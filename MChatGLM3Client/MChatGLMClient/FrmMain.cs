using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls;
using HZH_Controls.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Coldairarrow.Util.Sockets;
using System.Drawing;

namespace ChatGLMClient
{
    public partial class FrmMain : FrmWithTitle
    {
        public event Action<byte[], SocketClient> AdditionHandleRecMsg;
        string history = "  ";
        private string apiAddress = "";//api地址全局变量
        string result = "";//存储流式数据返回的新结果
        bool DetectConnection = false;
        string url = "";
        string APIKey = "fk217829-RgH5ZK9TJbsAYyelB9iQF8VSlAdcNM4P";

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        private static extern bool SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        // Constants for SetWindowLong
        public const int GWL_STYLE = -16;
        public const int WS_VISIBLE = 0x10000000;
        // API declaration for SetWindowLong
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        // API declaration for MoveWindow
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        // Windows API函数声明
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr GetDesktopWindow();
        // Windows API函数声明
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr GetParent(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);
        // 导入Windows API函数
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.serverAddress)) ucTextBoxExAPI.InputText = Properties.Settings.Default.serverAddress;
            ucAutoConnect.Checked = Properties.Settings.Default.autoConnect;
            string percision = Properties.Settings.Default.percision;
            //将API地址窗口输入的值赋值给全局apiAddress变量
            apiAddress = ucTextBoxExAPI.InputText;
            //初始化各窗口右键菜单
            InitRichTextBoxContextMenu(richTextBoxQuestion, false);
            InitRichTextBoxContextMenu(richTextBoxAnswer, true);

            if (ucAutoConnect.Checked == true)
            {
                ucb_Connect_BtnClick(percision, e);
                DetectConnection = true;
            }
            url = ucTextBoxExAPI.InputText + "/v1/chat/completions";
        }
        bool b_stop = false;
        private async void StopPredict()
        {
            b_stop = true;
        }

        public class GPTMessage
        {
            public GPTMessage(string author,string content)
            {
                this.role = author;
                this.content = content;
            }
            public string role { get; set; }
            public string content { get; set; }
        }

        
        public class GPTMessage_ToolChain
        {
            public GPTMessage_ToolChain()
            {
                this.role = "system";
                this.content = "Answer the following questions as best as you can. You have access to the following tools:";
                List<object> Tools = new List<object>();
                Tools.Add(new ChatGLMClient.ToolChain.StockTrack());
                tools = Tools;
            }
            public string role { get; set; }
            public string content { get; set; }
            public object tools { get; set; }

        }
        public List<object> GPTMessageList = new List<object>();
        private async void GLMSend(string str,string role="user")
        {
            DetectConnection = false;
            history="";
            string s_requirefunctionCall = "";
            //添加工具链声明
            if (ucSwitchTool.Checked)
            {
                AppendGPTMessageToList(new GPTMessage_ToolChain());
                s_requirefunctionCall = @", ""return_function_call"":""True"""; ;
            }
            AppendGPTMessageToList(new GPTMessage(role, str));            
            string messagesjson = "";
            messagesjson = JsonConvert.SerializeObject(GPTMessageList);
            string model = "gpt-3.5-turbo";
            try
            {
                string postdata = @"{""model"": """ + model +
                @""", ""top_p"":" + ucTrackBarTopp.Value +
                @", ""temperature"":" + ucTrackBarTemp.Value +
                @", ""max_tokens"":" + ucTrackBarMaxTokens.Value +
                @", ""stream"":false" +
                s_requirefunctionCall +
                @", ""messages"":" + messagesjson +
                @"}";
                HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
                request.Method = "POST";
                request.Headers = new WebHeaderCollection{
                    { "Authorization", $"Bearer {APIKey}" }
                };
                request.ContentType = "application/json";
                byte[] data = Encoding.UTF8.GetBytes(postdata);

                request.ContentLength = data.Length;
                using (Stream reqStream = request.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
                ucb_status.BtnText = "推理中";
                ucb_status.BtnForeColor = System.Drawing.Color.Blue;
                HttpWebResponse resp = (HttpWebResponse)await request.GetResponseAsync().ConfigureAwait(false);
                Stream stream = resp.GetResponseStream();

                //获取响应内容
                string result = "";
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
                JObject jo = JsonConvert.DeserializeObject<JObject>(result);
                var message = jo["choices"][0]["message"]["content"].ToString();

                if (!message.ToString().StartsWith("{"))
                { 
                    history = message.ToString();
                    AppendGPTMessageToList(new GPTMessage("assistant", history));
                    this.Invoke((EventHandler)(delegate
                    {
                        richTextBoxAnswer.AppendText(message.ToString());
                        richTextBoxAnswer.AppendText("\n---------------------------------------------------------------------------------------------\n");
                        ucb_status.BtnText = "空闲";
                        ucb_status.BtnForeColor = System.Drawing.Color.Green;
                        richTextBoxQuestion.Focus();
                    }));
                }else
                {
                    // 尝试再次解析字符串为 JObject
                    try
                    {
                        JObject toolrequest = JObject.Parse(message.ToString());
                        if (toolrequest.ContainsKey("name"))
                        {
                            if (toolrequest["name"].ToString() == "stocktrack")
                            {
                                byte[] b_send;
                                Encoding FromEcoding = Encoding.GetEncoding("UTF-8");
                                b_send = FromEcoding.GetBytes(message.ToString());
                                //发送到工具链
                                if (isClientConnected)
                                {
                                    client.Send(b_send);
                                }
                                history = message.ToString();
                            }
                        }
                    }
                    catch (JsonReaderException)
                    {
                        message = "工具链请求对象解析错误";
                    }
                    this.Invoke((EventHandler)(delegate
                    {
                        richTextBoxAnswer.AppendText("正在查询");
                        richTextBoxAnswer.AppendText("\n---------------------------------------------------------------------------------------------\n");
                        ucb_status.BtnText = "空闲";
                        ucb_status.BtnForeColor = System.Drawing.Color.Green;
                        richTextBoxQuestion.Focus();
                    }));

                }
            }
            catch (Exception ex)
            {
                this.Invoke((EventHandler)(delegate
                {
                    richTextBoxAnswer.AppendText("\n-API连接失败------------------------------------------------------------------------\n");
                    //richTextBoxAnswer.AppendText(ex.StackTrace+"ex\n");
                }));
                //MessageBox.Show("API连接失败\n" + ex.Message);
            }
            if (string.IsNullOrEmpty(history)) GPTMessageList.RemoveAt(GPTMessageList.Count - 1);
            else
            {
                AppendGPTMessageToList(new GPTMessage("assistant", history));
            }

            DetectConnection = true;
        }
        void AppendGPTMessageToList(Object gptmessage)
        {
            GPTMessageList.Add(gptmessage);
            //// 使用 StreamWriter 追加文本
            string jsonString = JsonConvert.SerializeObject(gptmessage);
            using (StreamWriter sw = File.AppendText(Application.StartupPath + "\\data\\chatlog.json"))
            {
                sw.WriteLine(jsonString);
            }
        }
        private async Task GLMSendStream(string str)
        {
            GPTMessageList.Add(new GPTMessage("user", str));
            history = "";
            string messagesjson = "";
            messagesjson = JsonConvert.SerializeObject(GPTMessageList);
            string model = "gpt-3.5-turbo";
            string postdata = @"{""model"": """ + model +
            @""", ""top_p"":" + ucTrackBarTopp.Value +
            @", ""temperature"":" + ucTrackBarTemp.Value +
            @", ""max_tokens"":" + ucTrackBarMaxTokens.Value +
            @", ""stream"":true"+
            @", ""messages"":" + messagesjson +
            @"}";
            // 创建一个 HttpClient 实例
            var httpClient = new HttpClient();
            var postData = new StringContent(postdata, Encoding.UTF8, "application/json");
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url) { Content = postData };
            request.Method = HttpMethod.Post;

            request.Headers.Add("Authorization", $"Bearer {APIKey}");
            // 发送 POST 请求
            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            ucb_status.BtnText = "推理中";
            ucb_status.BtnForeColor = System.Drawing.Color.Blue;
            Application.DoEvents();
            Stream stream = await response.Content.ReadAsStreamAsync();
            var streamReader = new StreamReader(stream, Encoding.UTF8);

            // 读取数据流
            char[] buffer = new char[100000];
            int bytesRead;
            richTextBoxAnswer.AppendText("回答：");
            while ((bytesRead = await streamReader.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                if (b_stop) break;
                try
                {
                    string jsonresult = new string(buffer, 0, bytesRead);
                    if (jsonresult != null)
                    {
                        //jsonresult = jsonresult.Replace("data:", "");//去掉SSE通信开头的data：

                        // 使用正则表达式来匹配JSON字符串
                        string pattern = @"\{.*?\}";
                        MatchCollection matches = Regex.Matches(jsonresult, pattern, RegexOptions.Singleline);

                        // 打印拆分后的JSON字符串
                        foreach (Match match in matches)
                        {
                            string subvalue = match.Value; 
                            JObject jo = JsonConvert.DeserializeObject<JObject>(subvalue);
                            try
                            {
                                object message=null;
                                if (jo.ContainsKey("choices"))
                                { 
                                    message = jo["choices"][0]["delta"]["content"];
                                }else if (jo.ContainsKey("delta"))
                                {
                                    message = jo["delta"]["content"];
                                }
                                if (message == null) continue;
                                result = message.ToString(); //提取response键值
                                Debug.Write(result + "\n");
                                this.Invoke((EventHandler)(delegate
                                {
                                    richTextBoxAnswer.AppendText(result);
                                }));
                                history = history+ message.ToString();

                            }
                            catch { }
                        }


                    }
                }
                catch (Exception ee)
                { }

                await Task.Delay(50);
            }
            if (string.IsNullOrEmpty(history)) GPTMessageList.RemoveAt(GPTMessageList.Count - 1);
            else
            {
                AppendGPTMessageToList(new GPTMessage("assistant", history));
            }

            this.Invoke((EventHandler)(delegate
            {
                richTextBoxAnswer.AppendText("\n---------------------------------------------------------------------------------------------\n");
                ucb_status.BtnText = "空闲";
                ucb_status.BtnForeColor = System.Drawing.Color.Green;
                richTextBoxQuestion.Focus();
            }));

        }

        private void ucTrackBarMaxTokens_ValueChanged(object sender, EventArgs e)
        {
            labelMaxTokens.Text = ucTrackBarMaxTokens.Value.ToString();
        }

        private void ucTrackBarTemp_ValueChanged(object sender, EventArgs e)
        {
            labelTemp.Text = ucTrackBarTemp.Value.ToString();
        }

        private void ucTrackBarTopp_ValueChanged(object sender, EventArgs e)
        {
            labelTopp.Text = ucTrackBarTopp.Value.ToString();
        }

        private async void ucBtnImgSend_BtnClick(object sender, EventArgs e)
        {
            b_stop = false;
            string question = richTextBoxQuestion.Text; //获取问题框中的文字作为问题
            this.Invoke((EventHandler)(delegate
            {
                richTextBoxAnswer.AppendText("发送：" + question + "\n"); //将问题写入到答案框，并加上开头
                richTextBoxQuestion.Clear(); //清空问题框
                ucb_status.BtnText = "发送中";
                ucb_status.BtnForeColor = System.Drawing.Color.Yellow;
            }));

            try
            {
                if (ucSwitchStream.Checked) //根据是否选择文字流来处理答案
                {
                    await GLMSendStream(question.Replace("\n", "<br>")); //流式GLM问题函数,将\n转为<br>否则服务器会报错
                }
                else GLMSend(question.Replace("\n", "<br>")); //非流式GLM问答函数，将\n转为<br>否则服务器会报错
                this.Invoke((EventHandler)(delegate
                {
                    ucb_status.BtnForeColor = System.Drawing.Color.Green;
                }));
            }
            catch
            {
                richTextBoxAnswer.Text = "发送失败";
            }
        }

        private void ucBtnImgClear_BtnClick(object sender, EventArgs e)
        {
            richTextBoxAnswer.Clear();
            GPTMessageList.Clear();
            // 读取 JSON 文件内容
            string json_chat = File.ReadAllText(Application.StartupPath + "\\Prompt\\chat3.json");
            List<GPTMessage> list = JsonConvert.DeserializeObject<List<GPTMessage>>(json_chat);
            foreach (GPTMessage gptm in list)
            {
                GPTMessageList.Add(gptm);
            }
        }

        private void richTextBoxAnswer_TextChanged(object sender, EventArgs e)
        {
            richTextBoxAnswer.SelectionStart = richTextBoxAnswer.Text.Length;
            richTextBoxAnswer.SelectionLength = 0;
            richTextBoxAnswer.Focus();
        }

        private void ucTextBoxExAPI_Leave(object sender, EventArgs e)
        {
            apiAddress = ucTextBoxExAPI.InputText;
            Properties.Settings.Default.serverAddress = ucTextBoxExAPI.Text;
            Properties.Settings.Default.Save();
        }

        private void InitRichTextBoxContextMenu(RichTextBox textBox, bool read_only)
        {

            var contextMenu = new ContextMenu();
            //创建复制子菜单
            var copyMenuItem = new System.Windows.Forms.MenuItem("复制");
            copyMenuItem.Click += (sender, eventArgs) => textBox.Copy();
            contextMenu.MenuItems.Add(copyMenuItem);

            if (read_only == false)
            {
                //创建剪切子菜单
                var cutMenuItem = new System.Windows.Forms.MenuItem("剪切");
                cutMenuItem.Click += (sender, eventArgs) => textBox.Cut();


                //创建粘贴子菜单
                var pasteMenuItem = new System.Windows.Forms.MenuItem("粘贴");
                pasteMenuItem.Click += (sender, eventArgs) => textBox.Paste();

                //创建右键菜单并将子菜单加入到右键菜单中
                contextMenu.MenuItems.Add(cutMenuItem);
                contextMenu.MenuItems.Add(pasteMenuItem);
            }
            textBox.ContextMenu = contextMenu;
        }
        Process process = null;

        private async void ucb_Connect_BtnClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.percision = sender.ToString();
            Properties.Settings.Default.Save();

            if (process != null && !process.HasExited) return;
            ucb_connectstatus.BtnText = "启动中";
            ucb_connectstatus.BtnForeColor = System.Drawing.Color.Blue;
            // 创建一个进程启动信息对象
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "runAPI_cpu.bat";
            ucb_mode.BtnText = "CPU";
            if (sender.ToString() == "fp16")
            {
                startInfo.FileName = "runAPI_fp16.bat";
                ucb_mode.BtnText = "fp16";
            }
            if (sender.ToString() == "int8")
            {
                startInfo.FileName = "runAPI_int8.bat";
                ucb_mode.BtnText = "int8";
            }
            if (sender.ToString() == "int4")
            {
                startInfo.FileName = "runAPI_int4.bat";
                ucb_mode.BtnText = "int4";
            }
            if (sender.ToString() == "fp16-双卡")
            {
                startInfo.FileName = "runAPI_fp16_dualcard.bat";
                ucb_mode.BtnText = "双卡";
            }
            startInfo.UseShellExecute = true;
            startInfo.RedirectStandardOutput = false;
            process = new Process();
            process.StartInfo = startInfo;
            process.Start();
            //等待程序启动
            await Task.Delay(1000);
            //窗口重新置顶
            this.Activate();
            DetectConnection = true;
            Bnt_startmonitorStatus_Click(sender, e);
            for(; ; )
            {
                if (ucb_connectstatus.BtnText == "已连接")
                {
                    // 读取 JSON 文件内容
                    string json_chat = File.ReadAllText(Application.StartupPath + "\\Prompt\\chat3.json");
                    List<GPTMessage> list= JsonConvert.DeserializeObject<List<GPTMessage>>(json_chat);
                    foreach (GPTMessage gptm in list)
                    {
                        GPTMessageList.Add(gptm);
                    }
                    ucb_status.BtnText = "初始化";
                    return;
                }
                await Task.Delay(100);
            }
            url = ucTextBoxExAPI.InputText + "/v1/chat/completions";
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.autoConnect = ucAutoConnect.Checked;
            Properties.Settings.Default.serverAddress = ucTextBoxExAPI.InputText;
            Properties.Settings.Default.Save();
            try
            {
                if (process != null)
                {
                    process.CloseMainWindow();
                    process.Kill();
                }
            }
            catch { }
        }

        private async void Bnt_startmonitorStatus_Click(object sender, EventArgs e)
        {
            // 创建一个 HttpClient 实例
            var httpClient = new HttpClient();
            //htpp 设置 300ms超时
            httpClient.Timeout = new TimeSpan(0, 0, 0, 0, 1000);
            HttpResponseMessage res = new HttpResponseMessage();
            for (; ; )
            {
                if (DetectConnection)
                {
                    //程序断开
                    if (process != null && process.HasExited)
                    {
                        // 连接成功
                        ucb_connectstatus.BtnText = "已断开";
                        ucb_connectstatus.BtnForeColor = System.Drawing.Color.Blue;
                        return;
                    }
                    try
                    {
                        res = await httpClient.GetAsync(ucTextBoxExAPI.InputText+"/status");
                        if (res.IsSuccessStatusCode)
                        {
                            // 连接成功
                            ucb_connectstatus.BtnText = "已连接";
                            ucb_connectstatus.BtnForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            // 连接失败
                            ucb_connectstatus.BtnText = "错误";
                            ucb_connectstatus.BtnForeColor = System.Drawing.Color.Red;
                        }
                    }
                    catch(Exception ee)
                    {
                        // 连接失败
                        ucb_connectstatus.BtnText = "连接中";
                        ucb_connectstatus.BtnForeColor = System.Drawing.Color.Blue;
                    }
                }
                await Task.Delay(500);
            }

        }

        private void ucBtnImgStop_BtnClick(object sender, EventArgs e)
        {
            StopPredict();
        }

        private void ucAutoConnect_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ucSwitchStream_CheckedChanged(object sender, EventArgs e)
        {
            if(ucSwitchStream.Checked)
            {
                ucSwitchTool.Checked = false;
                ucBtnImgClear_BtnClick(sender, e);
            }
        }

        private async void ucBtnImgSendExt_BtnClick(object sender, EventArgs e)
        {
            ucb_mode.BtnText = "外部";
            url = ucTextBoxExAPIExt.InputText;
            //b_stop = false;
            //string question = richTextBoxQuestion.Text; //获取问题框中的文字作为问题
            //this.Invoke((EventHandler)(delegate
            //{
            //    richTextBoxAnswer.AppendText("发送：" + question + "\n"); //将问题写入到答案框，并加上开头
            //    richTextBoxQuestion.Clear(); //清空问题框
            //    ucb_status.BtnText = "发送中";
            //    ucb_status.BtnForeColor = System.Drawing.Color.Yellow;
            //}));

            //if (ucSwitchStream.Checked) //根据是否选择文字流来处理答案
            //{
            //    await GLMSendStream(question.Replace("\n", "<br>")); //流式GLM问题函数,将\n转为<br>否则服务器会报错
            //}
            //else GLMSend(question.Replace("\n", "<br>")); //非流式GLM问答函数，将\n转为<br>否则服务器会报错
            //this.Invoke((EventHandler)(delegate
            //{
            //    ucb_status.BtnForeColor = System.Drawing.Color.Green;
            //}));
        }
        Process stockplug = null;
        private async void ucSwitchTool_CheckedChanged(object sender, EventArgs e)
        {
            // 获取当前所有正在运行的进程
            Process[] processes = Process.GetProcesses();

            // 遍历所有进程，查找名为"stocktrack"的进程
            foreach (Process process in processes)
            {
                if (process.ProcessName.ToLower() == "stocktrack")
                {
                    // 找到进程后，终止它
                    process.Kill();
                    Console.WriteLine("进程已终止: " + process.ProcessName);
                }
            }
            GPTMessageList.Clear();
            if (ucSwitchTool.Checked)
            {
                ucSwitchStream.Checked=false;
                if (stockplug != null && !stockplug.HasExited) return;
                // 创建一个进程启动信息对象
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName =(Directory.GetParent(System.IO.Path.GetFullPath(Application.StartupPath)).ToString()+ "\\toolchain\\stocktrack.exe");
                startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(startInfo.FileName);
                startInfo.UseShellExecute = true; // ShellExecute
                startInfo.CreateNoWindow = true; // 不创建外部窗口
                stockplug = new Process();
                stockplug.StartInfo = startInfo;
                stockplug.Start();
                IntPtr consoleHandle = IntPtr.Zero;
                IntPtr desktopWindowHandle = GetDesktopWindow();
                //等待程序启动
                for (; ; )
                {
                    IntPtr cmdhandle = stockplug.MainWindowHandle;
                    if (cmdhandle != IntPtr.Zero)
                    {
                        consoleHandle = cmdhandle;
                        break;
                    }
                    await Task.Delay(1);
                    // 获取控制台窗口句柄并嵌入到Panel中
                }
                SetParent(consoleHandle, pan_toolchain.Handle);
                // Remove border and whatnot

                SetWindowLong(consoleHandle, GWL_STYLE, WS_VISIBLE);

                // Move the window to overlay it on this window
                MoveWindow(consoleHandle, 0, 0, pan_toolchain.Width + 17, pan_toolchain.Height, true);
                btn_connectstock_Click(sender, e);
            }
            else
            {
                try
                {
                    if (stockplug == null) return;
                    stockplug.CloseMainWindow();
                    stockplug.Kill();
                    btn_disconnect_Click(sender, e);
                }
                catch { }
            }
        }

        public bool isClientConnected = false;
        public SocketClient client;
        private void btn_connectstock_Click(object sender, EventArgs e)
        {
            //创建客户端对象，默认连接本机127.0.0.1,端口为12345
            if (txt_clientAddr.Text == "")
            {
                client = new SocketClient(Convert.ToInt32(txt_clientPort.InputText));
            }
            else
            {
                client = new SocketClient(txt_clientAddr.Text, Convert.ToInt32(txt_clientPort.InputText));

            }

            client.HandleClientStarted = new Action<SocketClient>(theClient =>
            {
                this.BeginInvoke(new Action(() =>
                {
                    isClientConnected = true;
                    btn_clientConnected.BtnForeColor = Color.Green;
                }));
                this.BeginInvoke(new Action(() =>
                {
                    ////发送心跳包
                    //frm_echo.btn_cmd01_Click(sender, e);
                    //Application.DoEvents();
                    //btn_send_Click(sender, e);
                }));
            });
            //绑定当收到服务器发送的消息后的处理事件
            client.HandleRecMsg += new Action<byte[], SocketClient>((bytes, theClient) =>
            {
                string msg = Encoding.UTF8.GetString(bytes);

                this.BeginInvoke(new Action(() =>
                {
                    //收到工具链服务的回送信息
                    GLMSend(msg, "observation");

                }));
                if (AdditionHandleRecMsg != null) AdditionHandleRecMsg(bytes, theClient);
            });

            //绑定向服务器发送消息后的处理事件
            client.HandleSendMsg = new Action<byte[], SocketClient>((bytes, theClient) =>
            {
                //string msg = Encoding.UTF8.GetString(bytes);
                //log_console($"向服务器发送消息:{msg}");

            });
            client.HandleClientClose = new Action<SocketClient>(theClient =>
            {
                this.BeginInvoke(new Action(() =>
                {
                    btn_clientConnected.BtnForeColor = Color.LightGray;
                    isClientConnected = false;
                }));
            });
            //开始运行客户端
            client.StartClient();
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            client.Close();
        }

        private void ucExternalModel_CheckedChanged(object sender, EventArgs e)
        {
            if (ucExternalModel.Checked)
            {
                ucb_mode.BtnText = "外部";
                url = ucTextBoxExAPIExt.InputText;
            }else
            {
                ucb_mode.BtnText = "本地";
                url = ucTextBoxExAPI.InputText + "/v1/chat/completions";
            }
        }
    }
}
