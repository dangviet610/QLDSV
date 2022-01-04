using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

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
