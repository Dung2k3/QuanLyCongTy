﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class UCXemXinNghiChuaDuyet : UserControl
    {
        XemXinNghiChuaDuyetQLBUS xemXinNghiChuaDuyetQLBUS = new XemXinNghiChuaDuyetQLBUS();
        public UCXemXinNghiChuaDuyet()
        {
            InitializeComponent();
        }

        public void CapNhat(XinNghiModel xn, Reload.Flp HamRL, bool ChinhSua)
        {
            xemXinNghiChuaDuyetQLBUS.xn = xn;
            xemXinNghiChuaDuyetQLBUS.HamRL = HamRL;
            if (!ChinhSua)
            {
                btn_Duyet.Visible = false;
                btn_Xoa.Visible = false;
            }
        }

        private void UCXinNghi_Load(object sender, EventArgs e)
        {
            xemXinNghiChuaDuyetQLBUS.FillControls(lb_HovaTen, lb_NgayNghi, lb_SoNgayNghi, lb_LyDo);
        }

        private void btn_Duyet_Click(object sender, EventArgs e)
        {
            xemXinNghiChuaDuyetQLBUS.DuyetXN();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            xemXinNghiChuaDuyetQLBUS.KhongDuyetXN();
        }
    }
}
