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
    public partial class UC : UserControl
    {
        string ma;

        FThongTin form;
        public string Ma 
        {
            set 
            { 
                ma = value;
                lblName.Text = nvDao.GetTenNV(value);
                form = new FThongTin(value);
            } 

        }
        NhanVienDAO nvDao = new NhanVienDAO();
        public UC()
        {
            InitializeComponent();
        }

 
        public void TatMau()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is ucMenuBtn)
                {
                    ucMenuBtn btns = (ucMenuBtn)ctrl;
                    btns.BackColor = ColorTranslator.FromHtml("#33334C");
                }
            }
        }


        public void btn_Click(Button btn)
        {
            pnlTitle.BackColor = btn.BackColor;
            lblTitle.Text = btn.Text;
        }
        private Form currentFormChild;
        public void AddChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlNoiDung.Controls.Add(childForm);
            pnlNoiDung.Tag = childForm;
        }
        public void OpenChildForm(Form childForm)
        {
            
            if (currentFormChild != null)
            {
                currentFormChild.Hide();
            }
            currentFormChild = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void UC_Load(object sender, EventArgs e)
        {
            AddChildForm(form);
            OpenChildForm(form);
            lblTitle.Text = "Thông tin nhân viên";
            pnlTitle.BackColor = ColorTranslator.FromHtml("#33334C");
        }

        private void panelName_Click(object sender, EventArgs e)
        {
            OpenChildForm(form);
            TatMau();
            lblTitle.Text = "Thông tin nhân viên";
            pnlTitle.BackColor = ColorTranslator.FromHtml("#33334C");
        }
    }
}
