using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class KPIBUS
    {
        public NhanVienModel nv;
        FlowLayoutPanel flp;
        PhanCongDAO phanCongDAO = new PhanCongDAO();
        public void AddFlp(FlowLayoutPanel flp)
        {
            this.flp = flp;
        }
        public void Fillflp()
        {
            flp.Controls.Clear();
            List<PhanCongModel> list = phanCongDAO.ListPCChuaHTTheoNV(nv);
            foreach (PhanCongModel pc in list)
            {
                UCXemPhanCong_NhanVien uc = new UCXemPhanCong_NhanVien();
                uc.CapNhat(pc, Fillflp);
                flp.Controls.Add(uc);
            }
        }
    }
}
