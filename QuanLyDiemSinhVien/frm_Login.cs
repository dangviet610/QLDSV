﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            cbLoaiTK.SelectedIndex = 0;
            cbLoaiTKDK.SelectedIndex = 0;
            cbGTDK.SelectedIndex = 0;
        }

        private void lb_resetPasss_Click(object sender, EventArgs e)
        {

        }
    }
}
