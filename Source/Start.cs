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
    public partial class Start : Form
    {
        DateTime time;

        StreamWriter writer;
        Encoding enc = Encoding.GetEncoding("Shift_JIS");

        public string id, room;
        public int delay_setting = 0;
        public DateTime delay_time;
        public int start;
        public string test_file_name;
        public string show_file_name;
        public string data_file_name;

        public Start()
        {
            InitializeComponent();
            //this.ControlBox = !this.ControlBox;
            label_info.Text = "";
        }

        private void Timer_1Sec_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            label_nowtime.Text = time.ToString("HH:mm:ss");
        }

        private void Start_Load(object sender, EventArgs e)
        {
            time = DateTime.Now;
            label_nowtime.Text = time.ToString("HH:mm:ss");

            botton_send.Focus();
        }

        private void radioButton_OFF_Click(object sender, EventArgs e)
        {
            dateTimePicker_delaytime.Enabled = false;

            delay_setting = 0;
        }

        private void botton_start_Click(object sender, EventArgs e)
        {

            test_file_name = ".\\Nametest\\" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_" + Set_code_textBox.Text + "_" + Set_room_textBox.Text + ".csv";

            show_file_name = "開始時間(HHMMSS)" + "_" + Set_code_textBox.Text + "_" + Set_room_textBox.Text + ".csv";

            data_file_name = ".\\Data\\" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_" + Set_code_textBox.Text + "_" + Set_room_textBox.Text + ".csv";

            Check c1 = new Check(Set_code_textBox.Text, Set_room_textBox.Text, delay_setting ,delay_time ,show_file_name);
            try
            {
                System.Diagnostics.Debug.WriteLine(test_file_name);

                writer = new StreamWriter(@test_file_name, true, enc);
                writer.WriteLine("テスト成功");

                c1.StartPosition = FormStartPosition.CenterScreen;
                c1.ShowInTaskbar = false;
                c1.ShowDialog();
                start = c1.start;
                if (c1.start == 1) this.Close();
            }
            catch (Exception err1)
            {
                label_info.Text = "ファイル名を確認してください";
            }
            finally
            {
                try{
                    File.Delete(@test_file_name);
                    writer.Close();
                }
                catch (Exception)
                {

                }
            }
    }

        private void dateTimePicker_delaytime_ValueChanged(object sender, EventArgs e)
        {
            delay_time = dateTimePicker_delaytime.Value;
        }

        private void radioButton_ON_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void botton_exit_Click(object sender, EventArgs e)
        {
            End e1 = new End();
            e1.ShowInTaskbar = false;
            e1.StartPosition = FormStartPosition.CenterScreen;
            e1.ShowDialog();

            if (e1.endflag == 1) this.Close();
        }

        private void radioButton_ON_Click(object sender, EventArgs e)
        {
            dateTimePicker_delaytime.Enabled = true;
            TimeSpan ts1 = new TimeSpan(0, 0, 10, 0);
            DateTime dt1 = DateTime.Now + ts1;
            dateTimePicker_delaytime.Value = dt1;

            delay_time = dateTimePicker_delaytime.Value;
            delay_setting = 1;
        }
    }
}
