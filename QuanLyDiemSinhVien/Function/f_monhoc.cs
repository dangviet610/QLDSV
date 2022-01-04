using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSinhVien.Model;

namespace QuanLyDiemSinhVien.Function
{
    public class f_monhoc
    {
        private Context db;
        public f_monhoc()
        {
            db = new Context();
        }
        public MonHoc GetMonHoc(int id)
        {
            return db.MonHocs.FirstOrDefault(x=>x.Mamon==id);
        }
        public MonHoc GetMonHoc(string name)
        {
            return db.MonHocs.FirstOrDefault(x => x.Tenmon==name);
        }
        public List<MonHoc> DSMonHoc()
        {
            return db.MonHocs.ToList();
        }
        public bool Them(MonHoc e)
        {
            var o = GetMonHoc(e.Tenmon);
            if (o == null)
            {
                db.MonHocs.Add(e);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public bool Sua(MonHoc e)
        {
            var o = GetMonHoc(e.Mamon);
            if (o == null)
            {
                o.Tenmon = e.Tenmon;
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public bool Xoa(int id)
        {
            var o = GetMonHoc(id);
            if (o != null)
            {
                db.MonHocs.Remove(o);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Danh sách các giáo viên đang dạy môn này
        /// </summary>
        /// <param name="mamon"></param>
        /// <returns></returns>
        public List<GiaoVien> DSGiaoVien(int mamon)
        {
            var a = db.PhanLopGiaoViens.Where(x => x.Mamon == mamon);
            List<GiaoVien> list = new List<GiaoVien>();
            foreach (var item in a)
            {
                list.Add(new f_giaovien().GetGiaoVien(item.Magiaovien));
            }
            return list;
        }
        /// <summary>
        /// Danh sách học sinh đang học môn này
        /// </summary>
        /// <param name="mamon"></param>
        /// <returns></returns>
        public List<SinhVien> DSSinhVien(int mamon)
        {
            var a = db.PhanLopSinhViens.Where(x => x.Mamon == mamon);
            List<SinhVien> list = new List<SinhVien>();
            foreach (var item in a)
            {
                list.Add(new f_sinhvien().GetSinhVien(item.Masv));
            }
            return list;
        }
    }
}
