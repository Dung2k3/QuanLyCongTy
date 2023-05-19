using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class FXinNghi : Form
    {
        XemXinNghiBUS xemXinNghiBUS = new XemXinNghiBUS();
        public delegate void FReload();
        string MaNV;
        public FXinNghi(string ma)
        {
            InitializeComponent();
            this.MaNV = ma;
        }

        public void CapNhat(XinNghiModel xn)
        {
            xemXinNghiBUS.MaNV = MaNV;
            xemXinNghiBUS.xn = xn;
            xemXinNghiBUS.AddFlpXN(flp_ListXN);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add f = new Add();
            f.Show();
        }

        private void FXinNghi_Load(object sender, EventArgs e)
        {
            xemXinNghiBUS.FillXinNghiChuaDuyet();
        }

        private void btn_ChuaDuyet_Click(object sender, EventArgs e)
        {
            btn_ChuaDuyet.ForeColor = System.Drawing.Color.White;
            btn_ChuaDuyet.FillColor = Color.FromArgb(0, 118, 212);
            btn_DaDuyet.ForeColor = System.Drawing.Color.Teal;
            btn_DaDuyet.FillColor = System.Drawing.Color.White;
            xemXinNghiBUS.FillXinNghiChuaDuyet();
        }

        private void btn_DaDuyet_Click(object sender, EventArgs e)
        {
            btn_DaDuyet.ForeColor = System.Drawing.Color.White;
            btn_DaDuyet.FillColor = System.Drawing.Color.Teal;
            btn_ChuaDuyet.ForeColor = Color.FromArgb(0, 118, 212);
            btn_ChuaDuyet.FillColor = System.Drawing.Color.White;
            xemXinNghiBUS.FillXinNghiDaDuyet();
        }
    }
}
