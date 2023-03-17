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
        DuAnDAO daDAO = new DuAnDAO();
        public FDuAn()
        {
            InitializeComponent();
        }
        private void FDuAn_Load(object sender, EventArgs e)
        {
            DataTable dt = daDAO.LayDanhSachDuAnChuaHT();
            foreach (DataRow dr in dt.Rows)
            {
                UCTienDoDA uc = new UCTienDoDA(dr[0].ToString());
                flp_ListDA.Controls.Add(uc);
            }
        }

        private void btnChuaHT_Click(object sender, EventArgs e)
        {
            flp_ListDA.Controls.Clear();
            DataTable dt = daDAO.LayDanhSachDuAnChuaHT();
            foreach (DataRow dr in dt.Rows)
            {
                UCTienDoDA uc = new UCTienDoDA(dr[0].ToString());
                flp_ListDA.Controls.Add(uc);
            }
        }

        private void btnDaHT_Click(object sender, EventArgs e)
        {
            flp_ListDA.Controls.Clear();
            DataTable dt = daDAO.LayDanhSachDuAnDaHT();
            foreach (DataRow dr in dt.Rows)
            {
                UCTienDoDA uc = new UCTienDoDA(dr[0].ToString());
                flp_ListDA.Controls.Add(uc);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form form = new FThemDA();
            Enabled = false;
            form.ShowDialog();
            Enabled = true;
        }
    }
}
