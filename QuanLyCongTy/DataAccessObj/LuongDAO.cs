using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class LuongDAO
    {
        DataProvider dataProvider = new DataProvider();
        public bool Them(LuongModel luong)
        {
            string query = "INSERT INTO Luong VALUES ( @MaNV , @ThangNam , @Luong )";
            object[] para = new object[] { luong.MaNV, luong.ThangNam, luong.Luong};
            return dataProvider.ExecuteNonQuery(query, para) > 0;
        }

        public LuongModel GetLuongTheoNhanVien(NhanVienModel nv, DateTime date)
        {
            string query = "SELECT * FROM Luong WHERE MaNV = @MaNV AND Month(ThangNam) = @Thang AND Year(ThangNam) = @Nam ";
            object[] para = new object[] { nv.MaNV, date.Month, date.Year };
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return new LuongModel(dr[0].ToString(), DateTime.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()));
            }
            else return null;
        }
    }
}
