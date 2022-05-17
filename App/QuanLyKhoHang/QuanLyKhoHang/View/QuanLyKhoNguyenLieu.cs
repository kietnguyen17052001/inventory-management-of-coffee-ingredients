using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.View
{
    public partial class FrmQuanLyKhoNguyenLieu : Form
    {
        public FrmQuanLyKhoNguyenLieu(string _tenDangNhap)
        {
            InitializeComponent();
            lbNguoiDung.Text += BussinessLogicLayer.BLLayer_TaiKhoan.instance.tenNhanVien(_tenDangNhap);
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            FrmKhoNguyenLieu frmKho = new FrmKhoNguyenLieu();
            frmKho.Show();
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            FrmNguyenLieu frmNguyenLieu = new FrmNguyenLieu();
            frmNguyenLieu.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmTaiKhoan frmTaiKhoan = new FrmTaiKhoan();
            frmTaiKhoan.Show();
        }

        private void btnLapDonNhap_Click(object sender, EventArgs e)
        {
            FrmTaoPhieuNhapXuat frmTaoPhieuNhapXuat = new FrmTaoPhieuNhapXuat(true);
            frmTaoPhieuNhapXuat.Show();
        }

        private void btnLapDonXuat_Click(object sender, EventArgs e)
        {
            FrmTaoPhieuNhapXuat frmTaoPhieuNhapXuat = new FrmTaoPhieuNhapXuat(false);
            frmTaoPhieuNhapXuat.Show();
        }

        private void btnBaoCaoNguyenLieu_Click(object sender, EventArgs e)
        {
            FrmThongKe frmBaoCaoNguyenLieu = new FrmThongKe();
            frmBaoCaoNguyenLieu.Show();
        }
        private void btnDanhSachDonNhap_Click(object sender, EventArgs e)
        {
            FrmDanhSachPhieuNhap_Xuat frmDanhSachPhieu = new FrmDanhSachPhieuNhap_Xuat(true);
            frmDanhSachPhieu.Show();
        }

        private void btnDanhSachDonXuat_Click(object sender, EventArgs e)
        {
            FrmDanhSachPhieuNhap_Xuat frmDanhSachPhieu = new FrmDanhSachPhieuNhap_Xuat(false);
            frmDanhSachPhieu.Show();
        }

        private void btnKiemKe_Click(object sender, EventArgs e)
        {
            FrmBangKiemKe frmKiemKe = new FrmBangKiemKe();
            frmKiemKe.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
            this.Close();
        }

    }
}
