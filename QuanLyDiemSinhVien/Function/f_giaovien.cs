using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSinhVien.Model;

namespace QuanLyDiemSinhVien.Function
{
    public class f_giaovien
    {
        private Context db; 
        public f_giaovien()
        {
            db = new Context();
        }
        public GiaoVien GetGiaoVien(int id)
        {
            return db.GiaoViens.FirstOrDefault(x=>x.Magiaovien==id);
        }
        public GiaoVien GetGiaoVien(string email)
        {
            return db.GiaoViens.FirstOrDefault(x=>x.Email==email);
        }
        public List<GiaoVien> DSGiaoVien()
        {
            return db.GiaoViens.ToList();
        }
        public bool Them(GiaoVien e)
        {
            var o = GetGiaoVien(e.Email);
            if (o == null)
            {
                db.GiaoViens.Add(o);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public bool Sua(GiaoVien e)
        {
            var o = GetGiaoVien(e.Magiaovien);
            if (o != null)
            {
                var a = db.GiaoViens.FirstOrDefault(x=>x.Email==e.Email && x.Magiaovien!=e.Magiaovien);
                if (a != null)
                {
                    return false;//email đã tồn tại
                }
                else
                {
                    o.Hoten = e.Hoten;
                    o.Gioitinh = e.Gioitinh;
                    o.Email = e.Email;
                    db.SaveChanges();
                    return true;
                }                 
            }
            else
                return true;
        }
        public bool Xoa(int id)
        {
            var o = GetGiaoVien(id);
            if (o != null)
            {
                db.GiaoViens.Remove(o);
                db.SaveChanges();
                return true;
            }
            else
                return true;
        }
        public bool DoiMatKhau(int id, string password)
        {
            var o = GetGiaoVien(id);
            if (o != null)
            {
                o.Password = password;
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Danh sách các lớp mà giáo viên đang dạy
        /// </summary>
        /// <param name="magv"></param>
        /// <returns></returns>
        public List<ThongTinLop> DSLop(int magv,bool stt=true)
        {
            var a = db.PhanLopGiaoViens.Where(x => x.Magiaovien == magv);
            if(!stt)
                a= db.PhanLopGiaoViens.Where(x => x.Magiaovien != magv);
            List<ThongTinLop> list = new List<ThongTinLop>();
            foreach (var item in a)
            {
                ThongTinLop l = new ThongTinLop();
                l.malop = item.Malop;
                l.tenlop = new f_lop().GetLop(item.Malop).Tenlop;
                l.mamon = item.Mamon;
                l.tenmon = new f_monhoc().GetMonHoc(item.Mamon).Tenmon;
                list.Add(l);
            }
            return list;
        }
        /// <summary>
        /// Danh sách các môn mà giáo viên đang dạy
        /// </summary>
        /// <param name="magv"></param>
        /// <returns></returns>
        public List<MonHoc> DSMon(int magv)
        {
            var a = db.PhanLopGiaoViens.Where(x => x.Magiaovien == magv);
            List<MonHoc> list = new List<MonHoc>();
            foreach (var item in a)
            {
                list.Add(new f_monhoc().GetMonHoc((int)item.Mamon));
            }
            return list;
        }
    }
}
