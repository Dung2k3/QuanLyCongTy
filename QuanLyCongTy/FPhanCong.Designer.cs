﻿namespace QuanLyCongTy
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
            this.gv_NhanVien = new System.Windows.Forms.DataGridView();
            this.txt_CongViec = new System.Windows.Forms.TextBox();
            this.txt_MaDA = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_Deadline = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_DuAn = new System.Windows.Forms.DataGridView();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.gv_CongViec = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DuAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CongViec)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_NhanVien
            // 
            this.gv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_NhanVien.Location = new System.Drawing.Point(71, 209);
            this.gv_NhanVien.Name = "gv_NhanVien";
            this.gv_NhanVien.RowHeadersWidth = 62;
            this.gv_NhanVien.RowTemplate.Height = 28;
            this.gv_NhanVien.Size = new System.Drawing.Size(336, 253);
            this.gv_NhanVien.TabIndex = 17;
            this.gv_NhanVien.DoubleClick += new System.EventHandler(this.gv_NhanVien_DoubleClick);
            // 
            // txt_CongViec
            // 
            this.txt_CongViec.Location = new System.Drawing.Point(490, 43);
            this.txt_CongViec.Name = "txt_CongViec";
            this.txt_CongViec.Size = new System.Drawing.Size(299, 26);
            this.txt_CongViec.TabIndex = 16;
            // 
            // txt_MaDA
            // 
            this.txt_MaDA.Location = new System.Drawing.Point(176, 102);
            this.txt_MaDA.Name = "txt_MaDA";
            this.txt_MaDA.Size = new System.Drawing.Size(168, 26);
            this.txt_MaDA.TabIndex = 15;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(176, 43);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(168, 26);
            this.txt_MaNV.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thời hạn: ";
            // 
            // dtp_Deadline
            // 
            this.dtp_Deadline.Location = new System.Drawing.Point(490, 100);
            this.dtp_Deadline.Name = "dtp_Deadline";
            this.dtp_Deadline.Size = new System.Drawing.Size(299, 26);
            this.dtp_Deadline.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Công việc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã dự án:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã nhân viên:";
            // 
            // gv_DuAn
            // 
            this.gv_DuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_DuAn.Location = new System.Drawing.Point(453, 209);
            this.gv_DuAn.Name = "gv_DuAn";
            this.gv_DuAn.RowHeadersWidth = 62;
            this.gv_DuAn.RowTemplate.Height = 28;
            this.gv_DuAn.Size = new System.Drawing.Size(336, 108);
            this.gv_DuAn.TabIndex = 18;
            this.gv_DuAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_DuAn_CellContentClick);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(706, 157);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(83, 27);
            this.btn_Sua.TabIndex = 21;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(600, 157);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(83, 30);
            this.btn_Xoa.TabIndex = 20;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(494, 157);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(83, 30);
            this.btn_Them.TabIndex = 19;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // gv_CongViec
            // 
            this.gv_CongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_CongViec.Location = new System.Drawing.Point(453, 354);
            this.gv_CongViec.Name = "gv_CongViec";
            this.gv_CongViec.RowHeadersWidth = 62;
            this.gv_CongViec.RowTemplate.Height = 28;
            this.gv_CongViec.Size = new System.Drawing.Size(336, 108);
            this.gv_CongViec.TabIndex = 22;
            this.gv_CongViec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CongViec_CellContentClick);
            // 
            // FPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 502);
            this.Controls.Add(this.gv_CongViec);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.gv_DuAn);
            this.Controls.Add(this.gv_NhanVien);
            this.Controls.Add(this.txt_CongViec);
            this.Controls.Add(this.txt_MaDA);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_Deadline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FPhanCong";
            this.Text = "PhanCong";
            this.Load += new System.EventHandler(this.PhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DuAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CongViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gv_NhanVien;
        private System.Windows.Forms.TextBox txt_CongViec;
        private System.Windows.Forms.TextBox txt_MaDA;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_Deadline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gv_DuAn;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView gv_CongViec;
    }
}