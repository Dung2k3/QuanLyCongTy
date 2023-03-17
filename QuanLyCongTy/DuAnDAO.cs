using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class DuAnDAO
    {
        DBConnection dbConn = new DBConnection();
        public DataTable LayDanhSachDuAnChuaHT()
        {
            string sqlStr = string.Format("SELECT MaDA " +
                                           "FROM DuAn " +
                                           "WHERE MaDA IN (SELECT MaDA " +
                                                           "FROM PhanCong" +
                                                         " Where TienDo < 100)");
            return dbConn.LayDanhSach(sqlStr);
        }

        public DataTable LayDanhSachDuAnDaHT()
        {
            string sqlStr = string.Format("SELECT MaDA " +
                                           "FROM DuAn " +
                                           "WHERE MaDA NOT IN (SELECT MaDA " +
                                                           "FROM PhanCong" +
                                                         " Where TienDo < 100)");
            return dbConn.LayDanhSach(sqlStr);
        }
    }
}
