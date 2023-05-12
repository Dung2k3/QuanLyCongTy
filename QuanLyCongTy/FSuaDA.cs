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
    public partial class FSuaDA : Form
    {
        SuaDADAO suadaDAO = new SuaDADAO();
        string MaDA;
        string MaPB;
        string MaLPB;
        public FSuaDA(string maDA)
        {
            InitializeComponent();
            this.MaDA = maDA;
        }

        private void FSuaDA_Load(object sender, EventArgs e)
        {
            SuaDA da = suadaDAO.LayThongTinDA(MaDA);
            MaLPB = suadaDAO.GetMaLPB1(MaDA);
            cmbTenPB.DataSource = suadaDAO.LayDanhSachTenPhongBan(MaLPB);
            MaPB = suadaDAO.GetMaPB(cmbTenPB.Text);
            HienThiDanhSach();

            txtTenDA.Text = da.TenDA;
            txtMoTa.Text = da.MoTa;
            cmbTenPB.Text = da.TenPb;
            txtDiaDiem.Text = da.DiaDiem;
            dtpNgayBD.Text = da.NgayBD.ToString();
            dtpDeadline.Text = da.DeadLine.ToString();
        }

        private void HienThiDanhSach()
        {
            this.gvPhongBanRanh.DataSource = suadaDAO.LayDSTinhTrangLPB(MaLPB);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaDA da = new SuaDA(MaDA, txtTenDA.Text, txtMoTa.Text, cmbTenPB.Text, txtDiaDiem.Text, dtpNgayBD.Value, dtpDeadline.Value);
            suadaDAO.Sua(da, MaPB);
            Close();
        }
    }
}
