using QuanLyDiemSinhVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSinhVien.Function
{
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
                    o.Ngaysinh = o.Ngaysinh;
                    o.Hoten = o.Hoten;
                    o.Gioitinh = o.Gioitinh;
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
        /// Danh sách điểm theo môn học của học sinh 
        /// </summary>
        /// <param name="masv"></param>
        /// <param name="mamon"></param>
        /// <returns></returns>
        public List<Diem> DSDiem(int masv, int mamon)
        {
            return db.Diems.Where(x => x.Masv == masv && x.Mamon==mamon).ToList();
        }
        /// <summary>
        /// Danh sách các lớp mà học sinh đang học
        /// </summary>
        /// <param name="masv"></param>
        /// <returns></returns>
        public List<Lop> DSLop(int masv)
        {
            var a = db.PhanLopSinhViens.Where(x => x.Masv == masv);
            List<Lop> list = new List<Lop>();
            foreach(var item in a)
            {
                list.Add(new f_lop().GetLop(item.Malop));
            }
            return list;
        }
        /// <summary>
        /// Danh sách các môn mà học sinh đang học
        /// </summary>
        /// <param name="masv"></param>
        /// <returns></returns>
        public List<MonHoc> DSMon(int masv)
        {
            var a = db.PhanLopSinhViens.Where(x => x.Masv == masv);
            List<MonHoc> list = new List<MonHoc>();
            foreach (var item in a)
            {
                list.Add(new f_monhoc().GetMonHoc(item.Mamon));
            }
            return list;
        }
    }
}
