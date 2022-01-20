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
using QuanLyDiemSinhVien.Function;

namespace QuanLyDiemSinhVien
{
    public partial class frm_GiaoVien : Form
    {
        private int id;
        private f_giaovien f = new f_giaovien();
        private GiaoVien current;
        public frm_GiaoVien()
        {
            InitializeComponent();
        }
        public frm_GiaoVien(string Email)
        {
            InitializeComponent();
            id = f.GetGiaoVien(Email).Magiaovien;
            LoadThongTin();
        }
        public void LoadThongTin()
        {
            current = new Context().GiaoViens.FirstOrDefault(x => x.Magiaovien == id);
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

        private void btnThaydoithongtin_Click(object sender, EventArgs e)
        {
            using (frm_ThongTinGiaoVien frm = new frm_ThongTinGiaoVien(current.Magiaovien))
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    LoadThongTin();
                    this.Refresh();
                }
            }
        }

        private void btnQuanLyLop_Click(object sender, EventArgs e)
        {
            frm_QuanLyLopHoc frm = new frm_QuanLyLopHoc(current.Magiaovien);
            frm.ShowDialog();
        }

        private void btnQuanLyDiem_Click(object sender, EventArgs e)
        {
            /*frm_QuanLyDiem frm = new frm_QuanLyDiem(current.Magiaovien);
            frm.ShowDialog();*/
        }
    }
}
