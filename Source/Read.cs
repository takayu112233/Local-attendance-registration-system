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
    public partial class Read : Form
    {
        DateTime time,intime;
        FelicaLib.Felica f;

        public int getdata;//データを一軒でも取得した場合1にする


        string Last_Student_Number;
        string HEX_String;
        string Gakuseki_String = "";
        string write_address;
        int Insert_flag = 1;
        int Same_Card_SW1 = 1;//重複カード判定用
        int Same_Card_SW2 = 0;
        int Ng_sound = 0;
        int Error_control = 1;//読み取りエラー制御用

        int delay_setting = 0;
        DateTime delay_time;

        StreamWriter writer;
        Encoding enc = Encoding.GetEncoding("Shift_JIS");

        System.Media.SoundPlayer Ok_Sound = new System.Media.SoundPlayer("./Resources/Ok_Sound.wav");
        System.Media.SoundPlayer Ng_Sound = new System.Media.SoundPlayer("./Resources/Ng_Sound.wav");

        int Debug_Count = 0;

        public Read(String write_address ,int delay_setting, DateTime delay_time , string code , string room)
        {
            InitializeComponent();

            this.delay_setting = delay_setting;
            this.delay_time = delay_time;

            this.write_address = write_address;

            time = DateTime.Now;
            label_nowtime.Text = time.ToString("HH:mm:ss");

            Ok_info.Visible = false;
            label_flaglog.Text = "";

            label_show_room.Text = room;
            label_show_code.Text = code;

            if (label_show_code.Text == "")
            {
                label_show_code.Visible = false;
                label_code.Visible = false;
            }
            if (label_show_room.Text == "")
            {
                label_show_room.Visible = false;
                label_room.Visible = false;
            }

            try
            {
                f = new FelicaLib.Felica();
                
            }
            catch (Exception)
            {

            }
            
            if (System.IO.File.Exists(@write_address))
            {
                getdata = 1;
            }

            if(delay_setting == 1){
                label_delay_time_show.Text = "(" + delay_time.ToString("HH時mm分") + "～ 遅刻)";
            }
            else
            {
                label_delay_time_show.Visible = false;
            }
        }

        private void Read_Load(object sender, EventArgs e)
        {
            this.ControlBox = !this.ControlBox;

            botton_setting_log.Focus();

            Data_Time_Show.Text = "";
            Data_Gakuseki_Show.Text = "";
        }

        private void Read_Resize(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Size = new Size(this.Size.Width, this.Size.Height);
        }

        private void Timer_1Sec_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            label_nowtime.Text = time.ToString("HH:mm:ss");
            if (delay_setting == 1)
            {
                
                if(time.ToString("HHmm") == delay_time.ToString("HHmm"))
                {
                    label_delay_time_show.Visible = false;
                    Insert_flag = 3;
                    send_info.Text = "遅刻";
                }
                
            }
        }

        private void ScanTimer_Tick(object sender, EventArgs e)
        {
            Debug_Count++;
            Debug_Count_Show.Text = Debug_Count.ToString();

            Gakuseki_Read();
        }


        public void Gakuseki_Read()
        {
            f = new FelicaLib.Felica(); //毎回生成　

            try
            {
                Gakuseki_String = "";

                f.Polling(0xfe00);

                if (f.felicap == IntPtr.Zero)
                {
                    //Info_Show.Text = "カードがありません";
                    Same_Card_SW2 = 1;
                    Error_control = 0;
                }
                else
                {

                    byte[] data = f.ReadWithoutEncryption(0x1a8b, 0);//サービスコード

                    if (data == null)
                    {
                        //Info_Show.Text = "データがありません";
                        //Ok_show_timer.Enabled = false;
                        //Ok_info.Visible = false;
                        //↑三つを外すとスイカなどはデータがありませんと出表示する
                        // Last_Student_Number = "";
                        //↑コメントを外すと同じカードでデータを登録できるようになる
                        //Ok_show_timer.Enabled = true;

                        //↑5つ運用時コメントアウト
                    }
                    else
                    {

                        Gakuseki_String = System.Text.Encoding.ASCII.GetString(data);

                        HEX_String = BitConverter.ToString(data).Replace("-", string.Empty);

                        if (HEX_String.Substring(1, 5) == "00000")
                        {
                            if (Error_control == 0)
                            {
                                Info_Show.Text = "読込失敗";
                                Ng_Sound.Play();
                            }
                        }
                        else
                        {
                            

                            Gakuseki_String = System.Text.Encoding.ASCII.GetString(data);
                            Gakuseki_String = Gakuseki_String.Remove(0, 2);
                            Gakuseki_String = Gakuseki_String.Remove(9);
                            if (Gakuseki_String.Substring(0, 1) != "G" && Gakuseki_String.Substring(0, 1) != "K") Gakuseki_String = Gakuseki_String.Remove(5);
                            
                                                        
                            if (Last_Student_Number == Gakuseki_String)
                            {
                                Read_Info_Show.Text = " ";
                                if (Same_Card_SW2 == 1) Same_Card_SW1 = 1;
                            }
                            else
                            {
                                Ok_Sound.Play();

                                intime = DateTime.Now;

                                Same_Card_SW2 = 0;
                                Same_Card_SW1 = 0;

                                Insert(Gakuseki_String,intime,Insert_flag);
                            }

                            if (Same_Card_SW1 == 1 && Ok_show_timer.Enabled == false)
                            {
                                if(Ng_sound == 0)Ng_Sound.Play();
                                Info_Show.Text = "同じカードです";
                                Ok_show_timer.Enabled = false;
                                Ok_show_timer.Enabled = true;
                                Ok_info.Visible = false;
                                Ng_sound = 1;


                                //↑同じカードの連続表示
                            }
                            else
                            {
                                if(Same_Card_SW1 == 0)
                                {
                                    Info_Show.Text = "読込完了";
                                    Ok_info.Visible = true;
                                    Ok_show_timer.Enabled = false;
                                    Ok_show_timer.Enabled = true;
                                }
                            }

                            Error_control = 1;

                        }

                    }

                }

            }
            catch (Exception)
            {
                Info_Show.Text = "読込失敗";
            }


        }
        
        private void botton_read_end_Click(object sender, EventArgs e)
        {

            ScanTimer.Enabled = false;
            End e1 = new End("読取を終了しますか？");
            e1.ShowInTaskbar = false;
            e1.StartPosition = FormStartPosition.CenterScreen;
            e1.ShowDialog();

            if (e1.endflag == 0) ScanTimer.Enabled = true;

            if (e1.endflag == 1)
            {
                ExportSetting ex1 = new ExportSetting(write_address , getdata);
                ex1.ShowInTaskbar = false;
                ex1.StartPosition = FormStartPosition.CenterScreen;
                ex1.ShowDialog();

                if (ex1.end_flag == 1) this.Close();
                if (ex1.end_flag == 0) ScanTimer.Enabled = true;
            }
        }

        private void Ok_show_timer_Tick(object sender, EventArgs e)
        {
            Ok_show_timer.Enabled = false;
            Ok_info.Visible = false;
            Ng_sound = 0;
            Info_Show.Text = "";
        }

        private void botton_felica_connect_Click(object sender, EventArgs e)
        {
            ScanTimer.Enabled = false;
            f.Close();

            Check_felica f1 = new Check_felica();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.ShowInTaskbar = false;
            f1.ShowDialog();
            if (f1.Cancel == 0)
            {
                Info_Show.Text = "接続しました";

                ScanTimer.Enabled = true;
            }
            if (f1.Cancel == 1)
            {
                Info_Show.Text = "再接続してください";
            }
        }

        private void Data_Gakuseki_Show_Click(object sender, EventArgs e)
        {

        }

        private void botton_setting_log_Click(object sender, EventArgs e)
        {
            ScanTimer.Enabled = false;
            Setting_Log s1 = new Setting_Log(delay_setting,delay_time,Insert_flag,getdata,write_address);
            s1.ShowInTaskbar = false;
            s1.StartPosition = FormStartPosition.CenterScreen;
            s1.ShowDialog();
            ScanTimer.Enabled = true;
            if (s1.ok == 1)
            {
                Insert_flag = s1.Insert_flag;
                
                if (Insert_flag == 1) send_info.Text="出席";
                if (Insert_flag == 3) send_info.Text="遅刻";

                if (s1.delay_setting == 1)
                {
                    delay_time = s1.delay_time;
                    delay_setting = 1;
                    label_delay_time_show.Visible = true;
                    label_delay_time_show.Text = "(" + delay_time.ToString("HH時mm分") + "～ 遅刻)";
                }
                else
                {
                    label_delay_time_show.Visible = false;
                    delay_setting = 0;
                }
            }
        }


        private void Insert(string gakuseki , DateTime time , int flag)
        {
            try
            {
                if (System.IO.File.Exists(@write_address))
                {
                    writer = new StreamWriter(@write_address, true, enc);

                    writer.WriteLine(time.ToString("yy/MM/dd HH:mm:ss") + "," + gakuseki + "," + flag);


                    Data_Time_Show.Text = intime.ToString("HH:mm:ss");
                    Last_Student_Number = gakuseki;
                    Data_Gakuseki_Show.Text = gakuseki;
                    

                    if (flag == 1) label_flaglog.Text = "出席";
                    if (flag == 3) label_flaglog.Text = "遅刻";

                    getdata = 1;
                }
                else
                {
                    writer = new StreamWriter(@write_address, false, enc);

                    writer.WriteLine("日時,学籍番号,出席状況");
                    writer.WriteLine(time.ToString("yy/MM/dd HH:mm:ss") + "," + gakuseki + "," + flag);


                    Data_Time_Show.Text = intime.ToString("HH:mm:ss");
                    Last_Student_Number = gakuseki;
                    Data_Gakuseki_Show.Text = gakuseki;

                    

                    if (flag == 1) label_flaglog.Text = "出席";
                    if (flag == 3) label_flaglog.Text = "遅刻";

                    getdata = 1;
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                writer.Close();
            }
        }
    }
}
