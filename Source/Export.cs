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
    public partial class 出力 : Form
    {
        string in_add, out_add;
        public int end_export;
        public 出力(string in_add , string out_add)
        {
            InitializeComponent();
            this.ControlBox = !this.ControlBox;
            this.in_add=in_add;
            this.out_add = out_add;
        }

        private void button_go_Click(object sender, EventArgs e)
        {

            try
            {
                if(out_add.EndsWith("\\"))
                {
                }
                else
                {
                    out_add = out_add + "\\";
                }
                string outfile = out_add + in_add.Remove(0, 7);

                File.Copy(@in_add, @outfile, true);

                label_show_pass.Visible = true;
                label_show_pass.Text = outfile;

                label_info.Location = new Point(200, 72);
                label_info.Text = "書出しに成功しました";

                button_Cancel.Visible = false;
                button_Export.Visible = false;
                button_ok.Visible = true;
                end_export = 1;
            }
            catch (Exception)
            {
                label_info.Text = "書出しに失敗しました";
                end_export = 0;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();

            end_export = 0;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Export_Load(object sender, EventArgs e)
        {
            button_Export.Focus();
            label_info.Text = in_add.Remove(0, 7).Substring(0, in_add.Remove(0, 7).IndexOf(".")) + "\nの内容を\n" + out_add + "\n内に書き出しますか？";
        }
    }
}
