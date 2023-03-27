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
    public partial class UCNgay : UserControl
    {
        public UCNgay()
        {
            InitializeComponent();
        }
        public void songay(int ngay)
        {
            lblDay.Text = ngay + " ";
        }

        private void UCNgay_Load(object sender, EventArgs e)
        {

        }
    }
}
