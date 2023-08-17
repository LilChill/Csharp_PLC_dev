using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PopupControl;

namespace DateTimeIntervelControl
{
    public partial class DateTimeIntervelPicker : UserControl
    {
        public DateTimeIntervelPicker()
        {
            InitializeComponent();
            content = new DateTimeIntervelPopup();
            popup = new Popup(content);
            popup.Dock = DockStyle.Bottom;
            //添加DateTimeIntervelPopup点击按钮事件
            content.SureClick += new DateTimeIntervelPopup.BtnClickHandle(content_SureClick);
            
        }
        DateTimeIntervelPopup content;
        Popup popup;
        string[] defaultStartTime;
        string[] defaultEndTime;
        private void btnPopup_Click(object sender, EventArgs e)
        {
            popup.Show(labelDisplay);
            content.timeStart.MyTime = defaultStartTime;
            content.timeEnd.MyTime = defaultEndTime;
        }

        private void content_SureClick(object sender, EventArgs e, DateTime start, DateTime end,string startMilisec,string endMiliSec)
        {
            startTime = start;
            endTime = end;

            StringBuilder sb = new StringBuilder();
            sb.Append(start.Year + "/");
            sb.Append(start.Month + "/");
            sb.Append(start.Day + " ");
            sb.Append(start.Hour + ":");
            sb.Append(start.Minute + ":");
            sb.Append(start.Second+".");
            sb.Append(startMilisec);
            sb.Append("-");

            sb.Append(end.Year + "/");
            sb.Append(end.Month + "/");
            sb.Append(end.Day + " ");
            sb.Append(end.Hour + ":");
            sb.Append(end.Minute + ":");
            sb.Append(end.Second+".");
            sb.Append(endMiliSec);
            labelDisplay.Text = sb.ToString();
            labelDisplay.ForeColor = Color.Black;
            dTime = sb.ToString();
            popup.Hide();
        }

        private DateTime startTime;
        private DateTime endTime;
        private string dTime;
        public String DTime
        {
            get {
                return dTime;
            }
        }
        public DateTime StartTime
        {
            get
            {
                return startTime;
            }            

        }

        public DateTime EndTime
        {
            get
            {
                return endTime;
            }
        }
        public string[] DefaultStartTime
        {
            set {
                defaultStartTime = value;
            }

        }

        public string[] DefaultEndTime
        {
            set
            {
                defaultEndTime = value;
            }
        }
    }
}
