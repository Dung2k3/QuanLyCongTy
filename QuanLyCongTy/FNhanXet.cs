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
    public partial class FNhanXet : Form
    {
        NhanXetDADAO nxdaDAO = new NhanXetDADAO();
        string MaDA;
        int Diem;

        public FNhanXet(string MaDA)
        {
            InitializeComponent();
            this.MaDA = MaDA;
        }

        private void ThemSao(int Diem)
        {
            if(Diem == 0) return;
            if (Diem == 20)
            {
                ptbSao1.Image = Properties.Resources.SaoVang;
                return;
            }
            if(Diem == 40)
            {
                ptbSao1.Image = Properties.Resources.SaoVang;
                ptbSao2.Image = Properties.Resources.SaoVang;
                return;
            }
            if( Diem == 60)
            {
                ptbSao1.Image = Properties.Resources.SaoVang;
                ptbSao2.Image = Properties.Resources.SaoVang;
                ptbSao3.Image = Properties.Resources.SaoVang;
                return;
            }
            if(Diem == 80)
            {
                ptbSao1.Image = Properties.Resources.SaoVang;
                ptbSao2.Image = Properties.Resources.SaoVang;
                ptbSao3.Image = Properties.Resources.SaoVang;
                ptbSao4.Image = Properties.Resources.SaoVang;
                return;
            }
            if(Diem==100)
            {
                ptbSao1.Image = Properties.Resources.SaoVang;
                ptbSao2.Image = Properties.Resources.SaoVang;
                ptbSao3.Image = Properties.Resources.SaoVang;
                ptbSao4.Image = Properties.Resources.SaoVang;
                ptbSao5.Image = Properties.Resources.SaoVang;
                return;
            }
        }

        private void TatSao()
        {
            ptbSao1.Image = Properties.Resources.VienSaoVang;
            ptbSao2.Image = Properties.Resources.VienSaoVang;
            ptbSao3.Image = Properties.Resources.VienSaoVang;
            ptbSao4.Image = Properties.Resources.VienSaoVang;
            ptbSao5.Image = Properties.Resources.VienSaoVang;
        }

        private void btnNhanXet_Click(object sender, EventArgs e)
        {
            NhanXetDA nx = new NhanXetDA(MaDA, lbl_TenDA.Text, txt_NhanXet.Text, Diem);
            nxdaDAO.Sua(nx);
            Close();
        }
        private void FNhanXet_Load(object sender, EventArgs e)
        {
            nxdaDAO.LayThongTinDA(MaDA);
            NhanXetDA nx = nxdaDAO.LayThongTinDA(MaDA);

            lbl_TenDA.Text = nx.TenDA;
            txt_NhanXet.Text = nx.DanhGia;
            lbl_ChamDiem.Text = nxdaDAO.LayChamDiem(nx.ChamDiem);
            ThemSao(nx.ChamDiem);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ptbSao1_Click(object sender, EventArgs e)
        {
            lbl_ChamDiem.Text = "Tệ";
            Diem = 20;
            TatSao();
            ThemSao(Diem);
        }

        private void ptbSao2_Click(object sender, EventArgs e)
        {
            lbl_ChamDiem.Text = "Chưa tốt";
            Diem = 40;
            TatSao();
            ThemSao(Diem);
        }

        private void ptbSao3_Click(object sender, EventArgs e)
        {
            lbl_ChamDiem.Text = "Tốt";
            Diem = 60;
            TatSao();
            ThemSao(Diem);
        }

        private void ptbSao4_Click(object sender, EventArgs e)
        {
            lbl_ChamDiem.Text = "Rất tốt";
            Diem = 80;
            TatSao();
            ThemSao(Diem);
        }

        private void ptbSao5_Click(object sender, EventArgs e)
        {
            lbl_ChamDiem.Text = "Xuất sắc";
            Diem = 100;
            TatSao();
            ThemSao(Diem);
        }
    }
}
