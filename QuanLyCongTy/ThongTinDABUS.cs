using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class ThongTinDABUS
    {
        public string maDA;
        DuAnDAO duAnDAO = new DuAnDAO();
        PhanCongDAO phanCongDAO = new PhanCongDAO();

        public void FillControl(TextBox txtTenDa, Label lblDiaDiem, Label lblNgayBD, Label lblThoiHan, TextBox txtMoTa, FlowLayoutPanel flp)
        {
            DuAnModel da = duAnDAO.getDuAnTheoMa(maDA);

            txtTenDa.Text = da.TenDuAn;
            lblDiaDiem.Text = da.DiaDiem;
            lblNgayBD.Text = da.NgayBD.ToShortDateString();
            lblThoiHan.Text = da.DeadLine.ToShortDateString();
            txtMoTa.Text = da.MoTa;
            txtTenDa.Enabled = false;
            txtMoTa.Enabled = false;
            txtMoTa.ForeColor = System.Drawing.Color.Black;

            List<PhanCongModel> listPCChuaHTTheoDA = phanCongDAO.ListPCChuaHTTheoDA(maDA);
            foreach (PhanCongModel pc in listPCChuaHTTheoDA)
            {
                UCXemPhanCong uc = new UCXemPhanCong();
                uc.CapNhat(pc);
                uc.Margin = new Padding(10, 10, 0, 0);
                flp.Controls.Add(uc);
            }
        }

        public void OpenFThem()
        {
            DuAnModel da = duAnDAO.getDuAnTheoMa(maDA);
            FPhanCong fPhanCong = new FPhanCong();
            fPhanCong.CapNhat(da);
            fPhanCong.ShowDialog();
        }
    }
}
