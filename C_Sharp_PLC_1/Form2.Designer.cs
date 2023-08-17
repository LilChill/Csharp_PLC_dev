
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeIntervelPicker2 = new DateTimeIntervelControl.DateTimeIntervelPicker();
            this.dateTimeIntervelPicker1 = new DateTimeIntervelControl.DateTimeIntervelPicker();
            this.SuspendLayout();
            // 
            // hslButton1
            // 
            this.hslButton1.ActiveColor = System.Drawing.Color.Cyan;
            this.hslButton1.CustomerInformation = null;
            this.hslButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslButton1.ForeColor = System.Drawing.Color.Black;
            this.hslButton1.Location = new System.Drawing.Point(164, 173);
            this.hslButton1.Name = "hslButton1";
            this.hslButton1.OriginalColor = System.Drawing.Color.AliceBlue;
            this.hslButton1.Size = new System.Drawing.Size(110, 38);
            this.hslButton1.TabIndex = 0;
            this.hslButton1.Text = "确认";
            this.hslButton1.Click += new System.EventHandler(this.hslButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "signal1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "signal2";
            // 
            // dateTimeIntervelPicker2
            // 
            this.dateTimeIntervelPicker2.BackColor = System.Drawing.Color.White;
            this.dateTimeIntervelPicker2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateTimeIntervelPicker2.Location = new System.Drawing.Point(107, 111);
            this.dateTimeIntervelPicker2.Name = "dateTimeIntervelPicker2";
            this.dateTimeIntervelPicker2.Size = new System.Drawing.Size(304, 26);
            this.dateTimeIntervelPicker2.TabIndex = 5;
            // 
            // dateTimeIntervelPicker1
            // 
            this.dateTimeIntervelPicker1.BackColor = System.Drawing.Color.White;
            this.dateTimeIntervelPicker1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateTimeIntervelPicker1.Location = new System.Drawing.Point(107, 52);
            this.dateTimeIntervelPicker1.Name = "dateTimeIntervelPicker1";
            this.dateTimeIntervelPicker1.Size = new System.Drawing.Size(304, 26);
            this.dateTimeIntervelPicker1.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(421, 242);
            this.Controls.Add(this.dateTimeIntervelPicker2);
            this.Controls.Add(this.dateTimeIntervelPicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hslButton1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "回放时间段选择";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HslControls.HslButton hslButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public DateTimeIntervelControl.DateTimeIntervelPicker dateTimeIntervelPicker1;
        public DateTimeIntervelControl.DateTimeIntervelPicker dateTimeIntervelPicker2;
    }
}