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

        public DataTable LayDanhSachDuAn()
        {
            string sqlStr = string.Format("");
            return dbConn.LayDanhSach(sqlStr);
        }
        public void Them(ClassDuAn da)
        { 
            string sqlStr1 = string.Format("", da.MaDA, da.TenDA, da.MaPhongBan, da.DiaDiem,da.ThoiHan, da.MoTa);
            dbConn.ThucThi(sqlStr1);
        }
        public void Xoa(ClassDuAn da)
        {
            string sqlStr1 = string.Format("", da.MaDA);
            dbConn.ThucThi(sqlStr1);
        }

        public void Sua(ClassDuAn da)
        {
            string sqlStr = string.Format("", da.MaDA, da.TenDA,da.MaPhongBan, da.DiaDiem,da.ThoiHan, da.MoTa);
            dbConn.ThucThi(sqlStr);
        }
    }
}
