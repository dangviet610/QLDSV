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
    public partial class frm_LopDangHoc : Form
    {
        private int masv=-1, count=0, id_lop=-1,id_mon=-1;
        private f_sinhvien f = new f_sinhvien();
        public frm_LopDangHoc()
        {
            InitializeComponent();
        }
        public frm_LopDangHoc(int masv)
        {
            InitializeComponent();
            cbLoai.SelectedIndex = 0;
            this.masv = masv;
            LoadDS();
            count++;
        }
        public void LoadDS(bool stt=true)
        {
            var list = f.DSLop(masv,stt);
            if (list != null && list.Count > 0)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = list.Select(x => new { tenlop = x.tenlop, tenmon = x.tenmon, gv = x.gv, malop=x.malop}).ToList();
                dgDS.DataSource = bs;
            }
        }
        private void btnTrove_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void btnDangky_Click(object sender, EventArgs e)
        {
            if (id_lop != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn xác nhận tham gia lớp học này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var stt = f.DangKyLopHoc(masv, id_lop);
                    if (stt)
                    {
                        MessageBox.Show("Đăng ký thành công");
                        LoadDS();
                    }
                    else
                        MessageBox.Show("Lỗi");
                }
            }
            else
                MessageBox.Show("Vui lòng chọn một lớp");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id_lop != -1)
            {
                frm_Lop frm = new frm_Lop(id_lop,id_mon,false);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Vui lòng chọn một lớp");
        }

        private void GetIdLop(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id_lop = (int)dgDS.Rows[e.RowIndex].Cells["malop"].Value;
                id_mon = (int)dgDS.Rows[e.RowIndex].Cells["mamon"].Value;
                btnPick.Enabled = true;
            }
            else
            {
                btnPick.Enabled = false;
                id_lop = -1;
            }    
        }

        private void ChonLoai(object sender, EventArgs e)
        {
            if(count>0)
            if (cbLoai.SelectedIndex == 0)
            {
                LoadDS();
                    btnPick.Visible = false;
                    btnPick.Enabled = false;
                }
            else
            {
                LoadDS(false);
                    btnPick.Visible = true;
            }    
        }
    }
}
