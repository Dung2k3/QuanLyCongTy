using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class UCSailorStar : UserControl
    {
        XemDADaHTQLBUS xemDADaHTQLBUS = new XemDADaHTQLBUS();
        public UCSailorStar()
        {
            InitializeComponent();
        }
        public void CapNhat(DuAnModel da)
        {
            xemDADaHTQLBUS.da = da;
        }
        private void UCSailorStar_Load(object sender, EventArgs e)
        {
            xemDADaHTQLBUS.FillControls(lbl_tenDA, lbl_TenPhong, prgTienDo, rstChamDiem);
        }
        public void addReLoat(FDuAn.FReload HamRL)
        {
            xemDADaHTQLBUS.HamRL = HamRL;
        }

        private void UCSailorStar_Click(object sender, EventArgs e)
        {
            xemDADaHTQLBUS.OpenFNhanXet(this);
        }
    }
}
