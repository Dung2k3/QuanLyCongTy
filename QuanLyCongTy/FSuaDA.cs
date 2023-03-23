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
            MaDA = maDA;
        }

        private void FSuaDA_Load(object sender, EventArgs e)
        {
            SuaDA da = suadaDAO.LayThongTinDA(MaDA);
            MaLPB = suadaDAO.GetMaLPB1(MaDA);
            cmb_TenPB.DataSource = suadaDAO.LayDanhSachTenPhongBan(MaLPB);
            HienThiDanhSach();

            txt_TenDA.Text = da.TenDA;
            txt_MoTa.Text = da.MoTa;
            cmb_TenPB.Text = da.TenPb;
            txtDiaDiem.Text = da.DiaDiem;
            dtp_NgayBD.Text = da.NgayBD.ToString();
            dtp_DeadLine.Text = da.DeadLine.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SuaDA da = new SuaDA(MaDA, txt_TenDA.Text, txt_MoTa.Text, cmb_TenPB.Text,txtDiaDiem.Text, dtp_NgayBD.Value, dtp_DeadLine.Value);
            suadaDAO.Sua(da, MaPB);
            Close();
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HienThiDanhSach()
        {
            this.gvPhongBanRanh.DataSource = suadaDAO.LayDSTinhTrangLPB(MaLPB);
        }
    }
}
