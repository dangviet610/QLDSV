using QuanLyDiemSinhVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSinhVien.Function
{
    public class ThongTinLop
    {
        public int malop { get; set; }
        public string tenlop { set; get; }
        public string tenmon { get; set; }
        public int mamon { get; set; }
        public string gv { set; get; }
    }
    public class f_sinhvien
    {
        private Context db;
        public f_sinhvien()
        {
            db = new Context();
        }
        public SinhVien GetSinhVien(int masv)
        {
            return db.SinhViens.FirstOrDefault(x=>x.Masv==masv);
        }
        public SinhVien GetSinhVien(string email)
        {
            return db.SinhViens.FirstOrDefault(x => x.Email == email);
        }
        /// <summary>
        /// Danh sách tất cả sinh viên
        /// </summary>
        /// <returns></returns>
        public List<SinhVien> DSSinhVien()
        {
            return db.SinhViens.ToList();
        }
        
        public bool Them(SinhVien e)
        {
            var o = GetSinhVien(e.Email);
            if (o == null)
            {
                db.SinhViens.Add(o);
                db.SaveChanges();
                return true;
            }
            else
            return false;
        }
        public bool Sua(SinhVien e)
        {
            var o = GetSinhVien(e.Masv);
            if (o != null)
            {
                var a = db.SinhViens.FirstOrDefault(x=>x.Email==e.Email && x.Masv!=e.Masv);
                if (a != null)
                {
                    return false;//email đã tồn tại
                }
                else
                {
                    o.Email = e.Email;
                    o.Ngaysinh = e.Ngaysinh;
                    o.Hoten = e.Hoten;
                    o.Gioitinh = e.Gioitinh;
                    if (e.Password != null)
                        o.Password = e.Password;
                    db.SaveChanges();
                    return true;
                }                      
            }
            else
                return false;
        }
        public bool DoiMatKhau(int id, string password)
        {
            var o = GetSinhVien(id);
            if (o != null)
            {
                o.Password = password;
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public bool Xoa(int id)
        {
            var o = GetSinhVien(id);
            if (o != null)
            {
                db.SinhViens.Remove(o);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Danh sách điểm của học sinh
        /// </summary>
        /// <param name="masv"></param>
        /// <returns></returns>
        public List<Diem> DSDiem(int masv)
        {
            return db.Diems.Where(x => x.Masv == masv).ToList();
        }
        /// <summary>
        /// Danh sách các lớp học sinh đang học nếu stt=true, ngược lại là danh sách các lớp chưa học
        /// </summary>
        /// <param name="masv"></param>
        /// <param name="stt"></param>
        /// <returns></returns>
        public List<ThongTinLop> DSLop(int masv, bool stt=true)
        {
            var a = db.PhanLopSinhViens.Where(x => x.Masv == masv).Select(x=>x.Malop).ToList();
            var b = db.PhanLopGiaoViens.Select(x=>x.Malop).ToList();
            var c = b.Except(a).ToList();
            if (!stt)
            {
                a = b.Except(a).ToList();
            }
            List<ThongTinLop> list = new List<ThongTinLop>();
            foreach(var item in a)
            {
                ThongTinLop l = new ThongTinLop();
                l.malop = item;
                l.tenlop = new f_lop().GetLop(item).Tenlop;
                var o = db.PhanLopGiaoViens.FirstOrDefault(x=>x.Malop==item);
                if (o != null)
                    l.gv = new f_giaovien().GetGiaoVien(o.Magiaovien).Hoten;
                else
                    l.gv = "Chưa phân giáo viên";
                l.tenmon = new f_monhoc().GetMonHoc(o.Mamon).Tenmon;
                list.Add(l);
            }
            return list;
        }
        public bool DangKyLopHoc(int masv, int malop)
        {
            var sv = GetSinhVien(masv);
            var lop = new f_lop().GetLop(malop);
            if (sv != null && lop != null)
            {
                db.PhanLopSinhViens.Add(new PhanLopSinhVien { Masv = masv, Malop = malop });
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
