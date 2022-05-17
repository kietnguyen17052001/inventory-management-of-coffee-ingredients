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
    public partial class FrmKhoNguyenLieu : Form
    {
        public FrmKhoNguyenLieu()
        {
            InitializeComponent();
            LietKeKhoNguyenLieu();
            DinhDangTenCot();
        }
        private bool isThem; // Kiem tra chuc nang them hay sua: true => them, false => sua
        public void DinhDangTenCot()
        {
            dgvKho.Columns["MAKHO"].HeaderText = "Mã kho nguyên liệu";
            dgvKho.Columns["TENKHO"].HeaderText = "Tên kho nguyên liệu";
        }
        public void Enable(bool isChoPhep)
        {
            txtMaKho.Enabled = txtTenKho.Enabled = !isChoPhep;
            btnLuu.Enabled = !isChoPhep;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = isChoPhep;
        }
        public void DonDepDuLieuNhap()
        {
            txtMaKho.Clear(); txtTenKho.Clear();
        }
        public void LietKeKhoNguyenLieu()
        {
            BussinessLogicLayer.BLLayer_Kho.instance.DuLieuKhoNguyenLieu(dgvKho);
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
            if (String.IsNullOrEmpty(txtMaKho.Text))
            {
                MessageBox.Show("Vui lòng chọn kho muốn sửa thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                isThem = false;
                Enable(false);
                txtMaKho.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaKho.Text) || String.IsNullOrEmpty(txtTenKho.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (isThem)
                {
                    
                    if (BussinessLogicLayer.BLLayer_Kho.instance.isTonTaiMaKhoNguyenLieu(txtMaKho.Text.Trim())
                        && !BussinessLogicLayer.BLLayer_Kho.instance.isTonTaiTenKhoNguyenLieu(txtTenKho.Text.Trim())) {
                        MessageBox.Show("Mã kho nguyên liệu đã tồn tại", "Lỗi nhập mã kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enable(false);
                    }
                    else if (!BussinessLogicLayer.BLLayer_Kho.instance.isTonTaiMaKhoNguyenLieu(txtMaKho.Text.Trim())
                        && BussinessLogicLayer.BLLayer_Kho.instance.isTonTaiTenKhoNguyenLieu(txtTenKho.Text.Trim()))
                    {
                        MessageBox.Show("Tên kho nguyên liệu đã tồn tại", "Lỗi nhập mã kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enable(false);
                    }
                    else if (BussinessLogicLayer.BLLayer_Kho.instance.isTonTaiMaKhoNguyenLieu(txtMaKho.Text.Trim())
                        && BussinessLogicLayer.BLLayer_Kho.instance.isTonTaiTenKhoNguyenLieu(txtTenKho.Text.Trim()))
                    {
                        MessageBox.Show("Mã và Tên kho nguyên liệu đã tồn tại", "Lỗi nhập mã kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enable(false);
                    }
                    else
                    {
                        BussinessLogicLayer.BLLayer_Kho.instance.ThemKhoNguyenLieu(txtMaKho.Text, txtTenKho.Text);
                        MessageBox.Show("Thêm kho nguyên liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LietKeKhoNguyenLieu();
                    }
                }
                else
                {
                    BussinessLogicLayer.BLLayer_Kho.instance.SuaKhoNguyenLieu(txtMaKho.Text, txtTenKho.Text);
                    MessageBox.Show("Sửa kho nguyên liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LietKeKhoNguyenLieu();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaKho.Text))
            {
                MessageBox.Show("Vui lòng chọn kho muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult xoaKho = MessageBox.Show("Bạn chắc chắn muốn xóa kho nguyên liệu này?", "Thông báo xóa kho", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xoaKho == DialogResult.Yes)
                {
                    List<string> listMaKhoNguyenLieu = new List<string>();
                    DataGridViewSelectedRowCollection dataGV = dgvKho.SelectedRows;
                    foreach (DataGridViewRow dgvRow in dataGV)
                    {
                        if (BussinessLogicLayer.BLLayer_Kho.instance.isTonTaiNguyenLieuTrongKho(dgvRow.Cells["MAKHO"].Value.ToString()))
                        {
                            MessageBox.Show("Kho thể xóa kho. Trong " + dgvRow.Cells["TENKHO"].Value.ToString() + " đang có:\n" +
                                BussinessLogicLayer.BLLayer_Kho.instance.nguyenLieuTrongKho(dgvRow.Cells["MAKHO"].Value.ToString())
                                , "Lỗi xóa kho nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            listMaKhoNguyenLieu.Add(dgvRow.Cells["MAKHO"].Value.ToString());
                        }
                    }
                    BussinessLogicLayer.BLLayer_Kho.instance.XoaKhoNguyenLieu(listMaKhoNguyenLieu);
                }
                LietKeKhoNguyenLieu();
            }
        }

        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKho.Text = dgvKho.SelectedRows[0].Cells["MAKHO"].Value.ToString();
            txtTenKho.Text = dgvKho.SelectedRows[0].Cells["TENKHO"].Value.ToString();
        }

        private void dgvKho_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvKho.DefaultCellStyle.BackColor = Color.OldLace;
        }

    }
}
