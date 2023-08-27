
namespace DateTimeIntervelControl
{
    partial class DateTimeIntervelPopup
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSure = new System.Windows.Forms.Button();
            this.calendarStart = new System.Windows.Forms.MonthCalendar();
            this.calendarEnd = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeEnd = new DateTimeIntervelControl.TimeSetting();
            this.timeStart = new DateTimeIntervelControl.TimeSetting();
            this.SuspendLayout();
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(440, 259);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 23);
            this.btnSure.TabIndex = 0;
            this.btnSure.Text = "确定";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // calendarStart
            // 
            this.calendarStart.Location = new System.Drawing.Point(21, 31);
            this.calendarStart.MaxSelectionCount = 1;
            this.calendarStart.Name = "calendarStart";
            this.calendarStart.ShowToday = false;
            this.calendarStart.ShowTodayCircle = false;
            this.calendarStart.TabIndex = 1;
            this.calendarStart.TodayDate = new System.DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // calendarEnd
            // 
            this.calendarEnd.Location = new System.Drawing.Point(295, 31);
            this.calendarEnd.Name = "calendarEnd";
            this.calendarEnd.ShowToday = false;
            this.calendarEnd.ShowTodayCircle = false;
            this.calendarEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "开始";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "结束";
            // 
            // timeEnd
            // 
            this.timeEnd.Location = new System.Drawing.Point(318, 220);
            this.timeEnd.MyTime = "0:0:0";
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Size = new System.Drawing.Size(180, 21);
            this.timeEnd.TabIndex = 3;
            // 
            // timeStart
            // 
            this.timeStart.Location = new System.Drawing.Point(40, 220);
            this.timeStart.MyTime = "0:0:0";
            this.timeStart.Name = "timeStart";
            this.timeStart.Size = new System.Drawing.Size(184, 21);
            this.timeStart.TabIndex = 3;
            // 
            // DateTimeIntervelPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendarEnd);
            this.Controls.Add(this.calendarStart);
            this.Controls.Add(this.btnSure);
            this.Name = "DateTimeIntervelPopup";
            this.Size = new System.Drawing.Size(551, 297);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public TimeSetting timeStart;
        public TimeSetting timeEnd;
        public System.Windows.Forms.MonthCalendar calendarStart;
        public System.Windows.Forms.MonthCalendar calendarEnd;
    }
}
