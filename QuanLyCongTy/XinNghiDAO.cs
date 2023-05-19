using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class XinNghiDAO
    {
        DBConnection dbConn = new DBConnection();
        DataProvider dataProvider = new DataProvider();

        public string LayHeSo(string MaNV)
        {
            string sqlStr = string.Format("SELECT HeSoDuyet FROM XinNghi WHERE MaNV = '{0}'", MaNV);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            return dt.Rows[0][0].ToString();
        }


        public DataTable LayDanhSachChuaDuyetXinNghi()
        {
            string sqlStr = string.Format("SELECT MaNV " +
                                           "FROM XinNghi " +
                                            "WHERE HeSoDuyet = -1");
            return dbConn.LayDanhSach(sqlStr);
        }

        public List<XinNghiModel> ListXinNghiChuaDuyet(XinNghiModel xn)
        {
            List<XinNghiModel> list = new List<XinNghiModel>();
            string query = "SELECT * FROM XinNghi WHERE HeSoDuyet = -1";
            DataTable dt = dataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
                list.Add(new XinNghiModel(dr[0].ToString(), DateTime.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), dr[3].ToString(), int.Parse(dr[4].ToString())));
            return list;
        }

        public List<XinNghiModel> ListXinNghiDaDuyet(XinNghiModel xn)
        {
            List<XinNghiModel> list = new List<XinNghiModel>();
            string query = "SELECT * FROM XinNghi WHERE HeSoDuyet = 1";
            DataTable dt = dataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new XinNghiModel(dr[0].ToString(), DateTime.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), dr[3].ToString(), int.Parse(dr[4].ToString())));
            }
            return list;
        }

        public DataTable LayDanhSachXinNghiDaDuyet()
        {
            string sqlStr = string.Format("SELECT MaNV " +
                                           "FROM XinNghi " +
                                           "WHERE HeSoDuyet = 1");
            return dbConn.LayDanhSach(sqlStr);
        }

        public XinNghiModel getXinNghiTheoMa(string MaNV)
        {
            string query = "SELECT * FROM XinNghi WHERE MaNV = @MaNV ";
            object[] para = new object[] { MaNV };
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            DataRow dr = dt.Rows[0];
            return new XinNghiModel(dr[0].ToString(), DateTime.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), dr[3].ToString(), int.Parse(dr[4].ToString()));
        }
        public bool Them(XinNghiModel xn)
        {
            string query = "INSERT INTO XinNghi " +
                "VALUES ( @MaNV , @HoVaTen , @NgayNghi , @SoNgayNghi, @LyDo, @HeSoDuyet  )";
            object[] para = new object[] { xn.MaNV, xn.NgayBD, xn.SoNgayNghi, xn.LyDo, xn.HeSoDuyet };
            return dataProvider.ExecuteNonQuery(query, para) > 0;
        }

        public bool Xoa(XinNghiModel xn)
        {
            string query = "DELETE FROM XinNghi WHERE MaNV = @MaNV ";
            object[] para = new object[] { xn.MaNV };
            return dataProvider.ExecuteNonQuery(query, para) > 0;
        }

    }
}
