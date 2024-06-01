完整访问地址：http://127.0.0.1:7860/v1/chat/completions
地址栏输入地址：http://127.0.0.1:7860


工具链调用约定：采用socket+json方式，工具插件发送一个json字符串，返回一个json字符串，格式如下：

使用工具链前需要配置prmpt的messages

例子：

tools = [
    {
        "name": "track",
        "description": "追踪指定股票的实时价格",
        "parameters": {
            "type": "object",
            "properties": {
                "symbol": {
                    "description": "需要追踪的股票代码"
                }
            },
            "required": ['symbol']
        }
    }
]

system_info = {
    "role": "system",
    "content": "Answer the following questions as best as you can. You have access to the following tools:",
    "tools": list(tools.values()),
}

messages = [
    system_info,
    {
        "role": "user",
        "content": "帮我查询代码为601398的股票价格",
    }
]

    response = openai.ChatCompletion.create(
        model="chatglm3",
        messages=messages,
        temperature=0,
        return_function_call=True
    )


单参数
llm发送： {"name": "track", "parameters": {"symbol": "601398"}}
插件返回：{"price": 12412}


多参数

llm发送： {'name': 'get_weather', 'parameters': {'city_name': '北京'}}
插件返回：{'current_condition': {'temp_C': '29', 'FeelsLikeC': '27', 'humidity': '25', 'weatherDesc': [{'value': 'Sunny'}], 'observation_time': '07:59 AM'}}