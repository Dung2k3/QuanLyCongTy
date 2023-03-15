namespace QuanLyCongTy
{
    partial class FPhanCong
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
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_Deadline = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.gv_CongViec = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDuAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_TenNV = new System.Windows.Forms.ComboBox();
            this.cbo_TenDA = new System.Windows.Forms.ComboBox();
            this.rtxt_CongViec = new System.Windows.Forms.RichTextBox();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.lbl_duan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.cbo_CongViec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CongViec)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thời hạn: ";
            // 
            // dtp_Deadline
            // 
            this.dtp_Deadline.Location = new System.Drawing.Point(35, 607);
            this.dtp_Deadline.Name = "dtp_Deadline";
            this.dtp_Deadline.Size = new System.Drawing.Size(309, 26);
            this.dtp_Deadline.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Công việc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã dự án:";
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Location = new System.Drawing.Point(28, 100);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(107, 20);
            this.lbl_MaNV.TabIndex = 9;
            this.lbl_MaNV.Text = "Mã nhân viên:";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(261, 687);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(83, 33);
            this.btn_Sua.TabIndex = 21;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(149, 687);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(83, 33);
            this.btn_Xoa.TabIndex = 20;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(35, 687);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(83, 33);
            this.btn_Them.TabIndex = 19;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // gv_CongViec
            // 
            this.gv_CongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_CongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTenNV,
            this.MaDA,
            this.TenDuAn,
            this.CongViec,
            this.NgayBD,
            this.DeadLine});
            this.gv_CongViec.Location = new System.Drawing.Point(426, 49);
            this.gv_CongViec.Name = "gv_CongViec";
            this.gv_CongViec.RowHeadersVisible = false;
            this.gv_CongViec.RowHeadersWidth = 62;
            this.gv_CongViec.RowTemplate.Height = 28;
            this.gv_CongViec.Size = new System.Drawing.Size(669, 666);
            this.gv_CongViec.TabIndex = 22;
            this.gv_CongViec.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gv_CongViec_MouseClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 150;
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            this.HoTenNV.HeaderText = "Tên nhân viên";
            this.HoTenNV.MinimumWidth = 8;
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.ReadOnly = true;
            this.HoTenNV.Width = 150;
            // 
            // MaDA
            // 
            this.MaDA.DataPropertyName = "MaDA";
            this.MaDA.HeaderText = "Mã dự án";
            this.MaDA.MinimumWidth = 8;
            this.MaDA.Name = "MaDA";
            this.MaDA.ReadOnly = true;
            this.MaDA.Width = 150;
            // 
            // TenDuAn
            // 
            this.TenDuAn.DataPropertyName = "TenDuAn";
            this.TenDuAn.HeaderText = "Tên dự án";
            this.TenDuAn.MinimumWidth = 8;
            this.TenDuAn.Name = "TenDuAn";
            this.TenDuAn.ReadOnly = true;
            this.TenDuAn.Width = 150;
            // 
            // CongViec
            // 
            this.CongViec.DataPropertyName = "TenCV";
            this.CongViec.HeaderText = "Công việc";
            this.CongViec.MinimumWidth = 8;
            this.CongViec.Name = "CongViec";
            this.CongViec.ReadOnly = true;
            this.CongViec.Width = 150;
            // 
            // NgayBD
            // 
            this.NgayBD.DataPropertyName = "NgayBD";
            this.NgayBD.HeaderText = "Ngày bắt đầu";
            this.NgayBD.MinimumWidth = 8;
            this.NgayBD.Name = "NgayBD";
            this.NgayBD.ReadOnly = true;
            this.NgayBD.Width = 150;
            // 
            // DeadLine
            // 
            this.DeadLine.DataPropertyName = "DeadLine";
            this.DeadLine.HeaderText = "Thời hạn";
            this.DeadLine.MinimumWidth = 8;
            this.DeadLine.Name = "DeadLine";
            this.DeadLine.ReadOnly = true;
            this.DeadLine.Width = 150;
            // 
            // cbo_TenNV
            // 
            this.cbo_TenNV.FormattingEnabled = true;
            this.cbo_TenNV.Location = new System.Drawing.Point(149, 49);
            this.cbo_TenNV.Name = "cbo_TenNV";
            this.cbo_TenNV.Size = new System.Drawing.Size(222, 28);
            this.cbo_TenNV.TabIndex = 23;
            // 
            // cbo_TenDA
            // 
            this.cbo_TenDA.FormattingEnabled = true;
            this.cbo_TenDA.Location = new System.Drawing.Point(31, 188);
            this.cbo_TenDA.Name = "cbo_TenDA";
            this.cbo_TenDA.Size = new System.Drawing.Size(340, 28);
            this.cbo_TenDA.TabIndex = 24;
            // 
            // rtxt_CongViec
            // 
            this.rtxt_CongViec.Location = new System.Drawing.Point(31, 388);
            this.rtxt_CongViec.Name = "rtxt_CongViec";
            this.rtxt_CongViec.Size = new System.Drawing.Size(340, 58);
            this.rtxt_CongViec.TabIndex = 25;
            this.rtxt_CongViec.Text = "";
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Location = new System.Drawing.Point(27, 52);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(108, 20);
            this.lbl_ten.TabIndex = 26;
            this.lbl_ten.Text = "Tên nhân viên";
            // 
            // lbl_duan
            // 
            this.lbl_duan.AutoSize = true;
            this.lbl_duan.Location = new System.Drawing.Point(27, 148);
            this.lbl_duan.Name = "lbl_duan";
            this.lbl_duan.Size = new System.Drawing.Size(80, 20);
            this.lbl_duan.TabIndex = 27;
            this.lbl_duan.Text = "Tên dự án";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ngày bắt đầu:";
            // 
            // dtp_Start
            // 
            this.dtp_Start.Location = new System.Drawing.Point(31, 527);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(309, 26);
            this.dtp_Start.TabIndex = 28;
            // 
            // cbo_CongViec
            // 
            this.cbo_CongViec.FormattingEnabled = true;
            this.cbo_CongViec.Location = new System.Drawing.Point(31, 326);
            this.cbo_CongViec.Name = "cbo_CongViec";
            this.cbo_CongViec.Size = new System.Drawing.Size(340, 28);
            this.cbo_CongViec.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 32;
            // 
            // FPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 874);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_CongViec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_Start);
            this.Controls.Add(this.lbl_duan);
            this.Controls.Add(this.lbl_ten);
            this.Controls.Add(this.rtxt_CongViec);
            this.Controls.Add(this.cbo_TenDA);
            this.Controls.Add(this.cbo_TenNV);
            this.Controls.Add(this.gv_CongViec);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_Deadline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_MaNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FPhanCong";
            this.Text = "PhanCong";
            this.Load += new System.EventHandler(this.PhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_CongViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_Deadline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView gv_CongViec;
        private System.Windows.Forms.ComboBox cbo_TenNV;
        private System.Windows.Forms.ComboBox cbo_TenDA;
        private System.Windows.Forms.RichTextBox rtxt_CongViec;
        private System.Windows.Forms.Label lbl_ten;
        private System.Windows.Forms.Label lbl_duan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDuAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadLine;
        private System.Windows.Forms.ComboBox cbo_CongViec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}