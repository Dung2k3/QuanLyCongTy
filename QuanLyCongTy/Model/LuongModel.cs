using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class LuongModel
    {
        string maNV;
        DateTime thangNam;
        int luong;

        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime ThangNam { get => thangNam; set => thangNam = value; }
        public int Luong { get => luong; set => luong = value; }

        public LuongModel(string maNV, DateTime thangNam, int luong)
        {
            this.maNV = maNV;
            this.thangNam = thangNam;
            this.luong = luong;
        }
    }
}
