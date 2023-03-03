using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class DanhGiaDAO
    {
        DBConnection dbConn = new DBConnection();

        public DataTable LayDanhSachDanhGia()
        {
            string sqlStr = string.Format("SELECT * FROM PhanCong");
            return dbConn.LayDanhSach(sqlStr);
        }
        public void Them(ClassDanhGia dg)
        {
            string sqlStr1 = string.Format("INSERT INTO PhanCong(MaNV, MaDA, NhanXet, ChamCong) VALUES ('{0}', '{1}', '{2}', '{3}') ",
                                            dg.MaNV,dg.MaDA, dg.NhanXet, dg.ChamCong);
            dbConn.ThucThi(sqlStr1);
        }
        public void Xoa(ClassDanhGia dg)
        {
            string sqlStr1 = string.Format("DELETE FROM PhanCong WHERE MaNV = '{0}' and MaDA = '{1}'", dg.MaNV, dg.MaDA);
            dbConn.ThucThi(sqlStr1);
        }

        public void Sua(ClassDanhGia dg)
        {
            string sqlStr = string.Format("UPDATE PhanCong SET MaNV = '{0}', MaDA = '{1}', NhanXet = '{2}', ChamCong = '{3}' WHERE MaNV = '{4}'", dg.MaNV,dg.MaDA, dg.NhanXet, dg.ChamCong, dg.MaNV);
            dbConn.ThucThi(sqlStr);
        }
    }
}
