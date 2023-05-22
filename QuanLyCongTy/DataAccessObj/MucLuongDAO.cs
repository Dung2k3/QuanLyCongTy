using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class MucLuongDAO
    {
        DataProvider dataProvider = new DataProvider();
        public MucLuongModel GetMucLuongTheoMaLuong(string MaLuong)
        {
            string query = "SELECT * FROM MucLuong WHERE MaLuong = @MaLuong ";
            object[] para = new object[] { MaLuong };
            DataRow dr = dataProvider.ExecuteQuery(query, para).Rows[0];
            return new MucLuongModel(dr[0].ToString(), dr[1].ToString(), int.Parse(dr[2].ToString()));
        }
    }
}
