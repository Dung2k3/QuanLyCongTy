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
    public partial class FTruongPhong : Form
    {
        string maTP;
        TruongPhongDao tpDao = new TruongPhongDao();
        public FTruongPhong(string maTP)
        {
            InitializeComponent();
            this.maTP = maTP;
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

        private void btnCheckinout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FCheckinout(maTP));
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FTruongPhong_Load(object sender, EventArgs e)
        {
            lblName.Text = tpDao.GetTenTP(this.maTP);
        }

        private void btnTaoPC_Click(object sender, EventArgs e)
        {

        }
    }
}
