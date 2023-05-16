using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class PhanCongModel
    {
        string maDA;
        string maCV;
        string maNV;
        DateTime ngayBD;
        DateTime deadLine;
        int tienDo;
        string danhgia;
        int chamDiem;
        public string MaDA { get => maDA; set => maDA = value; }
        public string MaCV { get => maCV; set => maCV = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayBD { get => ngayBD; set => ngayBD = value; }
        public DateTime DeadLine { get => deadLine; set => deadLine = value; }
        public int TienDo { get => tienDo; set => tienDo = value; }
        public string Danhgia { get => danhgia; set => danhgia = value; }
        public int ChamDiem { get => chamDiem; set => chamDiem = value; }

        public PhanCongModel(string maDA, string maCV, string maNV, DateTime ngayBD, DateTime deadLine, int tienDo, string danhgia, int chamDiem)
        {
            this.maDA = maDA;
            this.maCV = maCV;
            this.maNV = maNV;
            this.ngayBD = ngayBD;
            this.deadLine = deadLine;
            this.tienDo = tienDo;
            this.danhgia = danhgia;
            this.chamDiem = chamDiem;
        }
    }
}
