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
    public partial class FPhanCong : Form
    {
        ThemPhanCongBUS themPhanCongBUS = new ThemPhanCongBUS();
        public FPhanCong()
        { 
            InitializeComponent();
        }
        public void CapNhat(DuAnModel da)
        {
            themPhanCongBUS.da = da;
        }

        private void PhanCong_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            themPhanCongBUS.FillcboNV(cboNhanVien, dtpDBLam, dtpDeadline);
            themPhanCongBUS.FillcboCV(cboCongViec);
        }
        private void HienThiDanhSach()
        {
            themPhanCongBUS.Fillgv(gv_CongViec, dtpDBLam, dtpDeadline);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            themPhanCongBUS.ThemPC(cboNhanVien,cboCongViec,textBox1,checkBox1,dtpDBLam,dtpDeadline);
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpDBLam_ValueChanged(object sender, EventArgs e)
        {
            PhanCong_Load(sender, e);
        }

        private void dtpDeadline_ValueChanged(object sender, EventArgs e)
        {
            PhanCong_Load(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Show();
                panel1.Location = new Point(textBox1.Location.X, textBox1.Location.Y + textBox1.Size.Height + 1);
            }
            else
            {
                textBox1.Hide();
                panel1.Location = new Point(cboCongViec.Location.X, cboCongViec.Location.Y + cboCongViec.Size.Height + 1);
            }
        }
    }
}
