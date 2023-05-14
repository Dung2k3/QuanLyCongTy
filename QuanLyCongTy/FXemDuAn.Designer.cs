namespace QuanLyCongTy
{
    partial class FXemDuAn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDaHT = new Guna.UI2.WinForms.Guna2Button();
            this.btnChuaHT = new Guna.UI2.WinForms.Guna2Button();
            this.flp_ListDA = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDaHT);
            this.panel1.Controls.Add(this.btnChuaHT);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 63);
            this.panel1.TabIndex = 5;
            // 
            // btnDaHT
            // 
            this.btnDaHT.Animated = true;
            this.btnDaHT.AutoRoundedCorners = true;
            this.btnDaHT.BackColor = System.Drawing.Color.Transparent;
            this.btnDaHT.BorderRadius = 22;
            this.btnDaHT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDaHT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDaHT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDaHT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDaHT.FillColor = System.Drawing.Color.White;
            this.btnDaHT.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnDaHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnDaHT.Location = new System.Drawing.Point(218, 8);
            this.btnDaHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDaHT.Name = "btnDaHT";
            this.btnDaHT.Size = new System.Drawing.Size(204, 46);
            this.btnDaHT.TabIndex = 7;
            this.btnDaHT.Text = "Đã hoàn thành";
            this.btnDaHT.Click += new System.EventHandler(this.btnDaHT_Click);
            // 
            // btnChuaHT
            // 
            this.btnChuaHT.Animated = true;
            this.btnChuaHT.AutoRoundedCorners = true;
            this.btnChuaHT.BorderRadius = 22;
            this.btnChuaHT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChuaHT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChuaHT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChuaHT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChuaHT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnChuaHT.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnChuaHT.ForeColor = System.Drawing.Color.White;
            this.btnChuaHT.Location = new System.Drawing.Point(9, 8);
            this.btnChuaHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChuaHT.Name = "btnChuaHT";
            this.btnChuaHT.Size = new System.Drawing.Size(204, 46);
            this.btnChuaHT.TabIndex = 6;
            this.btnChuaHT.Text = "Chưa hoàn thành";
            this.btnChuaHT.Click += new System.EventHandler(this.btnChuaHT_Click);
            // 
            // flp_ListDA
            // 
            this.flp_ListDA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flp_ListDA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_ListDA.Location = new System.Drawing.Point(0, 98);
            this.flp_ListDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp_ListDA.Name = "flp_ListDA";
            this.flp_ListDA.Size = new System.Drawing.Size(1000, 602);
            this.flp_ListDA.TabIndex = 6;
            // 
            // FXemDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flp_ListDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FXemDuAn";
            this.Text = "FXemDuAn2";
            this.Load += new System.EventHandler(this.FXemDuAn_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnDaHT;
        private Guna.UI2.WinForms.Guna2Button btnChuaHT;
        private System.Windows.Forms.FlowLayoutPanel flp_ListDA;
    }
}