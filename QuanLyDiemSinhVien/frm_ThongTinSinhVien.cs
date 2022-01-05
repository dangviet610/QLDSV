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
    public partial class frm_ThongTinSinhVien : Form
    {
        private SinhVien current = new SinhVien();
        private f_sinhvien function = new f_sinhvien();
        public frm_ThongTinSinhVien()
        {
            InitializeComponent();
        }
        public frm_ThongTinSinhVien(string Email)
        {
            InitializeComponent();
            current = function.GetSinhVien(Email);
            lbten.Text = current.Hoten;
            lbEmail.Text = current.Email;
            var a = DateTime.Parse(current.Ngaysinh.ToString());
            lbNgaysinh.Text = a.ToShortDateString();
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

        private void btnBangdiem_Click(object sender, EventArgs e)
        {
            frm_BangDiem frm = new frm_BangDiem(current.Masv);
            frm.ShowDialog();
        }

        private void btnLopdanghoc_Click(object sender, EventArgs e)
        {
            frm_LopDangHoc frm = new frm_LopDangHoc(current.Masv);
            frm.ShowDialog();
        }
    }
}
