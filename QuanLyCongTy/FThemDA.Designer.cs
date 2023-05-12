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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbLoaiPB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDA = new System.Windows.Forms.Label();
            this.gvPhongBanRanh = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.dtpDeadline = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpNgayBD = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbTenPB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_TenDA = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lbl_MoTa = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Shapes2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.txtDiaDiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.txtTenDA = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_DeadLine = new System.Windows.Forms.Label();
            this.lbl_NgayBD = new System.Windows.Forms.Label();
            this.lbl_DiaDiem = new System.Windows.Forms.Label();
            this.lbl_TenPB = new System.Windows.Forms.Label();
            this.lblMaDA = new System.Windows.Forms.Label();
            this.guna2Shapes3 = new Guna.UI2.WinForms.Guna2Shapes();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongBanRanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.FillWeight = 81.81828F;
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 8;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // TenPB
            // 
            this.TenPB.DataPropertyName = "TenPB";
            this.TenPB.FillWeight = 136.3637F;
            this.TenPB.HeaderText = "Tên phòng ban";
            this.TenPB.MinimumWidth = 8;
            this.TenPB.Name = "TenPB";
            this.TenPB.ReadOnly = true;
            // 
            // cmbLoaiPB
            // 
            this.cmbLoaiPB.BackColor = System.Drawing.Color.Transparent;
            this.cmbLoaiPB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.cmbLoaiPB.BorderRadius = 10;
            this.cmbLoaiPB.BorderThickness = 2;
            this.cmbLoaiPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbLoaiPB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaiPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiPB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiPB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiPB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLoaiPB.ForeColor = System.Drawing.Color.Black;
            this.cmbLoaiPB.ItemHeight = 30;
            this.cmbLoaiPB.Location = new System.Drawing.Point(276, 383);
            this.cmbLoaiPB.Name = "cmbLoaiPB";
            this.cmbLoaiPB.Size = new System.Drawing.Size(376, 36);
            this.cmbLoaiPB.TabIndex = 133;
            this.cmbLoaiPB.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiPB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 132;
            this.label2.Text = "Loại phòng ban:";
            // 
            // Deadline
            // 
            this.Deadline.DataPropertyName = "DL";
            this.Deadline.FillWeight = 81.81828F;
            this.Deadline.HeaderText = "Thời hạn";
            this.Deadline.MinimumWidth = 8;
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            // 
            // MaDA
            // 
            this.MaDA.AutoSize = true;
            this.MaDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDA.Location = new System.Drawing.Point(105, 75);
            this.MaDA.Name = "MaDA";
            this.MaDA.Size = new System.Drawing.Size(114, 29);
            this.MaDA.TabIndex = 129;
            this.MaDA.Text = "Mã dự án:";
            // 
            // gvPhongBanRanh
            // 
            this.gvPhongBanRanh.AllowUserToAddRows = false;
            this.gvPhongBanRanh.AllowUserToDeleteRows = false;
            this.gvPhongBanRanh.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvPhongBanRanh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(70)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(70)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPhongBanRanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gvPhongBanRanh.ColumnHeadersHeight = 50;
            this.gvPhongBanRanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvPhongBanRanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPB,
            this.Deadline,
            this.TinhTrang});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPhongBanRanh.DefaultCellStyle = dataGridViewCellStyle15;
            this.gvPhongBanRanh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvPhongBanRanh.Location = new System.Drawing.Point(723, 75);
            this.gvPhongBanRanh.Name = "gvPhongBanRanh";
            this.gvPhongBanRanh.ReadOnly = true;
            this.gvPhongBanRanh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPhongBanRanh.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.gvPhongBanRanh.RowHeadersVisible = false;
            this.gvPhongBanRanh.RowHeadersWidth = 62;
            this.gvPhongBanRanh.RowTemplate.Height = 28;
            this.gvPhongBanRanh.Size = new System.Drawing.Size(578, 558);
            this.gvPhongBanRanh.TabIndex = 128;
            this.gvPhongBanRanh.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvPhongBanRanh.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhongBanRanh.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvPhongBanRanh.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvPhongBanRanh.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvPhongBanRanh.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvPhongBanRanh.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.Height = 50;
            this.gvPhongBanRanh.ThemeStyle.ReadOnly = true;
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.Height = 28;
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyCongTy.Properties.Resources.add_button__1_;
            this.pictureBox1.Location = new System.Drawing.Point(176, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.TabIndex = 127;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 70);
            this.label1.TabIndex = 126;
            this.label1.Text = "Tạo dự án     \r\n\r\n";
            // 
            // btnHuy
            // 
            this.btnHuy.Animated = true;
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(177)))), ((int)(((byte)(184)))));
            this.btnHuy.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(512, 758);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(140, 54);
            this.btnHuy.TabIndex = 125;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Animated = true;
            this.btnThem.BorderRadius = 10;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(177)))), ((int)(((byte)(184)))));
            this.btnThem.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(366, 758);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 54);
            this.btnThem.TabIndex = 124;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Animated = true;
            this.dtpDeadline.BackColor = System.Drawing.Color.Transparent;
            this.dtpDeadline.BorderRadius = 10;
            this.dtpDeadline.Checked = true;
            this.dtpDeadline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDeadline.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.dtpDeadline.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeadline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDeadline.IndicateFocus = true;
            this.dtpDeadline.Location = new System.Drawing.Point(276, 683);
            this.dtpDeadline.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDeadline.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(376, 52);
            this.dtpDeadline.TabIndex = 123;
            this.dtpDeadline.UseTransparentBackground = true;
            this.dtpDeadline.Value = new System.DateTime(2023, 5, 11, 0, 25, 48, 267);
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Animated = true;
            this.dtpNgayBD.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgayBD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.dtpNgayBD.BorderRadius = 10;
            this.dtpNgayBD.BorderThickness = 3;
            this.dtpNgayBD.Checked = true;
            this.dtpNgayBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgayBD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.dtpNgayBD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayBD.Location = new System.Drawing.Point(276, 606);
            this.dtpNgayBD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(376, 52);
            this.dtpNgayBD.TabIndex = 122;
            this.dtpNgayBD.Value = new System.DateTime(2023, 5, 11, 0, 25, 48, 267);
            // 
            // cmbTenPB
            // 
            this.cmbTenPB.BackColor = System.Drawing.Color.Transparent;
            this.cmbTenPB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.cmbTenPB.BorderRadius = 10;
            this.cmbTenPB.BorderThickness = 2;
            this.cmbTenPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTenPB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenPB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenPB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenPB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTenPB.ForeColor = System.Drawing.Color.Black;
            this.cmbTenPB.ItemHeight = 30;
            this.cmbTenPB.Location = new System.Drawing.Point(276, 462);
            this.cmbTenPB.Name = "cmbTenPB";
            this.cmbTenPB.Size = new System.Drawing.Size(376, 36);
            this.cmbTenPB.TabIndex = 121;
            // 
            // lbl_TenDA
            // 
            this.lbl_TenDA.AutoSize = true;
            this.lbl_TenDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDA.Location = new System.Drawing.Point(105, 137);
            this.lbl_TenDA.Name = "lbl_TenDA";
            this.lbl_TenDA.Size = new System.Drawing.Size(116, 29);
            this.lbl_TenDA.TabIndex = 109;
            this.lbl_TenDA.Text = "Tên dự án:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoTa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(118, 233);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(525, 107);
            this.txtMoTa.TabIndex = 115;
            // 
            // lbl_MoTa
            // 
            this.lbl_MoTa.AutoSize = true;
            this.lbl_MoTa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoTa.Location = new System.Drawing.Point(134, 201);
            this.lbl_MoTa.Name = "lbl_MoTa";
            this.lbl_MoTa.Size = new System.Drawing.Size(78, 29);
            this.lbl_MoTa.TabIndex = 110;
            this.lbl_MoTa.Text = "Mô tả:";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.guna2TextBox1.BorderRadius = 15;
            this.guna2TextBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2TextBox1.BorderThickness = 2;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(110, 216);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(542, 137);
            this.guna2TextBox1.TabIndex = 120;
            // 
            // guna2Shapes2
            // 
            this.guna2Shapes2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Shapes2.BorderThickness = 0;
            this.guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.guna2Shapes2.LineEndCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
            this.guna2Shapes2.LineStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2Shapes2.LineThickness = 2;
            this.guna2Shapes2.Location = new System.Drawing.Point(267, 565);
            this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.PolygonSkip = 1;
            this.guna2Shapes2.Rotate = 0F;
            this.guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes2.Size = new System.Drawing.Size(382, 15);
            this.guna2Shapes2.TabIndex = 119;
            this.guna2Shapes2.Text = "guna2Shapes2";
            this.guna2Shapes2.UseTransparentBackground = true;
            this.guna2Shapes2.Zoom = 90;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Animated = true;
            this.txtDiaDiem.BorderColor = System.Drawing.Color.White;
            this.txtDiaDiem.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtDiaDiem.BorderThickness = 0;
            this.txtDiaDiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaDiem.DefaultText = "";
            this.txtDiaDiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaDiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaDiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaDiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiaDiem.ForeColor = System.Drawing.Color.Black;
            this.txtDiaDiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaDiem.Location = new System.Drawing.Point(270, 528);
            this.txtDiaDiem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.PasswordChar = '\0';
            this.txtDiaDiem.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDiaDiem.PlaceholderText = "";
            this.txtDiaDiem.SelectedText = "";
            this.txtDiaDiem.Size = new System.Drawing.Size(382, 50);
            this.txtDiaDiem.TabIndex = 118;
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Shapes1.BorderThickness = 0;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.guna2Shapes1.LineEndCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
            this.guna2Shapes1.LineStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2Shapes1.LineThickness = 2;
            this.guna2Shapes1.Location = new System.Drawing.Point(212, 163);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(437, 14);
            this.guna2Shapes1.TabIndex = 117;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.UseTransparentBackground = true;
            this.guna2Shapes1.Zoom = 90;
            // 
            // txtTenDA
            // 
            this.txtTenDA.Animated = true;
            this.txtTenDA.BorderColor = System.Drawing.Color.White;
            this.txtTenDA.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtTenDA.BorderThickness = 0;
            this.txtTenDA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDA.DefaultText = "";
            this.txtTenDA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDA.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenDA.ForeColor = System.Drawing.Color.Black;
            this.txtTenDA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDA.Location = new System.Drawing.Point(215, 127);
            this.txtTenDA.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenDA.Name = "txtTenDA";
            this.txtTenDA.PasswordChar = '\0';
            this.txtTenDA.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTenDA.PlaceholderText = "";
            this.txtTenDA.SelectedText = "";
            this.txtTenDA.Size = new System.Drawing.Size(437, 50);
            this.txtTenDA.TabIndex = 116;
            // 
            // lbl_DeadLine
            // 
            this.lbl_DeadLine.AutoSize = true;
            this.lbl_DeadLine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DeadLine.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeadLine.Location = new System.Drawing.Point(105, 693);
            this.lbl_DeadLine.Name = "lbl_DeadLine";
            this.lbl_DeadLine.Size = new System.Drawing.Size(107, 29);
            this.lbl_DeadLine.TabIndex = 114;
            this.lbl_DeadLine.Text = "Thời hạn:";
            // 
            // lbl_NgayBD
            // 
            this.lbl_NgayBD.AutoSize = true;
            this.lbl_NgayBD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NgayBD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayBD.Location = new System.Drawing.Point(102, 617);
            this.lbl_NgayBD.Name = "lbl_NgayBD";
            this.lbl_NgayBD.Size = new System.Drawing.Size(150, 29);
            this.lbl_NgayBD.TabIndex = 113;
            this.lbl_NgayBD.Text = "Ngày bắt đầu:";
            // 
            // lbl_DiaDiem
            // 
            this.lbl_DiaDiem.AutoSize = true;
            this.lbl_DiaDiem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaDiem.Location = new System.Drawing.Point(105, 543);
            this.lbl_DiaDiem.Name = "lbl_DiaDiem";
            this.lbl_DiaDiem.Size = new System.Drawing.Size(107, 29);
            this.lbl_DiaDiem.TabIndex = 112;
            this.lbl_DiaDiem.Text = "Địa điểm:";
            // 
            // lbl_TenPB
            // 
            this.lbl_TenPB.AutoSize = true;
            this.lbl_TenPB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenPB.Location = new System.Drawing.Point(102, 469);
            this.lbl_TenPB.Name = "lbl_TenPB";
            this.lbl_TenPB.Size = new System.Drawing.Size(170, 29);
            this.lbl_TenPB.TabIndex = 111;
            this.lbl_TenPB.Text = "Tên phòng ban: ";
            // 
            // lblMaDA
            // 
            this.lblMaDA.AutoSize = true;
            this.lblMaDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMaDA.Location = new System.Drawing.Point(238, 75);
            this.lblMaDA.Name = "lblMaDA";
            this.lblMaDA.Size = new System.Drawing.Size(74, 29);
            this.lblMaDA.TabIndex = 134;
            this.lblMaDA.Text = "label3";
            // 
            // guna2Shapes3
            // 
            this.guna2Shapes3.BorderThickness = 3;
            this.guna2Shapes3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Shapes3.FillColor = System.Drawing.Color.White;
            this.guna2Shapes3.Location = new System.Drawing.Point(0, 0);
            this.guna2Shapes3.Name = "guna2Shapes3";
            this.guna2Shapes3.PolygonSkip = 1;
            this.guna2Shapes3.Rotate = 0F;
            this.guna2Shapes3.RoundedRadius = 2;
            this.guna2Shapes3.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.guna2Shapes3.Size = new System.Drawing.Size(1373, 862);
            this.guna2Shapes3.TabIndex = 135;
            this.guna2Shapes3.Text = "guna2Shapes3";
            this.guna2Shapes3.Zoom = 100;
            // 
            // FThemDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1373, 862);
            this.Controls.Add(this.lblMaDA);
            this.Controls.Add(this.cmbLoaiPB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaDA);
            this.Controls.Add(this.gvPhongBanRanh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.cmbTenPB);
            this.Controls.Add(this.lbl_TenDA);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.lbl_MoTa);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2Shapes2);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.guna2Shapes1);
            this.Controls.Add(this.txtTenDA);
            this.Controls.Add(this.lbl_DeadLine);
            this.Controls.Add(this.lbl_NgayBD);
            this.Controls.Add(this.lbl_DiaDiem);
            this.Controls.Add(this.lbl_TenPB);
            this.Controls.Add(this.guna2Shapes3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FThemDA";
            this.Text = "FThemDA";
            this.Load += new System.EventHandler(this.FThemDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongBanRanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPB;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLoaiPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.Label MaDA;
        private Guna.UI2.WinForms.Guna2DataGridView gvPhongBanRanh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDeadline;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayBD;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTenPB;
        private System.Windows.Forms.Label lbl_TenDA;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lbl_MoTa;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaDiem;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDA;
        private System.Windows.Forms.Label lbl_DeadLine;
        private System.Windows.Forms.Label lbl_NgayBD;
        private System.Windows.Forms.Label lbl_DiaDiem;
        private System.Windows.Forms.Label lbl_TenPB;
        private System.Windows.Forms.Label lblMaDA;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes3;
    }
}