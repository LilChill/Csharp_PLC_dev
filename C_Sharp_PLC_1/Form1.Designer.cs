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
            this.segment_name = new System.Windows.Forms.Label();
            this.well_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCollapseReplay = new System.Windows.Forms.Button();
            this.label_isGathering = new System.Windows.Forms.Label();
            this.label_isConnect = new System.Windows.Forms.Label();
            this.Export_Button1 = new HslControls.HslButton();
            this.Choose_Time_Button = new HslControls.HslButton();
            this.Replay_Button1 = new HslControls.HslButton();
            this.DataScrub_Button1 = new HslControls.HslButton();
            this.userLantern2 = new HslCommunication.Controls.UserLantern();
            this.userLantern1 = new HslCommunication.Controls.UserLantern();
            this.Gather_Button1 = new HslControls.HslButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer_replay = new System.Windows.Forms.SplitContainer();
            this.userCurve_replay2 = new HslCommunication.Controls.UserCurve();
            this.userCurve_replay1 = new HslCommunication.Controls.UserCurve();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.userCurve_detail1 = new HslCommunication.Controls.UserCurve();
            this.userCurve_detail2 = new HslCommunication.Controls.UserCurve();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Btn_Connect = new System.Windows.Forms.Label();
            this.label_Btn_Scrub = new System.Windows.Forms.Label();
            this.label_Btn_Gather = new System.Windows.Forms.Label();
            this.label_Btn_Replay = new System.Windows.Forms.Label();
            this.label_Btn_List = new System.Windows.Forms.Label();
            this.label_Btn_Setting = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown_start = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDown_end = new System.Windows.Forms.NumericUpDown();
            this.splitContainer_collect = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox_collect_well = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox_collect_segment = new System.Windows.Forms.ComboBox();
            this.button_collect_confirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.userCurve_collect1 = new HslCommunication.Controls.UserCurve();
            this.userCurve_collect2 = new HslCommunication.Controls.UserCurve();
            this.Export_Button = new System.Windows.Forms.Button();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.DataScrub_Button = new System.Windows.Forms.Button();
            this.Gather_Button = new System.Windows.Forms.Button();
            this.Replay_Button = new System.Windows.Forms.Button();
            this.List_Button = new System.Windows.Forms.Button();
            this.Setting_Button = new System.Windows.Forms.Button();
            this.Connect_Button1 = new HslControls.HslButton();
            this.myTabControl1 = new C_Sharp_PLC_1.MyTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button_replay_detail_confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_replay)).BeginInit();
            this.splitContainer_replay.Panel1.SuspendLayout();
            this.splitContainer_replay.Panel2.SuspendLayout();
            this.splitContainer_replay.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_collect)).BeginInit();
            this.splitContainer_collect.Panel1.SuspendLayout();
            this.splitContainer_collect.Panel2.SuspendLayout();
            this.splitContainer_collect.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Elapsed);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_collect_well);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_collect_segment);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnCollapseReplay);
            this.splitContainer1.Panel1.Controls.Add(this.label_isGathering);
            this.splitContainer1.Panel1.Controls.Add(this.label_isConnect);
            this.splitContainer1.Panel1.Controls.Add(this.Connect_Button1);
            this.splitContainer1.Panel1.Controls.Add(this.Export_Button1);
            this.splitContainer1.Panel1.Controls.Add(this.Choose_Time_Button);
            this.splitContainer1.Panel1.Controls.Add(this.Replay_Button1);
            this.splitContainer1.Panel1.Controls.Add(this.DataScrub_Button1);
            this.splitContainer1.Panel1.Controls.Add(this.userLantern2);
            this.splitContainer1.Panel1.Controls.Add(this.userLantern1);
            this.splitContainer1.Panel1.Controls.Add(this.Gather_Button1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer_replay);
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer_collect);
            this.splitContainer1.Panel2.Controls.Add(this.myTabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1737, 1101);
            this.splitContainer1.SplitterDistance = 124;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // segment_name
            // 
            this.segment_name.AutoSize = true;
            this.segment_name.BackColor = System.Drawing.Color.Transparent;
            this.segment_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segment_name.Location = new System.Drawing.Point(117, 3);
            this.segment_name.Margin = new System.Windows.Forms.Padding(3);
            this.segment_name.Name = "segment_name";
            this.segment_name.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.segment_name.Size = new System.Drawing.Size(0, 29);
            this.segment_name.TabIndex = 12;
            // 
            // well_name
            // 
            this.well_name.AutoSize = true;
            this.well_name.BackColor = System.Drawing.Color.Transparent;
            this.well_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.well_name.Location = new System.Drawing.Point(57, 3);
            this.well_name.Margin = new System.Windows.Forms.Padding(3);
            this.well_name.Name = "well_name";
            this.well_name.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.well_name.Size = new System.Drawing.Size(0, 29);
            this.well_name.TabIndex = 12;
            this.well_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(1271, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "井号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(1454, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "段号:";
            // 
            // btnCollapseReplay
            // 
            this.btnCollapseReplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCollapseReplay.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCollapseReplay.Location = new System.Drawing.Point(1679, 93);
            this.btnCollapseReplay.Name = "btnCollapseReplay";
            this.btnCollapseReplay.Size = new System.Drawing.Size(44, 24);
            this.btnCollapseReplay.TabIndex = 5;
            this.btnCollapseReplay.Text = "展开";
            this.btnCollapseReplay.UseVisualStyleBackColor = true;
            this.btnCollapseReplay.Click += new System.EventHandler(this.btnCollapseReplay_Click);
            // 
            // label_isGathering
            // 
            this.label_isGathering.AutoSize = true;
            this.label_isGathering.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_isGathering.Location = new System.Drawing.Point(1156, 67);
            this.label_isGathering.Name = "label_isGathering";
            this.label_isGathering.Size = new System.Drawing.Size(51, 19);
            this.label_isGathering.TabIndex = 9;
            this.label_isGathering.Text = "未采集";
            // 
            // label_isConnect
            // 
            this.label_isConnect.AutoSize = true;
            this.label_isConnect.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_isConnect.Location = new System.Drawing.Point(1037, 67);
            this.label_isConnect.Name = "label_isConnect";
            this.label_isConnect.Size = new System.Drawing.Size(51, 19);
            this.label_isConnect.TabIndex = 9;
            this.label_isConnect.Text = "未连接";
            // 
            // Export_Button1
            // 
            this.Export_Button1.CustomerInformation = null;
            this.Export_Button1.EnableColor = System.Drawing.Color.White;
            this.Export_Button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export_Button1.ForeColor = System.Drawing.Color.Black;
            this.Export_Button1.Location = new System.Drawing.Point(1470, 10);
            this.Export_Button1.Name = "Export_Button1";
            this.Export_Button1.SelectColor = System.Drawing.Color.Orange;
            this.Export_Button1.Size = new System.Drawing.Size(97, 32);
            this.Export_Button1.TabIndex = 8;
            this.Export_Button1.Text = "导出";
            this.Export_Button1.Visible = false;
            this.Export_Button1.Click += new System.EventHandler(this.Export_Button_Click);
            // 
            // Choose_Time_Button
            // 
            this.Choose_Time_Button.CustomerInformation = null;
            this.Choose_Time_Button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose_Time_Button.ForeColor = System.Drawing.Color.Chocolate;
            this.Choose_Time_Button.Location = new System.Drawing.Point(1585, 10);
            this.Choose_Time_Button.Name = "Choose_Time_Button";
            this.Choose_Time_Button.SelectColor = System.Drawing.Color.Orange;
            this.Choose_Time_Button.Size = new System.Drawing.Size(98, 32);
            this.Choose_Time_Button.TabIndex = 8;
            this.Choose_Time_Button.Text = "选择时间段";
            this.Choose_Time_Button.Visible = false;
            this.Choose_Time_Button.Click += new System.EventHandler(this.Choose_Time_Button_Click);
            // 
            // Replay_Button1
            // 
            this.Replay_Button1.CustomerInformation = null;
            this.Replay_Button1.Enabled = false;
            this.Replay_Button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replay_Button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.Replay_Button1.Location = new System.Drawing.Point(1350, 10);
            this.Replay_Button1.Name = "Replay_Button1";
            this.Replay_Button1.SelectColor = System.Drawing.Color.Orange;
            this.Replay_Button1.Size = new System.Drawing.Size(99, 32);
            this.Replay_Button1.TabIndex = 8;
            this.Replay_Button1.Text = "数据回放";
            this.Replay_Button1.Visible = false;
            this.Replay_Button1.Click += new System.EventHandler(this.Replay_Button_Click);
            // 
            // DataScrub_Button1
            // 
            this.DataScrub_Button1.CustomerInformation = null;
            this.DataScrub_Button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataScrub_Button1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.DataScrub_Button1.Location = new System.Drawing.Point(1113, 10);
            this.DataScrub_Button1.Name = "DataScrub_Button1";
            this.DataScrub_Button1.Size = new System.Drawing.Size(92, 32);
            this.DataScrub_Button1.TabIndex = 5;
            this.DataScrub_Button1.Text = "清空";
            this.DataScrub_Button1.Click += new System.EventHandler(this.DataScrub_Button_Click);
            // 
            // userLantern2
            // 
            this.userLantern2.BackColor = System.Drawing.Color.Transparent;
            this.userLantern2.LanternBackground = System.Drawing.Color.Red;
            this.userLantern2.Location = new System.Drawing.Point(1118, 64);
            this.userLantern2.Margin = new System.Windows.Forms.Padding(9);
            this.userLantern2.Name = "userLantern2";
            this.userLantern2.Size = new System.Drawing.Size(26, 25);
            this.userLantern2.TabIndex = 4;
            // 
            // userLantern1
            // 
            this.userLantern1.BackColor = System.Drawing.Color.Transparent;
            this.userLantern1.LanternBackground = System.Drawing.Color.Red;
            this.userLantern1.Location = new System.Drawing.Point(1002, 64);
            this.userLantern1.Margin = new System.Windows.Forms.Padding(6);
            this.userLantern1.Name = "userLantern1";
            this.userLantern1.Size = new System.Drawing.Size(26, 25);
            this.userLantern1.TabIndex = 4;
            // 
            // Gather_Button1
            // 
            this.Gather_Button1.CustomerInformation = null;
            this.Gather_Button1.Enabled = false;
            this.Gather_Button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gather_Button1.ForeColor = System.Drawing.Color.Blue;
            this.Gather_Button1.Location = new System.Drawing.Point(1232, 10);
            this.Gather_Button1.Name = "Gather_Button1";
            this.Gather_Button1.Size = new System.Drawing.Size(92, 32);
            this.Gather_Button1.TabIndex = 2;
            this.Gather_Button1.Text = "开始采集";
            this.Gather_Button1.Click += new System.EventHandler(this.Gather_Button_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1465, 759);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer_replay
            // 
            this.splitContainer_replay.Location = new System.Drawing.Point(248, 19);
            this.splitContainer_replay.Name = "splitContainer_replay";
            this.splitContainer_replay.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_replay.Panel1
            // 
            this.splitContainer_replay.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer_replay.Panel2
            // 
            this.splitContainer_replay.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer_replay.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer_replay.Size = new System.Drawing.Size(1459, 789);
            this.splitContainer_replay.SplitterDistance = 188;
            this.splitContainer_replay.SplitterWidth = 10;
            this.splitContainer_replay.TabIndex = 5;
            this.splitContainer_replay.Visible = false;
            // 
            // userCurve_replay2
            // 
            this.userCurve_replay2.BackColor = System.Drawing.Color.Transparent;
            this.userCurve_replay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCurve_replay2.IsAbscissaStrech = true;
            this.userCurve_replay2.Location = new System.Drawing.Point(732, 4);
            this.userCurve_replay2.Margin = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.userCurve_replay2.Name = "userCurve_replay2";
            this.userCurve_replay2.Size = new System.Drawing.Size(717, 111);
            this.userCurve_replay2.TabIndex = 3;
            this.userCurve_replay2.Title = "Replay Signal2";
            this.userCurve_replay2.ValueMaxLeft = 2F;
            this.userCurve_replay2.ValueMaxRight = 2F;
            this.userCurve_replay2.ValueMinLeft = -2F;
            this.userCurve_replay2.ValueMinRight = -2F;
            this.userCurve_replay2.ValueSegment = 2;
            // 
            // userCurve_replay1
            // 
            this.userCurve_replay1.BackColor = System.Drawing.Color.Transparent;
            this.userCurve_replay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCurve_replay1.IsAbscissaStrech = true;
            this.userCurve_replay1.Location = new System.Drawing.Point(4, 4);
            this.userCurve_replay1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userCurve_replay1.Name = "userCurve_replay1";
            this.userCurve_replay1.Size = new System.Drawing.Size(718, 111);
            this.userCurve_replay1.TabIndex = 2;
            this.userCurve_replay1.Title = "Replay Signal1";
            this.userCurve_replay1.ValueMaxLeft = 2F;
            this.userCurve_replay1.ValueMaxRight = 2F;
            this.userCurve_replay1.ValueMinLeft = -2F;
            this.userCurve_replay1.ValueMinRight = -2F;
            this.userCurve_replay1.ValueSegment = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.userCurve_detail1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.userCurve_detail2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1459, 591);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // userCurve_detail1
            // 
            this.userCurve_detail1.BackColor = System.Drawing.Color.Transparent;
            this.userCurve_detail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCurve_detail1.Location = new System.Drawing.Point(4, 4);
            this.userCurve_detail1.Margin = new System.Windows.Forms.Padding(4);
            this.userCurve_detail1.Name = "userCurve_detail1";
            this.userCurve_detail1.Size = new System.Drawing.Size(1451, 277);
            this.userCurve_detail1.StrechDataCountMax = 100;
            this.userCurve_detail1.TabIndex = 1;
            this.userCurve_detail1.TextAddFormat = "HH:mm:ss";
            this.userCurve_detail1.Title = "Signal1";
            this.userCurve_detail1.ValueMaxLeft = 2F;
            this.userCurve_detail1.ValueMaxRight = 2F;
            this.userCurve_detail1.ValueMinLeft = -2F;
            this.userCurve_detail1.ValueMinRight = -2F;
            this.userCurve_detail1.ValueSegment = 10;
            // 
            // userCurve_detail2
            // 
            this.userCurve_detail2.BackColor = System.Drawing.Color.Transparent;
            this.userCurve_detail2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCurve_detail2.Location = new System.Drawing.Point(4, 289);
            this.userCurve_detail2.Margin = new System.Windows.Forms.Padding(4);
            this.userCurve_detail2.Name = "userCurve_detail2";
            this.userCurve_detail2.Size = new System.Drawing.Size(1451, 277);
            this.userCurve_detail2.TabIndex = 0;
            this.userCurve_detail2.TextAddFormat = "HH:mm:ss";
            this.userCurve_detail2.Title = "Signal2";
            this.userCurve_detail2.ValueMaxLeft = 2F;
            this.userCurve_detail2.ValueMaxRight = 2F;
            this.userCurve_detail2.ValueMinLeft = -2F;
            this.userCurve_detail2.ValueMinRight = -2F;
            this.userCurve_detail2.ValueSegment = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Controls.Add(this.Connect_Button, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DataScrub_Button, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Gather_Button, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Replay_Button, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.List_Button, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.Setting_Button, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_Btn_Connect, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label_Btn_Scrub, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label_Btn_Gather, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label_Btn_Replay, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label_Btn_List, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.label_Btn_Setting, 5, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(14, 10);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(852, 103);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // label_Btn_Connect
            // 
            this.label_Btn_Connect.AutoSize = true;
            this.label_Btn_Connect.BackColor = System.Drawing.Color.Transparent;
            this.label_Btn_Connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Btn_Connect.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Btn_Connect.Location = new System.Drawing.Point(3, 82);
            this.label_Btn_Connect.Name = "label_Btn_Connect";
            this.label_Btn_Connect.Size = new System.Drawing.Size(136, 21);
            this.label_Btn_Connect.TabIndex = 14;
            this.label_Btn_Connect.Text = "连接";
            this.label_Btn_Connect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Btn_Scrub
            // 
            this.label_Btn_Scrub.AutoSize = true;
            this.label_Btn_Scrub.BackColor = System.Drawing.Color.Transparent;
            this.label_Btn_Scrub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Btn_Scrub.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Btn_Scrub.Location = new System.Drawing.Point(145, 82);
            this.label_Btn_Scrub.Name = "label_Btn_Scrub";
            this.label_Btn_Scrub.Size = new System.Drawing.Size(136, 21);
            this.label_Btn_Scrub.TabIndex = 14;
            this.label_Btn_Scrub.Text = "清空";
            this.label_Btn_Scrub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Btn_Gather
            // 
            this.label_Btn_Gather.AutoSize = true;
            this.label_Btn_Gather.BackColor = System.Drawing.Color.Transparent;
            this.label_Btn_Gather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Btn_Gather.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Btn_Gather.Location = new System.Drawing.Point(287, 82);
            this.label_Btn_Gather.Name = "label_Btn_Gather";
            this.label_Btn_Gather.Size = new System.Drawing.Size(136, 21);
            this.label_Btn_Gather.TabIndex = 14;
            this.label_Btn_Gather.Text = "数据采集";
            this.label_Btn_Gather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Btn_Replay
            // 
            this.label_Btn_Replay.AutoSize = true;
            this.label_Btn_Replay.BackColor = System.Drawing.Color.Transparent;
            this.label_Btn_Replay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Btn_Replay.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Btn_Replay.Location = new System.Drawing.Point(429, 82);
            this.label_Btn_Replay.Name = "label_Btn_Replay";
            this.label_Btn_Replay.Size = new System.Drawing.Size(136, 21);
            this.label_Btn_Replay.TabIndex = 14;
            this.label_Btn_Replay.Text = "数据回放";
            this.label_Btn_Replay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Btn_List
            // 
            this.label_Btn_List.AutoSize = true;
            this.label_Btn_List.BackColor = System.Drawing.Color.Transparent;
            this.label_Btn_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Btn_List.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Btn_List.Location = new System.Drawing.Point(571, 82);
            this.label_Btn_List.Name = "label_Btn_List";
            this.label_Btn_List.Size = new System.Drawing.Size(136, 21);
            this.label_Btn_List.TabIndex = 14;
            this.label_Btn_List.Text = "井列表";
            this.label_Btn_List.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Btn_Setting
            // 
            this.label_Btn_Setting.AutoSize = true;
            this.label_Btn_Setting.BackColor = System.Drawing.Color.Transparent;
            this.label_Btn_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Btn_Setting.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Btn_Setting.Location = new System.Drawing.Point(713, 82);
            this.label_Btn_Setting.Name = "label_Btn_Setting";
            this.label_Btn_Setting.Size = new System.Drawing.Size(136, 21);
            this.label_Btn_Setting.TabIndex = 14;
            this.label_Btn_Setting.Text = "设置";
            this.label_Btn_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(891, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(891, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.1497F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.8503F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1459, 188);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.userCurve_replay2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.userCurve_replay1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 45);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1453, 119);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label14);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown_start);
            this.flowLayoutPanel1.Controls.Add(this.label15);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown_end);
            this.flowLayoutPanel1.Controls.Add(this.button_replay_detail_confirm);
            this.flowLayoutPanel1.Controls.Add(this.Export_Button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1453, 36);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(3, 3);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label14.Size = new System.Drawing.Size(79, 29);
            this.label14.TabIndex = 6;
            this.label14.Text = "起始时间：";
            // 
            // numericUpDown_start
            // 
            this.numericUpDown_start.Location = new System.Drawing.Point(85, 3);
            this.numericUpDown_start.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.numericUpDown_start.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown_start.Name = "numericUpDown_start";
            this.numericUpDown_start.Size = new System.Drawing.Size(54, 29);
            this.numericUpDown_start.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(152, 3);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label15.Size = new System.Drawing.Size(79, 29);
            this.label15.TabIndex = 8;
            this.label15.Text = "结束时间：";
            // 
            // numericUpDown_end
            // 
            this.numericUpDown_end.Location = new System.Drawing.Point(234, 3);
            this.numericUpDown_end.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.numericUpDown_end.Name = "numericUpDown_end";
            this.numericUpDown_end.Size = new System.Drawing.Size(54, 29);
            this.numericUpDown_end.TabIndex = 9;
            // 
            // splitContainer_collect
            // 
            this.splitContainer_collect.Location = new System.Drawing.Point(163, 26);
            this.splitContainer_collect.Name = "splitContainer_collect";
            this.splitContainer_collect.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_collect.Panel1
            // 
            this.splitContainer_collect.Panel1.Controls.Add(this.tableLayoutPanel5);
            // 
            // splitContainer_collect.Panel2
            // 
            this.splitContainer_collect.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer_collect.Panel2.Controls.Add(this.tableLayoutPanel7);
            this.splitContainer_collect.Size = new System.Drawing.Size(1459, 789);
            this.splitContainer_collect.SplitterDistance = 47;
            this.splitContainer_collect.SplitterWidth = 10;
            this.splitContainer_collect.TabIndex = 7;
            this.splitContainer_collect.Visible = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.84615F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.153846F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1459, 47);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label16);
            this.flowLayoutPanel2.Controls.Add(this.well_name);
            this.flowLayoutPanel2.Controls.Add(this.label17);
            this.flowLayoutPanel2.Controls.Add(this.segment_name);
            this.flowLayoutPanel2.Controls.Add(this.button_collect_confirm);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1453, 38);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(3, 3);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label16.Size = new System.Drawing.Size(51, 29);
            this.label16.TabIndex = 2;
            this.label16.Text = "井号：";
            // 
            // comboBox_collect_well
            // 
            this.comboBox_collect_well.FormattingEnabled = true;
            this.comboBox_collect_well.Location = new System.Drawing.Point(1320, 62);
            this.comboBox_collect_well.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.comboBox_collect_well.Name = "comboBox_collect_well";
            this.comboBox_collect_well.Size = new System.Drawing.Size(121, 30);
            this.comboBox_collect_well.TabIndex = 1;
            this.comboBox_collect_well.SelectedIndexChanged += new System.EventHandler(this.comboBox_collect_well_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(63, 3);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label17.Size = new System.Drawing.Size(51, 29);
            this.label17.TabIndex = 4;
            this.label17.Text = "段号：";
            // 
            // comboBox_collect_segment
            // 
            this.comboBox_collect_segment.FormattingEnabled = true;
            this.comboBox_collect_segment.Location = new System.Drawing.Point(1501, 62);
            this.comboBox_collect_segment.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.comboBox_collect_segment.Name = "comboBox_collect_segment";
            this.comboBox_collect_segment.Size = new System.Drawing.Size(121, 30);
            this.comboBox_collect_segment.TabIndex = 3;
            this.comboBox_collect_segment.SelectedIndexChanged += new System.EventHandler(this.comboBox_collect_segment_SelectedIndexChanged);
            // 
            // button_collect_confirm
            // 
            this.button_collect_confirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_collect_confirm.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_collect_confirm.Location = new System.Drawing.Point(140, 3);
            this.button_collect_confirm.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.button_collect_confirm.Name = "button_collect_confirm";
            this.button_collect_confirm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_collect_confirm.Size = new System.Drawing.Size(75, 29);
            this.button_collect_confirm.TabIndex = 10;
            this.button_collect_confirm.Text = "开始采集";
            this.button_collect_confirm.UseVisualStyleBackColor = true;
            this.button_collect_confirm.Click += new System.EventHandler(this.button_collect_confirm_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.userCurve_collect2, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.userCurve_collect1, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1459, 732);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // userCurve_collect1
            // 
            this.userCurve_collect1.BackColor = System.Drawing.Color.Transparent;
            this.userCurve_collect1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCurve_collect1.Location = new System.Drawing.Point(4, 4);
            this.userCurve_collect1.Margin = new System.Windows.Forms.Padding(4);
            this.userCurve_collect1.Name = "userCurve_collect1";
            this.userCurve_collect1.Size = new System.Drawing.Size(1451, 348);
            this.userCurve_collect1.StrechDataCountMax = 100;
            this.userCurve_collect1.TabIndex = 1;
            this.userCurve_collect1.TextAddFormat = "HH:mm:ss";
            this.userCurve_collect1.Title = "Signal1";
            this.userCurve_collect1.ValueMaxLeft = 2F;
            this.userCurve_collect1.ValueMaxRight = 2F;
            this.userCurve_collect1.ValueMinLeft = -2F;
            this.userCurve_collect1.ValueMinRight = -2F;
            this.userCurve_collect1.ValueSegment = 10;
            // 
            // userCurve_collect2
            // 
            this.userCurve_collect2.BackColor = System.Drawing.Color.Transparent;
            this.userCurve_collect2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCurve_collect2.Location = new System.Drawing.Point(4, 360);
            this.userCurve_collect2.Margin = new System.Windows.Forms.Padding(4);
            this.userCurve_collect2.Name = "userCurve_collect2";
            this.userCurve_collect2.Size = new System.Drawing.Size(1451, 348);
            this.userCurve_collect2.TabIndex = 0;
            this.userCurve_collect2.TextAddFormat = "HH:mm:ss";
            this.userCurve_collect2.Title = "Signal2";
            this.userCurve_collect2.ValueMaxLeft = 2F;
            this.userCurve_collect2.ValueMaxRight = 2F;
            this.userCurve_collect2.ValueMinLeft = -2F;
            this.userCurve_collect2.ValueMinRight = -2F;
            this.userCurve_collect2.ValueSegment = 10;
            // 
            // Export_Button
            // 
            this.Export_Button.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export_Button.Location = new System.Drawing.Point(406, 3);
            this.Export_Button.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.Export_Button.Name = "Export_Button";
            this.Export_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Export_Button.Size = new System.Drawing.Size(75, 30);
            this.Export_Button.TabIndex = 10;
            this.Export_Button.Text = "导出";
            this.Export_Button.UseVisualStyleBackColor = true;
            this.Export_Button.Click += new System.EventHandler(this.Export_Button_Click);
            // 
            // Connect_Button
            // 
            this.Connect_Button.BackColor = System.Drawing.Color.Transparent;
            this.Connect_Button.BackgroundImage = global::C_Sharp_PLC_1.Properties.Resources.connect;
            this.Connect_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Connect_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Connect_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Connect_Button.FlatAppearance.BorderSize = 0;
            this.Connect_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.Connect_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.Connect_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connect_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Connect_Button.Location = new System.Drawing.Point(3, 3);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(136, 76);
            this.Connect_Button.TabIndex = 13;
            this.Connect_Button.UseVisualStyleBackColor = false;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // DataScrub_Button
            // 
            this.DataScrub_Button.BackColor = System.Drawing.Color.Transparent;
            this.DataScrub_Button.BackgroundImage = global::C_Sharp_PLC_1.Properties.Resources.clear;
            this.DataScrub_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DataScrub_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataScrub_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataScrub_Button.FlatAppearance.BorderSize = 0;
            this.DataScrub_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.DataScrub_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.DataScrub_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataScrub_Button.Location = new System.Drawing.Point(145, 3);
            this.DataScrub_Button.Name = "DataScrub_Button";
            this.DataScrub_Button.Size = new System.Drawing.Size(136, 76);
            this.DataScrub_Button.TabIndex = 13;
            this.DataScrub_Button.UseVisualStyleBackColor = false;
            this.DataScrub_Button.Click += new System.EventHandler(this.DataScrub_Button_Click);
            // 
            // Gather_Button
            // 
            this.Gather_Button.BackColor = System.Drawing.Color.Transparent;
            this.Gather_Button.BackgroundImage = global::C_Sharp_PLC_1.Properties.Resources.collect;
            this.Gather_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gather_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gather_Button.Enabled = false;
            this.Gather_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Gather_Button.FlatAppearance.BorderSize = 0;
            this.Gather_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.Gather_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.Gather_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gather_Button.Location = new System.Drawing.Point(287, 3);
            this.Gather_Button.Name = "Gather_Button";
            this.Gather_Button.Size = new System.Drawing.Size(136, 76);
            this.Gather_Button.TabIndex = 13;
            this.Gather_Button.UseVisualStyleBackColor = false;
            this.Gather_Button.Click += new System.EventHandler(this.Gather_Button_Click);
            // 
            // Replay_Button
            // 
            this.Replay_Button.BackColor = System.Drawing.Color.Transparent;
            this.Replay_Button.BackgroundImage = global::C_Sharp_PLC_1.Properties.Resources.历史记录;
            this.Replay_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Replay_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Replay_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Replay_Button.FlatAppearance.BorderSize = 0;
            this.Replay_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.Replay_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.Replay_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Replay_Button.Location = new System.Drawing.Point(429, 3);
            this.Replay_Button.Name = "Replay_Button";
            this.Replay_Button.Size = new System.Drawing.Size(136, 76);
            this.Replay_Button.TabIndex = 13;
            this.Replay_Button.UseVisualStyleBackColor = false;
            this.Replay_Button.Click += new System.EventHandler(this.Replay_Button_Click);
            // 
            // List_Button
            // 
            this.List_Button.BackColor = System.Drawing.Color.Transparent;
            this.List_Button.BackgroundImage = global::C_Sharp_PLC_1.Properties.Resources.list;
            this.List_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.List_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.List_Button.FlatAppearance.BorderSize = 0;
            this.List_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.List_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.List_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.List_Button.Location = new System.Drawing.Point(571, 3);
            this.List_Button.Name = "List_Button";
            this.List_Button.Size = new System.Drawing.Size(136, 76);
            this.List_Button.TabIndex = 13;
            this.List_Button.UseVisualStyleBackColor = false;
            // 
            // Setting_Button
            // 
            this.Setting_Button.BackColor = System.Drawing.Color.Transparent;
            this.Setting_Button.BackgroundImage = global::C_Sharp_PLC_1.Properties.Resources.setting;
            this.Setting_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Setting_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Setting_Button.FlatAppearance.BorderSize = 0;
            this.Setting_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.Setting_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.Setting_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting_Button.Location = new System.Drawing.Point(713, 3);
            this.Setting_Button.Name = "Setting_Button";
            this.Setting_Button.Size = new System.Drawing.Size(136, 76);
            this.Setting_Button.TabIndex = 13;
            this.Setting_Button.UseVisualStyleBackColor = false;
            this.Setting_Button.Click += new System.EventHandler(this.Setting_Button_Click);
            // 
            // Connect_Button1
            // 
            this.Connect_Button1.BackgroundImage = global::C_Sharp_PLC_1.Properties.Resources.connect;
            this.Connect_Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Connect_Button1.CustomerInformation = null;
            this.Connect_Button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Connect_Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Connect_Button1.Location = new System.Drawing.Point(1002, 10);
            this.Connect_Button1.Name = "Connect_Button1";
            this.Connect_Button1.SelectColor = System.Drawing.Color.DarkRed;
            this.Connect_Button1.Size = new System.Drawing.Size(83, 32);
            this.Connect_Button1.TabIndex = 0;
            this.Connect_Button1.Text = "连接";
            this.Connect_Button1.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // myTabControl1
            // 
            this.myTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.myTabControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myTabControl1.ItemSize = new System.Drawing.Size(120, 25);
            this.myTabControl1.Location = new System.Drawing.Point(64, 220);
            this.myTabControl1.Name = "myTabControl1";
            this.myTabControl1.SelectedIndex = 0;
            this.myTabControl1.Size = new System.Drawing.Size(429, 317);
            this.myTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.myTabControl1.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(421, 284);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(421, 284);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button_replay_detail_confirm
            // 
            this.button_replay_detail_confirm.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_replay_detail_confirm.Location = new System.Drawing.Point(308, 3);
            this.button_replay_detail_confirm.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.button_replay_detail_confirm.Name = "button_replay_detail_confirm";
            this.button_replay_detail_confirm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_replay_detail_confirm.Size = new System.Drawing.Size(75, 30);
            this.button_replay_detail_confirm.TabIndex = 10;
            this.button_replay_detail_confirm.Text = "确定";
            this.button_replay_detail_confirm.UseVisualStyleBackColor = true;
            this.button_replay_detail_confirm.Click += new System.EventHandler(this.button_replay_detail_confirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1737, 1101);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EP3174 Analog Signal_Gather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer_replay.Panel1.ResumeLayout(false);
            this.splitContainer_replay.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_replay)).EndInit();
            this.splitContainer_replay.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_end)).EndInit();
            this.splitContainer_collect.Panel1.ResumeLayout(false);
            this.splitContainer_collect.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_collect)).EndInit();
            this.splitContainer_collect.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private HslControls.HslButton Gather_Button1;
        private HslControls.HslButton Connect_Button1;
        private HslCommunication.Controls.UserLantern userLantern1;
        private HslControls.HslButton DataScrub_Button1;
        private HslCommunication.Controls.UserLantern userLantern2;
        private System.Windows.Forms.Timer timer1;
        private HslControls.HslButton Replay_Button1;
        private HslControls.HslButton Choose_Time_Button;
        private System.Windows.Forms.Label label_isGathering;
        private System.Windows.Forms.Label label_isConnect;
        private System.Windows.Forms.Button btnCollapseReplay;
        public HslControls.HslButton Export_Button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label segment_name;
        public System.Windows.Forms.Label well_name;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer_replay;
        public HslCommunication.Controls.UserCurve userCurve_replay2;
        public HslCommunication.Controls.UserCurve userCurve_replay1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public HslCommunication.Controls.UserCurve userCurve_detail1;
        public HslCommunication.Controls.UserCurve userCurve_detail2;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button DataScrub_Button;
        private System.Windows.Forms.Button Gather_Button;
        private System.Windows.Forms.Button Replay_Button;
        private System.Windows.Forms.Button List_Button;
        private System.Windows.Forms.Button Setting_Button;
        private System.Windows.Forms.Label label_Btn_Connect;
        private System.Windows.Forms.Label label_Btn_Scrub;
        private System.Windows.Forms.Label label_Btn_Gather;
        private System.Windows.Forms.Label label_Btn_Replay;
        private System.Windows.Forms.Label label_Btn_List;
        private System.Windows.Forms.Label label_Btn_Setting;
        private MyTabControl myTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown_start;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDown_end;
        private System.Windows.Forms.SplitContainer splitContainer_collect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox_collect_well;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox_collect_segment;
        private System.Windows.Forms.Button button_collect_confirm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        public HslCommunication.Controls.UserCurve userCurve_collect1;
        public HslCommunication.Controls.UserCurve userCurve_collect2;
        private System.Windows.Forms.Button Export_Button;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button_replay_detail_confirm;
    }
}

