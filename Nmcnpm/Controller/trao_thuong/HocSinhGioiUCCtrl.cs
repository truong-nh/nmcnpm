using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic;
using System.Linq.Expressions;

namespace Nhom5.Controller.traothuong
{
    public static class HocSinhGioiUCCtrl
    {
        public static void load_HSG(DataGridView dtview)
        {
            try 
            {
                dtview.DataSource = dbContext.db.dip_hoc_sinh_gioi
                .GroupJoin(dbContext.db.chi_tiet_dip_hoc_sinh_gioi, p => p.idDip,
                    q => q.idDip,
                    (p, q) => new { dip_hsg = p, chitiet_hsg = q.DefaultIfEmpty() })
                .Select(t =>
                new {
                    t.dip_hsg.idDip,
                    t.dip_hsg.nam,
                    count = t.chitiet_hsg.Count(c => c.kiemtra == false),
                    t.dip_hsg.moTa
                }).ToList();
                dtview.Columns[0].HeaderText = "ID dịp";
                dtview.Columns[1].HeaderText = "Năm";
                dtview.Columns[2].HeaderText = "Số người chưa được trao thưởng";
                dtview.Columns[3].HeaderText = "Mô tả";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public static async void traCuuDipHSG(DataGridView dtview, String headText, String value)
        {
            var table = dbContext.db.dip_hoc_sinh_gioi
                .GroupJoin(dbContext.db.chi_tiet_dip_hoc_sinh_gioi, p => p.idDip,
                    q => q.idDip,
                    (p, q) => new { dip_hsg = p, chitiet_hsg = q.DefaultIfEmpty() })
                .Select(t =>
                new {
                    t.dip_hsg.idDip,
                    t.dip_hsg.nam,
                    count = t.chitiet_hsg.Count(c => c.kiemtra == false),
                    t.dip_hsg.moTa
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
                            .Select(p => new { p.idDip, p.nam, p.count, p.moTa })
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
                            .Select(p => new { p.idDip, p.nam, p.count, p.moTa })
                            .ToList();
                });
            }
        }

        public static void taoDipHSG(
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
            dbContext.db.dip_hoc_sinh_gioi.Add(
                new dip_hoc_sinh_gioi()
                {
                    nam = nam,
                    phanQuaDacBiet = qualoai1,
                    phanQuaGioi = qualoai2,
                    phanQuaKha = qualoai3,
                    tienDacBiet = tien1,
                    tienGioi = tien2,
                    tienKha = tien3,
                    moTa = mota
                });
            dbContext.db.SaveChanges();
        }

        public static dip_hoc_sinh_gioi xemDipHSG(int iddip)
        {
            var res = dbContext.db.dip_hoc_sinh_gioi.FirstOrDefault(p => p.idDip == iddip);
            return res;
        }

        public static nhan_khau xemHSG(int idnk)
        {
            var res = dbContext.db.nhan_khau.FirstOrDefault(p => p.idNhanKhau == idnk);
            return res;
        }

        public static void chinhSuaHSG(
            int iddip,
            String qualoai1,
            float tien1,
            String qualoai2,
            float tien2,
            String qualoai3,
            float tien3,
            string mota)
        {
            var res = dbContext.db.dip_hoc_sinh_gioi.FirstOrDefault(p => p.idDip == iddip);
            res.phanQuaDacBiet = qualoai1;
            res.tienDacBiet = tien1;
            res.phanQuaGioi = qualoai2;
            res.tienGioi = tien2;
            res.phanQuaKha = qualoai3;
            res.tienKha = tien3;
            res.moTa = mota;
            dbContext.db.SaveChanges();
        }
        public static String changeThanhTich(int x)
        {
            if (x == 1)
                return "Học sinh giỏi đặc biệt";
            if (x == 2)
                return "Học sinh giỏi";
            if (x == 3)
                return "Học sinh khá";
            return "Học sinh trung bình";
        }
        public static void load_HSGTrongDip(DataGridView dtview ,int iddip)
        {
            var results = dbContext.db.chi_tiet_dip_hoc_sinh_gioi
                .Join(dbContext.db.nhan_khau, p => p.idNhanKhau,
                q => q.idNhanKhau, (p, q) => new { hsg = p, nhankhau = q })
                .Where(p => p.hsg.idDip == iddip)
                .AsEnumerable()
                .Select(p =>
                new {
                    p.hsg.idNhanKhau,
                    p.nhankhau.hoTen,
                    nhom = changeThanhTich(p.hsg.nhom),
                    p.hsg.truong,
                    p.hsg.lop,
                    p.hsg.kiemtra
                });
            dtview.Invoke((MethodInvoker)delegate
            {
                dtview.DataSource = results.ToList();
                dtview.Columns[0].HeaderText = "ID dịp";
                dtview.Columns[1].HeaderText = "Họ tên";
                dtview.Columns[2].HeaderText = "Thành tích";
                dtview.Columns[3].HeaderText = "Trường";
                dtview.Columns[4].HeaderText = "Lớp";
                dtview.Columns[5].HeaderText = "Đã trao thưởng";
            });
        }

        public static void load_HSGChuaDK(DataGridView dtview, int iddip)
        {
            var results = dbContext.db.nhan_khau
                .Select(a =>
                new {
                    a.idNhanKhau,
                    a.hoTen,
                    a.ngaySinh,
                    a.gioiTinh
                }).
                Where(a => 
                !dbContext.db.chi_tiet_dip_hoc_sinh_gioi
                .Where(p=>p.idDip==iddip)
                .Select(p=>p.nhan_khau)
                .Any(p=> a.idNhanKhau==p.idNhanKhau)
                && DateTime.Now.Year - a.ngaySinh.Year < 20
                );
            dtview.Invoke((MethodInvoker)delegate
            {
                dtview.DataSource = results.ToList();
                dtview.Columns[0].HeaderText = "ID nhân khẩu";
                dtview.Columns[1].HeaderText = "Họ tên";
                dtview.Columns[2].HeaderText = "Ngày sinh";
                dtview.Columns[3].HeaderText = "Giới tính";
            });
        }
        public static async void traCuu_HSGTrongDip(DataGridView dtview, String headText, String value, int iddip)
        {
            var table = dbContext.db.chi_tiet_dip_hoc_sinh_gioi
                .Join(dbContext.db.nhan_khau, p => p.idNhanKhau,
                q => q.idNhanKhau, (p, q) => new { hsg = p, nhankhau = q })
                .Where(p => p.hsg.idDip == iddip)
                .AsEnumerable()
                .Select(p =>
                new {
                    p.hsg.idNhanKhau,
                    p.nhankhau.hoTen,
                    nhom = changeThanhTich(p.hsg.nhom),
                    p.hsg.truong,
                    p.hsg.lop,
                    p.hsg.kiemtra
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
                                p.truong,
                                p.lop,
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
                                p.truong,
                                p.lop,
                                p.kiemtra
                            })
                            .ToList();
                });
            }
        }

        public static async void traCuu_HSGChuaDK(DataGridView dtview, String headText, String value, int iddip)
        {
            var table = dbContext.db.nhan_khau
                .Select(a =>
                new {
                    a.idNhanKhau,
                    a.hoTen,
                    a.ngaySinh,
                    a.gioiTinh
                }).
                Where(a =>
                !dbContext.db.chi_tiet_dip_hoc_sinh_gioi
                .Where(p => p.idDip == iddip)
                .Select(p => p.nhan_khau)
                .Any(p => a.idNhanKhau == p.idNhanKhau)
                && DateTime.Now.Year - a.ngaySinh.Year <20
                ).ToList();

            int Index = 0;
            for (int i = 0; i < dtview.Columns.Count; i++)
                if (dtview.Columns[i].HeaderText == headText)
                {
                    Index = i;
                    break;
                }
            string columnName = dtview.Columns[Index].Name;
            var columnType = table.First().GetType().GetProperty(columnName).PropertyType;
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
                            .Select(a => new {
                                a.idNhanKhau,
                                a.hoTen,
                                a.ngaySinh,
                                a.gioiTinh
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
                            .Select(a => new {
                                a.idNhanKhau,
                                a.hoTen,
                                a.ngaySinh,
                                a.gioiTinh
                            })
                            .ToList();
                });
            }
        }

        public static void minhChung_themHSG(
            int iddip,
            int idnhankhau,
            string truong,
            string lop,
            int nhom,
            string minhchung,
            bool kiemtra
            )
        {
            dbContext.db.chi_tiet_dip_hoc_sinh_gioi
                .Add(new chi_tiet_dip_hoc_sinh_gioi()
                {
                    idDip = iddip,
                    idNhanKhau = idnhankhau,
                    truong = truong,
                    lop = lop,
                    nhom = nhom,
                    minhChung = minhchung,
                    kiemtra = kiemtra
                });
            dbContext.db.SaveChanges();
        }
    }
}
