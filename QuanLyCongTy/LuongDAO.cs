using System;
using System.Collections.Generic;
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
    }
}
