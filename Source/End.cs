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
    public partial class End : Form
    {
        public int endflag;
        public End()
        {
            InitializeComponent();
            this.ControlBox = !this.ControlBox;
        }
        public End(String msg)
        {
            InitializeComponent();
            this.ControlBox = !this.ControlBox;
            label_err.Text = msg;
        }

        private void End_Load(object sender, EventArgs e)
        {
            button_Cancel.Focus();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            endflag = 0;
            this.Close();
        }

        private void button_end_Click(object sender, EventArgs e)
        {
            endflag = 1;
            this.Close();
        }
    }
}
