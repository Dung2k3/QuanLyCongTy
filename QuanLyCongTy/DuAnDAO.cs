using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public class DuAnDAO
    {
        DBConnection dbConn = new DBConnection();

        public DataTable LayDanhSachDuAn()
        {
            string sqlStr = string.Format("SELECT MaDA, TenDuAn, MoTa, MaPB, DiaDiem, DeadLine FROM DuAn");
            return dbConn.LayDanhSach(sqlStr);
        }
        public void Them(ClassDuAn da)
        {
            MessageBox.Show(string.Format("{0}", da.ThoiHan.ToShortDateString()));
            string sqlStr1 = string.Format("INSERT INTO DuAn (MaDA, TenDuAn, MaPB, DiaDiem, DeadLine, MoTa) VALUES ('{0}',N'{1}','{2}',N'{3}','{4}',N'{5}')", 
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
