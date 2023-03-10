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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNhanVien));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnXinNghi = new System.Windows.Forms.Button();
            this.btnThuong = new System.Windows.Forms.Button();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnCheckinout = new System.Windows.Forms.Button();
            this.panelName = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.pnlNoiDung = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.panelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenu.Controls.Add(this.btnXinNghi);
            this.pnlMenu.Controls.Add(this.btnThuong);
            this.pnlMenu.Controls.Add(this.btnPhanCong);
            this.pnlMenu.Controls.Add(this.btnCheckinout);
            this.pnlMenu.Controls.Add(this.panelName);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(281, 1000);
            this.pnlMenu.TabIndex = 7;
            // 
            // btnXinNghi
            // 
            this.btnXinNghi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXinNghi.FlatAppearance.BorderSize = 0;
            this.btnXinNghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXinNghi.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXinNghi.ForeColor = System.Drawing.Color.White;
            this.btnXinNghi.Image = ((System.Drawing.Image)(resources.GetObject("btnXinNghi.Image")));
            this.btnXinNghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXinNghi.Location = new System.Drawing.Point(0, 389);
            this.btnXinNghi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXinNghi.Name = "btnXinNghi";
            this.btnXinNghi.Size = new System.Drawing.Size(281, 88);
            this.btnXinNghi.TabIndex = 5;
            this.btnXinNghi.Text = "Xin Nghỉ";
            this.btnXinNghi.UseVisualStyleBackColor = true;
            this.btnXinNghi.Click += new System.EventHandler(this.btnXinNghi_Click);
            // 
            // btnThuong
            // 
            this.btnThuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThuong.FlatAppearance.BorderSize = 0;
            this.btnThuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuong.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuong.ForeColor = System.Drawing.Color.White;
            this.btnThuong.Image = global::QuanLyCongTy.Properties.Resources.document_32;
            this.btnThuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThuong.Location = new System.Drawing.Point(0, 301);
            this.btnThuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThuong.Name = "btnThuong";
            this.btnThuong.Size = new System.Drawing.Size(281, 88);
            this.btnThuong.TabIndex = 4;
            this.btnThuong.Text = "    Lương Thưởng";
            this.btnThuong.UseVisualStyleBackColor = true;
            this.btnThuong.Click += new System.EventHandler(this.btnThuong_Click);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhanCong.FlatAppearance.BorderSize = 0;
            this.btnPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanCong.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCong.ForeColor = System.Drawing.Color.White;
            this.btnPhanCong.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanCong.Image")));
            this.btnPhanCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanCong.Location = new System.Drawing.Point(0, 213);
            this.btnPhanCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(281, 88);
            this.btnPhanCong.TabIndex = 3;
            this.btnPhanCong.Text = "Phân Công";
            this.btnPhanCong.UseVisualStyleBackColor = true;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // btnCheckinout
            // 
            this.btnCheckinout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckinout.FlatAppearance.BorderSize = 0;
            this.btnCheckinout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckinout.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckinout.ForeColor = System.Drawing.Color.White;
            this.btnCheckinout.Image = global::QuanLyCongTy.Properties.Resources.arrow_19_32_2_;
            this.btnCheckinout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckinout.Location = new System.Drawing.Point(0, 125);
            this.btnCheckinout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckinout.Name = "btnCheckinout";
            this.btnCheckinout.Size = new System.Drawing.Size(281, 88);
            this.btnCheckinout.TabIndex = 1;
            this.btnCheckinout.Text = "Check in/out";
            this.btnCheckinout.UseVisualStyleBackColor = true;
            this.btnCheckinout.Click += new System.EventHandler(this.btnCheckinout_Click);
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelName.Controls.Add(this.pictureBox1);
            this.panelName.Controls.Add(this.lblName);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(281, 125);
            this.panelName.TabIndex = 0;
            this.panelName.Click += new System.EventHandler(this.panelName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyCongTy.Properties.Resources.NhanVienName;
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(87, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.btnCloseForm);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(281, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1125, 125);
            this.pnlTitle.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(549, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 44);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = " ";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnCloseForm.ForeColor = System.Drawing.Color.Black;
            this.btnCloseForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCloseForm.Location = new System.Drawing.Point(1048, 0);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(76, 60);
            this.btnCloseForm.TabIndex = 6;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // pnlNoiDung
            // 
            this.pnlNoiDung.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNoiDung.Location = new System.Drawing.Point(281, 125);
            this.pnlNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Size = new System.Drawing.Size(1125, 875);
            this.pnlNoiDung.TabIndex = 9;
            // 
            // FNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 1000);
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FNhanVien";
            this.Load += new System.EventHandler(this.FNhanVien_Load);
            this.pnlMenu.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCheckinout;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnThuong;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlNoiDung;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnXinNghi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
    }
}