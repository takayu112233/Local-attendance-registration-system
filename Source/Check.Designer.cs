namespace NFC_OFFLINE_APP
{
    partial class Check
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer_1Sec = new System.Windows.Forms.Timer(this.components);
            this.botton_start = new System.Windows.Forms.Button();
            this.botton_ng = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Check_delay = new System.Windows.Forms.Label();
            this.label_Check_DelayOnOff = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label_Check_Code = new System.Windows.Forms.Label();
            this.label_Check_RoomNo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Check_FileName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_nowtime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_1Sec
            // 
            this.Timer_1Sec.Enabled = true;
            this.Timer_1Sec.Interval = 1000;
            this.Timer_1Sec.Tick += new System.EventHandler(this.Timer_1Sec_Tick);
            // 
            // botton_start
            // 
            this.botton_start.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.botton_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botton_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botton_start.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.botton_start.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_start.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_start.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.botton_start.ForeColor = System.Drawing.Color.Black;
            this.botton_start.Location = new System.Drawing.Point(751, 622);
            this.botton_start.Name = "botton_start";
            this.botton_start.Size = new System.Drawing.Size(285, 51);
            this.botton_start.TabIndex = 29;
            this.botton_start.Text = "読取";
            this.botton_start.UseVisualStyleBackColor = false;
            this.botton_start.Click += new System.EventHandler(this.botton_start_Click);
            // 
            // botton_ng
            // 
            this.botton_ng.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.botton_ng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botton_ng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botton_ng.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.botton_ng.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_ng.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botton_ng.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.botton_ng.ForeColor = System.Drawing.Color.Black;
            this.botton_ng.Location = new System.Drawing.Point(339, 622);
            this.botton_ng.Name = "botton_ng";
            this.botton_ng.Size = new System.Drawing.Size(285, 51);
            this.botton_ng.TabIndex = 28;
            this.botton_ng.Text = "修正";
            this.botton_ng.UseVisualStyleBackColor = false;
            this.botton_ng.Click += new System.EventHandler(this.botton_ng_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Check_delay);
            this.groupBox1.Controls.Add(this.label_Check_DelayOnOff);
            this.groupBox1.Controls.Add(this.label_time);
            this.groupBox1.Font = new System.Drawing.Font("メイリオ", 24F);
            this.groupBox1.Location = new System.Drawing.Point(400, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 199);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自動遅刻切替設定";
            // 
            // label_Check_delay
            // 
            this.label_Check_delay.AutoSize = true;
            this.label_Check_delay.BackColor = System.Drawing.Color.White;
            this.label_Check_delay.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Check_delay.Location = new System.Drawing.Point(222, 122);
            this.label_Check_delay.Name = "label_Check_delay";
            this.label_Check_delay.Size = new System.Drawing.Size(60, 48);
            this.label_Check_delay.TabIndex = 42;
            this.label_Check_delay.Text = "10";
            // 
            // label_Check_DelayOnOff
            // 
            this.label_Check_DelayOnOff.AutoSize = true;
            this.label_Check_DelayOnOff.BackColor = System.Drawing.Color.White;
            this.label_Check_DelayOnOff.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Check_DelayOnOff.Location = new System.Drawing.Point(222, 51);
            this.label_Check_DelayOnOff.Name = "label_Check_DelayOnOff";
            this.label_Check_DelayOnOff.Size = new System.Drawing.Size(68, 48);
            this.label_Check_DelayOnOff.TabIndex = 40;
            this.label_Check_DelayOnOff.Text = "ON";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.BackColor = System.Drawing.Color.White;
            this.label_time.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_time.Location = new System.Drawing.Point(8, 124);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(84, 48);
            this.label_time.TabIndex = 38;
            this.label_time.Text = "時刻";
            // 
            // label_Check_Code
            // 
            this.label_Check_Code.AutoSize = true;
            this.label_Check_Code.BackColor = System.Drawing.Color.White;
            this.label_Check_Code.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Check_Code.Location = new System.Drawing.Point(622, 161);
            this.label_Check_Code.Name = "label_Check_Code";
            this.label_Check_Code.Size = new System.Drawing.Size(280, 48);
            this.label_Check_Code.TabIndex = 38;
            this.label_Check_Code.Text = "KICE019CE311A";
            // 
            // label_Check_RoomNo
            // 
            this.label_Check_RoomNo.AutoSize = true;
            this.label_Check_RoomNo.BackColor = System.Drawing.Color.White;
            this.label_Check_RoomNo.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Check_RoomNo.Location = new System.Drawing.Point(622, 236);
            this.label_Check_RoomNo.Name = "label_Check_RoomNo";
            this.label_Check_RoomNo.Size = new System.Drawing.Size(120, 48);
            this.label_Check_RoomNo.TabIndex = 39;
            this.label_Check_RoomNo.Text = "30601";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(434, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(532, 48);
            this.label7.TabIndex = 40;
            this.label7.Text = "上記の内容で読取を開始しますか？";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(408, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 48);
            this.label4.TabIndex = 41;
            this.label4.Text = "保存ファイル名";
            // 
            // label_Check_FileName
            // 
            this.label_Check_FileName.AutoSize = true;
            this.label_Check_FileName.BackColor = System.Drawing.Color.White;
            this.label_Check_FileName.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Check_FileName.Location = new System.Drawing.Point(662, 529);
            this.label_Check_FileName.Name = "label_Check_FileName";
            this.label_Check_FileName.Size = new System.Drawing.Size(28, 23);
            this.label_Check_FileName.TabIndex = 42;
            this.label_Check_FileName.Text = "\\\\";
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
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label_Check_FileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_Check_RoomNo);
            this.Controls.Add(this.label_Check_Code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botton_start);
            this.Controls.Add(this.botton_ng);
            this.Controls.Add(this.label_nowtime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Check";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出席登録";
            this.Load += new System.EventHandler(this.Check_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Timer_1Sec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botton_ng;
        private System.Windows.Forms.Button botton_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_Check_Code;
        private System.Windows.Forms.Label label_Check_delay;
        private System.Windows.Forms.Label label_Check_DelayOnOff;
        private System.Windows.Forms.Label label_Check_RoomNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Check_FileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nowtime;
    }
}