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
            this.pbThem = new System.Windows.Forms.PictureBox();
            this.btnDaHT = new System.Windows.Forms.Button();
            this.btnChuaHT = new System.Windows.Forms.Button();
            this.flp_ListDA = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pbThem);
            this.panel1.Controls.Add(this.btnDaHT);
            this.panel1.Controls.Add(this.btnChuaHT);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 79);
            this.panel1.TabIndex = 0;
            // 
            // pbThem
            // 
            this.pbThem.Image = global::QuanLyCongTy.Properties.Resources.Add;
            this.pbThem.Location = new System.Drawing.Point(1047, 8);
            this.pbThem.Name = "pbThem";
            this.pbThem.Size = new System.Drawing.Size(64, 55);
            this.pbThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbThem.TabIndex = 3;
            this.pbThem.TabStop = false;
            this.pbThem.Click += new System.EventHandler(this.pbThem_Click);
            this.pbThem.MouseEnter += new System.EventHandler(this.pbThem_MouseEnter);
            this.pbThem.MouseLeave += new System.EventHandler(this.pbThem_MouseLeave);
            // 
            // btnDaHT
            // 
            this.btnDaHT.Location = new System.Drawing.Point(262, -1);
            this.btnDaHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDaHT.Name = "btnDaHT";
            this.btnDaHT.Size = new System.Drawing.Size(264, 55);
            this.btnDaHT.TabIndex = 1;
            this.btnDaHT.Text = "Đã hoàn thành";
            this.btnDaHT.UseVisualStyleBackColor = true;
            this.btnDaHT.Click += new System.EventHandler(this.btnDaHT_Click);
            // 
            // btnChuaHT
            // 
            this.btnChuaHT.Location = new System.Drawing.Point(-1, -1);
            this.btnChuaHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChuaHT.Name = "btnChuaHT";
            this.btnChuaHT.Size = new System.Drawing.Size(264, 55);
            this.btnChuaHT.TabIndex = 0;
            this.btnChuaHT.Text = "Chưa hoàn thành";
            this.btnChuaHT.UseVisualStyleBackColor = true;
            this.btnChuaHT.Click += new System.EventHandler(this.btnChuaHT_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbThem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDaHT;
        private System.Windows.Forms.Button btnChuaHT;
        private System.Windows.Forms.FlowLayoutPanel flp_ListDA;
        private System.Windows.Forms.PictureBox pbThem;
    }
}