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
        private int masv;
        private f_sinhvien f = new f_sinhvien();
        public frm_LopDangHoc()
        {
            InitializeComponent();
        }
        public frm_LopDangHoc(int masv)
        {
            this.masv = masv;
            var list = f.DSLop(masv);
            dgDS.DataSource = list;
        }
        public void LoadDS()
        {

        }
        private void btnTrove_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
