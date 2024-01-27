using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Data;

namespace Nhom5.Controller.hokhau_nhankhau.hokhau
{
    public class ChuHo
    {
        public int maHoKhau { get; set; }
        public int maChuHo { get; set; }
        public String diaChi { get; set; }
        public String tinhThanhPho { get; set; }
        public String hoTen { get; set; }
        public String phuongXa { get; set; }
        public String quanHuyen { get; set; }
        public String trangThai { get; set; }
        public DateTime ngayTao { get; set; }
    }
    public static class HoKhauUCCtrl
    {
        private static object _lock = new object();
        public static void loadHoKhau(DataGridView dtview)
        {
            try 
            {
                dtview.DataSource = dbContext.db.ho_khau
                    .Join(dbContext.db.nhan_khau, p => p.idChuHo,
                    q => q.idNhanKhau,
                    (p, q) => new { hokhau = p, nhankhau = q })
                    .Select(a => new {
                        a.hokhau.idHoKhau,
                        a.hokhau.idChuHo,
                        a.nhankhau.hoTen,
                        a.hokhau.diaChi,
                        a.hokhau.ngayTao,
                        a.hokhau.trangThai
                    }).ToList();
                dtview.Columns[0].HeaderText = "Mã hộ khẩu";
                dtview.Columns[1].HeaderText = "Mã chủ hộ";
                dtview.Columns[2].HeaderText = "Tên chủ hộ";
                dtview.Columns[3].HeaderText = "Địa chỉ";
                dtview.Columns[4].HeaderText = "Ngày tạo";
                dtview.Columns[5].HeaderText = "Trạng thái";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public static async void traCuuHoKhau(DataGridView dtview, String headText, String value)
        {
            var hokhaujoinnhankhau = dbContext.db.ho_khau
                .Join(dbContext.db.nhan_khau, p => p.idChuHo,
                q => q.idNhanKhau,
                (p, q) => new { hokhau = p, nhankhau = q })
                .Select(a => new {
                    a.hokhau.idHoKhau,
                    a.hokhau.idChuHo,
                    a.nhankhau.hoTen,
                    a.hokhau.diaChi,
                    a.hokhau.ngayTao,
                    a.hokhau.trangThai
                });
            int Index = 0;
            for (int i = 0; i < dtview.Columns.Count; i++)
                if (dtview.Columns[i].HeaderText == headText)
                {
                    Index = i;
                    break;
                }
            string columnName = dtview.Columns[Index].Name;
            var columnType = hokhaujoinnhankhau.First().GetType().GetProperty(columnName).PropertyType;
            if (columnType.IsAssignableFrom(typeof(int)))
            {
                int res = 0;
                if (int.TryParse(value, out res))
                {
                    // Sử lý nếu column là kiểu int
                    dtview.DataSource = await Task.Run(() =>
                    {
                        return hokhaujoinnhankhau
                            .AsQueryable()
                            .Where(string.Format("{0}=@0", columnName), res)
                            .Select(
                                a => new {
                                    a.idHoKhau,
                                    a.idChuHo,
                                    a.hoTen,
                                    a.diaChi,
                                    a.ngayTao,
                                    a.trangThai
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
                    return hokhaujoinnhankhau
                        .AsQueryable()
                        .Where(string.Format("{0}.Contains(@0)", columnName.ToString()), value.ToString())
                        .Select(
                                a => new {
                                    a.idHoKhau,
                                    a.idChuHo,
                                    a.hoTen,
                                    a.diaChi,
                                    a.ngayTao,
                                    a.trangThai
                                })
                        .ToList();
                });
            }
        }

        public static async void traCuuHoKhau2(DataGridView dtview, String headText, String value)
        {
            var khongTonTaiTrongHoKhau = dbContext.db.nhan_khau
                .Where(nk => !dbContext.db.ho_khau
                .Select(hk => hk.idChuHo)
                .Contains(nk.idNhanKhau) &&
                  nk.trangThai != "Đã qua đời" &&
                 !dbContext.db.ho_khau_nhan_khau
                .Select(hknh => hknh.idNhanKhau)
                .Contains(nk.idNhanKhau))
                .Select(nk => new { nk.idNhanKhau, nk.hoTen, nk.ngaySinh, nk.cmnd })
                .ToList();
            int Index = 0;
            for (int i = 0; i < dtview.Columns.Count; i++)
                if (dtview.Columns[i].HeaderText == headText)
                {
                    Index = i;
                    break;
                }
            string columnName = dtview.Columns[Index].Name;
            var columnType = khongTonTaiTrongHoKhau.First().GetType().GetProperty(columnName).PropertyType;
            if (columnType.IsAssignableFrom(typeof(int)))
            {
                int res = 0;
                if (int.TryParse(value, out res))
                {
                    // Sử lý nếu column là kiểu int
                    dtview.DataSource = await Task.Run(() =>
                    {
                        return khongTonTaiTrongHoKhau
                            .AsQueryable()
                            .Where(string.Format("{0}=@0", columnName), res)
                            .Select(
                                a => new {
                                    a.idNhanKhau,
                                    a.hoTen,
                                    a.ngaySinh,
                                    a.cmnd
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
                    return khongTonTaiTrongHoKhau
                        .AsQueryable()
                        .Where(string.Format("{0}.Contains(@0)", columnName.ToString()), value.ToString())
                        .Select(
                                a => new {
                                    a.idNhanKhau,
                                    a.hoTen,
                                    a.ngaySinh,
                                    a.cmnd
                                })
                        .ToList();
                });
            }
        }
        
        public static void themMoi_load(DataGridView dtview)
        {
            var khongTonTaiTrongHoKhau = dbContext.db.nhan_khau.AsQueryable()
                .Where(nk => !dbContext.db.ho_khau
                .Select(hk => hk.idChuHo)
                .Contains(nk.idNhanKhau) &&
                 !dbContext.db.ho_khau_nhan_khau
                .Select(hknh => hknh.idNhanKhau)
                .Contains(nk.idNhanKhau))
                .ToList();
            dtview.DataSource = khongTonTaiTrongHoKhau
                .Where(p=>p.trangThai!="Đã qua đời")
                .Select(p => new { p.idNhanKhau, p.hoTen, p.ngaySinh, p.cmnd})
                .ToList();
            dtview.Columns[0].HeaderText = "Mã nhân khẩu";
            dtview.Columns[1].HeaderText = "Họ tên";
            dtview.Columns[2].HeaderText = "Ngày sinh";
            dtview.Columns[3].HeaderText = "CCCD/CMND";
        }

        public static void themMoi_removeDT1(DataGridView dtview, DataGridView dtview2)
        {
            List<int> columnValues = new List<int>();
            for (int i = 0; i < dtview2.Rows.Count; i++)
            {
                string x = dtview2.Rows[i].Cells[0].Value.ToString();
                int val = x == "" ? 0 : Int32.Parse(x);
                columnValues.Add(val);
            }
            var khongTonTaiTrongHoKhau = dbContext.db.nhan_khau.AsQueryable()
                .Where(nk => !dbContext.db.ho_khau
                .Select(hk => hk.idChuHo)
                .Contains(nk.idNhanKhau) &&
                 !dbContext.db.ho_khau_nhan_khau
                .Select(hknh => hknh.idNhanKhau)
                .Contains(nk.idNhanKhau))
                .ToList();

            dtview.DataSource = khongTonTaiTrongHoKhau
                .Where(p => p.trangThai != "Đã qua đời" && !columnValues.Contains(p.idNhanKhau))
                .Select(p => new { p.idNhanKhau, p.hoTen, p.ngaySinh, p.cmnd })
                .ToList();
        }

        public static int themMoi_themChuHo(
            int idchuho,
            string tinhthanhpho,
            string quanhuyen,
            string phuongxa,
            string diachi,
            DateTime ngaytao,
            string trangthai)
        {
            dbContext.db.ho_khau.Add(
            new ho_khau()
            {
                idChuHo = idchuho,
                tinhThanhPho = tinhthanhpho,
                quanHuyen = quanhuyen,
                phuongXa = phuongxa,
                diaChi = diachi,
                ngayTao = ngaytao,
                trangThai = trangthai
            });
            var task = dbContext.db.SaveChangesAsync();
            task.Wait();
            var kq = dbContext.db.ho_khau
                    .Where(p => p.idChuHo == idchuho)
                    .Select(p => p.idHoKhau)
                    .ToList()[0].ToString();
            //Console.WriteLine("***************"+kq);
            return Int32.Parse(kq);    
        }

        public static void themMoi_themThanhVien(
            int idhokhau,
            int idnhankhau,
            string quanhe
            )
        {
            //Console.WriteLine(idhokhau+" "+idnhankhau+" "+quanhe);
            var hk_nk = new ho_khau_nhan_khau()
            {
                idHoKhau = idhokhau,
                idNhanKhau = idnhankhau,
                quanHeChuHo = quanhe
            };
            dbContext.db.ho_khau_nhan_khau.Add(hk_nk);
            dbContext.db.SaveChanges();
        }

        public static ChuHo xemHoKhau_ChuHo(int idchuho)
        {
            return dbContext.db.nhan_khau
                            .AsQueryable()
                            .Join(dbContext.db.ho_khau, p => p.idNhanKhau,
                             q => q.idChuHo,
                             (p, q) => new { nhankhau = p, hokhau = q })
                            .Where(string.Format("{0}=@0", "nhankhau.idNhanKhau"), idchuho)
                            .Select(t => new ChuHo() 
                            {
                                maHoKhau = t.hokhau.idHoKhau,
                                maChuHo = t.hokhau.idChuHo,
                                diaChi = t.hokhau.diaChi,
                                tinhThanhPho = t.hokhau.tinhThanhPho,
                                hoTen = t.nhankhau.hoTen,
                                phuongXa = t.hokhau.phuongXa,
                                quanHuyen = t.hokhau.quanHuyen,
                                trangThai = t.hokhau.trangThai,
                                ngayTao = t.hokhau.ngayTao
                            })
                            .ToList()[0];
        }

        public static void xemHoKhau_ThanhVien(DataGridView dt1, int idhokhau)
        {
            dt1.Invoke((MethodInvoker)delegate
            {
                dt1.DataSource = dbContext.db.nhan_khau
                            .AsQueryable()
                            .Join(dbContext.db.ho_khau_nhan_khau, p => p.idNhanKhau,
                             q => q.idNhanKhau,
                             (p, q) => new { nhankhau = p, hokhaunhankhau = q })
                            .Where(string.Format("{0}=@0", "hokhaunhankhau.idHoKhau"), idhokhau)
                            .Select(
                            t => new
                            {
                                t.nhankhau.idNhanKhau,
                                t.nhankhau.hoTen,
                                t.nhankhau.ngaySinh,
                                t.nhankhau.cmnd,
                                t.hokhaunhankhau.quanHeChuHo
                            })
                            .ToList();
                dt1.Columns[0].HeaderText = "ID nhân khẩu";
                dt1.Columns[1].HeaderText = "Họ tên";
                dt1.Columns[2].HeaderText = "Ngày sinh";
                dt1.Columns[3].HeaderText = "CMND/CCCD";
                dt1.Columns[4].HeaderText = "Quan hệ với chủ hộ";
            });
        }

        public static void chinhSuaHoKhau_CopyThanhVienToTable(DataTable table, int idhokhau)
        {
            var khongTonTaiTrongHoKhau = dbContext.db.nhan_khau.AsQueryable()
                .Join(dbContext.db.ho_khau_nhan_khau, p => p.idNhanKhau,
                             q => q.idNhanKhau,
                             (p, q) => new { nhankhau = p, hokhau = q })
                .Where(p=>p.hokhau.idHoKhau== idhokhau)
                .Select(p => new { p.nhankhau.idNhanKhau,
                    p.nhankhau.hoTen,
                    p.nhankhau.ngaySinh,
                    p.hokhau.quanHeChuHo })
                .ToList();
            foreach (var record in khongTonTaiTrongHoKhau)
            {
                DataRow row = table.NewRow();
                row["Mã nhân khẩu"] = record.idNhanKhau;
                row["Họ tên"] = record.hoTen;
                row["Ngày sinh"] = record.ngaySinh;
                row["Quan hệ với chủ hộ"] = record.quanHeChuHo;
                table.Rows.Add(row);
            }
        }

        public static void chinhSua_themThanhVien(
            int idhokhau,
            int idnhankhau,
            string quanhe
            )
        {
            //Console.WriteLine(idhokhau+" "+idnhankhau+" "+quanhe);
            var hk_nk = new ho_khau_nhan_khau()
            {
                idHoKhau = idhokhau,
                idNhanKhau = idnhankhau,
                quanHeChuHo = quanhe
            };
            if(!dbContext.db.ho_khau_nhan_khau.Any(r=> r.idHoKhau==hk_nk.idHoKhau && r.idNhanKhau==hk_nk.idNhanKhau))
                dbContext.db.ho_khau_nhan_khau.Add(hk_nk);
            dbContext.db.SaveChanges();
        }

        public static void tach_removeDT1(DataGridView dtview, DataGridView dtview2)
        {
            List<int> columnValues = new List<int>();
            for (int i = 0; i < dtview2.Rows.Count; i++)
            {
                string x = dtview2.Rows[i].Cells[0].Value.ToString();
                int val = x == "" ? 0 : Int32.Parse(x);
                columnValues.Add(val);
            }
            var khongTonTaiTrongHoKhau = dbContext.db.nhan_khau.AsQueryable()
                .Where(nk => !dbContext.db.ho_khau
                .Select(hk => hk.idChuHo)
                .Contains(nk.idNhanKhau) &&
                 !dbContext.db.ho_khau_nhan_khau
                .Select(hknh => hknh.idNhanKhau)
                .Contains(nk.idNhanKhau))
                .ToList();

            dtview.DataSource = khongTonTaiTrongHoKhau
                .Where(p => p.trangThai != "Đã qua đời" && !columnValues.Contains(p.idNhanKhau))
                .Select(p => new { p.idNhanKhau, p.hoTen, p.ngaySinh, p.cmnd })
                .ToList();
        }

        public static void tach_XoaHoKhau(DataTable dt)
        {
            List<int> ids = dt.AsEnumerable().Select(r => r.Field<int>("Mã nhân khẩu")).ToList();
            var rowsToRemove = dbContext.db.ho_khau_nhan_khau
                .AsQueryable()
                .Where(p => ids.Contains(p.idNhanKhau))
                .ToList();
            foreach (var row in rowsToRemove)
            {
                dbContext.db.ho_khau_nhan_khau.Remove(row);
            }

            dbContext.db.SaveChanges();
        }

        public static void chuyenHoKhau(
            int idhokhau,
            string diachi,
            string tinhthanhpho,
            string phuongxa,
            string quanhuyen,
            DateTime ngaychuyendi,
            string ghichu
            )
        {
            var hk = dbContext.db.ho_khau
                .FirstOrDefault(
                p => p.idHoKhau == idhokhau
                );
            hk.diaChi = diachi;
            hk.tinhThanhPho = tinhthanhpho;
            hk.phuongXa = phuongxa;
            hk.quanHuyen = quanhuyen;
            dbContext.db.chuyen_ho_khau
                .Add(new chuyen_ho_khau()
                {
                    idHoKhau = idhokhau,
                    ngayChuyenDi = ngaychuyendi,
                    noiChuyenDen = diachi,
                    ghiChu = ghichu
                });
            dbContext.db.SaveChanges();
            return;
        }

        public static void load_LichSu(DataGridView dtview, int idhokhau)
        {
            dtview.Invoke((MethodInvoker)delegate
            {
                dtview.DataSource = dbContext.db.chuyen_ho_khau
                    .Where(p=>p.idHoKhau==idhokhau)
                    .Select(p => new { p.id, p.ngayChuyenDi, p.noiChuyenDen, p.ghiChu })
                    .ToList();
                dtview.Columns[0].HeaderText = "ID";
                dtview.Columns[1].HeaderText = "Ngày chuyển đi";
                dtview.Columns[2].HeaderText = "Địa chỉ chuyển đến";
                dtview.Columns[3].HeaderText = "Ghi chú";
            });
            
        }
    }
}
