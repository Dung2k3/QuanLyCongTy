using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class ClassDuAn
    {
        string maDA;
        string tenDA;
        string maPhongBan;
        string diaDiem;
        string moTa;

        public string MaDA { get { return maDA; } }
        public string TenDA { get { return tenDA; } }
        public string MaPhongBan { get { return maPhongBan; } }
        public string DiaDiem { get { return diaDiem; } }
        public string MoTa { get { return moTa; } }

        public ClassDuAn(string maDA, string tenDA, string maPhongBan, string diaDiem, string moTa)
        {
            this.maDA = maDA;
            this.tenDA = tenDA;
            this.maPhongBan = maPhongBan;
            this.diaDiem = diaDiem;
            this.moTa = moTa;
        }
    }
}
