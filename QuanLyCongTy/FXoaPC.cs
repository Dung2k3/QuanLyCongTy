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
    public partial class FXoaPC : Form
    {
        PhanCongDAO phanCongDAO = new PhanCongDAO();
        PhanCongModel pc;
        public FXoaPC()
        {
            InitializeComponent();
        }

        public void CapNhat(PhanCongModel pc)
        {
            this.pc = pc;
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            phanCongDAO.Xoa(pc);
            Close();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
