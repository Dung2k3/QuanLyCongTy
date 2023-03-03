using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class ClassDanhGiaDA
    {
        string maDA;
        string tenDA;
        string nhanXet;
        long thuong;

        public string MaDA { get { return maDA; } }
        public string TenDA { get { return tenDA; } }
        public string NhanXet { get { return nhanXet; } }
        public long Thuong { get { return thuong; } }

        public ClassDanhGiaDA(string maDA, string tenDA, string nhanXet, long thuong)
        {
            this.maDA = maDA;
            this.tenDA = tenDA;
            this.nhanXet = nhanXet;
            this.thuong = thuong;
        }
    }
}
