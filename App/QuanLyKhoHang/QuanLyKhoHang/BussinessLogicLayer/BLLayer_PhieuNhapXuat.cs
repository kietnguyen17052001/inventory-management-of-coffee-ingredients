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
    class BLLayer_PhieuNhapXuat
    {
        private Team06Entities team06 = new Team06Entities();
        private static BLLayer_PhieuNhapXuat _instance;
        public static BLLayer_PhieuNhapXuat instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLLayer_PhieuNhapXuat();
                }
                return _instance;
            }
            private set { }
        }
        private BLLayer_PhieuNhapXuat() { }
        // Kiem tra ton tai ma phieu
        public bool isTonTaiMaPhieu(string maPhieu)
        {
            var phieuNhapXuat = team06.PHIEUNHAPKHO_XUATKHO.Find(maPhieu);
            if(phieuNhapXuat == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Bang phieu thong tin
        public DataTable BangPhieuThongTin()
        {
            DataTable bangDuLieu = new DataTable();
            bangDuLieu.Columns.AddRange(new DataColumn[] {
                new DataColumn("Mã nguyên liệu",typeof(string)),
                new DataColumn("Tên nguyên liệu", typeof(string)),
                new DataColumn("Số Lượng", typeof(int)),
            });
            return bangDuLieu;
        }
        // Du lieu nguyen lieu
        public void DuLieuNguyenLieu(DataGridView dataGV)
        {
            var nguyenLieu = team06.NGUYENLIEUx.Select(p => new
            {
                p.MANGUYENLIEU,
                p.TENNGUYENLIEU,
                p.NHACUNGCAP.TENNHACUNGCAP,
                p.DONVITINH
            });
            dataGV.DataSource = nguyenLieu.ToList();
        }
        // Tim kiem nguyen lieu
        public void TimKiemNguyenLieu(DataGridView dataGV, string thongTinTimKiem)
        {
            if(String.IsNullOrEmpty(thongTinTimKiem) || (thongTinTimKiem == "Nhập mã hoặc tên nguyên liệu"))
            {
                DuLieuNguyenLieu(dataGV);
            }
            else
            {
                var nguyenLieu = team06.NGUYENLIEUx.Where(p => p.MANGUYENLIEU.Contains(thongTinTimKiem)
                || p.TENNGUYENLIEU.Contains(thongTinTimKiem)).Select(p => new
                {
                    p.MANGUYENLIEU,
                    p.TENNGUYENLIEU,
                    p.NHACUNGCAP.TENNHACUNGCAP,
                    p.DONVITINH
                });
                dataGV.DataSource = nguyenLieu.ToList();
            }
        }
        // Kiem tra so luong nhap them vao co phu hop voi so luong trong kho hay khong
        public bool isPhuHopSoLuongNguyenLieu(DataTable bangDuLieu, string maNguyenLieu, int soLuongThem)
        {
            bool isPhuHopSoLuong = true;
            foreach(DataRow hangDuLieu in bangDuLieu.Rows)
            {
                if(hangDuLieu["Mã nguyên liệu"].ToString() == maNguyenLieu)
                {
                    if(soLuongThem + Convert.ToInt32(hangDuLieu["Số lượng"].ToString()) > BussinessLogicLayer.BLLayer_BangKiemKe.instance.luongTonKhoNguyenLieu(maNguyenLieu)) {
                        isPhuHopSoLuong = false;
                        break;
                    }
                }
            }
            return isPhuHopSoLuong;
        }
        // Them so luong
        public void ThemSoLuongNguyenLieu(DataTable bangDuLieu, int soLuongThem, string maNguyenLieu, string tenNguyenLieu)
        {
            bool isDaCoNguyenLieuTrongBangDuLieu = false;
            foreach(DataRow hangDuLieu in bangDuLieu.Rows)
            {
                if(hangDuLieu["Mã nguyên liệu"].ToString() == maNguyenLieu)
                {
                    isDaCoNguyenLieuTrongBangDuLieu = true;
                    hangDuLieu["Số lượng"] = (Convert.ToInt32(hangDuLieu["Số lượng"].ToString()) + soLuongThem).ToString();
                }
            }
            if (isDaCoNguyenLieuTrongBangDuLieu == false)
            {
                bangDuLieu.Rows.Add(maNguyenLieu, tenNguyenLieu, soLuongThem);
            }
        }
        // Giam so luong
        public void GiamSoLuongNguyenLieu(DataTable bangDuLieu, int soLuongGiam, string maNguyenLieu)
        {
            try
            {
                foreach (DataRow hangDuLieu in bangDuLieu.Rows)
                {
                    if (hangDuLieu["Mã nguyên liệu"].ToString() == maNguyenLieu)
                    {
                        if (Convert.ToInt32(hangDuLieu["Số lượng"].ToString()) == soLuongGiam)
                        {
                            bangDuLieu.Rows.Remove(hangDuLieu);
                        }
                        else
                        {
                            hangDuLieu["Số lượng"] = (Convert.ToInt32(hangDuLieu["Số lượng"].ToString()) - soLuongGiam).ToString();
                        }
                    }
                }
                bangDuLieu.AcceptChanges();
            }
            catch (Exception){}
        }
        // Chuyen dataRow trong DataTable thanh CHITIETPHIEU
        public CHITIETPHIEUNHAP chiTietPhieuNhap(DataRow duLieu, string maPhieuNhap)
        {
            return new CHITIETPHIEUNHAP
            {
                MAPHIEU = maPhieuNhap,
                MANGUYENLIEU = duLieu["Mã nguyên liệu"].ToString(),
                SOLUONG = Convert.ToInt32(duLieu["Số lượng"].ToString())
            };
        }
        public CHITIETPHIEUXUAT chiTietPhieuXuat(DataRow duLieu, string maPhieuNhap)
        {
            return new CHITIETPHIEUXUAT
            {
                MAPHIEU = maPhieuNhap,
                MANGUYENLIEU = duLieu["Mã nguyên liệu"].ToString(),
                SOLUONG = Convert.ToInt32(duLieu["Số lượng"].ToString())
            };
        }
        // Luu phieu
        public void LuuPhieu(bool isPhieuNhap, string maPhieu, string maNhanVien, DateTime ngayLapPhieu, DataTable bangDuLieu)
        {
            int soLuongNguyenLieu;
            string maNguyenLieu;
            PHIEUNHAPKHO_XUATKHO phieuNhapXuatNguyenLieu = new PHIEUNHAPKHO_XUATKHO();
            phieuNhapXuatNguyenLieu.MAPHIEU = maPhieu;
            phieuNhapXuatNguyenLieu.MANHANVIEN = maNhanVien;
            phieuNhapXuatNguyenLieu.NGAYLAP = ngayLapPhieu;
            BANGKIEMKE bangKiemKe = new BANGKIEMKE();
            if (isPhieuNhap == true) // Phieu nhap
            {
                // luu phieu nhap va chi tiet phieu nhap nguyen lieu
                phieuNhapXuatNguyenLieu.LOAIDON = true; // true => nhap nguyen lieu
                team06.PHIEUNHAPKHO_XUATKHO.Add(phieuNhapXuatNguyenLieu);
                team06.SaveChanges();
                // luu chi tiet phieu nhap
                foreach(DataRow hangDuLieu in bangDuLieu.Rows)
                {
                    team06.CHITIETPHIEUNHAPs.Add(chiTietPhieuNhap(hangDuLieu, maPhieu));
                    team06.SaveChanges();
                    // Kiem tra nguyen lieu da co trong bang kiem ke hay chua
                    maNguyenLieu = hangDuLieu["Mã nguyên liệu"].ToString();
                    bangKiemKe = team06.BANGKIEMKEs.Where(p => p.MANGUYENLIEU == maNguyenLieu).SingleOrDefault();
                    if (bangKiemKe == null) // chưa tồn tại kiểm kê nào => thêm kiểm kê vào bảng kiểm kê
                    {
                        soLuongNguyenLieu = Convert.ToInt32(hangDuLieu["Số lượng"].ToString());
                        BLLayer_BangKiemKe.instance.ThemKiemKe(maNguyenLieu, soLuongNguyenLieu);
                    }
                    else // đã tồn tại kiểm kê => sửa thông tin kiểm kê
                    {
                        soLuongNguyenLieu = (int)bangKiemKe.LUONGTONKHO + Convert.ToInt32(hangDuLieu["Số lượng"].ToString());
                        BLLayer_BangKiemKe.instance.SuaKiemKeTheoSoLuongNguyenLieu(bangKiemKe.MAKIEMKE, soLuongNguyenLieu);
                    }
                }
            }
            else // Phieu xuat
            {
                phieuNhapXuatNguyenLieu.LOAIDON = false; // false => xuat nguyen lieu
                team06.PHIEUNHAPKHO_XUATKHO.Add(phieuNhapXuatNguyenLieu);
                team06.SaveChanges();
                // luu chi tiet phieu xuat
                foreach (DataRow hangDuLieu in bangDuLieu.Rows)
                {
                    team06.CHITIETPHIEUXUATs.Add(chiTietPhieuXuat(hangDuLieu, maPhieu));
                    team06.SaveChanges();
                    maNguyenLieu = hangDuLieu["Mã nguyên liệu"].ToString();
                    bangKiemKe = team06.BANGKIEMKEs.Where(p => p.MANGUYENLIEU == maNguyenLieu).SingleOrDefault();
                    soLuongNguyenLieu = (int)bangKiemKe.LUONGTONKHO - Convert.ToInt32(hangDuLieu["Số lượng"].ToString());
                    BLLayer_BangKiemKe.instance.SuaKiemKeTheoSoLuongNguyenLieu(bangKiemKe.MAKIEMKE, soLuongNguyenLieu);
                }
            }
        }
        // Tong so luong nguyen lieu
        public int tongSoLuongNguyenLieu(DataTable bangDuLieu)
        {
            int tongSoLuong = 0;
            foreach(DataRow hangDuLieu in bangDuLieu.Rows)
            {
                tongSoLuong += Convert.ToInt32(hangDuLieu["Số lượng"].ToString());
            }
            return tongSoLuong;
        }
        // Kiem tra xem nguyen lieu co cung nha cung cap hay khong
        public bool isCungNhaCungCap(string nhaCungCap, DataTable bangDuLieu)
        {
            bool cungNhaCungCap = true; // true => nguyen lieu duoc nhap vao bang du lieu co cung nha cung cap voi nguyen lieu trong bang du lieu
            NGUYENLIEU nguyenLieuTrongBangDuLieu = new NGUYENLIEU();
            if (bangDuLieu.Rows.Count == 0)
            {
                cungNhaCungCap = true;
            }
            else
            {
                foreach (DataRow hangDuLieu in bangDuLieu.Rows)
                {
                    nguyenLieuTrongBangDuLieu = team06.NGUYENLIEUx.Find(hangDuLieu["Mã nguyên liệu"].ToString());
                    if (nguyenLieuTrongBangDuLieu.NHACUNGCAP.TENNHACUNGCAP != nhaCungCap)
                    {
                        cungNhaCungCap = false;
                        break;
                    }
                }
            }
            return cungNhaCungCap;
        }
    }
}
