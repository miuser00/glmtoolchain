using Coldairarrow.Util.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPServer
{
    public partial class Upgrade_ServerSide : Form
    {
        Form1 frm_main = null;
        byte[] firmware_bin;
        public Upgrade_ServerSide(Form1 frm)
        {
            frm_main = frm;
            InitializeComponent();

        }

        private void btn_browserfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            // 设置文件对话框的标题
            openFileDialog.Title = "选择要打开的固件文件";


            // 设置文件对话框的过滤器，只允许选择 hex 文件
            openFileDialog.Filter = "Hex 文件 (*.hex)|*.hex|所有文件 (*.*)|*.*";

            // 显示文件对话框
            DialogResult result = openFileDialog.ShowDialog();

            // 检查用户是否点击了 "打开" 按钮
            if (result == DialogResult.OK)
            {
                try
                {
                    // 获取用户选择的文件名
                    string selectedFileName = openFileDialog.FileName;
                    firmware_bin = ParseIntelHexFile(selectedFileName);
                }
                catch (Exception ex)
                {
                    // 捕获并显示任何异常信息
                    Console.WriteLine($"出现错误：{ex.Message}");
                }
            }
        }
        private void OTA_SendInitalizePackage()
        {
            int packagecount = (int)Math.Ceiling((double)firmware_bin.Length / 490);
            //发送OTA首包，发送报文信息，长度=24字节 
            byte[] ota_fistPack = new byte[24];//最终发送的数据包，<=512字节
            ota_fistPack[0] = 0x68; //startflag
            ota_fistPack[1] = 00; //len 2bytes
            ota_fistPack[2] = 20; //len
            ota_fistPack[3] = 0x68;//startflag
            ota_fistPack[4] = 0x00;//address 8
            ota_fistPack[5] = 0x00;//address 7
            ota_fistPack[6] = 0x00;//address 6
            ota_fistPack[7] = 0x00;//address 5
            ota_fistPack[8] = 0x00;//address 4
            ota_fistPack[9] = 0x00;//address 3
            ota_fistPack[10] = 0x00;//address 2
            ota_fistPack[11] = 0x00;//address 1
            //AFN
            ota_fistPack[12] = 0x08; // AFN=8
            //dir
            ota_fistPack[13] = 0x01;//dir:1 from cloud
            //package sequence
            ota_fistPack[14] = 0x00;//inital pack 2bytes 
            ota_fistPack[15] = 0x00;
            ota_fistPack[16] = 0x01; //first package 1bytes=1
            ota_fistPack[17] = (byte)(packagecount >> 8 & 0xff); //last package 2bytes
            ota_fistPack[18] = (byte)(packagecount & 0xff);
            ota_fistPack[19] = (byte)(packagecount >> 8 & 0xff); //package len 2bytes
            ota_fistPack[20] = (byte)(packagecount & 0xff);

            //crc16
            byte[] data_for_CRC = new byte[17];
            //计算第5位到第21位的CRC校验，共17位
            for (int i = 4; i < 21; i++) data_for_CRC[i] = ota_fistPack[i];
            ushort crc = GetCRC16(data_for_CRC, 17);
            ota_fistPack[21] = (byte)(byte)(crc >> 8 & 0xff);
            ota_fistPack[22] = (byte)(byte)(crc & 0xff);
            ota_fistPack[23] = 0x16;  //package end
            SendData(ota_fistPack);

        }
        private void OTA_SendDataPackage(int packageNo)
        {
            int packagecount = (int)Math.Ceiling((double)firmware_bin.Length / 490);
            //发送OTA数据包，长度=24+数据 字节
            int packageLen = 0;
            //最后一个包，数据长度等于剩余长度
            if (packageNo == packagecount)
            {
                packageLen = 24 + firmware_bin.Length % 490;
            }else
            {
                packageLen = 24 + 490;
            }
            byte[] ota_data = new byte[490];
            ota_data[0] = 0x68; //startflag
            ota_data[1] = (byte)(packageLen>>8); //len 2bytes
            ota_data[2] = (byte)packageLen; //len
            ota_data[3] = 0x68;//startflag
            ota_data[4] = 0x00;//address 8
            ota_data[5] = 0x00;//address 7
            ota_data[6] = 0x00;//address 6
            ota_data[7] = 0x00;//address 5
            ota_data[8] = 0x00;//address 4
            ota_data[9] = 0x00;//address 3
            ota_data[10] = 0x00;//address 2
            ota_data[11] = 0x00;//address 1
            //AFN
            ota_data[12] = 0x08; // AFN=8
            //dir
            ota_data[13] = 0x01;//dir:1 from cloud
            //package sequence
            ota_data[14] = 0x00;//inital pack 2bytes 
            ota_data[15] = 0x00;
            ota_data[16] = 0x01; //first package 1bytes=1
            ota_data[17] = (byte)(packagecount >> 8 & 0xff); //last package 2bytes
            ota_data[18] = (byte)(packagecount & 0xff);
            ota_data[19] = (byte)(packagecount >> 8 & 0xff); //package len 2bytes
            ota_data[20] = (byte)(packagecount & 0xff);
            for (int i = 21; i < packageLen; i++)
            {
                ota_data[i] = firmware_bin[i];
            }

            //crc16
            byte[] data_for_CRC = new byte[packageLen -7];
            //计算第5位到第21位的CRC校验，共17位
            for (int i = 4; i < packageLen -3 ; i++) data_for_CRC[i] = ota_data[i];
            ushort crc = GetCRC16(data_for_CRC, packageLen - 7);
            ota_data[21] = (byte)(byte)(crc >> 8 & 0xff);
            ota_data[22] = (byte)(byte)(crc & 0xff);
            ota_data[23] = 0x16;  //package end
            SendData(ota_data);

        }
        bool check_OTA_InitializePackage(byte[] receivedData)
        {
            bool b_receiveOK = true;
            int packagecount = (int)Math.Ceiling((double)firmware_bin.Length / 490);
            //收到客户端回复的包
            if (receivedData != null)
            {
                if (receivedData[0] != 0x68) b_receiveOK = false;
                if (receivedData[1] != 0) b_receiveOK = false;
                if (receivedData[2] != 25) b_receiveOK = false;
                if (receivedData[3] != 0x68) b_receiveOK = false;
                //ota_fistPack[4] = 0x00;//address 8
                //ota_fistPack[5] = 0x00;//address 7
                //ota_fistPack[6] = 0x00;//address 6
                //ota_fistPack[7] = 0x00;//address 5
                //ota_fistPack[8] = 0x00;//address 4
                //ota_fistPack[9] = 0x00;//address 3
                //ota_fistPack[10] = 0x00;//address 2
                //ota_fistPack[11] = 0x00;//address 1
                //AFN
                if (receivedData[12] != 0x08) b_receiveOK = false; // AFN=8
                if (receivedData[13] != 0x02) b_receiveOK = false;//dir:2 from client
                if (receivedData[14] != 0x01) b_receiveOK = false;//升级确认
                //包序号
                if (receivedData[15] != 0x00) b_receiveOK = false; //inital pack 2bytes 
                if (receivedData[16] != 0x00) b_receiveOK = false; ;
                if (receivedData[17] != 0x01) b_receiveOK = false; ; //first package 1bytes=1
                if (receivedData[18] != (byte)(packagecount >> 8 & 0xff)) b_receiveOK = false;  //last package 2bytes
                if (receivedData[19] != (byte)(packagecount & 0xff)) b_receiveOK = false;
                if (receivedData[20] != (byte)(packagecount >> 8 & 0xff)) b_receiveOK = false;  //package len 2bytes
                if (receivedData[21] != (byte)(packagecount & 0xff)) b_receiveOK = false;
                //crc16
                byte[] data_for_CRC_rsv = new byte[18];
                //计算第5位到第21位的CRC校验，共17位
                for (int i = 4; i < 21; i++) data_for_CRC_rsv[i] = receivedData[i];
                ushort crc_rsv = GetCRC16(data_for_CRC_rsv, 17);
                if (receivedData[21] != (byte)(byte)(crc_rsv >> 8 & 0xff)) b_receiveOK = false;
                if (receivedData[22] != (byte)(byte)(crc_rsv & 0xff)) b_receiveOK = false;
                if (receivedData[23] != 0x16) b_receiveOK = false; //package end
                if (!b_receiveOK)
                {
                    log_upgrade("OTA initial respond error");
                    return false;
                }
                return true;
            }
            log_upgrade("OTA initial respond timeout");
            return false;
        }
        bool check_OTA_CompletePackage(byte[] receivedData)
        {
            bool b_receiveOK = true;
            int packagecount = (int)Math.Ceiling((double)firmware_bin.Length / 490);
            //收到客户端回复的包
            if (receivedData != null)
            {
                if (receivedData[0] != 0x68) b_receiveOK = false;
                if (receivedData[1] != 0) b_receiveOK = false;
                if (receivedData[2] != 18) b_receiveOK = false;
                if (receivedData[3] != 0x68) b_receiveOK = false;
                //ota_fistPack[4] = 0x00;//address 8
                //ota_fistPack[5] = 0x00;//address 7
                //ota_fistPack[6] = 0x00;//address 6
                //ota_fistPack[7] = 0x00;//address 5
                //ota_fistPack[8] = 0x00;//address 4
                //ota_fistPack[9] = 0x00;//address 3
                //ota_fistPack[10] = 0x00;//address 2
                //ota_fistPack[11] = 0x00;//address 1
                //AFN
                if (receivedData[12] != 0x08) b_receiveOK = false; // AFN=8
                if (receivedData[13] != 0x02) b_receiveOK = false;//dir:2 from client
                if (receivedData[14] != 0x01) b_receiveOK = false;//升级结果

                //crc16
                byte[] data_for_CRC_rsv = new byte[18];
                //计算第5位到第21位的CRC校验，共17位
                for (int i = 4; i < 21; i++) data_for_CRC_rsv[i] = receivedData[i];
                ushort crc_rsv = GetCRC16(data_for_CRC_rsv, 17);
                if (receivedData[15] != (byte)(byte)(crc_rsv >> 8 & 0xff)) b_receiveOK = false;
                if (receivedData[16] != (byte)(byte)(crc_rsv & 0xff)) b_receiveOK = false;
                if (receivedData[17] != 0x16) b_receiveOK = false; //package end
                if (!b_receiveOK)
                {
                    log_upgrade("OTA fail to complete");
                    return false;
                }
                return true;
            }
            log_upgrade("OTA result respond timeout");
            return false;
        }
        bool check_OTA_DataPackage(byte[] receivedData,out int lastGood)
        {
            bool b_receiveOK = true;
            int packagecount = (int)Math.Ceiling((double)firmware_bin.Length / 490);
            //收到客户端回复的包
            if (receivedData != null)
            {
                if (receivedData[0] != 0x68) b_receiveOK = false;
                if (receivedData[1] != 0) b_receiveOK = false;
                if (receivedData[2] != 25) b_receiveOK = false;
                if (receivedData[3] != 0x68) b_receiveOK = false;
                //ota_fistPack[4] = 0x00;//address 8
                //ota_fistPack[5] = 0x00;//address 7
                //ota_fistPack[6] = 0x00;//address 6
                //ota_fistPack[7] = 0x00;//address 5
                //ota_fistPack[8] = 0x00;//address 4
                //ota_fistPack[9] = 0x00;//address 3
                //ota_fistPack[10] = 0x00;//address 2
                //ota_fistPack[11] = 0x00;//address 1
                //AFN
                if (receivedData[12] != 0x08) b_receiveOK = false; // AFN=8
                if (receivedData[13] != 0x02) b_receiveOK = false;//dir:2 from client
                if (receivedData[14] != 0x01) b_receiveOK = false;//升级确认位
                //if (receivedData[15] != 0x00) b_receiveOK = false; //last good pack 2bytes 
                //if (receivedData[16] != 0x00) b_receiveOK = false; ;
                if (receivedData[17] != 0x01) b_receiveOK = false; ; //first package 1bytes=1
                if (receivedData[18] != (byte)(packagecount >> 8 & 0xff)) b_receiveOK = false;  //last package 2bytes
                if (receivedData[19] != (byte)(packagecount & 0xff)) b_receiveOK = false;
                if (receivedData[20] != (byte)(packagecount >> 8 & 0xff)) b_receiveOK = false;  //package len 2bytes
                if (receivedData[21] != (byte)(packagecount & 0xff)) b_receiveOK = false;
                //crc16
                byte[] data_for_CRC_rsv = new byte[18];
                //计算第5位到第21位的CRC校验，共17位
                for (int i = 4; i < 21; i++) data_for_CRC_rsv[i] = receivedData[i];
                ushort crc_rsv = GetCRC16(data_for_CRC_rsv, 17);
                if (receivedData[22] != (byte)(byte)(crc_rsv >> 8 & 0xff)) b_receiveOK = false;
                if (receivedData[23] != (byte)(byte)(crc_rsv & 0xff)) b_receiveOK = false;
                if (receivedData[24] != 0x16) b_receiveOK = false; //package end
                int packageNo = receivedData[15] * 255 + receivedData[16];
                lastGood = packageNo;

                if (!b_receiveOK)
                {
                    log_upgrade("OTA datapackage respond error");
                    return false;
                }
                return true;
            }
            log_upgrade("OTA datapackage respond timeout");
            lastGood = -1;
            return false;
        }
        private void btn_startOTA_at_server_side_Click(object sender, EventArgs e)
        {
            int total_packagecount = (int)Math.Ceiling((double)firmware_bin.Length / 490);
            OTA_SendInitalizePackage();
            //接收客户端发来的响应数据
            byte[] receivedData = ReceiveClientData(1000);
            if (check_OTA_InitializePackage(receivedData))
            {
                log_upgrade("OTA started");
            }
            for (int i=1; i<total_packagecount;i++)
            {
                OTA_SendDataPackage(i);
                //接收客户端发来的响应数据
                receivedData = ReceiveClientData(1000);
                int curr_package_No=0;
                if (check_OTA_DataPackage(receivedData, out curr_package_No))
                {
                    log_upgrade("Package"+i.ToString()+" completed");
                }
            }
            //接收客户端发来的响应数据
            receivedData = ReceiveClientData(10000);
        }
        void SendData(byte[] b_send)
        {
            if (frm_main.isServerCreated)
            {
                foreach (SocketConnection sc in frm_main.server.GetConnectionList())
                {
                    sc.Send(b_send);
                }
            }
        }
        static void WriteBytesToFile(byte[] byteArray, string filePath)
        {
            try
            {
                // 打开文件流
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    // 写入字节数组
                    fs.Write(byteArray, 0, byteArray.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("写入文件时出错：" + ex.Message);
            }
        }
        public static byte[] ParseIntelHexFile(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    byte[] data = new byte[0];
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.StartsWith(":"))
                        {
                            byte[] bytes = ParseHexLine(line);
                            if (bytes != null)
                            {
                                data = AppendBytes(data, bytes);
                            }
                            else
                            {
                                Console.WriteLine("Error parsing line: " + line);
                            }
                        }
                    }
                    return data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error parsing Intel HEX file: " + ex.Message);
                return null;
            }
        }

        private static byte[] ParseHexLine(string line)
        {
            try
            {
                byte[] bytes = new byte[line.Length / 2 - 5];
                int dataLength = Convert.ToInt32(line.Substring(1, 2), 16);
                int address = Convert.ToInt32(line.Substring(3, 4), 16);
                int recordType = Convert.ToInt32(line.Substring(7, 2), 16);
                if (recordType == 0)
                {
                    for (int i = 0; i < dataLength; i++)
                    {
                        bytes[i] = Convert.ToByte(line.Substring(9 + i * 2, 2), 16);
                    }
                    return bytes;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error parsing hex line: " + ex.Message);
                return null;
            }
        }

        private static byte[] AppendBytes(byte[] array1, byte[] array2)
        {
            byte[] newArray = new byte[array1.Length + array2.Length];
            Array.Copy(array1, 0, newArray, 0, array1.Length);
            Array.Copy(array2, 0, newArray, array1.Length, array2.Length);
            return newArray;
        }

        public byte[] ReceiveClientData(int wait_ms)
        {
            for (int i=0;i<wait_ms;i++)
            {
                if (frm_main.client_Respond!=null)
                {
                    byte[] rsvdata = new byte[frm_main.client_Respond.Length];
                    Array.Copy(frm_main.client_Respond, rsvdata,rsvdata.Length);
                    frm_main.client_Respond = null;
                    return rsvdata;
                }else
                {
                    System.Threading.Thread.Sleep(1);
                    Application.DoEvents();
                }
            }
            return null;
        }



        public static ushort GetCRC16(byte[] data, int len)
        {
            ushort ax, lsb;
            ax = 0xFFFF;

            for (int i = 0; i < len; i++)
            {
                ax ^= data[i];
                for (int j = 0; j < 8; j++)
                {
                    lsb = (ushort)(ax & 0x0001);
                    ax = (ushort)(ax >> 1);
                    if (lsb != 0)
                        ax ^= 0xA001;
                }
            }
            return ax;
        }
        public void log_upgrade(string strinput, bool isAddingNewLine = true)
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
                    rtb_rsv.AppendText("[" + time + "] " + str_proceeded + s_NewLine);
                    rtb_rsv.SelectionStart = rtb_rsv.TextLength;
                    rtb_rsv.ScrollCaret();
                }

            }));
        }
        private void Upgrade_Load(object sender, EventArgs e)
        {

        }
    }
}
