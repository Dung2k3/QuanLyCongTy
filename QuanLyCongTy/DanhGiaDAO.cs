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
            string sqlStr = string.Format("");
            return dbConn.LayDanhSach(sqlStr);
        }
        public void Them(ClassDanhGia dg)
        {
            string sqlStr1 = string.Format("",dg.MaNV,dg.MaDA, dg.NhanXet, dg.ChamCong);
            dbConn.ThucThi(sqlStr1);
        }
        public void Xoa(ClassDanhGia dg)
        {
            string sqlStr1 = string.Format("", dg.MaNV, dg.MaDA);
            dbConn.ThucThi(sqlStr1);
        }

        public void Sua(ClassDanhGia dg)
        {
            string sqlStr = string.Format("", dg.MaNV,dg.MaDA, dg.NhanXet, dg.ChamCong);
            dbConn.ThucThi(sqlStr);
        }
    }
}
