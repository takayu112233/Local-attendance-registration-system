namespace NFC_OFFLINE_APP
{
    partial class 出力
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
            this.button_Export = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_info = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.label_show_pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Export
            // 
            this.button_Export.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Export.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.button_Export.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Export.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Export.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Export.ForeColor = System.Drawing.Color.Black;
            this.button_Export.Location = new System.Drawing.Point(350, 364);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(252, 51);
            this.button_Export.TabIndex = 1;
            this.button_Export.Text = "CSV出力";
            this.button_Export.UseVisualStyleBackColor = false;
            this.button_Export.Click += new System.EventHandler(this.button_go_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.button_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Cancel.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Cancel.ForeColor = System.Drawing.Color.Black;
            this.button_Cancel.Location = new System.Drawing.Point(49, 364);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(252, 51);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "キャンセル";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.BackColor = System.Drawing.Color.White;
            this.label_info.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_info.Location = new System.Drawing.Point(12, 9);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(78, 48);
            this.label_info.TabIndex = 43;
            this.label_info.Text = "info";
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ok.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.button_ok.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_ok.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_ok.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_ok.ForeColor = System.Drawing.Color.Black;
            this.button_ok.Location = new System.Drawing.Point(49, 364);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(553, 51);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Visible = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label_show_pass
            // 
            this.label_show_pass.AutoSize = true;
            this.label_show_pass.BackColor = System.Drawing.Color.White;
            this.label_show_pass.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_show_pass.Location = new System.Drawing.Point(16, 311);
            this.label_show_pass.Name = "label_show_pass";
            this.label_show_pass.Size = new System.Drawing.Size(42, 23);
            this.label_show_pass.TabIndex = 45;
            this.label_show_pass.Text = "pass";
            this.label_show_pass.Visible = false;
            // 
            // 出力
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 427);
            this.Controls.Add(this.label_show_pass);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "出力";
            this.Text = "Export";
            this.Load += new System.EventHandler(this.Export_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label_show_pass;
    }
}