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
        string MaPB;
        string MaLPB;
        PhanCongDAO PCdao = new PhanCongDAO();
        public FPhanCong(string maPB)
        {
            InitializeComponent();
            MaPB = maPB;
            MaLPB = PCdao.GetMaLPB(maPB);
        }

        private void PhanCong_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            cbo_TenNV.DataSource = PCdao.LayDanhSachTenNhanVien(MaPB);
            cbo_TenDA.DataSource = PCdao.LayDanhSachTenDuAn(MaPB);
            cbo_CongViec.DataSource = PCdao.LayDanhSachTenCongViec(MaLPB);
        }
        private void HienThiDanhSach()
        {   
            gv_CongViec.DataSource = PCdao.LayDanhSachPhanCong(MaPB);          
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            PhanCong pc = new PhanCong(cbo_TenNV.Text, cbo_TenDA.Text, rtxt_CongViec.Text,dtp_Start.Value, dtp_Deadline.Value);
            PCdao.Them(pc);
            HienThiDanhSach();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            PhanCong pc = new PhanCong(cbo_TenNV.Text, cbo_TenDA.Text, rtxt_CongViec.Text, dtp_Start.Value, dtp_Deadline.Value);
            PCdao.Xoa(pc);
            HienThiDanhSach();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            PhanCong pc = new PhanCong(cbo_TenNV.Text, cbo_TenDA.Text, rtxt_CongViec.Text, dtp_Start.Value, dtp_Deadline.Value);
            PCdao.Sua(pc);
            HienThiDanhSach();
        }
        private void gv_CongViec_MouseClick(object sender, MouseEventArgs e)
        {
            int i = gv_CongViec.CurrentRow.Index;
            label6.Text = gv_CongViec.Rows[i].Cells[2].Value.ToString();
            label1.Text = gv_CongViec.Rows[i].Cells[0].Value.ToString();
            cbo_TenNV.Text = gv_CongViec.Rows[i].Cells[1].Value.ToString();
            cbo_TenDA.Text = gv_CongViec.Rows[i].Cells[3].Value.ToString();
            cbo_CongViec.Text = gv_CongViec.Rows[i].Cells[4].Value.ToString();
            //rtxt_CongViec.Text = gv_CongViec.Rows[i].Cells[4].Value.ToString();
            //lbl_duan.Text = gv_CongViec.Rows[i].Cells[3].Value.ToString();
            dtp_Start.Text = gv_CongViec.Rows[i].Cells[5].Value.ToString();
            dtp_Deadline.Text = gv_CongViec.Rows[i].Cells[6].Value.ToString();
        }
    }
}
