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

        private void btnClickChangeColor(Control btn, string color)
        {
            btnCheckinout.BackColor = ColorTranslator.FromHtml("#33334C");
            btnTaoDA.BackColor = ColorTranslator.FromHtml("#33334C");
            btnDanhGiaDA.BackColor = ColorTranslator.FromHtml("#33334C");
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
            btnClickChangeColor(btnCheckinout, "#8BC240");
            lblTitle.Text = btnCheckinout.Text;
        }


        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FQuanLy_Load(object sender, EventArgs e)
        {
            lblName.Text = qlDao.GetTenQL(this.maQL);
            OpenChildForm(new FThongTin(maQL));
            btnClickChangeColor(pnlTitle, "#33334C");
            lblTitle.Text = "Thông tin nhân viên";
        }

        private void btnTaoDA_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDuAn());
            btnClickChangeColor(btnTaoDA, "#126881");
        }

        private void btnDanhGiaDA_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhGiaDA());
            btnClickChangeColor(btnDanhGiaDA, "#A12059");
        }

        private void btnXinNghi_Click(object sender, EventArgs e)
        {
            btnClickChangeColor(btnXinNghi, "#364D5B");
            OpenChildForm(new FXinNghi());
        }
        private void panelName_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FThongTin(maQL));
            btnClickChangeColor(panelName, "#33334C");
            btnClickChangeColor(pnlTitle, "#33334C");
            lblTitle.Text = "Thông tin nhân viên";
        }
    }
}
