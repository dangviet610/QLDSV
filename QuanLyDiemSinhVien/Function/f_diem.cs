using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSinhVien.Model;

namespace QuanLyDiemSinhVien.Function
{
    public class ThongTinBangDiem
    {
        public int mamon { get; set; }
        public int malop { get; set; }
        public double? diem { get; set; }
        public string tenmon { get; set; }
        public string tenlop { set; get; }
        public int masv { set; get; }
        public string tensv { set; get; }
    }
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
        public Diem GetDiem(int masv, int mamon, int malop)
        {
            return db.Diems.FirstOrDefault(x => x.Masv == masv && x.Mamon == mamon && x.Malop==malop);
        }
        public bool Them(int masv, int mamon, int malop, double diem)
        {
            var o = GetDiem(masv,mamon,malop);
            if (o == null)
            {
                db.Diems.Add(new Diem { Masv = masv, Mamon = masv, Diem1 = diem });
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Sua(int masv, int mamon,double diem)
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
        public bool Sua(int masv, int mamon, int malop, double diem)
        {
            var o = GetDiem(masv, mamon,malop);
            if (o != null)
            {
                o.Diem1 = diem;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Xoa(int masv, int mamon,int malop)
        {
            var o = GetDiem(masv, mamon,malop);
            if (o != null)
            {
                db.Diems.Remove(o);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public List<ThongTinBangDiem> BangDiem(int malop,int mamon)
        {
            List<ThongTinBangDiem> list = new List<ThongTinBangDiem>();
            var l2 = db.Diems.Where(x=>x.Malop==malop&&x.Mamon==mamon).ToList();
            foreach(var item in l2)
            {
                ThongTinBangDiem o = new ThongTinBangDiem();
                o.masv = item.Masv;
                o.tensv = new f_sinhvien().GetSinhVien(item.Masv).Hoten;
                o.malop = (int)item.Malop;
                o.tenlop = new f_lop().GetLop(o.malop).Tenlop;
                o.mamon = item.Mamon;
                o.tenmon = new f_monhoc().GetMonHoc(o.mamon).Tenmon;
                o.diem = item.Diem1;
                list.Add(o);
            }
            return list;
        }
     }
}
