using Guna.UI2.WinForms;
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

        public void FillControl(Label lblTen, Label lblDiaDiem, Label lblNgayBD, Label lblThoiHan, Label lblMoTa, FlowLayoutPanel flp)
        {
            DuAnModel da = duAnDAO.getDuAnTheoMa(maDA);

            lblTen.Text = da.TenDuAn;
            lblDiaDiem.Text = da.DiaDiem;
            lblNgayBD.Text = da.NgayBD.ToShortDateString();
            lblThoiHan.Text = da.DeadLine.ToShortDateString();
            lblMoTa.Text = da.MoTa;

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
