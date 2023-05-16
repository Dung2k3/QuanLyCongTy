﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class XemPCChuaHTTPBUS
    {
        public PhanCongModel pc;
        CongViecDAO congViecDAO = new CongViecDAO();
        PhanCongDAO phanCongDAO = new PhanCongDAO();
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        public void FillControl(Label lblTenCV, Label lblGTBatDauLam, Label lblTGConLai, UCTienDo ucTienDo1, TextBox textBox1)
        {
            CongViecModel cv = congViecDAO.GetCongViecTheoMaCV(pc.MaCV);
            NhanVienModel nv = nhanVienDAO.GetNhanVienTheoMaNV(pc.MaNV);

            lblTenCV.Text = cv.TenCV;
            lblGTBatDauLam.Text = "Ngày bắt đầu: " + pc.NgayBD.ToString("dd/MM/yyyy");
            lblTGConLai.Text = "Còn " + (pc.DeadLine.Subtract(DateTime.Now)).Days.ToString() + " Ngày";
            ucTienDo1.Change(pc.TienDo);
            textBox1.Text = nv.HoTenNV;
        }
        public void OpenFPCXoa()
        {
            FXoaPC fXoaPC = new FXoaPC();
            fXoaPC.CapNhat(pc);
            fXoaPC.ShowDialog();
        }

        public void OpenFThemPC()
        {
            FThemTroGiup fThemTroGiup = new FThemTroGiup();
            fThemTroGiup.CapNhat(pc);
            fThemTroGiup.ShowDialog();
        }
    }
}
