# coding=utf-8
# Implements API for ChatGLM3-6B in OpenAI's format. (https://platform.openai.com/docs/api-reference/chat)
# Usage: python openai_api.py
# Visit http://localhost:8000/docs for documents.


import json
import time
from contextlib import asynccontextmanager
from typing import List, Literal, Optional, Union

import torch
import uvicorn
from fastapi import FastAPI, HTTPException
from fastapi.middleware.cors import CORSMiddleware
from pydantic import BaseModel, Field
from sse_starlette.sse import EventSourceResponse
from transformers import AutoTokenizer, AutoModel

from utils import process_response, generate_chatglm3, generate_stream_chatglm3

from options import parser
import os

import logging


from utils import load_model_on_gpus
cmd_opts = parser.parse_args()

global status
status = "空闲"


@asynccontextmanager
async def lifespan(app: FastAPI):  # collects GPU memory
    yield
    if torch.cuda.is_available():
        torch.cuda.empty_cache()
        torch.cuda.ipc_collect()


app = FastAPI(lifespan=lifespan)

app.add_middleware(
    CORSMiddleware,
    allow_origins=["*"],
    allow_credentials=True,
    allow_methods=["*"],
    allow_headers=["*"],
)


class ModelCard(BaseModel):
    id: str
    object: str = "model"
    created: int = Field(default_factory=lambda: int(time.time()))
    owned_by: str = "owner"
    root: Optional[str] = None
    parent: Optional[str] = None
    permission: Optional[list] = None


class ModelList(BaseModel):
    object: str = "list"
    data: List[ModelCard] = []


class ChatMessage(BaseModel):
    role: Literal["user", "assistant", "system", "observation"]
    content: str = None
    metadata: Optional[str] = None
    tools: Optional[List[dict]] = None


class DeltaMessage(BaseModel):
    role: Optional[Literal["user", "assistant", "system"]] = None
    content: Optional[str] = None


class ChatCompletionRequest(BaseModel):
    model: str
    messages: List[ChatMessage]
    temperature: Optional[float] = 0.7
    top_p: Optional[float] = 1.0
    max_tokens: Optional[int] = None
    stop: Optional[Union[str, List[str]]] = None
    stream: Optional[bool] = False

    # Additional parameters support for stop generation
    stop_token_ids: Optional[List[int]] = None
    repetition_penalty: Optional[float] = 1.1

    # Additional parameters supported by tools
    return_function_call: Optional[bool] = False


class ChatCompletionResponseChoice(BaseModel):
    index: int
    message: ChatMessage
    finish_reason: Literal["stop", "length", "function_call"]
    history: Optional[List[dict]] = None


class ChatCompletionResponseStreamChoice(BaseModel):
    index: int
    delta: DeltaMessage
    finish_reason: Optional[Literal["stop", "length"]]


class UsageInfo(BaseModel):
    prompt_tokens: int = 0
    total_tokens: int = 0
    completion_tokens: Optional[int] = 0


class ChatCompletionResponse(BaseModel):
    model: str
    object: Literal["chat.completion", "chat.completion.chunk"]
    choices: List[Union[ChatCompletionResponseChoice, ChatCompletionResponseStreamChoice]]
    created: Optional[int] = Field(default_factory=lambda: int(time.time()))
    usage: Optional[UsageInfo] = None


@app.get("/v1/models", response_model=ModelList)
async def list_models():
    model_card = ModelCard(id="gpt-3.5-turbo")
    return ModelList(data=[model_card])


@app.post("/v1/chat/completions", response_model=ChatCompletionResponse)
async def create_chat_completion(request: ChatCompletionRequest):
    global model, tokenizer
    print (request)
    if request.messages[-1].role == "assistant":
        raise HTTPException(status_code=400, detail="Invalid request")

    with_function_call = bool(request.messages[0].role == "system" and request.messages[0].tools is not None)

    # stop settings
    request.stop = request.stop or []
    if isinstance(request.stop, str):
        request.stop = [request.stop]

    request.stop_token_ids = request.stop_token_ids or []

    gen_params = dict(
        messages=request.messages,
        temperature=request.temperature,
        top_p=request.top_p,
        max_tokens=request.max_tokens or 1024,
        echo=False,
        stream=request.stream,
        stop_token_ids=request.stop_token_ids,
        stop=request.stop,
        repetition_penalty=request.repetition_penalty,
        with_function_call=with_function_call,
    )
    global status
    status = "推理中"

    if request.stream:
        generate = predict(request.model, gen_params)
        return EventSourceResponse(generate, media_type="text/event-stream")

    response = generate_chatglm3(model, tokenizer, gen_params)
    usage = UsageInfo()

    finish_reason, history = "stop", None
    if with_function_call and request.return_function_call:
        history = [m.dict(exclude_none=True) for m in request.messages]
        content, history = process_response(response["text"], history)
        if isinstance(content, dict):
            message, finish_reason = ChatMessage(
                role="assistant",
                content=json.dumps(content, ensure_ascii=False),
            ), "function_call"
        else:
            message = ChatMessage(role="assistant", content=content)
    else:
        message = ChatMessage(role="assistant", content=response["text"])


    choice_data = ChatCompletionResponseChoice(
        index=0,
        message=message,
        finish_reason=finish_reason,
        history=history
    )

    # 定义颜色代码
    class Color:
        PURPLE = '\033[95m'
        CYAN = '\033[96m'
        DARKCYAN = '\033[36m'
        BLUE = '\033[94m'
        GREEN = '\033[92m'
        YELLOW = '\033[93m'
        RED = '\033[91m'
        BOLD = '\033[1m'
        UNDERLINE = '\033[4m'
        END = '\033[0m'

    # 打印彩色文字
    print(Color.RED + "Respond: " + Color.END)
    print(message)
    task_usage = UsageInfo.parse_obj(response["usage"])
    for usage_key, usage_value in task_usage.dict().items():
        setattr(usage, usage_key, getattr(usage, usage_key) + usage_value)

    status = "空闲"
    return ChatCompletionResponse(model=request.model, choices=[choice_data], object="chat.completion", usage=usage)

@app.get("/status")
async def root():
    return {"message": status}

async def predict(model_id: str, params: dict):
    global model, tokenizer

    choice_data = ChatCompletionResponseStreamChoice(
        index=0,
        delta=DeltaMessage(role="assistant"),
        finish_reason=None
    )
    chunk = ChatCompletionResponse(model=model_id, choices=[choice_data], object="chat.completion.chunk")
    yield "{}".format(chunk.json(exclude_unset=True, ensure_ascii=False))

    print("Stream respond:", end="")
    previous_text = ""
    for new_response in generate_stream_chatglm3(model, tokenizer, params):
        decoded_unicode = new_response["text"]
        delta_text = decoded_unicode[len(previous_text):]
        print(delta_text, end="")
        previous_text = decoded_unicode

        if len(delta_text) == 0:
            delta_text = None

        choice_data = ChatCompletionResponseStreamChoice(
            index=0,
            delta=DeltaMessage(content=delta_text),
            finish_reason=None
        )
        chunk = ChatCompletionResponse(model=model_id, choices=[choice_data], object="chat.completion.chunk")
        yield "{}".format(chunk.json(exclude_unset=True, ensure_ascii=False))
    print("")
    choice_data = ChatCompletionResponseStreamChoice(
        index=0,
        delta=DeltaMessage(),
        finish_reason="stop"
    )
    chunk = ChatCompletionResponse(model=model_id, choices=[choice_data], object="chat.completion.chunk")
    yield "{}".format(chunk.json(exclude_unset=True, ensure_ascii=False))
    yield '[DONE]'


if __name__ == "__main__":

    if cmd_opts.cpu:
        model = model.float()
    else:
        if cmd_opts.precision == "cpu":
            tokenizer = AutoTokenizer.from_pretrained(cmd_opts.model_path, trust_remote_code=True)
            model = AutoModel.from_pretrained(cmd_opts.model_path, trust_remote_code=True).float()
        elif cmd_opts.precision == "fp16":
            os.environ["CUDA_VISIBLE_DEVICES"] = cmd_opts.availablecard  # e.g. '1,"
            tokenizer = AutoTokenizer.from_pretrained(cmd_opts.model_path, trust_remote_code=True)
            model = load_model_on_gpus(cmd_opts.model_path, num_gpus=1)
        elif cmd_opts.precision == "fp16dual":
            os.environ["CUDA_VISIBLE_DEVICES"] = cmd_opts.availablecard  # e.g. '1,"
            tokenizer = AutoTokenizer.from_pretrained(cmd_opts.model_path, trust_remote_code=True)
            model = load_model_on_gpus(cmd_opts.model_path, num_gpus=2)
        elif cmd_opts.precision == "int4":
            os.environ["CUDA_VISIBLE_DEVICES"] = cmd_opts.availablecard  # e.g. '1,"
            tokenizer = AutoTokenizer.from_pretrained(cmd_opts.model_path, trust_remote_code=True)
            model = AutoModel.from_pretrained(cmd_opts.model_path, trust_remote_code=True).quantize(4).cuda()
            
        elif cmd_opts.precision == "int8":
            os.environ["CUDA_VISIBLE_DEVICES"] = cmd_opts.availablecard  # e.g. '1,"
            tokenizer = AutoTokenizer.from_pretrained(cmd_opts.model_path, trust_remote_code=True)
            model = AutoModel.from_pretrained(cmd_opts.model_path, trust_remote_code=True).quantize(8).cuda()


    model = model.eval()

    class DisableStatusLogFilter(logging.Filter):
        def filter(self, record: logging.LogRecord) -> bool:
            return "/status" not in (" ".join([str(s) for s in record.args]))


    logging.getLogger("uvicorn.access").addFilter(DisableStatusLogFilter())


    uvicorn.run(app, host='0.0.0.0', port=7860, workers=1)
