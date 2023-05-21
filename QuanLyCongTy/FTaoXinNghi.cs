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
    public partial class FTaoXinNghi : Form
    {
        TaoXinNghiBUS taoXinNghiBUS = new TaoXinNghiBUS();
        public FTaoXinNghi()
        {
            InitializeComponent();
        }

        public void CapNhat(NhanVienModel nv)
        {
            taoXinNghiBUS.nv = nv;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbKhac.Checked)
            {
                txtLyDo.Enabled = true;
            }
            else
            {
                txtLyDo.Enabled = false;
            }
        }

        private void btnTaoXN_Click(object sender, EventArgs e)
        {
            taoXinNghiBUS.TaoXinNghi(dtpNgayNghi, txtSoNN, cboLyDo, ckbKhac, txtLyDo);
        }
    }
}
