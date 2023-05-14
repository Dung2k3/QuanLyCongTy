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
    public partial class FNhanXetDA : Form
    {
        NhanXetDADAO nxdaDAO = new NhanXetDADAO();
        string MaDA;
        float Diem;

        public FNhanXetDA(string MaDA)
        {
            InitializeComponent();
            this.MaDA = MaDA;
        }
        
        private void FNhanXet_Load(object sender, EventArgs e)
        {
            nxdaDAO.LayThongTinDA(MaDA);
            NhanXetDA nx = nxdaDAO.LayThongTinDA(MaDA);
            LayXepLoai(nx.ChamDiem);
            lblTenDA.Text = nx.TenDA;
            txtNhanXet.Text = nx.DanhGia;
            RatingStar.Value = nx.ChamDiem / 20;
        }

        private void LayXepLoai(float diem)
        {
            lblXepLoai.Text = nxdaDAO.LayChamDiem(diem);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanXetDA nx = new NhanXetDA(MaDA, lblTenDA.Text, txtNhanXet.Text, Diem);
            nxdaDAO.Sua(nx);
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RatingStar_ValueChanged(object sender, EventArgs e)
        {
            Diem = float.Parse(RatingStar.Value.ToString()) * 20;
            LayXepLoai(Diem);
        }
    }
}
