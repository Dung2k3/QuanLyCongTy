using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class XinNghiDAO
    {
        public class DuAnDAO
        {
            DBConnection dbConn = new DBConnection();
            DataSource dataSource = new DataSource();

            public string LayHeSo(string MSNV)
            {
                string sqlStr = string.Format("SELECT HeSoDuyet FROM XinNghi WHERE MSNV = '{0}'", MSNV);
                DataTable dt = dbConn.LayDanhSach(sqlStr);
                return dt.Rows[0][0].ToString();
            }

            public DataTable LayDanhSachChuaDuyetXinNghi()
            {
                string sqlStr = string.Format("SELECT MSNV " +
                                               "FROM XinNghi ");
                return dbConn.LayDanhSach(sqlStr);
            }
            public List<XinNghi> ListXinNghi()
            {
                List<XinNghi> list = new List<XinNghi>();
                string query = "SELECT * FROM XinNghi ";
                DataTable dt = dataSource.ExecuteQuery(query);
                foreach (DataRow dr in dt.Rows)
                list.Add(new XinNghi(dr[0].ToString(), dr[1].ToString(), DateTime.Parse(dr[2].ToString()), int.Parse(dr[3].ToString()), dr[4].ToString(), int.Parse(dr[5].ToString())));
                return list;
            }

            public XinNghi getDuAnTheoMa(string MaDA)
            {
                string query = "SELECT * FROM XinNghi WHERE MSNV = @MSNV ";
                object[] para = new object[] { MaDA };
                DataTable dt = dataSource.ExecuteQuery(query, para);
                DataRow dr = dt.Rows[0];
                return new XinNghi(dr[0].ToString(), dr[1].ToString(), DateTime.Parse(dr[2].ToString()), int.Parse(dr[3].ToString()), dr[4].ToString(), int.Parse(dr[5].ToString()));
            }
        }
    }
}
