using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class ClassDangNhap
    {
        string taikhoan;
        string matkhau;
        public string Taikhoan { get { return taikhoan; } }
        public string Matkhau { get { return matkhau; } }
        public ClassDangNhap(string taikhoan, string matkhau)
        {

            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
        }
    }
}