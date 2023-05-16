using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class NhanXetDABUS
    {
        DuAnDAO duAnDAO = new DuAnDAO();
        public DuAnModel da;

        public string LayChamDiem(int Diem)
        {
            if (Diem == 0) return "";
            if (Diem == 20) return "Tệ";
            if (Diem == 40) return "Chưa tốt";
            if (Diem == 60) return "Tốt";
            if (Diem == 80) return "Rất tốt";
            if (Diem == 100) return "Xuất sắc";
            else return "";
        }

        public void FillControl(Label lbl_TenDA,TextBox txt_NhanXet,Label lbl_ChamDiem,ref int Diem)
        {
            lbl_TenDA.Text = da.TenDuAn;
            txt_NhanXet.Text = da.DanhGia;
            Diem = da.ChamDiem;
            lbl_ChamDiem.Text = LayChamDiem(Diem);
        }
        public void LuuNhanXet(TextBox txt_NhanXet, int Diem)
        {
            da.DanhGia = txt_NhanXet.Text;
            da.ChamDiem = Diem;
            duAnDAO.Sua(da);
        }
    }
}
