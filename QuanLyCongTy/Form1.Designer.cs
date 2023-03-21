namespace QuanLyCongTy
{
    partial class Form1
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
            this.ucXemPhanCong1 = new QuanLyCongTy.UCXemPhanCong();
            this.SuspendLayout();
            // 
            // ucXemPhanCong1
            // 
            this.ucXemPhanCong1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ucXemPhanCong1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucXemPhanCong1.Location = new System.Drawing.Point(34, 28);
            this.ucXemPhanCong1.Name = "ucXemPhanCong1";
            this.ucXemPhanCong1.Size = new System.Drawing.Size(444, 180);
            this.ucXemPhanCong1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucXemPhanCong1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UCXemPhanCong ucXemPhanCong1;
    }
}