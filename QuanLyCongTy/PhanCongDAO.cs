using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class PhanCongDAO
    {
        DBConnection dbConn = new DBConnection();

        public DataTable LayDanhSachPhanCong()
        {
            string sqlStr = string.Format("");
            return dbConn.LayDanhSach(sqlStr);
        }
        public void Them(ClassPhanCong pc)
        {
            string sqlStr1 = string.Format("", pc.MaNV, pc.MaDA, pc.CongViec, pc.Deadline);
            dbConn.ThucThi(sqlStr1);
        }
        public void Xoa(ClassPhanCong pc)
        {
            string sqlStr1 = string.Format("", pc.MaNV, pc.MaDA);
            dbConn.ThucThi(sqlStr1);
        }

        public void Sua(ClassPhanCong pc)
        {
            string sqlStr = string.Format("", pc.MaNV, pc.MaDA, pc.CongViec,pc.Deadline);
            dbConn.ThucThi(sqlStr);
        }
    }
}
