using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coldairarrow.Util.Sockets;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace stock
{
    public partial class Form1 : Form
    {
        public bool isClientConnected = false;
        public bool isServerCreated = false;
        public event Action<byte[], SocketClient> AdditionHandleRecMsg;
        //从客户端发来的响应
        public byte[] client_Respond;
        public SocketServer server;
        public Form1()
        {
            InitializeComponent();
        }
        public static string GetMarketPrefix(string symbol)
        {
            if (symbol.Length == 5)
            {
                return "hk"; // 港股，传入的symbol应为5位
            }
            else if(symbol.StartsWith("6"))
            {
                return "sh"; // 上海股票
            }
            else if (symbol.StartsWith("0") || symbol.StartsWith("3"))
            {
                return "sz"; // 深圳股票
            }
            else if (symbol.StartsWith("5") || symbol.StartsWith("1"))
            {
                return "sz"; // 深圳基金
            }

            else
            {
                return "";
            }
        }
        private void btn_createServer_Click(object sender, EventArgs e)
        {
            //创建服务器对象，默认监听本机0.0.0.0，端口12345
            server = new SocketServer(Convert.ToInt32(txt_serverPort.Text));
            //处理从客户端收到的消息
            server.HandleRecMsg = new Action<byte[], SocketConnection, SocketServer>( async(bytes, client, theServer) =>
            {
                this.BeginInvoke(new Action(() =>
                {
                    log_console($"服务端收到消息:{BytesToString(bytes)}");
                    rtb_rsv_server.AppendText("recv:" + BytesToString(bytes) + "\n\r");
                }));
                // 处理客户端请求
                string requestJson = Encoding.UTF8.GetString(bytes);
                Console.WriteLine($"Received: {requestJson}");
                string symbol = "";
                // 解析JSON字符串
                try
                {
                    JObject inputObj = JObject.Parse(requestJson);
                    symbol = inputObj["parameters"]["symbol"].ToString();
                }
                catch
                {
                    log_console("无法解析输入的json字符串");
                    return;
                }

                //预处理去除股票代码中可能包含的其他字符
                // 定义正则表达式模式
                string pattern = @"\d+";

                // 创建Regex对象
                Regex regex = new Regex(pattern);

                // 使用Match方法查找第一个匹配项
                Match match = regex.Match(symbol);
                // 检查是否找到了匹配项
                if (match.Success)
                {
                    symbol = match.Value;
                }

                // 调用腾讯股票API获取实时股价
                string fix = GetMarketPrefix(symbol);
                string apiUrl = $"http://qt.gtimg.cn/q={fix}{symbol}";
                byte[] responseBytes=null;
                using (HttpClient clientHttp = new HttpClient())
                {
                    string response = await clientHttp.GetStringAsync(apiUrl);
                    try
                    {
                        // 解析返回结果
                        // 示例返回格式：v_sh601006="1~大秦铁路~601006~8.510~8.520~8.520~58200~49500~8700~8.500~90~8.490~131~8.480~56~8.470~27~8.460~30~8.520~1~8.530~1~8.540~11~8.550~3~8.560~2~15:09:48/8.510/10268/S/87505/11019|15:00:03/8.520/2780/B/23681/23681|";
                        string[] parts = response.Split('~');

                        string stockName = parts[1]; // 股票名称
                        double currentPrice = double.Parse(parts[3]); // 当前价格
                        double prevClosePrice = double.Parse(parts[4]); // 昨收
                        double openPrice = double.Parse(parts[5]); // 开盘价
                        double highPrice = double.Parse(parts[33]); // 最高价
                        double lowPrice = double.Parse(parts[34]); // 最低价
                        string dateTime = parts[30].Split('/')[0]; // 日期和时间


                        // 计算涨跌幅
                        double priceChange = currentPrice - prevClosePrice;
                        double priceChangePercent = (priceChange / prevClosePrice) * 100;

                        // 构建返回JSON
                        var result = new
                        {
                            name = stockName,
                            currentPrice = currentPrice,
                            highPrice = highPrice,
                            lowPrice = lowPrice,
                            dateTime = dateTime,
                            priceChange = priceChange,
                            priceChangePercent = priceChangePercent
                        };
                        string outputJson = JsonConvert.SerializeObject(result);
                        Console.WriteLine($"Sending: {outputJson}");

                        // 发送响应
                        responseBytes = Encoding.UTF8.GetBytes(outputJson);
                        client.Send(responseBytes);
                        this.BeginInvoke(new Action(() =>
                        {
                            rtb_rsv_server.AppendText("send:" + BytesToString(responseBytes) + "\n\r");

                        }));
                        log_console($"服务端发送消息:{BytesToString(responseBytes)}");
                    }
                    catch
                    {
                        client.Send("symbol not found");
                    }
                }
                client_Respond = bytes;


            });

            //处理服务器启动后事件
            server.HandleServerStarted = new Action<SocketServer>(theServer =>
            {
                log_console("stocktrack服务已经在TCP端口"+txt_serverPort.Text+"启动************");
                this.BeginInvoke(new Action(() =>
                {
                    btn_serverRunning.BackColor = Color.Green;
                    isServerCreated = true;
                }));
            });
            //处理新的客户端连接后的事件
            server.HandleNewClientConnected = new Action<SocketServer, SocketConnection>((theServer, theCon) =>
            {
                log_console($@"一个新的客户端接入，当前连接数：{theServer.GetConnectionCount()}");
                this.BeginInvoke(new Action(() =>
                {
                    btn_serverConnected.Text = theServer.GetConnectionCount().ToString();
                }));
            });

            //处理客户端连接关闭后的事件
            server.HandleClientClose = new Action<SocketConnection, SocketServer>((theCon, theServer) =>
            {
                log_console($@"一个客户端关闭，当前连接数为：{theServer.GetConnectionCount()}");
                this.BeginInvoke(new Action(() =>
                {
                    btn_serverConnected.Text = theServer.GetConnectionCount().ToString();
                }));
            });

            //处理异常
            server.HandleException = new Action<Exception>(ex =>
            {
                log_console(ex.Message);
            });

            //服务器启动
            server.StartServer();
        }
        //字符编码为byte数组
        private byte[] StringToBytes(string TheString)
        {
            Encoding FromEcoding = Encoding.GetEncoding("UTF-8");
            Encoding ToEcoding = Encoding.GetEncoding("GB2312");
            byte[] FromBytes = FromEcoding.GetBytes(TheString);
            byte[] ToBytes = Encoding.Convert(FromEcoding, ToEcoding, FromBytes);
            return ToBytes;
        }
        //将GB2312编码的byte数组转换为字符串
        private string BytesToString(byte[] Bytes)
        {
            string Mystring;
            Encoding ToEcoding = Encoding.GetEncoding("UTF-8");
            Mystring = ToEcoding.GetString(Bytes);
            return Mystring;
        }
        public void log_console(string strinput, bool isAddingNewLine = true)
        {
            string[] spliter = { "\n", "\r" };
            string[] lines = strinput.Split(spliter, StringSplitOptions.RemoveEmptyEntries);
            string s_NewLine = "";
            if (isAddingNewLine) s_NewLine = "\n";
            string time = DateTime.Now.ToString("HH:mm:ss.fff");
            this.BeginInvoke(new Action(() =>
            {
                foreach (string str in lines)
                {
                    string str_proceeded = Regex.Replace(str, @"[\p{C}]", " ");
                    rtb_consolelog.AppendText("[" + time + "] " + str_proceeded + s_NewLine);
                    rtb_consolelog.SelectionStart = rtb_consolelog.TextLength;
                    rtb_consolelog.ScrollCaret();
                }

            }));
        }
        public SocketClient client;
        private void btn_connect_Click(object sender, EventArgs e)
        {
            //创建客户端对象，默认连接本机127.0.0.1,端口为12345
            if (txt_clientAddr.Text == "")
            {
                client = new SocketClient(Convert.ToInt32(txt_clientPort.Text));
            }
            else
            {
                client = new SocketClient(txt_clientAddr.Text, Convert.ToInt32(txt_clientPort.Text));

            }

            client.HandleClientStarted = new Action<SocketClient>(theClient =>
            {
                log_console("成功连接到服务器************");
                this.BeginInvoke(new Action(() =>
                {
                    isClientConnected = true;
                    btn_clientConnected.BackColor = Color.Green;
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

                    log_console($"客户端收到消息:{BytesToString(bytes)}");
                    rtb_rsv_client.AppendText("recv:" + BytesToString(bytes) + "\n\r");


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
                log_console("与服务器的连接已中断**");
                this.BeginInvoke(new Action(() =>
                {
                    btn_clientConnected.BackColor = Color.Gray;
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rtb_consolelog.Text = "";
            rtb_rsv_client.Text = "";
            rtb_rsv_server.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtb_consolelog.Styles[ScintillaNET.Style.Default].Font = "Consolas";
            rtb_consolelog.Styles[ScintillaNET.Style.Default].SizeF = 10;
            GetNetworkInfomation();
            btn_createServer_Click(sender, e);
        }
        private void GetNetworkInfomation()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();




            foreach (NetworkInterface adapter in adapters)
            {
                // 如果适配器支持IPv4并且不是虚拟适配器
                if (adapter.Supports(NetworkInterfaceComponent.IPv4) && !adapter.Description.Contains("Virtual"))
                {
                    // 获取IP属性
                    IPInterfaceProperties ipProperties = adapter.GetIPProperties();




                    // 获取IPv4地址集
                    UnicastIPAddressInformationCollection addresses = ipProperties.UnicastAddresses;

                    foreach (UnicastIPAddressInformation address in addresses)
                    {
                        // 如果该地址是IPv4并且不是环回地址，则打印它
                        if (address.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && !IPAddress.IsLoopback(address.Address))
                        {
                            log_console("设备名:" + adapter.Name + ", " + "IP地址: " + address.Address.ToString());
                        }
                    }
                }
            }

        }

        public void btn_send_Click(object sender, EventArgs e)
        {
            byte[] b_send;

            Encoding FromEcoding = Encoding.GetEncoding("UTF-8");
            b_send = FromEcoding.GetBytes(txt_send_client.Text);

            if (isClientConnected)
            {
                client.Send(b_send);
                log_console($"向服务端发送消息:{BytesToString(b_send)}");

            }
            rtb_rsv_client.AppendText("send:"+BytesToString(b_send)+"\n\r");


        }

        private void btn_send_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_send_server_Click(object sender, EventArgs e)
        {
            byte[] b_send;

            Encoding FromEcoding = Encoding.GetEncoding("UTF-8");
            b_send = FromEcoding.GetBytes(txt_send_server.Text);

            if (isServerCreated)
            {
                foreach (SocketConnection sc in server.GetConnectionList())
                {
                    sc.Send(b_send);
                }
                log_console($"向客户端广播消息:{BytesToString(b_send)}");
                rtb_rsv_server.AppendText("send:" + BytesToString(b_send) + "\n\r");
            }
        }
    }
}
