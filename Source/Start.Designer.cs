namespace NFC_OFFLINE_APP
{
    partial class Start
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label_nowtime = new System.Windows.Forms.Label();
            this.Timer_1Sec = new System.Windows.Forms.Timer(this.components);
            this.botton_send = new System.Windows.Forms.Button();
            this.botton_exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Set_code_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Set_room_textBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker_delaytime = new System.Windows.Forms.DateTimePicker();
            this.radioButton_ON = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_OFF = new System.Windows.Forms.RadioButton();
            this.label_info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(107, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 52);
            this.label1.TabIndex = 25;
            this.label1.Text = "現在時刻";
            // 
            // label_nowtime
            // 
            this.label_nowtime.AutoSize = true;
            this.label_nowtime.BackColor = System.Drawing.Color.White;
            this.label_nowtime.Font = new System.Drawing.Font("メイリオ", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_nowtime.Location = new System.Drawing.Point(276, 44);
            this.label_nowtime.Name = "label_nowtime";
            this.label_nowtime.Size = new System.Drawing.Size(178, 96);
            this.label_nowtime.TabIndex = 26;
            this.label_nowtime.Text = "time";
            // 
            // Timer_1Sec
            // 
            this.Timer_1Sec.Enabled = true;
            this.Timer_1Sec.Interval = 1000;
            this.Timer_1Sec.Tick += new System.EventHandler(this.Timer_1Sec_Tick);
            // 
            // botton_send
            // 
            this.botton_send.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.botton_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botton_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botton_send.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.botton_send.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_send.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_send.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.botton_send.ForeColor = System.Drawing.Color.Black;
            this.botton_send.Location = new System.Drawing.Point(751, 622);
            this.botton_send.Name = "botton_send";
            this.botton_send.Size = new System.Drawing.Size(285, 51);
            this.botton_send.TabIndex = 4;
            this.botton_send.Text = "登録";
            this.botton_send.UseVisualStyleBackColor = false;
            this.botton_send.Click += new System.EventHandler(this.botton_start_Click);
            // 
            // botton_exit
            // 
            this.botton_exit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.botton_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botton_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botton_exit.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.botton_exit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_exit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_exit.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.botton_exit.ForeColor = System.Drawing.Color.Black;
            this.botton_exit.Location = new System.Drawing.Point(339, 622);
            this.botton_exit.Name = "botton_exit";
            this.botton_exit.Size = new System.Drawing.Size(285, 51);
            this.botton_exit.TabIndex = 3;
            this.botton_exit.Text = "終了";
            this.botton_exit.UseVisualStyleBackColor = false;
            this.botton_exit.Click += new System.EventHandler(this.botton_exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(408, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 48);
            this.label2.TabIndex = 30;
            this.label2.Text = "講義コード";
            // 
            // Set_code_textBox
            // 
            this.Set_code_textBox.Font = new System.Drawing.Font("メイリオ", 24F);
            this.Set_code_textBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Set_code_textBox.Location = new System.Drawing.Point(621, 154);
            this.Set_code_textBox.Name = "Set_code_textBox";
            this.Set_code_textBox.Size = new System.Drawing.Size(378, 55);
            this.Set_code_textBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(408, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 48);
            this.label3.TabIndex = 32;
            this.label3.Text = "教室";
            // 
            // Set_room_textBox
            // 
            this.Set_room_textBox.Font = new System.Drawing.Font("メイリオ", 24F);
            this.Set_room_textBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Set_room_textBox.Location = new System.Drawing.Point(621, 229);
            this.Set_room_textBox.Name = "Set_room_textBox";
            this.Set_room_textBox.Size = new System.Drawing.Size(378, 55);
            this.Set_room_textBox.TabIndex = 1;
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
            this.radioButton_ON.Click += new System.EventHandler(this.radioButton_ON_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker_delaytime);
            this.groupBox1.Controls.Add(this.radioButton_OFF);
            this.groupBox1.Controls.Add(this.radioButton_ON);
            this.groupBox1.Font = new System.Drawing.Font("メイリオ", 24F);
            this.groupBox1.Location = new System.Drawing.Point(400, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 199);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自動遅刻切替設定";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(345, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 36);
            this.label5.TabIndex = 42;
            this.label5.Text = "読取中に変更できます";
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
            this.radioButton_OFF.Click += new System.EventHandler(this.radioButton_OFF_Click);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.BackColor = System.Drawing.Color.White;
            this.label_info.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_info.Location = new System.Drawing.Point(408, 549);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(78, 48);
            this.label_info.TabIndex = 41;
            this.label_info.Text = "info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::NFC_OFFLINE_APP.Properties.Resources.gui1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1357, 732);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.Set_room_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Set_code_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botton_send);
            this.Controls.Add(this.botton_exit);
            this.Controls.Add(this.label_nowtime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出席登録";
            this.Load += new System.EventHandler(this.Start_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nowtime;
        private System.Windows.Forms.Timer Timer_1Sec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botton_exit;
        private System.Windows.Forms.Button botton_send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_delaytime;
        private System.Windows.Forms.RadioButton radioButton_ON;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_OFF;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Set_code_textBox;
        public System.Windows.Forms.TextBox Set_room_textBox;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label5;
    }
}

