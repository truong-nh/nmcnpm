using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5.Controller.trao_thuong
{
    public static class DipDacBietUCCtrl
    {
        public static void load_Dip(DataGridView dtview)
        {
            try
            {
                dtview.DataSource = dbContext.db.dip_dac_biet
                .GroupJoin(dbContext.db.chi_tiet_dip_dac_biet, p => p.idDip,
                    q => q.idDip,
                    (p, q) => new { dip_db = p, chitiet_dip = q.DefaultIfEmpty() })
                .Select(t =>
                new {
                    t.dip_db.idDip,
                    t.dip_db.ten,
                    t.dip_db.nam,
                    count = t.chitiet_dip.Count(c => c.kiemtra == false),
                    t.dip_db.moTa
                }).ToList();
                dtview.Columns[0].HeaderText = "ID dịp";
                dtview.Columns[1].HeaderText = "Tên dịp";
                dtview.Columns[2].HeaderText = "Năm";
                dtview.Columns[3].HeaderText = "Số người chưa được trao thưởng";
                dtview.Columns[4].HeaderText = "Mô tả";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public static async void traCuuDipDacBiet(DataGridView dtview, String headText, String value)
        {
            var table = dbContext.db.dip_dac_biet
                .GroupJoin(dbContext.db.chi_tiet_dip_dac_biet, p => p.idDip,
                    q => q.idDip,
                    (p, q) => new { dip_db = p, chitiet_dip = q.DefaultIfEmpty() })
                .Select(t =>
                new {
                    t.dip_db.idDip,
                    t.dip_db.ten,
                    t.dip_db.nam,
                    count = t.chitiet_dip.Count(c => c.kiemtra == false),
                    t.dip_db.moTa
                }).ToList();

            int Index = 0;
            for (int i = 0; i < dtview.Columns.Count; i++)
                if (dtview.Columns[i].HeaderText == headText)
                {
                    Index = i;
                    break;
                }
            string columnName = dtview.Columns[Index].Name;
            var columnType = table.First().GetType().GetProperty(columnName).PropertyType;
            //Console.WriteLine(columnType+" "+Index);
            if (columnType.IsAssignableFrom(typeof(int)))
            {
                int res = 0;
                //Console.WriteLine(value);
                if (int.TryParse(value, out res))
                {
                    // Sử lý nếu column là kiểu int
                    dtview.DataSource = await Task.Run(() =>
                    {
                        return table
                            .AsQueryable()
                            .Where(string.Format("{0}=@0", columnName), res)
                            .Select(p => new { p.idDip, p.ten, p.nam, p.count, p.moTa })
                            .ToList();
                    });
                }
            }
            else
            {
                // Sử lý nếu column không phải là kiểu int
                dtview.DataSource = await Task.Run(() =>
                {
                    return table
                            .AsQueryable()
                            .Where(string.Format("{0}.Contains(@0)", columnName.ToString()), value.ToString())
                            .Select(p => new { p.idDip, p.ten, p.nam, p.count, p.moTa })
                            .ToList();
                });
            }
        }

        public static void taoDipDacBiet(
            String ten,
            int nam,
            String qualoai1,
            float tien1,
            String qualoai2,
            float tien2,
            String qualoai3,
            float tien3,
            string mota
            )
        {
            dbContext.db.dip_dac_biet.Add(
                new dip_dac_biet()
                {
                    ten = ten,
                    nam = nam,
                    phanQua05 = qualoai1,
                    phanQua1517 = qualoai2,
                    phanQua614 = qualoai3,
                    tien05 = tien1,
                    tien614 = tien2,
                    tien1517 = tien3,
                    moTa = mota
                });
            dbContext.db.SaveChanges();
        }

        public static dip_dac_biet xemDipDacBiet(int iddip)
        {
            var res = dbContext.db.dip_dac_biet.FirstOrDefault(p => p.idDip == iddip);
            return res;
        }

        public static void chinhSuaDipDacBiet(
            int iddip,
            String ten,
            String qualoai1,
            float tien1,
            String qualoai2,
            float tien2,
            String qualoai3,
            float tien3,
            string mota
            )
        {
            var res = dbContext.db.dip_dac_biet.FirstOrDefault(p => p.idDip == iddip);
            res.ten = ten;
            res.phanQua05 = qualoai1;
            res.phanQua614 = qualoai2;
            res.phanQua1517 = qualoai3;
            res.tien05 = tien1;
            res.tien614 = tien2;
            res.tien1517 = tien3;
            res.moTa = mota;
            dbContext.db.SaveChanges();
        }

        public static String changeThanhTich(int x)
        {
            if (x == 1)
                return "Độ tuổi từ 0 đến 5";
            if (x == 2)
                return "Độ tuổi từ 6 đến 14";
            if (x == 3)
                return "Độ tuổi từ 15 đến 17";
            return "Người lớn";
        }
        public static void load_DanhSachDip(DataGridView dtview, int iddip)
        {
            var results = dbContext.db.chi_tiet_dip_dac_biet
                .Join(dbContext.db.nhan_khau, p => p.idNhanKhau,
                q => q.idNhanKhau, (p, q) => new { dipdb = p, nhankhau = q })
                .Where(p => p.dipdb.idDip == iddip)
                .AsEnumerable()
                .Select(p =>
                new {
                    p.dipdb.idNhanKhau,
                    p.nhankhau.hoTen,
                    nhom = changeThanhTich(p.dipdb.nhom),
                    p.dipdb.kiemtra
                });
            dtview.Invoke((MethodInvoker)delegate
            {
                dtview.DataSource = results.ToList();
                dtview.Columns[0].HeaderText = "ID Nhân khẩu";
                dtview.Columns[1].HeaderText = "Họ tên";
                dtview.Columns[2].HeaderText = "Nhóm phần thưởng";
                dtview.Columns[3].HeaderText = "Đã trao thưởng";
            });
        }

        public static async void traCuuDanhSachDip(DataGridView dtview, String headText, String value, int iddip)
        {
            var table = dbContext.db.chi_tiet_dip_dac_biet
                .Join(dbContext.db.nhan_khau, p => p.idNhanKhau,
                q => q.idNhanKhau, (p, q) => new { dipdb = p, nhankhau = q })
                .Where(p => p.dipdb.idDip == iddip)
                .AsEnumerable()
                .Select(p =>
                new {
                    p.dipdb.idNhanKhau,
                    p.nhankhau.hoTen,
                    nhom = changeThanhTich(p.dipdb.nhom),
                    p.dipdb.kiemtra
                }).ToList();

            int Index = 0;
            for (int i = 0; i < dtview.Columns.Count; i++)
                if (dtview.Columns[i].HeaderText == headText)
                {
                    Index = i;
                    break;
                }
            string columnName = dtview.Columns[Index].Name;
            var columnType = table.First().GetType().GetProperty(columnName).PropertyType;
            //Console.WriteLine(columnType+" "+Index);
            if (columnType.IsAssignableFrom(typeof(int)))
            {
                int res = 0;
                //Console.WriteLine(value);
                if (int.TryParse(value, out res))
                {
                    // Sử lý nếu column là kiểu int
                    dtview.DataSource = await Task.Run(() =>
                    {
                        return table
                            .AsQueryable()
                            .Where(string.Format("{0}=@0", columnName), res)
                            .Select(p => new {
                                p.idNhanKhau,
                                p.hoTen,
                                p.nhom,
                                p.kiemtra
                            })
                            .ToList();
                    });
                }
            }
            else
            {
                // Sử lý nếu column không phải là kiểu int
                dtview.DataSource = await Task.Run(() =>
                {
                    return table
                            .AsQueryable()
                            .Where(string.Format("{0}.Contains(@0)", columnName.ToString()), value.ToString())
                            .Select(p => new {
                                p.idNhanKhau,
                                p.hoTen,
                                p.nhom,
                                p.kiemtra
                            })
                            .ToList();
                });
            }
        }

    }
}
