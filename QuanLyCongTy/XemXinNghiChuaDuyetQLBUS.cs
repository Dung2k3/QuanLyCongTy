using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemXinNghiChuaDuyetQLBUS
    {
        public XinNghiModel xn;
        public Reload.Flp HamRL;
        XinNghiDAO xinNghiDAO = new XinNghiDAO();
        NhanVienDAO nhanVienDAO = new NhanVienDAO();

        public void FillControls( Label lb_HovaTen, Label lb_NgayNghi, Label lb_SoNgayNghi, Label lb_LyDo)
        {
            NhanVienModel nv = nhanVienDAO.GetNhanVienTheoMaNV(xn.MaNV);
            lb_HovaTen.Text = nv.HoTenNV;
            lb_NgayNghi.Text = xn.NgayBD.ToShortDateString();
            lb_SoNgayNghi.Text = xn.SoNgayNghi.ToString();
            lb_LyDo.Text = xn.LyDo.ToString();
        }
        public void DuyetXN()
        {
            xinNghiDAO.Duyet(xn.MaNV);
            HamRL();
        }

        public void KhongDuyetXN()
        {
            xinNghiDAO.KhongDuyet(xn.MaNV);
            HamRL();
        }
    }
}
