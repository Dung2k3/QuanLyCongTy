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
        PhanCongDAO PCdao = new PhanCongDAO();
        public FPhanCong()
        {
            InitializeComponent();
        }

        private void PhanCong_Load(object sender, EventArgs e)
        {
            gv_NhanVien.DataSource = PCdao.LayDanhSachNhanVien();
            gv_DuAn.DataSource = PCdao.LayDanhSachDuAn();
            gv_CongViec.DataSource = PCdao.LayDanhSachPhanCong();
        }
        private void HienThiDanhSach()
        {
            this.gv_NhanVien.DataSource = PCdao.LayDanhSachNhanVien();
            this.gv_DuAn.DataSource = PCdao.LayDanhSachDuAn();
            this.gv_CongViec.DataSource = PCdao.LayDanhSachPhanCong();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ClassPhanCong pc = new ClassPhanCong(txt_MaNV.Text, txt_MaDA.Text, txt_CongViec.Text, dtp_Deadline.Value);
            PCdao.Them(pc);
            HienThiDanhSach();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            ClassPhanCong pc = new ClassPhanCong(txt_MaNV.Text, txt_MaDA.Text, txt_CongViec.Text, dtp_Deadline.Value);
            PCdao.Xoa(pc);
            HienThiDanhSach();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            ClassPhanCong pc = new ClassPhanCong(txt_MaNV.Text, txt_MaDA.Text, txt_CongViec.Text, dtp_Deadline.Value);
            PCdao.Sua(pc);
            HienThiDanhSach();
        }

        private void gv_NhanVien_DoubleClick(object sender, EventArgs e)
        {
            int i = gv_NhanVien.CurrentRow.Index;
            txt_MaNV.Text = gv_NhanVien.Rows[i].Cells[0].Value.ToString();
        }

        private void gv_DuAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gv_DuAn.CurrentRow.Index;
            txt_MaDA.Text = gv_DuAn.Rows[i].Cells[0].Value.ToString();
        }

        private void gv_CongViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gv_CongViec.CurrentRow.Index;
            txt_CongViec.Text = gv_CongViec.Rows[i].Cells[2].Value.ToString();
        }
    }
}
