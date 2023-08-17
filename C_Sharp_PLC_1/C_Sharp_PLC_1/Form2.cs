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
<<<<<<< HEAD


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


=======
        public static string[] AuxiliaryLines1;
        public static string[] AuxiliaryLines2;

        private void hslButton1_Click(object sender, EventArgs e)
        {
            int start1, end1, start2, end2;
            if (int.TryParse(textBox1.Text, out start1) && int.TryParse(textBox2.Text, out end1)) {
                AuxiliaryLines1 = new string[4];
                AuxiliaryLines1[0] = start1.ToString();
                AuxiliaryLines1[2] = end1.ToString();
            }            
            if (int.TryParse(textBox1.Text, out start2) && int.TryParse(textBox2.Text, out end2))
            {
                AuxiliaryLines2 = new string[4];
                AuxiliaryLines2[0] = start2.ToString();
                AuxiliaryLines2[2] = end2.ToString();
            }
            this.Close();
        }
>>>>>>> 7b443d29056d50e59990e246d4784835222d1ddc
    }
}
