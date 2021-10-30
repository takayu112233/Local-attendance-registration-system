using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FelicaLib;

namespace NFC_OFFLINE_APP
{
    public partial class Check_felica : Form
    {
        public int Cancel;
        FelicaLib.Felica f;
        public Check_felica()
        {
            InitializeComponent();
            this.ControlBox = !this.ControlBox;
        }

        private void Check_felica_Load(object sender, EventArgs e)
        {
            botton_cancel.Focus();
            try
            {
                f = new FelicaLib.Felica();
                label_err.Text = "接続成功";
                Cancel = 0;
                this.Close();
            }
            catch (Exception e1)
            {
                label_err.Text = e1.Message;
            }
        }

        private void botton_cancel_Click(object sender, EventArgs e)
        {
            Cancel = 1;
            this.Close();
        }

        private void Timer_1Sec_Tick(object sender, EventArgs e)
        {
            try
            {
                f = new FelicaLib.Felica();
                label_err.Text = "接続成功";
                this.Close();
            }
            catch (Exception e1)
            {
                label_err.Text = e1.Message;
            }
        }
    }
}
