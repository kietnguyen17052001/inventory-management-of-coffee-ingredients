using QuanLyKhoHang.Entity;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.BussinessLogicLayer
{
    class BLLayer_Kho
    {
        private Team06Entities team06 = new Team06Entities();
        private static BLLayer_Kho _instance;
        public static BLLayer_Kho instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLLayer_Kho();
                }
                return _instance;
            }
            private set { }
        }
        private BLLayer_Kho() { }
        // Kiem tra ton tai ten kho nguyen lieu
        public bool isTonTaiTenKhoNguyenLieu(string tenKho)
        {
            var khoNguyenLieu = team06.KHOes.Where(p => p.TENKHO.ToUpper() == tenKho.ToUpper()).SingleOrDefault();
            if (khoNguyenLieu == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Kiem tra ton tai ma kho nguyen lieu
        public bool isTonTaiMaKhoNguyenLieu(string maKho)
        {
            var khoNguyenLieu = team06.KHOes.Find(maKho);
            if (khoNguyenLieu == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Kiem tra ton tai nguyen lieu trong kho
        public bool isTonTaiNguyenLieuTrongKho(string maKho)
        {
            bool isTonTai = false;
            foreach(NGUYENLIEU nguyenLieu in team06.NGUYENLIEUx)
            {
                if(nguyenLieu.MAKHO == maKho)
                {
                    isTonTai = true;
                    break;
                }
            }
            return isTonTai;
        }
        // Danh sach cac nguyen lieu trong kho
        public string nguyenLieuTrongKho(string maKho)
        {
            string text = null;
            var nguyenLieu = team06.NGUYENLIEUx.Where(p => p.MAKHO == maKho);
            foreach(NGUYENLIEU _nguyenLieu in nguyenLieu)
            {
                text += "+" + _nguyenLieu.TENNGUYENLIEU + "\n";
            }
            return text;
        }
        // Liet ke cac kho nguyen lieu trong Database
        public void DuLieuKhoNguyenLieu(DataGridView dataGV)
        {
            var khoNguyenLieu = team06.KHOes.Select(p => new
            {
                p.MAKHO,
                p.TENKHO
            });
            dataGV.DataSource = khoNguyenLieu.ToList();
        }
        // Them kho nguyen lieu
        public void ThemKhoNguyenLieu(string maKho, string tenKho)
        {
            KHO khoNguyenLieu = new KHO();
            khoNguyenLieu.MAKHO = maKho;
            khoNguyenLieu.TENKHO = tenKho;
            team06.KHOes.Add(khoNguyenLieu);
            team06.SaveChanges();
        }
        // Sua kho nguyen lieu
        public void SuaKhoNguyenLieu(string maKho, string tenKho)
        {
            var khoNguyenLieu = team06.KHOes.Find(maKho);
            khoNguyenLieu.TENKHO = tenKho;
            team06.SaveChanges();
        }
        // Xoa kho nguyen lieu
        public void XoaKhoNguyenLieu(List<string> listMaKho)
        {
            KHO khoNguyenLieu = new KHO();
            BANGKIEMKE bangKiemKe = new BANGKIEMKE();
            foreach(string maKho in listMaKho)
            {
                khoNguyenLieu = team06.KHOes.Find(maKho);
                team06.KHOes.Remove(khoNguyenLieu);
                team06.SaveChanges();
            }
        }
        // combobox kho nguyen lieu
        public List<ComboboxItem> comboboxKhoNguyenLieu()
        {
            List<ComboboxItem> listKhoNguyenLieu = new List<ComboboxItem>();
            foreach (KHO khoNguyenLieu in team06.KHOes)
            {
                listKhoNguyenLieu.Add(new ComboboxItem { Ma = khoNguyenLieu.MAKHO, Ten = khoNguyenLieu.TENKHO });
            }
            return listKhoNguyenLieu;
        }
    }
}
