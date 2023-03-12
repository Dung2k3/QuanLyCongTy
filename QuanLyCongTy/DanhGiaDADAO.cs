using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class DanhGiaDADAO
    {
        DBConnection dbConn = new DBConnection();

        public DataTable LayDanhSachDanhGiaDA()
        {
            string sqlStr = string.Format("SELECT * FROM DuAn");
            return dbConn.LayDanhSach(sqlStr);
        }

        public void Sua(ClassDanhGiaDA dgda)
        {
            string sqlStr = string.Format("UPDATE DuAn SET  DanhGia = N'{0}', Thuong = '{1}' WHERE MaDA = '{2}'", dgda.NhanXet, dgda.Thuong, dgda.MaDA);
            dbConn.ThucThi(sqlStr);
        }
    }
}
