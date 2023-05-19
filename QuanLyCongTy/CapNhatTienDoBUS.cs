using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class CapNhatTienDoBUS
    {
        public PhanCongModel pc;
        public Reload.Flp reLoadF;
        CongViecDAO congViecDAO = new CongViecDAO();
        PhanCongDAO phanCongDAO = new PhanCongDAO();

        public void FillControl(Label lblCV, Label lblMoTa, Guna2TrackBar trackBar, Label lblTienDo, Label lblNgayCL)
        {
            lblCV.Text = congViecDAO.GetCongViecTheoMaCV(pc.MaCV).TenCV;
            lblMoTa.Text = pc.MoTa;
            trackBar.Value = pc.TienDo;
            lblTienDo.Text = pc.TienDo.ToString() + "%";
            int NgayCL = pc.DeadLine.Subtract(pc.NgayBD).Days;
            if(NgayCL <= 10)
            {
                lblNgayCL.ForeColor = ColorTranslator.FromHtml("#F44336");
            }
            lblNgayCL.Text = NgayCL.ToString() + " ngày.";
        }
        public void UpdateLbl(Guna2TrackBar trackBar, Label lblTienDo)
        {
            lblTienDo.Text = trackBar.Value + "%";
            pc.TienDo = trackBar.Value;
        }
        public void CapNhatPC()
        {
            phanCongDAO.Sua(pc);
            reLoadF();
        }
    }
}
