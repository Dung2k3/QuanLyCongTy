﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class FQuanLy2 : Form
    {
        public FQuanLy2(string ma)
        {
            InitializeComponent();
            ucTheme.Ma = ma;
            ucbtnCheckinout.SetupButon(ColorTranslator.FromHtml("#8BC240"), ucTheme, new FCheckinout(ma));
            ucbtnTaoDA.SetupButon(ColorTranslator.FromHtml("#126881"), ucTheme, new FDuAn());
            ucbtnDanhGiaDA.SetupButon(ColorTranslator.FromHtml("#A12059"), ucTheme, new FDanhGiaDA());
        }
    }
}
