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
    public partial class frm_ThemDiem : Form
    {
        int malop, mamon;
        public frm_ThemDiem(int malop,int mamon)
        {
            InitializeComponent();
            this.malop = malop;
            this.mamon = mamon;
            var list = new Context().Diems.Where(x=>x.Mamon==mamon && x.Malop==malop).Select(x=>x.Masv).ToList();
            var list_sv = new Context().SinhViens.Select(x => new KeyValuePair<int, string> (x.Masv,x.Hoten));
            //var list3 = list_sv.Where(x=>!list.Any(x2=>x2.Masv!=x.Key));
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
                    var stt = new f_diem().Sua(int.Parse(cbSinhvien.SelectedItem.ToString()), mamon, malop, double.Parse(txtDiem.Text));
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
