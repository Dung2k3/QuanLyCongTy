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
            this.ucMenuBtn5 = new QuanLyCongTy.ucMenuBtn();
            this.ucMenuBtn4 = new QuanLyCongTy.ucMenuBtn();
            this.ucMenuBtn3 = new QuanLyCongTy.ucMenuBtn();
            this.ucMenuBtn2 = new QuanLyCongTy.ucMenuBtn();
            this.ucMenuBtn1 = new QuanLyCongTy.ucMenuBtn();
            this.uc = new QuanLyCongTy.UC();
            this.SuspendLayout();
            // 
            // ucMenuBtn5
            // 
            this.ucMenuBtn5.Location = new System.Drawing.Point(0, 402);
            this.ucMenuBtn5.Name = "ucMenuBtn5";
            this.ucMenuBtn5.Size = new System.Drawing.Size(250, 70);
            this.ucMenuBtn5.TabIndex = 5;
            // 
            // ucMenuBtn4
            // 
            this.ucMenuBtn4.Location = new System.Drawing.Point(0, 326);
            this.ucMenuBtn4.Name = "ucMenuBtn4";
            this.ucMenuBtn4.Size = new System.Drawing.Size(250, 70);
            this.ucMenuBtn4.TabIndex = 4;
            // 
            // ucMenuBtn3
            // 
            this.ucMenuBtn3.Location = new System.Drawing.Point(0, 174);
            this.ucMenuBtn3.Name = "ucMenuBtn3";
            this.ucMenuBtn3.Size = new System.Drawing.Size(250, 70);
            this.ucMenuBtn3.TabIndex = 3;
            // 
            // ucMenuBtn2
            // 
            this.ucMenuBtn2.Location = new System.Drawing.Point(0, 250);
            this.ucMenuBtn2.Name = "ucMenuBtn2";
            this.ucMenuBtn2.Size = new System.Drawing.Size(250, 70);
            this.ucMenuBtn2.TabIndex = 2;
            // 
            // ucMenuBtn1
            // 
            this.ucMenuBtn1.Location = new System.Drawing.Point(0, 98);
            this.ucMenuBtn1.Name = "ucMenuBtn1";
            this.ucMenuBtn1.Size = new System.Drawing.Size(250, 70);
            this.ucMenuBtn1.TabIndex = 1;
            // 
            // uc
            // 
            this.uc.Location = new System.Drawing.Point(0, 0);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(1942, 800);
            this.uc.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 800);
            this.Controls.Add(this.ucMenuBtn5);
            this.Controls.Add(this.ucMenuBtn4);
            this.Controls.Add(this.ucMenuBtn3);
            this.Controls.Add(this.ucMenuBtn2);
            this.Controls.Add(this.ucMenuBtn1);
            this.Controls.Add(this.uc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UC uc;
        private ucMenuBtn ucMenuBtn1;
        private ucMenuBtn ucMenuBtn2;
        private ucMenuBtn ucMenuBtn3;
        private ucMenuBtn ucMenuBtn4;
        private ucMenuBtn ucMenuBtn5;
    }
}