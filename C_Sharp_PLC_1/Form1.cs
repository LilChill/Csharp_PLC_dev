﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            adsClient = new TcAdsClient();
            adsClient.Connect("192.168.1.6.1.1", 851);
            userLantern1.LanternBackground = Color.Green;

            userCurve1.SetLeftCurve("A", new float[] { }, Color.Red);
            userCurve2.SetLeftCurve("B", new float[] { }, Color.Blue);
        }

        private void Disconnect_Button_Click(object sender, EventArgs e)
        {
            userLantern1.LanternBackground = Color.Red;
            adsClient.Dispose();
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
            timer1.Interval = 10;
            timer1.Start();
            userLantern2.LanternBackground = Color.Blue;
            Collect = true;
            userCurve1.StrechDataCountMax = userCurve2.StrechDataCountMax = 300;

            userCurve1.IsAbscissaStrech = userCurve2.IsAbscissaStrech = false;

            userCurve1.TextAddFormat = userCurve2.TextAddFormat = "HH:mm:ss";
        }
        
        private void timer1_Elapsed(object sender, EventArgs e)
        {
            if (!Collect)
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
            DateTime currentTime;
            string[] customXAxisArray = new string[100];
            string time;            
            try
            {
                for (int k = 0; k < 100; k++)
                {
                    varHandle = adsClient.CreateVariableHandle("MAIN.stData");
                    
                    dataRead = (ST_Data)adsClient.ReadAny(varHandle, typeof(ST_Data));
                    array1[k] = (float)dataRead.data[k].dintArr[0];
                    array2[k] = (float)dataRead.data[k].dintArr[1];
                    currentTime = DateTime.Now;
                    curTimeList.Add(currentTime);
                    time = currentTime.ToString("HH:mm:ss");
                    customXAxisArray[k]=time;
                }

                userCurve1.AddCurveData("A", array1);
                //userCurve1.SetCurveText( customXAxisArray);
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
                            currentTime = curTimeList[i];
                            time = currentTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                            int milliseconds = currentTime.Millisecond;

                            command.CommandText = $"INSERT INTO signals (timestamp, milliseconds, signal1, signal2) VALUES (@timestamp, @milliseconds, @value1, @value2)";
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@timestamp", time);
                            command.Parameters.AddWithValue("@milliseconds", milliseconds);
                            command.Parameters.AddWithValue("@value1", array1[i]);
                            command.Parameters.AddWithValue("@value2", array2[i]);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Stop_Button_Click(object sender, EventArgs e)
        {
            Collect = false;
            userLantern2.LanternBackground = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
        private string Parse_Time(string time) {
            //将"yyyy-MM-dd HH:mm:ss.fff"转换为"HH:mm:ss"
            string dtime;
            int start ,end;
            start = end = 0;
            for (int i = 0; i < time.Length; i++) {
                if (time[i] == ' ') start = i + 1;
            }
            dtime = time.Substring(start, time.Length - start);
            return dtime;
        }
        private void Review_Button_Click(object sender, EventArgs e)
        {
            Collect = false;
            int length = Get_Length();
            userLantern2.LanternBackground = Color.Black;
            userCurve1.SetLeftCurve("A", new float[] { }, Color.Red);
            userCurve2.SetLeftCurve("B", new float[] { }, Color.Blue);
            userCurve1.StrechDataCountMax = userCurve2.StrechDataCountMax = length;

            userCurve1.IsAbscissaStrech = userCurve2.IsAbscissaStrech = true;

            //userCurve1.TextAddFormat = userCurve2.TextAddFormat = "HH:mm";

            userCurve1.Invalidate();
            userCurve2.Invalidate();
            //Form2 timeSelectionForm = new Form2();
            //timeSelectionForm.Show();
            float[] array1;
            float[] array2;

            string[] customXAxisArray = new string[length];
            string time;
            int k = 0;
            string connectstring = "server = localhost; user = root; password = lichunrui ; database = array";

            using (MySqlConnection connection = new MySqlConnection(connectstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    int rowCount = 200;
                    int offset = 0;
                    array1 = new float[rowCount];
                    array2 = new float[rowCount];
                    while(true)
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
                                array1[i] = (float)reader["signal1"];
                                array2[i] = (float)reader["signal2"];
                                customXAxisArray[k++] =Parse_Time(reader["timestamp"].ToString());
                                i++;
                            }
                            userCurve1.AddCurveData("A", array1);
                            userCurve2.AddCurveData("B", array2);
                            if (reader.Read() == false&&i<rowCount) break;
                            offset += rowCount;
                        }
                        

                    }
                    userCurve1.SetCurveText(customXAxisArray);

                }
            }
        }

    }
        
    
}