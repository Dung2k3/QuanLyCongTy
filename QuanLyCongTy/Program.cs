﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new FThongTinDA("DA006"));
            //Application.Run(new Form1());
            Application.Run(new FDangNhap());
            //Application.Run(new FQuanLy("NV001"));
            //Application.Run(new FTruongPhong("NV004"));
        } 
    }
}
