namespace QuanLyCongTy
{
    partial class FQuanLy
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
            this.ucbtnTaoDA = new QuanLyCongTy.ucMenuBtn();
            this.ucbtnCheckinout = new QuanLyCongTy.ucMenuBtn();
            this.ucbtnXinNghi = new QuanLyCongTy.ucMenuBtn();
            this.ucTheme = new QuanLyCongTy.UC();
            this.SuspendLayout();
            // 
            // ucbtnTaoDA
            // 
            this.ucbtnTaoDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ucbtnTaoDA.Location = new System.Drawing.Point(0, 143);
            this.ucbtnTaoDA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucbtnTaoDA.Name = "ucbtnTaoDA";
            this.ucbtnTaoDA.Size = new System.Drawing.Size(187, 57);
            this.ucbtnTaoDA.TabIndex = 2;
            this.ucbtnTaoDA.Text = "Tạo Dự Án";
            // 
            // ucbtnCheckinout
            // 
            this.ucbtnCheckinout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ucbtnCheckinout.Location = new System.Drawing.Point(0, 81);
            this.ucbtnCheckinout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucbtnCheckinout.Name = "ucbtnCheckinout";
            this.ucbtnCheckinout.Size = new System.Drawing.Size(187, 57);
            this.ucbtnCheckinout.TabIndex = 1;
            this.ucbtnCheckinout.Text = "Checkin/out";
            // 
            // ucbtnXinNghi
            // 
            this.ucbtnXinNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ucbtnXinNghi.Location = new System.Drawing.Point(0, 207);
            this.ucbtnXinNghi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucbtnXinNghi.Name = "ucbtnXinNghi";
            this.ucbtnXinNghi.Size = new System.Drawing.Size(187, 57);
            this.ucbtnXinNghi.TabIndex = 4;
            this.ucbtnXinNghi.Text = "Xin nghỉ";
            // 
            // ucTheme
            // 
            this.ucTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTheme.Location = new System.Drawing.Point(0, 0);
            this.ucTheme.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucTheme.Name = "ucTheme";
            this.ucTheme.Size = new System.Drawing.Size(937, 650);
            this.ucTheme.TabIndex = 0;
            // 
            // FQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 650);
            this.Controls.Add(this.ucbtnXinNghi);
            this.Controls.Add(this.ucbtnTaoDA);
            this.Controls.Add(this.ucbtnCheckinout);
            this.Controls.Add(this.ucTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FQuanLy";
            this.Text = "FQuanLy2";
            this.ResumeLayout(false);

        }

        #endregion

        private UC ucTheme;
        private ucMenuBtn ucbtnCheckinout;
        private ucMenuBtn ucbtnTaoDA;
        private ucMenuBtn ucbtnXinNghi;
    }
}