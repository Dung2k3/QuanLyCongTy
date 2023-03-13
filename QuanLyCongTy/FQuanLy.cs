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
    public partial class FQuanLy : Form
    {
        string maQL;
        QuanLyDao qlDao = new QuanLyDao();
        public FQuanLy(string maQL)
        {
            InitializeComponent();
            this.maQL = maQL;
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlNoiDung.Controls.Add(childForm);
            pnlNoiDung.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnCheckinout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FCheckinout(maQL));
        }


        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FQuanLy_Load(object sender, EventArgs e)
        {
            lblName.Text = qlDao.GetTenQL(this.maQL);
        }

        private void btnTaoDA_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDuAn());
        }

        private void btnDanhGiaDA_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhGiaDA());
        }

        private void btnXinNghi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FXinNghi());
        }
    }
}
