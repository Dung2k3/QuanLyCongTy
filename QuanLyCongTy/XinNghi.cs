using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class XinNghi
    {
        string msnv;
        string hoVaTen;
        DateTime ngayBD;
        int soNgayNghi;
        string lyDo;
        int heSoDuyet;
        //Image minhChung;

        public string MSNV { get => msnv; set => msnv = value; }
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public DateTime NgayBD { get => ngayBD; set => ngayBD = value; }
        public int SoNgayNghi { get => soNgayNghi; set => soNgayNghi = value; }
        public string LyDo { get => lyDo; set => lyDo = value; }
        public int HeSoDuyet { get => heSoDuyet; set => heSoDuyet = value; }
        //public Image MinhChung { get => minhChung; set => minhChung = value; }


        public XinNghi(string msnv, string hoVaTen, DateTime ngayBD, int soNgayNghi, string lyDo, int heSoDuyet)
        {
            this.msnv = msnv;
            this.hoVaTen = hoVaTen;
            this.ngayBD = ngayBD;
            this.soNgayNghi = soNgayNghi;
            this.lyDo = lyDo;
            this.heSoDuyet = heSoDuyet;
            //this.minhChung = minhChung;
        }
    }
}
