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
        private int masv, count=0;
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
            var list = f.DSLop(masv);
            if(!stt)
                list = f.DSLop(masv,false);
            if (list != null && list.Count > 0)
            {
                dgDS.DataSource = list.Select(x => new { tenlop = x.tenlop, tenmon = x.tenmon, gv = x.gv }).ToList();
            }
        }
        private void btnTrove_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }

        private void ChonLoai(object sender, EventArgs e)
        {
            if(count>0)
            if (cbLoai.SelectedIndex == 0)
            {
                LoadDS();
                    btnPick.Visible = false;
                }
            else
            {
                LoadDS(false);
                    btnPick.Visible = true;
            }    
        }
    }
}
