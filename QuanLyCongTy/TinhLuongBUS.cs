using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace QuanLyCongTy
{
    internal class TinhLuongBUS
    {
        public LuongModel luong;
        DateTime datecal = DateTime.Today;
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        PhongBanDAO phongBanDAO = new PhongBanDAO();
        LuongDAO luongDAO = new LuongDAO();
        public void FillControl(Label lblThang, FlowLayoutPanel flp, Guna2ComboBox cbo)
        {
            lblThang.Text = "Tháng " + datecal.Month.ToString() + " Năm " + datecal.Year.ToString();
            cbo.DataSource = phongBanDAO.ListPhongBan();
            cbo.DisplayMember = "TenPB";
            Loadfpl(flp, cbo);
        }
        public void Loadfpl(FlowLayoutPanel flp, Guna2ComboBox cbo)
        {
            flp.Controls.Clear();
            List<NhanVienModel> list = nhanVienDAO.ListNVChuaPhatLuongTheoPhong(datecal,(PhongBanModel)cbo.SelectedValue);
            foreach (NhanVienModel nv in list)
            {
                UCLuongCN uc = new UCLuongCN();
                uc.CapNhat(nv,datecal);
                uc.Checked = false;
                uc.Margin = new Padding(10, 10, 0, 0);
                flp.Controls.Add(uc);
            }
        }
        public void PreMonth(Label lblThang, FlowLayoutPanel flp, Guna2ComboBox cbo)
        {
            datecal = datecal.AddMonths(-1);
            lblThang.Text = "Tháng " + datecal.Month.ToString() + " Năm " + datecal.Year.ToString();
            Loadfpl(flp, cbo);
        }
        public void NextMonth(Label lblThang, FlowLayoutPanel flp, Guna2ComboBox cbo)
        {
            datecal = datecal.AddMonths(1);
            lblThang.Text = "Tháng " + datecal.Month.ToString() + " Năm " + datecal.Year.ToString();
            Loadfpl(flp, cbo);
        }
        public void CheckChange(Guna2CustomCheckBox chk, FlowLayoutPanel flp)
        {
            foreach(Control ctr in flp.Controls)
            {
                if(ctr is UCLuongCN)
                {
                    UCLuongCN uc = (UCLuongCN)ctr;
                    uc.Checked = chk.Checked;
                }
            }
        }
        public void PhatLuong(FlowLayoutPanel flp, Guna2ComboBox cbo)
        {
            foreach (Control ctr in flp.Controls)
            {
                if (ctr is UCLuongCN)
                {
                    UCLuongCN uc = (UCLuongCN)ctr;
                    if(uc.Checked && luongDAO.Them(uc.GetLuong())) { }
                    else
                    {
                        MessageBox.Show("Không thêm được lương");
                        return;
                    }

                }
            }
            Loadfpl(flp, cbo);
        }
    }
}
