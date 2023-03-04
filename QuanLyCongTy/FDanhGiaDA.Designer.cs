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
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DanhGiaDA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã dự án:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên dự án:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhận xét:";
            // 
            // txt_MaDA
            // 
            this.txt_MaDA.Location = new System.Drawing.Point(144, 42);
            this.txt_MaDA.Name = "txt_MaDA";
            this.txt_MaDA.Size = new System.Drawing.Size(253, 26);
            this.txt_MaDA.TabIndex = 3;
            // 
            // txt_Thuong
            // 
            this.txt_Thuong.Location = new System.Drawing.Point(144, 212);
            this.txt_Thuong.Name = "txt_Thuong";
            this.txt_Thuong.Size = new System.Drawing.Size(253, 26);
            this.txt_Thuong.TabIndex = 4;
            // 
            // txt_TenDA
            // 
            this.txt_TenDA.Location = new System.Drawing.Point(508, 42);
            this.txt_TenDA.Name = "txt_TenDA";
            this.txt_TenDA.Size = new System.Drawing.Size(236, 26);
            this.txt_TenDA.TabIndex = 5;
            // 
            // rtxt_NhanXet
            // 
            this.rtxt_NhanXet.Location = new System.Drawing.Point(50, 116);
            this.rtxt_NhanXet.Name = "rtxt_NhanXet";
            this.rtxt_NhanXet.Size = new System.Drawing.Size(694, 82);
            this.rtxt_NhanXet.TabIndex = 6;
            this.rtxt_NhanXet.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thưởng:";
            // 
            // gv_DanhGiaDA
            // 
            this.gv_DanhGiaDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_DanhGiaDA.Location = new System.Drawing.Point(50, 260);
            this.gv_DanhGiaDA.Name = "gv_DanhGiaDA";
            this.gv_DanhGiaDA.RowHeadersWidth = 62;
            this.gv_DanhGiaDA.RowTemplate.Height = 28;
            this.gv_DanhGiaDA.Size = new System.Drawing.Size(694, 156);
            this.gv_DanhGiaDA.TabIndex = 8;
            this.gv_DanhGiaDA.DoubleClick += new System.EventHandler(this.gv_DanhGiaDA_DoubleClick);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(643, 209);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(83, 27);
            this.btn_Sua.TabIndex = 13;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(554, 208);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(83, 30);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(465, 209);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(83, 30);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // FDanhGiaDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 444);
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
    }
}