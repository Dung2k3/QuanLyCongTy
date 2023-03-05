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
        DuAnDAO DAdao = new DuAnDAO();
        public FDuAn()
        {
            InitializeComponent();
        }

        private void DuAn_Load(object sender, EventArgs e)
        {
            gv_DuAn.DataSource = DAdao.LayDanhSachDuAn();
        }

        private void HienThiDanhSach()
        {
            this.gv_DuAn.DataSource = DAdao.LayDanhSachDuAn();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ClassDuAn da = new ClassDuAn(txt_MaDA.Text, txt_TenDA.Text, txt_MaPB.Text, txt_DD.Text, dtp_deadline.Value, rtxt_MoTa.Text);
            DAdao.Them(da);
            HienThiDanhSach();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            ClassDuAn da = new ClassDuAn(txt_MaDA.Text, txt_TenDA.Text, txt_MaPB.Text, txt_DD.Text, dtp_deadline.Value, rtxt_MoTa.Text);
            DAdao.Xoa(da);
            HienThiDanhSach();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            ClassDuAn da = new ClassDuAn(txt_MaDA.Text, txt_TenDA.Text, txt_MaPB.Text, txt_DD.Text, dtp_deadline.Value, rtxt_MoTa.Text);
            DAdao.Sua(da);
            HienThiDanhSach();
        }

        private void gv_DuAn_DoubleClick(object sender, EventArgs e)
        {
            int i = gv_DuAn.CurrentRow.Index;
            txt_MaDA.Text = gv_DuAn.Rows[i].Cells[0].Value.ToString();
            txt_TenDA.Text = gv_DuAn.Rows[i].Cells[1].Value.ToString();
            txt_MaPB.Text = gv_DuAn.Rows[i].Cells[3].Value.ToString();
            txt_DD.Text= gv_DuAn.Rows[i].Cells[4].Value.ToString();
            dtp_deadline.Text = gv_DuAn.Rows[i].Cells[5].Value.ToString();
            rtxt_MoTa.Text= gv_DuAn.Rows[i].Cells[2].Value.ToString();
        }

        private void gv_DuAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
