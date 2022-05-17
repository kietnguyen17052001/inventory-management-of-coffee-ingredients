using QuanLyKhoHang.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.BussinessLogicLayer
{
    class BLLayer_TaiKhoan
    {
        private Team06Entities team06 = new Team06Entities();
        private static BLLayer_TaiKhoan _instance;
        public static BLLayer_TaiKhoan instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new BLLayer_TaiKhoan();
                }
                return _instance;
            }
            private set { }
        }
        private BLLayer_TaiKhoan() { }
        // Kiem tra ton tai ten dang nhap
        public bool isTonTaiTenDangNhap(string tenDangNhap)
        {
            var nguoiDung = team06.NGUOIDUNGs.Where(p => p.TAIKHOAN == tenDangNhap).SingleOrDefault();
            if(nguoiDung == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Ham kiem tra dang nhap co thanh cong?
        public bool isDangNhapThanhCong(string tenDangNhap, string matKhau)
        {
            var taiKhoan = team06.NGUOIDUNGs.Where(p => p.TAIKHOAN == tenDangNhap).SingleOrDefault();
            if (taiKhoan == null)
            {
                return false;
            }
            else
            {
                if (taiKhoan.MATKHAU == matKhau)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        // Tra ve ten nhan vien boi tai khoan dang nhap
        public string tenNhanVien(string tenDangNhap)
        {
            var nhanVien = team06.NGUOIDUNGs.Where(p => p.TAIKHOAN == tenDangNhap).SingleOrDefault();
            return nhanVien.TENNHANVIEN;
        }
        // Kiem tra ton tai ma nhan vien
        public bool isTonTaiMaNhanVien(string maNhanVien)
        {
            var nguoiDung = team06.NGUOIDUNGs.Find(maNhanVien);
            if (nguoiDung == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Combobox nhan vien
        public List<ComboboxItem> comboboxNhanVien()
        {
            List<ComboboxItem> listNhanVien = new List<ComboboxItem>();
            foreach(NGUOIDUNG nhanVien in team06.NGUOIDUNGs)
            {
                listNhanVien.Add(new ComboboxItem { Ma = nhanVien.MANHANVIEN, Ten = nhanVien.TENNHANVIEN });
            }
            return listNhanVien;
        }
        // Du lieu nguoi dung
        public void DuLieuNguoiDung(DataGridView dataGV)
        {
            var nguoiDung = team06.NGUOIDUNGs.Select(p => new
            {
                p.MANHANVIEN,
                p.TENNHANVIEN,
                p.TAIKHOAN,
                p.MATKHAU
            });
            dataGV.DataSource = nguoiDung.ToList();
        }
        // Them nguoi dung
        public void ThemNguoiDung(string maNhanVien, string tenNhanVien, string taiKhoan, string matKhau)
        {
            NGUOIDUNG nguoiDung = new NGUOIDUNG();
            nguoiDung.MANHANVIEN = maNhanVien;
            nguoiDung.TENNHANVIEN = tenNhanVien;
            nguoiDung.TAIKHOAN = taiKhoan;
            nguoiDung.MATKHAU = matKhau;
            team06.NGUOIDUNGs.Add(nguoiDung);
            team06.SaveChanges();
        }
        // Sua nguoi dung
        public void SuaNguoiDung(string maNhanVien, string tenNhanVien, string taiKhoan, string matKhau)
        {
            var nguoiDung = team06.NGUOIDUNGs.Find(maNhanVien);
            nguoiDung.TENNHANVIEN = tenNhanVien;
            nguoiDung.TAIKHOAN = taiKhoan;
            nguoiDung.MATKHAU = matKhau;
            team06.SaveChanges();
        }
        // Xoa nguoi dung 
        public void XoaNguoiDung(List<string> listMaNhanVien)
        {
            NGUOIDUNG nguoiDung = new NGUOIDUNG();
            foreach(string maNhanVien in listMaNhanVien)
            {
                nguoiDung = team06.NGUOIDUNGs.Find(maNhanVien);
                team06.NGUOIDUNGs.Remove(nguoiDung);
                team06.SaveChanges();
            }
        }
        // Tim kiem nguoi dung
        public void TimKiemNguoiDung(DataGridView dataGV, string thongTinTimKiem)
        {
            if (String.IsNullOrEmpty(thongTinTimKiem) || (thongTinTimKiem == "Nhập mã, tên nhân viên hoặc tên đăng nhập"))
            {
                DuLieuNguoiDung(dataGV);
            }
            else
            {
                var nguoiDung = team06.NGUOIDUNGs.Where(p => p.MANHANVIEN.Contains(thongTinTimKiem)
                || p.TENNHANVIEN.Contains(thongTinTimKiem) || p.TAIKHOAN.Contains(thongTinTimKiem)).Select(p => new
                {
                    p.MANHANVIEN,
                    p.TENNHANVIEN,
                    p.TAIKHOAN,
                    p.MATKHAU
                });
                dataGV.DataSource = nguoiDung.ToList();
            }
        }
    }
}
