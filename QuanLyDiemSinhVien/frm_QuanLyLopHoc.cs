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
    public partial class frm_QuanLyLopHoc : Form
    {
        private int magv, id_lop = -1, id_mon = -1;
        private GiaoVien gv;
        private f_giaovien f = new f_giaovien();
        public frm_QuanLyLopHoc()
        {
            InitializeComponent();
        }
        public frm_QuanLyLopHoc(int magv)
        {
            InitializeComponent();
            this.magv = magv;
            this.gv = f.GetGiaoVien(magv);
            LoadDS();
        }
        public void LoadDS(bool stt=true)
        {
            var list = f.DSLop(magv, false);
            if (list != null && list.Count > 0)
            {
                BindingSource bs = new BindingSource();
                var l = list.Select(x => new { tenlop = x.tenlop, tenmon = x.tenmon, malop = x.malop,mamon=x.mamon }).ToList();
                bs.DataSource = l;
                dgDS.DataSource = bs;
                lb_tongso.Text = l.Count.ToString();
            }
            else
            {
                lb_tongso.Text = "0";
            }    
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (id_lop != -1)
            {
                frm_Lop frm = new frm_Lop(id_lop,id_mon);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp muốn xem");
            }    
        }

        private void ChonLop(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id_lop = (int)dgDS.Rows[e.RowIndex].Cells["malop"].Value;
                id_mon = (int)dgDS.Rows[e.RowIndex].Cells["mamon"].Value;
                btnXem.Enabled = true;
            }
            else
            {
                btnXem.Enabled = false;
                id_lop = -1;
            }    
                
        }
    }
}
