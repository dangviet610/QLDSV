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
    public partial class frm_BangDiem : Form
    {
        private f_sinhvien f = new f_sinhvien();
        private f_monhoc fmon = new f_monhoc();
        private QuanLyDiemSinhVien.Model.SinhVien current;
        public frm_BangDiem()
        {
            InitializeComponent();
        }
        public frm_BangDiem(int masv)
        {
            InitializeComponent();
            current = f.GetSinhVien(masv);
            LoadDanhSach();
            cbSx.SelectedIndex = 0;
        }
        public void LoadDanhSach()
        {
            var list = f.DSDiem(current.Masv);
            var list2 = list.Select(x => new { mon = fmon.GetMonHoc(x.Mamon).Tenmon, d = x.Diem1 }).ToList();
            dgDanhSach.DataSource = list2;
        }
        private void btnBangdiem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SapXep(object sender, EventArgs e)
        {
            if (cbSx.SelectedIndex == 0)
            {
                //cao đến thấp
                var list = f.DSDiem(current.Masv);
                var list2 = list.Select(x => new { mon = fmon.GetMonHoc(x.Mamon).Tenmon, d = x.Diem1 }).OrderByDescending(x=>x.d).ToList();
                dgDanhSach.DataSource = list2;
            }
            else
            {
                var list = f.DSDiem(current.Masv);
                var list2 = list.Select(x => new { mon = fmon.GetMonHoc(x.Mamon).Tenmon, d = x.Diem1 }).OrderBy(x => x.d).ToList();
                dgDanhSach.DataSource = list2;
            }    
        }
    }
}
