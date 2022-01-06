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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            cbLoaiTKDK.SelectedIndex = 0;
            cbGTDK.SelectedIndex = 0;
            cbLoaiTK.SelectedIndex = 0;
        }

        private void lb_resetPasss_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                if (!string.IsNullOrEmpty(txtPass.Text))
                {
                    string type = "sv";
                    if (cbLoaiTK.SelectedIndex == 0)
                    {
                        type = "gv";
                    }
                    else
                        if (cbLoaiTK.SelectedIndex == 2)
                    {
                        type = "admin";
                    }
                    var up = new f_taikhoan().Login(txtEmail.Text, txtPass.Text,type);
                    if (!up)
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                    }else
                     if(type == "admin"){
                        frm_Admin frm = new frm_Admin();
                        Hide();
                        frm.ShowDialog();
                        Show();
                    }
                    else
                    if (type=="gv"){
                        frm_GiaoVien frm = new frm_GiaoVien(txtEmail.Text);
                        Hide();
                        frm.ShowDialog();
                        Show();
                    }
                    else
                    if (type=="sv"){
                        frm_SinhVien frm = new frm_SinhVien(txtEmail.Text);
                        Hide();
                        frm.ShowDialog();
                        Show();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập email");
            }
        }
    }
}
