namespace QuanLyCongTy
{
    partial class UCSailorStar
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
            this.pgb_TDDA = new System.Windows.Forms.ProgressBar();
            this.lbl_TenPhong = new System.Windows.Forms.Label();
            this.lbl_tenDA = new System.Windows.Forms.Label();
            this.flpNgoiSao = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pgb_TDDA
            // 
            this.pgb_TDDA.Location = new System.Drawing.Point(29, 111);
            this.pgb_TDDA.Name = "pgb_TDDA";
            this.pgb_TDDA.Size = new System.Drawing.Size(580, 10);
            this.pgb_TDDA.TabIndex = 20;
            // 
            // lbl_TenPhong
            // 
            this.lbl_TenPhong.AutoSize = true;
            this.lbl_TenPhong.Location = new System.Drawing.Point(25, 66);
            this.lbl_TenPhong.Name = "lbl_TenPhong";
            this.lbl_TenPhong.Size = new System.Drawing.Size(85, 20);
            this.lbl_TenPhong.TabIndex = 19;
            this.lbl_TenPhong.Text = "Tên phòng";
            // 
            // lbl_tenDA
            // 
            this.lbl_tenDA.AutoSize = true;
            this.lbl_tenDA.Location = new System.Drawing.Point(25, 27);
            this.lbl_tenDA.Name = "lbl_tenDA";
            this.lbl_tenDA.Size = new System.Drawing.Size(80, 20);
            this.lbl_tenDA.TabIndex = 18;
            this.lbl_tenDA.Text = "Tên dự án";
            // 
            // flpNgoiSao
            // 
            this.flpNgoiSao.Location = new System.Drawing.Point(29, 135);
            this.flpNgoiSao.Margin = new System.Windows.Forms.Padding(0);
            this.flpNgoiSao.Name = "flpNgoiSao";
            this.flpNgoiSao.Size = new System.Drawing.Size(580, 40);
            this.flpNgoiSao.TabIndex = 21;
            // 
            // UCSailorStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pgb_TDDA);
            this.Controls.Add(this.lbl_TenPhong);
            this.Controls.Add(this.lbl_tenDA);
            this.Controls.Add(this.flpNgoiSao);
            this.Name = "UCSailorStar";
            this.Size = new System.Drawing.Size(648, 198);
            this.Load += new System.EventHandler(this.UCSailorStar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar pgb_TDDA;
        private System.Windows.Forms.Label lbl_TenPhong;
        private System.Windows.Forms.Label lbl_tenDA;
        private System.Windows.Forms.FlowLayoutPanel flpNgoiSao;
    }
}
