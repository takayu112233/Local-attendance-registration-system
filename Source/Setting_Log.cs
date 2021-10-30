using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFC_OFFLINE_APP
{
    public partial class Setting_Log : Form
    {
        public int delay_setting = 0;
        public DateTime delay_time;
        public int Insert_flag;
        public int ok;
        int all_count;
        string flag_string;

        public Setting_Log(int delayonoff, DateTime delay ,int Insert_flag,int getdata,string write_address)
        {
            ok = 0;
            InitializeComponent();
            this.delay_time = delay;
            this.delay_setting = delayonoff;
            this.Insert_flag = Insert_flag;
            if (getdata == 0)
            {
                dataGridView_log.Enabled = false;
            }
            else
            {
                dataGridView_log.Enabled = true;
                dataGridView_log.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                dataGridView_log.ColumnCount = 4;
                dataGridView_log.Columns[0].HeaderText = "No.";
                dataGridView_log.Columns[0].Width = 120;
                dataGridView_log.Columns[1].HeaderText = "時間";
                dataGridView_log.Columns[1].Width = 290;
                dataGridView_log.Columns[2].HeaderText = "学籍番号";
                dataGridView_log.Columns[2].Width = 250;
                dataGridView_log.Columns[3].HeaderText = "登録状況";
                dataGridView_log.Columns[3].Width = 250;

                try
                {
                    StreamReader reader = new StreamReader(@write_address, Encoding.GetEncoding("shift_jis"));
                    try
                    {
                        all_count = 0;

                        dataGridView_log.Rows.Clear();

                        while (reader.Peek() >= 0)
                        {
                            string[] cols = reader.ReadLine().Split(',');


                            if (cols[2] == "1") flag_string = "出席";
                            if (cols[2] == "3") flag_string = "遅刻";

                            if (all_count != 0)  dataGridView_log.Rows.Add(all_count, cols[0], cols[1], flag_string);
                            
                            all_count++;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    finally
                    {
                        all_count--;
                    }
                    //count_show.Text = "全" + all_count + "件";

                    reader.Close();
                }
                catch(Exception)
                {

                }
                


                //dataGridView_log.DefaultCellStyle.WrapMode = DataGridViewTriState.True;//折り返し
                dataGridView_log.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;//高さ調整
            }

            if (delayonoff == 0)
            {
                dateTimePicker_delaytime.Enabled = false;
                radioButton_OFF.Checked = true;
            }
            else
            {
                radioButton_ON.Checked = true;
                dateTimePicker_delaytime.Enabled = true;
                dateTimePicker_delaytime.Value = delay;
            }
            if(Insert_flag == 1)
            {
                radioButton_nirmal.Checked = true;
            }
            if(Insert_flag == 3)
            {
                radioButton_delay.Checked = true;
            }

        }

        private void Setting_Load(object sender, EventArgs e)
        {
            this.ControlBox = !this.ControlBox;

            botton_ok.Focus();
        }

        private void botton_cancel_Click(object sender, EventArgs e)
        {
            ok = 0;
            this.Close();
        }

        private void radioButton_OFF_Click_Click(object sender, EventArgs e)
        {
            dateTimePicker_delaytime.Enabled = false;
            delay_setting = 0;
        }

        private void radioButton_ON_Click_Click(object sender, EventArgs e)
        {
            dateTimePicker_delaytime.Enabled = true;
            radioButton_nirmal.Checked = true;
            TimeSpan ts1 = new TimeSpan(0, 0, 10, 0);
            DateTime dt1 = DateTime.Now + ts1;
            dateTimePicker_delaytime.Value = dt1;

            delay_time = dateTimePicker_delaytime.Value;
            delay_setting = 1;
        }

        private void botton_ok_Click(object sender, EventArgs e)
        {

            ok = 1;
            this.Close();
        }


        private void radioButton_delay_Click(object sender, EventArgs e)
        {
            delay_setting = 1;
            Insert_flag = 3;
            dateTimePicker_delaytime.Enabled = false;
            radioButton_OFF.Checked = true;
        }

        private void radioButton_nirmal_CheckedChanged(object sender, EventArgs e)
        {
            Insert_flag = 1;
            delay_setting = 0;
        }

        private void dateTimePicker_delaytime_ValueChanged(object sender, EventArgs e)
        {
            delay_time = dateTimePicker_delaytime.Value;
        }
    }
}
