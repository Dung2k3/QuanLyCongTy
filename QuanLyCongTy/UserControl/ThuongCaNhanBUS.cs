using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{ 
    internal class ThuongCaNhanBUS
    {
        public PhanCongModel pc;
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        CongViecDAO congViecDAO = new CongViecDAO();
        PhanCongDAO phanCongDAO = new PhanCongDAO();
        public void FillControls(Label Ten, Label CongViec, Guna2TextBox Thuong)
        {
            NhanVienModel nv = nhanVienDAO.GetNhanVienTheoMaNV(pc.MaNV);
            CongViecModel cv = congViecDAO.GetCongViecTheoMaCV(pc.MaCV);
            Ten.Text = nv.HoTenNV;
            CongViec.Text = cv.TenCV;
            Thuong.Text = pc.Thuong.ToString();
        }

        public void XacNhan(Guna2TextBox Thuong)
        {
            pc.Thuong =int.Parse(Thuong.Text);
            phanCongDAO.Sua(pc);
        }

    }
}
