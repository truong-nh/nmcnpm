using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic;
using System.Linq.Expressions;

namespace Nhom5.Controller.hokhau_nhankhau.nhankhau
{
    public static class NhanKhauUCCtrl
    {
        public static void loadNhanKhau(DataGridView dtview)
        {
            try
            {
                dtview.DataSource = dbContext.db.nhan_khau
               .Select(p => new { p.idNhanKhau, p.hoTen, p.ngaySinh, p.gioiTinh, p.cmnd, p.trangThai })
               .ToList();
                dtview.Columns[0].HeaderText = "ID nhân khẩu";
                dtview.Columns[1].HeaderText = "Họ tên";
                dtview.Columns[2].HeaderText = "Ngày sinh";
                dtview.Columns[3].HeaderText = "Giới tính";
                dtview.Columns[4].HeaderText = "CCCD/CMND";
                dtview.Columns[5].HeaderText = "Trạng thái";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static async void traCuuNhanKhau(DataGridView dtview, String headText, String value)
        {
            int Index = 0;
            for(int i=0;i<=5;i++)
            if(dtview.Columns[i].HeaderText == headText)
            {
                    Index = i;
                    break;
            }
            string columnName = dtview.Columns[Index].Name;
            var columnType = dbContext.db.nhan_khau.First().GetType().GetProperty(columnName).PropertyType;
            if (columnType.IsAssignableFrom(typeof(int)))
            {
                int res = 0;
                if (int.TryParse(value, out res))
                {
                    // Sử lý nếu column là kiểu int
                    dtview.DataSource = await Task.Run(() =>
                    {
                        return dbContext.db.nhan_khau
                            .AsQueryable()
                            .Where(string.Format("{0}=@0", columnName), res)
                            .Select(p => new { p.idNhanKhau, p.hoTen, p.ngaySinh, p.gioiTinh, p.cmnd, p.trangThai })
                            .ToList();
                    });
                }
            }
            else
            {
                // Sử lý nếu column không phải là kiểu int
                dtview.DataSource = await Task.Run(() =>
                {
                    return dbContext.db.nhan_khau
                        .AsQueryable()
                        .Where(string.Format("{0}.Contains(@0)", columnName.ToString()), value.ToString())
                        .Select(p => new { p.idNhanKhau, p.hoTen, p.ngaySinh, p.gioiTinh, p.cmnd, p.trangThai })
                        .ToList();
                });
            }
        }

        public static bool themNhanKhau(
            String hoten,
            String bidanh,
            DateTime ngaysinh,
            String noisinh,
            String gioitinh,
            String nguyenquan,
            String dantoc,
            String tongiao,
            String quoctich,
            String nghenghiep,
            String noilamviec,
            String cmnd,
            DateTime ngaycap,
            DateTime chuyendenngay,
            String noithuongtrutruoc,
            String trangthai
            )
        {       
            if(hoten=="" || quoctich==""  || noisinh==""  || nguyenquan == ""
               || dantoc=="" || tongiao == "" )
            {
                return false;
            }
            dbContext.db.nhan_khau.Add(
                new nhan_khau()
                {
                    hoTen = hoten,
                    biDanh = bidanh,
                    ngaySinh = ngaysinh,
                    noiSinh = noisinh,
                    gioiTinh = gioitinh,
                    nguyenQuan = nguyenquan,
                    danToc = dantoc,
                    tonGiao = tongiao,
                    quocTich = quoctich,
                    ngheNghiep = nghenghiep,
                    noiLamViec = noilamviec,
                    cmnd = cmnd,
                    ngayCap = ngaycap,
                    chuyenDenNgay = chuyendenngay,
                    noiThuongTruTruoc = noithuongtrutruoc,
                    trangThai = trangthai
                });
            try
            {
                dbContext.db.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                //xoá mọi query
                foreach (var entry in dbContext.db.ChangeTracker.Entries())
                {
                    entry.State = (System.Data.Entity.EntityState)EntityState.Detached;

                }
                dbContext.db.SaveChanges();
                return false;
            }
            return true;
        }
        
        public static nhan_khau xemNhanKhau(int id)
        {
            return  dbContext.db.nhan_khau
                            .AsQueryable()
                            .Where(string.Format("{0}=@0", "idNhanKhau"), id)
                            .Select(p => p)
                            .ToList()[0];
        }

        public static bool chinhSuaNhanKhau(
            int id,
            String hoten,
            String bidanh,
            DateTime ngaysinh,
            String noisinh,
            String gioitinh,
            String nguyenquan,
            String dantoc,
            String tongiao,
            String quoctich,
            String nghenghiep,
            String noilamviec,
            String cmnd,
            DateTime ngaycap,
            DateTime chuyendenngay,
            String noithuongtrutruoc,
            String trangthai
            )
        {
            if (hoten == "" || quoctich == "" || noisinh == "" || nguyenquan == ""
               || dantoc == "" || tongiao == "")
            {
                return false;
            }
            var nk = dbContext.db.nhan_khau.FirstOrDefault(a => a.idNhanKhau==id);
            nk.hoTen = hoten;
            nk.biDanh = bidanh;
            nk.ngaySinh = ngaysinh;
            nk.noiSinh = noisinh;
            nk.gioiTinh = gioitinh;
            nk.nguyenQuan = nguyenquan;
            nk.danToc = dantoc;
            nk.tonGiao = tongiao;
            nk.quocTich = quoctich;
            nk.ngheNghiep = nghenghiep;
            nk.noiLamViec = noilamviec;
            nk.cmnd = cmnd;
            nk.ngayCap = ngaycap;
            nk.chuyenDenNgay = chuyendenngay;
            nk.noiThuongTruTruoc = noithuongtrutruoc;
            nk.trangThai = trangthai;
            dbContext.db.SaveChanges();
            return true;
        }

        public static bool dangKiTamVang(
            int id,
            String noitamtru,
            DateTime tungay,
            DateTime denngay,
            String lydo
            )
        {
            if (noitamtru == "")
                return false;
            dbContext.db.tam_vang.Add(new tam_vang()
                {
                    idNhanKhau = id,
                    noiTamTru = noitamtru,
                    tuNgay = tungay,
                    denNgay = denngay,
                    lyDo = lydo
                });
            var nk = dbContext.db.nhan_khau.FirstOrDefault(p => p.idNhanKhau == id);
            nk.trangThai = "Tạm vắng";
            dbContext.db.SaveChanges();
            return true;
        }

        public static bool dangKiTamTru(
            int id,
            String noiotruoc,
            String noitamtru,
            DateTime tungay,
            DateTime denngay,
            String lydo
            )
        {
            if (noitamtru == "")
                return false;
            dbContext.db.tam_tru.Add(new tam_tru()
            {
                idNhanKhau = id,
                noiThuongTru = noiotruoc,
                noiTamTru = noitamtru,
                tuNgay = tungay,
                denNgay = denngay,
                lyDo = lydo
            });
            var nk = dbContext.db.nhan_khau.FirstOrDefault(p => p.idNhanKhau == id);
            nk.trangThai = "Tạm trú";
            dbContext.db.SaveChanges();
            return true;
        }

        public static async void loadNguoiKhaiBao(DataGridView dtview, int ID)
        {
            await Task.Run(() =>
            {
                dtview.Invoke((MethodInvoker)delegate
                {
                    dtview.DataSource = dbContext.db.nhan_khau.AsQueryable()
                    .Where(p=> p.idNhanKhau != ID & p.trangThai != "Đã qua đời")
                    .Select(p => new { p.idNhanKhau, p.hoTen, p.ngaySinh, p.gioiTinh, p.cmnd })
                    .ToList();
                    dtview.Columns[0].HeaderText = "ID nhân khẩu";
                    dtview.Columns[1].HeaderText = "Họ tên";
                    dtview.Columns[2].HeaderText = "Ngày sinh";
                    dtview.Columns[3].HeaderText = "Giới tính";
                    dtview.Columns[4].HeaderText = "CCCD/CMND";
                });
            });
            
        }
        
        public static bool khaiTu_ThemBangKhaiTu(
            int idnguoimat,
            int idnguoikhai,
            DateTime ngaykhai,
            DateTime ngaymat,
            String lydomat
            )
        {
            if (idnguoimat == 0 || idnguoikhai == 0 ||
                lydomat == "")
                return false;
            dbContext.db.khai_tu.Add(new khai_tu()
            {
                idNguoiMat = idnguoimat,
                idNguoiKhai = idnguoikhai,
                ngayKhai = ngaykhai,
                ngayMat = ngaymat,
                liDoMat = lydomat
            });
            var nk = dbContext.db.nhan_khau.FirstOrDefault(p =>
                p.idNhanKhau == idnguoimat  );
            nk.trangThai = "Đã qua đời";
            dbContext.db.SaveChanges();
            return true;
        }
        public static void khaiTu_XoaBangLienQuan(int ID)
        {
            var hk_nk = dbContext.db.ho_khau_nhan_khau.FirstOrDefault(p => p.idNhanKhau == ID);
            if(hk_nk!=null)
            {
                dbContext.db.ho_khau_nhan_khau.Remove(hk_nk);
            }
            // lấy 1 thành viên khác trong gđ làm chủ hộ

            //lấy chủ nhà
            var hk_nk2 = dbContext.db.ho_khau.FirstOrDefault(p => p.idChuHo == ID);
            if(hk_nk2!=null)
            {
                //lấy thành viên
                hk_nk = dbContext.db.ho_khau_nhan_khau.AsQueryable()
                    .FirstOrDefault(p => p.idNhanKhau != ID && p.idHoKhau == hk_nk2.idHoKhau);
                if(hk_nk!=null)
                {
                    // gán cho thành viên lên làm chủ
                    hk_nk2.idChuHo = hk_nk.idNhanKhau;
                    // loại ra khoi danh sach thanh vien
                    dbContext.db.ho_khau_nhan_khau.Remove(hk_nk);
                }
                else //thanh vien khong co
                {
                    hk_nk2.trangThai = "Không có người ở";
                }
            }    
            
            dbContext.db.SaveChanges();
        }
    }
}
