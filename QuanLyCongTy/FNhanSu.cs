using Guna.UI2.WinForms;
using System;
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
    public partial class FNhanSu : Form
    {
        Form currentFormChild;
        readonly NhanVienDAO nvDao = new NhanVienDAO();
        string MaNV;
        public FNhanSu(string manv)
        {
            InitializeComponent();
            this.MaNV = manv;
        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 166, b.Location.Y - 30);
            imgSlide.BringToFront();
        }
        public void OpenChildForm(Form childForm)
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

        private void FNhanSu_Load(object sender, EventArgs e)
        {
            lblName.Text = nvDao.GetTenNV(MaNV);
            lblTitle.Text = "Thông tin cá nhân";
            OpenChildForm(new FThongTin(MaNV));
        }

        private void btnCaNhan_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin cá nhân";
            OpenChildForm(new FThongTin(MaNV));
            moveImageBox(sender);
        }

        private void btnCheckinout_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnCheckin.Text;
            NhanVienModel nv = nvDao.GetNhanVienTheoMaNV(MaNV);
            FCheckinout form = new FCheckinout();
            form.CapNhat(nv);
            OpenChildForm(form);
            moveImageBox(sender);
        }

        private void btnTinhLuong_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnTinhLuong.Text;
            FTinhLuong form = new FTinhLuong();
            OpenChildForm(form);
            moveImageBox(sender);
        }

        private void btnDuyetXinNghi_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = btnCheckin.Text;
            NhanVienModel nv = nvDao.GetNhanVienTheoMaNV(MaNV);
            FDuyetXinNghi form = new FDuyetXinNghi();
            form.CapNhat(nv);
            OpenChildForm(form);
            moveImageBox(sender);
        }
        private void lblThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
