using QuanLyDiemSinhVien.Function;
using QuanLyDiemSinhVien.Model;
using System;
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
    public partial class frm_ThongTinGiaoVien : Form
    {
        private GiaoVien current;
        public frm_ThongTinGiaoVien()
        {
            InitializeComponent();
        }
        public frm_ThongTinGiaoVien(string Email)
        {
            InitializeComponent();
            current = new f_giaovien().GetGiaoVien(Email);
            lbten.Text = current.Hoten;
            lbEmail.Text = current.Email;
            if (current.Gioitinh == 0)
            {
                lbGt.Text = "Nữ";
            }
            else
                lbGt.Text = "Nam";
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
