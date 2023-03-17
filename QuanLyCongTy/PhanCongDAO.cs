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


        public string GetMaLPB(string MaPB)
        {
            string sqlStr = string.Format("SELECT MaLPB FROM PhongBan Where MaPB = '{0}'", MaPB);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            return dt.Rows[0][0].ToString();
        }

        public List<string> LayDanhSachTenDuAn(string MaPB)
        {
            string sqlStr = string.Format("SELECT TenDuAn FROM DuAn WHERE MaPB = '{0}'", MaPB);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            List<string> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr[0].ToString());
            }
            list.Sort();
            return list;
        }
        public List<string>  LayDanhSachTenNhanVien(string MaPB)
        {
            string sqlStr = string.Format("SELECT HoTenNV FROM NhanVien  WHERE MaPB = '{0}'", MaPB);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            List<string> list = new List<string>();
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(dr[0].ToString());
            }
            list.Sort();
            return list;
        }

        public List<string> LayDanhSachTenCongViec(string MaLPB)
        {
            string sqlStr = string.Format("SELECT TenCV FROM CongViec WHERE MaLPB = '{0}'", MaLPB);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            List<string> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr[0].ToString());
            }
            list.Sort();
            return list;
        }

        public DataTable LayDanhSachPhanCong(string MaPB)
        {
            string sqlStr = string.Format("SELECT NhanVien.MaNV,HoTenNV, PhanCong.MaDA, TenDuAn, CongViec.TenCV, NgayBD, PhanCong.DeadLine " +
                                          " FROM PhanCong, NhanVien, CongViec, DuAn  " +
                                          " WHERE PhanCong.MaNV = NhanVien.MaNV and CongViec.MaCV = PhanCong.CongViec and DuAn.MaDA = PhanCong.MaDA " +
                                          " AND NhanVien.MaPB = '{0}'", MaPB );
            return dbConn.LayDanhSach(sqlStr);
        }

        public void Them(PhanCong pc)
        {
            string sqlStr1 = string.Format("INSERT INTO PhanCong (MaNV, MaDA, CongViec,NgayBD, DeadLine) " +
                                            " VALUES ('{0}', '{1}', N'{2}', '{3}', '{4}')",
                                            pc.MaNV, pc.MaDA, pc.CongViec,pc.NgayBD, pc.Deadline);
            dbConn.ThucThi(sqlStr1);
        }
        public void Xoa(PhanCong pc)
        {
            string sqlStr1 = string.Format("DELETE FROM PhanCong WHERE MaNV = '{0}' AND MaDA = '{1}'", pc.MaNV, pc.MaDA);
            dbConn.ThucThi(sqlStr1);
        }

        public void Sua(PhanCong pc)
        {
            string sqlStr = string.Format("UPDATE PhanCong SET MaNV = '{0}', MaDA = '{1}', CongViec = '{2}', DeadLine = '{3}' " +
                                            "WHERE MaNV = '{4}' AND MaDA = '{5}'", 
                                            pc.MaNV, pc.MaDA, pc.CongViec,pc.NgayBD, pc.Deadline, pc.MaNV, pc.MaDA);
            dbConn.ThucThi(sqlStr);
        }
    }
}
