namespace QuanLyCongTy
{
    partial class FNhanVien
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
            this.ucbtnXinNghi = new QuanLyCongTy.ucMenuBtn();
            this.ucbtnKPI = new QuanLyCongTy.ucMenuBtn();
            this.ucbtnPhanCong = new QuanLyCongTy.ucMenuBtn();
            this.ucbtnCheckinout = new QuanLyCongTy.ucMenuBtn();
            this.ucTheme = new QuanLyCongTy.UC();
            this.SuspendLayout();
            // 
            // ucbtnXinNghi
            // 
            this.ucbtnXinNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ucbtnXinNghi.Location = new System.Drawing.Point(0, 252);
            this.ucbtnXinNghi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucbtnXinNghi.Name = "ucbtnXinNghi";
            this.ucbtnXinNghi.Size = new System.Drawing.Size(187, 57);
            this.ucbtnXinNghi.TabIndex = 4;
            this.ucbtnXinNghi.Text = "Xin Nghỉ";
            // 
            // ucbtnKPI
            // 
            this.ucbtnKPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ucbtnKPI.Location = new System.Drawing.Point(0, 195);
            this.ucbtnKPI.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucbtnKPI.Name = "ucbtnKPI";
            this.ucbtnKPI.Size = new System.Drawing.Size(187, 57);
            this.ucbtnKPI.TabIndex = 3;
            this.ucbtnKPI.Text = "Cập nhật tiến độ";
            // 
            // ucbtnPhanCong
            // 
            this.ucbtnPhanCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ucbtnPhanCong.Location = new System.Drawing.Point(0, 138);
            this.ucbtnPhanCong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucbtnPhanCong.Name = "ucbtnPhanCong";
            this.ucbtnPhanCong.Size = new System.Drawing.Size(187, 57);
            this.ucbtnPhanCong.TabIndex = 2;
            this.ucbtnPhanCong.Text = "Phân Công";
            // 
            // ucbtnCheckinout
            // 
            this.ucbtnCheckinout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ucbtnCheckinout.Location = new System.Drawing.Point(0, 81);
            this.ucbtnCheckinout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucbtnCheckinout.Name = "ucbtnCheckinout";
            this.ucbtnCheckinout.Size = new System.Drawing.Size(187, 57);
            this.ucbtnCheckinout.TabIndex = 1;
            this.ucbtnCheckinout.Text = "Check in/out";
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
            // FNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 650);
            this.Controls.Add(this.ucbtnXinNghi);
            this.Controls.Add(this.ucbtnKPI);
            this.Controls.Add(this.ucbtnPhanCong);
            this.Controls.Add(this.ucbtnCheckinout);
            this.Controls.Add(this.ucTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FNhanVien2";
            this.ResumeLayout(false);

        }

        #endregion

        private UC ucTheme;
        private ucMenuBtn ucbtnCheckinout;
        private ucMenuBtn ucbtnPhanCong;
        private ucMenuBtn ucbtnKPI;
        private ucMenuBtn ucbtnXinNghi;
    }
}