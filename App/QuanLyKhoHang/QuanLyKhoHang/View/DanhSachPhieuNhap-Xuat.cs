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
    public partial class FrmDanhSachPhieuNhap_Xuat : Form
    {
        private bool isDanhSachPhieuNhap;
        private string maNhanVien;
        public FrmDanhSachPhieuNhap_Xuat(bool _isDanhSachPhieuNhap)
        {
            InitializeComponent();
            isDanhSachPhieuNhap = _isDanhSachPhieuNhap;
            rButtonTimTheoMaVaTen.Checked = true;
            if(isDanhSachPhieuNhap == true)
            {
                lbDanhSachPhieu.Text += "nhập nguyên liệu";
            }
            else
            {
                lbDanhSachPhieu.Text += "xuất nguyên liệu";
            }
            ThietLapComboboxNhanVien();
            LietKeDanhSachPhieu();
            BussinessLogicLayer.BLLayer_DanhSachPhieuNhapXuat.instance.ChiTietPhieu(isDanhSachPhieuNhap, dgvChiTietPhieu, null);
            DinhDangTenCot();
        }
        public void DinhDangTenCot()
        {
            dgvDSPhieu.Columns["MAPHIEU"].HeaderText = "Mã phiếu";
            dgvDSPhieu.Columns["TENNHANVIEN"].HeaderText = "Nhân viên";
            dgvDSPhieu.Columns["NGAYLAP"].HeaderText = "Ngày lập phiếu";
            dgvChiTietPhieu.Columns["TENNGUYENLIEU"].HeaderText = "Nguyên liệu";
            dgvChiTietPhieu.Columns["SOLUONG"].HeaderText = "Số lượng";
            dgvChiTietPhieu.Columns["TENNHACUNGCAP"].HeaderText = "Nhà cung cấp";
        }
        public void Enable(bool isChoPhep)
        {
            cbboxNhanVien.Enabled = dateLapPhieu.Enabled = !isChoPhep;
            btnLuu.Enabled = !isChoPhep;
            btnSua.Enabled = btnXoa.Enabled = isChoPhep;
        }
        public void DonDepDuLieuNhap()
        {
            txtMaPhieu.Clear();
            lbMaPhieu.Text = null;
            cbboxNhanVien.SelectedIndex = 0;
            dgvChiTietPhieu.DataSource = null;
        }
        public void ThietLapComboboxNhanVien()
        {
            cbboxNhanVien.Items.Add("--Nhân viên--");
            cbboxNhanVien.Items.AddRange(BussinessLogicLayer.BLLayer_TaiKhoan.instance.comboboxNhanVien().ToArray());
            cbboxNhanVien.SelectedIndex = 0;
        }
        public void LietKeDanhSachPhieu()
        {
            BussinessLogicLayer.BLLayer_DanhSachPhieuNhapXuat.instance.DuLieuPhieu(dgvDSPhieu, isDanhSachPhieuNhap);
            Enable(true);
            DonDepDuLieuNhap();
        }
        private void btnQuayRa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(rButtonTimTheoMaVaTen.Checked == true)
            {
                BussinessLogicLayer.BLLayer_DanhSachPhieuNhapXuat.instance.TimKiemPhieu(dgvDSPhieu, isDanhSachPhieuNhap, true, txtTimKiem.Text.Trim(), DateTime.Now);
            }
            else if(rButtonTimTheoNgay.Checked == true)
            {
                BussinessLogicLayer.BLLayer_DanhSachPhieuNhapXuat.instance.TimKiemPhieu(dgvDSPhieu, isDanhSachPhieuNhap, false, null, dateTimKiem.Value);
            }
            DonDepDuLieuNhap();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu muốn sửa thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Enable(false);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult xoaPhieu = MessageBox.Show("Bạn chắc chắn muốn xóa phiếu này?", "Thông báo xóa phiếu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xoaPhieu == DialogResult.Yes)
                {
                    List<string> listMaPhieu = new List<string>();
                    DataGridViewSelectedRowCollection dataGV = dgvDSPhieu.SelectedRows;
                    foreach (DataGridViewRow dgvRow in dataGV)
                    {
                        listMaPhieu.Add(dgvRow.Cells["MAPHIEU"].Value.ToString());
                    }
                    BussinessLogicLayer.BLLayer_DanhSachPhieuNhapXuat.instance.XoaPhieu(isDanhSachPhieuNhap, listMaPhieu);
                }
                LietKeDanhSachPhieu();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbboxNhanVien.SelectedIndex == 0 || dateLapPhieu.Value > DateTime.Now)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Lỗi chưa chọn nhân viên hoặc nhập ngày không chính xác", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                maNhanVien = ((ComboboxItem)cbboxNhanVien.SelectedItem).Ma;
                BussinessLogicLayer.BLLayer_DanhSachPhieuNhapXuat.instance.SuaPhieu(txtMaPhieu.Text, maNhanVien, dateLapPhieu.Value);
                MessageBox.Show("Sửa phiếu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LietKeDanhSachPhieu();
            }
        }
        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập mã đơn hoặc tên nhân viên")
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
                txtTimKiem.Text = "Nhập mã đơn hoặc tên nhân viên";
            }
        }

        private void dgvDSPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieu.Text = dgvDSPhieu.SelectedRows[0].Cells["MAPHIEU"].Value.ToString();
            cbboxNhanVien.Text = dgvDSPhieu.SelectedRows[0].Cells["TENNHANVIEN"].Value.ToString();
            dateLapPhieu.Value = (DateTime)dgvDSPhieu.SelectedRows[0].Cells["NGAYLAP"].Value;
            BussinessLogicLayer.BLLayer_DanhSachPhieuNhapXuat.instance.ChiTietPhieu(isDanhSachPhieuNhap, dgvChiTietPhieu, txtMaPhieu.Text);
            lbMaPhieu.Text = txtMaPhieu.Text;
        }

        private void dgvDSPhieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvDSPhieu.DefaultCellStyle.BackColor = Color.OldLace;
        }

        private void dgvChiTietPhieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvChiTietPhieu.DefaultCellStyle.BackColor = Color.LightCyan;
        }

        private void rButtonTimTheoMaVaTen_CheckedChanged(object sender, EventArgs e)
        {
            if(rButtonTimTheoMaVaTen.Checked == true)
            {
                dateTimKiem.Enabled = false;
                txtTimKiem.Enabled = true;
            }
            else
            {
                LietKeDanhSachPhieu();
            }
        }

        private void rButtonTimTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if(rButtonTimTheoNgay.Checked == true)
            {
                txtTimKiem.Enabled = false;
                dateTimKiem.Enabled = true;
            }
            else
            {
                LietKeDanhSachPhieu();
            }
        }

    }
}
