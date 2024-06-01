
namespace TCPServer
{
    partial class Upgrade_ServerSide
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_upgrade = new System.Windows.Forms.Button();
            this.btn_startOTA_at_server_side = new System.Windows.Forms.Button();
            this.txt_OTA_file_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_browserfile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtb_rsv = new ScintillaNET.Scintilla();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_upgrade
            // 
            this.btn_upgrade.Location = new System.Drawing.Point(668, 271);
            this.btn_upgrade.Name = "btn_upgrade";
            this.btn_upgrade.Size = new System.Drawing.Size(119, 30);
            this.btn_upgrade.TabIndex = 0;
            this.btn_upgrade.Text = "升级状态";
            this.btn_upgrade.UseVisualStyleBackColor = true;
            // 
            // btn_startOTA_at_server_side
            // 
            this.btn_startOTA_at_server_side.Location = new System.Drawing.Point(665, 67);
            this.btn_startOTA_at_server_side.Name = "btn_startOTA_at_server_side";
            this.btn_startOTA_at_server_side.Size = new System.Drawing.Size(122, 30);
            this.btn_startOTA_at_server_side.TabIndex = 1;
            this.btn_startOTA_at_server_side.Text = "启动OTA（服务端）";
            this.btn_startOTA_at_server_side.UseVisualStyleBackColor = true;
            this.btn_startOTA_at_server_side.Click += new System.EventHandler(this.btn_startOTA_at_server_side_Click);
            // 
            // txt_OTA_file_path
            // 
            this.txt_OTA_file_path.Location = new System.Drawing.Point(132, 25);
            this.txt_OTA_file_path.Name = "txt_OTA_file_path";
            this.txt_OTA_file_path.Size = new System.Drawing.Size(580, 21);
            this.txt_OTA_file_path.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "OTA 文件路径：";
            // 
            // btn_browserfile
            // 
            this.btn_browserfile.Location = new System.Drawing.Point(720, 24);
            this.btn_browserfile.Name = "btn_browserfile";
            this.btn_browserfile.Size = new System.Drawing.Size(67, 22);
            this.btn_browserfile.TabIndex = 4;
            this.btn_browserfile.Text = "浏览";
            this.btn_browserfile.UseVisualStyleBackColor = true;
            this.btn_browserfile.Click += new System.EventHandler(this.btn_browserfile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtb_rsv);
            this.groupBox1.Location = new System.Drawing.Point(29, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 141);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "升级进度：";
            // 
            // rtb_rsv
            // 
            this.rtb_rsv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_rsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_rsv.HScrollBar = false;
            this.rtb_rsv.Location = new System.Drawing.Point(3, 17);
            this.rtb_rsv.Margins.Capacity = 0;
            this.rtb_rsv.Margins.Left = 0;
            this.rtb_rsv.Margins.Right = 0;
            this.rtb_rsv.Name = "rtb_rsv";
            this.rtb_rsv.Size = new System.Drawing.Size(752, 121);
            this.rtb_rsv.TabIndex = 1;
            // 
            // Upgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_browserfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_OTA_file_path);
            this.Controls.Add(this.btn_startOTA_at_server_side);
            this.Controls.Add(this.btn_upgrade);
            this.Name = "Upgrade";
            this.Text = "Upgrade";
            this.Load += new System.EventHandler(this.Upgrade_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_upgrade;
        private System.Windows.Forms.Button btn_startOTA_at_server_side;
        private System.Windows.Forms.TextBox txt_OTA_file_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_browserfile;
        private System.Windows.Forms.GroupBox groupBox1;
        public ScintillaNET.Scintilla rtb_rsv;
    }
}