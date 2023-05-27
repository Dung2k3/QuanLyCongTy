using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemDAChuaHTTPBUS
    {
        public DuAn da;
        public Reload.Flp rl;
        PhongBanDAO phongBanDAO = new PhongBanDAO();
        DuAnDAO duAnDAO = new DuAnDAO();
        QLCTContext db = new QLCTContext();
        public void FillControl(Label lblTenDA, Label lblTenPhong, Guna2ProgressBar prgTienDo, Label lblNgayCL, Label lblTienDo)
        {
            PhongBanModel pb = phongBanDAO.GetPhongBanTheoMaPB(da.MaPB);


            lblTenDA.Text = da.TenDuAn;
            lblTenPhong.Text = pb.TenPB;

            prgTienDo.Value = (int) da.PhanCongs.Average(pc => pc.TienDo);
            lblNgayCL.Text = "Thời hạn: Còn " + da.DeadLine.Value.Subtract(da.NgayBD.Value).Days.ToString() + " ngày.";
            lblTienDo.Text = prgTienDo.Value.ToString() + "%";
        }

        public void OpenFThongTin()
        {
            FThongTinDA form = new FThongTinDA();
            form.CapNhat(da, rl);
            form.ShowDialog();
        }
    }
}
