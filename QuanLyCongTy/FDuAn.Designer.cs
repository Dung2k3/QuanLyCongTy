namespace QuanLyCongTy
{
    partial class FDuAn
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
            this.flp_ListDA = new System.Windows.Forms.FlowLayoutPanel();
            this.ptbDaHT = new System.Windows.Forms.PictureBox();
            this.ptbChuaHT = new System.Windows.Forms.PictureBox();
            this.pbThem = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDaHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChuaHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.ptbDaHT);
            this.panel1.Controls.Add(this.ptbChuaHT);
            this.panel1.Controls.Add(this.pbThem);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 79);
            this.panel1.TabIndex = 0;
            // 
            // flp_ListDA
            // 
            this.flp_ListDA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flp_ListDA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_ListDA.Location = new System.Drawing.Point(0, 85);
            this.flp_ListDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp_ListDA.Name = "flp_ListDA";
            this.flp_ListDA.Size = new System.Drawing.Size(1125, 790);
            this.flp_ListDA.TabIndex = 2;
            // 
            // ptbDaHT
            // 
            this.ptbDaHT.Image = global::QuanLyCongTy.Properties.Resources.ptDaHT;
            this.ptbDaHT.Location = new System.Drawing.Point(274, 5);
            this.ptbDaHT.Name = "ptbDaHT";
            this.ptbDaHT.Size = new System.Drawing.Size(265, 60);
            this.ptbDaHT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDaHT.TabIndex = 5;
            this.ptbDaHT.TabStop = false;
            this.ptbDaHT.Click += new System.EventHandler(this.ptbDaHT_Click);
            this.ptbDaHT.MouseEnter += new System.EventHandler(this.ptbDaHT_MouseEnter);
            this.ptbDaHT.MouseLeave += new System.EventHandler(this.ptbDaHT_MouseLeave);
            // 
            // ptbChuaHT
            // 
            this.ptbChuaHT.Image = global::QuanLyCongTy.Properties.Resources.ptChuaHT;
            this.ptbChuaHT.Location = new System.Drawing.Point(3, 5);
            this.ptbChuaHT.Name = "ptbChuaHT";
            this.ptbChuaHT.Size = new System.Drawing.Size(265, 60);
            this.ptbChuaHT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbChuaHT.TabIndex = 4;
            this.ptbChuaHT.TabStop = false;
            this.ptbChuaHT.Click += new System.EventHandler(this.ptbChuaHT_Click);
            this.ptbChuaHT.MouseEnter += new System.EventHandler(this.ptbChuaHT_MouseEnter);
            this.ptbChuaHT.MouseLeave += new System.EventHandler(this.ptbChuaHT_MouseLeave);
            // 
            // pbThem
            // 
            this.pbThem.Image = global::QuanLyCongTy.Properties.Resources.add_button;
            this.pbThem.Location = new System.Drawing.Point(1042, 5);
            this.pbThem.Name = "pbThem";
            this.pbThem.Size = new System.Drawing.Size(69, 66);
            this.pbThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbThem.TabIndex = 3;
            this.pbThem.TabStop = false;
            this.pbThem.Click += new System.EventHandler(this.pbThem_Click);
            this.pbThem.MouseEnter += new System.EventHandler(this.pbThem_MouseEnter);
            this.pbThem.MouseLeave += new System.EventHandler(this.pbThem_MouseLeave);
            // 
            // FDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1125, 875);
            this.Controls.Add(this.flp_ListDA);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FDuAn";
            this.Text = "FDuAn2";
            this.Load += new System.EventHandler(this.FDuAn_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbDaHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChuaHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flp_ListDA;
        private System.Windows.Forms.PictureBox pbThem;
        private System.Windows.Forms.PictureBox ptbChuaHT;
        private System.Windows.Forms.PictureBox ptbDaHT;
    }
}