using QuanLyKhoHang.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.BussinessLogicLayer
{
    class BLLayer_DanhSachPhieuNhapXuat
    {
        private Team06Entities team06 = new Team06Entities();
        private static BLLayer_DanhSachPhieuNhapXuat _instance;
        public static BLLayer_DanhSachPhieuNhapXuat instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLLayer_DanhSachPhieuNhapXuat();
                }
                return _instance;
            }
            private set { }
        }
        private BLLayer_DanhSachPhieuNhapXuat() { }
        // Du lieu phieu
        public void DuLieuPhieu(DataGridView dataGV, bool isDanhSachPhieuNhap)
        {
            if (isDanhSachPhieuNhap) // danh sach phieu nhap nguyen lieu
            {
                var danhSachPhieu = team06.PHIEUNHAPKHO_XUATKHO.Where(p => p.LOAIDON == true).Select(p => new
                {
                    p.MAPHIEU,
                    p.NGAYLAP,
                    p.NGUOIDUNG.TENNHANVIEN
                });
                dataGV.DataSource = danhSachPhieu.ToList();
            }
            else // danh sach phieu xuat nguyen lieu
            {
                var danhSachPhieu = team06.PHIEUNHAPKHO_XUATKHO.Where(p => p.LOAIDON == false).Select(p => new
                {
                    p.MAPHIEU,
                    p.NGAYLAP,
                    p.NGUOIDUNG.TENNHANVIEN
                });
                dataGV.DataSource = danhSachPhieu.ToList();
            }
        }
        // Sua phieu
        public void SuaPhieu(string maPhieu, string maNhanVien, DateTime ngayLapPhieu)
        {
            var phieuNhapXuat = team06.PHIEUNHAPKHO_XUATKHO.Find(maPhieu);
            phieuNhapXuat.MANHANVIEN = maNhanVien;
            phieuNhapXuat.NGAYLAP = ngayLapPhieu;
            team06.SaveChanges();
        }
        // Xoa phieu
        public void XoaPhieu(bool isPhieuNhap, List<string> danhSachMaPhieu)
        {
            PHIEUNHAPKHO_XUATKHO phieuNhapXuat = new PHIEUNHAPKHO_XUATKHO();
            BANGKIEMKE bangKiemKe = new BANGKIEMKE();
            foreach(string maPhieu in danhSachMaPhieu)
            {
                phieuNhapXuat = team06.PHIEUNHAPKHO_XUATKHO.Find(maPhieu);
                if (isPhieuNhap)
                {
                    foreach (CHITIETPHIEUNHAP chiTietPhieuNhap in team06.CHITIETPHIEUNHAPs.Where(p => p.MAPHIEU == maPhieu).ToList())
                    {
                        bangKiemKe = team06.BANGKIEMKEs.Where(p => p.MANGUYENLIEU == chiTietPhieuNhap.MANGUYENLIEU).SingleOrDefault();
                        bangKiemKe.KIEMTHUCONG = bangKiemKe.LUONGTONKHO -= chiTietPhieuNhap.SOLUONG;
                        team06.CHITIETPHIEUNHAPs.Remove(chiTietPhieuNhap);
                    }
                }
                else
                {
                    foreach (CHITIETPHIEUXUAT chiTietPhieuXuat in team06.CHITIETPHIEUXUATs.Where(p => p.MAPHIEU == maPhieu).ToList())
                    {
                        bangKiemKe = team06.BANGKIEMKEs.Where(p => p.MANGUYENLIEU == chiTietPhieuXuat.MANGUYENLIEU).SingleOrDefault();
                        bangKiemKe.KIEMTHUCONG = bangKiemKe.LUONGTONKHO += chiTietPhieuXuat.SOLUONG;
                        team06.CHITIETPHIEUXUATs.Remove(chiTietPhieuXuat);
                    }
                }
                team06.PHIEUNHAPKHO_XUATKHO.Remove(phieuNhapXuat);
                team06.SaveChanges();
            }
        }
        // Tim kiem phieu
        public void TimKiemPhieu(DataGridView dataGV, bool isDanhSachPhieuNhap, bool isTimTheoMaVaTen, string thongTinTimKiem, DateTime ngayLapPhieu)
        {
            DateTime formatNgayLapPhieu = Convert.ToDateTime(ngayLapPhieu.ToShortDateString());
            if (isDanhSachPhieuNhap) // tim kiem danh sach phieu nhap nguyen lieu
            {
                if (isTimTheoMaVaTen) // tim kiem theo ma phieu va ten nhan vien
                {
                    if(String.IsNullOrEmpty(thongTinTimKiem) || (thongTinTimKiem == "Nhập mã đơn hoặc tên nhân viên"))
                    {
                        DuLieuPhieu(dataGV, isDanhSachPhieuNhap);
                    }
                    else
                    {
                        var danhSachPhieu = team06.PHIEUNHAPKHO_XUATKHO.Where(p => p.MAPHIEU.Contains(thongTinTimKiem)
                        || p.NGUOIDUNG.TENNHANVIEN.Contains(thongTinTimKiem) && p.LOAIDON == isDanhSachPhieuNhap).Select(p => new
                        {
                            p.MAPHIEU,
                            p.NGAYLAP,
                            p.NGUOIDUNG.TENNHANVIEN
                        });
                        dataGV.DataSource = danhSachPhieu.ToList();
                    }
                }
                else // tim kiem theo ngay lap phieu
                {
                    var danhSachPhieu = team06.PHIEUNHAPKHO_XUATKHO.Where(p => p.NGAYLAP == formatNgayLapPhieu && p.LOAIDON == isDanhSachPhieuNhap).Select(p => new
                    {
                        p.MAPHIEU,
                        p.NGAYLAP,
                        p.NGUOIDUNG.TENNHANVIEN
                    });
                    dataGV.DataSource = danhSachPhieu.ToList();
                }
            }
            else // tim kiem theo danh sach phieu xuat nguyen lieu
            {
                if (isTimTheoMaVaTen) // tim kiem theo ma phieu va ten nhan vien
                {
                    if (String.IsNullOrEmpty(thongTinTimKiem) || (thongTinTimKiem == "Nhập mã đơn hoặc tên nhân viên"))
                    {
                        DuLieuPhieu(dataGV, isDanhSachPhieuNhap);
                    }
                    else
                    {
                        var danhSachPhieu = team06.PHIEUNHAPKHO_XUATKHO.Where(p => p.MAPHIEU.Contains(thongTinTimKiem)
                        || p.NGUOIDUNG.TENNHANVIEN.Contains(thongTinTimKiem) && p.LOAIDON == isDanhSachPhieuNhap).Select(p => new
                        {
                            p.MAPHIEU,
                            p.NGAYLAP,
                            p.NGUOIDUNG.TENNHANVIEN
                        });
                        dataGV.DataSource = danhSachPhieu.ToList();
                    }
                }
                else // tim kiem theo ngay lap phieu
                {
                    var danhSachPhieu = team06.PHIEUNHAPKHO_XUATKHO.Where(p => p.NGAYLAP == formatNgayLapPhieu && p.LOAIDON == isDanhSachPhieuNhap).Select(p => new
                    {
                        p.MAPHIEU,
                        p.NGAYLAP,
                        p.NGUOIDUNG.TENNHANVIEN
                    });
                    dataGV.DataSource = danhSachPhieu.ToList();
                }
            }
        }
        // Chi tiet phieu 
        public void ChiTietPhieu(bool isPhieuNhap, DataGridView dataGV, string maPhieu)
        {
            if (isPhieuNhap)
            {
                var chiTietPhieuNhap = team06.CHITIETPHIEUNHAPs.Where(p => p.MAPHIEU == maPhieu).Select(p => new
                {
                    p.NGUYENLIEU.TENNGUYENLIEU,
                    p.SOLUONG,
                    p.NGUYENLIEU.NHACUNGCAP.TENNHACUNGCAP
                });
                dataGV.DataSource = chiTietPhieuNhap.ToList();
            }
            else
            {
                var chiTietPhieuXuat = team06.CHITIETPHIEUXUATs.Where(p => p.MAPHIEU == maPhieu).Select(p => new
                {
                    p.NGUYENLIEU.TENNGUYENLIEU,
                    p.SOLUONG,
                    p.NGUYENLIEU.NHACUNGCAP.TENNHACUNGCAP
                });
                dataGV.DataSource = chiTietPhieuXuat.ToList();
            }
        }
    }
}
