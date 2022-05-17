using QuanLyKhoHang.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.BussinessLogicLayer
{
    class BLLayer_NhaCungCap
    {
        private Team06Entities team06 = new Team06Entities();
        private static BLLayer_NhaCungCap _instance;
        public static BLLayer_NhaCungCap instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLLayer_NhaCungCap();
                }
                return _instance;
            }
            private set { }
        }
        private BLLayer_NhaCungCap() { }
        // Kiem tra ton tai ten nha cung cap
        public bool isTonTaiTenNhaCungCap(string tenNhaCungCap)
        {
            var nhaCungCap = team06.NHACUNGCAPs.Where(p => p.TENNHACUNGCAP == tenNhaCungCap).SingleOrDefault();
            if (nhaCungCap == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Kiem tra ton tai ma nha cung cap
        public bool isTonTaiMaNhaCungCap(string maNhaCungCap)
        {
            var nhaCungCap = team06.NHACUNGCAPs.Find(maNhaCungCap);
            if (nhaCungCap == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Them nha cung cap
        public void ThemNhaCungCap(string maNhaCungCap, string tenNhaCungCap, string diaChi, string soDienThoai)
        {
            NHACUNGCAP nhaCungCap = new NHACUNGCAP();
            nhaCungCap.MANHACUNGCAP = maNhaCungCap;
            nhaCungCap.TENNHACUNGCAP = tenNhaCungCap;
            nhaCungCap.DIACHI = diaChi;
            nhaCungCap.SODIENTHOAI = soDienThoai;
            team06.NHACUNGCAPs.Add(nhaCungCap);
            team06.SaveChanges();
        }
        // Tra ve ten nha cung cap theo ma nha cung cap
        public string tenNhaCungCap(string maNhaCungCap)
        {
            var nhaCungCap = team06.NHACUNGCAPs.Find(maNhaCungCap);
            return nhaCungCap.TENNHACUNGCAP;
        }
        // Tra ve dia chi nha cung cap
        public string diaChiNhaCungCap(string maNhaCungCap)
        {
            var nhaCungCap = team06.NHACUNGCAPs.Find(maNhaCungCap);
            return nhaCungCap.DIACHI;
        }
        // Tra ve so dien thoai nha cung cap
        public string soDienThoaiNhaCungCap(string maNhaCungCap)
        {
            var nhaCungCap = team06.NHACUNGCAPs.Find(maNhaCungCap);
            return nhaCungCap.SODIENTHOAI;
        }
        // combobox nha cung cap
        public List<ComboboxItem> comboboxNhaCungCap()
        {
            List<ComboboxItem> listNhaCungCap = new List<ComboboxItem>();
            foreach(NHACUNGCAP nhaCungCap in team06.NHACUNGCAPs)
            {
                listNhaCungCap.Add(new ComboboxItem { Ma = nhaCungCap.MANHACUNGCAP, Ten = nhaCungCap.TENNHACUNGCAP});
            }
            return listNhaCungCap;
        }
    }
}
