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
            this.gv_DuAn = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaDA = new System.Windows.Forms.TextBox();
            this.txt_TenDA = new System.Windows.Forms.TextBox();
            this.txt_MaPB = new System.Windows.Forms.TextBox();
            this.txt_DD = new System.Windows.Forms.TextBox();
            this.rtxt_MoTa = new System.Windows.Forms.RichTextBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_deadline = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DuAn)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_DuAn
            // 
            this.gv_DuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_DuAn.Location = new System.Drawing.Point(498, 50);
            this.gv_DuAn.Name = "gv_DuAn";
            this.gv_DuAn.RowHeadersWidth = 62;
            this.gv_DuAn.RowTemplate.Height = 28;
            this.gv_DuAn.Size = new System.Drawing.Size(516, 404);
            this.gv_DuAn.TabIndex = 0;
            this.gv_DuAn.DoubleClick += new System.EventHandler(this.gv_DuAn_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã dự án:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên dự án:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã phòng ban:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa điểm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mô tả:";
            // 
            // txt_MaDA
            // 
            this.txt_MaDA.Location = new System.Drawing.Point(158, 50);
            this.txt_MaDA.Name = "txt_MaDA";
            this.txt_MaDA.Size = new System.Drawing.Size(297, 26);
            this.txt_MaDA.TabIndex = 6;
            // 
            // txt_TenDA
            // 
            this.txt_TenDA.Location = new System.Drawing.Point(158, 98);
            this.txt_TenDA.Name = "txt_TenDA";
            this.txt_TenDA.Size = new System.Drawing.Size(297, 26);
            this.txt_TenDA.TabIndex = 7;
            // 
            // txt_MaPB
            // 
            this.txt_MaPB.Location = new System.Drawing.Point(158, 144);
            this.txt_MaPB.Name = "txt_MaPB";
            this.txt_MaPB.Size = new System.Drawing.Size(297, 26);
            this.txt_MaPB.TabIndex = 8;
            // 
            // txt_DD
            // 
            this.txt_DD.Location = new System.Drawing.Point(158, 192);
            this.txt_DD.Name = "txt_DD";
            this.txt_DD.Size = new System.Drawing.Size(297, 26);
            this.txt_DD.TabIndex = 9;
            // 
            // rtxt_MoTa
            // 
            this.rtxt_MoTa.Location = new System.Drawing.Point(158, 287);
            this.rtxt_MoTa.Name = "rtxt_MoTa";
            this.rtxt_MoTa.Size = new System.Drawing.Size(297, 108);
            this.rtxt_MoTa.TabIndex = 10;
            this.rtxt_MoTa.Text = "";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(372, 424);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(83, 30);
            this.btn_Sua.TabIndex = 24;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(265, 424);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(83, 30);
            this.btn_Xoa.TabIndex = 23;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(158, 424);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(83, 30);
            this.btn_Them.TabIndex = 22;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Thời hạn:";
            // 
            // dtp_deadline
            // 
            this.dtp_deadline.Location = new System.Drawing.Point(158, 237);
            this.dtp_deadline.Name = "dtp_deadline";
            this.dtp_deadline.Size = new System.Drawing.Size(297, 26);
            this.dtp_deadline.TabIndex = 26;
            // 
            // FDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 488);
            this.Controls.Add(this.dtp_deadline);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.rtxt_MoTa);
            this.Controls.Add(this.txt_DD);
            this.Controls.Add(this.txt_MaPB);
            this.Controls.Add(this.txt_TenDA);
            this.Controls.Add(this.txt_MaDA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gv_DuAn);
            this.Name = "FDuAn";
            this.Text = "DuAn";
            this.Load += new System.EventHandler(this.DuAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_DuAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_DuAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaDA;
        private System.Windows.Forms.TextBox txt_TenDA;
        private System.Windows.Forms.TextBox txt_MaPB;
        private System.Windows.Forms.TextBox txt_DD;
        private System.Windows.Forms.RichTextBox rtxt_MoTa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_deadline;
    }
}