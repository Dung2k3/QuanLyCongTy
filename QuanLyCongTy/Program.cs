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

            //Application.Run(new FDangNhap());

            Application.Run(new FQuanLy2("NV003"));

            //Application.Run(new FDangNhap());
            //Application.Run(new Form1("NV017"));


            //Application.Run(new FDangNhap());
            //Application.Run(new FQuanLy("NV001"));
        }
    }
}
