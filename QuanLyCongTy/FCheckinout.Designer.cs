﻿namespace QuanLyCongTy
{
    partial class FCheckinout
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvCheckoutList = new System.Windows.Forms.DataGridView();
            this.TGCheckout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nhanxet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.gvCheckinList = new System.Windows.Forms.DataGridView();
            this.TGCheckin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nhanxet2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.pnlTable = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gvCheckoutList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCheckinList)).BeginInit();
            this.pnlTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvCheckoutList
            // 
            this.gvCheckoutList.BackgroundColor = System.Drawing.Color.White;
            this.gvCheckoutList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCheckoutList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvCheckoutList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCheckoutList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TGCheckout,
            this.Nhanxet});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvCheckoutList.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvCheckoutList.Dock = System.Windows.Forms.DockStyle.Right;
            this.gvCheckoutList.Location = new System.Drawing.Point(266, 8);
            this.gvCheckoutList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gvCheckoutList.Name = "gvCheckoutList";
            this.gvCheckoutList.RowHeadersVisible = false;
            this.gvCheckoutList.RowHeadersWidth = 51;
            this.gvCheckoutList.RowTemplate.Height = 24;
            this.gvCheckoutList.Size = new System.Drawing.Size(259, 561);
            this.gvCheckoutList.TabIndex = 2;
            // 
            // TGCheckout
            // 
            this.TGCheckout.DataPropertyName = "TGCheckout";
            this.TGCheckout.HeaderText = "Thời điểm Checkout";
            this.TGCheckout.MinimumWidth = 6;
            this.TGCheckout.Name = "TGCheckout";
            this.TGCheckout.Width = 155;
            // 
            // Nhanxet
            // 
            this.Nhanxet.DataPropertyName = "Nhanxet";
            this.Nhanxet.HeaderText = "Nhận xét";
            this.Nhanxet.MinimumWidth = 6;
            this.Nhanxet.Name = "Nhanxet";
            this.Nhanxet.Width = 90;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Navy;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(29, 95);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(150, 55);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "CHECKOUT";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // gvCheckinList
            // 
            this.gvCheckinList.BackgroundColor = System.Drawing.Color.White;
            this.gvCheckinList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCheckinList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvCheckinList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCheckinList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TGCheckin,
            this.Nhanxet2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvCheckinList.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvCheckinList.Dock = System.Windows.Forms.DockStyle.Left;
            this.gvCheckinList.Location = new System.Drawing.Point(0, 8);
            this.gvCheckinList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gvCheckinList.Name = "gvCheckinList";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCheckinList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvCheckinList.RowHeadersVisible = false;
            this.gvCheckinList.RowHeadersWidth = 51;
            this.gvCheckinList.RowTemplate.Height = 24;
            this.gvCheckinList.Size = new System.Drawing.Size(255, 561);
            this.gvCheckinList.TabIndex = 0;
            // 
            // TGCheckin
            // 
            this.TGCheckin.DataPropertyName = "TGCheckin";
            this.TGCheckin.HeaderText = "Thời điểm Checkin";
            this.TGCheckin.MinimumWidth = 6;
            this.TGCheckin.Name = "TGCheckin";
            this.TGCheckin.Width = 155;
            // 
            // Nhanxet2
            // 
            this.Nhanxet2.DataPropertyName = "Nhanxet";
            this.Nhanxet2.HeaderText = "Nhận xét";
            this.Nhanxet2.MinimumWidth = 6;
            this.Nhanxet2.Name = "Nhanxet2";
            this.Nhanxet2.Width = 90;
            // 
            // btnCheckin
            // 
            this.btnCheckin.BackColor = System.Drawing.Color.Teal;
            this.btnCheckin.FlatAppearance.BorderSize = 0;
            this.btnCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckin.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.ForeColor = System.Drawing.Color.White;
            this.btnCheckin.Location = new System.Drawing.Point(29, 23);
            this.btnCheckin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(150, 55);
            this.btnCheckin.TabIndex = 1;
            this.btnCheckin.Text = "CHECKIN";
            this.btnCheckin.UseVisualStyleBackColor = false;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // pnlTable
            // 
            this.pnlTable.Controls.Add(this.gvCheckoutList);
            this.pnlTable.Controls.Add(this.gvCheckinList);
            this.pnlTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTable.Location = new System.Drawing.Point(225, 0);
            this.pnlTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pnlTable.Size = new System.Drawing.Size(525, 569);
            this.pnlTable.TabIndex = 3;
            // 
            // FCheckinout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 569);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.btnCheckout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FCheckinout";
            this.Text = "Checkin";
            this.Load += new System.EventHandler(this.Checkin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCheckoutList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCheckinList)).EndInit();
            this.pnlTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gvCheckoutList;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DataGridView gvCheckinList;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGCheckout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nhanxet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGCheckin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nhanxet2;
    }
}