﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class ClassKPI
    {
        
        string tenDA;
        string tienDo;


        public string TenDA { get { return tenDA; } }
        public string TienDo { get { return tienDo; } }


        public ClassKPI(string tenDA, string tienDo)
        {
            this.tenDA= tenDA;  
            this.tienDo= tienDo;
        }
    }
}
