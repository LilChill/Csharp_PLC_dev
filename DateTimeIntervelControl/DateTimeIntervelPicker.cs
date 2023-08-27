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
            content = new DateTimeIntervelPopup(this);
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
            content.timeStart.MyTime = defaultStartTime[1];
            content.timeEnd.MyTime = defaultEndTime[1];
            content.calendarStart.SelectionStart = Convert.ToDateTime(string.Join("-", defaultStartTime[0].Split('/')));
            content.calendarEnd.SelectionStart = Convert.ToDateTime(string.Join("-", defaultEndTime[0].Split('/')));
            popup.Show(labelDisplay);
            
        }

        private void content_SureClick(object sender, EventArgs e, DateTime start, DateTime end)
        {
            startTime = start;
            endTime = end;

            StringBuilder sb = new StringBuilder();
            sb.Append(start.Year + "/");
            sb.Append(start.Month + "/");
            sb.Append(start.Day + " ");
            sb.Append(start.Hour + ":");
            sb.Append(start.Minute + ":");
            sb.Append(start.Second);
            //sb.Append(startMilisec);
            sb.Append("-");

            sb.Append(end.Year + "/");
            sb.Append(end.Month + "/");
            sb.Append(end.Day + " ");
            sb.Append(end.Hour + ":");
            sb.Append(end.Minute + ":");
            sb.Append(end.Second);
            //sb.Append(endMiliSec);
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
            set {
                labelDisplay.Text = value;
                labelDisplay.ForeColor=SystemColors.ButtonShadow;
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
            get {
                return defaultStartTime;
            }
            set {
                defaultStartTime = value;
            }

        }

        public string[] DefaultEndTime
        {
            get
            {
                return defaultEndTime;
            }
            set
            {
                defaultEndTime = value;
            }
        }
    }
}
