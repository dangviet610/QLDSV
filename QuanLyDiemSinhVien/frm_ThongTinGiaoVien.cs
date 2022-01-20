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
using QuanLyDiemSinhVien.Model;

namespace QuanLyDiemSinhVien
{
    public partial class frm_ThongTinGiaoVien : Form
    {
        private int id;
        private GiaoVien sv;
        public frm_ThongTinGiaoVien()
        {
            InitializeComponent();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public frm_ThongTinGiaoVien(int ma)
        {
            InitializeComponent();
            this.id = ma;
            this.sv = new f_giaovien().GetGiaoVien(ma);
            txtHoten.Text = sv.Hoten;
            txtEmail.Text = sv.Email;
            if (sv.Gioitinh == 0)
                rbNu.Checked = true;
            else
                rbNam.Checked = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtHoten.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                GiaoVien sv = new GiaoVien();
                sv.Magiaovien = id;
                sv.Email = txtEmail.Text;
                sv.Hoten = txtHoten.Text;
                if (rbNam.Checked)
                    sv.Gioitinh = 1;
                else
                    sv.Gioitinh = 0;
                if (cbDoimk.Checked)
                {
                    if (txtPass.Text != txtRepass.Text)
                    {
                        MessageBox.Show("Mật khẩu không khớp");
                    }
                    else
                    if (string.IsNullOrEmpty(txtRepass.Text) || string.IsNullOrEmpty(txtPass.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin");
                    }
                    else
                    {
                        sv.Password = txtPass.Text;
                        var up = new f_giaovien().Sua(sv);
                        if (up)
                        {
                            MessageBox.Show("Thành công!");
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Lỗi!");
                        }
                    }
                }
                else
                {
                    var up = new f_giaovien().Sua(sv);
                    if(up)
                    {
                        MessageBox.Show("Thành công!");
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi!");
                    }    
                }
            }    
        }

    }
}
