using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSinhVien.Model;

namespace QuanLyDiemSinhVien.Function
{
    public class f_lop
    {
        private Context db;
        public f_lop()
        {
            db = new Context();
        }
        public Lop GetLop(int id)
        {
            return db.Lops.FirstOrDefault(x=>x.Malop==id);
        }
        public Lop GetLop(string name)
        {
            return db.Lops.FirstOrDefault(x => x.Tenlop == name);
        }
        public List<Lop> DSLop()
        {
            return db.Lops.ToList();
        }
        public bool Them(Lop e)
        {
            if (GetLop(e.Tenlop) == null)
            {
                db.Lops.Add(e);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public bool Sua(Lop e)
        {
            var o = GetLop(e.Malop);
            if (o != null)
            {
                o.Tenlop = e.Tenlop;
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public bool Xoa(int id)
        {
            var o = GetLop(id);
            if (o != null)
            {
                db.Lops.Remove(o);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Get danh sách sinh viên cùng lớp
        /// </summary>
        /// <param name="malop"></param>
        /// <returns>List sinh viên</returns>
        public List<SinhVien> DSSinhVien(int malop)
        {
            var list_id = db.PhanLopSinhViens.Where(x => x.Malop == malop).Select(x => x.Masv).ToList();
            var list = new List<SinhVien>();
            foreach (var item in list_id)
            {
                list.Add(new f_sinhvien().GetSinhVien(item));
            }
            return list;
        }
        /// <summary>
        /// Get danh sách giáo viên đang dạy của lớp
        /// </summary>
        /// <param name="malop"></param>
        /// <returns>List giáo viên</returns>
        public List<GiaoVien> DSGiaoVien(int malop)
        {
            var list_id = db.PhanLopGiaoViens.Where(x => x.Malop == malop).Select(x => x.Magiaovien).ToList();
            var list = new List<GiaoVien>();
            foreach (var item in list_id)
            {
                list.Add(new f_giaovien().GetGiaoVien(item));
            }
            return list;
        }
    }
}
