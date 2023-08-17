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
    public partial class Form2 : Form
    {
        public static string[] AuxiliaryLines1;
        public static string[] AuxiliaryLines2;
        Form1 mainForm;
        public Form2(Form1 mForm)
        {
            
            InitializeComponent();
            mainForm = mForm;

            
        }


        private void hslButton1_Click(object sender, EventArgs e)
        {
            string[] time1,time2;
            if (dateTimeIntervelPicker1.DTime != null ) {
                time1 = dateTimeIntervelPicker1.DTime.Split('-');
                AuxiliaryLines1 = new string[2];
                AuxiliaryLines1[0] = time1[0];
                AuxiliaryLines1[1] = time1[1];
            }
            else AuxiliaryLines1= null;
            if (dateTimeIntervelPicker2.DTime != null)
            {
                time2 = dateTimeIntervelPicker2.DTime.Split('-');
                AuxiliaryLines2 = new string[2];
                AuxiliaryLines2[0] = time2[0];
                AuxiliaryLines2[1] = time2[1];
            }
            else AuxiliaryLines2 = null;
            this.Hide();
            mainForm.userCurve_replay1.Invalidate();
            mainForm.userCurve_replay2.Invalidate();
        }


    }
}
