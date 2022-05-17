using QuanLyKhoHang.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.BussinessLogicLayer
{
    class BLLayer_ThongKe
    {
        private Team06Entities team06 = new Team06Entities();
        private static BLLayer_ThongKe _instance;
        public static BLLayer_ThongKe instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new BLLayer_ThongKe();
                }
                return _instance;
            }
            private set { }
        }
        private BLLayer_ThongKe() { }
        // So luong nhap cua nguyen lieu theo thoi gian
        public int SoLuongNhapCuaNguyenLieu(bool isDuLieuTheoThang, string maNguyenLieu, int thang, int nam)
        {
            IQueryable<CHITIETPHIEUNHAP> chiTietPhieuNhap = null;
            if (isDuLieuTheoThang)
            {
                chiTietPhieuNhap = team06.CHITIETPHIEUNHAPs.Where(p => p.PHIEUNHAPKHO_XUATKHO.NGAYLAP.Month == thang
                && p.PHIEUNHAPKHO_XUATKHO.NGAYLAP.Year == nam
                && p.MANGUYENLIEU == maNguyenLieu);
            }
            else
            {
                chiTietPhieuNhap = team06.CHITIETPHIEUNHAPs.Where(p => p.PHIEUNHAPKHO_XUATKHO.NGAYLAP.Year == nam
                   && p.MANGUYENLIEU == maNguyenLieu);
            }
            int soLuong = 0;
            foreach (CHITIETPHIEUNHAP _chiTietPhieuNhap in chiTietPhieuNhap)
            {
                soLuong += (int)_chiTietPhieuNhap.SOLUONG;
            }
            return soLuong;
        }
        // So luong xuat cua nguyen lieu theo thoi gian
        public int SoLuongXuatCuaNguyenLieu(bool isDuLieuTheoThang, string maNguyenLieu, int thang, int nam)
        {
            IQueryable<CHITIETPHIEUXUAT> chiTietPhieuXuat = null;
            if (isDuLieuTheoThang)
            {
                chiTietPhieuXuat = team06.CHITIETPHIEUXUATs.Where(p => p.PHIEUNHAPKHO_XUATKHO.NGAYLAP.Month == thang
                && p.PHIEUNHAPKHO_XUATKHO.NGAYLAP.Year == nam
                && p.MANGUYENLIEU == maNguyenLieu);
            }
            else
            {
                chiTietPhieuXuat = team06.CHITIETPHIEUXUATs.Where(p => p.PHIEUNHAPKHO_XUATKHO.NGAYLAP.Year == nam
                && p.MANGUYENLIEU == maNguyenLieu);
            }
            int soLuong = 0;
            foreach (CHITIETPHIEUXUAT _chiTietPhieuXuat in chiTietPhieuXuat)
            {
                soLuong += (int)_chiTietPhieuXuat.SOLUONG;
            }
            return soLuong;
        }
        public int SoLuongTonKhoCuaNguyenLieu(bool isDuLieuTheoThang, string maNguyenLieu, int thang, int nam)
        {
            int soLuongTonKhoCuaNguyenLieu;
            if (isDuLieuTheoThang)
            {
                var chiTietNhapNguyenLieu = team06.CHITIETPHIEUNHAPs.Where(p => (p.MANGUYENLIEU == maNguyenLieu
                && p.PHIEUNHAPKHO_XUATKHO.NGAYLAP.Year < nam) || (p.MANGUYENLIEU == maNguyenLieu
                && p.PHIEUNHAPKHO_XUATKHO.NGAYLAP.Year == nam && p.PHIEUNHAPKHO_XUATKHO.NGAYLAP.Month <= thang));
                if (chiTietNhapNguyenLieu == null)
                { // Kiem tra xem co don nhap hang nao phu hop voi thoi gian thang, nam hay khong
                    soLuongTonKhoCuaNguyenLieu = 0;
                }
                else
                {
                    int soLuongNhap = 0;
                    int soLuongXuat = 0;
                    var chiTietXuatNguyenLieu = team06.CHITIETPHIEUXUATs.Where(p => p.MANGUYENLIEU == maNguyenLieu
                    && p.PHIEUNHAPKHO_XUATKHO.NGAYLAP.Year == nam && p.PHIEUNHAPKHO_XUATKHO.NGAYLAP.Month == thang);
                    foreach (CHITIETPHIEUNHAP _chiTietPhieuNhap in chiTietNhapNguyenLieu)
                    {
                        soLuongNhap += (int)_chiTietPhieuNhap.SOLUONG;
                    }
                    foreach (CHITIETPHIEUXUAT _chiTietPhieuXuat in chiTietXuatNguyenLieu)
                    {
                        soLuongXuat += (int)_chiTietPhieuXuat.SOLUONG;
                    }
                    soLuongTonKhoCuaNguyenLieu = soLuongNhap - soLuongXuat;
                }
            }
            else
            { 
                var chiTietNhapNguyenLieu = team06.CHITIETPHIEUNHAPs.Where(p => p.MANGUYENLIEU == maNguyenLieu
                && p.PHIEUNHAPKHO_XUATKHO.NGAYLAP.Year <= nam);
                if (chiTietNhapNguyenLieu == null)
                { // Kiem tra xem co don nhap hang nao phu hop voi thoi gian thang, nam hay khong
                    soLuongTonKhoCuaNguyenLieu = 0;
                }
                else
                {
                    int soLuongNhap = 0;
                    int soLuongXuat = 0;
                    var chiTietXuatNguyenLieu = team06.CHITIETPHIEUXUATs.Where(p => p.MANGUYENLIEU == maNguyenLieu
                    && p.PHIEUNHAPKHO_XUATKHO.NGAYLAP.Year == nam);
                    foreach (CHITIETPHIEUNHAP _chiTietPhieuNhap in chiTietNhapNguyenLieu)
                    {
                        soLuongNhap += (int)_chiTietPhieuNhap.SOLUONG;
                    }
                    foreach (CHITIETPHIEUXUAT _chiTietPhieuXuat in chiTietXuatNguyenLieu)
                    {
                        soLuongXuat += (int)_chiTietPhieuXuat.SOLUONG;
                    }
                    soLuongTonKhoCuaNguyenLieu = soLuongNhap - soLuongXuat;
                }
            }
            return soLuongTonKhoCuaNguyenLieu;
        }
        // Du lieu thong ke(so luong nhap, so luong xuat, so ton kho) cua nguyen lieu theo thoi gian 
        public void DuLieuThongKe(bool isDuLieuTheoThang, DataGridView dataGV, int thang, int nam)
        {
            if (isDuLieuTheoThang) // Du lieu theo thang
            {
                var nguyenLieu = team06.NGUYENLIEUx.AsEnumerable().Select(p => new {
                    p.MANGUYENLIEU,
                    p.TENNGUYENLIEU,
                    p.NHACUNGCAP.TENNHACUNGCAP,
                    SOLUONGNHAP = SoLuongNhapCuaNguyenLieu(true, p.MANGUYENLIEU, thang, nam),
                    SOLUONGXUAT = SoLuongXuatCuaNguyenLieu(true, p.MANGUYENLIEU, thang, nam),
                    TONKHO = SoLuongTonKhoCuaNguyenLieu(isDuLieuTheoThang, p.MANGUYENLIEU, thang, nam),
                    p.DONVITINH
                });
                dataGV.DataSource = nguyenLieu.ToList();
            }
            else // Du lieu theo nam 
            {
                var nguyenLieu = team06.NGUYENLIEUx.AsEnumerable().Select(p => new {
                    p.MANGUYENLIEU,
                    p.TENNGUYENLIEU,
                    p.NHACUNGCAP.TENNHACUNGCAP,
                    SOLUONGNHAP = SoLuongNhapCuaNguyenLieu(false, p.MANGUYENLIEU, thang, nam),
                    SOLUONGXUAT = SoLuongXuatCuaNguyenLieu(false, p.MANGUYENLIEU, thang, nam),
                    TONKHO = SoLuongTonKhoCuaNguyenLieu(isDuLieuTheoThang, p.MANGUYENLIEU, thang, nam),
                    p.DONVITINH
                });
                dataGV.DataSource = nguyenLieu.ToList();
            }
        }
    }
}
