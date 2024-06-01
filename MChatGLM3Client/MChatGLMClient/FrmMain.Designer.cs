namespace ChatGLMClient
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ucTextBoxExAPI = new HZH_Controls.Controls.UCTextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.ucBtnImgSend = new HZH_Controls.Controls.UCBtnImg();
            this.ucBtnImgMaxTokens = new HZH_Controls.Controls.UCBtnImg();
            this.ucTrackBarMaxTokens = new HZH_Controls.Controls.UCTrackBar();
            this.labelMaxTokens = new System.Windows.Forms.Label();
            this.ucBtnImgTemp = new HZH_Controls.Controls.UCBtnImg();
            this.ucTrackBarTemp = new HZH_Controls.Controls.UCTrackBar();
            this.labelTemp = new System.Windows.Forms.Label();
            this.ucBtnImgTopp = new HZH_Controls.Controls.UCBtnImg();
            this.labelTopp = new System.Windows.Forms.Label();
            this.ucTrackBarTopp = new HZH_Controls.Controls.UCTrackBar();
            this.ucBtnImgClear = new HZH_Controls.Controls.UCBtnImg();
            this.label2 = new System.Windows.Forms.Label();
            this.ucSwitchStream = new HZH_Controls.Controls.UCSwitch();
            this.richTextBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.ucBtnExt2 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.ucb_connectstatus = new HZH_Controls.Controls.UCBtnExt();
            this.ucb_status = new HZH_Controls.Controls.UCBtnExt();
            this.ucAutoConnect = new HZH_Controls.Controls.UCSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.bnt_startmonitorStatus = new System.Windows.Forms.Button();
            this.ucBtnImgStop = new HZH_Controls.Controls.UCBtnImg();
            this.ucb_Connect = new HZH_Controls.Controls.UCDropDownBtn();
            this.ucb_mode = new HZH_Controls.Controls.UCBtnExt();
            this.ucTextBoxExAPIExt = new HZH_Controls.Controls.UCTextBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            this.ucSwitchTool = new HZH_Controls.Controls.UCSwitch();
            this.label5 = new System.Windows.Forms.Label();
            this.ucBtnExt3 = new HZH_Controls.Controls.UCBtnExt();
            this.pan_toolchain = new System.Windows.Forms.Panel();
            this.btn_connectstock = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.txt_clientAddr = new HZH_Controls.Controls.UCTextBoxEx();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_clientPort = new HZH_Controls.Controls.UCTextBoxEx();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_clientConnected = new HZH_Controls.Controls.UCBtnExt();
            this.label7 = new System.Windows.Forms.Label();
            this.ucExternalModel = new HZH_Controls.Controls.UCSwitch();
            this.SuspendLayout();
            // 
            // ucTextBoxExAPI
            // 
            this.ucTextBoxExAPI.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBoxExAPI.ConerRadius = 20;
            this.ucTextBoxExAPI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxExAPI.DecLength = 2;
            this.ucTextBoxExAPI.FillColor = System.Drawing.Color.Empty;
            this.ucTextBoxExAPI.FocusBorderColor = System.Drawing.SystemColors.Control;
            this.ucTextBoxExAPI.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.ucTextBoxExAPI.InputText = "http://127.0.0.1:7860";
            this.ucTextBoxExAPI.InputType = HZH_Controls.TextInputType.NotControl;
            this.ucTextBoxExAPI.IsFocusColor = true;
            this.ucTextBoxExAPI.IsFouceShowKey = false;
            this.ucTextBoxExAPI.IsRadius = true;
            this.ucTextBoxExAPI.IsShowClearBtn = true;
            this.ucTextBoxExAPI.IsShowKeyboard = false;
            this.ucTextBoxExAPI.IsShowRect = true;
            this.ucTextBoxExAPI.IsShowSearchBtn = false;
            this.ucTextBoxExAPI.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.ucTextBoxExAPI.Location = new System.Drawing.Point(86, 71);
            this.ucTextBoxExAPI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxExAPI.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ucTextBoxExAPI.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.ucTextBoxExAPI.Name = "ucTextBoxExAPI";
            this.ucTextBoxExAPI.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxExAPI.PasswordChar = '\0';
            this.ucTextBoxExAPI.PromptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ucTextBoxExAPI.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxExAPI.PromptText = "";
            this.ucTextBoxExAPI.RectColor = System.Drawing.SystemColors.Control;
            this.ucTextBoxExAPI.RectWidth = 1;
            this.ucTextBoxExAPI.RegexPattern = "";
            this.ucTextBoxExAPI.Size = new System.Drawing.Size(449, 30);
            this.ucTextBoxExAPI.TabIndex = 56;
            this.ucTextBoxExAPI.Leave += new System.EventHandler(this.ucTextBoxExAPI_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "地址";
            // 
            // ucBtnImgSend
            // 
            this.ucBtnImgSend.BackColor = System.Drawing.Color.White;
            this.ucBtnImgSend.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnImgSend.BtnFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImgSend.BtnForeColor = System.Drawing.Color.Green;
            this.ucBtnImgSend.BtnText = "   发送";
            this.ucBtnImgSend.ConerRadius = 20;
            this.ucBtnImgSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnImgSend.EnabledMouseEffect = false;
            this.ucBtnImgSend.FillColor = System.Drawing.Color.White;
            this.ucBtnImgSend.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImgSend.ForeColor = System.Drawing.Color.Green;
            this.ucBtnImgSend.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImgSend.Image")));
            this.ucBtnImgSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImgSend.ImageFontIcons = ((object)(resources.GetObject("ucBtnImgSend.ImageFontIcons")));
            this.ucBtnImgSend.IsRadius = true;
            this.ucBtnImgSend.IsShowRect = true;
            this.ucBtnImgSend.IsShowTips = false;
            this.ucBtnImgSend.Location = new System.Drawing.Point(658, 602);
            this.ucBtnImgSend.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImgSend.Name = "ucBtnImgSend";
            this.ucBtnImgSend.RectColor = System.Drawing.Color.Green;
            this.ucBtnImgSend.RectWidth = 1;
            this.ucBtnImgSend.Size = new System.Drawing.Size(125, 42);
            this.ucBtnImgSend.TabIndex = 58;
            this.ucBtnImgSend.TabStop = false;
            this.ucBtnImgSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImgSend.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImgSend.TipsText = "";
            this.ucBtnImgSend.BtnClick += new System.EventHandler(this.ucBtnImgSend_BtnClick);
            // 
            // ucBtnImgMaxTokens
            // 
            this.ucBtnImgMaxTokens.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgMaxTokens.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgMaxTokens.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImgMaxTokens.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgMaxTokens.BtnText = "Maximum length";
            this.ucBtnImgMaxTokens.ConerRadius = 5;
            this.ucBtnImgMaxTokens.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ucBtnImgMaxTokens.EnabledMouseEffect = false;
            this.ucBtnImgMaxTokens.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnImgMaxTokens.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImgMaxTokens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgMaxTokens.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImgMaxTokens.Image")));
            this.ucBtnImgMaxTokens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImgMaxTokens.ImageFontIcons = ((object)(resources.GetObject("ucBtnImgMaxTokens.ImageFontIcons")));
            this.ucBtnImgMaxTokens.IsRadius = true;
            this.ucBtnImgMaxTokens.IsShowRect = true;
            this.ucBtnImgMaxTokens.IsShowTips = false;
            this.ucBtnImgMaxTokens.Location = new System.Drawing.Point(645, 185);
            this.ucBtnImgMaxTokens.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImgMaxTokens.Name = "ucBtnImgMaxTokens";
            this.ucBtnImgMaxTokens.RectColor = System.Drawing.Color.Transparent;
            this.ucBtnImgMaxTokens.RectWidth = 1;
            this.ucBtnImgMaxTokens.Size = new System.Drawing.Size(186, 31);
            this.ucBtnImgMaxTokens.TabIndex = 63;
            this.ucBtnImgMaxTokens.TabStop = false;
            this.ucBtnImgMaxTokens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucBtnImgMaxTokens.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImgMaxTokens.TipsText = "";
            // 
            // ucTrackBarMaxTokens
            // 
            this.ucTrackBarMaxTokens.DcimalDigits = 0;
            this.ucTrackBarMaxTokens.IsShowTips = true;
            this.ucTrackBarMaxTokens.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBarMaxTokens.LineWidth = 8F;
            this.ucTrackBarMaxTokens.Location = new System.Drawing.Point(645, 219);
            this.ucTrackBarMaxTokens.MaxValue = 4096F;
            this.ucTrackBarMaxTokens.MinValue = 0F;
            this.ucTrackBarMaxTokens.Name = "ucTrackBarMaxTokens";
            this.ucTrackBarMaxTokens.Size = new System.Drawing.Size(186, 30);
            this.ucTrackBarMaxTokens.TabIndex = 64;
            this.ucTrackBarMaxTokens.TipsFormat = null;
            this.ucTrackBarMaxTokens.Value = 2048F;
            this.ucTrackBarMaxTokens.ValueColor = System.Drawing.Color.Green;
            this.ucTrackBarMaxTokens.ValueChanged += new System.EventHandler(this.ucTrackBarMaxTokens_ValueChanged);
            // 
            // labelMaxTokens
            // 
            this.labelMaxTokens.AutoSize = true;
            this.labelMaxTokens.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMaxTokens.Location = new System.Drawing.Point(843, 226);
            this.labelMaxTokens.Name = "labelMaxTokens";
            this.labelMaxTokens.Size = new System.Drawing.Size(45, 19);
            this.labelMaxTokens.TabIndex = 65;
            this.labelMaxTokens.Text = "2048";
            // 
            // ucBtnImgTemp
            // 
            this.ucBtnImgTemp.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTemp.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTemp.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImgTemp.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgTemp.BtnText = "Temperature";
            this.ucBtnImgTemp.ConerRadius = 5;
            this.ucBtnImgTemp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ucBtnImgTemp.EnabledMouseEffect = false;
            this.ucBtnImgTemp.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTemp.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImgTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgTemp.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImgTemp.Image")));
            this.ucBtnImgTemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImgTemp.ImageFontIcons = ((object)(resources.GetObject("ucBtnImgTemp.ImageFontIcons")));
            this.ucBtnImgTemp.IsRadius = true;
            this.ucBtnImgTemp.IsShowRect = true;
            this.ucBtnImgTemp.IsShowTips = false;
            this.ucBtnImgTemp.Location = new System.Drawing.Point(645, 262);
            this.ucBtnImgTemp.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImgTemp.Name = "ucBtnImgTemp";
            this.ucBtnImgTemp.RectColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTemp.RectWidth = 1;
            this.ucBtnImgTemp.Size = new System.Drawing.Size(152, 30);
            this.ucBtnImgTemp.TabIndex = 66;
            this.ucBtnImgTemp.TabStop = false;
            this.ucBtnImgTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucBtnImgTemp.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImgTemp.TipsText = "";
            // 
            // ucTrackBarTemp
            // 
            this.ucTrackBarTemp.DcimalDigits = 1;
            this.ucTrackBarTemp.IsShowTips = true;
            this.ucTrackBarTemp.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBarTemp.LineWidth = 8F;
            this.ucTrackBarTemp.Location = new System.Drawing.Point(645, 295);
            this.ucTrackBarTemp.MaxValue = 1F;
            this.ucTrackBarTemp.MinValue = 0F;
            this.ucTrackBarTemp.Name = "ucTrackBarTemp";
            this.ucTrackBarTemp.Size = new System.Drawing.Size(185, 30);
            this.ucTrackBarTemp.TabIndex = 67;
            this.ucTrackBarTemp.TipsFormat = null;
            this.ucTrackBarTemp.Value = 0.9F;
            this.ucTrackBarTemp.ValueColor = System.Drawing.Color.Green;
            this.ucTrackBarTemp.ValueChanged += new System.EventHandler(this.ucTrackBarTemp_ValueChanged);
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTemp.Location = new System.Drawing.Point(843, 301);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(40, 19);
            this.labelTemp.TabIndex = 68;
            this.labelTemp.Text = "0.95";
            // 
            // ucBtnImgTopp
            // 
            this.ucBtnImgTopp.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTopp.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTopp.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImgTopp.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgTopp.BtnText = "Top p";
            this.ucBtnImgTopp.ConerRadius = 5;
            this.ucBtnImgTopp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ucBtnImgTopp.EnabledMouseEffect = false;
            this.ucBtnImgTopp.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTopp.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImgTopp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgTopp.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImgTopp.Image")));
            this.ucBtnImgTopp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImgTopp.ImageFontIcons = ((object)(resources.GetObject("ucBtnImgTopp.ImageFontIcons")));
            this.ucBtnImgTopp.IsRadius = true;
            this.ucBtnImgTopp.IsShowRect = true;
            this.ucBtnImgTopp.IsShowTips = false;
            this.ucBtnImgTopp.Location = new System.Drawing.Point(659, 337);
            this.ucBtnImgTopp.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImgTopp.Name = "ucBtnImgTopp";
            this.ucBtnImgTopp.RectColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTopp.RectWidth = 1;
            this.ucBtnImgTopp.Size = new System.Drawing.Size(98, 30);
            this.ucBtnImgTopp.TabIndex = 69;
            this.ucBtnImgTopp.TabStop = false;
            this.ucBtnImgTopp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucBtnImgTopp.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImgTopp.TipsText = "";
            // 
            // labelTopp
            // 
            this.labelTopp.AutoSize = true;
            this.labelTopp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTopp.Location = new System.Drawing.Point(845, 377);
            this.labelTopp.Name = "labelTopp";
            this.labelTopp.Size = new System.Drawing.Size(31, 19);
            this.labelTopp.TabIndex = 71;
            this.labelTopp.Text = "0.7";
            // 
            // ucTrackBarTopp
            // 
            this.ucTrackBarTopp.DcimalDigits = 1;
            this.ucTrackBarTopp.IsShowTips = true;
            this.ucTrackBarTopp.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBarTopp.LineWidth = 8F;
            this.ucTrackBarTopp.Location = new System.Drawing.Point(645, 370);
            this.ucTrackBarTopp.MaxValue = 1F;
            this.ucTrackBarTopp.MinValue = 0F;
            this.ucTrackBarTopp.Name = "ucTrackBarTopp";
            this.ucTrackBarTopp.Size = new System.Drawing.Size(185, 30);
            this.ucTrackBarTopp.TabIndex = 70;
            this.ucTrackBarTopp.TipsFormat = null;
            this.ucTrackBarTopp.Value = 0.7F;
            this.ucTrackBarTopp.ValueColor = System.Drawing.Color.Green;
            this.ucTrackBarTopp.ValueChanged += new System.EventHandler(this.ucTrackBarTopp_ValueChanged);
            // 
            // ucBtnImgClear
            // 
            this.ucBtnImgClear.BackColor = System.Drawing.Color.White;
            this.ucBtnImgClear.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnImgClear.BtnFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.ucBtnImgClear.BtnForeColor = System.Drawing.Color.Green;
            this.ucBtnImgClear.BtnText = "  清空";
            this.ucBtnImgClear.ConerRadius = 20;
            this.ucBtnImgClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnImgClear.EnabledMouseEffect = false;
            this.ucBtnImgClear.FillColor = System.Drawing.Color.White;
            this.ucBtnImgClear.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImgClear.ForeColor = System.Drawing.Color.Gray;
            this.ucBtnImgClear.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImgClear.Image")));
            this.ucBtnImgClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImgClear.ImageFontIcons = ((object)(resources.GetObject("ucBtnImgClear.ImageFontIcons")));
            this.ucBtnImgClear.IsRadius = true;
            this.ucBtnImgClear.IsShowRect = true;
            this.ucBtnImgClear.IsShowTips = false;
            this.ucBtnImgClear.Location = new System.Drawing.Point(658, 474);
            this.ucBtnImgClear.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImgClear.Name = "ucBtnImgClear";
            this.ucBtnImgClear.RectColor = System.Drawing.Color.Green;
            this.ucBtnImgClear.RectWidth = 1;
            this.ucBtnImgClear.Size = new System.Drawing.Size(125, 42);
            this.ucBtnImgClear.TabIndex = 59;
            this.ucBtnImgClear.TabStop = false;
            this.ucBtnImgClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImgClear.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImgClear.TipsText = "";
            this.ucBtnImgClear.BtnClick += new System.EventHandler(this.ucBtnImgClear_BtnClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(655, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 87;
            this.label2.Text = "流模式";
            // 
            // ucSwitchStream
            // 
            this.ucSwitchStream.BackColor = System.Drawing.Color.Transparent;
            this.ucSwitchStream.Checked = true;
            this.ucSwitchStream.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ucSwitchStream.FalseTextColr = System.Drawing.Color.White;
            this.ucSwitchStream.Location = new System.Drawing.Point(719, 422);
            this.ucSwitchStream.Name = "ucSwitchStream";
            this.ucSwitchStream.Size = new System.Drawing.Size(69, 31);
            this.ucSwitchStream.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.ucSwitchStream.TabIndex = 88;
            this.ucSwitchStream.Texts = new string[] {
        "I",
        "O"};
            this.ucSwitchStream.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucSwitchStream.TrueTextColr = System.Drawing.Color.White;
            this.ucSwitchStream.CheckedChanged += new System.EventHandler(this.ucSwitchStream_CheckedChanged);
            // 
            // richTextBoxAnswer
            // 
            this.richTextBoxAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxAnswer.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxAnswer.Location = new System.Drawing.Point(36, 181);
            this.richTextBoxAnswer.Name = "richTextBoxAnswer";
            this.richTextBoxAnswer.ReadOnly = true;
            this.richTextBoxAnswer.Size = new System.Drawing.Size(584, 342);
            this.richTextBoxAnswer.TabIndex = 60;
            this.richTextBoxAnswer.TabStop = false;
            this.richTextBoxAnswer.Text = "";
            this.richTextBoxAnswer.TextChanged += new System.EventHandler(this.richTextBoxAnswer_TextChanged);
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxQuestion.ImeMode = System.Windows.Forms.ImeMode.On;
            this.richTextBoxQuestion.Location = new System.Drawing.Point(37, 547);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.Size = new System.Drawing.Size(583, 97);
            this.richTextBoxQuestion.TabIndex = 0;
            this.richTextBoxQuestion.Text = "";
            // 
            // ucBtnExt2
            // 
            this.ucBtnExt2.BackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt2.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnText = null;
            this.ucBtnExt2.ConerRadius = 20;
            this.ucBtnExt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt2.EnabledMouseEffect = false;
            this.ucBtnExt2.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnExt2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt2.IsRadius = true;
            this.ucBtnExt2.IsShowRect = true;
            this.ucBtnExt2.IsShowTips = false;
            this.ucBtnExt2.Location = new System.Drawing.Point(33, 544);
            this.ucBtnExt2.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt2.Name = "ucBtnExt2";
            this.ucBtnExt2.RectColor = System.Drawing.Color.Green;
            this.ucBtnExt2.RectWidth = 1;
            this.ucBtnExt2.Size = new System.Drawing.Size(590, 103);
            this.ucBtnExt2.TabIndex = 86;
            this.ucBtnExt2.TabStop = false;
            this.ucBtnExt2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt2.TipsText = "";
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = null;
            this.ucBtnExt1.ConerRadius = 20;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(33, 178);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.Green;
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(590, 348);
            this.ucBtnExt1.TabIndex = 61;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            // 
            // ucb_connectstatus
            // 
            this.ucb_connectstatus.BackColor = System.Drawing.Color.White;
            this.ucb_connectstatus.BtnBackColor = System.Drawing.Color.White;
            this.ucb_connectstatus.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.ucb_connectstatus.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ucb_connectstatus.BtnText = "连接";
            this.ucb_connectstatus.ConerRadius = 100;
            this.ucb_connectstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucb_connectstatus.EnabledMouseEffect = false;
            this.ucb_connectstatus.FillColor = System.Drawing.Color.Transparent;
            this.ucb_connectstatus.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucb_connectstatus.IsRadius = true;
            this.ucb_connectstatus.IsShowRect = true;
            this.ucb_connectstatus.IsShowTips = false;
            this.ucb_connectstatus.Location = new System.Drawing.Point(806, 423);
            this.ucb_connectstatus.Margin = new System.Windows.Forms.Padding(0);
            this.ucb_connectstatus.Name = "ucb_connectstatus";
            this.ucb_connectstatus.RectColor = System.Drawing.Color.Green;
            this.ucb_connectstatus.RectWidth = 1;
            this.ucb_connectstatus.Size = new System.Drawing.Size(100, 100);
            this.ucb_connectstatus.TabIndex = 87;
            this.ucb_connectstatus.TabStop = false;
            this.ucb_connectstatus.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucb_connectstatus.TipsText = "";
            // 
            // ucb_status
            // 
            this.ucb_status.BackColor = System.Drawing.Color.White;
            this.ucb_status.BtnBackColor = System.Drawing.Color.White;
            this.ucb_status.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.ucb_status.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ucb_status.BtnText = "状态";
            this.ucb_status.ConerRadius = 100;
            this.ucb_status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucb_status.EnabledMouseEffect = false;
            this.ucb_status.FillColor = System.Drawing.Color.Transparent;
            this.ucb_status.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucb_status.IsRadius = true;
            this.ucb_status.IsShowRect = true;
            this.ucb_status.IsShowTips = false;
            this.ucb_status.Location = new System.Drawing.Point(804, 547);
            this.ucb_status.Margin = new System.Windows.Forms.Padding(0);
            this.ucb_status.Name = "ucb_status";
            this.ucb_status.RectColor = System.Drawing.Color.Green;
            this.ucb_status.RectWidth = 1;
            this.ucb_status.Size = new System.Drawing.Size(100, 100);
            this.ucb_status.TabIndex = 90;
            this.ucb_status.TabStop = false;
            this.ucb_status.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucb_status.TipsText = "";
            // 
            // ucAutoConnect
            // 
            this.ucAutoConnect.BackColor = System.Drawing.Color.Transparent;
            this.ucAutoConnect.Checked = true;
            this.ucAutoConnect.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ucAutoConnect.FalseTextColr = System.Drawing.Color.White;
            this.ucAutoConnect.Location = new System.Drawing.Point(729, 74);
            this.ucAutoConnect.Name = "ucAutoConnect";
            this.ucAutoConnect.Size = new System.Drawing.Size(69, 31);
            this.ucAutoConnect.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.ucAutoConnect.TabIndex = 92;
            this.ucAutoConnect.Texts = new string[] {
        "I",
        "O"};
            this.ucAutoConnect.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucAutoConnect.TrueTextColr = System.Drawing.Color.White;
            this.ucAutoConnect.CheckedChanged += new System.EventHandler(this.ucAutoConnect_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(649, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 91;
            this.label3.Text = "自动运行";
            // 
            // bnt_startmonitorStatus
            // 
            this.bnt_startmonitorStatus.Location = new System.Drawing.Point(804, 662);
            this.bnt_startmonitorStatus.Name = "bnt_startmonitorStatus";
            this.bnt_startmonitorStatus.Size = new System.Drawing.Size(101, 25);
            this.bnt_startmonitorStatus.TabIndex = 93;
            this.bnt_startmonitorStatus.Text = "监控网络";
            this.bnt_startmonitorStatus.UseVisualStyleBackColor = true;
            this.bnt_startmonitorStatus.Visible = false;
            this.bnt_startmonitorStatus.Click += new System.EventHandler(this.Bnt_startmonitorStatus_Click);
            // 
            // ucBtnImgStop
            // 
            this.ucBtnImgStop.BackColor = System.Drawing.Color.White;
            this.ucBtnImgStop.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnImgStop.BtnFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.ucBtnImgStop.BtnForeColor = System.Drawing.Color.Green;
            this.ucBtnImgStop.BtnText = "  停止";
            this.ucBtnImgStop.ConerRadius = 20;
            this.ucBtnImgStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnImgStop.EnabledMouseEffect = false;
            this.ucBtnImgStop.FillColor = System.Drawing.Color.White;
            this.ucBtnImgStop.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImgStop.ForeColor = System.Drawing.Color.Gray;
            this.ucBtnImgStop.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImgStop.Image")));
            this.ucBtnImgStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImgStop.ImageFontIcons = ((object)(resources.GetObject("ucBtnImgStop.ImageFontIcons")));
            this.ucBtnImgStop.IsRadius = true;
            this.ucBtnImgStop.IsShowRect = true;
            this.ucBtnImgStop.IsShowTips = false;
            this.ucBtnImgStop.Location = new System.Drawing.Point(658, 547);
            this.ucBtnImgStop.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImgStop.Name = "ucBtnImgStop";
            this.ucBtnImgStop.RectColor = System.Drawing.Color.Green;
            this.ucBtnImgStop.RectWidth = 1;
            this.ucBtnImgStop.Size = new System.Drawing.Size(125, 42);
            this.ucBtnImgStop.TabIndex = 94;
            this.ucBtnImgStop.TabStop = false;
            this.ucBtnImgStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImgStop.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImgStop.TipsText = "";
            this.ucBtnImgStop.BtnClick += new System.EventHandler(this.ucBtnImgStop_BtnClick);
            // 
            // ucb_Connect
            // 
            this.ucb_Connect.BackColor = System.Drawing.Color.White;
            this.ucb_Connect.BtnBackColor = System.Drawing.Color.White;
            this.ucb_Connect.BtnFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.ucb_Connect.BtnForeColor = System.Drawing.Color.Green;
            this.ucb_Connect.Btns = new string[] {
        "cpu",
        "fp16",
        "int8",
        "int4",
        "fp16-双卡"};
            this.ucb_Connect.BtnText = "运行";
            this.ucb_Connect.ConerRadius = 20;
            this.ucb_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucb_Connect.DropPanelHeight = -1;
            this.ucb_Connect.EnabledMouseEffect = false;
            this.ucb_Connect.FillColor = System.Drawing.Color.White;
            this.ucb_Connect.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucb_Connect.ForeColor = System.Drawing.Color.Green;
            this.ucb_Connect.Image = ((System.Drawing.Image)(resources.GetObject("ucb_Connect.Image")));
            this.ucb_Connect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucb_Connect.ImageFontIcons = null;
            this.ucb_Connect.IsRadius = true;
            this.ucb_Connect.IsShowRect = true;
            this.ucb_Connect.IsShowTips = false;
            this.ucb_Connect.Location = new System.Drawing.Point(541, 70);
            this.ucb_Connect.Margin = new System.Windows.Forms.Padding(2);
            this.ucb_Connect.Name = "ucb_Connect";
            this.ucb_Connect.RectColor = System.Drawing.Color.Green;
            this.ucb_Connect.RectWidth = 1;
            this.ucb_Connect.Size = new System.Drawing.Size(79, 31);
            this.ucb_Connect.TabIndex = 96;
            this.ucb_Connect.TabStop = false;
            this.ucb_Connect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucb_Connect.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucb_Connect.TipsText = "";
            this.ucb_Connect.BtnClick += new System.EventHandler(this.ucb_Connect_BtnClick);
            // 
            // ucb_mode
            // 
            this.ucb_mode.BackColor = System.Drawing.Color.White;
            this.ucb_mode.BtnBackColor = System.Drawing.Color.White;
            this.ucb_mode.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.ucb_mode.BtnForeColor = System.Drawing.Color.Green;
            this.ucb_mode.BtnText = "模式";
            this.ucb_mode.ConerRadius = 50;
            this.ucb_mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucb_mode.EnabledMouseEffect = false;
            this.ucb_mode.FillColor = System.Drawing.Color.Transparent;
            this.ucb_mode.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucb_mode.IsRadius = true;
            this.ucb_mode.IsShowRect = true;
            this.ucb_mode.IsShowTips = false;
            this.ucb_mode.Location = new System.Drawing.Point(815, 80);
            this.ucb_mode.Margin = new System.Windows.Forms.Padding(0);
            this.ucb_mode.Name = "ucb_mode";
            this.ucb_mode.RectColor = System.Drawing.Color.Green;
            this.ucb_mode.RectWidth = 1;
            this.ucb_mode.Size = new System.Drawing.Size(80, 80);
            this.ucb_mode.TabIndex = 97;
            this.ucb_mode.TabStop = false;
            this.ucb_mode.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucb_mode.TipsText = "";
            // 
            // ucTextBoxExAPIExt
            // 
            this.ucTextBoxExAPIExt.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBoxExAPIExt.ConerRadius = 20;
            this.ucTextBoxExAPIExt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxExAPIExt.DecLength = 2;
            this.ucTextBoxExAPIExt.FillColor = System.Drawing.Color.Empty;
            this.ucTextBoxExAPIExt.FocusBorderColor = System.Drawing.SystemColors.Control;
            this.ucTextBoxExAPIExt.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.ucTextBoxExAPIExt.InputText = "https://openai.api2d.net/v1/chat/completions";
            this.ucTextBoxExAPIExt.InputType = HZH_Controls.TextInputType.NotControl;
            this.ucTextBoxExAPIExt.IsFocusColor = true;
            this.ucTextBoxExAPIExt.IsFouceShowKey = false;
            this.ucTextBoxExAPIExt.IsRadius = true;
            this.ucTextBoxExAPIExt.IsShowClearBtn = false;
            this.ucTextBoxExAPIExt.IsShowKeyboard = false;
            this.ucTextBoxExAPIExt.IsShowRect = true;
            this.ucTextBoxExAPIExt.IsShowSearchBtn = false;
            this.ucTextBoxExAPIExt.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.ucTextBoxExAPIExt.Location = new System.Drawing.Point(85, 125);
            this.ucTextBoxExAPIExt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxExAPIExt.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ucTextBoxExAPIExt.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.ucTextBoxExAPIExt.Name = "ucTextBoxExAPIExt";
            this.ucTextBoxExAPIExt.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxExAPIExt.PasswordChar = '\0';
            this.ucTextBoxExAPIExt.PromptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ucTextBoxExAPIExt.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxExAPIExt.PromptText = "";
            this.ucTextBoxExAPIExt.RectColor = System.Drawing.SystemColors.Control;
            this.ucTextBoxExAPIExt.RectWidth = 1;
            this.ucTextBoxExAPIExt.RegexPattern = "";
            this.ucTextBoxExAPIExt.Size = new System.Drawing.Size(535, 30);
            this.ucTextBoxExAPIExt.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(36, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 98;
            this.label4.Text = "外部";
            // 
            // ucSwitchTool
            // 
            this.ucSwitchTool.BackColor = System.Drawing.Color.Transparent;
            this.ucSwitchTool.Checked = false;
            this.ucSwitchTool.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ucSwitchTool.FalseTextColr = System.Drawing.Color.White;
            this.ucSwitchTool.Location = new System.Drawing.Point(713, 697);
            this.ucSwitchTool.Name = "ucSwitchTool";
            this.ucSwitchTool.Size = new System.Drawing.Size(69, 31);
            this.ucSwitchTool.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.ucSwitchTool.TabIndex = 102;
            this.ucSwitchTool.Texts = new string[] {
        "I",
        "O"};
            this.ucSwitchTool.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucSwitchTool.TrueTextColr = System.Drawing.Color.White;
            this.ucSwitchTool.CheckedChanged += new System.EventHandler(this.ucSwitchTool_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(649, 702);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 101;
            this.label5.Text = "工具链";
            // 
            // ucBtnExt3
            // 
            this.ucBtnExt3.BackColor = System.Drawing.Color.White;
            this.ucBtnExt3.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt3.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt3.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt3.BtnText = null;
            this.ucBtnExt3.ConerRadius = 20;
            this.ucBtnExt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt3.EnabledMouseEffect = false;
            this.ucBtnExt3.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnExt3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt3.IsRadius = true;
            this.ucBtnExt3.IsShowRect = true;
            this.ucBtnExt3.IsShowTips = false;
            this.ucBtnExt3.Location = new System.Drawing.Point(33, 662);
            this.ucBtnExt3.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt3.Name = "ucBtnExt3";
            this.ucBtnExt3.RectColor = System.Drawing.Color.Green;
            this.ucBtnExt3.RectWidth = 1;
            this.ucBtnExt3.Size = new System.Drawing.Size(598, 157);
            this.ucBtnExt3.TabIndex = 103;
            this.ucBtnExt3.TabStop = false;
            this.ucBtnExt3.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt3.TipsText = "";
            // 
            // pan_toolchain
            // 
            this.pan_toolchain.BackColor = System.Drawing.Color.White;
            this.pan_toolchain.Location = new System.Drawing.Point(42, 667);
            this.pan_toolchain.Name = "pan_toolchain";
            this.pan_toolchain.Size = new System.Drawing.Size(581, 145);
            this.pan_toolchain.TabIndex = 2;
            // 
            // btn_connectstock
            // 
            this.btn_connectstock.Location = new System.Drawing.Point(815, 805);
            this.btn_connectstock.Name = "btn_connectstock";
            this.btn_connectstock.Size = new System.Drawing.Size(44, 25);
            this.btn_connectstock.TabIndex = 104;
            this.btn_connectstock.Text = "连接";
            this.btn_connectstock.UseVisualStyleBackColor = true;
            this.btn_connectstock.Visible = false;
            this.btn_connectstock.Click += new System.EventHandler(this.btn_connectstock_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_disconnect.Location = new System.Drawing.Point(865, 805);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(41, 25);
            this.btn_disconnect.TabIndex = 111;
            this.btn_disconnect.Text = "断开";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Visible = false;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // txt_clientAddr
            // 
            this.txt_clientAddr.BackColor = System.Drawing.Color.Transparent;
            this.txt_clientAddr.ConerRadius = 20;
            this.txt_clientAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_clientAddr.DecLength = 2;
            this.txt_clientAddr.FillColor = System.Drawing.Color.Empty;
            this.txt_clientAddr.FocusBorderColor = System.Drawing.SystemColors.Control;
            this.txt_clientAddr.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txt_clientAddr.InputText = "127.0.0.1";
            this.txt_clientAddr.InputType = HZH_Controls.TextInputType.NotControl;
            this.txt_clientAddr.IsFocusColor = true;
            this.txt_clientAddr.IsFouceShowKey = false;
            this.txt_clientAddr.IsRadius = true;
            this.txt_clientAddr.IsShowClearBtn = false;
            this.txt_clientAddr.IsShowKeyboard = false;
            this.txt_clientAddr.IsShowRect = true;
            this.txt_clientAddr.IsShowSearchBtn = false;
            this.txt_clientAddr.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txt_clientAddr.Location = new System.Drawing.Point(703, 800);
            this.txt_clientAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_clientAddr.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_clientAddr.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txt_clientAddr.Name = "txt_clientAddr";
            this.txt_clientAddr.Padding = new System.Windows.Forms.Padding(5);
            this.txt_clientAddr.PasswordChar = '\0';
            this.txt_clientAddr.PromptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_clientAddr.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_clientAddr.PromptText = "";
            this.txt_clientAddr.RectColor = System.Drawing.SystemColors.Control;
            this.txt_clientAddr.RectWidth = 1;
            this.txt_clientAddr.RegexPattern = "";
            this.txt_clientAddr.Size = new System.Drawing.Size(108, 30);
            this.txt_clientAddr.TabIndex = 113;
            this.txt_clientAddr.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(658, 805);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 22);
            this.label8.TabIndex = 112;
            this.label8.Text = "地址";
            this.label8.Visible = false;
            // 
            // txt_clientPort
            // 
            this.txt_clientPort.BackColor = System.Drawing.Color.Transparent;
            this.txt_clientPort.ConerRadius = 20;
            this.txt_clientPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_clientPort.DecLength = 2;
            this.txt_clientPort.FillColor = System.Drawing.Color.Empty;
            this.txt_clientPort.FocusBorderColor = System.Drawing.SystemColors.Control;
            this.txt_clientPort.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txt_clientPort.InputText = "6000";
            this.txt_clientPort.InputType = HZH_Controls.TextInputType.NotControl;
            this.txt_clientPort.IsFocusColor = true;
            this.txt_clientPort.IsFouceShowKey = false;
            this.txt_clientPort.IsRadius = true;
            this.txt_clientPort.IsShowClearBtn = false;
            this.txt_clientPort.IsShowKeyboard = false;
            this.txt_clientPort.IsShowRect = true;
            this.txt_clientPort.IsShowSearchBtn = false;
            this.txt_clientPort.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txt_clientPort.Location = new System.Drawing.Point(709, 746);
            this.txt_clientPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_clientPort.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_clientPort.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txt_clientPort.Name = "txt_clientPort";
            this.txt_clientPort.Padding = new System.Windows.Forms.Padding(5);
            this.txt_clientPort.PasswordChar = '\0';
            this.txt_clientPort.PromptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_clientPort.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_clientPort.PromptText = "";
            this.txt_clientPort.RectColor = System.Drawing.SystemColors.Control;
            this.txt_clientPort.RectWidth = 1;
            this.txt_clientPort.RegexPattern = "";
            this.txt_clientPort.Size = new System.Drawing.Size(73, 30);
            this.txt_clientPort.TabIndex = 115;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(665, 751);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 22);
            this.label6.TabIndex = 114;
            this.label6.Text = "端口";
            // 
            // btn_clientConnected
            // 
            this.btn_clientConnected.BackColor = System.Drawing.Color.White;
            this.btn_clientConnected.BtnBackColor = System.Drawing.Color.White;
            this.btn_clientConnected.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btn_clientConnected.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_clientConnected.BtnText = "工具";
            this.btn_clientConnected.ConerRadius = 100;
            this.btn_clientConnected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clientConnected.EnabledMouseEffect = false;
            this.btn_clientConnected.FillColor = System.Drawing.Color.Transparent;
            this.btn_clientConnected.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_clientConnected.IsRadius = true;
            this.btn_clientConnected.IsShowRect = true;
            this.btn_clientConnected.IsShowTips = false;
            this.btn_clientConnected.Location = new System.Drawing.Point(804, 699);
            this.btn_clientConnected.Margin = new System.Windows.Forms.Padding(0);
            this.btn_clientConnected.Name = "btn_clientConnected";
            this.btn_clientConnected.RectColor = System.Drawing.Color.Green;
            this.btn_clientConnected.RectWidth = 1;
            this.btn_clientConnected.Size = new System.Drawing.Size(100, 100);
            this.btn_clientConnected.TabIndex = 116;
            this.btn_clientConnected.TabStop = false;
            this.btn_clientConnected.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_clientConnected.TipsText = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(649, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 22);
            this.label7.TabIndex = 117;
            this.label7.Text = "外部模型";
            // 
            // ucExternalModel
            // 
            this.ucExternalModel.BackColor = System.Drawing.Color.Transparent;
            this.ucExternalModel.Checked = false;
            this.ucExternalModel.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ucExternalModel.FalseTextColr = System.Drawing.Color.White;
            this.ucExternalModel.Location = new System.Drawing.Point(729, 129);
            this.ucExternalModel.Name = "ucExternalModel";
            this.ucExternalModel.Size = new System.Drawing.Size(69, 31);
            this.ucExternalModel.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.ucExternalModel.TabIndex = 118;
            this.ucExternalModel.Texts = new string[] {
        "I",
        "O"};
            this.ucExternalModel.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucExternalModel.TrueTextColr = System.Drawing.Color.White;
            this.ucExternalModel.CheckedChanged += new System.EventHandler(this.ucExternalModel_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(942, 837);
            this.Controls.Add(this.ucExternalModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_clientConnected);
            this.Controls.Add(this.txt_clientPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_clientAddr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connectstock);
            this.Controls.Add(this.pan_toolchain);
            this.Controls.Add(this.ucBtnExt3);
            this.Controls.Add(this.ucSwitchTool);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ucTextBoxExAPIExt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ucb_mode);
            this.Controls.Add(this.ucb_Connect);
            this.Controls.Add(this.ucBtnImgStop);
            this.Controls.Add(this.bnt_startmonitorStatus);
            this.Controls.Add(this.ucAutoConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ucb_status);
            this.Controls.Add(this.richTextBoxQuestion);
            this.Controls.Add(this.ucSwitchStream);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucBtnExt2);
            this.Controls.Add(this.ucTextBoxExAPI);
            this.Controls.Add(this.ucBtnImgClear);
            this.Controls.Add(this.labelTopp);
            this.Controls.Add(this.ucTrackBarTopp);
            this.Controls.Add(this.ucBtnImgTopp);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.ucTrackBarTemp);
            this.Controls.Add(this.ucBtnImgTemp);
            this.Controls.Add(this.labelMaxTokens);
            this.Controls.Add(this.ucTrackBarMaxTokens);
            this.Controls.Add(this.ucBtnImgMaxTokens);
            this.Controls.Add(this.richTextBoxAnswer);
            this.Controls.Add(this.ucBtnImgSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.ucb_connectstatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsShowCloseBtn = true;
            this.Name = "FrmMain";
            this.RegionRadius = 40;
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.Text = "FrmMain";
            this.Title = "       ChatGLM3-6B 工具链与外部连接 V1 build20240601";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Controls.SetChildIndex(this.ucb_connectstatus, 0);
            this.Controls.SetChildIndex(this.ucBtnExt1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ucBtnImgSend, 0);
            this.Controls.SetChildIndex(this.richTextBoxAnswer, 0);
            this.Controls.SetChildIndex(this.ucBtnImgMaxTokens, 0);
            this.Controls.SetChildIndex(this.ucTrackBarMaxTokens, 0);
            this.Controls.SetChildIndex(this.labelMaxTokens, 0);
            this.Controls.SetChildIndex(this.ucBtnImgTemp, 0);
            this.Controls.SetChildIndex(this.ucTrackBarTemp, 0);
            this.Controls.SetChildIndex(this.labelTemp, 0);
            this.Controls.SetChildIndex(this.ucBtnImgTopp, 0);
            this.Controls.SetChildIndex(this.ucTrackBarTopp, 0);
            this.Controls.SetChildIndex(this.labelTopp, 0);
            this.Controls.SetChildIndex(this.ucBtnImgClear, 0);
            this.Controls.SetChildIndex(this.ucTextBoxExAPI, 0);
            this.Controls.SetChildIndex(this.ucBtnExt2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ucSwitchStream, 0);
            this.Controls.SetChildIndex(this.richTextBoxQuestion, 0);
            this.Controls.SetChildIndex(this.ucb_status, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.ucAutoConnect, 0);
            this.Controls.SetChildIndex(this.bnt_startmonitorStatus, 0);
            this.Controls.SetChildIndex(this.ucBtnImgStop, 0);
            this.Controls.SetChildIndex(this.ucb_Connect, 0);
            this.Controls.SetChildIndex(this.ucb_mode, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.ucTextBoxExAPIExt, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.ucSwitchTool, 0);
            this.Controls.SetChildIndex(this.ucBtnExt3, 0);
            this.Controls.SetChildIndex(this.pan_toolchain, 0);
            this.Controls.SetChildIndex(this.btn_connectstock, 0);
            this.Controls.SetChildIndex(this.btn_disconnect, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txt_clientAddr, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txt_clientPort, 0);
            this.Controls.SetChildIndex(this.btn_clientConnected, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.ucExternalModel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxExAPI;
        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.UCBtnImg ucBtnImgSend;
        private HZH_Controls.Controls.UCBtnImg ucBtnImgMaxTokens;
        private HZH_Controls.Controls.UCTrackBar ucTrackBarMaxTokens;
        private System.Windows.Forms.Label labelMaxTokens;
        private HZH_Controls.Controls.UCBtnImg ucBtnImgTemp;
        private HZH_Controls.Controls.UCTrackBar ucTrackBarTemp;
        private System.Windows.Forms.Label labelTemp;
        private HZH_Controls.Controls.UCBtnImg ucBtnImgTopp;
        private System.Windows.Forms.Label labelTopp;
        private HZH_Controls.Controls.UCTrackBar ucTrackBarTopp;
        private HZH_Controls.Controls.UCBtnImg ucBtnImgClear;
        private System.Windows.Forms.Label label2;
        private HZH_Controls.Controls.UCSwitch ucSwitchStream;
        private System.Windows.Forms.RichTextBox richTextBoxAnswer;
        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt2;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private HZH_Controls.Controls.UCBtnExt ucb_connectstatus;
        private HZH_Controls.Controls.UCBtnExt ucb_status;
        private HZH_Controls.Controls.UCSwitch ucAutoConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnt_startmonitorStatus;
        private HZH_Controls.Controls.UCBtnImg ucBtnImgStop;
        private HZH_Controls.Controls.UCDropDownBtn ucb_Connect;
        private HZH_Controls.Controls.UCBtnExt ucb_mode;
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxExAPIExt;
        private System.Windows.Forms.Label label4;
        private HZH_Controls.Controls.UCSwitch ucSwitchTool;
        private System.Windows.Forms.Label label5;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt3;
        private System.Windows.Forms.Panel pan_toolchain;
        private System.Windows.Forms.Button btn_connectstock;
        private System.Windows.Forms.Button btn_disconnect;
        private HZH_Controls.Controls.UCTextBoxEx txt_clientAddr;
        private System.Windows.Forms.Label label8;
        private HZH_Controls.Controls.UCTextBoxEx txt_clientPort;
        private System.Windows.Forms.Label label6;
        private HZH_Controls.Controls.UCBtnExt btn_clientConnected;
        private System.Windows.Forms.Label label7;
        private HZH_Controls.Controls.UCSwitch ucExternalModel;
    }
}

