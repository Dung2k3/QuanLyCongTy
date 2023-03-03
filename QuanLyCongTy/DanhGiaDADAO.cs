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
            string sqlStr = string.Format("");
            return dbConn.LayDanhSach(sqlStr);
        }
        public void Them(ClassDanhGiaDA dgda)
        {
            string sqlStr1 = string.Format("", dgda.MaDA, dgda.TenDA, dgda.NhanXet, dgda.Thuong);
            dbConn.ThucThi(sqlStr1);
        }
        public void Xoa(ClassDanhGiaDA dgda)
        {
            string sqlStr1 = string.Format("", dgda.MaDA);
            dbConn.ThucThi(sqlStr1);
        }

        public void Sua(ClassDanhGiaDA dgda)
        {
            string sqlStr = string.Format("", dgda.MaDA, dgda.TenDA, dgda.NhanXet, dgda.Thuong);
            dbConn.ThucThi(sqlStr);
        }
    }
}
