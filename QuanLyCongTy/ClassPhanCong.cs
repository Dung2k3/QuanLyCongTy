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
        string maDA;
        string congViec;
        DateTime deadline;

        public string MaNV { get { return maNV; } }
        public string MaDA { get { return maDA; } }
        public string CongViec { get { return congViec; } }
        public DateTime Deadline { get { return deadline; } }

        public ClassPhanCong(string maNV, string maDA, string congViec, DateTime deadline)
        {
            this.maNV = maNV;
            this.maDA = maDA;
            this.congViec = congViec;
            this.deadline = deadline;
        }
    }
}
