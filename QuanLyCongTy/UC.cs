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
        public string Ma 
        {
            set 
            { 
                ma = value;
                lblName.Text = nvDao.GetTenNV(value);
            } 
        }
        NhanVienDao nvDao = new NhanVienDao();
        public UC()
        {
            InitializeComponent();
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

        }
    }
}
