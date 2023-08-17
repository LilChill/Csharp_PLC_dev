
namespace DateTimeIntervelControl
{
    partial class DateTimeIntervelPicker
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
            this.btnPopup = new System.Windows.Forms.Button();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPopup
            // 
            this.btnPopup.BackColor = System.Drawing.Color.Lime;
            this.btnPopup.Location = new System.Drawing.Point(279, 0);
            this.btnPopup.Name = "btnPopup";
            this.btnPopup.Size = new System.Drawing.Size(22, 22);
            this.btnPopup.TabIndex = 1;
            this.btnPopup.UseVisualStyleBackColor = false;
            this.btnPopup.Click += new System.EventHandler(this.btnPopup_Click);
            // 
            // labelDisplay
            // 
            this.labelDisplay.AutoSize = true;
            this.labelDisplay.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelDisplay.Location = new System.Drawing.Point(3, 6);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(137, 12);
            this.labelDisplay.TabIndex = 2;
            this.labelDisplay.Text = "点击右侧按钮选择时间段";
            // 
            // DateTimeIntervelPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.btnPopup);
            this.Name = "DateTimeIntervelPicker";
            this.Size = new System.Drawing.Size(300, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPopup;
        private System.Windows.Forms.Label labelDisplay;
    }
}
