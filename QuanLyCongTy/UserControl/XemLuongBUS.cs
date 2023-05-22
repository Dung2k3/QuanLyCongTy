using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemLuongBUS
    {
        public NhanVienModel nv;
        public DateTime date;
        DateTime datecal = DateTime.Today;
        MucLuongDAO mucLuongDAO = new MucLuongDAO();
        LuongDAO luongDAO = new LuongDAO();
        PhanCongDAO phanCongDAO = new PhanCongDAO();
        CheckIODAO checkIODAO = new CheckIODAO();

        public void FillControls(Label lblChucVu, Label lblMucLuong, Label lblThuong, Label lblNgayDiLam, Label lblTreSom, Label lblTongLuong, Label lblThang)
        {
            MucLuongModel luong = mucLuongDAO.GetMucLuongTheoMaLuong(nv.MaLuong);
            int MucLuong = luong.MucLuong;
            int Thuong = phanCongDAO.TongThuongNVTheoThang(nv, date);
            int NgayDiLam = checkIODAO.SoNgayDiLamNVTheoThang(nv, date);
            int NgayViPham = checkIODAO.SoNgayViPhamNVTheoThang(nv, date);

            lblThang.Text = "Tháng " + datecal.Month.ToString() + " Năm " + datecal.Year.ToString();

            LuongModel lg = luongDAO.GetLuongTheoNhanVien(nv, datecal);

            lblChucVu.Text = luong.ChucVu;
            lblMucLuong.Text = MucLuong.ToString();
            lblThuong.Text = Thuong.ToString();
            lblNgayDiLam.Text = NgayDiLam.ToString();
            lblTreSom.Text = NgayViPham.ToString();
            if (lg is null )
            {
                lblTongLuong.Text = "Chưa có lương";
                lblTongLuong.ForeColor = ColorTranslator.FromHtml("#F44336");
            }
            else
            {
                lblTongLuong.Text = lg.Luong.ToString();

                lblTongLuong.ForeColor = Color.Black;
            }
        }

        public void PreMonth(Label lblChucVu, Label lblMucLuong, Label lblThuong, Label lblNgayDiLam, Label lblTreSom, Label lblTongLuong, Label lblThang)
        {
            datecal = datecal.AddMonths(-1);
            lblThang.Text = "Tháng " + datecal.Month.ToString() + " Năm " + datecal.Year.ToString();
            FillControls(lblChucVu, lblMucLuong, lblThuong, lblNgayDiLam, lblTreSom, lblTongLuong, lblThang);
        }
        public void NextMonth(Label lblChucVu, Label lblMucLuong, Label lblThuong, Label lblNgayDiLam, Label lblTreSom, Label lblTongLuong, Label lblThang)
        {
            datecal = datecal.AddMonths(1);
            lblThang.Text = "Tháng " + datecal.Month.ToString() + " Năm " + datecal.Year.ToString();
            FillControls(lblChucVu, lblMucLuong, lblThuong, lblNgayDiLam, lblTreSom, lblTongLuong, lblThang);
        }
    }
}
