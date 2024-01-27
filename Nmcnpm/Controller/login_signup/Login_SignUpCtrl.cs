using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5.Controller.login_signup
{
    public static class Login_SignUpCtrl
    {
        public static bool checkTK_MK(String tk, String mk)
        {
            nguoi_dung tk1 = dbContext.db.nguoi_dung
                .FirstOrDefault(p => tk == p.taiKhoan);
            if(tk1 != null)
            {
                if(tk1.taiKhoan == tk && tk1.matKhau==mk)
                {
                    return true;
                }    
            }    
            return false;
        }

        public static bool checkExistTK(String tk)
        {
            nguoi_dung tk1 = dbContext.db.nguoi_dung
                .FirstOrDefault(p => tk == p.taiKhoan);
            if (tk1 != null)
            {
                if (tk1.taiKhoan == tk)
                {
                    return true;
                }
            }
            return false;
        }
        public static void changeMK(String tk, String mk)
        {
            nguoi_dung tk1 = dbContext.db.nguoi_dung
                .FirstOrDefault(p => tk == p.taiKhoan);
            tk1.matKhau = mk;
            dbContext.db.SaveChanges();
        }

        public static void addTK_MK(String tk, String mk)
        {
            dbContext.db.nguoi_dung.Add(new nguoi_dung() {taiKhoan = tk, matKhau = mk});
            dbContext.db.SaveChanges();
        }
    }
}
