using System;
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
    public partial class FDuAn : Form
    {
        XemDuAnQLBUS xemDuAnQLBUS = new XemDuAnQLBUS();
        public delegate void FReload();
        public FDuAn()
        {
            InitializeComponent();
            xemDuAnQLBUS.AddFlp(flp_ListDA);
        }
        private void FDuAn_Load(object sender, EventArgs e)
        {
            xemDuAnQLBUS.FillDuAnChuaHT();
        }
        private void TatMau()
        {
            btnDaHT.FillColor = ColorTranslator.FromHtml("#006AF9");
            btnChuaHT.FillColor = ColorTranslator.FromHtml("#006AF9");
            btnChuaHT.ForeColor = Color.White;
            btnDaHT.ForeColor = Color.White;
        }
        private void btnDaHT_Click(object sender, EventArgs e)
        {
            xemDuAnQLBUS.FillDuAnDaHT(); ;
            TatMau();
            btnDaHT.FillColor = Color.White;
            btnDaHT.ForeColor = ColorTranslator.FromHtml("#006AF9");
        }

        private void btnChuaHT_Click(object sender, EventArgs e)
        {
            xemDuAnQLBUS.FillDuAnChuaHT();
            TatMau();
            btnChuaHT.FillColor = Color.White;
            btnChuaHT.ForeColor = ColorTranslator.FromHtml("#006AF9");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xemDuAnQLBUS.OpenFThemDA(this);
        }
    }
}
