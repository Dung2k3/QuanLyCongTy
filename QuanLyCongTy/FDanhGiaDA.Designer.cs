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
            ((System.ComponentModel.ISupportInitialize)(this.gv_DanhGiaDA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Dự Án";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Dự Án";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhận xét";
            // 
            // txt_MaDA
            // 
            this.txt_MaDA.Location = new System.Drawing.Point(25, 81);
            this.txt_MaDA.Name = "txt_MaDA";
            this.txt_MaDA.Size = new System.Drawing.Size(100, 22);
            this.txt_MaDA.TabIndex = 8;
            // 
            // txt_Thuong
            // 
            this.txt_Thuong.Location = new System.Drawing.Point(22, 390);
            this.txt_Thuong.Name = "txt_Thuong";
            this.txt_Thuong.Size = new System.Drawing.Size(100, 22);
            this.txt_Thuong.TabIndex = 7;
            // 
            // txt_TenDA
            // 
            this.txt_TenDA.Location = new System.Drawing.Point(28, 147);
            this.txt_TenDA.Name = "txt_TenDA";
            this.txt_TenDA.Size = new System.Drawing.Size(100, 22);
            this.txt_TenDA.TabIndex = 6;
            // 
            // rtxt_NhanXet
            // 
            this.rtxt_NhanXet.Location = new System.Drawing.Point(25, 237);
            this.rtxt_NhanXet.Name = "rtxt_NhanXet";
            this.rtxt_NhanXet.Size = new System.Drawing.Size(312, 113);
            this.rtxt_NhanXet.TabIndex = 5;
            this.rtxt_NhanXet.Text = "";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thưởng";
            // 
            // gv_DanhGiaDA
            // 
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
            this.gv_DanhGiaDA.Location = new System.Drawing.Point(373, 12);
            this.gv_DanhGiaDA.Name = "gv_DanhGiaDA";
            this.gv_DanhGiaDA.RowHeadersVisible = false;
            this.gv_DanhGiaDA.RowHeadersWidth = 51;
            this.gv_DanhGiaDA.RowTemplate.Height = 28;
            this.gv_DanhGiaDA.Size = new System.Drawing.Size(615, 561);
            this.gv_DanhGiaDA.TabIndex = 3;
            this.gv_DanhGiaDA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_DanhGiaDA_CellContentClick);
            this.gv_DanhGiaDA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gv_DanhGiaDA_MouseClick);
            // 
            // MaDA
            // 
            this.MaDA.DataPropertyName = "MaDA";
            this.MaDA.MinimumWidth = 6;
            this.MaDA.Name = "MaDA";
            this.MaDA.ReadOnly = true;
            this.MaDA.Width = 125;
            // 
            // TenDuAn
            // 
            this.TenDuAn.DataPropertyName = "TenDuAn";
            this.TenDuAn.MinimumWidth = 6;
            this.TenDuAn.Name = "TenDuAn";
            this.TenDuAn.ReadOnly = true;
            this.TenDuAn.Width = 125;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Width = 125;
            // 
            // MaPB
            // 
            this.MaPB.DataPropertyName = "maPB";
            this.MaPB.MinimumWidth = 6;
            this.MaPB.Name = "MaPB";
            this.MaPB.ReadOnly = true;
            this.MaPB.Width = 125;
            // 
            // DiaDiem
            // 
            this.DiaDiem.DataPropertyName = "DiaDiem";
            this.DiaDiem.MinimumWidth = 6;
            this.DiaDiem.Name = "DiaDiem";
            this.DiaDiem.ReadOnly = true;
            this.DiaDiem.Width = 125;
            // 
            // DeadLine
            // 
            this.DeadLine.DataPropertyName = "DeadLine";
            this.DeadLine.MinimumWidth = 6;
            this.DeadLine.Name = "DeadLine";
            this.DeadLine.ReadOnly = true;
            this.DeadLine.Width = 125;
            // 
            // Thuong
            // 
            this.Thuong.DataPropertyName = "Thuong";
            this.Thuong.MinimumWidth = 6;
            this.Thuong.Name = "Thuong";
            this.Thuong.ReadOnly = true;
            this.Thuong.Width = 125;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(142, 454);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 0;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
           
            // 
            // FDanhGiaDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.btn_Sua);
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
            this.Name = "FDanhGiaDA";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDuAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thuong;
    }
}