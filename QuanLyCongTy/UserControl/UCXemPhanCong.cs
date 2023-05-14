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
    public partial class UCXemPhanCong : UserControl
    {
        string maPB;
        string maDA;
        string maCV;
        PhanCongDAO PCdao;
        public UCXemPhanCong()
        {
            InitializeComponent();
        }
        public void Set(string maPB, string maDA, string maCV)
        {
            this.maPB = maPB;
            this.maDA = maDA;
            this.maCV = maCV;
            PCdao = new PhanCongDAO(maPB);
        }
        private bool Check()
        {
            return (maPB != null && maDA != null && maCV != null && PCdao != null);
        }
        private void UCXemPhanCong_Load(object sender, EventArgs e)
        {
            if (!Check())
                return;
            PhanCong pc = PCdao.ThongTinPC(maCV, maDA);
            lblTenCV.Text = pc.CongViec;
            lblGTBatDauLam.Text = "Ngày bắt đầu: "+pc.NgayBatDau.ToString("dd/MM/yyyy");
            lblTGConLai.Text ="Còn " + (pc.Deadline.Subtract(DateTime.Now)).Days.ToString() + " Ngày";
            //ucTienDo.Change(pc.TienDo);
            textBox1.Text = PCdao.DSTenNVThamGia(maCV, maDA);
        }

        private void pbThem_Click(object sender, EventArgs e)
        {
            FThemTroGiup fThemTroGiup = new FThemTroGiup();
            fThemTroGiup.Set(maPB, maDA, maCV);
            Hide();
            fThemTroGiup.ShowDialog();
            Show();
        }

        private void UCXemPhanCong_Click(object sender, EventArgs e)
        {
            FChinhPhanCong fChinhPhanCong = new FChinhPhanCong(maDA, maPB, maCV);
            Hide();
            fChinhPhanCong.ShowDialog();
            Show();
       
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FThemTroGiup fThemTroGiup = new FThemTroGiup();
            fThemTroGiup.Set(maPB, maDA, maCV);
            Hide();
            fThemTroGiup.ShowDialog();
            Show();
        }
    }
}
