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
        public FXinNghi()
        {
            InitializeComponent();
        }

        private void btn_ChuaDuyet_Click(object sender, EventArgs e)
        {
            btn_ChuaDuyet.ForeColor = System.Drawing.Color.White;
            btn_ChuaDuyet.FillColor = Color.FromArgb(0, 118, 212);
            btn_DaDuyet.ForeColor = System.Drawing.Color.Teal;
            btn_DaDuyet.FillColor = System.Drawing.Color.White;

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add f = new Add();
            f.Show();
        }

        private void btn_DaDuyet_Click(object sender, EventArgs e)
        {
            btn_DaDuyet.ForeColor = System.Drawing.Color.White;
            btn_DaDuyet.FillColor = System.Drawing.Color.Teal;
            btn_ChuaDuyet.ForeColor = Color.FromArgb(0, 118, 212);
            btn_ChuaDuyet.FillColor = System.Drawing.Color.White;
        }
    }
}
