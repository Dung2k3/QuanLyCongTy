using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class TaoXinNghiBUS
    {
        XinNghiDAO xinNghiDAO = new XinNghiDAO();
        public NhanVienModel nv;

        public void TaoXinNghi(Guna2DateTimePicker dtp, Guna2TextBox txt, Guna2ComboBox cbo, Guna2CustomCheckBox chk, Guna2TextBox txtLyDo)
        {
            XinNghiModel xn;
            if (chk.Checked) xn = new XinNghiModel(nv.MaNV, dtp.Value, int.Parse(txt.Text), txtLyDo.Text, -1);
            else xn = new XinNghiModel(nv.MaNV,  dtp.Value, int.Parse(txt.Text), cbo.Text, -1);

            if (xinNghiDAO.Them(xn)) MessageBox.Show("Thêm thành công!");
        }


    }
}
