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
    public partial class FrmThongKe : Form
    {
        private int thang = DateTime.Now.Month, nam = DateTime.Now.Year;
        public FrmThongKe()
        {
            InitializeComponent();
            cbboxNam.SelectedIndex = cbbThang.SelectedIndex = 0;
            LietKeDuLieuThongKe(thang,nam);
            DinhDangTenCot();
        }
        public void SoLuongNhapXuatVaTonKho()
        {
            int tongTonKho, soLuongNhap, soLuongXuat;
            tongTonKho = soLuongNhap = soLuongXuat = 0;
            foreach(DataGridViewRow dgvRow in dgvThongKe.Rows)
            {
                tongTonKho += Convert.ToInt32(dgvRow.Cells["TONKHO"].Value.ToString());
                soLuongNhap += Convert.ToInt32(dgvRow.Cells["SOLUONGNHAP"].Value.ToString());
                soLuongXuat += Convert.ToInt32(dgvRow.Cells["SOLUONGXUAT"].Value.ToString());
            }
            lbSoLuongNhap.Text = soLuongNhap.ToString();
            lbSoLuongXuat.Text = soLuongXuat.ToString();
            lbTongTonKho.Text = tongTonKho.ToString();
        }
        public void DinhDangTenCot()
        {
            dgvThongKe.Columns["MANGUYENLIEU"].HeaderText = "Mã nguyên liệu";
            dgvThongKe.Columns["TENNGUYENLIEU"].HeaderText = "Tên nguyên liệu";
            dgvThongKe.Columns["TENNHACUNGCAP"].HeaderText = "Nhà cung cấp";
            dgvThongKe.Columns["TONKHO"].HeaderText = "Tồn kho";
            dgvThongKe.Columns["DONVITINH"].HeaderText = "Đơn vị tính";
            dgvThongKe.Columns["SOLUONGNHAP"].HeaderText = "Số lượng nhập";
            dgvThongKe.Columns["SOLUONGXUAT"].HeaderText = "Số lượng xuất";
        }
        public void LietKeDuLieuThongKe(int thang, int nam)
        {
            BussinessLogicLayer.BLLayer_ThongKe.instance.DuLieuThongKe(false, dgvThongKe, thang, nam);
            SoLuongNhapXuatVaTonKho();
        }

        private void btnQuayRa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvThongKe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvThongKe.DefaultCellStyle.BackColor = Color.OldLace;
        }

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            if(rButtonThang.Checked == true)
            {
                if((cbbThang.SelectedIndex == 0) || (cbboxNam.SelectedIndex == 0))
                {
                    if((cbbThang.SelectedIndex == 0) && (cbboxNam.SelectedIndex != 0))
                    {
                        MessageBox.Show("Vui lòng chọn tháng muốn xem thống kê", "Lỗi chưa chọn ghời gian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(cbboxNam.SelectedIndex == 0 && cbbThang.SelectedIndex != 0)
                    {
                        MessageBox.Show("Vui lòng chọn năm muốn xem thống kê", "Lỗi chưa chọn thời gian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn tháng và năm muốn xem thống kê", "Lỗi chưa chọn thời gian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    thang = Convert.ToInt32(cbbThang.SelectedItem.ToString());
                    nam = Convert.ToInt32(cbboxNam.SelectedItem.ToString());
                    BussinessLogicLayer.BLLayer_ThongKe.instance.DuLieuThongKe(true, dgvThongKe, thang, nam);
                    SoLuongNhapXuatVaTonKho();
                }
            }
            else if(rbButtonNam.Checked == true)
            {
                if(cbboxNam.SelectedIndex == 0)
                {
                    MessageBox.Show("Vui lòng chọn năm muốn xem thống kê", "Lỗi chưa chọn năm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    nam = Convert.ToInt32(cbboxNam.SelectedItem.ToString());
                    BussinessLogicLayer.BLLayer_ThongKe.instance.DuLieuThongKe(false, dgvThongKe, thang, nam);
                    SoLuongNhapXuatVaTonKho();
                }
            }
        }
    }
}
