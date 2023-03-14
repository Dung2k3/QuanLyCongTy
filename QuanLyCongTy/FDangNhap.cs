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
    public partial class FDangNhap : Form
    {
        DangNhapDao dnDao = new DangNhapDao();
        public FDangNhap()
        {
            InitializeComponent();
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ClassDangNhap dn = new ClassDangNhap(txtTaiKhoan.Text,txtMatKhau.Text);
            string MaNV = dnDao.KTTaiKhoan(dn);
            if (MaNV != null)
            {
                this.Hide();
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                Form newForm;
                if (dnDao.KTQuanLy(MaNV))
                    newForm = new FQuanLy2(MaNV);
                else if (dnDao.KTTruongPhong(MaNV))
                    newForm = new FTruongPhong2(MaNV);
                else
                    newForm = new FNhanVien2(MaNV);
                newForm.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu chưa đúng");
        }
    }
}
