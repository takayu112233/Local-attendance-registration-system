using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFC_OFFLINE_APP
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]


        static void Main()
        {

            string set_room,set_code;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Start());

            Start s1 = new Start();
            s1.StartPosition = FormStartPosition.CenterScreen;
            s1.ShowDialog();

            set_room = s1.Set_room_textBox.Text;
            set_code = s1.Set_code_textBox.Text;

            if(s1.start == 1)
            {
                Read r1 = new Read(s1.data_file_name , s1.delay_setting , s1.delay_time , set_code ,set_room);
                r1.StartPosition = FormStartPosition.CenterScreen;
                r1.ShowDialog();
            }
        }
    }
}
