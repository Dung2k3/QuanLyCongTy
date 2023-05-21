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
    public partial class FDuyetXinNghi : Form
    {

        XinNghiDAO xinNghiDAO = new XinNghiDAO();
        DangNhapDAO dnDao = new DangNhapDAO();
        NhanVienModel nv;
        public FDuyetXinNghi()
        {
            InitializeComponent();
        }
        public void CapNhat(NhanVienModel nv)
        {
            this.nv = nv;
        }
        private void FXinNghi_Load(object sender, EventArgs e)
        {
            XNChuaDuyet();
        }

        public delegate void FReload();

        private void XNChuaDuyet()
        {
            flp.Controls.Clear();
            shape.FillColor = ColorTranslator.FromHtml("#0076D4");

            //DataTable dt = xinNghiDAO.LayDanhSachChuaDuyetXinNghi();
            List<XinNghiModel> list = xinNghiDAO.LayListXinNghiChuaDuyet();
            bool check = dnDao.KTTruongPhong(nv.MaNV) || dnDao.KTQuanLy(nv.MaNV);

            foreach (XinNghiModel xn in list)
            {
                UCXemXinNghiChuaDuyet uc = new UCXemXinNghiChuaDuyet();
                uc.CapNhat(xn, XNChuaDuyet, check);
                flp.Controls.Add(uc);
            }
        }
        private void XNDaDuyet()
        {
            flp.Controls.Clear();
            shape.FillColor = ColorTranslator.FromHtml("#128C7E");

            List<XinNghiModel> list = xinNghiDAO.LayListXinNghiDaDuyet();
            foreach (XinNghiModel xn in list)
            {
                UCXemXinNghiDaDuyet uc = new UCXemXinNghiDaDuyet();
                uc.CapNhat(xn);
                flp.Controls.Add(uc);
            }
        }

        private void btnDaDuyet_CheckedChanged(object sender, EventArgs e)
        {
            XNDaDuyet();
        }

        private void btnChuaDuyet_CheckedChanged(object sender, EventArgs e)
        {
            XNChuaDuyet();
        }
    }
}
