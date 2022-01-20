﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiemSinhVien.Model;
using QuanLyDiemSinhVien.Function;

namespace QuanLyDiemSinhVien
{
    public partial class frm_Diem : Form
    {
        int masv, mamon, malop;
        double diem;
        public frm_Diem(int masv,int mamon,int malop, double diem)
        {
            InitializeComponent();
            txtHoten.Text = new f_sinhvien().GetSinhVien(masv).Hoten;
            txtDiem.Text = diem.ToString();
            this.masv = masv;
            this.mamon = mamon;
            this.malop = malop;
            this.diem = diem;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(txtDiem.Text) > 10 || double.Parse(txtDiem.Text) < 0)
                {
                    MessageBox.Show("Điểm không hợp lệ");
                }
                else
                {
                    var stt = new f_diem().Sua(masv, mamon, malop, double.Parse(txtDiem.Text));
                    if (stt)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Lỗi");
                }
                    
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập lại");
            }
            
        }
    }
}
