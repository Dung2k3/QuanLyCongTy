using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class MucLuongModel
    {
        string maLuong;
        string chucVu;
        int mucLuong;

        public string MaLuong { get => maLuong; set => maLuong = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public int MucLuong { get => mucLuong; set => mucLuong = value; }

        public MucLuongModel(string maLuong, string chucVu, int mucLuong)
        {
            this.maLuong = maLuong;
            this.chucVu = chucVu;
            this.mucLuong = mucLuong;
        }
    }
}
