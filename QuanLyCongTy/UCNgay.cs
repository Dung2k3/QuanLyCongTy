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
    public partial class UCNgay : UserControl
    {
        LichDAO lichDAO = new LichDAO();
        public UCNgay()
        {
            InitializeComponent();
        }
        public void songay(int ngay)
        {
            lblDay.Text = ngay + " ";
        }

        public void kiemtraDL(int year, int month, int day)
        {
            DateTime datecheck = new DateTime(year, month, day);
            LichDA lda = lichDAO.KiemtraDL(datecheck);

            if (lda != null)
            {
                lbldl.Text = "dl da";
                this.BackColor = Color.Pink;
            }
        }
        public void kiemtraBD(int year, int month, int day)
        {
            DateTime datecheck = new DateTime(year, month, day);
            LichDA lda = lichDAO.KiemtraBD(datecheck);

            if (lda != null)
            {
                lbldl.Text = "bd da";
                this.BackColor = Color.Green;
            }
        }

        private void UCNgay_Load(object sender, EventArgs e)
        {
        }
    }
}
