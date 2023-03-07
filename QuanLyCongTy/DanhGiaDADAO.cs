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
        public void Them(ClassDanhGiaDA dgda)
        {
            string sqlStr1 = string.Format("UPDATE  DuAn SET  (MaDA, TenDuAn, DanhGia, Thuong) VALUES ('{0}','{1}','{2}','{3}')", 
                                            dgda.MaDA, dgda.TenDA, dgda.NhanXet, dgda.Thuong);
            dbConn.ThucThi(sqlStr1);
        }
        public void Xoa(ClassDanhGiaDA dgda)
        {
            string sqlStr1 = string.Format("DELETE FROM DuAn WHERE MaDA = '{0}'", dgda.MaDA);
            dbConn.ThucThi(sqlStr1);
        }

        public void Sua(ClassDanhGiaDA dgda)
        {
            string sqlStr = string.Format("UPDATE DuAn SET  DanhGia = '{0}', Thuong = '{1}' WHERE MaDA = '{2}'", dgda.NhanXet, dgda.Thuong, dgda.MaDA);
            dbConn.ThucThi(sqlStr);
        }
    }
}
