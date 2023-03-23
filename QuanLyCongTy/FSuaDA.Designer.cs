namespace QuanLyCongTy
{
    partial class FSuaDA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_TenDA = new System.Windows.Forms.Label();
            this.lbl_MoTa = new System.Windows.Forms.Label();
            this.txt_TenDA = new System.Windows.Forms.TextBox();
            this.gvPhongBanRanh = new System.Windows.Forms.DataGridView();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.dtp_DeadLine = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayBD = new System.Windows.Forms.DateTimePicker();
            this.cmb_TenPB = new System.Windows.Forms.ComboBox();
            this.lbl_DeadLine = new System.Windows.Forms.Label();
            this.lbl_NgayBD = new System.Windows.Forms.Label();
            this.lbl_DiaDiem = new System.Windows.Forms.Label();
            this.lbl_TenPB = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.TenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongBanRanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TenDA
            // 
            this.lbl_TenDA.AutoSize = true;
            this.lbl_TenDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDA.Location = new System.Drawing.Point(62, 79);
            this.lbl_TenDA.Name = "lbl_TenDA";
            this.lbl_TenDA.Size = new System.Drawing.Size(116, 29);
            this.lbl_TenDA.TabIndex = 1;
            this.lbl_TenDA.Text = "Tên dự án:";
            // 
            // lbl_MoTa
            // 
            this.lbl_MoTa.AutoSize = true;
            this.lbl_MoTa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoTa.Location = new System.Drawing.Point(62, 153);
            this.lbl_MoTa.Name = "lbl_MoTa";
            this.lbl_MoTa.Size = new System.Drawing.Size(78, 29);
            this.lbl_MoTa.TabIndex = 13;
            this.lbl_MoTa.Text = "Mô tả:";
            // 
            // txt_TenDA
            // 
            this.txt_TenDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TenDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDA.Location = new System.Drawing.Point(184, 79);
            this.txt_TenDA.Name = "txt_TenDA";
            this.txt_TenDA.Size = new System.Drawing.Size(419, 30);
            this.txt_TenDA.TabIndex = 15;
            // 
            // gvPhongBanRanh
            // 
            this.gvPhongBanRanh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPhongBanRanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.gvPhongBanRanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPhongBanRanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPB,
            this.Deadline,
            this.TinhTrang});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPhongBanRanh.DefaultCellStyle = dataGridViewCellStyle16;
            this.gvPhongBanRanh.Location = new System.Drawing.Point(665, 44);
            this.gvPhongBanRanh.Name = "gvPhongBanRanh";
            this.gvPhongBanRanh.RowHeadersVisible = false;
            this.gvPhongBanRanh.RowHeadersWidth = 62;
            this.gvPhongBanRanh.RowTemplate.Height = 28;
            this.gvPhongBanRanh.Size = new System.Drawing.Size(538, 601);
            this.gvPhongBanRanh.TabIndex = 16;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(369, 603);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(114, 42);
            this.btn_Sua.TabIndex = 17;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(489, 603);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(114, 42);
            this.btn_Huy.TabIndex = 18;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // dtp_DeadLine
            // 
            this.dtp_DeadLine.CalendarFont = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DeadLine.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DeadLine.Location = new System.Drawing.Point(258, 513);
            this.dtp_DeadLine.Name = "dtp_DeadLine";
            this.dtp_DeadLine.Size = new System.Drawing.Size(344, 32);
            this.dtp_DeadLine.TabIndex = 28;
            // 
            // dtp_NgayBD
            // 
            this.dtp_NgayBD.CalendarFont = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayBD.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayBD.Location = new System.Drawing.Point(260, 450);
            this.dtp_NgayBD.Name = "dtp_NgayBD";
            this.dtp_NgayBD.Size = new System.Drawing.Size(343, 32);
            this.dtp_NgayBD.TabIndex = 27;
            // 
            // cmb_TenPB
            // 
            this.cmb_TenPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_TenPB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TenPB.FormattingEnabled = true;
            this.cmb_TenPB.Location = new System.Drawing.Point(259, 326);
            this.cmb_TenPB.Name = "cmb_TenPB";
            this.cmb_TenPB.Size = new System.Drawing.Size(343, 37);
            this.cmb_TenPB.TabIndex = 25;
            // 
            // lbl_DeadLine
            // 
            this.lbl_DeadLine.AutoSize = true;
            this.lbl_DeadLine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DeadLine.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeadLine.Location = new System.Drawing.Point(62, 513);
            this.lbl_DeadLine.Name = "lbl_DeadLine";
            this.lbl_DeadLine.Size = new System.Drawing.Size(107, 29);
            this.lbl_DeadLine.TabIndex = 23;
            this.lbl_DeadLine.Text = "Thời hạn:";
            // 
            // lbl_NgayBD
            // 
            this.lbl_NgayBD.AutoSize = true;
            this.lbl_NgayBD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NgayBD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayBD.Location = new System.Drawing.Point(62, 453);
            this.lbl_NgayBD.Name = "lbl_NgayBD";
            this.lbl_NgayBD.Size = new System.Drawing.Size(150, 29);
            this.lbl_NgayBD.TabIndex = 22;
            this.lbl_NgayBD.Text = "Ngày bắt đầu:";
            // 
            // lbl_DiaDiem
            // 
            this.lbl_DiaDiem.AutoSize = true;
            this.lbl_DiaDiem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaDiem.Location = new System.Drawing.Point(62, 390);
            this.lbl_DiaDiem.Name = "lbl_DiaDiem";
            this.lbl_DiaDiem.Size = new System.Drawing.Size(107, 29);
            this.lbl_DiaDiem.TabIndex = 21;
            this.lbl_DiaDiem.Text = "Địa điểm:";
            // 
            // lbl_TenPB
            // 
            this.lbl_TenPB.AutoSize = true;
            this.lbl_TenPB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenPB.Location = new System.Drawing.Point(62, 334);
            this.lbl_TenPB.Name = "lbl_TenPB";
            this.lbl_TenPB.Size = new System.Drawing.Size(170, 29);
            this.lbl_TenPB.TabIndex = 20;
            this.lbl_TenPB.Text = "Tên phòng ban: ";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaDiem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaDiem.Location = new System.Drawing.Point(259, 386);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(343, 30);
            this.txtDiaDiem.TabIndex = 29;
            // 
            // TenPB
            // 
            this.TenPB.DataPropertyName = "TenPB";
            this.TenPB.Frozen = true;
            this.TenPB.HeaderText = "Tên phòng ban";
            this.TenPB.MinimumWidth = 8;
            this.TenPB.Name = "TenPB";
            this.TenPB.ReadOnly = true;
            this.TenPB.Width = 150;
            // 
            // Deadline
            // 
            this.Deadline.DataPropertyName = "DL";
            this.Deadline.Frozen = true;
            this.Deadline.HeaderText = "Thời hạn";
            this.Deadline.MinimumWidth = 8;
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.Frozen = true;
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 8;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            this.TinhTrang.Width = 120;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyCongTy.Properties.Resources.Picture3;
            this.pictureBox1.Location = new System.Drawing.Point(26, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MoTa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MoTa.Location = new System.Drawing.Point(67, 185);
            this.txt_MoTa.Multiline = true;
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(536, 88);
            this.txt_MoTa.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "___________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "____________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "____________________________";
            // 
            // FSuaDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1231, 693);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_TenPB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TenDA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MoTa);
            this.Controls.Add(this.dtp_DeadLine);
            this.Controls.Add(this.dtp_NgayBD);
            this.Controls.Add(this.lbl_DeadLine);
            this.Controls.Add(this.lbl_NgayBD);
            this.Controls.Add(this.lbl_DiaDiem);
            this.Controls.Add(this.lbl_TenPB);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.lbl_MoTa);
            this.Controls.Add(this.lbl_TenDA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gvPhongBanRanh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSuaDA";
            this.Text = "FSuaDA";
            this.Load += new System.EventHandler(this.FSuaDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongBanRanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_TenDA;
        private System.Windows.Forms.Label lbl_MoTa;
        private System.Windows.Forms.TextBox txt_TenDA;
        private System.Windows.Forms.DataGridView gvPhongBanRanh;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.DateTimePicker dtp_DeadLine;
        private System.Windows.Forms.DateTimePicker dtp_NgayBD;
        private System.Windows.Forms.ComboBox cmb_TenPB;
        private System.Windows.Forms.Label lbl_DeadLine;
        private System.Windows.Forms.Label lbl_NgayBD;
        private System.Windows.Forms.Label lbl_DiaDiem;
        private System.Windows.Forms.Label lbl_TenPB;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_MoTa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}