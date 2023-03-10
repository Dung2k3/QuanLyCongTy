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
    public partial class ucMenuBtn : UserControl
    {
        Color color;
        UC uc;
        Form childForm;
        public ucMenuBtn()
        {
            InitializeComponent();
        }
        public void SetupButon(Color color,UC uc,Form childForm)
        {
            this .color = color;
            this .uc = uc;
            this .childForm = childForm;
            uc.AddChildForm(childForm);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in Parent.Controls)
            {
                if (ctrl is ucMenuBtn)
                {
                    ucMenuBtn btns = (ucMenuBtn)ctrl;
                    btns.btn.BackColor = ColorTranslator.FromHtml("#33334C");
                }
            }
            btn.BackColor = color;
            uc.btn_Click(btn);
            uc.OpenChildForm(childForm);
        }
    }
}
