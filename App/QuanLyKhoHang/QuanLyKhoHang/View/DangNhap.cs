using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
            lbDate.Text += " " + DateTime.Now.ToString("dddd, dd/MM/yyyy, HH:mm");
        }
        // Chuc nang dang nhap
        public void ThietLapTextTaiKhoan(string _tenDangNhap)
        {
            txtTaikhoan.Text = _tenDangNhap;
        }
        public void DangNhap()
        {
            if (String.IsNullOrEmpty(txtTaikhoan.Text) && !String.IsNullOrEmpty(txtMatkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(txtMatkhau.Text) && !String.IsNullOrEmpty(txtTaikhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(txtTaikhoan.Text) && String.IsNullOrEmpty(txtMatkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (BussinessLogicLayer.BLLayer_TaiKhoan.instance.isDangNhapThanhCong(txtTaikhoan.Text, txtMatkhau.Text)) // Kiem tra dang nhap thanh cong
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    View.FrmQuanLyKhoNguyenLieu frmQuanLyKhoNguyenLieu = new View.FrmQuanLyKhoNguyenLieu(txtTaikhoan.Text);
                    frmQuanLyKhoNguyenLieu.Show();
                    this.Visible = false;
                }
                else // Kiem tra dang nhap that bai
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }
        // Chuc nang thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
            Application.Exit();
        }
    }
}
