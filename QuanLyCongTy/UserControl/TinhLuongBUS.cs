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
            cbo.DataSource = phongBanDAO.ListPhongBanTinhLuong();
            cbo.DisplayMember = "TenPB";
            Loadfpl(flp, cbo);
        }
        public void Loadfpl(FlowLayoutPanel flp, Guna2ComboBox cbo)
        {
            flp.Controls.Clear();
            List<NhanVienModel> list;
            if (cbo.Text != "Tất cả")
            {
                list = nhanVienDAO.ListNVChuaPhatLuongTheoPhong(datecal, (PhongBanModel)cbo.SelectedValue);
            }
            else list = nhanVienDAO.ListTatCaNVChuaPhatLuongTheoPhong(datecal, (PhongBanModel)cbo.SelectedValue);

            foreach (NhanVienModel nv in list)
            {
                UCLuongCN uc = new UCLuongCN();
                uc.CapNhat(nv, datecal);
                uc.Checked = false;
                uc.Margin = new Padding(10, 10, 0, 0);
                flp.Controls.Add(uc);
            }
        }
        public void PreMonth(Label lblThang, FlowLayoutPanel flp, Guna2ComboBox cbo, Guna2CustomCheckBox chk)
        {
            datecal = datecal.AddMonths(-1);
            lblThang.Text = "Tháng " + datecal.Month.ToString() + " Năm " + datecal.Year.ToString();
            chk.Checked = false;
            Loadfpl(flp, cbo);
        }
        public void NextMonth(Label lblThang, FlowLayoutPanel flp, Guna2ComboBox cbo, Guna2CustomCheckBox chk)
        {
            datecal = datecal.AddMonths(1);
            lblThang.Text = "Tháng " + datecal.Month.ToString() + " Năm " + datecal.Year.ToString();
            chk.Checked = false;
            Loadfpl(flp, cbo);
        }
        public void CheckChange(Guna2CustomCheckBox chk, FlowLayoutPanel flp)
        {
            foreach (Control ctr in flp.Controls)
            {
                if (ctr is UCLuongCN)
                {
                    UCLuongCN uc = (UCLuongCN)ctr;
                    uc.Checked = chk.Checked;
                }
            }
        }
        public void PhatLuong(FlowLayoutPanel flp, Guna2ComboBox cbo)
        {
            bool flat = false;
            foreach (Control ctr in flp.Controls)
            {
                if (ctr is UCLuongCN)
                {
                    UCLuongCN uc = (UCLuongCN)ctr;
                    if (uc.Checked)
                        if (!luongDAO.Them(uc.GetLuong()))
                        {
                            MessageBox.Show("Không phát được lương");
                            return;
                        }
                        else
                        {
                            flat = true;
                        }

                }
            }
            if (flat)
            {
                MessageBox.Show("Đã phát được lương");
                Loadfpl(flp, cbo);
            }
            else
            {
                MessageBox.Show("Không có đối tượng phát lương");
            }

        }
    }
}
