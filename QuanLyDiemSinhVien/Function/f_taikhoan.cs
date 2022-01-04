using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSinhVien.Model;

namespace QuanLyDiemSinhVien.Function
{
    public class f_taikhoan
    {
        private Context db;
        public f_taikhoan()
        {
            db = new Context();
        }
        public bool Login(string email, string password,string type="sv")
        {            
            if (type == "gv")
            {
                var o = db.GiaoViens.FirstOrDefault(x => x.Email == email && x.Password == password);
                return o != null;
            }
            else
            if(type=="admin")
            {
                var o = db.Admins.FirstOrDefault(x => x.Username == email && x.Password == password);
                return o != null;
            }
            else
            {
                var o = db.SinhViens.FirstOrDefault(x => x.Email == email && x.Password == password);
                return o != null;
            }
        }
    }
}
