namespace C_Sharp_PLC_1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnCollapseReplay = new System.Windows.Forms.Button();
            this.label_isGathering = new System.Windows.Forms.Label();
            this.label_isConnect = new System.Windows.Forms.Label();
            this.Connect_Button = new HslControls.HslButton();
            this.Choose_Time_Button = new HslControls.HslButton();
            this.Replay_Button = new HslControls.HslButton();
=======
=======
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
            this.Connect_Button = new HslControls.HslButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Review_Button = new HslControls.HslButton();
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DataScrub_Button = new HslControls.HslButton();
            this.userLantern2 = new HslCommunication.Controls.UserLantern();
            this.userLantern1 = new HslCommunication.Controls.UserLantern();
            this.Gather_Button = new HslControls.HslButton();
<<<<<<< HEAD
<<<<<<< HEAD
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userCurve_replay2 = new HslCommunication.Controls.UserCurve();
            this.userCurve_replay1 = new HslCommunication.Controls.UserCurve();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.userCurve1 = new HslCommunication.Controls.UserCurve();
            this.userCurve2 = new HslCommunication.Controls.UserCurve();
=======
            this.Disconnect_Button = new HslControls.HslButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
=======
            this.Disconnect_Button = new HslControls.HslButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
            this.userCurve_replay1 = new HslCommunication.Controls.UserCurve();
            this.userCurve_replay2 = new HslCommunication.Controls.UserCurve();
            this.userCurve1 = new HslCommunication.Controls.UserCurve();
            this.userCurve2 = new HslCommunication.Controls.UserCurve();
            this.Choose_Time_Button = new HslControls.HslButton();
<<<<<<< HEAD
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
=======
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Elapsed);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Snow;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCollapseReplay);
            this.splitContainer1.Panel1.Controls.Add(this.label_isGathering);
            this.splitContainer1.Panel1.Controls.Add(this.label_isConnect);
            this.splitContainer1.Panel1.Controls.Add(this.Connect_Button);
<<<<<<< HEAD
            this.splitContainer1.Panel1.Controls.Add(this.Choose_Time_Button);
            this.splitContainer1.Panel1.Controls.Add(this.Replay_Button);
=======
            this.splitContainer1.Panel1.Controls.Add(this.textBox3);
            this.splitContainer1.Panel1.Controls.Add(this.Choose_Time_Button);
            this.splitContainer1.Panel1.Controls.Add(this.Review_Button);
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.DataScrub_Button);
            this.splitContainer1.Panel1.Controls.Add(this.userLantern2);
            this.splitContainer1.Panel1.Controls.Add(this.userLantern1);
            this.splitContainer1.Panel1.Controls.Add(this.Gather_Button);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1477, 853);
            this.splitContainer1.SplitterDistance = 106;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            // btnCollapseReplay
            // 
            this.btnCollapseReplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCollapseReplay.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCollapseReplay.Location = new System.Drawing.Point(1426, 75);
            this.btnCollapseReplay.Name = "btnCollapseReplay";
            this.btnCollapseReplay.Size = new System.Drawing.Size(44, 24);
            this.btnCollapseReplay.TabIndex = 5;
            this.btnCollapseReplay.Text = "展开";
            this.btnCollapseReplay.UseVisualStyleBackColor = true;
            this.btnCollapseReplay.Click += new System.EventHandler(this.btnCollapseReplay_Click);
=======
            // Connect_Button
            // 
            this.Connect_Button.CustomerInformation = null;
            this.Connect_Button.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Connect_Button.Location = new System.Drawing.Point(37, 239);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.SelectColor = System.Drawing.Color.DarkRed;
            this.Connect_Button.Size = new System.Drawing.Size(114, 46);
            this.Connect_Button.TabIndex = 0;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 752);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 29);
            this.textBox3.TabIndex = 9;
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
            // 
            // label_isGathering
            // 
            this.label_isGathering.AutoSize = true;
            this.label_isGathering.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_isGathering.Location = new System.Drawing.Point(176, 16);
            this.label_isGathering.Name = "label_isGathering";
            this.label_isGathering.Size = new System.Drawing.Size(51, 19);
            this.label_isGathering.TabIndex = 9;
            this.label_isGathering.Text = "未传输";
            // 
            // label_isConnect
            // 
            this.label_isConnect.AutoSize = true;
            this.label_isConnect.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_isConnect.Location = new System.Drawing.Point(57, 16);
            this.label_isConnect.Name = "label_isConnect";
            this.label_isConnect.Size = new System.Drawing.Size(51, 19);
            this.label_isConnect.TabIndex = 9;
            this.label_isConnect.Text = "未连接";
            // 
            // Connect_Button
            // 
            this.Connect_Button.CustomerInformation = null;
            this.Connect_Button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Connect_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Connect_Button.Location = new System.Drawing.Point(652, 27);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.SelectColor = System.Drawing.Color.DarkRed;
            this.Connect_Button.Size = new System.Drawing.Size(114, 46);
            this.Connect_Button.TabIndex = 0;
            this.Connect_Button.Text = "连接";
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // Choose_Time_Button
            // 
            this.Choose_Time_Button.CustomerInformation = null;
            this.Choose_Time_Button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose_Time_Button.ForeColor = System.Drawing.Color.Chocolate;
            this.Choose_Time_Button.Location = new System.Drawing.Point(1251, 27);
            this.Choose_Time_Button.Name = "Choose_Time_Button";
            this.Choose_Time_Button.SelectColor = System.Drawing.Color.Orange;
            this.Choose_Time_Button.Size = new System.Drawing.Size(114, 46);
            this.Choose_Time_Button.TabIndex = 8;
            this.Choose_Time_Button.Text = "选择时间段";
            this.Choose_Time_Button.Visible = false;
            this.Choose_Time_Button.Click += new System.EventHandler(this.Choose_Time_Button_Click);
            // 
            // Replay_Button
            // 
            this.Replay_Button.CustomerInformation = null;
            this.Replay_Button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replay_Button.ForeColor = System.Drawing.Color.OrangeRed;
            this.Replay_Button.Location = new System.Drawing.Point(1101, 27);
            this.Replay_Button.Name = "Replay_Button";
            this.Replay_Button.SelectColor = System.Drawing.Color.Orange;
            this.Replay_Button.Size = new System.Drawing.Size(114, 46);
            this.Replay_Button.TabIndex = 8;
            this.Replay_Button.Text = "数据回放";
            this.Replay_Button.Click += new System.EventHandler(this.Replay_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "PORT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "AMSNETID:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(109, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "851";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(347, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "192.168.31.165.1.1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataScrub_Button
            // 
            this.DataScrub_Button.CustomerInformation = null;
            this.DataScrub_Button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataScrub_Button.ForeColor = System.Drawing.Color.DarkOrchid;
            this.DataScrub_Button.Location = new System.Drawing.Point(805, 27);
            this.DataScrub_Button.Name = "DataScrub_Button";
            this.DataScrub_Button.Size = new System.Drawing.Size(114, 46);
            this.DataScrub_Button.TabIndex = 5;
            this.DataScrub_Button.Text = "清空";
            this.DataScrub_Button.Click += new System.EventHandler(this.DataScrub_Button_Click);
            // 
            // userLantern2
            // 
            this.userLantern2.BackColor = System.Drawing.Color.Transparent;
            this.userLantern2.LanternBackground = System.Drawing.Color.Red;
            this.userLantern2.Location = new System.Drawing.Point(138, 13);
            this.userLantern2.Margin = new System.Windows.Forms.Padding(9);
            this.userLantern2.Name = "userLantern2";
            this.userLantern2.Size = new System.Drawing.Size(26, 25);
            this.userLantern2.TabIndex = 4;
            // 
            // userLantern1
            // 
            this.userLantern1.BackColor = System.Drawing.Color.Transparent;
            this.userLantern1.LanternBackground = System.Drawing.Color.Red;
            this.userLantern1.Location = new System.Drawing.Point(22, 13);
            this.userLantern1.Margin = new System.Windows.Forms.Padding(6);
            this.userLantern1.Name = "userLantern1";
            this.userLantern1.Size = new System.Drawing.Size(26, 25);
            this.userLantern1.TabIndex = 4;
            // 
            // Gather_Button
            // 
            this.Gather_Button.CustomerInformation = null;
            this.Gather_Button.Enabled = false;
            this.Gather_Button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gather_Button.ForeColor = System.Drawing.Color.Blue;
            this.Gather_Button.Location = new System.Drawing.Point(952, 27);
            this.Gather_Button.Name = "Gather_Button";
            this.Gather_Button.Size = new System.Drawing.Size(114, 46);
            this.Gather_Button.TabIndex = 2;
            this.Gather_Button.Text = "开始传输";
            this.Gather_Button.Click += new System.EventHandler(this.Gather_Button_Click);
            // 
<<<<<<< HEAD
=======
            // Disconnect_Button
            // 
            this.Disconnect_Button.CustomerInformation = null;
            this.Disconnect_Button.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnect_Button.ForeColor = System.Drawing.Color.Red;
            this.Disconnect_Button.Location = new System.Drawing.Point(37, 306);
            this.Disconnect_Button.Name = "Disconnect_Button";
            this.Disconnect_Button.Size = new System.Drawing.Size(114, 46);
            this.Disconnect_Button.TabIndex = 1;
            this.Disconnect_Button.Text = "Disconnect";
            this.Disconnect_Button.Click += new System.EventHandler(this.Disconnect_Button_Click);
            // 
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Panel1Collapsed = true;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(1473, 737);
            this.splitContainer2.SplitterDistance = 177;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.userCurve_replay2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.userCurve_replay1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1473, 177);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
<<<<<<< HEAD
            // userCurve_replay2
            // 
            this.userCurve_replay2.BackColor = System.Drawing.Color.Transparent;
            this.userCurve_replay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCurve_replay2.Location = new System.Drawing.Point(739, 3);
            this.userCurve_replay2.Name = "userCurve_replay2";
            this.userCurve_replay2.Size = new System.Drawing.Size(731, 171);
            this.userCurve_replay2.TabIndex = 3;
            this.userCurve_replay2.Title = "Replay Signal2";
            this.userCurve_replay2.ValueMaxLeft = 2F;
            this.userCurve_replay2.ValueMaxRight = 2F;
            this.userCurve_replay2.ValueMinLeft = -2F;
            this.userCurve_replay2.ValueMinRight = -2F;
            this.userCurve_replay2.ValueSegment = 2;
            this.userCurve_replay2.Paint += new System.Windows.Forms.PaintEventHandler(this.userCurve_replay2_Paint);
            // 
=======
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
            // userCurve_replay1
            // 
            this.userCurve_replay1.BackColor = System.Drawing.Color.Transparent;
            this.userCurve_replay1.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< HEAD
            this.userCurve_replay1.Location = new System.Drawing.Point(4, 4);
            this.userCurve_replay1.Margin = new System.Windows.Forms.Padding(4);
            this.userCurve_replay1.Name = "userCurve_replay1";
            this.userCurve_replay1.Size = new System.Drawing.Size(728, 169);
=======
            this.userCurve_replay1.Location = new System.Drawing.Point(3, 3);
            this.userCurve_replay1.Name = "userCurve_replay1";
            this.userCurve_replay1.Size = new System.Drawing.Size(736, 199);
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
            this.userCurve_replay1.TabIndex = 2;
            this.userCurve_replay1.Title = "Replay Signal1";
            this.userCurve_replay1.ValueMaxLeft = 2F;
            this.userCurve_replay1.ValueMaxRight = 2F;
            this.userCurve_replay1.ValueMinLeft = -2F;
            this.userCurve_replay1.ValueMinRight = -2F;
            this.userCurve_replay1.ValueSegment = 2;
            this.userCurve_replay1.Paint += new System.Windows.Forms.PaintEventHandler(this.userCurve_replay1_Paint);
            // 
<<<<<<< HEAD
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.userCurve1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.userCurve2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1473, 737);
            this.tableLayoutPanel2.TabIndex = 2;
=======
            // userCurve_replay2
            // 
            this.userCurve_replay2.BackColor = System.Drawing.Color.Transparent;
            this.userCurve_replay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCurve_replay2.Location = new System.Drawing.Point(745, 3);
            this.userCurve_replay2.Name = "userCurve_replay2";
            this.userCurve_replay2.Size = new System.Drawing.Size(736, 199);
            this.userCurve_replay2.TabIndex = 3;
            this.userCurve_replay2.Title = "Replay Signal2";
            this.userCurve_replay2.ValueMaxLeft = 2F;
            this.userCurve_replay2.ValueMaxRight = 2F;
            this.userCurve_replay2.ValueMinLeft = -2F;
            this.userCurve_replay2.ValueMinRight = -2F;
            this.userCurve_replay2.ValueSegment = 2;
            this.userCurve_replay2.Paint += new System.Windows.Forms.PaintEventHandler(this.userCurve_replay2_Paint);
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
            // 
            // userCurve1
=======
            // Connect_Button
            // 
            this.Connect_Button.CustomerInformation = null;
            this.Connect_Button.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Connect_Button.Location = new System.Drawing.Point(37, 239);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.SelectColor = System.Drawing.Color.DarkRed;
            this.Connect_Button.Size = new System.Drawing.Size(114, 46);
            this.Connect_Button.TabIndex = 0;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 752);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 29);
            this.textBox3.TabIndex = 9;
            // 
            // Review_Button
            // 
            this.Review_Button.CustomerInformation = null;
            this.Review_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Review_Button.ForeColor = System.Drawing.Color.OrangeRed;
            this.Review_Button.Location = new System.Drawing.Point(37, 611);
            this.Review_Button.Name = "Review_Button";
            this.Review_Button.SelectColor = System.Drawing.Color.Orange;
            this.Review_Button.Size = new System.Drawing.Size(114, 46);
            this.Review_Button.TabIndex = 8;
            this.Review_Button.Text = "Replay";
            this.Review_Button.Click += new System.EventHandler(this.Review_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "PORT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "AMSNETID:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(93, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "851";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(93, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "192.168.31.165.1.1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataScrub_Button
            // 
            this.DataScrub_Button.CustomerInformation = null;
            this.DataScrub_Button.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataScrub_Button.ForeColor = System.Drawing.Color.DarkOrchid;
            this.DataScrub_Button.Location = new System.Drawing.Point(37, 375);
            this.DataScrub_Button.Name = "DataScrub_Button";
            this.DataScrub_Button.Size = new System.Drawing.Size(114, 46);
            this.DataScrub_Button.TabIndex = 5;
            this.DataScrub_Button.Text = "DataScrub";
            this.DataScrub_Button.Click += new System.EventHandler(this.DataScrub_Button_Click);
            // 
            // userLantern2
            // 
            this.userLantern2.BackColor = System.Drawing.Color.Transparent;
            this.userLantern2.LanternBackground = System.Drawing.Color.DarkGray;
            this.userLantern2.Location = new System.Drawing.Point(181, 446);
            this.userLantern2.Margin = new System.Windows.Forms.Padding(9);
            this.userLantern2.Name = "userLantern2";
            this.userLantern2.Size = new System.Drawing.Size(57, 53);
            this.userLantern2.TabIndex = 4;
            // 
            // userLantern1
            // 
            this.userLantern1.BackColor = System.Drawing.Color.Transparent;
            this.userLantern1.LanternBackground = System.Drawing.Color.DarkGray;
            this.userLantern1.Location = new System.Drawing.Point(181, 232);
            this.userLantern1.Margin = new System.Windows.Forms.Padding(6);
            this.userLantern1.Name = "userLantern1";
            this.userLantern1.Size = new System.Drawing.Size(57, 53);
            this.userLantern1.TabIndex = 4;
            // 
            // Stop_Button
            // 
            this.Stop_Button.CustomerInformation = null;
            this.Stop_Button.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_Button.ForeColor = System.Drawing.Color.Black;
            this.Stop_Button.Location = new System.Drawing.Point(37, 532);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.SelectColor = System.Drawing.Color.Blue;
            this.Stop_Button.Size = new System.Drawing.Size(114, 46);
            this.Stop_Button.TabIndex = 3;
            this.Stop_Button.Text = "Stop";
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // Gather_Button
            // 
            this.Gather_Button.CustomerInformation = null;
            this.Gather_Button.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gather_Button.ForeColor = System.Drawing.Color.Blue;
            this.Gather_Button.Location = new System.Drawing.Point(37, 453);
            this.Gather_Button.Name = "Gather_Button";
            this.Gather_Button.Size = new System.Drawing.Size(114, 46);
            this.Gather_Button.TabIndex = 2;
            this.Gather_Button.Text = "Gather";
            this.Gather_Button.Click += new System.EventHandler(this.Gather_Button_Click);
            // 
            // Disconnect_Button
            // 
            this.Disconnect_Button.CustomerInformation = null;
            this.Disconnect_Button.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnect_Button.ForeColor = System.Drawing.Color.Red;
            this.Disconnect_Button.Location = new System.Drawing.Point(37, 306);
            this.Disconnect_Button.Name = "Disconnect_Button";
            this.Disconnect_Button.Size = new System.Drawing.Size(114, 46);
            this.Disconnect_Button.TabIndex = 1;
            this.Disconnect_Button.Text = "Disconnect";
            this.Disconnect_Button.Click += new System.EventHandler(this.Disconnect_Button_Click);
            // 
            // splitContainer2
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
            // 
            this.userCurve1.BackColor = System.Drawing.Color.Transparent;
<<<<<<< HEAD
            this.userCurve1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCurve1.Location = new System.Drawing.Point(4, 4);
            this.userCurve1.Margin = new System.Windows.Forms.Padding(4);
            this.userCurve1.Name = "userCurve1";
            this.userCurve1.Size = new System.Drawing.Size(1465, 350);
=======
            this.userCurve1.Location = new System.Drawing.Point(9, 24);
            this.userCurve1.Name = "userCurve1";
            this.userCurve1.Size = new System.Drawing.Size(1475, 303);
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
            this.userCurve1.StrechDataCountMax = 100;
            this.userCurve1.TabIndex = 1;
            this.userCurve1.TextAddFormat = "HH:mm:ss";
            this.userCurve1.Title = "Signal1";
            this.userCurve1.ValueMaxLeft = 2F;
            this.userCurve1.ValueMaxRight = 2F;
            this.userCurve1.ValueMinLeft = -2F;
            this.userCurve1.ValueMinRight = -2F;
<<<<<<< HEAD
            this.userCurve1.ValueSegment = 10;
=======
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
            // 
            // userCurve2
            // 
            this.userCurve2.BackColor = System.Drawing.Color.Transparent;
<<<<<<< HEAD
            this.userCurve2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCurve2.Location = new System.Drawing.Point(4, 362);
            this.userCurve2.Margin = new System.Windows.Forms.Padding(4);
            this.userCurve2.Name = "userCurve2";
            this.userCurve2.Size = new System.Drawing.Size(1465, 350);
=======
            this.userCurve2.Location = new System.Drawing.Point(11, 324);
            this.userCurve2.Name = "userCurve2";
            this.userCurve2.Size = new System.Drawing.Size(1475, 307);
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
            this.userCurve2.TabIndex = 0;
            this.userCurve2.TextAddFormat = "HH:mm:ss";
            this.userCurve2.Title = "Signal2";
            this.userCurve2.ValueMaxLeft = 2F;
            this.userCurve2.ValueMaxRight = 2F;
            this.userCurve2.ValueMinLeft = -2F;
            this.userCurve2.ValueMinRight = -2F;
<<<<<<< HEAD
            this.userCurve2.ValueSegment = 10;
            this.userCurve2.Load += new System.EventHandler(this.userCurve2_Load);
=======
            // 
            // Choose_Time_Button
            // 
            this.Choose_Time_Button.CustomerInformation = null;
            this.Choose_Time_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose_Time_Button.ForeColor = System.Drawing.Color.OrangeRed;
            this.Choose_Time_Button.Location = new System.Drawing.Point(37, 681);
            this.Choose_Time_Button.Name = "Choose_Time_Button";
            this.Choose_Time_Button.SelectColor = System.Drawing.Color.Orange;
            this.Choose_Time_Button.Size = new System.Drawing.Size(114, 46);
            this.Choose_Time_Button.TabIndex = 8;
            this.Choose_Time_Button.Text = "Choose";
            this.Choose_Time_Button.Visible = false;
            this.Choose_Time_Button.Click += new System.EventHandler(this.Choose_Time_Button_Click);
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
            // 
            // userCurve_replay1
            // 
            this.userCurve_replay1.BackColor = System.Drawing.Color.Transparent;
            this.userCurve_replay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCurve_replay1.Location = new System.Drawing.Point(3, 3);
            this.userCurve_replay1.Name = "userCurve_replay1";
            this.userCurve_replay1.Size = new System.Drawing.Size(736, 199);
            this.userCurve_replay1.TabIndex = 2;
            this.userCurve_replay1.Title = "Replay Signal1";
            this.userCurve_replay1.ValueMaxLeft = 2F;
            this.userCurve_replay1.ValueMaxRight = 2F;
            this.userCurve_replay1.ValueMinLeft = -2F;
            this.userCurve_replay1.ValueMinRight = -2F;
            this.userCurve_replay1.ValueSegment = 2;
            this.userCurve_replay1.Paint += new System.Windows.Forms.PaintEventHandler(this.userCurve_replay1_Paint);
            // 
            // userCurve_replay2
            // 
            this.userCurve_replay2.BackColor = System.Drawing.Color.Transparent;
            this.userCurve_replay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCurve_replay2.Location = new System.Drawing.Point(745, 3);
            this.userCurve_replay2.Name = "userCurve_replay2";
            this.userCurve_replay2.Size = new System.Drawing.Size(736, 199);
            this.userCurve_replay2.TabIndex = 3;
            this.userCurve_replay2.Title = "Replay Signal2";
            this.userCurve_replay2.ValueMaxLeft = 2F;
            this.userCurve_replay2.ValueMaxRight = 2F;
            this.userCurve_replay2.ValueMinLeft = -2F;
            this.userCurve_replay2.ValueMinRight = -2F;
            this.userCurve_replay2.ValueSegment = 2;
            this.userCurve_replay2.Paint += new System.Windows.Forms.PaintEventHandler(this.userCurve_replay2_Paint);
            // 
            // userCurve1
            // 
            this.userCurve1.BackColor = System.Drawing.Color.Transparent;
            this.userCurve1.Location = new System.Drawing.Point(9, 24);
            this.userCurve1.Name = "userCurve1";
            this.userCurve1.Size = new System.Drawing.Size(1475, 303);
            this.userCurve1.StrechDataCountMax = 100;
            this.userCurve1.TabIndex = 1;
            this.userCurve1.TextAddFormat = "HH:mm:ss";
            this.userCurve1.Title = "Signal1";
            this.userCurve1.ValueMaxLeft = 2F;
            this.userCurve1.ValueMaxRight = 2F;
            this.userCurve1.ValueMinLeft = -2F;
            this.userCurve1.ValueMinRight = -2F;
            // 
            // userCurve2
            // 
            this.userCurve2.BackColor = System.Drawing.Color.Transparent;
            this.userCurve2.Location = new System.Drawing.Point(11, 324);
            this.userCurve2.Name = "userCurve2";
            this.userCurve2.Size = new System.Drawing.Size(1475, 307);
            this.userCurve2.TabIndex = 0;
            this.userCurve2.TextAddFormat = "HH:mm:ss";
            this.userCurve2.Title = "Signal2";
            this.userCurve2.ValueMaxLeft = 2F;
            this.userCurve2.ValueMaxRight = 2F;
            this.userCurve2.ValueMinLeft = -2F;
            this.userCurve2.ValueMinRight = -2F;
            // 
            // Choose_Time_Button
            // 
            this.Choose_Time_Button.CustomerInformation = null;
            this.Choose_Time_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose_Time_Button.ForeColor = System.Drawing.Color.OrangeRed;
            this.Choose_Time_Button.Location = new System.Drawing.Point(37, 681);
            this.Choose_Time_Button.Name = "Choose_Time_Button";
            this.Choose_Time_Button.SelectColor = System.Drawing.Color.Orange;
            this.Choose_Time_Button.Size = new System.Drawing.Size(114, 46);
            this.Choose_Time_Button.TabIndex = 8;
            this.Choose_Time_Button.Text = "Choose";
            this.Choose_Time_Button.Visible = false;
            this.Choose_Time_Button.Click += new System.EventHandler(this.Choose_Time_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 853);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EP3174 Analog Sungal_Gather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private HslCommunication.Controls.UserCurve userCurve1;
        private HslCommunication.Controls.UserCurve userCurve2;
        private HslControls.HslButton Gather_Button;
        private HslControls.HslButton Connect_Button;
        private HslCommunication.Controls.UserLantern userLantern1;
        private System.Windows.Forms.TextBox textBox1;
        private HslControls.HslButton DataScrub_Button;
        private HslCommunication.Controls.UserLantern userLantern2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private HslControls.HslButton Replay_Button;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private HslControls.HslButton Choose_Time_Button;
<<<<<<< HEAD
<<<<<<< HEAD
        public HslCommunication.Controls.UserCurve userCurve_replay1;
        public HslCommunication.Controls.UserCurve userCurve_replay2;
        private System.Windows.Forms.Label label_isGathering;
        private System.Windows.Forms.Label label_isConnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCollapseReplay;
=======
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
=======
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
    }
}

