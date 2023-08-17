using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace DateTimeIntervelControl
{
    public partial class DateTimeIntervelPopup : UserControl
    {
        public string[] defaultStartTime, defaultEndTime;
        public DateTimeIntervelPopup()
        {
            InitializeComponent();
            timeStart.MyTime = defaultStartTime;
            timeEnd.MyTime = defaultEndTime;
        }

        public delegate void BtnClickHandle(object sender, EventArgs e, DateTime start, DateTime end, string startMilisec, string endMiliSec);

        public event BtnClickHandle SureClick;

        private void btnSure_Click(object sender, EventArgs e)
        {
            //String sStart = "2014-7-5 3:0:20";
            string startMilSec, endMilSec;
            DateTime start = calendarStart.SelectionStart;
            String sStart = start.Year + "-" + start.Month + "-" + start.Day + " " + timeStart.MyTime[0];
            start = Convert.ToDateTime(sStart);
            startMilSec = timeStart.MyTime[1];

            DateTime end = calendarEnd.SelectionStart;
            String sEnd = end.Year + "-" + end.Month + "-" + end.Day + " " + timeEnd.MyTime[0];
            end = Convert.ToDateTime(sEnd);
            endMilSec = timeEnd.MyTime[1];
            if (SureClick != null)
            {
                SureClick(sender, e, start, end, startMilSec, endMilSec);  //把日期时间传给DateTimeIntervelPicker
                
            }

        }
    }
}
