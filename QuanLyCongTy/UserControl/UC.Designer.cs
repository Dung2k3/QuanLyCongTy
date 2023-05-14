namespace QuanLyCongTy
{
    partial class UC
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panelName = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlNoiDung = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.pnlMenu.SuspendLayout();
            this.panelName.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.panelName);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(378, 1000);
            this.pnlMenu.TabIndex = 9;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelName.Controls.Add(this.guna2Shapes1);
            this.panelName.Controls.Add(this.guna2CustomGradientPanel3);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(378, 125);
            this.panelName.TabIndex = 0;
            this.panelName.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(86, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.panelName_Click);
            // 
            // pnlNoiDung
            // 
            this.pnlNoiDung.Location = new System.Drawing.Point(433, 125);
            this.pnlNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Size = new System.Drawing.Size(972, 875);
            this.pnlNoiDung.TabIndex = 11;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.btnCloseForm);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(378, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1028, 125);
            this.pnlTitle.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(519, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 44);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = " ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.btnCloseForm.ForeColor = System.Drawing.Color.Black;
            this.btnCloseForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCloseForm.Location = new System.Drawing.Point(1048, 0);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(76, 60);
            this.btnCloseForm.TabIndex = 6;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel3.BorderRadius = 25;
            this.guna2CustomGradientPanel3.Controls.Add(this.lblName);
            this.guna2CustomGradientPanel3.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.Silver;
            this.guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.Silver;
            this.guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.Silver;
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.Silver;
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(16, 12);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(325, 77);
            this.guna2CustomGradientPanel3.TabIndex = 29;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CirclePictureBox1.Image = global::QuanLyCongTy.Properties.Resources.NhanVienName;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(80, 77);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 27;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.BorderColor = System.Drawing.Color.White;
            this.guna2Shapes1.FillColor = System.Drawing.Color.Gray;
            this.guna2Shapes1.LineEndCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
            this.guna2Shapes1.LineStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2Shapes1.LineThickness = 1;
            this.guna2Shapes1.Location = new System.Drawing.Point(39, 95);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(283, 27);
            this.guna2Shapes1.TabIndex = 30;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.UseTransparentBackground = true;
            this.guna2Shapes1.Zoom = 100;
            // 
            // UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "UC";
            this.Size = new System.Drawing.Size(1406, 1000);
            this.Load += new System.EventHandler(this.panelName_Click);
            this.pnlMenu.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Panel pnlNoiDung;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
    }
}
