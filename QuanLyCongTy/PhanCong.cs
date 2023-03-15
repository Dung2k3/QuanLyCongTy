using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class ClassPhanCong
    {
        string maNV;
        string hoTenNV;
        string maPB;
        string maDA;
        string congViec;
        DateTime ngayBD;
        DateTime deadline;

        public string MaNV { get { return maNV; } }
        //public string HoTenNV { get { return hoTenNV; } }
        //public string MaPB { get { return maPB; } }
        public string MaDA { get { return maDA; } }
        public string CongViec { get { return congViec; } }
        public DateTime NgayBD { get { return ngayBD; } }
        public DateTime Deadline { get { return deadline; } }

        public ClassPhanCong(string maNV, string maDA, string congViec, DateTime ngayBD, DateTime deadline)
        {
            this.maNV = maNV;
            this.maDA = maDA;
            this.congViec = congViec;
            this.ngayBD = ngayBD;
            this.deadline = deadline;
        }
    }
}
