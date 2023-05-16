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
    public partial class FThongTinDA : Form
    {
        ThongTinDABUS thongTinDABUS = new ThongTinDABUS();

        public FThongTinDA(string maDA)
        {
            InitializeComponent();

            thongTinDABUS.maDA = maDA;
        }

        private void FThongTinDA_Load(object sender, EventArgs e)
        {
            thongTinDABUS.FillControl(txtTenDa, lblDiaDiem, lblNgayBD, lblThoiHan, txtMoTa, flowLayoutPanel1);
        }

        private void txtMoTa_MouseMove(object sender, MouseEventArgs e)
        {
            txtMoTa.SelectionLength = 0;
        }

        private void pbThem_Click(object sender, EventArgs e)
        {
            thongTinDABUS.OpenFThem();
        }
        private void pbThem_MouseEnter(object sender, EventArgs e)
        {
            pbThem.Size = new Size(pbThem.Size.Height + 10, pbThem.Size.Height + 10);
            pbThem.Location = new Point(pbThem.Location.X - 5, pbThem.Location.Y - 5);
        }

        private void pbThem_MouseLeave(object sender, EventArgs e)
        {
            pbThem.Size = new Size(pbThem.Size.Height - 10, pbThem.Size.Height - 10);
            pbThem.Location = new Point(pbThem.Location.X + 5, pbThem.Location.Y + 5);
        }
    }
}
