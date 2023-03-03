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
            string sqlStr = string.Format("SELECT * FROM DuAn");
            return dbConn.LayDanhSach(sqlStr);
        }
        public void Them(ClassDuAn da)
        { 
            string sqlStr1 = string.Format("INSERT INTO DuAn (MaDA, TenDuAn, MaPB, DiaDiem, DeadLine, MoTa) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", 
                                            da.MaDA, da.TenDA, da.MaPhongBan, da.DiaDiem,da.ThoiHan, da.MoTa);
            dbConn.ThucThi(sqlStr1);
        }
        public void Xoa(ClassDuAn da)
        {
            string sqlStr1 = string.Format("DELETE FROM DuAn WHERE MaDA = '{0}'", da.MaDA);
            dbConn.ThucThi(sqlStr1);
        }

        public void Sua(ClassDuAn da)
        {
            string sqlStr = string.Format("UPDATE DuAn SET MaDA = '{0}', TenDuAn = '{1}', MaPB = '{2}', DiaDiem = '{3}', DeadLine = '{4}', MoTa = '{5}' WHERE MaDA = '{6}'",
                                            da.MaDA, da.TenDA,da.MaPhongBan, da.DiaDiem,da.ThoiHan, da.MoTa, da.MaDA);
            dbConn.ThucThi(sqlStr);
        }
    }
}
