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
        PhanCongDAO PCdao = new PhanCongDAO();
        public FPhanCong(string maPB)
        {
            InitializeComponent();
            MaPB = maPB;
        }

        private void PhanCong_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            cbo_MaNV.DataSource = PCdao.LayDanhSachMaNhanVien();
            cbo_MaDA.DataSource = PCdao.LayDanhSachMaDuAn();
        }
        private void HienThiDanhSach()
        {   
            this.gv_CongViec.DataSource = PCdao.LayDanhSachPhanCong();          
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ClassPhanCong pc = new ClassPhanCong(cbo_MaNV.Text, cbo_MaDA.Text, rtxt_CongViec.Text, dtp_Deadline.Value);
            PCdao.Them(pc);
            HienThiDanhSach();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            ClassPhanCong pc = new ClassPhanCong(cbo_MaNV.Text, cbo_MaDA.Text, rtxt_CongViec.Text, dtp_Deadline.Value);
            PCdao.Xoa(pc);
            HienThiDanhSach();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            ClassPhanCong pc = new ClassPhanCong(cbo_MaNV.Text, cbo_MaDA.Text, rtxt_CongViec.Text, dtp_Deadline.Value);
            PCdao.Sua(pc);
            HienThiDanhSach();
        }

        private void gv_CongViec_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = gv_CongViec.CurrentRow.Index;
            cbo_MaNV.Text = gv_CongViec.Rows[i].Cells[0].Value.ToString();
            cbo_MaDA.Text = gv_CongViec.Rows[i].Cells[1].Value.ToString();
            rtxt_CongViec.Text = gv_CongViec.Rows[i].Cells[2].Value.ToString();
        }
    }
}
