using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class DangNhapDao
    {
        DBConnection dbConn = new DBConnection();
        public string KTTaiKhoan(DangNhap dn)
        {
            string sqlStr = string.Format("SELECT * FROM TaiKhoan");
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            foreach (DataRow row in dt.Rows)
            {
                if (row.ItemArray[1].ToString().Equals(dn.Taikhoan) && row.ItemArray[2].ToString().Equals(dn.Matkhau))
                    return row.ItemArray[0].ToString();
            }
            return null;
        }
    }
}
