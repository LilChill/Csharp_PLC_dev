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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Review_Button = new HslControls.HslButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DataScrub_Button = new HslControls.HslButton();
            this.userLantern2 = new HslCommunication.Controls.UserLantern();
            this.userLantern1 = new HslCommunication.Controls.UserLantern();
            this.Stop_Button = new HslControls.HslButton();
            this.Gather_Button = new HslControls.HslButton();
            this.Disconnect_Button = new HslControls.HslButton();
            this.Connect_Button = new HslControls.HslButton();
            this.userCurve1 = new HslCommunication.Controls.UserCurve();
            this.userCurve2 = new HslCommunication.Controls.UserCurve();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.textBox3);
            this.splitContainer1.Panel1.Controls.Add(this.Review_Button);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.DataScrub_Button);
            this.splitContainer1.Panel1.Controls.Add(this.userLantern2);
            this.splitContainer1.Panel1.Controls.Add(this.userLantern1);
            this.splitContainer1.Panel1.Controls.Add(this.Stop_Button);
            this.splitContainer1.Panel1.Controls.Add(this.Gather_Button);
            this.splitContainer1.Panel1.Controls.Add(this.Disconnect_Button);
            this.splitContainer1.Panel1.Controls.Add(this.Connect_Button);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.userCurve1);
            this.splitContainer1.Panel2.Controls.Add(this.userCurve2);
            this.splitContainer1.Size = new System.Drawing.Size(1420, 710);
            this.splitContainer1.SplitterDistance = 106;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(770, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(318, 29);
            this.textBox3.TabIndex = 9;
            // 
            // Review_Button
            // 
            this.Review_Button.CustomerInformation = null;
            this.Review_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Review_Button.ForeColor = System.Drawing.Color.OrangeRed;
            this.Review_Button.Location = new System.Drawing.Point(1226, 25);
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
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "PORT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "AMSNETID:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(115, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "851";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(115, 16);
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
            this.DataScrub_Button.Location = new System.Drawing.Point(770, 25);
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
            this.userLantern2.Location = new System.Drawing.Point(684, 20);
            this.userLantern2.Margin = new System.Windows.Forms.Padding(9);
            this.userLantern2.Name = "userLantern2";
            this.userLantern2.Size = new System.Drawing.Size(57, 53);
            this.userLantern2.TabIndex = 4;
            // 
            // userLantern1
            // 
            this.userLantern1.BackColor = System.Drawing.Color.Transparent;
            this.userLantern1.LanternBackground = System.Drawing.Color.DarkGray;
            this.userLantern1.Location = new System.Drawing.Point(304, 20);
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
            this.Stop_Button.Location = new System.Drawing.Point(1070, 25);
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
            this.Gather_Button.Location = new System.Drawing.Point(923, 25);
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
            this.Disconnect_Button.Location = new System.Drawing.Point(538, 25);
            this.Disconnect_Button.Name = "Disconnect_Button";
            this.Disconnect_Button.Size = new System.Drawing.Size(114, 46);
            this.Disconnect_Button.TabIndex = 1;
            this.Disconnect_Button.Text = "Disconnect";
            this.Disconnect_Button.Click += new System.EventHandler(this.Disconnect_Button_Click);
            // 
            // Connect_Button
            // 
            this.Connect_Button.CustomerInformation = null;
            this.Connect_Button.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Connect_Button.Location = new System.Drawing.Point(389, 25);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.SelectColor = System.Drawing.Color.DarkRed;
            this.Connect_Button.Size = new System.Drawing.Size(114, 46);
            this.Connect_Button.TabIndex = 0;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // userCurve1
            // 
            this.userCurve1.BackColor = System.Drawing.Color.Transparent;
            this.userCurve1.Location = new System.Drawing.Point(-2, 6);
            this.userCurve1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.userCurve1.Name = "userCurve1";
            this.userCurve1.Size = new System.Drawing.Size(1420, 290);
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
            this.userCurve2.Location = new System.Drawing.Point(-2, 299);
            this.userCurve2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.userCurve2.Name = "userCurve2";
            this.userCurve2.Size = new System.Drawing.Size(1420, 290);
            this.userCurve2.TabIndex = 0;
            this.userCurve2.TextAddFormat = "HH:mm:ss";
            this.userCurve2.Title = "Signal2";
            this.userCurve2.ValueMaxLeft = 2F;
            this.userCurve2.ValueMaxRight = 2F;
            this.userCurve2.ValueMinLeft = -2F;
            this.userCurve2.ValueMinRight = -2F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 710);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private HslCommunication.Controls.UserCurve userCurve1;
        private HslCommunication.Controls.UserCurve userCurve2;
        private HslControls.HslButton Stop_Button;
        private HslControls.HslButton Gather_Button;
        private HslControls.HslButton Disconnect_Button;
        private HslControls.HslButton Connect_Button;
        private HslCommunication.Controls.UserLantern userLantern1;
        private System.Windows.Forms.TextBox textBox1;
        private HslControls.HslButton DataScrub_Button;
        private HslCommunication.Controls.UserLantern userLantern2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private HslControls.HslButton Review_Button;
        private System.Windows.Forms.TextBox textBox3;
    }
}

