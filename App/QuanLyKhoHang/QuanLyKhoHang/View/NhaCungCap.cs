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
    public partial class FrmNhaCungCap : Form
    {
        public delegate void myDel(string maNhaCungCap, string tenNhaCungCap);
        public myDel thaoLy { get; set; }
        private string maNhaCungCap, tenNhaCungCap, diaChi, soDienThoai;
        public FrmNhaCungCap(string maNhaCungCap)
        {
            InitializeComponent();
            if (maNhaCungCap != null)
            {
                txtMaNCC.Text = maNhaCungCap;
                txtTenNCC.Text = BussinessLogicLayer.BLLayer_NhaCungCap.instance.tenNhaCungCap(maNhaCungCap);
                txtDiaChi.Text = BussinessLogicLayer.BLLayer_NhaCungCap.instance.diaChiNhaCungCap(maNhaCungCap);
                txtSĐT.Text = BussinessLogicLayer.BLLayer_NhaCungCap.instance.soDienThoaiNhaCungCap(maNhaCungCap);
                Enable(true);
            }
            else
            {
                lbNhaCungCap.Text = "Thêm mới nhà cung cấp";
                Enable(false);
            }
        }
        public void DonDepDuLieu()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtSĐT.Clear();
        }

        public void Enable(bool isChoPhep)
        {
            txtMaNCC.Enabled = txtTenNCC.Enabled = txtDiaChi.Enabled = txtSĐT.Enabled = !isChoPhep;
            btnThem.Enabled = isChoPhep;
            btnLuu.Enabled = !isChoPhep;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Enable(false);
            DonDepDuLieu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaNCC.Text) || String.IsNullOrEmpty(txtTenNCC.Text) || String.IsNullOrEmpty(txtDiaChi.Text) || String.IsNullOrEmpty(txtSĐT.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập", "Nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (BussinessLogicLayer.BLLayer_NhaCungCap.instance.isTonTaiMaNhaCungCap(txtMaNCC.Text.Trim())
                        && !BussinessLogicLayer.BLLayer_NhaCungCap.instance.isTonTaiTenNhaCungCap(txtTenNCC.Text.Trim()))
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại", "Lỗi nhập mã nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Enable(false);
                }
                else if (!BussinessLogicLayer.BLLayer_NhaCungCap.instance.isTonTaiMaNhaCungCap(txtMaNCC.Text.Trim())
                    && BussinessLogicLayer.BLLayer_NhaCungCap.instance.isTonTaiTenNhaCungCap(txtTenNCC.Text.Trim()))
                {
                    MessageBox.Show("Tên nhà cung cấp đã tồn tại", "Lỗi nhập mã nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Enable(false);
                }
                else if (BussinessLogicLayer.BLLayer_NhaCungCap.instance.isTonTaiMaNhaCungCap(txtMaNCC.Text.Trim())
                    && BussinessLogicLayer.BLLayer_NhaCungCap.instance.isTonTaiTenNhaCungCap(txtTenNCC.Text.Trim()))
                {
                    MessageBox.Show("Mã và Tên nhà cung cấp đã tồn tại", "Lỗi nhập mã và tên nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Enable(false);
                }
                else
                {
                    maNhaCungCap = txtMaNCC.Text.Trim();
                    tenNhaCungCap = txtTenNCC.Text.Trim();
                    diaChi = txtDiaChi.Text.Trim();
                    soDienThoai = txtSĐT.Text.Trim();
                    BussinessLogicLayer.BLLayer_NhaCungCap.instance.ThemNhaCungCap(maNhaCungCap, tenNhaCungCap, diaChi, soDienThoai);
                    DialogResult quayVe = MessageBox.Show("Thêm nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(quayVe == DialogResult.OK)
                    {
                        thaoLy(maNhaCungCap, tenNhaCungCap);
                        this.Close();
                    }
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
