# coding=gbk
import os
import platform
import signal
from transformers import AutoTokenizer, AutoModel
import readline

tokenizer = AutoTokenizer.from_pretrained("model\models--THUDM--chatglm3-6b", trust_remote_code=True)
# model = AutoModel.from_pretrained("model\models--THUDM--chatglm3-6b", trust_remote_code=True).cuda()
# ���Կ�֧�֣�ʹ���������д�������һ�У���num_gpus��Ϊ��ʵ�ʵ��Կ�����
from utils import load_model_on_gpus
model = load_model_on_gpus("model\models--THUDM--chatglm3-6b", num_gpus=2)
model = model.eval()

os_name = platform.system()
clear_command = 'cls' if os_name == 'Windows' else 'clear'
stop_stream = False


def build_prompt(history):
    prompt = "��ӭʹ�� ChatGLM3-6B ģ�ͣ��������ݼ��ɽ��жԻ���clear ��նԻ���ʷ��stop ��ֹ����"
    for query, response in history:
        prompt += f"\n\n�û���{query}"
        prompt += f"\n\nChatGLM3-6B��{response}"
    return prompt


def signal_handler(signal, frame):
    global stop_stream
    stop_stream = True

tools = [{'name': 'track', 'description': '׷��ָ����Ʊ��ʵʱ�۸�', 'parameters': {'type': 'object', 'properties': {'symbol': {'description': '��Ҫ׷�ٵĹ�Ʊ����'}}, 'required': []}}, {'name': '/text-to-speech', 'description': '���ı�ת��Ϊ����', 'parameters': {'type': 'object', 'properties': {'text': {'description': '��Ҫת�����������ı�'}, 'voice': {'description': 'Ҫʹ�õ��������ͣ�������Ů���ȣ�'}, 'speed': {'description': '�������ٶȣ��졢�еȡ����ȣ�'}}, 'required': []}}, {'name': '/image_resizer', 'description': '����ͼƬ�Ĵ�С�ͳߴ�', 'parameters': {'type': 'object', 'properties': {'image_file': {'description': '��Ҫ������С��ͼƬ�ļ�'}, 'width': {'description': '��Ҫ�����Ŀ��ֵ'}, 'height': {'description': '��Ҫ�����ĸ߶�ֵ'}}, 'required': []}}, {'name': '/foodimg', 'description': 'ͨ��������ʳƷ�������ɸ�ʳƷ��ͼƬ', 'parameters': {'type': 'object', 'properties': {'food_name': {'description': '��Ҫ����ͼƬ��ʳƷ����'}}, 'required': []}}]
system_item = {"role": "system",
               "content": "Answer the following questions as best as you can. You have access to the following tools:",
               "tools": tools}

def main():
    # past_key_values, history = None, [system_item]
    # role = "user"
    # global stop_stream
    # print("��ӭʹ�� ChatGLM3-6B ģ�ͣ��������ݼ��ɽ��жԻ���clear ��նԻ���ʷ��stop ��ֹ����")
    # while True:
    #     query = input("\n�û���") if role == "user" else input("\n�����")
    #     if query.strip() == "stop":
    #         break
    #     if query.strip() == "clear":
    #         past_key_values, history = None,  [system_item]
    #         role = "user"
    #         os.system(clear_command)
    #         print("��ӭʹ�� ChatGLM3-6B ģ�ͣ��������ݼ��ɽ��жԻ���clear ��նԻ���ʷ��stop ��ֹ����")
    #         continue
    #     print("\nChatGLM��", end="")
    #     response, history = model.chat(tokenizer, query, history=history, role=role)
    #     print(response, end="", flush=True)
    #     print("")
    #     if isinstance(response, dict):
    #         role = "observation"

    history = [system_item]
    global stop_stream
    print("��ӭʹ�� ChatGLM-6B ģ�ͣ��������ݼ��ɽ��жԻ���clear ��նԻ���ʷ��stop ��ֹ����")
    while True:
        query = input("\n�û���")
        if query.strip() == "stop":
            break
        if query.strip() == "clear":
            history = []
            os.system(clear_command)
            print("��ӭʹ�� ChatGLM-6B ģ�ͣ��������ݼ��ɽ��жԻ���clear ��նԻ���ʷ��stop ��ֹ����")
            continue
        count = 0
        for response, history in model.stream_chat(tokenizer, query, history=history):
            if stop_stream:
                stop_stream = False
                break
            else:
                count += 1
                if count % 8 == 0:
                    os.system(clear_command)
                    print(build_prompt(history), flush=True)
                    signal.signal(signal.SIGINT, signal_handler)
        os.system(clear_command)
        print(build_prompt(history), flush=True)

if __name__ == "__main__":
    main()