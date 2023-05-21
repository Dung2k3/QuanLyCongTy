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
        PhanCongDAO phanCongDAO = new PhanCongDAO();

        public void FillFlpTienDo(FlowLayoutPanel flp, Guna2CircleProgressBar pr, Label lbl)
        {
            flp.Controls.Clear();
            List<PhanCongModel> list = phanCongDAO.ListPCTheoDA(da.MaDA);
            int value = 0;
            pr.Value = value;
            foreach (PhanCongModel pc in list)
            {
                UCTienDoCaNhan uc = new UCTienDoCaNhan();
                uc.CapNhat(pc);
                flp.Controls.Add(uc);
                value = value + pc.TienDo;
            }
            if (list.Count != 0)    pr.Value = value / (list.Count);
            lbl.Text = pr.Value.ToString() + "%";
        }
    }
}
