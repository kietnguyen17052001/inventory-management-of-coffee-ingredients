using QuanLyKhoHang.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.BussinessLogicLayer
{
    class BLLayer_BangKiemKe
    {
        private Team06Entities team06 = new Team06Entities();
        private static BLLayer_BangKiemKe _instance;
        public static BLLayer_BangKiemKe instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLLayer_BangKiemKe();
                }
                return _instance;
            }
            private set { }
        }
        private BLLayer_BangKiemKe() { }
        // Du lieu bang kiem ke
        public void DuLieuBangKiemKe(DataGridView dataGV)
        {
            var bangKiemKe = team06.BANGKIEMKEs.Select(p => new { 
                p.MAKIEMKE,
                p.NGUYENLIEU.TENNGUYENLIEU,
                p.LUONGTONKHO,
                p.KIEMTHUCONG,
                p.LUONGTHIEUHUT
            });
            dataGV.DataSource = bangKiemKe.ToList();
        }
        // Them kiem ke
        public void ThemKiemKe(string maNguyenLieu, int luongTonKho)
        {
            BANGKIEMKE kiemKe = new BANGKIEMKE();
            kiemKe.MAKIEMKE = maKiemKeTuTao();
            kiemKe.MANGUYENLIEU = maNguyenLieu;
            kiemKe.LUONGTONKHO = kiemKe.KIEMTHUCONG = luongTonKho;
            kiemKe.LUONGTHIEUHUT = 0;
            team06.BANGKIEMKEs.Add(kiemKe);
            team06.SaveChanges();
        }
        // Sua kiem ke theo so luong kiem thu cong
        public void SuaKiemKeTheoKiemThuCong(string maKiemKe, int kiemThuCong)
        {
            var kiemKe = team06.BANGKIEMKEs.Find(maKiemKe);
            kiemKe.KIEMTHUCONG = kiemThuCong;
            kiemKe.LUONGTHIEUHUT = kiemKe.LUONGTONKHO - kiemThuCong;
            team06.SaveChanges();
        }
        // Sua kiem ke theo so luong ton kho
        public void SuaKiemKeTheoSoLuongNguyenLieu(string maKiemKe, int soLuongNguyenLieu)
        {
            var kiemKe = team06.BANGKIEMKEs.Find(maKiemKe);
            kiemKe.LUONGTONKHO = soLuongNguyenLieu;
            kiemKe.KIEMTHUCONG = soLuongNguyenLieu - kiemKe.LUONGTHIEUHUT;
            team06.SaveChanges();
        }
        // Tim kiem kiem ke
        public void TimKiemKiemKe(DataGridView dataGV, string thongTinTimKiem)
        {
            if(String.IsNullOrEmpty(thongTinTimKiem) || (thongTinTimKiem == "Nhập mã kiểm kê hoặc nguyên liệu"))
            {
                DuLieuBangKiemKe(dataGV);
            }
            else
            {
                var kiemKe = team06.BANGKIEMKEs.Where(p => p.MAKIEMKE.Contains(thongTinTimKiem) || p.NGUYENLIEU.TENNGUYENLIEU.Contains(thongTinTimKiem)).
                    Select(p => new {
                        p.MAKIEMKE,
                        p.NGUYENLIEU.TENNGUYENLIEU,
                        p.LUONGTONKHO,
                        p.KIEMTHUCONG,
                        p.LUONGTHIEUHUT
                    });
                dataGV.DataSource = kiemKe.ToList();
            }
        }
        // Kiem tra xem co nguyen lieu trong bang kiem ke hay khong
        public bool isCoNguyenLieuTrongBangKiemKe(string maNguyenLieu)
        {
            var nguyenLieu = team06.BANGKIEMKEs.Where(p => p.MANGUYENLIEU == maNguyenLieu).SingleOrDefault();
            if(nguyenLieu == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Luong ton kho cua nguyen lieu
        public int luongTonKhoNguyenLieu(string maNguyenLieu)
        {
            var nguyenLieu = team06.BANGKIEMKEs.Where(p => p.MANGUYENLIEU == maNguyenLieu).SingleOrDefault();
            if(nguyenLieu.LUONGTONKHO > 0)
            {
                return (int)nguyenLieu.LUONGTONKHO;
            }
            else
            {
                return 0;
            }
        }
        // Tu tao ma kiem ke
        public string maKiemKeTuTao()
        {
            string maKiemKe = null;
            int index;
            List<BANGKIEMKE> listKiemKe = team06.BANGKIEMKEs.ToList();
            if(listKiemKe.Count == 0)
            {
                maKiemKe = "KK0001";
            }
            else
            {
                index = Convert.ToInt32(listKiemKe[listKiemKe.Count - 1].MAKIEMKE.Remove(0, 2));
                if(index + 1 < 10)
                {
                    maKiemKe = "KK000" + (index + 1).ToString();
                }
                else if(index + 1 < 100)
                {
                    maKiemKe = "KK00" + (index + 1).ToString();
                }
                else if(index + 1 < 1000)
                {
                    maKiemKe = "KK0" + (index + 1).ToString();
                }
                else
                {
                    maKiemKe = "KK" + (index + 1).ToString();
                }
            }
            return maKiemKe;
        }
    }
}
