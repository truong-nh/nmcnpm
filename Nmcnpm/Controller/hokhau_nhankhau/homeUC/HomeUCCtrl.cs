using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5.Controller.hokhau_nhankhau.homeUC
{
    public static class HomeUCCtrl
    {
        public static int layNhanKhau()
        {
            try
            {
                return dbContext.db.nhan_khau.AsQueryable()
                .Where(p => p.trangThai.ToLower() == "Thường trú".ToLower()
                || p.trangThai.ToLower() == "Tạm trú".ToLower()).Count();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
            
        }
        public static int layHoKhau()
        {
            try
            {
                return dbContext.db.ho_khau.Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        public static int layTamTru()
        {
            try
            {
                return dbContext.db.tam_tru.Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        public static int layTamVang()
        {
            try
            {
                return dbContext.db.tam_vang.Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

    }
}
