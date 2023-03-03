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

        private void FDangNhap_Load(object sender, EventArgs e)
        { 
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap(txtTaiKhoan.Text,txtMatKhau.Text);
            string MaNV = dnDao.KTTaiKhoan(dn);
            if (MaNV != null)
                MessageBox.Show(MaNV);
            else
                MessageBox.Show("That bai");
        }
    }
}
