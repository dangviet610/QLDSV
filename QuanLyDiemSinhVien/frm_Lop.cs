using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyDiemSinhVien.Function;
using QuanLyDiemSinhVien.Model;

namespace QuanLyDiemSinhVien
{
    public partial class frm_Lop : Form
    {
        private f_lop flop = new f_lop();
        private Lop l;
        private int id_mon;

        public frm_Lop()
        {
            InitializeComponent();
        }
        public frm_Lop(int malop,int mamon,bool edit=true)
        {
            InitializeComponent();
            if (!edit)
            {
                btnXoaSv.Visible = false;
                btnXem.Visible = false;
                btnThemSv.Visible = false;
                btnXemDiem.Visible = false;
            }
            l = flop.GetLop(malop);
            id_mon = mamon;
            lb_tenlop.Text = "Lớp: "+l.Tenlop;
            LoadDS();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public void LoadDS()
        {
            var list = flop.DSSinhVien(l.Malop);
            if (list != null && list.Count > 0)
            {
                int s = 0;
                BindingSource bs = new BindingSource();
                bs.DataSource = list.Select((x) => new { Stt = s++, Hoten = x.Hoten, Masv = "Sv" + x.Masv, Gioitinh = (x.Gioitinh == 0) ? "Nữ" : "Nam", ngaysinh = x.Ngaysinh, Email = x.Email }).ToList();
                dgDS.DataSource = bs;
            }
        }
        private void GetID(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnXoaSv.Enabled = true;
                btnXem.Enabled = true;
                btnXemDiem.Enabled = true;
            }
            else
            {
                btnXoaSv.Enabled = false;
                btnXem.Enabled = false;
                btnXemDiem.Enabled = false;
            }    
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            frm_QuanLyDiem frm = new frm_QuanLyDiem(l.Malop,id_mon);
            frm.ShowDialog();
        }
    }
}
