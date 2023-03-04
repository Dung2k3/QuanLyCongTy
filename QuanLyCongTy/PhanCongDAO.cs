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

        public DataTable LayDanhSachDuAn()
        {
            string sqlStr = string.Format("SELECT * FROM DuAn ");
            return dbConn.LayDanhSach(sqlStr);
        }
        public DataTable LayDanhSachNhanVien()
        {
            string sqlStr = string.Format("SELECT * FROM NhanVien");
            return dbConn.LayDanhSach(sqlStr);
        }
        public DataTable LayDanhSachPhanCong()
        {
            string sqlStr = string.Format("SELECT * FROM PhanCong");
            return dbConn.LayDanhSach(sqlStr);
        }

        public void Them(ClassPhanCong pc)
        {
            string sqlStr1 = string.Format("INSERT INTO PhanCong (MaNV, MaDA, CongViec, DeadLine) VALUES ('{0}', '{1}', '{2}', '{3}'",
                                            pc.MaNV, pc.MaDA, pc.CongViec, pc.Deadline);
            dbConn.ThucThi(sqlStr1);
        }
        public void Xoa(ClassPhanCong pc)
        {
            string sqlStr1 = string.Format("DELETE FROM PhanCong WHERE MaNV = '{0}' AND MaDA = '{1}'", pc.MaNV, pc.MaDA);
            dbConn.ThucThi(sqlStr1);
        }

        public void Sua(ClassPhanCong pc)
        {
            string sqlStr = string.Format("UPDATE PhanCong SET MaNV = '{0}', MaDA = '{1}', CongViec = '{2}', DeadLine = '{3}'WHERE MaNV = '{4}' AND MaDA = '{5}'", 
                                            pc.MaNV, pc.MaDA, pc.CongViec,pc.Deadline, pc.MaNV, pc.MaDA);
            dbConn.ThucThi(sqlStr);
        }
    }
}
