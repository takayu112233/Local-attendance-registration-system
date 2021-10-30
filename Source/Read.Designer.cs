namespace NFC_OFFLINE_APP
{
    partial class Read
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
            this.components = new System.ComponentModel.Container();
            this.Data_Gakuseki_Show = new System.Windows.Forms.Label();
            this.label_nowtime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer_1Sec = new System.Windows.Forms.Timer(this.components);
            this.Info_Show = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.send_info = new System.Windows.Forms.Label();
            this.botton_setting_log = new System.Windows.Forms.Button();
            this.botton_read_end = new System.Windows.Forms.Button();
            this.botton_felica_connect = new System.Windows.Forms.Button();
            this.Data_Time_Show = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ScanTimer = new System.Windows.Forms.Timer(this.components);
            this.Debug_Count_Show = new System.Windows.Forms.Label();
            this.Ok_show_timer = new System.Windows.Forms.Timer(this.components);
            this.Read_Info_Show = new System.Windows.Forms.Label();
            this.Ok_info = new System.Windows.Forms.Label();
            this.label_code = new System.Windows.Forms.Label();
            this.label_show_code = new System.Windows.Forms.Label();
            this.label_room = new System.Windows.Forms.Label();
            this.label_show_room = new System.Windows.Forms.Label();
            this.label_delay_time_show = new System.Windows.Forms.Label();
            this.label_flaglog = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Data_Gakuseki_Show
            // 
            this.Data_Gakuseki_Show.BackColor = System.Drawing.Color.Transparent;
            this.Data_Gakuseki_Show.Font = new System.Drawing.Font("メイリオ", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Data_Gakuseki_Show.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Data_Gakuseki_Show.Location = new System.Drawing.Point(94, 420);
            this.Data_Gakuseki_Show.Name = "Data_Gakuseki_Show";
            this.Data_Gakuseki_Show.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Data_Gakuseki_Show.Size = new System.Drawing.Size(1162, 199);
            this.Data_Gakuseki_Show.TabIndex = 39;
            this.Data_Gakuseki_Show.Text = "学籍番号";
            this.Data_Gakuseki_Show.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Data_Gakuseki_Show.UseMnemonic = false;
            this.Data_Gakuseki_Show.Click += new System.EventHandler(this.Data_Gakuseki_Show_Click);
            // 
            // label_nowtime
            // 
            this.label_nowtime.AutoSize = true;
            this.label_nowtime.BackColor = System.Drawing.Color.White;
            this.label_nowtime.Font = new System.Drawing.Font("メイリオ", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_nowtime.Location = new System.Drawing.Point(305, 44);
            this.label_nowtime.Name = "label_nowtime";
            this.label_nowtime.Size = new System.Drawing.Size(223, 120);
            this.label_nowtime.TabIndex = 30;
            this.label_nowtime.Text = "time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(107, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 52);
            this.label1.TabIndex = 29;
            this.label1.Text = "現在時刻";
            // 
            // Timer_1Sec
            // 
            this.Timer_1Sec.Enabled = true;
            this.Timer_1Sec.Interval = 1000;
            this.Timer_1Sec.Tick += new System.EventHandler(this.Timer_1Sec_Tick);
            // 
            // Info_Show
            // 
            this.Info_Show.AutoSize = true;
            this.Info_Show.BackColor = System.Drawing.Color.White;
            this.Info_Show.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Info_Show.Location = new System.Drawing.Point(903, 273);
            this.Info_Show.Name = "Info_Show";
            this.Info_Show.Size = new System.Drawing.Size(308, 48);
            this.Info_Show.TabIndex = 33;
            this.Info_Show.Text = "タッチしてください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(111, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 52);
            this.label2.TabIndex = 40;
            this.label2.Text = "登録内容";
            // 
            // send_info
            // 
            this.send_info.AutoSize = true;
            this.send_info.BackColor = System.Drawing.Color.White;
            this.send_info.Font = new System.Drawing.Font("メイリオ", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.send_info.Location = new System.Drawing.Point(309, 174);
            this.send_info.Name = "send_info";
            this.send_info.Size = new System.Drawing.Size(168, 96);
            this.send_info.TabIndex = 41;
            this.send_info.Text = "出席";
            // 
            // botton_setting_log
            // 
            this.botton_setting_log.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.botton_setting_log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botton_setting_log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botton_setting_log.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.botton_setting_log.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_setting_log.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_setting_log.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.botton_setting_log.ForeColor = System.Drawing.Color.Black;
            this.botton_setting_log.Location = new System.Drawing.Point(179, 622);
            this.botton_setting_log.Name = "botton_setting_log";
            this.botton_setting_log.Size = new System.Drawing.Size(285, 51);
            this.botton_setting_log.TabIndex = 0;
            this.botton_setting_log.Text = "設定・履歴";
            this.botton_setting_log.UseVisualStyleBackColor = false;
            this.botton_setting_log.Click += new System.EventHandler(this.botton_setting_log_Click);
            // 
            // botton_read_end
            // 
            this.botton_read_end.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.botton_read_end.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botton_read_end.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botton_read_end.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.botton_read_end.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_read_end.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_read_end.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.botton_read_end.ForeColor = System.Drawing.Color.Black;
            this.botton_read_end.Location = new System.Drawing.Point(880, 622);
            this.botton_read_end.Name = "botton_read_end";
            this.botton_read_end.Size = new System.Drawing.Size(285, 51);
            this.botton_read_end.TabIndex = 2;
            this.botton_read_end.Text = "終了・書き出し";
            this.botton_read_end.UseVisualStyleBackColor = false;
            this.botton_read_end.Click += new System.EventHandler(this.botton_read_end_Click);
            // 
            // botton_felica_connect
            // 
            this.botton_felica_connect.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.botton_felica_connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botton_felica_connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botton_felica_connect.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.botton_felica_connect.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_felica_connect.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_felica_connect.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.botton_felica_connect.ForeColor = System.Drawing.Color.Black;
            this.botton_felica_connect.Location = new System.Drawing.Point(529, 622);
            this.botton_felica_connect.Name = "botton_felica_connect";
            this.botton_felica_connect.Size = new System.Drawing.Size(285, 51);
            this.botton_felica_connect.TabIndex = 1;
            this.botton_felica_connect.Text = "FeliCa再接続";
            this.botton_felica_connect.UseVisualStyleBackColor = false;
            this.botton_felica_connect.Click += new System.EventHandler(this.botton_felica_connect_Click);
            // 
            // Data_Time_Show
            // 
            this.Data_Time_Show.AutoSize = true;
            this.Data_Time_Show.BackColor = System.Drawing.Color.White;
            this.Data_Time_Show.Font = new System.Drawing.Font("メイリオ", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Data_Time_Show.Location = new System.Drawing.Point(502, 347);
            this.Data_Time_Show.Name = "Data_Time_Show";
            this.Data_Time_Show.Size = new System.Drawing.Size(168, 96);
            this.Data_Time_Show.TabIndex = 45;
            this.Data_Time_Show.Text = "時間";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(106, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 52);
            this.label6.TabIndex = 46;
            this.label6.Text = "最終登録";
            // 
            // ScanTimer
            // 
            this.ScanTimer.Enabled = true;
            this.ScanTimer.Tick += new System.EventHandler(this.ScanTimer_Tick);
            // 
            // Debug_Count_Show
            // 
            this.Debug_Count_Show.AutoSize = true;
            this.Debug_Count_Show.ForeColor = System.Drawing.Color.Red;
            this.Debug_Count_Show.Location = new System.Drawing.Point(1269, 708);
            this.Debug_Count_Show.Name = "Debug_Count_Show";
            this.Debug_Count_Show.Size = new System.Drawing.Size(11, 12);
            this.Debug_Count_Show.TabIndex = 47;
            this.Debug_Count_Show.Text = "0";
            // 
            // Ok_show_timer
            // 
            this.Ok_show_timer.Interval = 2000;
            this.Ok_show_timer.Tick += new System.EventHandler(this.Ok_show_timer_Tick);
            // 
            // Read_Info_Show
            // 
            this.Read_Info_Show.AutoSize = true;
            this.Read_Info_Show.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Read_Info_Show.ForeColor = System.Drawing.Color.Green;
            this.Read_Info_Show.Location = new System.Drawing.Point(1151, 695);
            this.Read_Info_Show.Name = "Read_Info_Show";
            this.Read_Info_Show.Size = new System.Drawing.Size(39, 27);
            this.Read_Info_Show.TabIndex = 48;
            this.Read_Info_Show.Text = "■";
            // 
            // Ok_info
            // 
            this.Ok_info.AutoSize = true;
            this.Ok_info.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Ok_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Ok_info.Location = new System.Drawing.Point(235, 603);
            this.Ok_info.Name = "Ok_info";
            this.Ok_info.Size = new System.Drawing.Size(888, 16);
            this.Ok_info.TabIndex = 49;
            this.Ok_info.Text = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
            // 
            // label_code
            // 
            this.label_code.AutoSize = true;
            this.label_code.BackColor = System.Drawing.Color.White;
            this.label_code.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_code.Location = new System.Drawing.Point(680, 0);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(119, 31);
            this.label_code.TabIndex = 50;
            this.label_code.Text = "講義コード";
            // 
            // label_show_code
            // 
            this.label_show_code.AutoSize = true;
            this.label_show_code.BackColor = System.Drawing.Color.White;
            this.label_show_code.Font = new System.Drawing.Font("メイリオ", 16F);
            this.label_show_code.Location = new System.Drawing.Point(805, -2);
            this.label_show_code.Name = "label_show_code";
            this.label_show_code.Size = new System.Drawing.Size(65, 33);
            this.label_show_code.TabIndex = 51;
            this.label_show_code.Text = "code";
            // 
            // label_room
            // 
            this.label_room.AutoSize = true;
            this.label_room.BackColor = System.Drawing.Color.White;
            this.label_room.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_room.Location = new System.Drawing.Point(1004, 0);
            this.label_room.Name = "label_room";
            this.label_room.Size = new System.Drawing.Size(56, 31);
            this.label_room.TabIndex = 52;
            this.label_room.Text = "教室";
            // 
            // label_show_room
            // 
            this.label_show_room.AutoSize = true;
            this.label_show_room.BackColor = System.Drawing.Color.White;
            this.label_show_room.Font = new System.Drawing.Font("メイリオ", 16F);
            this.label_show_room.Location = new System.Drawing.Point(1066, -2);
            this.label_show_room.Name = "label_show_room";
            this.label_show_room.Size = new System.Drawing.Size(71, 33);
            this.label_show_room.TabIndex = 53;
            this.label_show_room.Text = "room";
            // 
            // label_delay_time_show
            // 
            this.label_delay_time_show.AutoSize = true;
            this.label_delay_time_show.BackColor = System.Drawing.Color.White;
            this.label_delay_time_show.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_delay_time_show.Location = new System.Drawing.Point(318, 270);
            this.label_delay_time_show.Name = "label_delay_time_show";
            this.label_delay_time_show.Size = new System.Drawing.Size(164, 41);
            this.label_delay_time_show.TabIndex = 54;
            this.label_delay_time_show.Text = "delay_time";
            // 
            // label_flaglog
            // 
            this.label_flaglog.AutoSize = true;
            this.label_flaglog.BackColor = System.Drawing.Color.White;
            this.label_flaglog.Font = new System.Drawing.Font("メイリオ", 48F);
            this.label_flaglog.Location = new System.Drawing.Point(813, 347);
            this.label_flaglog.Name = "label_flaglog";
            this.label_flaglog.Size = new System.Drawing.Size(247, 96);
            this.label_flaglog.TabIndex = 55;
            this.label_flaglog.Text = "flaglog";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::NFC_OFFLINE_APP.Properties.Resources.touch;
            this.pictureBox2.Location = new System.Drawing.Point(871, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(385, 226);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::NFC_OFFLINE_APP.Properties.Resources.gui1;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1357, 732);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label_flaglog);
            this.Controls.Add(this.label_delay_time_show);
            this.Controls.Add(this.label_show_room);
            this.Controls.Add(this.label_room);
            this.Controls.Add(this.label_show_code);
            this.Controls.Add(this.label_code);
            this.Controls.Add(this.Ok_info);
            this.Controls.Add(this.Read_Info_Show);
            this.Controls.Add(this.Debug_Count_Show);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Data_Time_Show);
            this.Controls.Add(this.botton_felica_connect);
            this.Controls.Add(this.botton_read_end);
            this.Controls.Add(this.botton_setting_log);
            this.Controls.Add(this.send_info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Data_Gakuseki_Show);
            this.Controls.Add(this.Info_Show);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_nowtime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Read";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出席登録";
            this.Load += new System.EventHandler(this.Read_Load);
            this.Resize += new System.EventHandler(this.Read_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_nowtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer_1Sec;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Info_Show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label send_info;
        private System.Windows.Forms.Button botton_setting_log;
        private System.Windows.Forms.Button botton_read_end;
        private System.Windows.Forms.Button botton_felica_connect;
        private System.Windows.Forms.Label Data_Time_Show;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer ScanTimer;
        private System.Windows.Forms.Label Debug_Count_Show;
        private System.Windows.Forms.Timer Ok_show_timer;
        private System.Windows.Forms.Label Read_Info_Show;
        private System.Windows.Forms.Label Ok_info;
        private System.Windows.Forms.Label Data_Gakuseki_Show;
        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.Label label_show_code;
        private System.Windows.Forms.Label label_room;
        private System.Windows.Forms.Label label_show_room;
        private System.Windows.Forms.Label label_delay_time_show;
        private System.Windows.Forms.Label label_flaglog;
    }
}