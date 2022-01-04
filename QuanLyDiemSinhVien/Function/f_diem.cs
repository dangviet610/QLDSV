using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSinhVien.Model;

namespace QuanLyDiemSinhVien.Function
{
    public class f_diem
    {
        private Context db; 
        public f_diem()
        {
            db = new Context();
        }
        public Diem GetDiem(int masv, int mamon)
        {
            return db.Diems.FirstOrDefault(x=>x.Masv==masv&&x.Mamon==mamon);
        }
        public bool Them(int masv, int mamon, float diem)
        {
            var o = GetDiem(masv,mamon);
            if (o == null)
            {
                db.Diems.Add(new Diem { Masv = masv, Mamon = masv, Diem1 = diem });
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Sua(int masv, int mamon,float diem)
        {
            var o = GetDiem(masv, mamon);
            if (o != null)
            {
                o.Diem1 = diem;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Xoa(int masv, int mamon)
        {
            var o = GetDiem(masv, mamon);
            if (o != null)
            {
                db.Diems.Remove(o);
                db.SaveChanges();
                return true;
            }
            return false;
        }
     }
}
