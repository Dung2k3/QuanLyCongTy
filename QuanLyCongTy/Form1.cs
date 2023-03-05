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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_ShowForm.Controls.Add(childForm);
            panel_ShowForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void btn_DanhGia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhGia());
            lbl_Title.Text = btn_DanhGia.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FDangNhap());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
