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
using HslCommunication.Controls;
using System.Threading;
using System.Windows.Input;

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
        public List<string> indexArray; // 存放秒点回放数据的时间戳，用于后续获得相应索引以绘制辅助线
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
        public int startIndex, endIndex;//记录当前采集时间段的起止记录索引
        int startReplayIndex, endReplayIndex;//记录指定时间段的起止记录索引(用于展示、导出)
        public string currentTableName;
        public string currentExportFileName;
        public List<HslControls.AuxiliaryLine> auxiliaryLine;
        public Pen pen_Auxiliary_Line;
        public Brush brush_Auxiliary_text;
        //public AuxiliaryLine auxiliaryLines = new AuxiliaryLine();
        public Form1()
        {
            InitializeComponent();
            connectstring = $"server = localhost; user = {databaseUsername}; password = {databasePassWord} ; database = array;Allow User Variables=True";
            form2 = new Form2(this);
            myTabControl1.Dock= DockStyle.Fill;
            startIndex = endIndex = 0;
            getAllWellName(comboBox_collect_well);
            if (wells_dataTable != null)
            {
                comboBox_collect_well.SelectedIndex = defaultWell;
                comboBox_collect_segment.SelectedIndex = defaultSegment;
            }
            //startIndex = 8800;
            //currentTableName = "well11_segment15_signals";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //userCurve_replay1.SetLeftCurve("C", new float[] { }, Color.Red);
            //userCurve_replay2.SetLeftCurve("D", new float[] { }, Color.Blue);
        }
        /// <summary>
        /// 设置连接组件的状态值
        /// </summary>
        /// <param name="mode"></param>
        private void Set_connect_component_mode(bool mode) {
            
            if (mode) {
                userLantern1.LanternBackground = Color.Green;
                label_isConnect.Text = "已连接";
                label_Btn_Connect.Text = "断开连接";
                Gather_Button.Enabled = true;
                Connect_Button.BackgroundImage = Properties.Resources.disconnect;
            }
            else {
                userLantern1.LanternBackground = Color.Red;
                label_isConnect.Text = "未连接";
                label_Btn_Connect.Text = "连接";
                Gather_Button.Enabled = false;
                Connect_Button.BackgroundImage = Properties.Resources.connect;
            }
        }
        /// <summary>
        /// 设置传输组件的状态值
        /// </summary>
        /// <param name="mode"></param>
        private void Set_gather_component_mode(bool mode) {
            if (mode)
            {
                //userCurve_detail1.StrechDataCountMax = userCurve_detail2.StrechDataCountMax = 300;

                //userCurve_detail1.IsAbscissaStrech = userCurve_detail2.IsAbscissaStrech = false;

                //userCurve_detail1.TextAddFormat = userCurve_detail2.TextAddFormat = "HH:mm:ss";

                userLantern2.LanternBackground = Color.Green;
                button_collect_confirm.Text = "停止采集";
                label_isGathering.Text = "采集中";
                Connect_Button.Enabled = false;
                Replay_Button.Enabled = true;

                isGathering = true;
                isReplaying = false;
                //Gather_Button.BackgroundImage = Properties.Resources.stop;

            }
            else
            {
                isGathering = false;
                userLantern2.LanternBackground = Color.Red;
                button_collect_confirm.Text = "开始采集";
                label_isGathering.Text = "未采集";
                Connect_Button.Enabled = true;
                //Gather_Button.BackgroundImage = Properties.Resources.collect;
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

                    userCurve_collect1.SetLeftCurve("A", new float[] { }, Color.Red);
                    userCurve_collect2.SetLeftCurve("B", new float[] { }, Color.Blue);
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
            userCurve_collect1.RemoveAllCurve(); userCurve_collect2.RemoveAllCurve();
            userCurve_collect1.SetLeftCurve("A", new float[] { }, Color.Red); userCurve_collect2.SetLeftCurve("B", new float[] { }, Color.Blue);
            //userCurve_replay1.RemoveAllCurve(); userCurve_replay2.RemoveAllCurve();
            userCurve_detail1.RemoveAllCurve(); userCurve_detail2.RemoveAllCurve();
            //先判断是否已经存在该选项卡
            foreach (TabPage tabPage in myTabControl1.TabPages)
            {
                if (tabPage.Text == "数据采集")
                {
                    myTabControl1.SelectedTab = tabPage;
                    return;
                }
            }
            //disposeReplayLine();

            //splitContainer_replay.Panel1Collapsed = true;
            //Choose_Time_Button.Visible = false;
            //Export_Button.Visible = false;
        }

        private void Gather_Button_Click(object sender, EventArgs e)
        {

            //先判断是否已经存在该选项卡
            foreach (TabPage tabPage in myTabControl1.TabPages)
            {
                if (tabPage.Text == "数据采集")
                {
                    myTabControl1.SelectedTab = tabPage;
                    return;
                }
            }
            // 创建新的TabPage
            TabPage newTabPage = new TabPage("数据采集");

            SplitContainer splitContainer = splitContainer_collect;

            // 移除SplitContainer从其父容器中
            splitContainer.Parent = null;
            splitContainer_collect.Visible = true;
            splitContainer_collect.Dock = DockStyle.Fill;
            // 将Label添加到TabPage
            newTabPage.Controls.Add(splitContainer_collect);

            // 将新的TabPage添加到TabControl
            myTabControl1.TabPages.Add(newTabPage);
            myTabControl1.SelectedTab = newTabPage;

            well_name.Text = comboBox_collect_well.Text;
            segment_name.Text = comboBox_collect_segment.Text;




        }

        //--------------------------------------------------------------------------------------
        DataTable wells_dataTable;
        DataTable segments_dataTable;
        static int defaultWell = 0;
        static int defaultSegment = 0;
        public int getWellIdByName(string well_name)
        {
            int id;

            using (MySqlConnection connection = new MySqlConnection(connectstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"SELECT id FROM wells WHERE name='{well_name}'";
                    id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return id;
        }
        public int getSegmentIdByNameAndWellId(string segment_name, int well_id)
        {
            int id;

            using (MySqlConnection connection = new MySqlConnection(connectstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"SELECT id FROM segments WHERE name='{segment_name}' AND well_id ={well_id} ";
                    id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return id;
        }
        public void getAllWellName(ComboBox comboBox_well)
        {

            using (MySqlConnection connection = new MySqlConnection(connectstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"SELECT id, name FROM wells";
                    command.Parameters.Clear();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            wells_dataTable = new DataTable();
                            wells_dataTable.Load(reader);
                            comboBox_well.DataSource = wells_dataTable;
                            comboBox_well.DisplayMember = "name";
                            comboBox_well.ValueMember = "id";
                        }
                    }
                }
            }
        }
        public void getAllSegmentsName(int well_id, ComboBox comboBox_segments)
        {
            using (MySqlConnection connection = new MySqlConnection(connectstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"SELECT * FROM segments WHERE well_id={well_id}";
                    command.Parameters.Clear();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            segments_dataTable = new DataTable();
                            segments_dataTable.Load(reader);
                            comboBox_segments.DataSource = segments_dataTable;
                            comboBox_segments.DisplayMember = "name";
                            comboBox_segments.ValueMember = "id";
                        }
                    }
                }
            }
        }
        private void comboBox_collect_well_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wells_dataTable != null)
            {
                DataRowView drv = (DataRowView)comboBox_collect_well.SelectedItem;
                int select_well_id = Convert.ToInt32(drv.Row["id"].ToString());
                getAllSegmentsName(select_well_id, comboBox_collect_segment);
            }
            well_name.Text = comboBox_collect_well.Text;
            
        }
        //--------------------------------------------------------------------------------------
        public int current_well;
        public int current_segment;
        private void button_collect_confirm_Click(object sender, EventArgs e)
        {
            string newWellName = comboBox_collect_well.Text;
            string newSegmentName = comboBox_collect_segment.Text;

            if (!isGathering) {
                //初始化曲线框
                userCurve_collect1.RemoveAllCurve(); userCurve_collect2.RemoveAllCurve();
                userCurve_collect1.SetLeftCurve("A", new float[] { }, Color.Red); userCurve_collect2.SetLeftCurve("B", new float[] { }, Color.Blue);

                currentTime = DateTime.Now;
                MySqlConnection connection = new MySqlConnection(connectstring);
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                if (newWellName == "" || newSegmentName == "")
                {
                    MessageBox.Show("请选择井/段号！");
                    return;
                }
                else
                {
                    current_well = getWellIdByName(newWellName);
                    current_segment = getSegmentIdByNameAndWellId(newSegmentName, current_well);
                }
                connection.Close();
                defaultWell = comboBox_collect_well.SelectedIndex;
                defaultSegment = comboBox_collect_segment.SelectedIndex;

                currentTableName = $"well{current_well}_segment{current_segment}_signals";
                currentExportFileName = $"{newWellName}_{newSegmentName}_signals";
                startIndex = Get_Length()+1;
                Set_gather_component_mode(true);
                timer1.Interval = 10;
                timer1.Start();
                comboBox_collect_well.Enabled= false;
                comboBox_collect_segment.Enabled= false;
            }             
            else
            {
                //endIndex = Get_Length();
                Set_gather_component_mode(false);
                comboBox_collect_well.Enabled = true;
                comboBox_collect_segment.Enabled=true;
                //Replay(1);

            }


        }
        /// <summary>
        /// 传输数据函数，在选择井、段后被调用
        /// </summary>
        public void Gather() {
            Set_gather_component_mode(true);
            timer1.Interval = 10;
            timer1.Start();                            
        }

        /// <summary>
        /// 计时器事件，用于控制数据展示及入库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Elapsed(object sender, EventArgs e)
        {
            if (!isGathering)
            {
                timer1.Stop();
                return;
            }

            ST_Data dataRead;
            int varHandle = adsClient.CreateVariableHandle("MAIN.stData");
            int rowCount = 100; //每个interval读取数量

            float[] array1 = new float[rowCount]; //用于暂存signal1数据
            float[] array2 = new float[rowCount]; //用于暂存signal2数据
            string time;
            int milliseconds;                     
            try
            {
                // 数据绘制
                for (int k = 0; k < rowCount; k++)
                {

                    dataRead = (ST_Data)adsClient.ReadAny(varHandle, typeof(ST_Data));
                    array1[k] = (float)dataRead.data[k].dintArr[0];
                    array2[k] = (float)dataRead.data[k].dintArr[1]; 
                }

                userCurve_collect1.AddCurveData("A", array1); userCurve_collect2.AddCurveData("B", array2);
                userCurve_collect1.Invalidate(); userCurve_collect2.Invalidate();

                //数据入库
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
                            command.CommandText = $"INSERT INTO {currentTableName} (timestamp, milliseconds, signal1, signal2) VALUES (@timestamp, @milliseconds, @value1, @value2)";
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

        private void Replay_Button_Click(object sender, EventArgs e)
        {           
            
            //先判断是否已经存在该选项卡
            foreach (TabPage tabPage in myTabControl1.TabPages)
            {
                if (tabPage.Text == "数据回放")
                {
                    myTabControl1.SelectedTab = tabPage;
                    return;
                }
            }
            // 创建新的TabPage
            TabPage newTabPage = new TabPage("数据回放");

            SplitContainer splitContainer = splitContainer_replay;

            // 移除SplitContainer从其父容器中
            splitContainer_replay.Parent = null;
            splitContainer_replay.Visible = true;
            splitContainer_replay.Dock = DockStyle.Fill;
            // 将Label添加到TabPage
            newTabPage.Controls.Add(splitContainer_replay);

            // 将新的TabPage添加到TabControl
            myTabControl1.TabPages.Add(newTabPage);
            myTabControl1.SelectedTab = newTabPage;


            int currentLength = Get_Length() - startIndex+1; // 当前时间段接收数据总数
            using (MySqlConnection connection = new MySqlConnection(connectstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"SELECT TIMESTAMPDIFF(MINUTE, MIN(timestamp), MAX(timestamp)) as minutes FROM (SELECT timestamp  FROM {currentTableName} ORDER BY timestamp LIMIT @startIndex,@length) AS subquery;";
                    command.Parameters.AddWithValue("@startIndex", startIndex);
                    command.Parameters.AddWithValue("@length", currentLength);
                    numericUpDown_start.Maximum=numericUpDown_end.Maximum = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            int selectInterval = 1000;//间隔多少条取数据
            Replay(selectInterval);
        }

        private void button_replay_confirm_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// 回放当前时间段采集的秒点数据
        /// </summary>
        /// <param name="selectInterval"></param>
        private void Replay(int selectInterval)
        {
            Set_gather_component_mode(false);
            int currentLength = Get_Length() - startIndex+1; // 当前时间段接收数据总数
            int sampleLength = currentLength / selectInterval; // 当前时间段接收数据的秒点采样总数

            
            using (MySqlConnection connection = new MySqlConnection(connectstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    if(selectInterval<=1) command.CommandText = $"SELECT COUNT(*) FROM (select @n:=@n+1 as i, a.* from (select * from {currentTableName} LIMIT @startIndex,@length)a,(select @n:=0)b)c where c.i%1=0 ";

                    else command.CommandText = $"SELECT COUNT(*) FROM (select @n:=@n+1 as i, a.* from (select * from {currentTableName} LIMIT @startIndex,@length)a,(select @n:=0)b)c where c.i%{selectInterval}=1 ";
                    command.Parameters.AddWithValue("@startIndex", startIndex);
                    command.Parameters.AddWithValue("@length", currentLength);
                    sampleLength = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            

            if (sampleLength > 1) // 数据量超过1才绘制
            {
                // 初始化回放框
                userCurve_replay1.SetLeftCurve("C", new float[] { }, Color.DeepSkyBlue);
                userCurve_replay2.SetLeftCurve("D", new float[] { }, Color.DeepSkyBlue);
                userCurve_replay1.StrechDataCountMax = userCurve_replay2.StrechDataCountMax = sampleLength;

                float[] array1;
                float[] array2;

                indexArray = new List<string>(); 
                customXAxisArray = new string[sampleLength]; // 回放框横坐标数组
                int k = 0;
                int afterExpandWidth = userCurve_replay1.Size.Width;
                int interval = get_interval(afterExpandWidth); // 获得回放框中纵向辅助线之间的间隔

                bool hasData = false;

                using (MySqlConnection connection = new MySqlConnection(connectstring))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        int rowCount = sampleLength > 200 ? 200 : sampleLength;
                        int offset = 0;
                        array1 = new float[rowCount];
                        array2 = new float[rowCount];
                        while (true)
                        {
                            command.Connection = connection;
                            if (selectInterval <= 1)
                            {
                                command.CommandText = $"select row_number() over(ORDER BY signal_id) as rownum,c.*  from (select @n:=@n+1 as i, a.* from (select * from {currentTableName} LIMIT @startIndex,@length)a,(select @n:=0)b)c where c.i%{selectInterval}=0 LIMIT @offset,@rowCount ";

                            }

                            else {
                                command.CommandText = $"select row_number() over(ORDER BY signal_id) as rownum,c.*  from (select @n:=@n+1 as i, a.* from (select * from {currentTableName} LIMIT @startIndex,@length)a,(select @n:=0)b)c where c.i%{selectInterval}=1 LIMIT @offset,@rowCount ";

                            }

                            //command.CommandText = $"SELECT * FROM {currentTableName} LIMIT @offset,@rowCount";
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@startIndex", startIndex);
                            command.Parameters.AddWithValue("@length", Get_Length());
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
                                    k = int.Parse(reader["rownum"].ToString()) - 1;
                                    if ((k % interval == 0 && (k / interval) % 2 == 0) || k == sampleLength - 1)
                                        customXAxisArray[k] = Parse_Time(reader["timestamp"].ToString());

                                    else
                                        customXAxisArray[k] = " ";
                                    indexArray.Add(reader["timestamp"].ToString() + $".{reader["milliseconds"]}");
                                    //k++;
                                    i++;
                                }
                                if (hasData)
                                {
                                    userCurve_replay1.AddCurveData("C", array1);
                                    userCurve_replay2.AddCurveData("D", array2);
                                }
                                if (reader.Read() == false && i < rowCount) break;
                                //if (k >= sampleLength) break;
                                offset += rowCount;
                            }


                        }

                    }

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
                        splitContainer_replay.Panel1Collapsed = false;
                    }
                    //else MessageBox.Show("暂无数据");
                }
            }

        }
        /// <summary>
        /// 清空回放框曲线及辅助线
        /// </summary>
        private void disposeReplayLine()
        {
            userCurve_replay1.RemoveAllCurve();
            userCurve_replay2.RemoveAllCurve();
            AuxiliaryLinesTime = null;
            if(indexArray!=null)
                indexArray.Clear();
            pen_Auxiliary_Line?.Dispose();
            brush_Auxiliary_text?.Dispose();
            userCurve_replay1.Invalidate();
            userCurve_replay2.Invalidate();
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
        /// <summary>
        /// 绘制指定时间段回放曲线
        /// </summary>
        public void Draw_replay_curve()
        {
            //Console.WriteLine($"startReplayIndex:{startReplayIndex}");
            
            int length;
            Color color = Color.Red;
            string startReplayTime = indexArray[getTimeIndexFromMinute(int.Parse(numericUpDown_start.Text))]; //indexArray[getTimeIndex(ParseStringToSqlFormat(AuxiliaryLinesTime[0]))]; 
            string endReplayTime = indexArray[getTimeIndexFromMinute(int.Parse(numericUpDown_end.Text)+1)]; //indexArray[getTimeIndex(ParseStringToSqlFormat(AuxiliaryLinesTime[1]))]; 
            
            using (MySqlConnection connection = new MySqlConnection(connectstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"SELECT COUNT(*) FROM {currentTableName} WHERE timestamp <= @startReplayTime";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@startReplayTime", startReplayTime);
                    startReplayIndex = Convert.ToInt32(command.ExecuteScalar()) - 1;

                    command.CommandText = $"SELECT COUNT(*) FROM {currentTableName} WHERE timestamp <= @endReplayTime";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@endReplayTime", endReplayTime);
                    endReplayIndex = Convert.ToInt32(command.ExecuteScalar()) - 1;
                }
            }
            length = endReplayIndex - startReplayIndex + 1;
            if (length <= 1)
            {
                MessageBox.Show("所选范围内仅一条数据。");
                return;
            }
            userCurve_detail1.RemoveAllCurve(); userCurve_detail2.RemoveAllCurve();

            userCurve_detail1.SetLeftCurve("A", new float[] { }, color);
            userCurve_detail1.StrechDataCountMax = length;
            userCurve_detail1.IsAbscissaStrech = true;

            userCurve_detail2.SetLeftCurve("B", new float[] { }, color);
            userCurve_detail2.StrechDataCountMax = length;
            userCurve_detail2.IsAbscissaStrech = true;
            exportDataList = new List<ExportData>();
            float[] array1;
            float[] array2;
            //List<float> signalList = new List<float>();
            string[] XAxisArray = new string[length];
            int k = 0;
            
            int interval = get_interval(userCurve_detail1.Width);
            bool hasData = false;
            using (MySqlConnection connection = new MySqlConnection(connectstring))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    int rowCount = length > 200 ? 200 : length;

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
                                if (k > length - 1)
                                {
                                    break;
                                }
                                hasData = true;
                                array1[i] = (float)reader["signal1"];
                                array2[i] = (float)reader["signal2"];
                                exportDataList.Add(new ExportData()
                                {
                                    timestamp = reader["timestamp"].ToString() + $".{reader["milliseconds"]}",
                                    milliseconds = reader["milliseconds"].ToString(),
                                    signal1 = array1[i],
                                    signal2 = array2[i]
                                });
                                //signalList.Add((float)reader[signal]);
                                if ((k % interval == 0 && (k / interval) % 3 == 0) || k == length - 1)
                                {
                                    XAxisArray[k] = Parse_Time(reader["timestamp"].ToString()) + $".{reader["milliseconds"]}";


                                }
                                else XAxisArray[k] = "";
                                k++;
                                i++;
                            }
                            if (hasData) //读取了200条记录
                            {
                                userCurve_detail1.AddCurveData("A", array1);
                                userCurve_detail2.AddCurveData("B", array2);
                            }

                            if (reader.Read() == false && i < rowCount || k > endReplayIndex) break; //若已经读到最后一页的最后一条记录，不足200条记录，
                                                                                                     //且当前索引小于200，说明所有数据已经读取完毕
                            offset += rowCount;
                        }


                    }

                }
                userCurve_detail1.SetCurveText(XAxisArray);
                userCurve_detail2.SetCurveText(XAxisArray);
            }
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
        /// <summary>
        /// 时间辅助线绘制
        /// </summary>
        /// <param name="AuxiliaryLinesTime"></param>
        /// <param name="userCurve"></param>
        /// <param name="e"></param>
        private void draw_replay_auxiliaryLine(string[] AuxiliaryLinesTime, UserCurve userCurve, PaintEventArgs e)
        {
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
        private string SaveFilePathName(string fileName, string filter = null, string title = null) {
            string path = "";
            SaveFileDialog fbd = new SaveFileDialog();
            fbd.Filter = "Csv|*.csv;";
            fbd.Title = "导出为";
            if (!string.IsNullOrEmpty(fileName))
            { 
                fbd.FileName = fileName;

            }
            if(!string.IsNullOrEmpty(filter)) fbd.Filter = filter;
            if (!string.IsNullOrEmpty(filter)) fbd.Title = title;
            if (fbd.ShowDialog() == DialogResult.OK) path = fbd.FileName;
            
           // Console.WriteLine(currentExportFileName);
            return path;

        }
        private void Export_Button_Click(object sender, EventArgs e)
        {
            if (exportDataList == null)
            {
                MessageBox.Show("无数据");
                return;
            }
            string path = SaveFilePathName(currentExportFileName);
            
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
                {
                    // 写入表头
                    sw.WriteLine("Timestamp,Milliseconds,Signal1,Signal2");

                    // 写入数据
                    foreach (ExportData exportData in exportDataList)
                    {
                        sw.WriteLine($"{exportData.timestamp},{exportData.milliseconds},{exportData.signal1},{exportData.signal2}");
                    }
                    MessageBox.Show($"文件导出成功！");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }

        }

        private void btnCollapseReplay_Click(object sender, EventArgs e)
        {
            splitContainer_replay.Panel1Collapsed = !splitContainer_replay.Panel1Collapsed;
            if (splitContainer_replay.Panel1Collapsed) btnCollapseReplay.Text = "展开";
            else btnCollapseReplay.Text = "收起";

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
            dtime = time.Split(' ')[1];
            return dtime;
        }
        private int get_interval(int afterExpandWidth)
        {
            //int afterExpandWidth = 728; //userCurve_replay1.Size.Width
            float offect = ( afterExpandWidth- leftRight * 2) * 1.0f / (userCurve_replay1.StrechDataCountMax - 1);
            if (offect > 40) return 1;
            offect = 40f / offect;
            return (int)Math.Ceiling(offect);
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
        public int getTimeIndexFromMinute(int minute)
        {
            DateTime time = Convert.ToDateTime(indexArray[0]).AddMinutes(minute);
            
            for (int i = 0; i < indexArray.Count; i++)
            {
                if (time <= Convert.ToDateTime(indexArray[i])) return i;
            }
            return indexArray.Count - 1;

        }
        public int getTimeIndexFromSecond(int second)
        {

            int s = 0;
            int oldTargetSecond = int.Parse(indexArray[0].Split(' ')[1].Split(':')[1]);
            for (int i = 1; i < indexArray.Count; i++)
            {

                string[] targetArray = indexArray[i].Split(' ');
                int tartgetMinute = int.Parse(targetArray[1].Split(':')[1]);
                if (tartgetMinute > oldTargetSecond)
                {
                    s++;
                    oldTargetSecond = tartgetMinute;
                }
                if (second == s)
                    return i;
            }
            return indexArray.Count - 1;

        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Setting_Button_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button_replay_detail_confirm_Click(object sender, EventArgs e)
        {
            Draw_replay_curve();
        }

        private void comboBox_collect_segment_SelectedIndexChanged(object sender, EventArgs e)
        {
            segment_name.Text = comboBox_collect_segment.Text;
        }

        private void Set_default_time() {
            form2.dateTimeIntervelPicker.DefaultStartTime  = new string[] { 
                indexArray[0].Split(' ')[0], indexArray[0].Split(' ')[1].Split('.')[0]};
            form2.dateTimeIntervelPicker.DefaultEndTime  = new string[] {
                indexArray[indexArray.Count-1].Split(' ')[0], indexArray[indexArray.Count-1].Split(' ')[1].Split('.')[0]};
            
        }
        private string ParseStringToSqlFormat(string time) {
            //将时间字符串 "yyyy/mm/dd hh:mm:ss.fff"解析为sql格式 "yyyy-mm-dd hh:mm:ss.fff"

            string res;
            res = string.Join("-",time.Split(' ')[0].Split('/')[0], time.Split(' ')[0].Split('/')[1], time.Split(' ')[0].Split('/')[2]);
            res += " " + time.Split(' ')[1];
            return res;
        }



    }
}