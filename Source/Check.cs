using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFC_OFFLINE_APP
{
    public partial class Check : Form
    {
        DateTime time;
        public int start;
        public Check(string code, string room, int delayonoff, DateTime delay ,string show_file_name)
        {        
            InitializeComponent();

            time = DateTime.Now;
            label_nowtime.Text = time.ToString("HH:mm:ss");

            this.ControlBox = !this.ControlBox;
            
            label_Check_Code.Text = code;
            label_Check_RoomNo.Text = room;
            label_Check_FileName.Text = show_file_name;

            label_Check_delay.Text = delay.ToString("HH時  mm分");

            if (label_Check_Code.Text == "") label_Check_Code.Text = "未登録";
            if (label_Check_RoomNo.Text == "") label_Check_RoomNo.Text = "未登録";

            if (delayonoff == 0)
            {
                label_Check_DelayOnOff.Text = "OFF";
                label_Check_delay.Visible = false;
                label_time.Visible = false;
            }
            else
            {
                label_Check_DelayOnOff.Text = "ON";
                label_Check_delay.Visible = true;
                label_time.Visible = true;
            }
        }

        private void Check_Load(object sender, EventArgs e)
        {
            botton_start.Focus();
        }


        private void Timer_1Sec_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            label_nowtime.Text = time.ToString("HH:mm:ss");
        }

        private void botton_start_Click(object sender, EventArgs e)
        {
            start = 1;
            Check_felica f1 = new Check_felica();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.ShowInTaskbar = false;
            f1.ShowDialog();
            if (f1.Cancel == 0) this.Close();
            if (f1.Cancel == 1) start = 0;

        }
        private void botton_ng_Click(object sender, EventArgs e)
        {
            start = 0;

            this.Close();
        }
    }
}
