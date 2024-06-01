
namespace stock
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pan_righttop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtb_rsv_server = new ScintillaNET.Scintilla();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_send_server = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_send_server = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.pan_data = new System.Windows.Forms.Panel();
            this.rtb_rsv_client = new ScintillaNET.Scintilla();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_send_client = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_send_client = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_serverConnected = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_clientConnected = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_serverRunning = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.txt_serverAddr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_clientAddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txt_clientPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_serverPort = new System.Windows.Forms.TextBox();
            this.btn_createServer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pan_fill = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtb_consolelog = new ScintillaNET.Scintilla();
            this.pan_righttop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.pan_data.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pan_fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_righttop
            // 
            this.pan_righttop.Controls.Add(this.panel2);
            this.pan_righttop.Controls.Add(this.btn_clear);
            this.pan_righttop.Controls.Add(this.pan_data);
            this.pan_righttop.Controls.Add(this.groupBox4);
            this.pan_righttop.Controls.Add(this.btn_serverConnected);
            this.pan_righttop.Controls.Add(this.label8);
            this.pan_righttop.Controls.Add(this.btn_clientConnected);
            this.pan_righttop.Controls.Add(this.label7);
            this.pan_righttop.Controls.Add(this.btn_serverRunning);
            this.pan_righttop.Controls.Add(this.btn_disconnect);
            this.pan_righttop.Controls.Add(this.txt_serverAddr);
            this.pan_righttop.Controls.Add(this.label4);
            this.pan_righttop.Controls.Add(this.txt_clientAddr);
            this.pan_righttop.Controls.Add(this.label3);
            this.pan_righttop.Controls.Add(this.btn_connect);
            this.pan_righttop.Controls.Add(this.txt_clientPort);
            this.pan_righttop.Controls.Add(this.label2);
            this.pan_righttop.Controls.Add(this.label1);
            this.pan_righttop.Controls.Add(this.txt_serverPort);
            this.pan_righttop.Controls.Add(this.btn_createServer);
            this.pan_righttop.Controls.Add(this.label6);
            this.pan_righttop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_righttop.Location = new System.Drawing.Point(0, 150);
            this.pan_righttop.Name = "pan_righttop";
            this.pan_righttop.Size = new System.Drawing.Size(676, 425);
            this.pan_righttop.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtb_rsv_server);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Location = new System.Drawing.Point(343, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 389);
            this.panel2.TabIndex = 0;
            // 
            // rtb_rsv_server
            // 
            this.rtb_rsv_server.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_rsv_server.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_rsv_server.Location = new System.Drawing.Point(0, 56);
            this.rtb_rsv_server.Margins.Capacity = 0;
            this.rtb_rsv_server.Margins.Left = 0;
            this.rtb_rsv_server.Margins.Right = 0;
            this.rtb_rsv_server.Name = "rtb_rsv_server";
            this.rtb_rsv_server.Size = new System.Drawing.Size(318, 333);
            this.rtb_rsv_server.TabIndex = 3;
            this.rtb_rsv_server.WrapMode = ScintillaNET.WrapMode.Char;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_send_server);
            this.groupBox5.Controls.Add(this.panel3);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.btn_send_server);
            this.groupBox5.Controls.Add(this.panel5);
            this.groupBox5.Controls.Add(this.panel6);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(318, 56);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "服务端";
            // 
            // txt_send_server
            // 
            this.txt_send_server.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_send_server.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_send_server.Location = new System.Drawing.Point(64, 17);
            this.txt_send_server.Name = "txt_send_server";
            this.txt_send_server.Size = new System.Drawing.Size(160, 26);
            this.txt_send_server.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(224, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 26);
            this.panel3.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Font = new System.Drawing.Font("新宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(3, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 26);
            this.label9.TabIndex = 29;
            this.label9.Text = "输入:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_send_server
            // 
            this.btn_send_server.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_send_server.Location = new System.Drawing.Point(239, 17);
            this.btn_send_server.Name = "btn_send_server";
            this.btn_send_server.Size = new System.Drawing.Size(64, 26);
            this.btn_send_server.TabIndex = 24;
            this.btn_send_server.Text = "发送";
            this.btn_send_server.UseVisualStyleBackColor = true;
            this.btn_send_server.Click += new System.EventHandler(this.btn_send_server_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(303, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(12, 26);
            this.panel5.TabIndex = 28;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 43);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(312, 10);
            this.panel6.TabIndex = 30;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(596, 43);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(50, 21);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "清屏";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // pan_data
            // 
            this.pan_data.Controls.Add(this.rtb_rsv_client);
            this.pan_data.Controls.Add(this.groupBox3);
            this.pan_data.Location = new System.Drawing.Point(12, 84);
            this.pan_data.Name = "pan_data";
            this.pan_data.Size = new System.Drawing.Size(318, 388);
            this.pan_data.TabIndex = 20;
            // 
            // rtb_rsv_client
            // 
            this.rtb_rsv_client.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_rsv_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_rsv_client.Location = new System.Drawing.Point(0, 56);
            this.rtb_rsv_client.Margins.Capacity = 0;
            this.rtb_rsv_client.Margins.Left = 0;
            this.rtb_rsv_client.Margins.Right = 0;
            this.rtb_rsv_client.Name = "rtb_rsv_client";
            this.rtb_rsv_client.Size = new System.Drawing.Size(318, 332);
            this.rtb_rsv_client.TabIndex = 13;
            this.rtb_rsv_client.Text = "请在输入框中尝试输入\r\n{\"name\": \"stocktrack\", \"parameters\": {\"symbol\": \"601398\"}}";
            this.rtb_rsv_client.WrapMode = ScintillaNET.WrapMode.Char;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_send_client);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_send_client);
            this.groupBox3.Controls.Add(this.panel18);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 56);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "客户端";
            // 
            // txt_send_client
            // 
            this.txt_send_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_send_client.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_send_client.Location = new System.Drawing.Point(64, 17);
            this.txt_send_client.Name = "txt_send_client";
            this.txt_send_client.Size = new System.Drawing.Size(160, 26);
            this.txt_send_client.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(224, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 26);
            this.panel4.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("新宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 26);
            this.label5.TabIndex = 29;
            this.label5.Text = "输入:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_send_client
            // 
            this.btn_send_client.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_send_client.Location = new System.Drawing.Point(239, 17);
            this.btn_send_client.Name = "btn_send_client";
            this.btn_send_client.Size = new System.Drawing.Size(64, 26);
            this.btn_send_client.TabIndex = 24;
            this.btn_send_client.Text = "发送";
            this.btn_send_client.UseVisualStyleBackColor = true;
            this.btn_send_client.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // panel18
            // 
            this.panel18.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel18.Location = new System.Drawing.Point(303, 17);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(12, 26);
            this.panel18.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 10);
            this.panel1.TabIndex = 30;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(10, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(656, 10);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // btn_serverConnected
            // 
            this.btn_serverConnected.BackColor = System.Drawing.Color.Transparent;
            this.btn_serverConnected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_serverConnected.Location = new System.Drawing.Point(595, 12);
            this.btn_serverConnected.Name = "btn_serverConnected";
            this.btn_serverConnected.Size = new System.Drawing.Size(51, 22);
            this.btn_serverConnected.TabIndex = 17;
            this.btn_serverConnected.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(546, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "连接数：";
            // 
            // btn_clientConnected
            // 
            this.btn_clientConnected.BackColor = System.Drawing.Color.Transparent;
            this.btn_clientConnected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientConnected.Location = new System.Drawing.Point(489, 42);
            this.btn_clientConnected.Name = "btn_clientConnected";
            this.btn_clientConnected.Size = new System.Drawing.Size(51, 22);
            this.btn_clientConnected.TabIndex = 14;
            this.btn_clientConnected.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(450, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "连接：";
            // 
            // btn_serverRunning
            // 
            this.btn_serverRunning.BackColor = System.Drawing.Color.Transparent;
            this.btn_serverRunning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_serverRunning.Location = new System.Drawing.Point(489, 11);
            this.btn_serverRunning.Name = "btn_serverRunning";
            this.btn_serverRunning.Size = new System.Drawing.Size(51, 22);
            this.btn_serverRunning.TabIndex = 13;
            this.btn_serverRunning.UseVisualStyleBackColor = false;
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_disconnect.Location = new System.Drawing.Point(387, 41);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(52, 21);
            this.btn_disconnect.TabIndex = 12;
            this.btn_disconnect.Text = "断开";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // txt_serverAddr
            // 
            this.txt_serverAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_serverAddr.Location = new System.Drawing.Point(95, 14);
            this.txt_serverAddr.Name = "txt_serverAddr";
            this.txt_serverAddr.Size = new System.Drawing.Size(104, 20);
            this.txt_serverAddr.TabIndex = 9;
            this.txt_serverAddr.Text = "0.0.0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(22, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "本机IP地址：";
            // 
            // txt_clientAddr
            // 
            this.txt_clientAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_clientAddr.Location = new System.Drawing.Point(95, 41);
            this.txt_clientAddr.Name = "txt_clientAddr";
            this.txt_clientAddr.Size = new System.Drawing.Size(104, 20);
            this.txt_clientAddr.TabIndex = 7;
            this.txt_clientAddr.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(10, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "客户机IP地址：";
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_connect.Location = new System.Drawing.Point(326, 39);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(55, 24);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "连接";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txt_clientPort
            // 
            this.txt_clientPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_clientPort.Location = new System.Drawing.Point(278, 41);
            this.txt_clientPort.Name = "txt_clientPort";
            this.txt_clientPort.Size = new System.Drawing.Size(42, 20);
            this.txt_clientPort.TabIndex = 4;
            this.txt_clientPort.Text = "6000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(205, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TCP端口：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(205, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TCP端口：";
            // 
            // txt_serverPort
            // 
            this.txt_serverPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_serverPort.Location = new System.Drawing.Point(278, 14);
            this.txt_serverPort.Name = "txt_serverPort";
            this.txt_serverPort.Size = new System.Drawing.Size(42, 20);
            this.txt_serverPort.TabIndex = 1;
            this.txt_serverPort.Text = "6000";
            // 
            // btn_createServer
            // 
            this.btn_createServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_createServer.Location = new System.Drawing.Point(326, 13);
            this.btn_createServer.Name = "btn_createServer";
            this.btn_createServer.Size = new System.Drawing.Size(113, 21);
            this.btn_createServer.TabIndex = 0;
            this.btn_createServer.Text = "建立服务器";
            this.btn_createServer.UseVisualStyleBackColor = true;
            this.btn_createServer.Click += new System.EventHandler(this.btn_createServer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(450, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "运行：";
            // 
            // pan_fill
            // 
            this.pan_fill.Controls.Add(this.groupBox1);
            this.pan_fill.Location = new System.Drawing.Point(0, 0);
            this.pan_fill.Name = "pan_fill";
            this.pan_fill.Size = new System.Drawing.Size(676, 58);
            this.pan_fill.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log:";
            // 
            // rtb_consolelog
            // 
            this.rtb_consolelog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_consolelog.Location = new System.Drawing.Point(6, 20);
            this.rtb_consolelog.Margins.Capacity = 0;
            this.rtb_consolelog.Margins.Left = 0;
            this.rtb_consolelog.Margins.Right = 0;
            this.rtb_consolelog.Name = "rtb_consolelog";
            this.rtb_consolelog.Size = new System.Drawing.Size(660, 124);
            this.rtb_consolelog.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(676, 575);
            this.Controls.Add(this.rtb_consolelog);
            this.Controls.Add(this.pan_fill);
            this.Controls.Add(this.pan_righttop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Finance plugin V0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pan_righttop.ResumeLayout(false);
            this.pan_righttop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.pan_data.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pan_fill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_righttop;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel pan_data;
        private System.Windows.Forms.Button btn_serverConnected;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_clientConnected;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_serverRunning;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.TextBox txt_serverAddr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_clientAddr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txt_clientPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_serverPort;
        private System.Windows.Forms.Button btn_createServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pan_fill;
        private System.Windows.Forms.GroupBox groupBox1;
        public ScintillaNET.Scintilla rtb_consolelog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.TextBox txt_send_server;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btn_send_server;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        public ScintillaNET.Scintilla rtb_rsv_server;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txt_send_client;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btn_send_client;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel1;
        public ScintillaNET.Scintilla rtb_rsv_client;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

