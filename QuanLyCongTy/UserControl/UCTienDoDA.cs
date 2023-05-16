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
    public partial class UCTienDoDA : UserControl
    {
        TienDoDADAO ttdaDAO = new TienDoDADAO();
        SuaDADAO suaDADAO = new SuaDADAO();
        string MaDA;
        FDuAn.FReload HamRL;
        UCTienDoDA uctd;
        public UCTienDoDA(string MaDA)
        {
            InitializeComponent();
            this.MaDA = MaDA;
        }

        private void UCTienDoDA_Load(object sender, EventArgs e)
        {
            TienDoDA td = ttdaDAO.LayDanhSachDuAn(MaDA);

            lblTenDA.Text = td.TenDuAn;
            lblTenPhong.Text = td.TenPB;
            lblNgayConLai.Text = "Thời hạn: Còn " + td.NgayKT.Subtract(td.NgayBD).Days.ToString() + " ngày.";
            prgTienDo.Value = ttdaDAO.LayTienDo(MaDA);
            lblTienDo.Text = ttdaDAO.LayTienDo(MaDA).ToString() + "%";
        }

        private void ptbSetting_Click(object sender, EventArgs e)
        {
            Form form = new FSuaDA(MaDA);
            Enabled = false;
            form.ShowDialog();
            Enabled = true;
            HamRL();
        }

        private void ptbDelete_Click(object sender, EventArgs e)
        {
            Form form = new FThongBao(MaDA);
            Enabled = false;
            form.ShowDialog();
            Enabled = true;
            HamRL();
        }
        public void addReLoat(FDuAn.FReload HamRL)
        {
            this.HamRL = HamRL;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Form form = new FThongBao(MaDA);
            Enabled = false;
            form.ShowDialog();
            Enabled = true;
            HamRL();
        }

        private void ptbBG_Click(object sender, EventArgs e)
        {
            Form form = new FSuaDA(MaDA);
            Enabled = false;
            form.ShowDialog();
            Enabled = true;
            HamRL();
        }
    }
}
