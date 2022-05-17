
namespace QuanLyKhoHang.View
{
    partial class FrmDanhSachPhieuNhap_Xuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDanhSachPhieu = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbboxNhanVien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDSPhieu = new System.Windows.Forms.DataGridView();
            this.dgvChiTietPhieu = new System.Windows.Forms.DataGridView();
            this.lbChiTietPhieu = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dateTimKiem = new System.Windows.Forms.DateTimePicker();
            this.labelMaPhieu = new System.Windows.Forms.Label();
            this.rButtonTimTheoMaVaTen = new System.Windows.Forms.RadioButton();
            this.rButtonTimTheoNgay = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnQuayRa = new System.Windows.Forms.Button();
            this.lbMaPhieu = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDanhSachPhieu);
            this.groupBox1.Location = new System.Drawing.Point(276, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 55);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lbDanhSachPhieu
            // 
            this.lbDanhSachPhieu.AutoSize = true;
            this.lbDanhSachPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachPhieu.ForeColor = System.Drawing.Color.Firebrick;
            this.lbDanhSachPhieu.Location = new System.Drawing.Point(16, 18);
            this.lbDanhSachPhieu.Name = "lbDanhSachPhieu";
            this.lbDanhSachPhieu.Size = new System.Drawing.Size(180, 25);
            this.lbDanhSachPhieu.TabIndex = 0;
            this.lbDanhSachPhieu.Text = "Danh sách phiếu ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBox2.Controls.Add(this.cbboxNhanVien);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateLapPhieu);
            this.groupBox2.Controls.Add(this.txtMaPhieu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(26, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(966, 94);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // cbboxNhanVien
            // 
            this.cbboxNhanVien.BackColor = System.Drawing.Color.SkyBlue;
            this.cbboxNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxNhanVien.FormattingEnabled = true;
            this.cbboxNhanVien.Location = new System.Drawing.Point(130, 52);
            this.cbboxNhanVien.Name = "cbboxNhanVien";
            this.cbboxNhanVien.Size = new System.Drawing.Size(254, 28);
            this.cbboxNhanVien.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nhân viên";
            // 
            // dateLapPhieu
            // 
            this.dateLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateLapPhieu.Location = new System.Drawing.Point(575, 18);
            this.dateLapPhieu.Name = "dateLapPhieu";
            this.dateLapPhieu.Size = new System.Drawing.Size(254, 26);
            this.dateLapPhieu.TabIndex = 20;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.BackColor = System.Drawing.Color.SkyBlue;
            this.txtMaPhieu.Enabled = false;
            this.txtMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.ForeColor = System.Drawing.Color.Firebrick;
            this.txtMaPhieu.Location = new System.Drawing.Point(130, 18);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(254, 26);
            this.txtMaPhieu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu";
            // 
            // dgvDSPhieu
            // 
            this.dgvDSPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSPhieu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhieu.Location = new System.Drawing.Point(335, 173);
            this.dgvDSPhieu.Name = "dgvDSPhieu";
            this.dgvDSPhieu.RowHeadersVisible = false;
            this.dgvDSPhieu.RowHeadersWidth = 62;
            this.dgvDSPhieu.RowTemplate.Height = 28;
            this.dgvDSPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSPhieu.Size = new System.Drawing.Size(657, 302);
            this.dgvDSPhieu.TabIndex = 28;
            this.dgvDSPhieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhieu_CellClick);
            this.dgvDSPhieu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDSPhieu_CellFormatting);
            // 
            // dgvChiTietPhieu
            // 
            this.dgvChiTietPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietPhieu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChiTietPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieu.Location = new System.Drawing.Point(26, 492);
            this.dgvChiTietPhieu.Name = "dgvChiTietPhieu";
            this.dgvChiTietPhieu.RowHeadersVisible = false;
            this.dgvChiTietPhieu.RowHeadersWidth = 62;
            this.dgvChiTietPhieu.RowTemplate.Height = 28;
            this.dgvChiTietPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietPhieu.Size = new System.Drawing.Size(966, 201);
            this.dgvChiTietPhieu.TabIndex = 29;
            this.dgvChiTietPhieu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvChiTietPhieu_CellFormatting);
            // 
            // lbChiTietPhieu
            // 
            this.lbChiTietPhieu.AutoSize = true;
            this.lbChiTietPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTietPhieu.ForeColor = System.Drawing.Color.IndianRed;
            this.lbChiTietPhieu.Location = new System.Drawing.Point(22, 453);
            this.lbChiTietPhieu.Name = "lbChiTietPhieu";
            this.lbChiTietPhieu.Size = new System.Drawing.Size(141, 22);
            this.lbChiTietPhieu.TabIndex = 30;
            this.lbChiTietPhieu.Text = "Chi tiết phiếu: ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiem.ForeColor = System.Drawing.Color.Silver;
            this.txtTimKiem.Location = new System.Drawing.Point(26, 209);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(253, 26);
            this.txtTimKiem.TabIndex = 32;
            this.txtTimKiem.Text = "Nhập mã đơn hoặc tên nhân viên";
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // dateTimKiem
            // 
            this.dateTimKiem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimKiem.Location = new System.Drawing.Point(26, 288);
            this.dateTimKiem.Name = "dateTimKiem";
            this.dateTimKiem.Size = new System.Drawing.Size(253, 26);
            this.dateTimKiem.TabIndex = 34;
            // 
            // labelMaPhieu
            // 
            this.labelMaPhieu.AutoSize = true;
            this.labelMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaPhieu.ForeColor = System.Drawing.Color.IndianRed;
            this.labelMaPhieu.Location = new System.Drawing.Point(168, 453);
            this.labelMaPhieu.Name = "labelMaPhieu";
            this.labelMaPhieu.Size = new System.Drawing.Size(0, 22);
            this.labelMaPhieu.TabIndex = 36;
            // 
            // rButtonTimTheoMaVaTen
            // 
            this.rButtonTimTheoMaVaTen.AutoSize = true;
            this.rButtonTimTheoMaVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonTimTheoMaVaTen.ForeColor = System.Drawing.Color.SteelBlue;
            this.rButtonTimTheoMaVaTen.Location = new System.Drawing.Point(26, 177);
            this.rButtonTimTheoMaVaTen.Name = "rButtonTimTheoMaVaTen";
            this.rButtonTimTheoMaVaTen.Size = new System.Drawing.Size(253, 26);
            this.rButtonTimTheoMaVaTen.TabIndex = 39;
            this.rButtonTimTheoMaVaTen.TabStop = true;
            this.rButtonTimTheoMaVaTen.Text = "Tìm kiếm theo mã và tên";
            this.rButtonTimTheoMaVaTen.UseVisualStyleBackColor = true;
            this.rButtonTimTheoMaVaTen.CheckedChanged += new System.EventHandler(this.rButtonTimTheoMaVaTen_CheckedChanged);
            // 
            // rButtonTimTheoNgay
            // 
            this.rButtonTimTheoNgay.AutoSize = true;
            this.rButtonTimTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonTimTheoNgay.ForeColor = System.Drawing.Color.SteelBlue;
            this.rButtonTimTheoNgay.Location = new System.Drawing.Point(26, 255);
            this.rButtonTimTheoNgay.Name = "rButtonTimTheoNgay";
            this.rButtonTimTheoNgay.Size = new System.Drawing.Size(209, 26);
            this.rButtonTimTheoNgay.TabIndex = 40;
            this.rButtonTimTheoNgay.TabStop = true;
            this.rButtonTimTheoNgay.Text = "Tìm kiếm theo ngày";
            this.rButtonTimTheoNgay.UseVisualStyleBackColor = true;
            this.rButtonTimTheoNgay.CheckedChanged += new System.EventHandler(this.rButtonTimTheoNgay_CheckedChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.FlatAppearance.BorderSize = 2;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTimKiem.Image = global::QuanLyKhoHang.Properties.Resources.btnTimKiem;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(174, 332);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(157, 50);
            this.btnTimKiem.TabIndex = 41;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatAppearance.BorderSize = 2;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLuu.Image = global::QuanLyKhoHang.Properties.Resources.btnLuu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(26, 390);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(142, 50);
            this.btnLuu.TabIndex = 38;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderSize = 2;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSua.Image = global::QuanLyKhoHang.Properties.Resources.btnSua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(26, 332);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(142, 50);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderSize = 2;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.IndianRed;
            this.btnXoa.Image = global::QuanLyKhoHang.Properties.Resources.btnXoa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(174, 390);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(157, 50);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa phiếu";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnQuayRa
            // 
            this.btnQuayRa.FlatAppearance.BorderSize = 2;
            this.btnQuayRa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayRa.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnQuayRa.Image = global::QuanLyKhoHang.Properties.Resources.btnQuayLai;
            this.btnQuayRa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayRa.Location = new System.Drawing.Point(848, 12);
            this.btnQuayRa.Name = "btnQuayRa";
            this.btnQuayRa.Size = new System.Drawing.Size(144, 50);
            this.btnQuayRa.TabIndex = 27;
            this.btnQuayRa.Text = "Quay ra";
            this.btnQuayRa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuayRa.UseVisualStyleBackColor = true;
            this.btnQuayRa.Click += new System.EventHandler(this.btnQuayRa_Click);
            // 
            // lbMaPhieu
            // 
            this.lbMaPhieu.AutoSize = true;
            this.lbMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieu.ForeColor = System.Drawing.Color.IndianRed;
            this.lbMaPhieu.Location = new System.Drawing.Point(174, 453);
            this.lbMaPhieu.Name = "lbMaPhieu";
            this.lbMaPhieu.Size = new System.Drawing.Size(0, 22);
            this.lbMaPhieu.TabIndex = 42;
            // 
            // FrmDanhSachPhieuNhap_Xuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 705);
            this.ControlBox = false;
            this.Controls.Add(this.lbMaPhieu);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.rButtonTimTheoNgay);
            this.Controls.Add(this.rButtonTimTheoMaVaTen);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.labelMaPhieu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dateTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lbChiTietPhieu);
            this.Controls.Add(this.dgvChiTietPhieu);
            this.Controls.Add(this.dgvDSPhieu);
            this.Controls.Add(this.btnQuayRa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDanhSachPhieuNhap_Xuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách phiếu - Team06";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDanhSachPhieu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateLapPhieu;
        private System.Windows.Forms.Button btnQuayRa;
        private System.Windows.Forms.DataGridView dgvDSPhieu;
        private System.Windows.Forms.DataGridView dgvChiTietPhieu;
        private System.Windows.Forms.Label lbChiTietPhieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DateTimePicker dateTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label labelMaPhieu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cbboxNhanVien;
        private System.Windows.Forms.RadioButton rButtonTimTheoMaVaTen;
        private System.Windows.Forms.RadioButton rButtonTimTheoNgay;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lbMaPhieu;
    }
}