using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace C_Sharp_PLC_1
{
    public partial class Form3 : Form
    {
        Form1 mainForm;
        public int current_well;
        public int current_segment;
        string databaseUsername = "root";
        string databasePassWord = "lichunrui";
        string connectstring;
        DataTable wells_dataTable;
        DataTable segments_dataTable;
        bool addWellMode = false;
        bool addSegmentMode = false;
        static int defaultWell=0;
        static int defaultSegment=0;
        bool combobox_editable;
        public Form3(Form1 mForm)
        {
            InitializeComponent();
            mainForm = mForm;
            connectstring = $"server = localhost; user = {databaseUsername}; password = {databasePassWord} ; database = array";

            comboBox_wells.DropDownStyle = comboBox_segments.DropDownStyle = ComboBoxStyle.DropDown;

            getAllWellName();
            comboBox_wells.SelectedIndex = defaultWell;
            comboBox_segments.SelectedIndex = defaultSegment;
            
            
            
        }

        private void Confirm_button_Click(object sender, EventArgs e)
        {
            string newWellName = comboBox_wells.Text;
            string newSegmentName = comboBox_segments.Text;
            DateTime currentTime = DateTime.Now;
            string time = currentTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            MySqlConnection connection = new MySqlConnection(connectstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            if (newWellName == "" || newSegmentName == "")
            {
                MessageBox.Show("请选择井/段号！");
                return;
            }
            else if (addWellMode)
            {
                command.CommandText = $"INSERT INTO wells (create_time, name) VALUES (@time, @name)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@name", newWellName);
                command.ExecuteNonQuery();

                current_well = getWellIdByName(newWellName);
                command.CommandText = $"INSERT INTO segments (create_time, name,well_id) VALUES (@time, @name,@well_id)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@name", newSegmentName);
                command.Parameters.AddWithValue("@well_id", current_well);
                command.ExecuteNonQuery();
                current_segment = getSegmentIdByNameAndWellId(newSegmentName, current_well);
                //MessageBox.Show($"新建井、段成功！井：{current_well}，段：{current_segment}");

            }
            else if (addSegmentMode)
            {
                current_well = getWellIdByName(newWellName);
                command.CommandText = $"INSERT INTO segments (create_time, name,well_id) VALUES (@time, @name,@well_id)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@name", newSegmentName);
                command.Parameters.AddWithValue("@well_id", current_well);
                command.ExecuteNonQuery();
                current_segment = getSegmentIdByNameAndWellId(newSegmentName, current_well);
                //MessageBox.Show($"新建段成功！井：{current_well}，段：{current_segment}");
            }
            else {
                current_well = getWellIdByName(newWellName);
                current_segment = getSegmentIdByNameAndWellId(newSegmentName, current_well);
                //MessageBox.Show($"选择井段成功！井：{current_well}，段：{current_segment}");
            }
            connection.Close();
            addWellMode = addSegmentMode = false;
            defaultWell = comboBox_wells.SelectedIndex;
            defaultSegment = comboBox_segments.SelectedIndex;
            mainForm.currentTableName = $"well{current_well}_segment{current_segment}_signals";
            mainForm.CreateTableIfNotExists(mainForm.currentTableName);
            //Console.WriteLine(defaultWell);
            mainForm.startIndex = mainForm.Get_Length();
            //mainForm.startIndex =0;
            mainForm.well_name.Text = newWellName;
            mainForm.segment_name.Text = newSegmentName;
            mainForm.currentTime = currentTime;
            mainForm.gather();
            this.Close();

        }
        public int getWellIdByName(string well_name) {
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
        public int getSegmentIdByNameAndWellId(string segment_name,int well_id)
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
        public void getAllWellName() {
            
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
                        if (reader.HasRows) {
                            wells_dataTable = new DataTable();
                            wells_dataTable.Load(reader);
                            comboBox_wells.DataSource = wells_dataTable;
                            comboBox_wells.DisplayMember = "name";
                            comboBox_wells.ValueMember = "id";
                        }
                    }
                }
            }
        }
        public void getAllSegmentsName(int well_id) {
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

        private void comboBox_wells_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)comboBox_wells.SelectedItem;
            int select_well_id = Convert.ToInt32(drv.Row["id"].ToString());
            getAllSegmentsName(select_well_id);
        }

        private void button_addWell_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_wells_TextChanged(object sender, EventArgs e)
        {         
        }
        private void comboBox_wells_TextUpdate(object sender, EventArgs e)
        {
            //Console.WriteLine("change");
        }
        private void comboBox_wells_Leave(object sender, EventArgs e)
        {

            string newWellName = comboBox_wells.Text;
            int index = 0;
            foreach (DataRowView item in comboBox_wells.Items)
            {
                if (newWellName == item.Row["name"].ToString()) {
                    int select_well_id = Convert.ToInt32(item.Row["id"].ToString());
                    comboBox_wells.SelectedIndex = index;
                    getAllSegmentsName(select_well_id);
                    addWellMode = false;
                    return;
                }
                index++;
            }
            comboBox_segments.DataSource = null;
            addWellMode = true;

        }

        private void comboBox_segments_Leave(object sender, EventArgs e)
        {
            int index = 0;
            string newSegmentName = comboBox_segments.Text;
            foreach (DataRowView item in comboBox_segments.Items)
            {
                if (newSegmentName == item.Row["name"].ToString()) {
                    comboBox_segments.SelectedIndex = index;
                    return;
                }
                index++;
            }
            addSegmentMode = true;
        }
    }
}
