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
        public string[] AuxiliaryLinesTime;
        private Form2 form2;//时间段选择窗体实例
        private Form3 form3;//井、段号选择窗体实例
        public List<string> indexArray;
        string[] customXAxisArray;
        private struct ExportData
        {
            public string timestamp;
            public string milliseconds;
            public float signal1;
            public float signal2;
        }
        List<ExportData> exportDataList;
        public DateTime currentTime;
        bool isConnected = false;
        bool isGathering = false;
        int leftRight = 50;//userCurve控件左右内边距
        int upDown = 25;//userCurve控件上下内边距
        string databaseUsername = "root";
        string databasePassWord = "lichunrui";
        string connectstring;
        public bool isReplaying = false;
        public  int startIndex, endIndex;//记录当前采集时间段的起止记录索引
        public string currentTableName;
        public List<HslControls.AuxiliaryLine> auxiliaryLine;
        public Pen pen_Auxiliary_Line;
        public Brush brush_Auxiliary_text;
        //public AuxiliaryLine auxiliaryLines = new AuxiliaryLine();
        public Form1()
        {
            InitializeComponent();
            connectstring = $"server = localhost; user = {databaseUsername}; password = {databasePassWord} ; database = array;Allow User Variables=True";
            form2 = new Form2(this);
            startIndex = endIndex = 0;        
        }
        private void Set_connect_component_mode(bool mode) {
            if (mode) {
                userLantern1.LanternBackground = Color.Green;
                label_isConnect.Text = "已连接";
                Connect_Button.Text = "断开连接";
                Gather_Button.Enabled = true;
            }
            else {
                userLantern1.LanternBackground = Color.Red;
                label_isConnect.Text = "未连接";
                Connect_Button.Text = "连接";
                Gather_Button.Enabled = false;
            }
        }
        private void Set_gather_component_mode(bool mode) {
            if (mode)
            {
                userCurve1.StrechDataCountMax = userCurve2.StrechDataCountMax = 300;

                userCurve1.IsAbscissaStrech = userCurve2.IsAbscissaStrech = false;

                userCurve1.TextAddFormat = userCurve2.TextAddFormat = "HH:mm:ss";
                isGathering = true;
                userLantern2.LanternBackground = Color.Green;
                Gather_Button.Text = "停止传输";
                label_isGathering.Text = "传输中";
                Connect_Button.Enabled = false;
                isReplaying = false;
            }
            else
            {
                isGathering = false;
                userLantern2.LanternBackground = Color.Red;
                Gather_Button.Text = "开始传输";
                label_isGathering.Text = "未传输";
                Connect_Button.Enabled = true;
            }
        }
        private void Connect_Button_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                adsClient = new TcAdsClient();
                adsClient.Connect("192.168.1.6.1.1", 851);
                int varHandle;
                try
                {
                    varHandle = adsClient.CreateVariableHandle("MAIN.stData");

                    userCurve1.SetLeftCurve("A", new float[] { }, Color.Red);
                    userCurve2.SetLeftCurve("B", new float[] { }, Color.Blue);
                    isConnected = true;
                    Set_connect_component_mode(true);

                }
                catch (Exception err)
                {
                    isGathering = false;
                    MessageBox.Show(err.Message);
                    return;
                }


            }
            else
            {
                adsClient.Dispose();
                isConnected = false;
                Set_connect_component_mode(false);
            }

        }



        private void DataScrub_Button_Click(object sender, EventArgs e)
        {
            userCurve1.RemoveAllCurve(); userCurve2.RemoveAllCurve();
            userCurve1.SetLeftCurve("A", new float[] { }, Color.Red);
            
            userCurve2.SetLeftCurve("B", new float[] { }, Color.Blue);
            userCurve1.StrechDataCountMax = userCurve2.StrechDataCountMax = 300;
            userCurve1.IsAbscissaStrech = userCurve2.IsAbscissaStrech = false;
            userCurve1.TextAddFormat = userCurve2.TextAddFormat = "HH:mm:ss";
            disposeReplayLine();

            splitContainer2.Panel1Collapsed = true;
            Choose_Time_Button.Visible = false;
            Export_Button.Visible = false;
        }


        private void Gather_Button_Click(object sender, EventArgs e)
        {
            if (!isGathering)
            {
                userCurve1.RemoveAllCurve(); userCurve2.RemoveAllCurve();
                userCurve1.SetLeftCurve("A", new float[] { }, Color.Red);

                userCurve2.SetLeftCurve("B", new float[] { }, Color.Blue);
                userCurve1.StrechDataCountMax = userCurve2.StrechDataCountMax = 300;
                userCurve1.IsAbscissaStrech = userCurve2.IsAbscissaStrech = false;
                userCurve1.TextAddFormat = userCurve2.TextAddFormat = "HH:mm:ss";

                disposeReplayLine();
                splitContainer2.Panel1Collapsed = true;
                Choose_Time_Button.Visible = false;
                Export_Button.Visible = false;

                form3 = new Form3(this);
                form3.Show();
                currentTime = DateTime.Now;                              
                
            }
            else
            {
                isGathering = false;
                endIndex = Get_Length();
                Set_gather_component_mode(false);
            }


        }
        private void disposeReplayLine() 
        {
            userCurve_replay1.RemoveAllCurve();
            userCurve_replay2.RemoveAllCurve();
            AuxiliaryLinesTime = null;
            pen_Auxiliary_Line?.Dispose();
            brush_Auxiliary_text?.Dispose();
            userCurve_replay1.Invalidate();
            userCurve_replay2.Invalidate();
        }
        public void gather() {          
            timer1.Interval = 10;
            timer1.Start();
            Set_gather_component_mode(true);
            Replay_Button.Enabled = true;
            //disposeReplayLine();
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

            try {
                varHandle = adsClient.CreateVariableHandle("MAIN.stData");
            } catch (Exception err) {
                isGathering = false;
                MessageBox.Show(err.Message);
                return;
            }
            
            try
            {
                for (int k = 0; k < 100; k++)
                {

                    dataRead = (ST_Data)adsClient.ReadAny(varHandle, typeof(ST_Data));
                    array1[k] = (float)dataRead.data[k].dintArr[0];
                    array2[k] = (float)dataRead.data[k].dintArr[1]; 
                }
                userCurve1.AddCurveData("A", array1);

                userCurve1.Invalidate();
                userCurve2.AddCurveData("B", array2);
                userCurve2.Invalidate();

               
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
                            //Console.WriteLine($"{time}");
                            command.CommandText = $"INSERT INTO {currentTableName} (timestamp, milliseconds, signal1, signal2) VALUES (@timestamp, @milliseconds, @value1, @value2)";
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@timestamp", time);
                            command.Parameters.AddWithValue("@milliseconds", milliseconds);
                            command.Parameters.AddWithValue("@value1", array1[i]);
                            command.Parameters.AddWithValue("@value2", array2[i]);
                            command.ExecuteNonQuery();
                            //milliseconds++;
                            //if (milliseconds == 1000) milliseconds = 0;
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
        public void CreateTableIfNotExists(string tableName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectstring))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $@"
                        CREATE TABLE IF NOT EXISTS {tableName} (
                            signal_id INT AUTO_INCREMENT PRIMARY KEY,
                            timestamp DATETIME(3),
                            milliseconds INT,
                            signal1 FLOAT,
                            signal2 FLOAT,
                            segment_id INT
                        );";

                    command.ExecuteNonQuery();
                }
            }
        }
        public int Get_Length()
        {
            int length;
            //CreateTableIfNotExists(tableName);
            using (MySqlConnection connection = new MySqlConnection(connectstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"SELECT COUNT(*) FROM {currentTableName}";
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

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public int getTimeIndex(string time)
        {
            string[] sourceArray = time.Split('.');
            DateTime source = Convert.ToDateTime(sourceArray[0]);
            int sMilsec = int.Parse(sourceArray[1]);
            DateTime target;
            int tMilsec;
            for (int i = 0; i < indexArray.Count; i++)
            {
                string[] targetArray = indexArray[i].Split('.');
                target = Convert.ToDateTime(targetArray[0]);
                tMilsec = int.Parse(targetArray[1]);
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
            Graphics g = e.Graphics;
            if (AuxiliaryLinesTime != null)
            {
                pen_Auxiliary_Line = new Pen(Color.Red, 3);
                brush_Auxiliary_text = new SolidBrush(Color.Black);
                int startAuxiliaryIndex, endAuxiliaryIndex;
                startAuxiliaryIndex = getTimeIndex(AuxiliaryLinesTime[0]);
                endAuxiliaryIndex = getTimeIndex(AuxiliaryLinesTime[1]);
                int heigh_totle = userCurve.Height;
                float offect = (userCurve.Size.Width - leftRight * 2) * 1.0f / (userCurve.StrechDataCountMax - 1);


                g.DrawLine(pen_Auxiliary_Line, startAuxiliaryIndex * offect + leftRight, upDown, startAuxiliaryIndex * offect + leftRight, heigh_totle - upDown - 1); //起始辅助线
                g.DrawLine(pen_Auxiliary_Line, endAuxiliaryIndex * offect + leftRight, upDown, endAuxiliaryIndex * offect + leftRight, heigh_totle - upDown - 1);//结束辅助线
                Rectangle recLeft, recRight;
                /*if (Math.Abs(endIndex - startIndex) > 15000)
                {
                    recLeft = new Rectangle((int)(startIndex * offect + leftRight), upDown * 6 / 5, 100, upDown + 5); //new Rectangle((int)(startIndex * offect), upDown, 100, upDown);
                    recRight = new Rectangle((int)(endIndex * offect - leftRight), upDown * 6 / 5, 100, upDown + 5);
                }
                else {
                    recLeft = new Rectangle((int)(startIndex * offect - leftRight), upDown * 6 / 5, 100, upDown + 5); //new Rectangle((int)(startIndex * offect), upDown, 100, upDown);
                    recRight = new Rectangle((int)(endIndex * offect + leftRight), upDown * 6 / 5, 100, upDown + 5);
                }*/
                recLeft = new Rectangle((int)(startAuxiliaryIndex * offect), upDown, 100, upDown + 5);
                recRight = new Rectangle((int)(endAuxiliaryIndex * offect), heigh_totle - 2 * upDown - 1, 100, upDown + 5);

                StringFormat format_center = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center,
                };
                g.DrawString(indexArray[startAuxiliaryIndex], new Font("UniDreamLED", 10, FontStyle.Bold), brush_Auxiliary_text, recLeft, format_center);
                g.DrawString(indexArray[endAuxiliaryIndex], new Font("UniDreamLED", 10, FontStyle.Bold), brush_Auxiliary_text, recRight, format_center);
            }
            
            

        }
        private void userCurve_replay1_Paint(object sender, PaintEventArgs e)
        {
           
            draw_replay_auxiliaryLine(AuxiliaryLinesTime,userCurve_replay1,e);

        }

        private void userCurve_replay2_Paint(object sender, PaintEventArgs e)
        {
            
            draw_replay_auxiliaryLine(AuxiliaryLinesTime, userCurve_replay2, e);
        }

        private void Choose_Time_Button_Click(object sender, EventArgs e)
        {

            form2.Show();
        }



        private void btnCollapseReplay_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel1Collapsed = !splitContainer2.Panel1Collapsed;
            if (splitContainer2.Panel1Collapsed) btnCollapseReplay.Text = "展开";
            else btnCollapseReplay.Text = "收起";

        }
        private void Set_default_time() {
            form2.dateTimeIntervelPicker.DefaultStartTime  = new string[] { 
                indexArray[0].Split(' ')[0], indexArray[0].Split(' ')[1].Split('.')[0],indexArray[0].Split(' ')[1].Split('.')[1]};
            form2.dateTimeIntervelPicker.DefaultEndTime  = new string[] {
                indexArray[indexArray.Count-1].Split(' ')[0], indexArray[indexArray.Count-1].Split(' ')[1].Split('.')[0],indexArray[indexArray.Count-1].Split(' ')[1].Split('.')[1]}; ;
            
        }
        public void Draw_replay_curve(int startReplayIndex,int endReplayIndex,Color color,int length) {
            if (length <= 1) {
                MessageBox.Show("所选范围内仅一条数据。");
                return;
            }
            userCurve1.RemoveAllCurve();userCurve2.RemoveAllCurve();

            userCurve1.SetLeftCurve("A", new float[] { }, color);
            userCurve1.StrechDataCountMax = length;
            userCurve1.IsAbscissaStrech = true;

            userCurve2.SetLeftCurve("B", new float[] { }, color);
            userCurve2.StrechDataCountMax = length;
            userCurve2.IsAbscissaStrech = true;
            exportDataList = new List<ExportData>();
            float[] array1;
            float[] array2;
            //List<float> signalList = new List<float>();
            string[] XAxisArray = new string[length];
            int k = 0;
            //string connectstring = $"server = localhost; user = {databaseUsername}; password = {databasePassWord} ; database = array";
            int slice = 15;
            int interval = get_interval(length, slice);
            bool hasData = false;
            using (MySqlConnection connection = new MySqlConnection(connectstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    int rowCount = length>200 ? 200: length;
                    
                    int offset = startReplayIndex;
                    array1 = new float[rowCount];
                    array2 = new float[rowCount];
                    while (true)
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT * FROM {currentTableName} LIMIT @offset,@rowCount";
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@offset", offset);
                        command.Parameters.AddWithValue("@rowCount", rowCount);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                if (k > length-1)
                                {
                                    break;
                                }
                                hasData = true;
                                array1[i] = (float)reader["signal1"];
                                array2[i] = (float)reader["signal2"];
                                exportDataList.Add(new ExportData() {
                                    timestamp = reader["timestamp"].ToString() + $".{reader["milliseconds"]}",
                                    milliseconds = reader["milliseconds"].ToString(),
                                    signal1 = array1[i],
                                    signal2 = array2[i]});
                                //signalList.Add((float)reader[signal]);
                                if ((k % interval == 0 && (k / interval) % 3 == 0) || k == length-1)
                                {
                                    XAxisArray[k] = Parse_Time(reader["timestamp"].ToString()) + $".{reader["milliseconds"]}";
                                    

                                }
                                else XAxisArray[k] = "";
                                k++;
                                i++;
                            }
                            if (hasData) //读取了200条记录
                            {
                                userCurve1.AddCurveData("A", array1);
                                userCurve2.AddCurveData("B", array2);
                            }
                            
                            if (reader.Read() == false && i < rowCount||k> endReplayIndex) break; //若已经读到最后一页的最后一条记录，不足200条记录，
                                                                                           //且当前索引小于200，说明所有数据已经读取完毕
                            offset += rowCount;
                        }


                    }

                }
                userCurve1.SetCurveText(XAxisArray);
                userCurve2.SetCurveText(XAxisArray);
            }
        }
        private void Replay_Button_Click(object sender, EventArgs e)
        {
            // Console.WriteLine(userCurve_replay1.Width);
            //currentTableName = "well1_segment1_signals";
            Set_gather_component_mode(false);
            int selectInterval = 200;//间隔多少条取数据
            Replay(selectInterval);
        }
        private void Replay(int selectInterval) {
            int length = Get_Length() - startIndex;
            //int length = Get_Length();
           // 
            int sampleLength = length / selectInterval;
            if (sampleLength > 1) 
            {
                userCurve_replay1.SetLeftCurve("C", new float[] { }, Color.DeepSkyBlue);
                userCurve_replay2.SetLeftCurve("D", new float[] { }, Color.DeepSkyBlue);
                userCurve_replay1.StrechDataCountMax = userCurve_replay2.StrechDataCountMax = sampleLength;

                userCurve_replay1.IsAbscissaStrech = userCurve_replay2.IsAbscissaStrech = true;

                float[] array1;
                float[] array2;
                List<float> signalList1 = new List<float>();
                List<float> signalList2 = new List<float>();
                indexArray = new List<string>();
                customXAxisArray = new string[sampleLength];
                string time;
                int k = 0;
                int j = 0;

                int slice = 15;
                int interval = get_interval(sampleLength, slice);
                //textBox3.Text = (interval).ToString();
                bool hasData = false;

                using (MySqlConnection connection = new MySqlConnection(connectstring))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        int rowCount = sampleLength > 200 ? 200 : sampleLength;
                        int offset = startIndex / selectInterval;
                        array1 = new float[rowCount];
                        array2 = new float[rowCount];
                        while (true)
                        {
                            command.Connection = connection;
                            command.CommandText = $"select * from (select @n:=@n+1 as i, a.* from (select * from {currentTableName})a,(select @n:=0)b)c where c.i%{selectInterval}=1 LIMIT @offset,@rowCount ";
                            //command.CommandText = $"SELECT * FROM {currentTableName} LIMIT @offset,@rowCount";
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
                                    if ((k % interval == 0 && (k / interval) % 3 == 0) || k == sampleLength - 1)
                                        //customXAxisArray[k] = Parse_Time(reader["timestamp"].ToString()) + $".{reader["milliseconds"]}";
                                        customXAxisArray[k] = Parse_Time(reader["timestamp"].ToString());

                                    else
                                        customXAxisArray[k] = " ";
                                    //Console.WriteLine(reader["timestamp"].ToString() + $".{reader["milliseconds"]}");
                                    indexArray.Add(reader["timestamp"].ToString() + $".{reader["milliseconds"]}");
                                    k++;
                                    i++;
                                }
                                if (hasData)
                                {
                                    userCurve_replay1.AddCurveData("C", array1);
                                    userCurve_replay2.AddCurveData("D", array2);
                                }
                                //if (reader.Read() == false && i < rowCount) break;
                                if (k>=sampleLength) break;
                                offset += rowCount;
                            }


                        }

                    }
                    //Console.WriteLine(sampleLength);
                    if (hasData)
                    {
                        if (!isReplaying)
                        {
                            Set_default_time();
                            isReplaying = true;
                        }

                        userCurve_replay1.SetCurveText(customXAxisArray);
                        userCurve_replay2.SetCurveText(customXAxisArray);
                        userCurve_replay1.Invalidate(); userCurve_replay2.Invalidate();
                        Choose_Time_Button.Visible = true;
                        btnCollapseReplay.Visible = true; //折叠按钮
                        btnCollapseReplay.Text = "收起";
                        splitContainer2.Panel1Collapsed = false;
                    }
                    //else MessageBox.Show("暂无数据");
                }
            }
            
        }
        private void Export_Button_Click(object sender, EventArgs e)
        {
            if (exportDataList == null) {
                MessageBox.Show("无数据");
                return;
            }
            AuxiliaryLinesTime = Form2.AuxiliaryLines;
            string parantPath="";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择输出文件夹";
            int startIndex, endIndex, length;
            startIndex = getTimeIndex(AuxiliaryLinesTime[0]);
            endIndex = getTimeIndex(AuxiliaryLinesTime[1]);
            length = endIndex - startIndex + 1;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示"); return;
                }
                parantPath = dialog.SelectedPath;
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(parantPath, "signal.csv"), false, Encoding.Default))
                {
                    // 写入表头
                    sw.WriteLine("Timestamp,Milliseconds,Signal1,Signal2");

                    // 写入数据
                    foreach (ExportData exportData in exportDataList)
                    {
                        sw.WriteLine($"{exportData.timestamp},{exportData.milliseconds},{exportData.signal1},{exportData.signal2}");
                    }
                    MessageBox.Show($"文件已写入{Path.Combine(parantPath, "signal.csv")}");
                }
            }
            catch (Exception error) {
                MessageBox.Show(error.Message);
                return;
            }
            
        }
    }
}