using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemTienDoPCBUS
    {
        public PhanCongModel pc;
        public Reload.Flp reLoadF;
        NhanVienDAO nhanVienDAO = new NhanVienDAO();

        public void FillControl(Label lblTen, Guna2ProgressBar prg, Label lblTD)
        {
            NhanVienModel nv = nhanVienDAO.GetNhanVienTheoMaNV(pc.MaNV);

            lblTen.Text = nv.HoTenNV;
            prg.Value = pc.TienDo;
            lblTD.Text = prg.Value.ToString() + "%";
        }
    }
}
