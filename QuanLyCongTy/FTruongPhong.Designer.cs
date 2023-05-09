namespace QuanLyCongTy
{
    partial class FTruongPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTruongPhong));
            this.ucbtnLich = new QuanLyCongTy.ucMenuBtn();
            this.ucbtnXinNghi = new QuanLyCongTy.ucMenuBtn();
            this.ucbtnTaoPC = new QuanLyCongTy.ucMenuBtn();
            this.ucbtnCheckinout = new QuanLyCongTy.ucMenuBtn();
            this.ucTheme = new QuanLyCongTy.UC();
            this.SuspendLayout();
            // 
            // ucbtnLich
            // 
            this.ucbtnLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ucbtnLich.Location = new System.Drawing.Point(-2, 382);
            this.ucbtnLich.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucbtnLich.Name = "ucbtnLich";
            this.ucbtnLich.Size = new System.Drawing.Size(280, 88);
            this.ucbtnLich.TabIndex = 6;
            this.ucbtnLich.Text = "Lịch ";
            // 
            // ucbtnXinNghi
            // 
            this.ucbtnXinNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ucbtnXinNghi.Location = new System.Drawing.Point(0, 300);
            this.ucbtnXinNghi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucbtnXinNghi.Name = "ucbtnXinNghi";
            this.ucbtnXinNghi.Size = new System.Drawing.Size(279, 88);
            this.ucbtnXinNghi.TabIndex = 4;
            this.ucbtnXinNghi.Text = "Xin Nghỉ";
            // 
            // ucbtnTaoPC
            // 
            this.ucbtnTaoPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ucbtnTaoPC.Location = new System.Drawing.Point(0, 212);
            this.ucbtnTaoPC.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucbtnTaoPC.Name = "ucbtnTaoPC";
            this.ucbtnTaoPC.Size = new System.Drawing.Size(279, 88);
            this.ucbtnTaoPC.TabIndex = 2;
            this.ucbtnTaoPC.Text = "Dự Án";
            // 
            // ucbtnCheckinout
            // 
            this.ucbtnCheckinout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ucbtnCheckinout.Location = new System.Drawing.Point(0, 125);
            this.ucbtnCheckinout.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucbtnCheckinout.Name = "ucbtnCheckinout";
            this.ucbtnCheckinout.Size = new System.Drawing.Size(279, 88);
            this.ucbtnCheckinout.TabIndex = 1;
            this.ucbtnCheckinout.Text = "Check in/out";
            // 
            // ucTheme
            // 
            this.ucTheme.Location = new System.Drawing.Point(0, 0);
            this.ucTheme.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucTheme.Name = "ucTheme";
            this.ucTheme.Size = new System.Drawing.Size(1406, 1000);
            this.ucTheme.TabIndex = 7;
            // 
            // FTruongPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 1000);
            this.Controls.Add(this.ucbtnLich);
            this.Controls.Add(this.ucbtnXinNghi);
            this.Controls.Add(this.ucbtnTaoPC);
            this.Controls.Add(this.ucbtnCheckinout);
            this.Controls.Add(this.ucTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FTruongPhong";
            this.Text = "FTruongPhong2";
            this.ResumeLayout(false);

        }

        #endregion
        private ucMenuBtn ucbtnCheckinout;
        private ucMenuBtn ucbtnTaoPC;
        private ucMenuBtn ucbtnXinNghi;
        private ucMenuBtn ucbtnLich;
        private UC ucTheme;
    }
}