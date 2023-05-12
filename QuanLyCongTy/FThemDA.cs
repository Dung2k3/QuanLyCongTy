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
    public partial class FThemDA : Form
    {

        SuaDADAO suadaDAO = new SuaDADAO();
        string MaPB;
        string MaLPB;
        public FThemDA()
        {
            InitializeComponent();
            cmbLoaiPB.DataSource = suadaDAO.LayDanhSachTenLoaiPhongBan();
        }

        private void HienThiDanhSach()
        {
            this.gvPhongBanRanh.DataSource = suadaDAO.LayDSTinhTrangLPB(MaLPB);
        }

        private void FThemDA_Load(object sender, EventArgs e)
        {
            MaLPB = suadaDAO.GetMaLPB2(cmbLoaiPB.Text);
            HienThiDanhSach();
            lblMaDA.Text = suadaDAO.TaoMaDA();
        }

        private void cmbLoaiPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaLPB = suadaDAO.GetMaLPB2(cmbLoaiPB.Text);
            cmbTenPB.DataSource = suadaDAO.LayDanhSachTenPhongBan(MaLPB);
            HienThiDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemDA da = new ThemDA(lblMaDA.Text, txtTenDA.Text, txtMoTa.Text, cmbLoaiPB.Text, cmbTenPB.Text, txtDiaDiem.Text, dtpNgayBD.Value, dtpDeadline.Value);
            MaPB = suadaDAO.GetMaPB(cmbTenPB.Text);
            suadaDAO.Them(da, MaPB);
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
