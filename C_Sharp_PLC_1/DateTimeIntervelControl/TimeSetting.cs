using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeIntervelControl
{
    public partial class TimeSetting : UserControl
    {
        public TimeSetting()
        {
            InitializeComponent();
        }
        public String[] MyTime
        {
            get
            {
                string[] mytime = new string[2];
                mytime[0] = numHour.Text + ":" + numMin.Text + ":" + numSecond.Text;
                mytime[1] = numMilSec.Text;
                return mytime;
            }
            set {
                if (value != null) {
                    string[] time = value[0].Split(':');
                    string millisecond = value[1];
                    numHour.Text = time[0]; numMin.Text = time[1]; numSecond.Text = time[2];
                    numMilSec.Text = millisecond;
                }
                

            }
        }
        
    }
}
