namespace QuanLyCongTy
{
    partial class DanhGia
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.rtxt_NhanXet = new System.Windows.Forms.RichTextBox();
            this.gv_PhanCong = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txt_ChamCong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaDA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhận xét:";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(163, 34);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(303, 26);
            this.txt_MaNV.TabIndex = 3;
            // 
            // rtxt_NhanXet
            // 
            this.rtxt_NhanXet.Location = new System.Drawing.Point(54, 110);
            this.rtxt_NhanXet.Name = "rtxt_NhanXet";
            this.rtxt_NhanXet.Size = new System.Drawing.Size(870, 75);
            this.rtxt_NhanXet.TabIndex = 6;
            this.rtxt_NhanXet.Text = "";
            // 
            // gv_PhanCong
            // 
            this.gv_PhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_PhanCong.Location = new System.Drawing.Point(54, 268);
            this.gv_PhanCong.Name = "gv_PhanCong";
            this.gv_PhanCong.RowHeadersWidth = 62;
            this.gv_PhanCong.RowTemplate.Height = 28;
            this.gv_PhanCong.Size = new System.Drawing.Size(870, 347);
            this.gv_PhanCong.TabIndex = 7;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(603, 210);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(83, 30);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(709, 210);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(83, 30);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(815, 210);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(83, 30);
            this.btn_Sua.TabIndex = 10;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // txt_ChamCong
            // 
            this.txt_ChamCong.Location = new System.Drawing.Point(163, 211);
            this.txt_ChamCong.Name = "txt_ChamCong";
            this.txt_ChamCong.Size = new System.Drawing.Size(303, 26);
            this.txt_ChamCong.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chấm công:";
            // 
            // txt_MaDA
            // 
            this.txt_MaDA.Location = new System.Drawing.Point(604, 34);
            this.txt_MaDA.Name = "txt_MaDA";
            this.txt_MaDA.Size = new System.Drawing.Size(320, 26);
            this.txt_MaDA.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã dự án:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.txt_MaDA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ChamCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.gv_PhanCong);
            this.Controls.Add(this.rtxt_NhanXet);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "DanhGia";
            this.Text = "DanhGia";
            ((System.ComponentModel.ISupportInitialize)(this.gv_PhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.RichTextBox rtxt_NhanXet;
        private System.Windows.Forms.DataGridView gv_PhanCong;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.TextBox txt_ChamCong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaDA;
        private System.Windows.Forms.Label label4;
    }
}