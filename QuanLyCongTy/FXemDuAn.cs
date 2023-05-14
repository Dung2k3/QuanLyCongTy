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
    public partial class FXemDuAn : Form
    {
        XemDADAO xemdaDAO = new XemDADAO();
        string maPB;
        public FXemDuAn(string maPB)
        {
            InitializeComponent();
            this.maPB = maPB;

        }
        private void FXemDuAn_Load(object sender, EventArgs e)
        {
            DataTable dt = xemdaDAO.LayDanhSachDuAnChuaHT(maPB);
            foreach (DataRow dr in dt.Rows)
            {
                UCXemDAChuaHT uc = new UCXemDAChuaHT(dr[0].ToString());
                flp_ListDA.Controls.Add(uc);
            }
        }

        public delegate void FReload();

        private void DAChuaHT()
        {
            flp_ListDA.Controls.Clear();
            DataTable dt = xemdaDAO.LayDanhSachDuAnChuaHT(maPB);
            foreach (DataRow dr in dt.Rows)
            {
                UCXemDAChuaHT uc = new UCXemDAChuaHT(dr[0].ToString());
                flp_ListDA.Controls.Add(uc);
                uc.addReLoat(DAChuaHT);
            }
        }
        private void DADaHT()
        {
            flp_ListDA.Controls.Clear();
            DataTable dt = xemdaDAO.LayDanhSachDuAnDaHT(maPB);
            foreach (DataRow dr in dt.Rows)
            {
                UCXemDADaHT uc = new UCXemDADaHT(dr[0].ToString());
                flp_ListDA.Controls.Add(uc);
                uc.addReLoat(DADaHT);
            }
        }
        private void TatMau()
        {
            btnDaHT.ForeColor = ColorTranslator.FromHtml("#128C7E");
            btnChuaHT.ForeColor = ColorTranslator.FromHtml("#0076D4");
            btnDaHT.FillColor = Color.White;
            btnChuaHT.FillColor = Color.White;
        }

        private void btnDaHT_Click(object sender, EventArgs e)
        {
            DADaHT();
            TatMau();
            btnDaHT.ForeColor = Color.White;
            btnDaHT.FillColor = ColorTranslator.FromHtml("#128C7E");
        }

        private void btnChuaHT_Click(object sender, EventArgs e)
        {
            DAChuaHT();
            TatMau();
            btnChuaHT.ForeColor = Color.White;
            btnChuaHT.FillColor = ColorTranslator.FromHtml("#0076D4");
        }
    }
}
