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
    public partial class FrmBangKiemKe : Form
    {
        private int luongKiemThuCong;
        private string maKiemKe;
        public FrmBangKiemKe()
        {
            InitializeComponent();
            LietKeBangKiemKe();
            DinhDangTenCot();
        }
        public void DinhDangTenCot()
        {
            dgvBangKiemKe.Columns["MAKIEMKE"].HeaderText = "Mã kiểm kê";
            dgvBangKiemKe.Columns["TENNGUYENLIEU"].HeaderText = "Tên nguyên liệu";
            dgvBangKiemKe.Columns["LUONGTONKHO"].HeaderText = "Lượng tồn kho";
            dgvBangKiemKe.Columns["LUONGTHIEUHUT"].HeaderText = "Lượng thiếu hụt";
            dgvBangKiemKe.Columns["KIEMTHUCONG"].HeaderText = "Kiểm thủ công";
        }
        public void DonDepDuLieuNhap()
        {
            txtMaKiemKe.Clear(); 
            txtNguyenLieu.Clear(); 
            txtTonKho.Clear();
            txtThuCong.Clear();
            txtThieuHut.Clear();
        }
        public void Enable(bool isChoPhep)
        {
            txtThuCong.Enabled = !isChoPhep;
            btnLuu.Enabled = !isChoPhep;
            btnSua.Enabled = isChoPhep;
        }
        public void LietKeBangKiemKe()
        {
            BussinessLogicLayer.BLLayer_BangKiemKe.instance.DuLieuBangKiemKe(dgvBangKiemKe);
            DonDepDuLieuNhap();
            Enable(true);
        }
        private void btnQuayRa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaKiemKe.Text))
            {
                MessageBox.Show("Vui lòng chọn kiểm kê muốn sửa thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Enable(false);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtThuCong.Text))
            {
                MessageBox.Show("Số lượng kiểm thủ công trống", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                luongKiemThuCong = Convert.ToInt32(txtThuCong.Text);
                if (luongKiemThuCong > Convert.ToInt32(txtTonKho.Text))
                {
                    MessageBox.Show("Số lượng kiểm thủ công không được lớn hơn số lượng tồn kho", "Lỗi nhập sai dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    maKiemKe = txtMaKiemKe.Text;
                    BussinessLogicLayer.BLLayer_BangKiemKe.instance.SuaKiemKeTheoKiemThuCong(maKiemKe, luongKiemThuCong);
                    MessageBox.Show("Sửa thông tin bảng kiểm kê thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LietKeBangKiemKe();
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            BussinessLogicLayer.BLLayer_BangKiemKe.instance.TimKiemKiemKe(dgvBangKiemKe, txtTimKiem.Text.Trim());
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập mã kiểm kê hoặc nguyên liệu")
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
                txtTimKiem.Text = "Nhập mã kiểm kê hoặc nguyên liệu";
            }
        }

        private void dgvBangKiemKe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKiemKe.Text = dgvBangKiemKe.SelectedRows[0].Cells["MAKIEMKE"].Value.ToString();
            txtNguyenLieu.Text = dgvBangKiemKe.SelectedRows[0].Cells["TENNGUYENLIEU"].Value.ToString();
            txtTonKho.Text = dgvBangKiemKe.SelectedRows[0].Cells["LUONGTONKHO"].Value.ToString();
            txtThuCong.Text = dgvBangKiemKe.SelectedRows[0].Cells["KIEMTHUCONG"].Value.ToString();
            txtThieuHut.Text = dgvBangKiemKe.SelectedRows[0].Cells["LUONGTHIEUHUT"].Value.ToString();
        }

        private void dgvBangKiemKe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvBangKiemKe.DefaultCellStyle.BackColor = Color.OldLace;
        }
    }
}
