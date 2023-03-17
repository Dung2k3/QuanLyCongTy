namespace QuanLyCongTy
{
    partial class UCTienDoDA
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.lbl_NgayCL = new System.Windows.Forms.Label();
            this.pgb_TDDA = new System.Windows.Forms.ProgressBar();
            this.lbl_TenPhong = new System.Windows.Forms.Label();
            this.lbl_tenDA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(565, 34);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(52, 54);
            this.btn_Xoa.TabIndex = 17;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(507, 34);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(52, 54);
            this.btn_Sua.TabIndex = 16;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // lbl_NgayCL
            // 
            this.lbl_NgayCL.AutoSize = true;
            this.lbl_NgayCL.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_NgayCL.Location = new System.Drawing.Point(33, 146);
            this.lbl_NgayCL.Name = "lbl_NgayCL";
            this.lbl_NgayCL.Size = new System.Drawing.Size(94, 20);
            this.lbl_NgayCL.TabIndex = 15;
            this.lbl_NgayCL.Text = "Ngày còn lại";
            // 
            // pgb_TDDA
            // 
            this.pgb_TDDA.Location = new System.Drawing.Point(37, 118);
            this.pgb_TDDA.Name = "pgb_TDDA";
            this.pgb_TDDA.Size = new System.Drawing.Size(580, 10);
            this.pgb_TDDA.TabIndex = 14;
            // 
            // lbl_TenPhong
            // 
            this.lbl_TenPhong.AutoSize = true;
            this.lbl_TenPhong.Location = new System.Drawing.Point(33, 77);
            this.lbl_TenPhong.Name = "lbl_TenPhong";
            this.lbl_TenPhong.Size = new System.Drawing.Size(85, 20);
            this.lbl_TenPhong.TabIndex = 13;
            this.lbl_TenPhong.Text = "Tên phòng";
            // 
            // lbl_tenDA
            // 
            this.lbl_tenDA.AutoSize = true;
            this.lbl_tenDA.Location = new System.Drawing.Point(33, 34);
            this.lbl_tenDA.Name = "lbl_tenDA";
            this.lbl_tenDA.Size = new System.Drawing.Size(80, 20);
            this.lbl_tenDA.TabIndex = 12;
            this.lbl_tenDA.Text = "Tên dự án";
            // 
            // UCTienDoDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.lbl_NgayCL);
            this.Controls.Add(this.pgb_TDDA);
            this.Controls.Add(this.lbl_TenPhong);
            this.Controls.Add(this.lbl_tenDA);
            this.Name = "UCTienDoDA";
            this.Size = new System.Drawing.Size(648, 198);
            this.Load += new System.EventHandler(this.UCTienDoDA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label lbl_NgayCL;
        private System.Windows.Forms.ProgressBar pgb_TDDA;
        private System.Windows.Forms.Label lbl_TenPhong;
        private System.Windows.Forms.Label lbl_tenDA;
    }
}
