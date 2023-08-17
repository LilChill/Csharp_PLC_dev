using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;
using System.Runtime.InteropServices;
using System.Timers;
using System.IO;
using MySql.Data.MySqlClient;
using HslCommunication.Controls;
using System.Threading;

namespace C_Sharp_PLC_1
{
    public partial class Form1 : Form
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct ST_DataArray
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public float[] dintArr;
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct ST_Data
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
            public ST_DataArray[] data;
        }

        private TcAdsClient adsClient;
        private bool Collect = false;
        public string[] AuxiliaryLinesTime1;
        public string[] AuxiliaryLinesTime2;
        private Form2 form2;//时间段选择窗体实例
        public List<string> indexArray;
        string[] customXAxisArray;
        DateTime currentTime;
        bool isConnected = false;
        bool isGathering = false;
        int leftRight = 50;//userCurve控件左右内边距
        int upDown = 25;//userCurve控件上下内边距
        public Form1()
        {

            form2 = new Form2(this);
            testForm test = new testForm();

            //test.Show();
            InitializeComponent();
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                adsClient = new TcAdsClient();
                adsClient.Connect("192.168.1.6.1.1", 851);
                if (adsClient != null)
                {
                    userLantern1.LanternBackground = Color.Green;
                    label_isConnect.Text = "已连接";
                    userCurve1.SetLeftCurve("A", new float[] { }, Color.Red);
                    userCurve2.SetLeftCurve("B", new float[] { }, Color.Blue);
                }
                else
                {
                    MessageBox.Show("连接失败");
                }
                isConnected = true;
                Connect_Button.Text = "断开连接";
                Gather_Button.Enabled = true;
            }
            else
            {
                userLantern1.LanternBackground = Color.Red;
                adsClient.Dispose();
                isConnected = false;
                Connect_Button.Text = "连接";
                Gather_Button.Enabled = false;
            }

        }



        private void DataScrub_Button_Click(object sender, EventArgs e)
        {

            userCurve1.SetLeftCurve("A", new float[] { }, Color.Red);
            userCurve2.SetLeftCurve("B", new float[] { }, Color.Blue);
            userCurve1.StrechDataCountMax = userCurve2.StrechDataCountMax = 300;
            userCurve1.IsAbscissaStrech = userCurve2.IsAbscissaStrech = false;
            userCurve1.TextAddFormat = userCurve2.TextAddFormat = "HH:mm:ss";

        }


        private void Gather_Button_Click(object sender, EventArgs e)
        {
            if (!isGathering)
            {
                try
                {
                    currentTime = DateTime.Now;
                    timer1.Interval = 10;
                    timer1.Start();
                    userLantern2.LanternBackground = Color.Blue;
                    //Collect = true;
                    userCurve1.StrechDataCountMax = userCurve2.StrechDataCountMax = 300;

                    userCurve1.IsAbscissaStrech = userCurve2.IsAbscissaStrech = false;

                    userCurve1.TextAddFormat = userCurve2.TextAddFormat = "HH:mm:ss";
                    isGathering = true;
                    Gather_Button.Text = "停止传输";
                    Connect_Button.Enabled = false;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                //Collect = false;
                userLantern2.LanternBackground = Color.Black;
                isGathering = false;
                Gather_Button.Text = "开始传输";
                Connect_Button.Enabled = true;
            }


        }

        private void timer1_Elapsed(object sender, EventArgs e)
        {
            if (!isGathering)
            {
                timer1.Stop();
                return;
            }

            ST_Data dataRead;
            int varHandle;
            int rowCount = 100;
            float[] array1 = new float[rowCount];
            float[] array2 = new float[rowCount];
            List<DateTime> curTimeList = new List<DateTime>();
            string time;
            int milliseconds = currentTime.Millisecond;
            try
            {
                for (int k = 0; k < 100; k++)
                {
                    varHandle = adsClient.CreateVariableHandle("MAIN.stData");

                    dataRead = (ST_Data)adsClient.ReadAny(varHandle, typeof(ST_Data));
                    array1[k] = (float)dataRead.data[k].dintArr[0];
                    array2[k] = (float)dataRead.data[k].dintArr[1];
                }

                userCurve1.AddCurveData("A", array1);

                userCurve1.Invalidate();
                userCurve2.AddCurveData("B", array2);
                userCurve2.Invalidate();

                string connectstring = "server = localhost; user = root; password = lichunrui ; database = array";
                using (MySqlConnection connection = new MySqlConnection(connectstring))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        command.Connection = connection;
                        for (int i = 0; i < rowCount; i++)
                        {
                            currentTime = currentTime.AddMilliseconds(1);
                            time = currentTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                            milliseconds = currentTime.Millisecond;
                            Console.WriteLine($"{currentTime}\t{milliseconds}");
                            command.CommandText = $"INSERT INTO signals (timestamp, milliseconds, signal1, signal2) VALUES (@timestamp, @milliseconds, @value1, @value2)";
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@timestamp", time);
                            command.Parameters.AddWithValue("@milliseconds", milliseconds);
                            command.Parameters.AddWithValue("@value1", array1[i]);
                            command.Parameters.AddWithValue("@value2", array2[i]);
                            command.ExecuteNonQuery();
                            milliseconds++;
                            if (milliseconds == 1000) milliseconds = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //userCurve_replay1.SetLeftCurve("C", new float[] { }, Color.Red);
            //userCurve_replay2.SetLeftCurve("D", new float[] { }, Color.Blue);
        }
        private int Get_Length()
        {
            int length;
            string connectstring = "server = localhost; user = root; password = lichunrui ; database = array";
            using (MySqlConnection connection = new MySqlConnection(connectstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"SELECT COUNT(*) FROM signals";
                    length = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return length;
        }
        private string[] GetXAxisArray(int length)
        {
            string[] customXAxisArray = new string[length];

            return customXAxisArray;
        }
        private string Parse_Time(string time)
        {
            //将"yyyy-MM-dd HH:mm:ss"转换为"HH:mm:ss"
            string dtime;
            int start, end;
            start = end = 0;
            for (int i = 0; i < time.Length; i++)
            {
                if (time[i] == ' ') start = i + 1;
            }
            dtime = time.Substring(start, time.Length - start);
            return dtime;
        }

        private int get_interval(int length, int slice)
        {
            float offect = (userCurve_replay1.Size.Width - leftRight * 2) * 1.0f / (userCurve_replay1.StrechDataCountMax - 1);
            if (offect > 40) return 1;
            offect = 40f / offect;
            return (int)Math.Ceiling(offect);
        }
        private void addVerticalAuxiliaryLines(UserCurve userControl, int index)
        {
            int heigh_totle = userControl.Height;
            float offect = (userCurve_replay1.Size.Width - leftRight * 2) * 1.0f / (userCurve_replay1.StrechDataCountMax - 1);
            Pen pen_dash = new Pen(Color.Red);
            pen_dash.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            pen_dash.DashPattern = new float[] { 5, 5 };
            Graphics g = userControl.CreateGraphics();
            g.DrawLine(pen_dash, index * offect + leftRight, upDown, index * offect + leftRight, heigh_totle - upDown - 1);
        }

        private void outputLog()
        {
            string filePath = @"output.txt";

            StreamWriter file = new StreamWriter(filePath, append: true);
            for (int i = 0; i < indexArray.Count; i++)
            {
                file.WriteLine(customXAxisArray[i] + " " + indexArray[i]);
            }
            file.Close();

        }
        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private int getTimeIndex(string time)
        {
            string[] array = time.Split('.');
            DateTime source = Convert.ToDateTime(array[0]);
            int sMilsec = int.Parse(array[1]);
            DateTime target;
            int tMilsec;
            for (int i = 0; i < indexArray.Count; i++)
            {
                array = indexArray[i].Split('.');
                target = Convert.ToDateTime(array[0]);
                tMilsec = int.Parse(array[1]);
                if (source < target)
                    return i;
                else if (source == target)
                {
                    if (sMilsec <= tMilsec)
                        return i;
                }
            }
            return indexArray.Count - 1;

        }
        private void draw_replay_auxiliaryLine(string[] AuxiliaryLinesTime,UserCurve userCurve, PaintEventArgs e) {

            int startIndex, endIndex;
            startIndex = getTimeIndex(AuxiliaryLinesTime[0]);
            endIndex = getTimeIndex(AuxiliaryLinesTime[1]);
            int heigh_totle = userCurve.Height;
            float offect = (userCurve.Size.Width - leftRight * 2) * 1.0f / (userCurve.StrechDataCountMax - 1);
            Pen pen_AuxiliaryLine = new Pen(Color.Red);
            pen_AuxiliaryLine.Width = 3;
            Graphics g = e.Graphics;
            g.DrawLine(pen_AuxiliaryLine, startIndex * offect + leftRight, upDown, startIndex * offect + leftRight, heigh_totle - upDown - 1);
            g.DrawLine(pen_AuxiliaryLine, endIndex * offect + leftRight, upDown, endIndex * offect + leftRight, heigh_totle - upDown - 1);
            Rectangle recLeft, recRight;
            if (Math.Abs(endIndex - startIndex) > 15000)
            {
                recLeft = new Rectangle((int)(startIndex * offect + leftRight), upDown * 6 / 5, 100, upDown + 5); //new Rectangle((int)(startIndex * offect), upDown, 100, upDown);
                recRight = new Rectangle((int)(endIndex * offect - leftRight), upDown * 6 / 5, 100, upDown + 5);
            }
            else {
                recLeft = new Rectangle((int)(startIndex * offect - leftRight), upDown * 6 / 5, 100, upDown + 5); //new Rectangle((int)(startIndex * offect), upDown, 100, upDown);
                recRight = new Rectangle((int)(endIndex * offect + leftRight), upDown * 6 / 5, 100, upDown + 5);
            }
            Brush brush_deep = new SolidBrush(Color.Black);
            StringFormat format_center = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center,
            };
            g.DrawString(indexArray[startIndex], new Font("UniDreamLED", 10,FontStyle.Bold), brush_deep, recLeft, format_center);
            g.DrawString(indexArray[endIndex], new Font("UniDreamLED", 10, FontStyle.Bold), brush_deep, recRight, format_center);
        }
        private void userCurve_replay1_Paint(object sender, PaintEventArgs e)
        {
            AuxiliaryLinesTime1 = Form2.AuxiliaryLines1;

            if (AuxiliaryLinesTime1 != null)
            {
                draw_replay_auxiliaryLine(AuxiliaryLinesTime1,userCurve_replay1,e);
            }

        }

        private void userCurve_replay2_Paint(object sender, PaintEventArgs e)
        {
            AuxiliaryLinesTime2 = Form2.AuxiliaryLines2;

            if (AuxiliaryLinesTime2 != null)
            {
                draw_replay_auxiliaryLine(AuxiliaryLinesTime2, userCurve_replay2, e);
            }
        }

        private void Choose_Time_Button_Click(object sender, EventArgs e)
        {

            form2.Show();
        }

        private void userCurve2_Load(object sender, EventArgs e)
        {

        }

        private void btnCollapseReplay_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel1Collapsed = !splitContainer2.Panel1Collapsed;
            if (splitContainer2.Panel1Collapsed) btnCollapseReplay.Text = "展开";
            else btnCollapseReplay.Text = "收起";

        }

        private void Replay_Button_Click(object sender, EventArgs e)
        {
            isGathering = false;
            label_isGathering.Text = "未传输";
            Gather_Button.Text = "开始传输";
            int length = Get_Length();

            userCurve_replay1.SetLeftCurve("C", new float[] { }, Color.DeepSkyBlue);
            userCurve_replay2.SetLeftCurve("D", new float[] { }, Color.DeepSkyBlue);
            userCurve_replay1.StrechDataCountMax = userCurve_replay2.StrechDataCountMax = length;

            userCurve_replay1.IsAbscissaStrech = userCurve_replay2.IsAbscissaStrech = true;

            float[] array1;
            float[] array2;

            indexArray = new List<string>();
            customXAxisArray = new string[length];
            string time;
            int k = 0;
            int j = 0;
            string connectstring = "server = localhost; user = root; password = lichunrui ; database = array";
            int slice = 15;
            int interval = get_interval(length, slice);
            //textBox3.Text = (interval).ToString();
            bool hasData = false;
            using (MySqlConnection connection = new MySqlConnection(connectstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    int rowCount = 200;
                    int offset = 0;
                    array1 = new float[rowCount];
                    array2 = new float[rowCount];
                    while (true)
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT * FROM signals LIMIT @offset,@rowCount";
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@offset", offset);
                        command.Parameters.AddWithValue("@rowCount", rowCount);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                hasData = true;
                                array1[i] = (float)reader["signal1"];
                                array2[i] = (float)reader["signal2"];
                                if ((k % interval == 0 && (k / interval) % 3 == 0) || k == length - 1)
                                {
                                    customXAxisArray[k] = Parse_Time(reader["timestamp"].ToString()) + $".{reader["milliseconds"]}";
                                    j++;

                                }

                                else customXAxisArray[k] = "";
                                //customXAxisArray[k] = k.ToString();
                                indexArray.Add(reader["timestamp"].ToString() + $".{reader["milliseconds"]}");
                                k++;
                                i++;
                            }
                            if (hasData)
                            {
                                userCurve_replay1.AddCurveData("C", array1);
                                userCurve_replay2.AddCurveData("D", array2);


                            }
                            if (reader.Read() == false && i < rowCount) break;
                            offset += rowCount;
                        }


                    }

                }
                if (hasData)
                {
                    form2.dateTimeIntervelPicker1.DefaultStartTime = form2.dateTimeIntervelPicker2.DefaultStartTime = indexArray[0].Split(' ')[1].Split('.');
                    form2.dateTimeIntervelPicker1.DefaultEndTime = form2.dateTimeIntervelPicker2.DefaultEndTime = indexArray[length - 1].Split(' ')[1].Split('.');
                    userCurve_replay2.SetCurveText(customXAxisArray);
                    userCurve_replay1.SetCurveText(customXAxisArray);

                    userCurve_replay1.Invalidate();
                    userCurve_replay2.Invalidate();
                    Choose_Time_Button.Visible = true;
                    btnCollapseReplay.Visible = true; //折叠按钮
                    btnCollapseReplay.Text = "收起";
                    splitContainer2.Panel1Collapsed = false;
                    userLantern2.LanternBackground = Color.Red;
                }
            }
        }

    }
}