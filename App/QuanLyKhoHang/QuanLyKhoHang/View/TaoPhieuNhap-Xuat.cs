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
    public partial class FrmTaoPhieuNhapXuat : Form
    {
        private string maNguyenLieu, tenNguyenLieu, maPhieu, maNhanVien, donViTinh;
        private int soLuongThem, soLuongGiam, tongNguyenLieu, tongSoLuong;
        private DateTime ngayLapPhieu;
        private DataTable bangDuLieu = BussinessLogicLayer.BLLayer_PhieuNhapXuat.instance.BangPhieuThongTin();
        private bool isPhieuNhap; // Kiem tra la phieu nhap hay phieu xuat
        public FrmTaoPhieuNhapXuat(bool _isPhieuNhap)
        {
            InitializeComponent();
            isPhieuNhap = _isPhieuNhap;
            if (isPhieuNhap == true)
            {
                lbLoaiPhieu.Text += "Nhập nguyên liệu";
            }
            else if(isPhieuNhap == false)
            {
                lbLoaiPhieu.Text += "Xuất nguyên liệu";
            }
            LietKeNguyenLieu();
            DinhDangTenCot();
            ThietLapCombobox();
            maNguyenLieu = dgvNguyenLieu.Rows[0].Cells[0].Value.ToString();
            tenNguyenLieu = dgvNguyenLieu.Rows[0].Cells[1].Value.ToString();
            donViTinh = dgvNguyenLieu.Rows[0].Cells[3].Value.ToString();
        }
        public void DinhDangTenCot()
        {
            dgvNguyenLieu.Columns["MANGUYENLIEU"].HeaderText = "Mã N.liệu";
            dgvNguyenLieu.Columns["TENNGUYENLIEU"].HeaderText = "Tên N.Liệu";
            dgvNguyenLieu.Columns["TENNHACUNGCAP"].HeaderText = "Nhà cung cấp";
            dgvNguyenLieu.Columns["DONVITINH"].HeaderText = "Đơn vị tính";
        }
        public void DonDepDuLieuNhap()
        {
            txtMaPhieu.Clear(); cbboxNhanVien.SelectedIndex = 0;
            txtTongNguyenLieu.Clear(); txtTongSoLuong.Clear();
            txtNguyenLieu.Clear();
            txtGiam.Text = txtTang.Text = "1";
            bangDuLieu.Clear();
        }
        public void LietKeNguyenLieu()
        {
            BussinessLogicLayer.BLLayer_PhieuNhapXuat.instance.DuLieuNguyenLieu(dgvNguyenLieu);
            dgvPhieu.DataSource = bangDuLieu;
        }
        public void ThietLapCombobox()
        {
            cbboxNhanVien.Items.Add("--Lựa chọn nhân viên--");
            cbboxNhanVien.Items.AddRange(BussinessLogicLayer.BLLayer_TaiKhoan.instance.comboboxNhanVien().ToArray());
            cbboxNhanVien.SelectedIndex = 0;
        }
        private void btnQuayRa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNguyenLieu_TextChanged(object sender, EventArgs e)
        {
            BussinessLogicLayer.BLLayer_PhieuNhapXuat.instance.TimKiemNguyenLieu(dgvNguyenLieu, txtNguyenLieu.Text.Trim());
        }

        private void txtNguyenLieu_Enter(object sender, EventArgs e)
        {
            if (txtNguyenLieu.Text == "Nhập mã hoặc tên nguyên liệu")
            {
                txtNguyenLieu.ForeColor = Color.Black;
                txtNguyenLieu.Text = "";
            }
        }

        private void txtNguyenLieu_Leave(object sender, EventArgs e)
        {
            if (txtNguyenLieu.Text == "")
            {
                txtNguyenLieu.ForeColor = Color.Silver;
                txtNguyenLieu.Text = "Nhập mã hoặc tên nguyên liệu";
            }
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTang.Text) || (Convert.ToInt32(txtTang.Text) == 0))
            {
                MessageBox.Show("Vui lòng nhập số lượng nguyên liệu trước khi nhấn thêm", "Lỗi nhập nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                soLuongThem = Convert.ToInt32(txtTang.Text);
                if (isPhieuNhap == true) // phieu nhap
                {
                    if (BussinessLogicLayer.BLLayer_PhieuNhapXuat.instance.isCungNhaCungCap(dgvNguyenLieu.SelectedRows[0].Cells["TENNHACUNGCAP"].Value.ToString()
                    , bangDuLieu)) // nguyen lieu co cung nha cung cap
                    {
                        BussinessLogicLayer.BLLayer_PhieuNhapXuat.instance.ThemSoLuongNguyenLieu(bangDuLieu, soLuongThem, maNguyenLieu, tenNguyenLieu);
                    }
                    else // nguyen lieu khong cung nha cung cap
                    {
                        MessageBox.Show("Nguyên liệu vừa nhập không cùng nhà cung cấp \n với nguyên liệu trong bảng dữ liệu", "Lỗi nhập nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // phieu xuat
                {
                    if (BussinessLogicLayer.BLLayer_BangKiemKe.instance.isCoNguyenLieuTrongBangKiemKe(maNguyenLieu))
                    {
                        // Kiem tra xem so luong nguyen lieu trong kho co du xuat hay khong
                        if ((soLuongThem <= BussinessLogicLayer.BLLayer_BangKiemKe.instance.luongTonKhoNguyenLieu(maNguyenLieu))
                            && BussinessLogicLayer.BLLayer_PhieuNhapXuat.instance.isPhuHopSoLuongNguyenLieu(bangDuLieu,maNguyenLieu,soLuongThem))// du dieu kien xuat nguyen lieu
                        {
                            BussinessLogicLayer.BLLayer_PhieuNhapXuat.instance.ThemSoLuongNguyenLieu(bangDuLieu, soLuongThem, maNguyenLieu, tenNguyenLieu);
                        }
                        else // kh du dieu kien xuat nghien lieu
                        {
                            MessageBox.Show("Số lượng " + tenNguyenLieu + " trong kho không đủ để xuất\n Hiện trong kho có: "
                                + BussinessLogicLayer.BLLayer_BangKiemKe.instance.luongTonKhoNguyenLieu(maNguyenLieu) + " " + donViTinh
                                , "Lỗi xuất nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại nguyên liệu trong bảng kiểm kê", "Lỗi xuất nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            tongNguyenLieu = bangDuLieu.Rows.Count;
            tongSoLuong = BussinessLogicLayer.BLLayer_PhieuNhapXuat.instance.tongSoLuongNguyenLieu(bangDuLieu);
            txtTongNguyenLieu.Text = tongNguyenLieu.ToString(); // So loai nguyen lieu
            txtTongSoLuong.Text = tongSoLuong.ToString(); // So luong nguyen lieu
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if(bangDuLieu.Rows.Count == 0)
            {
                MessageBox.Show("Phiếu nguyên liệu trống", "Lỗi không thể giảm nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (String.IsNullOrEmpty(txtGiam.Text) || (Convert.ToInt32(txtGiam.Text) == 0))
                {
                    MessageBox.Show("Vui lòng nhập số lượng nguyên liệu trước khi nhấn giảm", "Lỗi không thể giảm nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    soLuongGiam = Convert.ToInt32(txtGiam.Text);
                    if (soLuongGiam <= Convert.ToInt32(dgvPhieu.SelectedRows[0].Cells["Số lượng"].Value.ToString()))
                    {
                        BussinessLogicLayer.BLLayer_PhieuNhapXuat.instance.GiamSoLuongNguyenLieu(bangDuLieu, soLuongGiam, dgvPhieu.SelectedRows[0].Cells["Mã nguyên liệu"].Value.ToString());
                        tongNguyenLieu = bangDuLieu.Rows.Count;
                        tongSoLuong = BussinessLogicLayer.BLLayer_PhieuNhapXuat.instance.tongSoLuongNguyenLieu(bangDuLieu);
                        txtTongNguyenLieu.Text = tongNguyenLieu.ToString(); // So loai nguyen lieu
                        txtTongSoLuong.Text = tongSoLuong.ToString(); // So luong nguyen lieu
                    }
                    else
                    {
                        MessageBox.Show("Số lượng giảm lớn hơn số lượng của nguyên liệu trong phiếu", "Lỗi không thể giảm nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtMaPhieu.Text) || (cbboxNhanVien.SelectedIndex == 0) || bangDuLieu.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập", "Lỗi nhập thiếu thông tin hoặc phiếu trống nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult luuPhieu = MessageBox.Show("Bạn chắc chắn muốn lưu phiếu?", "Thông báo lưu phiếu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(luuPhieu == DialogResult.Yes)
                {
                    maPhieu = txtMaPhieu.Text.Trim();
                    ngayLapPhieu = dateLapPhieu.Value;
                    maNhanVien = ((ComboboxItem)cbboxNhanVien.SelectedItem).Ma;
                    if (BussinessLogicLayer.BLLayer_PhieuNhapXuat.instance.isTonTaiMaPhieu(maPhieu))
                    {
                        MessageBox.Show("Mã phiếu đã tồn tại", "Lỗi nhập mã phiếu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        BussinessLogicLayer.BLLayer_PhieuNhapXuat.instance.LuuPhieu(isPhieuNhap, maPhieu, maNhanVien, ngayLapPhieu, bangDuLieu);
                        MessageBox.Show("Tạo phiếu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DonDepDuLieuNhap();
                    }
                }
            }
        }

        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maNguyenLieu = dgvNguyenLieu.SelectedRows[0].Cells["MANGUYENLIEU"].Value.ToString();
            tenNguyenLieu = dgvNguyenLieu.SelectedRows[0].Cells["TENNGUYENLIEU"].Value.ToString();
            donViTinh = dgvNguyenLieu.SelectedRows[0].Cells["DONVITINH"].Value.ToString();
        }

        private void dgvNguyenLieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvNguyenLieu.DefaultCellStyle.BackColor = Color.OldLace;
        }

        private void dgvPhieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvPhieu.DefaultCellStyle.BackColor = Color.LightCyan;
        }
    }
}
