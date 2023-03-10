﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class FNhanVien : Form
    {
        string maNV;
        NhanVienDao nvDao = new NhanVienDao();
        public FNhanVien(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }
        private void btnClickChangeColor(Button btn, string color)
        {
            foreach (Control ctrl in pnlMenu.Controls)
            {
                if (ctrl is Button)
                {
                    Button btns = (Button)ctrl;
                    btns.BackColor = ColorTranslator.FromHtml("#33334C");
                }
            }
            btn.BackColor = ColorTranslator.FromHtml(color);
            pnlTitle.BackColor = ColorTranslator.FromHtml(color);
            lblTitle.Text = btn.Text;
            
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlNoiDung.Controls.Add(childForm);
            pnlNoiDung.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void FNhanVien_Load(object sender, EventArgs e)
        {
            lblName.Text = nvDao.GetTenNV(this.maNV);
        }


        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCheckinout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FCheckinout(maNV));
            btnClickChangeColor(btnCheckinout, "#8BC240");
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            btnClickChangeColor(btnPhanCong, "#126881");
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            btnClickChangeColor(btnThuong, "#A12059");
        }

        private void btnXinNghi_Click(object sender, EventArgs e)
        {
            btnClickChangeColor(btnXinNghi, "#364D5B");
        }
    }
}
