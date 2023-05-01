namespace QuanLyCongTy
{
    partial class UCNgay
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
            this.lblDay = new System.Windows.Forms.Label();
            this.lbldl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(17, 15);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(34, 20);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "day";
            // 
            // lbldl
            // 
            this.lbldl.AutoSize = true;
            this.lbldl.Location = new System.Drawing.Point(27, 56);
            this.lbldl.Name = "lbldl";
            this.lbldl.Size = new System.Drawing.Size(13, 20);
            this.lbldl.TabIndex = 1;
            this.lbldl.Text = " ";
            // 
            // UCNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbldl);
            this.Controls.Add(this.lblDay);
            this.Name = "UCNgay";
            this.Size = new System.Drawing.Size(150, 100);
            this.Load += new System.EventHandler(this.UCNgay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lbldl;
    }
}
