namespace QuanLyCongTy
{
    partial class ucMenuBtn
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
            this.btn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BorderRadius = 20;
            this.btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn.FillColor = System.Drawing.Color.White;
            this.btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn.ForeColor = System.Drawing.Color.Navy;
            this.btn.Image = global::QuanLyCongTy.Properties.Resources.pencil__2_;
            this.btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn.ImageSize = new System.Drawing.Size(35, 35);
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(250, 70);
            this.btn.TabIndex = 31;
            this.btn.Text = "Text";
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // ucMenuBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn);
            this.Name = "ucMenuBtn";
            this.Size = new System.Drawing.Size(250, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn;
    }
}
