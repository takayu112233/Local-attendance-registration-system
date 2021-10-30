namespace NFC_OFFLINE_APP
{
    partial class Setting_Log
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.botton_cancel = new System.Windows.Forms.Button();
            this.botton_ok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_delay = new System.Windows.Forms.RadioButton();
            this.radioButton_nirmal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_delaytime = new System.Windows.Forms.DateTimePicker();
            this.radioButton_OFF = new System.Windows.Forms.RadioButton();
            this.radioButton_ON = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_log = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botton_cancel
            // 
            this.botton_cancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.botton_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botton_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botton_cancel.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.botton_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_cancel.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.botton_cancel.ForeColor = System.Drawing.Color.Black;
            this.botton_cancel.Location = new System.Drawing.Point(246, 622);
            this.botton_cancel.Name = "botton_cancel";
            this.botton_cancel.Size = new System.Drawing.Size(405, 51);
            this.botton_cancel.TabIndex = 2;
            this.botton_cancel.Text = "キャンセル";
            this.botton_cancel.UseVisualStyleBackColor = false;
            this.botton_cancel.Click += new System.EventHandler(this.botton_cancel_Click);
            // 
            // botton_ok
            // 
            this.botton_ok.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.botton_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botton_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botton_ok.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.botton_ok.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_ok.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_ok.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.botton_ok.ForeColor = System.Drawing.Color.Black;
            this.botton_ok.Location = new System.Drawing.Point(701, 622);
            this.botton_ok.Name = "botton_ok";
            this.botton_ok.Size = new System.Drawing.Size(405, 51);
            this.botton_ok.TabIndex = 3;
            this.botton_ok.Text = "確定";
            this.botton_ok.UseVisualStyleBackColor = false;
            this.botton_ok.Click += new System.EventHandler(this.botton_ok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radioButton_delay);
            this.groupBox1.Controls.Add(this.radioButton_nirmal);
            this.groupBox1.Font = new System.Drawing.Font("メイリオ", 24F);
            this.groupBox1.Location = new System.Drawing.Point(102, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登録設定";
            // 
            // radioButton_delay
            // 
            this.radioButton_delay.AutoSize = true;
            this.radioButton_delay.Checked = true;
            this.radioButton_delay.Font = new System.Drawing.Font("メイリオ", 50F, System.Drawing.FontStyle.Bold);
            this.radioButton_delay.Location = new System.Drawing.Point(339, 54);
            this.radioButton_delay.Name = "radioButton_delay";
            this.radioButton_delay.Size = new System.Drawing.Size(194, 104);
            this.radioButton_delay.TabIndex = 1;
            this.radioButton_delay.TabStop = true;
            this.radioButton_delay.Text = "遅刻";
            this.radioButton_delay.UseVisualStyleBackColor = true;
            this.radioButton_delay.Click += new System.EventHandler(this.radioButton_delay_Click);
            // 
            // radioButton_nirmal
            // 
            this.radioButton_nirmal.AutoSize = true;
            this.radioButton_nirmal.Font = new System.Drawing.Font("メイリオ", 50F, System.Drawing.FontStyle.Bold);
            this.radioButton_nirmal.Location = new System.Drawing.Point(134, 54);
            this.radioButton_nirmal.Name = "radioButton_nirmal";
            this.radioButton_nirmal.Size = new System.Drawing.Size(194, 104);
            this.radioButton_nirmal.TabIndex = 0;
            this.radioButton_nirmal.Text = "出席";
            this.radioButton_nirmal.UseVisualStyleBackColor = true;
            this.radioButton_nirmal.CheckedChanged += new System.EventHandler(this.radioButton_nirmal_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker_delaytime);
            this.groupBox2.Controls.Add(this.radioButton_OFF);
            this.groupBox2.Controls.Add(this.radioButton_ON);
            this.groupBox2.Font = new System.Drawing.Font("メイリオ", 24F);
            this.groupBox2.Location = new System.Drawing.Point(647, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自動遅刻切替設定";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(8, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 48);
            this.label4.TabIndex = 38;
            this.label4.Text = "時刻";
            // 
            // dateTimePicker_delaytime
            // 
            this.dateTimePicker_delaytime.CustomFormat = "HH 時 mm 分";
            this.dateTimePicker_delaytime.Enabled = false;
            this.dateTimePicker_delaytime.Font = new System.Drawing.Font("メイリオ", 24F);
            this.dateTimePicker_delaytime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_delaytime.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.dateTimePicker_delaytime.Location = new System.Drawing.Point(221, 119);
            this.dateTimePicker_delaytime.Name = "dateTimePicker_delaytime";
            this.dateTimePicker_delaytime.ShowUpDown = true;
            this.dateTimePicker_delaytime.Size = new System.Drawing.Size(212, 55);
            this.dateTimePicker_delaytime.TabIndex = 2;
            this.dateTimePicker_delaytime.Value = new System.DateTime(2020, 1, 17, 12, 0, 0, 0);
            this.dateTimePicker_delaytime.ValueChanged += new System.EventHandler(this.dateTimePicker_delaytime_ValueChanged);
            // 
            // radioButton_OFF
            // 
            this.radioButton_OFF.AutoSize = true;
            this.radioButton_OFF.Checked = true;
            this.radioButton_OFF.Font = new System.Drawing.Font("メイリオ", 24F);
            this.radioButton_OFF.Location = new System.Drawing.Point(370, 54);
            this.radioButton_OFF.Name = "radioButton_OFF";
            this.radioButton_OFF.Size = new System.Drawing.Size(98, 52);
            this.radioButton_OFF.TabIndex = 1;
            this.radioButton_OFF.TabStop = true;
            this.radioButton_OFF.Text = "OFF";
            this.radioButton_OFF.UseVisualStyleBackColor = true;
            this.radioButton_OFF.Click += new System.EventHandler(this.radioButton_OFF_Click_Click);
            // 
            // radioButton_ON
            // 
            this.radioButton_ON.AutoSize = true;
            this.radioButton_ON.Font = new System.Drawing.Font("メイリオ", 24F);
            this.radioButton_ON.Location = new System.Drawing.Point(230, 54);
            this.radioButton_ON.Name = "radioButton_ON";
            this.radioButton_ON.Size = new System.Drawing.Size(86, 52);
            this.radioButton_ON.TabIndex = 0;
            this.radioButton_ON.Text = "ON";
            this.radioButton_ON.UseVisualStyleBackColor = true;
            this.radioButton_ON.Click += new System.EventHandler(this.radioButton_ON_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(108, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 48);
            this.label1.TabIndex = 39;
            this.label1.Text = "登録履歴";
            // 
            // dataGridView_log
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataGridView_log.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_log.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_log.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_log.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_log.Location = new System.Drawing.Point(273, 275);
            this.dataGridView_log.Name = "dataGridView_log";
            this.dataGridView_log.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_log.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_log.RowTemplate.Height = 21;
            this.dataGridView_log.Size = new System.Drawing.Size(973, 320);
            this.dataGridView_log.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::NFC_OFFLINE_APP.Properties.Resources.gui1;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1357, 732);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Setting_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.dataGridView_log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botton_cancel);
            this.Controls.Add(this.botton_ok);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Setting_Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登録設定";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botton_cancel;
        private System.Windows.Forms.Button botton_ok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_delay;
        private System.Windows.Forms.RadioButton radioButton_nirmal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_OFF;
        private System.Windows.Forms.RadioButton radioButton_ON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_log;
        private System.Windows.Forms.DateTimePicker dateTimePicker_delaytime;
    }
}