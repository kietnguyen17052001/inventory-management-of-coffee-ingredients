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
    public partial class FrmNguyenLieu : Form
    {
        private string maNguyenLieu, tenNguyenLieu, maNhaCungCap, donViTinh, maKho;
        public FrmNguyenLieu()
        {
            InitializeComponent();
            ThietLapCombobox();
            LietKeNguyenLieu();
            DinhDangTenCot();
        }
        private bool isThem; // Kiem tra chuc nang them hay sua: true => them, false => sua
        public void DinhDangTenCot()
        {
            dgvNguyenLieu.Columns["MANGUYENLIEU"].HeaderText = "Mã nguyên liệu";
            dgvNguyenLieu.Columns["TENNGUYENLIEU"].HeaderText = "Tên nguyên liệu";
            dgvNguyenLieu.Columns["TENNHACUNGCAP"].HeaderText = "Nhà cung cấp";
            dgvNguyenLieu.Columns["TENKHO"].HeaderText = "Kho";
            dgvNguyenLieu.Columns["DONVITINH"].HeaderText = "Đơn vị tính";
        }
        public void Enable(bool isChoPhep)
        {
            txtMaNguyenLieu.Enabled = txtTenNguyenLieu.Enabled = txtDonViTinh.Enabled = cbboxKhoHang.Enabled = cbboxNhaCungCap.Enabled = !isChoPhep;
            btnLuu.Enabled = btnHuyBo.Enabled = !isChoPhep;
            btnThem.Enabled = btnSua.Enabled = isChoPhep;
        }
        public void DonDepDuLieuNhap()
        {
            txtMaNguyenLieu.Clear(); txtTenNguyenLieu.Clear(); txtDonViTinh.Clear();
            cbboxKhoHang.SelectedIndex = cbboxNhaCungCap.SelectedIndex = 0;
        }
        public void ThietLapCombobox()
        {
            cbboxKhoHang.Items.Add("--Lựa chọn kho hàng--");
            cbboxNhaCungCap.Items.Add("--Lựa chọn nhà cung cấp--");
            cbboxKhoHang.Items.AddRange(BussinessLogicLayer.BLLayer_Kho.instance.comboboxKhoNguyenLieu().ToArray());
            cbboxNhaCungCap.Items.AddRange(BussinessLogicLayer.BLLayer_NhaCungCap.instance.comboboxNhaCungCap().ToArray());
            cbboxKhoHang.SelectedIndex = cbboxNhaCungCap.SelectedIndex = 0;
        }
        public void LietKeNguyenLieu()
        {
            BussinessLogicLayer.BLLayer_NguyenLieu.instance.DuLieuNguyenLieu(dgvNguyenLieu);
            Enable(true);
            DonDepDuLieuNhap();
        }
        private void btnQuayRa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ThemNhaCungCap(string maNhaCungCap, string tenNhaCungCap)
        {
            cbboxNhaCungCap.Items.Add(new ComboboxItem { Ma = maNhaCungCap, Ten = tenNhaCungCap });
        }
        private void btnXemNCC_Click(object sender, EventArgs e)
        {
            if (cbboxNhaCungCap.SelectedIndex == 0)
            {
                FrmNhaCungCap frmNhaCungCap = new FrmNhaCungCap(null);
                frmNhaCungCap.thaoLy += new FrmNhaCungCap.myDel(ThemNhaCungCap);
                frmNhaCungCap.Show();
            }
            else
            {
                FrmNhaCungCap frmNhaCungCap = new FrmNhaCungCap(((ComboboxItem)cbboxNhaCungCap.SelectedItem).Ma);
                frmNhaCungCap.thaoLy += new FrmNhaCungCap.myDel(ThemNhaCungCap);
                frmNhaCungCap.Show();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true;
            Enable(false);
            DonDepDuLieuNhap();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaNguyenLieu.Text))
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu muốn sửa thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                isThem = false;
                Enable(false);
                txtMaNguyenLieu.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaNguyenLieu.Text) || String.IsNullOrEmpty(txtTenNguyenLieu.Text) || String.IsNullOrEmpty(txtDonViTinh.Text)
                || (cbboxNhaCungCap.SelectedIndex == 0) || (cbboxKhoHang.SelectedIndex == 0))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                maNguyenLieu = txtMaNguyenLieu.Text.Trim();
                tenNguyenLieu = txtTenNguyenLieu.Text.Trim();
                donViTinh = txtDonViTinh.Text.Trim();
                maKho = ((ComboboxItem)cbboxKhoHang.SelectedItem).Ma;
                maNhaCungCap = ((ComboboxItem)cbboxNhaCungCap.SelectedItem).Ma;
                if (isThem)
                {
                    if (BussinessLogicLayer.BLLayer_NguyenLieu.instance.isTonTaiMaNguyenLieu(maNguyenLieu)
                        && !BussinessLogicLayer.BLLayer_NguyenLieu.instance.isTonTaiTenNguyenLieu(tenNguyenLieu))
                    {
                        MessageBox.Show("Mã nguyên liệu đã tồn tại", "Lỗi nhập mã nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enable(false);
                    }
                    else if (!BussinessLogicLayer.BLLayer_NguyenLieu.instance.isTonTaiMaNguyenLieu(maNguyenLieu)
                        && BussinessLogicLayer.BLLayer_NguyenLieu.instance.isTonTaiTenNguyenLieu(tenNguyenLieu))
                    {
                        MessageBox.Show("Tên nguyên liệu đã tồn tại", "Lỗi nhập tên nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enable(false);
                    }
                    else if (BussinessLogicLayer.BLLayer_NguyenLieu.instance.isTonTaiMaNguyenLieu(maNguyenLieu)
                        && BussinessLogicLayer.BLLayer_NguyenLieu.instance.isTonTaiTenNguyenLieu(tenNguyenLieu))
                    {
                        MessageBox.Show("Mã và Tên nguyên liệu đã tồn tại", "Lỗi nhập mã và tên nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enable(false);
                    }
                    else
                    {
                        BussinessLogicLayer.BLLayer_NguyenLieu.instance.ThemNguyenLieu(maNguyenLieu, tenNguyenLieu, donViTinh, maNhaCungCap, maKho);
                        MessageBox.Show("Thêm nguyên liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LietKeNguyenLieu();
                    }
                }
                else
                {
                    BussinessLogicLayer.BLLayer_NguyenLieu.instance.SuaNguyenLieu(maNguyenLieu, tenNguyenLieu, donViTinh, maNhaCungCap, maKho);
                    MessageBox.Show("Sửa nguyên liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LietKeNguyenLieu();
                }
            }
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DonDepDuLieuNhap();
            Enable(true);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            BussinessLogicLayer.BLLayer_NguyenLieu.instance.TimKiemNguyenLieu(dgvNguyenLieu, txtTimKiem.Text.Trim());
        }

        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNguyenLieu.Text = dgvNguyenLieu.SelectedRows[0].Cells["MANGUYENLIEU"].Value.ToString();
            txtTenNguyenLieu.Text = dgvNguyenLieu.SelectedRows[0].Cells["TENNGUYENLIEU"].Value.ToString();
            txtDonViTinh.Text = dgvNguyenLieu.SelectedRows[0].Cells["DONVITINH"].Value.ToString();
            cbboxNhaCungCap.Text = dgvNguyenLieu.SelectedRows[0].Cells["TENNHACUNGCAP"].Value.ToString();
            cbboxKhoHang.Text = dgvNguyenLieu.SelectedRows[0].Cells["TENKHO"].Value.ToString();
        }

        private void dgvNguyenLieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvNguyenLieu.DefaultCellStyle.BackColor = Color.OldLace;
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if(txtTimKiem.Text == "Nhập mã, tên nguyên liệu hoặc kho hàng, nhà cung cấp")
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
                txtTimKiem.Text = "Nhập mã, tên nguyên liệu hoặc kho hàng, nhà cung cấp";
            }
        }
    }
}
