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
    public partial class DanhGia : Form
    {
        DanhGiaDAO DGdao = new DanhGiaDAO();
        public DanhGia()
        {
            InitializeComponent();
        }

        private void DanhGia_Load(object sender, EventArgs e)
        {
            gv_PhanCong.DataSource= DGdao.LayDanhSachDanhGia();
        }
    }
}
