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
    public partial class UCTienDoDA : UserControl
    {
        TienDoDADAO ttdaDAO = new TienDoDADAO();
        SuaDADAO suaDADAO = new SuaDADAO();
        string MaDA;
        public UCTienDoDA(string MaDA)
        {
            InitializeComponent();
            this.MaDA = MaDA;
        }

        private void UCTienDoDA_Load(object sender, EventArgs e)
        {
            TienDoDA td = ttdaDAO.LayDanhSachDuAn(MaDA);

            lbl_tenDA.Text = td.TenDuAn;
            lbl_TenPhong.Text = td.TenPB;
            lbl_NgayCL.Text = "Thời hạn: Còn " + td.NgayKT.Subtract(td.NgayBD).Days.ToString() + " ngày.";

            pgb_TDDA.Minimum = 0;
            pgb_TDDA.Maximum = 100;
            pgb_TDDA.Value = ttdaDAO.LayTienDo(MaDA);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Form form = new FSuaDA(MaDA);
            Enabled = false;
            form.ShowDialog();
            Enabled = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            suaDADAO.Xoa(MaDA);
        }
    }
}
