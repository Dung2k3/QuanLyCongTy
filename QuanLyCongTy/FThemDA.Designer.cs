namespace QuanLyCongTy
{
    partial class FThemDA
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
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.dtp_DeadLine = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayBD = new System.Windows.Forms.DateTimePicker();
            this.cmb_TenPB = new System.Windows.Forms.ComboBox();
            this.lbl_DeadLine = new System.Windows.Forms.Label();
            this.lbl_NgayBD = new System.Windows.Forms.Label();
            this.lbl_DiaDiem = new System.Windows.Forms.Label();
            this.lbl_TenPB = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_TenDA = new System.Windows.Forms.TextBox();
            this.rtxt_MoTa = new System.Windows.Forms.RichTextBox();
            this.lbl_MoTa = new System.Windows.Forms.Label();
            this.txt_MaDA = new System.Windows.Forms.TextBox();
            this.lbl_TenDA = new System.Windows.Forms.Label();
            this.lbl_MaDA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_TenLPB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(182, 448);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(295, 26);
            this.txtDiaDiem.TabIndex = 46;
            // 
            // dtp_DeadLine
            // 
            this.dtp_DeadLine.Location = new System.Drawing.Point(182, 553);
            this.dtp_DeadLine.Name = "dtp_DeadLine";
            this.dtp_DeadLine.Size = new System.Drawing.Size(296, 26);
            this.dtp_DeadLine.TabIndex = 45;
            // 
            // dtp_NgayBD
            // 
            this.dtp_NgayBD.Location = new System.Drawing.Point(182, 500);
            this.dtp_NgayBD.Name = "dtp_NgayBD";
            this.dtp_NgayBD.Size = new System.Drawing.Size(296, 26);
            this.dtp_NgayBD.TabIndex = 44;
            // 
            // cmb_TenPB
            // 
            this.cmb_TenPB.FormattingEnabled = true;
            this.cmb_TenPB.Location = new System.Drawing.Point(182, 393);
            this.cmb_TenPB.Name = "cmb_TenPB";
            this.cmb_TenPB.Size = new System.Drawing.Size(296, 28);
            this.cmb_TenPB.TabIndex = 43;
            // 
            // lbl_DeadLine
            // 
            this.lbl_DeadLine.AutoSize = true;
            this.lbl_DeadLine.Location = new System.Drawing.Point(28, 554);
            this.lbl_DeadLine.Name = "lbl_DeadLine";
            this.lbl_DeadLine.Size = new System.Drawing.Size(74, 20);
            this.lbl_DeadLine.TabIndex = 42;
            this.lbl_DeadLine.Text = "Thời hạn:";
            // 
            // lbl_NgayBD
            // 
            this.lbl_NgayBD.AutoSize = true;
            this.lbl_NgayBD.Location = new System.Drawing.Point(27, 500);
            this.lbl_NgayBD.Name = "lbl_NgayBD";
            this.lbl_NgayBD.Size = new System.Drawing.Size(107, 20);
            this.lbl_NgayBD.TabIndex = 41;
            this.lbl_NgayBD.Text = "Ngày bắt đầu:";
            // 
            // lbl_DiaDiem
            // 
            this.lbl_DiaDiem.AutoSize = true;
            this.lbl_DiaDiem.Location = new System.Drawing.Point(27, 449);
            this.lbl_DiaDiem.Name = "lbl_DiaDiem";
            this.lbl_DiaDiem.Size = new System.Drawing.Size(75, 20);
            this.lbl_DiaDiem.TabIndex = 40;
            this.lbl_DiaDiem.Text = "Địa điểm:";
            // 
            // lbl_TenPB
            // 
            this.lbl_TenPB.AutoSize = true;
            this.lbl_TenPB.Location = new System.Drawing.Point(28, 396);
            this.lbl_TenPB.Name = "lbl_TenPB";
            this.lbl_TenPB.Size = new System.Drawing.Size(124, 20);
            this.lbl_TenPB.TabIndex = 39;
            this.lbl_TenPB.Text = "Tên phòng ban: ";
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(363, 604);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(114, 42);
            this.btn_Huy.TabIndex = 38;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(241, 604);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(114, 42);
            this.btn_Them.TabIndex = 37;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(508, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(737, 634);
            this.dataGridView1.TabIndex = 36;
            // 
            // txt_TenDA
            // 
            this.txt_TenDA.Location = new System.Drawing.Point(183, 73);
            this.txt_TenDA.Name = "txt_TenDA";
            this.txt_TenDA.Size = new System.Drawing.Size(296, 26);
            this.txt_TenDA.TabIndex = 35;
            // 
            // rtxt_MoTa
            // 
            this.rtxt_MoTa.Location = new System.Drawing.Point(33, 157);
            this.rtxt_MoTa.Name = "rtxt_MoTa";
            this.rtxt_MoTa.Size = new System.Drawing.Size(445, 124);
            this.rtxt_MoTa.TabIndex = 34;
            this.rtxt_MoTa.Text = "";
            // 
            // lbl_MoTa
            // 
            this.lbl_MoTa.AutoSize = true;
            this.lbl_MoTa.Location = new System.Drawing.Point(29, 134);
            this.lbl_MoTa.Name = "lbl_MoTa";
            this.lbl_MoTa.Size = new System.Drawing.Size(53, 20);
            this.lbl_MoTa.TabIndex = 33;
            this.lbl_MoTa.Text = "Mô tả:";
            // 
            // txt_MaDA
            // 
            this.txt_MaDA.Location = new System.Drawing.Point(183, 19);
            this.txt_MaDA.Name = "txt_MaDA";
            this.txt_MaDA.Size = new System.Drawing.Size(296, 26);
            this.txt_MaDA.TabIndex = 32;
            // 
            // lbl_TenDA
            // 
            this.lbl_TenDA.AutoSize = true;
            this.lbl_TenDA.Location = new System.Drawing.Point(28, 79);
            this.lbl_TenDA.Name = "lbl_TenDA";
            this.lbl_TenDA.Size = new System.Drawing.Size(84, 20);
            this.lbl_TenDA.TabIndex = 31;
            this.lbl_TenDA.Text = "Tên dự án:";
            // 
            // lbl_MaDA
            // 
            this.lbl_MaDA.AutoSize = true;
            this.lbl_MaDA.Location = new System.Drawing.Point(28, 25);
            this.lbl_MaDA.Name = "lbl_MaDA";
            this.lbl_MaDA.Size = new System.Drawing.Size(79, 20);
            this.lbl_MaDA.TabIndex = 30;
            this.lbl_MaDA.Text = "Mã dự án:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Loại phòng ban:\r\n";
            // 
            // cmb_TenLPB
            // 
            this.cmb_TenLPB.FormattingEnabled = true;
            this.cmb_TenLPB.Location = new System.Drawing.Point(182, 345);
            this.cmb_TenLPB.Name = "cmb_TenLPB";
            this.cmb_TenLPB.Size = new System.Drawing.Size(296, 28);
            this.cmb_TenLPB.TabIndex = 48;
            this.cmb_TenLPB.SelectedIndexChanged += new System.EventHandler(this.cmb_TenLPB_SelectedIndexChanged);
            // 
            // FThemDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 744);
            this.Controls.Add(this.cmb_TenLPB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.dtp_DeadLine);
            this.Controls.Add(this.dtp_NgayBD);
            this.Controls.Add(this.cmb_TenPB);
            this.Controls.Add(this.lbl_DeadLine);
            this.Controls.Add(this.lbl_NgayBD);
            this.Controls.Add(this.lbl_DiaDiem);
            this.Controls.Add(this.lbl_TenPB);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_TenDA);
            this.Controls.Add(this.rtxt_MoTa);
            this.Controls.Add(this.lbl_MoTa);
            this.Controls.Add(this.txt_MaDA);
            this.Controls.Add(this.lbl_TenDA);
            this.Controls.Add(this.lbl_MaDA);
            this.Name = "FThemDA";
            this.Text = "FThemDA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.DateTimePicker dtp_DeadLine;
        private System.Windows.Forms.DateTimePicker dtp_NgayBD;
        private System.Windows.Forms.ComboBox cmb_TenPB;
        private System.Windows.Forms.Label lbl_DeadLine;
        private System.Windows.Forms.Label lbl_NgayBD;
        private System.Windows.Forms.Label lbl_DiaDiem;
        private System.Windows.Forms.Label lbl_TenPB;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_TenDA;
        private System.Windows.Forms.RichTextBox rtxt_MoTa;
        private System.Windows.Forms.Label lbl_MoTa;
        private System.Windows.Forms.TextBox txt_MaDA;
        private System.Windows.Forms.Label lbl_TenDA;
        private System.Windows.Forms.Label lbl_MaDA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_TenLPB;
    }
}