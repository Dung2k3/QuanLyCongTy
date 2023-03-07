namespace QuanLyCongTy
{
    partial class FDanhGiaDA
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaDA = new System.Windows.Forms.TextBox();
            this.txt_Thuong = new System.Windows.Forms.TextBox();
            this.txt_TenDA = new System.Windows.Forms.TextBox();
            this.rtxt_NhanXet = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gv_DanhGiaDA = new System.Windows.Forms.DataGridView();
            this.MaDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDuAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DanhGiaDA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-41, -48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã dự án:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-41, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên dự án:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-47, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhận xét:";
            // 
            // txt_MaDA
            // 
            this.txt_MaDA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaDA.Location = new System.Drawing.Point(-38, -8);
            this.txt_MaDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaDA.Name = "txt_MaDA";
            this.txt_MaDA.Size = new System.Drawing.Size(149, 26);
            this.txt_MaDA.TabIndex = 3;
            // 
            // txt_Thuong
            // 
            this.txt_Thuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Thuong.Location = new System.Drawing.Point(-46, 404);
            this.txt_Thuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Thuong.Name = "txt_Thuong";
            this.txt_Thuong.Size = new System.Drawing.Size(124, 26);
            this.txt_Thuong.TabIndex = 4;
            // 
            // txt_TenDA
            // 
            this.txt_TenDA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenDA.Location = new System.Drawing.Point(-38, 89);
            this.txt_TenDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenDA.Name = "txt_TenDA";
            this.txt_TenDA.Size = new System.Drawing.Size(149, 26);
            this.txt_TenDA.TabIndex = 5;
            // 
            // rtxt_NhanXet
            // 
            this.rtxt_NhanXet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxt_NhanXet.Location = new System.Drawing.Point(-46, 185);
            this.rtxt_NhanXet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxt_NhanXet.Name = "rtxt_NhanXet";
            this.rtxt_NhanXet.Size = new System.Drawing.Size(260, 125);
            this.rtxt_NhanXet.TabIndex = 6;
            this.rtxt_NhanXet.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-49, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thưởng:";
            // 
            // gv_DanhGiaDA
            // 
            this.gv_DanhGiaDA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gv_DanhGiaDA.BackgroundColor = System.Drawing.Color.White;
            this.gv_DanhGiaDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_DanhGiaDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_DanhGiaDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDA,
            this.TenDuAn,
            this.MoTa,
            this.MaPB,
            this.DiaDiem,
            this.DeadLine,
            this.Thuong});
            this.gv_DanhGiaDA.Location = new System.Drawing.Point(318, -54);
            this.gv_DanhGiaDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gv_DanhGiaDA.Name = "gv_DanhGiaDA";
            this.gv_DanhGiaDA.RowHeadersVisible = false;
            this.gv_DanhGiaDA.RowHeadersWidth = 62;
            this.gv_DanhGiaDA.RowTemplate.Height = 28;
            this.gv_DanhGiaDA.Size = new System.Drawing.Size(732, 722);
            this.gv_DanhGiaDA.TabIndex = 8;
            this.gv_DanhGiaDA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gv_DanhGiaDA_MouseClick);
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
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 8;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Width = 150;
            // 
            // MaPB
            // 
            this.MaPB.DataPropertyName = "maPB";
            this.MaPB.HeaderText = "Mã phòng ban";
            this.MaPB.MinimumWidth = 8;
            this.MaPB.Name = "MaPB";
            this.MaPB.ReadOnly = true;
            this.MaPB.Width = 150;
            // 
            // DiaDiem
            // 
            this.DiaDiem.DataPropertyName = "DiaDiem";
            this.DiaDiem.HeaderText = "Địa điểm";
            this.DiaDiem.MinimumWidth = 8;
            this.DiaDiem.Name = "DiaDiem";
            this.DiaDiem.ReadOnly = true;
            this.DiaDiem.Width = 150;
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
            // Thuong
            // 
            this.Thuong.DataPropertyName = "Thuong";
            this.Thuong.HeaderText = "Thưởng";
            this.Thuong.MinimumWidth = 8;
            this.Thuong.Name = "Thuong";
            this.Thuong.ReadOnly = true;
            this.Thuong.Width = 150;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Sua.Location = new System.Drawing.Point(168, 547);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(83, 31);
            this.btn_Sua.TabIndex = 13;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Xoa.Location = new System.Drawing.Point(60, 547);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(83, 34);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Them.Location = new System.Drawing.Point(-47, 547);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(83, 34);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // FDanhGiaDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 729);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.gv_DanhGiaDA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxt_NhanXet);
            this.Controls.Add(this.txt_TenDA);
            this.Controls.Add(this.txt_Thuong);
            this.Controls.Add(this.txt_MaDA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FDanhGiaDA";
            this.Text = "DanhGiaDA";
            this.Load += new System.EventHandler(this.DanhGiaDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_DanhGiaDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaDA;
        private System.Windows.Forms.TextBox txt_Thuong;
        private System.Windows.Forms.TextBox txt_TenDA;
        private System.Windows.Forms.RichTextBox rtxt_NhanXet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gv_DanhGiaDA;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDuAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thuong;
    }
}