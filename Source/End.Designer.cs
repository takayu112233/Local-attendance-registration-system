namespace NFC_OFFLINE_APP
{
    partial class End
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
            this.button_end = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_err = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_end
            // 
            this.button_end.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_end.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_end.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_end.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.button_end.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_end.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_end.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_end.ForeColor = System.Drawing.Color.Black;
            this.button_end.Location = new System.Drawing.Point(353, 121);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(252, 51);
            this.button_end.TabIndex = 1;
            this.button_end.Text = "終了";
            this.button_end.UseVisualStyleBackColor = false;
            this.button_end.Click += new System.EventHandler(this.button_end_Click);
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
            this.button_Cancel.Location = new System.Drawing.Point(52, 121);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(252, 51);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "キャンセル";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_err
            // 
            this.label_err.AutoSize = true;
            this.label_err.BackColor = System.Drawing.Color.White;
            this.label_err.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_err.Location = new System.Drawing.Point(172, 40);
            this.label_err.Name = "label_err";
            this.label_err.Size = new System.Drawing.Size(244, 48);
            this.label_err.TabIndex = 42;
            this.label_err.Text = "終了しますか？";
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 198);
            this.Controls.Add(this.label_err);
            this.Controls.Add(this.button_end);
            this.Controls.Add(this.button_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "End";
            this.Text = "確認";
            this.Load += new System.EventHandler(this.End_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_end;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_err;
    }
}