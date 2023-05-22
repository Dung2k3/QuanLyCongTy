using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class LuongCNBUS
    {
        public NhanVienModel nv;
        public DateTime date;
        MucLuongDAO mucLuongDAO = new MucLuongDAO();
        PhanCongDAO phanCongDAO = new PhanCongDAO();
        CheckIODAO checkIODAO = new CheckIODAO();
        public void FillControl(Label lblTen, Label lblChucVu, Label lblMucLuong,
            Label lblThuong, Label lblNgayDiLam, Label lblTreSom, Label lblTongLuong)
        {
            MucLuongModel luong = mucLuongDAO.GetMucLuongTheoMaLuong(nv.MaLuong);
            int MucLuong = luong.MucLuong;
            int Thuong = phanCongDAO.TongThuongNVTheoThang(nv, date);
            int NgayDiLam = checkIODAO.SoNgayDiLamNVTheoThang(nv, date);
            int NgayViPham = checkIODAO.SoNgayViPhamNVTheoThang(nv, date);
            lblTen.Text = nv.HoTenNV;
            lblChucVu.Text = luong.ChucVu;
            lblMucLuong.Text = MucLuong.ToString();
            lblThuong.Text = Thuong.ToString();
            lblNgayDiLam.Text = NgayDiLam.ToString();
            lblTreSom.Text = NgayViPham.ToString();
            lblTongLuong.Text = ((int)(MucLuong*(NgayDiLam - NgayViPham/2) + Thuong)).ToString();
        }
        public LuongModel getLuong()
        {
            MucLuongModel luong = mucLuongDAO.GetMucLuongTheoMaLuong(nv.MaLuong);
            int MucLuong = luong.MucLuong;
            int Thuong = phanCongDAO.TongThuongNVTheoThang(nv, date);
            int NgayDiLam = checkIODAO.SoNgayDiLamNVTheoThang(nv, date);
            int NgayViPham = checkIODAO.SoNgayViPhamNVTheoThang(nv, date);
            int TongLuong = (int)(MucLuong * (NgayDiLam - NgayViPham / 2) + Thuong);
            return new LuongModel(nv.MaNV, date, TongLuong);
        }
    }
}
