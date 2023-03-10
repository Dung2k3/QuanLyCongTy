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

        private void btnClickChangeColor(Control btn, string color)
        {
            btnCheckinout.BackColor = ColorTranslator.FromHtml("#33334C");
            btnTaoPC.BackColor = ColorTranslator.FromHtml("#33334C");
            btnDanhGiaPC.BackColor = ColorTranslator.FromHtml("#33334C");
            btnXinNghi.BackColor = ColorTranslator.FromHtml("#33334C");
            btn.BackColor = ColorTranslator.FromHtml(color);
            pnlTitle.BackColor = ColorTranslator.FromHtml(color);
            lblTitle.Text = btn.Text;
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
            btnClickChangeColor(btnCheckinout, "#8BC240");
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FTruongPhong_Load(object sender, EventArgs e)
        {
            lblName.Text = tpDao.GetTenTP(this.maTP);
            OpenChildForm(new FThongTin(maTP));
            btnClickChangeColor(pnlTitle, "#33334C");
            lblTitle.Text = "Thông tin nhân viên";
        }

        private void btnTaoPC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FPhanCong());
            btnClickChangeColor(btnTaoPC, "#126881");
        }

        private void btnDanhGiaPC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhGia());
            btnClickChangeColor(btnDanhGiaPC, "#A12059");
        }

        private void btnXinNghi_Click(object sender, EventArgs e)
        {
            btnClickChangeColor(btnXinNghi, "#364D5B");
        }
        private void panelName_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FThongTin(maTP));
            btnClickChangeColor(panelName, "#33334C");
            btnClickChangeColor(pnlTitle, "#33334C");
            lblTitle.Text = "Thông tin nhân viên";
        }
    }
}
