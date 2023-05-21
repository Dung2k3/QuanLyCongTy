using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XinNghiDaDuyetBUS
    {
        public XinNghiModel xn;
        NhanVienDAO nvDAO = new NhanVienDAO();

        public void FillConstrols( Label HoTen, Label NgayNghi, Label SoNN, Label LyDo, Label TT )
        {
            NhanVienModel nv = nvDAO.GetNhanVienTheoMaNV(xn.MaNV);

            HoTen.Text = nv.HoTenNV;
            NgayNghi.Text = xn.NgayBD.ToShortDateString();
            SoNN.Text = xn.SoNgayNghi.ToString();
            LyDo.Text = xn.LyDo.ToString();

            if (xn.HeSoDuyet == 1)
            {
                TT.Text = "Chấp nhận";
                TT.ForeColor = ColorTranslator.FromHtml("#128C7E");
            }
            else if (xn.HeSoDuyet == 0)
            {
                TT.Text = "Không chấp nhận";
                TT.ForeColor = ColorTranslator.FromHtml("#F44336");
            }
        }
    }
}
