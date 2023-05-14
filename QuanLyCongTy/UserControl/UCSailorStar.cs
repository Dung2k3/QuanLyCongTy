using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            prgTienDo.Value = ttdaDAO.LayTienDo(MaDA);
            lblTienDo.Text = ttdaDAO.LayTienDo(MaDA).ToString() + "%";

            float t = float.Parse(daDAO.LayDiemDA(MaDA));
            RatingStar.Value = t / 20;
        }
        public void addReLoat(FDuAn.FReload HamRL)
        {
            this.HamRL = HamRL;
        }

        private void ptbBG_Click(object sender, EventArgs e)
        {
            Form form = new FNhanXetDA(MaDA);
            Enabled = false;
            form.ShowDialog();
            Enabled = true;
            HamRL();
        }
    }
}
