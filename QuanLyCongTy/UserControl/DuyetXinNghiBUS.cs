using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class DuyetXinNghiBUS
    {
        XinNghiDAO xinNghiDAO = new XinNghiDAO();
        DangNhapDAO dnDao = new DangNhapDAO();
        NhanVienModel nv;

        public void CapNhat(NhanVienModel nv)
        {
            this.nv = nv;
        }
    }
}
