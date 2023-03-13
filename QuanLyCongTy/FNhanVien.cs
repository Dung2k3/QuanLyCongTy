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
    public partial class FNhanVien : Form
    {
        string maNV;
        NhanVienDao nvDao = new NhanVienDao();
        public FNhanVien(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlNoiDung.Controls.Add(childForm);
            pnlNoiDung.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void FNhanVien_Load(object sender, EventArgs e)
        {
            lblName.Text = nvDao.GetTenNV(this.maNV);
        }


        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCheckinout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FCheckinout(maNV));
        }

        private void btnXinNghi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FXinNghi());
        }

        private void btn_KPI_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FKPI());
        }
    }
}
