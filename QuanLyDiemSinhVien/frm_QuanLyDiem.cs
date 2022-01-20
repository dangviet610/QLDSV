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
    public partial class frm_QuanLyDiem : Form
    {
        private int malop, mamon,masv;
        private double diem;
        private f_giaovien fgv = new f_giaovien();
        private f_lop flop = new f_lop();
        private f_monhoc fmon = new f_monhoc();
        private f_diem fdiem = new f_diem();
        private GiaoVien gv;
        public frm_QuanLyDiem()
        {
            InitializeComponent();
        }
        public frm_QuanLyDiem(int malop,int mamon)
        {
            InitializeComponent();
            this.malop = malop;
            this.mamon = mamon;
            lb_lop.Text = flop.GetLop(malop).Tenlop;
            lb_mon.Text = fmon.GetMonHoc(mamon).Tenmon;
            LoadDS();
        }
        public void LoadDS()
        {
            var list = fdiem.BangDiem(malop,mamon);
            if(list!=null && list.Count > 0)
            {
                dgDS.Refresh();
                int stt = 0;
                BindingSource bs = new BindingSource();
                bs.DataSource = list.Select(x => new {Stt=stt++,Hoten=x.tensv,Diem=x.diem,Masv=x.masv,Mamon=x.mamon });
                dgDS.DataSource = bs;
                
            }
        }
        private void btnTrove_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (masv > 0)
            {
                var stt = fdiem.Xoa(masv, mamon, malop);
                if (stt)
                {
                    MessageBox.Show("Thành công");
                    btnXoa.Enabled = false;
                    button1.Enabled = false;
                    masv = 0;
                    LoadDS();
                }
                else
                    MessageBox.Show("Lỗi");
            }
            else
                MessageBox.Show("Vui lòng chọn 1 dòng");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_ThemDiem frm = new frm_ThemDiem(malop,mamon);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (frm_Diem frm = new frm_Diem(masv,mamon,malop,diem))
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    LoadDS();
                }
            }
            
        }

        private void GetID(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                masv = (int)dgDS.Rows[e.RowIndex].Cells["Masv"].Value;
                diem = (double)dgDS.Rows[e.RowIndex].Cells["Diem"].Value;
                button1.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
    }
}
