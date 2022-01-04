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
        private SinhVien current;
        public frm_ThongTinSinhVien()
        {
            InitializeComponent();
        }
        public frm_ThongTinSinhVien(string Email)
        {
            InitializeComponent();
            current = new f_sinhvien().GetSinhVien(Email);
            lbten.Text = current.Hoten;
        }
    }
}
