using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyCongTy
{
    public partial class FThemTroGiup : Form
    {
        ThemHoTroBUS themTroGiupBUS = new ThemHoTroBUS();
        public FThemTroGiup()
        {
            InitializeComponent();
        }
        public void CapNhat(PhanCongModel pc)
        {
            themTroGiupBUS.pc = pc;

        }
        private void HienThiDanhSach()
        {
            themTroGiupBUS.Fillgv(gv_CongViec);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FThemTroGiup_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void gv_CongViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            themTroGiupBUS.AddListBox(gv_CongViec, listBox1);
            
        }
        private void btnThemTroGiup_Click(object sender, EventArgs e)
        {
            themTroGiupBUS.ThemHoTro(listBox1);
            Close();
        }
    }
}