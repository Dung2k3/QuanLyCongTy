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
    public partial class UCXemPhanCong : UserControl
    {
        XemPCChuaHTTPBUS xemPCChuaHTTPBUS = new XemPCChuaHTTPBUS();
        public UCXemPhanCong()
        {
            InitializeComponent();
        }
        public void CapNhat(PhanCongModel pc)
        {
            xemPCChuaHTTPBUS.pc = pc;
        }

        private void UCXemPhanCong_Load(object sender, EventArgs e)
        {
            xemPCChuaHTTPBUS.FillControl(lblTenCV, lblGTBatDauLam, lblTGConLai, ucTienDo1, textBox1 );
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
        private void pbXoa_MouseEnter(object sender, EventArgs e)
        {
            pbXoa.Size = new Size(pbXoa.Size.Height + 10, pbXoa.Size.Height + 10);
            pbXoa.Location = new Point(pbXoa.Location.X - 5, pbXoa.Location.Y - 5);
        }

        private void pbXoa_MouseLeave(object sender, EventArgs e)
        {
            pbXoa.Size = new Size(pbXoa.Size.Height - 10, pbXoa.Size.Height - 10);
            pbXoa.Location = new Point(pbXoa.Location.X + 5, pbXoa.Location.Y + 5);
        }

        private void pbThem_Click(object sender, EventArgs e)
        {
            xemPCChuaHTTPBUS.OpenFThemPC();
        }

        private void pbXoa_Click(object sender, EventArgs e)
        {
            xemPCChuaHTTPBUS.OpenFPCXoa();
        }
    }
}
