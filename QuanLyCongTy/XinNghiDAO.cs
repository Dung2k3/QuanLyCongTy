using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class XinNghiDAO
    {
        DBConnection dbConn = new DBConnection();
        DataProvider dataProvider = new DataProvider();

        public string LayHeSo(string MaNV)
        {
            string sqlStr = string.Format("SELECT HeSoDuyet FROM XinNghi WHERE MaNV = '{0}'", MaNV);
            DataTable dt = dbConn.LayDanhSach(sqlStr);
            return dt.Rows[0][0].ToString();
        }

        public XinNghi LayDanhSachXinNghi(string MaNV)
        {
            string sqlStr = string.Format("SELECT XinNghi.MaNV, NhanVien.HoTenNV, XinNghi.NgayNghi, XinNghi.SoNgayNghi, XinNghi.LyDo, XinNghi.HeSoDuyet " +
                                            "FROM XinNghi, NhanVien WHERE XinNghi.MaNV = NhanVien.MaNV " +
                                            "AND XinNghi.MaNV = '{0}'", MaNV);
            DataRow dr = dbConn.LayDanhSach(sqlStr).Rows[0];
            return new XinNghi(dr[0].ToString(), dr[1].ToString(), DateTime.Parse(dr[2].ToString()), int.Parse(dr[3].ToString()), dr[4].ToString(), int.Parse(dr[5].ToString()));
        }

        public DataTable LayDanhSachChuaDuyetXinNghi()
        {
            string sqlStr = string.Format("SELECT MaNV " +
                                           "FROM XinNghi " +
                                            "WHERE HeSoDuyet = -1");
            return dbConn.LayDanhSach(sqlStr);
        }

        public List<XinNghiModel> ListXinNghiChuaDuyet()
        {
            List<XinNghiModel> list = new List<XinNghiModel>();
            string query = "SELECT * FROM XinNghi WHERE HeSoDuyet = -1 ";
            DataTable dt = dataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
                list.Add(new XinNghiModel(dr[0].ToString(), DateTime.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), dr[4].ToString(), int.Parse(dr[5].ToString())));
            return list;
        }

        public List<XinNghiModel> ListXinNghiDaDuyet()
        {
            List<XinNghiModel> list = new List<XinNghiModel>();
            string query = "SELECT * FROM XinNghi WHERE HeSoDuyet > -1 ";
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
                                           "WHERE HeSoDuyet > -1");
            return dbConn.LayDanhSach(sqlStr);
        }
        public bool Them(XinNghiModel xn)
        {
            string query = "INSERT INTO XinNghi " +
                "VALUES ( @MaNV , @NgayNghi , @SoNgayNghi , @LyDo , @HeSoDuyet  )";
            object[] para = new object[] { xn.MaNV, xn.NgayBD, xn.SoNgayNghi, xn.LyDo, xn.HeSoDuyet };
            return dataProvider.ExecuteNonQuery(query, para) > 0;
        }

        public XinNghiModel getXinNghiTheoMA(NhanVienModel nv)
        {
            string query = "SELECT * FROM XinNghi WHERE MaNV = @MaNV ";
            object[] para = new object[] { nv.MaNV };
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            DataRow dr = dt.Rows[0];
            return new XinNghiModel(dr[0].ToString(), DateTime.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), dr[3].ToString(), int.Parse(dr[4].ToString())); 
        }

        public List<XinNghiModel> ListTrangThaiXN(NhanVienModel nv)
        {
            List<XinNghiModel> list = new List<XinNghiModel>(); 
            string query = "SELECT * FROM XinNghi WHERE HeSoDuyet >= 0 AND MaNV = @MaNV ";
            object[] para = new object[] { nv.MaNV };
            DataTable dt = dataProvider.ExecuteQuery(query, para);
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(new XinNghiModel(dr[0].ToString(), DateTime.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), dr[3].ToString(), int.Parse(dr[4].ToString())));
            }
            return list;
        }

        public List<XinNghiModel> LayListXinNghiDaDuyet()
        {
            List<XinNghiModel> list = new List<XinNghiModel>();
            string query = "SELECT * FROM XinNghi WHERE HeSoDuyet >= 0 ";
            DataTable dt = dataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new XinNghiModel(dr[0].ToString(), DateTime.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), dr[3].ToString(), int.Parse(dr[4].ToString())));
            }
            return list;
        }

        public List<XinNghiModel> LayListXinNghiChuaDuyet()
        {
            List<XinNghiModel> list = new List<XinNghiModel>();
            string query = "SELECT * FROM XinNghi WHERE HeSoDuyet = -1 ";
            DataTable dt = dataProvider.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new XinNghiModel(dr[0].ToString(), DateTime.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), dr[3].ToString(), int.Parse(dr[4].ToString())));
            }
            return list;
        }

        public bool Duyet(string MaNV)
        {
            string query = "UPDATE XinNghi SET HeSoDuyet = 1 WHERE MaNV = @MaNV ";
            object[] para = new object[] { MaNV };
            return dataProvider.ExecuteNonQuery(query, para) > 0;
        }
        public bool KhongDuyet(string MaNV)
        {
            string query = "UPDATE XinNghi SET HeSoDuyet = 0 WHERE MaNV = @MaNV ";
            object[] para = new object[] { MaNV };
            return dataProvider.ExecuteNonQuery(query, para) > 0;
        }

    }
}
