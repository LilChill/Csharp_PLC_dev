
namespace C_Sharp_PLC_1
{
    partial class Form3
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
            //Hide();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_wells = new System.Windows.Forms.ComboBox();
            this.comboBox_segments = new System.Windows.Forms.ComboBox();
            this.Confirm_button = new HslControls.HslButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "井号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "段号";
            // 
            // comboBox_wells
            // 
            this.comboBox_wells.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_wells.FormattingEnabled = true;
            this.comboBox_wells.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_wells.Location = new System.Drawing.Point(67, 33);
            this.comboBox_wells.Name = "comboBox_wells";
            this.comboBox_wells.Size = new System.Drawing.Size(133, 20);
            this.comboBox_wells.TabIndex = 1;
            this.comboBox_wells.SelectedIndexChanged += new System.EventHandler(this.comboBox_wells_SelectedIndexChanged);
            this.comboBox_wells.TextUpdate += new System.EventHandler(this.comboBox_wells_TextUpdate);
            this.comboBox_wells.TextChanged += new System.EventHandler(this.comboBox_wells_TextChanged);
            this.comboBox_wells.Leave += new System.EventHandler(this.comboBox_wells_Leave);
            // 
            // comboBox_segments
            // 
            this.comboBox_segments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_segments.FormattingEnabled = true;
            this.comboBox_segments.Location = new System.Drawing.Point(67, 85);
            this.comboBox_segments.Name = "comboBox_segments";
            this.comboBox_segments.Size = new System.Drawing.Size(133, 20);
            this.comboBox_segments.TabIndex = 1;
            this.comboBox_segments.Leave += new System.EventHandler(this.comboBox_segments_Leave);
            // 
            // Confirm_button
            // 
            this.Confirm_button.CustomerInformation = null;
            this.Confirm_button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Confirm_button.ForeColor = System.Drawing.Color.Black;
            this.Confirm_button.Location = new System.Drawing.Point(67, 134);
            this.Confirm_button.Name = "Confirm_button";
            this.Confirm_button.OriginalColor = System.Drawing.Color.SkyBlue;
            this.Confirm_button.Size = new System.Drawing.Size(100, 37);
            this.Confirm_button.TabIndex = 4;
            this.Confirm_button.Text = "确定";
            this.Confirm_button.Click += new System.EventHandler(this.Confirm_button_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 206);
            this.Controls.Add(this.Confirm_button);
            this.Controls.Add(this.comboBox_segments);
            this.Controls.Add(this.comboBox_wells);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "井、段号选择";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private HslControls.HslButton Confirm_button;
        public System.Windows.Forms.ComboBox comboBox_wells;
        public System.Windows.Forms.ComboBox comboBox_segments;
    }
}