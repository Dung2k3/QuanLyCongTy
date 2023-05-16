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
        NhanXetDABUS nhanXetDABUS = new NhanXetDABUS();
        int Diem;

        public FNhanXetDA()
        {
            InitializeComponent();
        }
        public void CapNhat(DuAnModel da)
        {
            nhanXetDABUS.da = da;
        }

        private void ThemSao()
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

        private void tangSize(PictureBox ptb)
        {
            ptb.Size = new Size(ptb.Size.Width + 2, ptb.Size.Height + 2);
            ptb.Location = new Point(ptb.Location.X - 1, ptb.Location.Y - 1);
        }

        private void giamSize(PictureBox ptb)
        {
            ptb.Size = new Size(ptb.Size.Width - 2, ptb.Size.Height - 2);
            ptb.Location = new Point(ptb.Location.X + 1, ptb.Location.Y + 1);
        }
        private void FNhanXet_Load(object sender, EventArgs e)
        {
            nhanXetDABUS.FillControl(lbl_TenDA, txt_NhanXet, lbl_ChamDiem,ref Diem);
            ThemSao();
        }

        private void ptbSao1_Click(object sender, EventArgs e)
        {
            lbl_ChamDiem.Text = "Tệ";
            Diem = 20;
            TatSao();
            ThemSao();
        }

        private void ptbSao2_Click(object sender, EventArgs e)
        {
            lbl_ChamDiem.Text = "Chưa tốt";
            Diem = 40;
            TatSao();
            ThemSao();
        }

        private void ptbSao3_Click(object sender, EventArgs e)
        {
            lbl_ChamDiem.Text = "Tốt";
            Diem = 60;
            TatSao();
            ThemSao();
        }

        private void ptbSao4_Click(object sender, EventArgs e)
        {
            lbl_ChamDiem.Text = "Rất tốt";
            Diem = 80;
            TatSao();
            ThemSao();
        }

        private void ptbSao5_Click(object sender, EventArgs e)
        {
            lbl_ChamDiem.Text = "Xuất sắc";
            Diem = 100;
            TatSao();
            ThemSao();
        }

        private void ptbHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ptbHuy_MouseEnter(object sender, EventArgs e)
        {
            tangSize(ptbHuy);
        }

        private void ptbHuy_MouseLeave(object sender, EventArgs e)
        {
            giamSize(ptbHuy);
        }

        private void ptbNhanXet_Click(object sender, EventArgs e)
        {
            nhanXetDABUS.LuuNhanXet(txt_NhanXet, Diem);
            Close();
        }

        private void ptbNhanXet_MouseEnter(object sender, EventArgs e)
        {
            tangSize(ptbNhanXet);
        }

        private void ptbNhanXet_MouseLeave(object sender, EventArgs e)
        {
            giamSize(ptbNhanXet);
        }
    }
}
