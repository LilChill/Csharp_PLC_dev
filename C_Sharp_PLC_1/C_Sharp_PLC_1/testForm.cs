using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_PLC_1
{
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = dateTimeIntervelPicker1.DTime.Split('-');
            DateTime time = Convert.ToDateTime(arr[0].Split('.')[0]);
            time.AddMilliseconds(double.Parse(textBox1.Text) );
            label1.Text = time.Millisecond.ToString();
        }
    }
}
