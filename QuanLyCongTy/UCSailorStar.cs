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
    public partial class UCSailorStar : UserControl
    {
        TienDoDADAO ttdaDAO = new TienDoDADAO();
        DuAnDAO daDAO = new DuAnDAO();
        FDuAn.FReload HamRL;
        string MaDA;
        public UCSailorStar(String MaDA)
        {
            InitializeComponent();
            this.MaDA = MaDA;
        }

        private void UCSailorStar_Load(object sender, EventArgs e)
        {
            TienDoDA da = ttdaDAO.LayDanhSachDuAn(MaDA);
            lbl_tenDA.Text = da.TenDuAn;
            lbl_TenPhong.Text = da.TenPB;
            pgb_TDDA.Minimum = 0;
            pgb_TDDA.Maximum = 100;
            pgb_TDDA.Value = ttdaDAO.LayTienDo(MaDA);
            
            int t = int.Parse(daDAO.LayDiemDA(MaDA));
            int s = 100 - t;
            flpNgoiSao.Padding = new Padding(10,0,0,0);

            while (t > 0)
            {
                PictureBox pb = new PictureBox();
                pb.ImageLocation = "D:\\K2N2\\Winform\\SaoVang.png";
                pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pb.Size = new Size(20, 20);
                flpNgoiSao.Controls.Add(pb);
                t = t - 20;
            }
            
            while (s > 0)
            {
                PictureBox pb = new PictureBox();
                pb.ImageLocation = "D:\\K2N2\\Winform\\VienSaoVang.png";
                pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pb.Size = new Size(20, 20);
                flpNgoiSao.Controls.Add(pb);
                s = s - 20;
            }
        }
        public void addReLoat(FDuAn.FReload HamRL)
        {
            this.HamRL = HamRL;
        }
    }
}
