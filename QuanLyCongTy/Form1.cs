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
        public Form1(string ma)
        {
            InitializeComponent();
            uc.Ma = ma;
            ucMenuBtn1.SetupButon(ColorTranslator.FromHtml("#8BC240"), uc, new FCheckinout(ma));
            ucMenuBtn2.SetupButon(ColorTranslator.FromHtml("#126881"), uc, new FDuAn());
            ucMenuBtn3.SetupButon(ColorTranslator.FromHtml("#A12059"), uc, new FDanhGiaDA());
            ucMenuBtn5.SetupButon(ColorTranslator.FromHtml("#A12059"), uc, new FDangNhap());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
