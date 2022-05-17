using QuanLyKhoHang.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.BussinessLogicLayer
{
    class BLLayer_NguyenLieu
    {
        private Team06Entities team06 = new Team06Entities();
        private static BLLayer_NguyenLieu _instance;
        public static BLLayer_NguyenLieu instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLLayer_NguyenLieu();
                }
                return _instance;
            }
            private set { }
        }
        private BLLayer_NguyenLieu() { }
        // Kiem tra ton tai ten nguyen lieu
        public bool isTonTaiTenNguyenLieu(string tenNguyenLieu)
        {
            var nguyenLieu = team06.NGUYENLIEUx.Where(p => p.TENNGUYENLIEU.Contains(tenNguyenLieu) || tenNguyenLieu.Contains(p.TENNGUYENLIEU)).SingleOrDefault();
            if (nguyenLieu == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Kiem tra ton tai ma nguyen lieu
        public bool isTonTaiMaNguyenLieu(string maNguyenLieu)
        {
            var nguyenLieu = team06.NGUYENLIEUx.Find(maNguyenLieu);
            if(nguyenLieu == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Du lieu nguyen lieu trong database
        public void DuLieuNguyenLieu(DataGridView dataGV)
        {
            var nguyenLieu = team06.NGUYENLIEUx.Select(p => new
            {
                p.MANGUYENLIEU,
                p.TENNGUYENLIEU,
                p.NHACUNGCAP.TENNHACUNGCAP,
                p.KHO.TENKHO,
                p.DONVITINH
            });
            dataGV.DataSource = nguyenLieu.ToList();
        }
        // Them nguyen lieu
        public void ThemNguyenLieu(string maNguyenLieu, string tenNguyenLieu, string donViTinh, string maNhaCungCap, string maKho)
        {
            NGUYENLIEU nguyenLieu = new NGUYENLIEU();
            nguyenLieu.MANGUYENLIEU = maNguyenLieu;
            nguyenLieu.TENNGUYENLIEU = tenNguyenLieu;
            nguyenLieu.DONVITINH = donViTinh;
            nguyenLieu.MANHACUNGCAP = maNhaCungCap;
            nguyenLieu.MAKHO = maKho;
            team06.NGUYENLIEUx.Add(nguyenLieu);
            team06.SaveChanges();
        }
        // Sua nguyen lieu
        public void SuaNguyenLieu(string maNguyenLieu, string tenNguyenLieu, string donViTinh, string maNhaCungCap, string maKho)
        {
            var nguyenLieu = team06.NGUYENLIEUx.Find(maNguyenLieu);
            nguyenLieu.TENNGUYENLIEU = tenNguyenLieu;
            nguyenLieu.DONVITINH = donViTinh;
            nguyenLieu.MANHACUNGCAP = maNhaCungCap;
            nguyenLieu.MAKHO = maKho;
            team06.SaveChanges();
        }
        // Xoa nguyen lieu
        public void XoaNguyenLieu(List<string> listMaNguyenLieu)
        {
            NGUYENLIEU nguyenLieu = new NGUYENLIEU();
            foreach(string maNguyenLieu in listMaNguyenLieu)
            {
                nguyenLieu = team06.NGUYENLIEUx.Find(maNguyenLieu);
                team06.NGUYENLIEUx.Remove(nguyenLieu);
                team06.SaveChanges();
            }
        }
        // Tim kiem nguyen lieu
        public void TimKiemNguyenLieu(DataGridView dataGV, string thongTinTimKiem)
        {
            if (String.IsNullOrEmpty(thongTinTimKiem) || (thongTinTimKiem == "Nhập mã, tên nguyên liệu hoặc kho hàng, nhà cung cấp"))
            {
                DuLieuNguyenLieu(dataGV);
            }
            else
            {
                var nguyenLieu = team06.NGUYENLIEUx.Where(p => p.MANGUYENLIEU.Contains(thongTinTimKiem)
                || p.TENNGUYENLIEU.Contains(thongTinTimKiem) || p.NHACUNGCAP.TENNHACUNGCAP.Contains(thongTinTimKiem)).Select(p => new
                {
                    p.MANGUYENLIEU,
                    p.TENNGUYENLIEU,
                    p.NHACUNGCAP.TENNHACUNGCAP,
                    p.KHO.TENKHO,
                    p.DONVITINH
                });
                dataGV.DataSource = nguyenLieu.ToList();
            }
        }
    }
}
