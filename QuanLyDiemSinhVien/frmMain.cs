using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_ThemSV frm = new frm_ThemSV();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEdit frm = new frmEdit();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            frm_Lop frm = new frm_Lop();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
