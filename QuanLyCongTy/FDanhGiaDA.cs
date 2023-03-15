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
    public partial class FDanhGiaDA : Form
    {
        DanhGiaDADAO DGDAdao = new DanhGiaDADAO();
        public FDanhGiaDA()
        {
            InitializeComponent();
        }

        private void DanhGiaDA_Load(object sender, EventArgs e)
        {
            gv_DanhGiaDA.DataSource = DGDAdao.LayDanhSachDanhGiaDA();
        }
        private void HienThiDanhSach()
        {
            this.gv_DanhGiaDA.DataSource = DGDAdao.LayDanhSachDanhGiaDA();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DanhGiaDA dgda = new DanhGiaDA(txt_MaDA.Text, txt_TenDA.Text, rtxt_NhanXet.Text, long.Parse(txt_Thuong.Text));
            DGDAdao.Sua(dgda);
            HienThiDanhSach();
        }

        private void gv_DanhGiaDA_MouseClick(object sender, MouseEventArgs e)
        {
            int i = gv_DanhGiaDA.CurrentRow.Index;
            txt_MaDA.Text = gv_DanhGiaDA.Rows[i].Cells[0].Value.ToString();
            txt_TenDA.Text = gv_DanhGiaDA.Rows[i].Cells[1].Value.ToString();
            rtxt_NhanXet.Text = gv_DanhGiaDA.Rows[i].Cells[6].Value.ToString();
            txt_Thuong.Text = gv_DanhGiaDA.Rows[i].Cells[7].Value.ToString();
        }

        private void txt_Thuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void gv_DanhGiaDA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
