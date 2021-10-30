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
    public partial class ExportSetting : Form
    {
        string address;
        int all_count,getdata;
        string flag_string;

        public int end_flag = 0;
        public ExportSetting(String address,int getdata)
        {
            InitializeComponent();
            this.ControlBox = !this.ControlBox;
            this.address = address;
            this.getdata = getdata;
        }

        private void botton_back_Click(object sender, EventArgs e)
        {
            end_flag = 0;
            this.Close();
        }

        private void botton_end_Click(object sender, EventArgs e)
        {

            End e1 = new End();
            e1.ShowInTaskbar = false;
            e1.StartPosition = FormStartPosition.CenterScreen;
            e1.ShowDialog();

            if (e1.endflag == 1)
            {
                end_flag = 1;
                this.Close();
            }

        }

        private void botton_export_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "フォルダを指定してください。";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.SelectedPath = @"F:\";
            fbd.ShowNewFolderButton = true;

            if (fbd.ShowDialog(this) == DialogResult.OK)
            {

                string folder = fbd.SelectedPath;


                出力 ex2 = new 出力(address,folder);
                ex2.ShowInTaskbar = false;
                ex2.StartPosition = FormStartPosition.CenterScreen;
                ex2.ShowDialog();

                if (ex2.end_export == 1)
                {
                    label_err.Text = "書出し済";
                    label_err.ForeColor= Color.Black;
                }
            }
        }

        private void Export_Load(object sender, EventArgs e)
        {
            botton_export.Focus();

            if (getdata == 0)
            {
                dataGridView_log.Enabled = false;
                botton_export.Visible = false;
                label_info_show.Text = "データがありません";
                label_err.Visible = false;
            }
            else
            {
                dataGridView_log.Enabled = true;
                botton_export.Visible = true;
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
                    StreamReader reader = new StreamReader(@address, Encoding.GetEncoding("shift_jis"));
                    try
                    {
                        all_count = 0;

                        dataGridView_log.Rows.Clear();

                        while (reader.Peek() >= 0)
                        {
                            string[] cols = reader.ReadLine().Split(',');


                            if (cols[2] == "1") flag_string = "出席";
                            if (cols[2] == "3") flag_string = "遅刻";

                            if (all_count != 0) dataGridView_log.Rows.Add(all_count, cols[0], cols[1], flag_string);

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
                    label_info_show.Text = "全" + all_count + "件";

                    reader.Close();
                }
                catch (Exception)
                {
                    label_info_show.Text = "エラーが発生しました";
                }
                //dataGridView_log.DefaultCellStyle.WrapMode = DataGridViewTriState.True;//折り返し
                dataGridView_log.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;//高さ調整
            }
        }
    }
}
