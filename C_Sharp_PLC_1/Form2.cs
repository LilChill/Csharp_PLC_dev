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
        public static string[] AuxiliaryLines;
        public static List<float> signalList;
        Form1 mainForm;
        public Form2(Form1 mForm)
        {
            
            InitializeComponent();
            mainForm = mForm;

            
        }


        private void hslButton1_Click(object sender, EventArgs e)
        {
            string[] time;
            if (dateTimeIntervelPicker.DTime != null ) {
                time = dateTimeIntervelPicker.DTime.Split('-');
                AuxiliaryLines = new string[2];
                AuxiliaryLines[0] = time[0] + ".0";
                AuxiliaryLines[1] = time[1] + ".999";
                mainForm.AuxiliaryLinesTime = AuxiliaryLines;
                //int startReplayIndex, endReplayIndex;
                //startReplayIndex = mainForm.getTimeIndex(AuxiliaryLines[0]);
                //endReplayIndex = mainForm.getTimeIndex(AuxiliaryLines[1]);
                mainForm.Draw_replay_curve();
                mainForm.userCurve_replay1.Invalidate();
                mainForm.userCurve_detail1.Invalidate();
                mainForm.userCurve_replay2.Invalidate();
                mainForm.userCurve_detail2.Invalidate();
                mainForm.Export_Button1.Visible = true;

               

            }
            else AuxiliaryLines= null;
            this.Hide();
            mainForm.isReplaying = true;
            
            
            
            
            
        }


    }
}
