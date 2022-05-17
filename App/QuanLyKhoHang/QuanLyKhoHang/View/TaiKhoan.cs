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
    public partial class FrmTaiKhoan : Form
    {
        private string maNhanVien, tenNhanVien, taiKhoan, matKhau;
        public FrmTaiKhoan()
        {
            InitializeComponent();
            LietKeNguoiDung();
            DinhDangTenCot();
        }
        private bool isThem; // Kiem tra chuc nang them hay sua: true => them, false => sua
        public void DinhDangTenCot()
        {
            dgvTaiKhoan.Columns["MANHANVIEN"].HeaderText = "Mã nhân viên";
            dgvTaiKhoan.Columns["TENNHANVIEN"].HeaderText = "Tên nhân viên";
            dgvTaiKhoan.Columns["TAIKHOAN"].HeaderText = "Tài khoản";
            dgvTaiKhoan.Columns["MATKHAU"].HeaderText = "Mật khẩu";
        }
        public void Enable(bool isChoPhep)
        {
            txtMaNhanVien.Enabled = txtTenNhanVien.Enabled = txtTaiKhoan.Enabled = txtMatKhau.Enabled = !isChoPhep;
            btnLuu.Enabled = btnHuyBo.Enabled = !isChoPhep;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = isChoPhep;
        }
        public void DonDepDuLieuNhap()
        {
            txtMaNhanVien.Clear(); txtTenNhanVien.Clear(); txtTaiKhoan.Clear(); txtMatKhau.Clear();
        }
        public void LietKeNguoiDung()
        {
            BussinessLogicLayer.BLLayer_TaiKhoan.instance.DuLieuNguoiDung(dgvTaiKhoan);
            Enable(true);
            DonDepDuLieuNhap();
        }
        private void btnQuayRa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true;
            Enable(false);
            DonDepDuLieuNhap();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn người dùng muốn sửa thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                isThem = false;
                Enable(false);
                txtMaNhanVien.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaNhanVien.Text) || String.IsNullOrEmpty(txtTenNhanVien.Text) || String.IsNullOrEmpty(txtTaiKhoan.Text)
                || String.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                maNhanVien = txtMaNhanVien.Text.Trim();
                tenNhanVien = txtTenNhanVien.Text.Trim();
                taiKhoan = txtTaiKhoan.Text.Trim();
                matKhau = txtMatKhau.Text.Trim();
                if (isThem)
                {
                    if (BussinessLogicLayer.BLLayer_TaiKhoan.instance.isTonTaiMaNhanVien(maNhanVien)
                        && !BussinessLogicLayer.BLLayer_TaiKhoan.instance.isTonTaiTenDangNhap(taiKhoan))
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại", "Lỗi nhập mã nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enable(false);
                    }
                    else if (!BussinessLogicLayer.BLLayer_TaiKhoan.instance.isTonTaiMaNhanVien(maNhanVien)
                        && BussinessLogicLayer.BLLayer_TaiKhoan.instance.isTonTaiTenDangNhap(taiKhoan))
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại", "Lỗi nhập tên đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enable(false);
                    }
                    else if (BussinessLogicLayer.BLLayer_TaiKhoan.instance.isTonTaiMaNhanVien(maNhanVien)
                        && BussinessLogicLayer.BLLayer_TaiKhoan.instance.isTonTaiTenDangNhap(taiKhoan))
                    {
                        MessageBox.Show("Mã nhân viên và Tên đăng nhập đã tồn tại", "Lỗi nhập mã và tên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enable(false);
                    }
                    else
                    {
                        BussinessLogicLayer.BLLayer_TaiKhoan.instance.ThemNguoiDung(maNhanVien, tenNhanVien, taiKhoan, matKhau);
                        MessageBox.Show("Thêm người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LietKeNguoiDung();
                    }
                }
                else
                {
                    BussinessLogicLayer.BLLayer_TaiKhoan.instance.SuaNguoiDung(maNhanVien, tenNhanVien, taiKhoan, matKhau);
                    MessageBox.Show("Sửa người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LietKeNguoiDung();
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DonDepDuLieuNhap();
            Enable(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn người dùng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult xoaNguoiDung = MessageBox.Show("Bạn chắc chắn muốn xóa người dùng này?", "Thông báo xóa người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xoaNguoiDung == DialogResult.Yes)
                {
                    List<string> listMaNguoiDung = new List<string>();
                    DataGridViewSelectedRowCollection dataGV = dgvTaiKhoan.SelectedRows;
                    foreach (DataGridViewRow dgvRow in dataGV)
                    {
                        listMaNguoiDung.Add(dgvRow.Cells["MANHANVIEN"].Value.ToString());
                    }
                    BussinessLogicLayer.BLLayer_TaiKhoan.instance.XoaNguoiDung(listMaNguoiDung);
                }
                LietKeNguoiDung();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            BussinessLogicLayer.BLLayer_TaiKhoan.instance.TimKiemNguoiDung(dgvTaiKhoan, txtTimKiem.Text.Trim());
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập mã, tên nhân viên hoặc tên đăng nhập")
            {
                txtTimKiem.ForeColor = Color.Black;
                txtTimKiem.Text = "";
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.ForeColor = Color.Silver;
                txtTimKiem.Text = "Nhập mã, tên nhân viên hoặc tên đăng nhập";
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNhanVien.Text = dgvTaiKhoan.SelectedRows[0].Cells["MANHANVIEN"].Value.ToString();
            txtTenNhanVien.Text = dgvTaiKhoan.SelectedRows[0].Cells["TENNHANVIEN"].Value.ToString();
            txtTaiKhoan.Text = dgvTaiKhoan.SelectedRows[0].Cells["TAIKHOAN"].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoan.SelectedRows[0].Cells["MATKHAU"].Value.ToString();
        }

        private void dgvTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvTaiKhoan.DefaultCellStyle.BackColor = Color.OldLace;
        }

    }
}
