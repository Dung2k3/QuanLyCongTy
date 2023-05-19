using Guna.Charts.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyCongTy
{
    internal class ChartDABUS
    {
        public DuAnModel da;
        public PhanCongModel pc;
        public Reload.Flp rl;
        PhanCongDAO phanCongDAO = new PhanCongDAO();

        public void FillProTienDo(Guna2CircleProgressBar pr, Label lbl)
        {
            List<PhanCongModel> list = phanCongDAO.ListPCTheoDA(da.MaDA);
            int value = 0;
            foreach (PhanCongModel pc in list)
            {
                value = value + pc.TienDo;
            }
            pr.Value = value / (list.Count);
            lbl.Text = pr.Value.ToString() + "%";
        }

        public void FillFlpTienDo(FlowLayoutPanel flp)
        {
            flp.Controls.Clear();
            List<PhanCongModel> listPCChuaHTTheoDA = phanCongDAO.ListPCTheoDA(da.MaDA);
            foreach (PhanCongModel pc in listPCChuaHTTheoDA)
            {
                UCTienDoCaNhan uc = new UCTienDoCaNhan();
                uc.CapNhat(pc);
                flp.Controls.Add(uc);
            }
        }
    }
}
