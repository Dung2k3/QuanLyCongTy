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
    public partial class FThongBao : Form
    {
        string MaDA;
        SuaDADAO suaDADAO = new SuaDADAO();
        public FThongBao(string maDA)
        {
            InitializeComponent();
            this.MaDA = maDA;
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            suaDADAO.Xoa(MaDA);
            Close();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
