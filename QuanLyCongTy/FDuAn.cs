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
            DAChuaHT();
        }

        public delegate void FReload();

        private void DAChuaHT()
        {
            flp_ListDA.Controls.Clear();
            DataTable dt = daDAO.LayDanhSachDuAnChuaHT();
            foreach (DataRow dr in dt.Rows)
            {
                UCTienDoDA uc = new UCTienDoDA(dr[0].ToString());
                flp_ListDA.Controls.Add(uc);
                uc.addReLoat(DAChuaHT);
            }
        }
        private void DADaHT()
        {
            flp_ListDA.Controls.Clear();
            DataTable dt = daDAO.LayDanhSachDuAnDaHT();
            foreach (DataRow dr in dt.Rows)
            {
                UCSailorStar uc = new UCSailorStar(dr[0].ToString());
                flp_ListDA.Controls.Add(uc);
                uc.addReLoat(DADaHT);
            }
        }

        private void btnChuaHT_Click(object sender, EventArgs e)
        {
            DAChuaHT();
        }

        private void btnDaHT_Click(object sender, EventArgs e)
        {
            DADaHT();
        }

        private void pbThem_Click(object sender, EventArgs e)
        {
            Form form = new FThemDA();
            Enabled = false;
            form.ShowDialog();
            Enabled = true;
            DAChuaHT();
        }

        private void pbThem_MouseLeave(object sender, EventArgs e)
        {
            pbThem.Size = new Size(pbThem.Size.Height - 10, pbThem.Size.Height - 10);
            pbThem.Location = new Point(pbThem.Location.X + 5, pbThem.Location.Y + 5);
        }

        private void pbThem_MouseEnter(object sender, EventArgs e)
        {
            pbThem.Size = new Size(pbThem.Size.Height + 10, pbThem.Size.Height + 10);
            pbThem.Location = new Point(pbThem.Location.X - 5, pbThem.Location.Y - 5);
        }
    }
}
