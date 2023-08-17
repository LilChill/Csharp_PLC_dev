
namespace C_Sharp_PLC_1
{
    partial class Form2
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
            Hide();
            /*if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);*/
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hslButton1 = new HslControls.HslButton();
            this.dateTimeIntervelPicker = new DateTimeIntervelControl.DateTimeIntervelPicker();
            this.SuspendLayout();
            // 
            // hslButton1
            // 
            this.hslButton1.ActiveColor = System.Drawing.Color.Cyan;
            this.hslButton1.CustomerInformation = null;
            this.hslButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslButton1.ForeColor = System.Drawing.Color.Black;
            this.hslButton1.Location = new System.Drawing.Point(156, 79);
            this.hslButton1.Name = "hslButton1";
            this.hslButton1.OriginalColor = System.Drawing.Color.AliceBlue;
            this.hslButton1.Size = new System.Drawing.Size(110, 38);
            this.hslButton1.TabIndex = 0;
            this.hslButton1.Text = "确认";
            this.hslButton1.Click += new System.EventHandler(this.hslButton1_Click);
            // 
            // dateTimeIntervelPicker
            // 
            this.dateTimeIntervelPicker.BackColor = System.Drawing.Color.White;
            this.dateTimeIntervelPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateTimeIntervelPicker.DefaultEndTime = null;
            this.dateTimeIntervelPicker.DefaultStartTime = null;
            this.dateTimeIntervelPicker.Location = new System.Drawing.Point(64, 27);
            this.dateTimeIntervelPicker.Name = "dateTimeIntervelPicker";
            this.dateTimeIntervelPicker.Size = new System.Drawing.Size(308, 27);
            this.dateTimeIntervelPicker.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(430, 138);
            this.Controls.Add(this.dateTimeIntervelPicker);
            this.Controls.Add(this.hslButton1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "回放时间段选择";
            this.ResumeLayout(false);

        }

        #endregion

        private HslControls.HslButton hslButton1;
        public DateTimeIntervelControl.DateTimeIntervelPicker dateTimeIntervelPicker;
    }
}