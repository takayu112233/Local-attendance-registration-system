namespace NFC_OFFLINE_APP
{
    partial class Check_felica
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
            this.botton_cancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_err = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_1Sec
            // 
            this.Timer_1Sec.Enabled = true;
            this.Timer_1Sec.Interval = 1000;
            this.Timer_1Sec.Tick += new System.EventHandler(this.Timer_1Sec_Tick);
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
            this.botton_cancel.Location = new System.Drawing.Point(339, 622);
            this.botton_cancel.Name = "botton_cancel";
            this.botton_cancel.Size = new System.Drawing.Size(684, 51);
            this.botton_cancel.TabIndex = 0;
            this.botton_cancel.Text = "キャンセル";
            this.botton_cancel.UseVisualStyleBackColor = false;
            this.botton_cancel.Click += new System.EventHandler(this.botton_cancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(482, 559);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(436, 48);
            this.label7.TabIndex = 40;
            this.label7.Text = "リーダーを接続してください";
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
            // label_err
            // 
            this.label_err.AutoSize = true;
            this.label_err.BackColor = System.Drawing.Color.White;
            this.label_err.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_err.Location = new System.Drawing.Point(119, 53);
            this.label_err.Name = "label_err";
            this.label_err.Size = new System.Drawing.Size(64, 48);
            this.label_err.TabIndex = 41;
            this.label_err.Text = "err";
            // 
            // Check_felica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label_err);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.botton_cancel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Check_felica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "出席登録";
            this.Load += new System.EventHandler(this.Check_felica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Timer_1Sec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botton_cancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_err;
    }
}