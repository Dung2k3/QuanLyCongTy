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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDanhGiaDA));
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txt_MaDA
            // 
            resources.ApplyResources(this.txt_MaDA, "txt_MaDA");
            this.txt_MaDA.Name = "txt_MaDA";
            // 
            // txt_Thuong
            // 
            resources.ApplyResources(this.txt_Thuong, "txt_Thuong");
            this.txt_Thuong.Name = "txt_Thuong";
            // 
            // txt_TenDA
            // 
            resources.ApplyResources(this.txt_TenDA, "txt_TenDA");
            this.txt_TenDA.Name = "txt_TenDA";
            // 
            // rtxt_NhanXet
            // 
            resources.ApplyResources(this.rtxt_NhanXet, "rtxt_NhanXet");
            this.rtxt_NhanXet.Name = "rtxt_NhanXet";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // gv_DanhGiaDA
            // 
            resources.ApplyResources(this.gv_DanhGiaDA, "gv_DanhGiaDA");
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
            this.gv_DanhGiaDA.Name = "gv_DanhGiaDA";
            this.gv_DanhGiaDA.RowHeadersVisible = false;
            this.gv_DanhGiaDA.RowTemplate.Height = 28;
            this.gv_DanhGiaDA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gv_DanhGiaDA_MouseClick);
            // 
            // MaDA
            // 
            this.MaDA.DataPropertyName = "MaDA";
            resources.ApplyResources(this.MaDA, "MaDA");
            this.MaDA.Name = "MaDA";
            this.MaDA.ReadOnly = true;
            // 
            // TenDuAn
            // 
            this.TenDuAn.DataPropertyName = "TenDuAn";
            resources.ApplyResources(this.TenDuAn, "TenDuAn");
            this.TenDuAn.Name = "TenDuAn";
            this.TenDuAn.ReadOnly = true;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            resources.ApplyResources(this.MoTa, "MoTa");
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            // 
            // MaPB
            // 
            this.MaPB.DataPropertyName = "maPB";
            resources.ApplyResources(this.MaPB, "MaPB");
            this.MaPB.Name = "MaPB";
            this.MaPB.ReadOnly = true;
            // 
            // DiaDiem
            // 
            this.DiaDiem.DataPropertyName = "DiaDiem";
            resources.ApplyResources(this.DiaDiem, "DiaDiem");
            this.DiaDiem.Name = "DiaDiem";
            this.DiaDiem.ReadOnly = true;
            // 
            // DeadLine
            // 
            this.DeadLine.DataPropertyName = "DeadLine";
            resources.ApplyResources(this.DeadLine, "DeadLine");
            this.DeadLine.Name = "DeadLine";
            this.DeadLine.ReadOnly = true;
            // 
            // Thuong
            // 
            this.Thuong.DataPropertyName = "Thuong";
            resources.ApplyResources(this.Thuong, "Thuong");
            this.Thuong.Name = "Thuong";
            this.Thuong.ReadOnly = true;
            // 
            // btn_Sua
            // 
            resources.ApplyResources(this.btn_Sua, "btn_Sua");
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            resources.ApplyResources(this.btn_Xoa, "btn_Xoa");
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            resources.ApplyResources(this.btn_Them, "btn_Them");
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // FDanhGiaDA
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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