
namespace QuanLyKhoHang.View
{
    partial class FrmTaoPhieuNhapXuat
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNguyenLieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbboxNhanVien = new System.Windows.Forms.ComboBox();
            this.dateLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.txtTang = new System.Windows.Forms.TextBox();
            this.txtGiam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGiam = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnQuayRa = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTongSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongNguyenLieu = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbLoaiPhieu = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(445, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 55);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(125, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo phiếu";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBox2.Controls.Add(this.txtNguyenLieu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 130);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nguyên liệu";
            // 
            // txtNguyenLieu
            // 
            this.txtNguyenLieu.BackColor = System.Drawing.SystemColors.Window;
            this.txtNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguyenLieu.ForeColor = System.Drawing.Color.Silver;
            this.txtNguyenLieu.Location = new System.Drawing.Point(72, 63);
            this.txtNguyenLieu.Name = "txtNguyenLieu";
            this.txtNguyenLieu.Size = new System.Drawing.Size(311, 28);
            this.txtNguyenLieu.TabIndex = 8;
            this.txtNguyenLieu.Text = "Nhập mã hoặc tên nguyên liệu";
            this.txtNguyenLieu.TextChanged += new System.EventHandler(this.txtNguyenLieu_TextChanged);
            this.txtNguyenLieu.Enter += new System.EventHandler(this.txtNguyenLieu_Enter);
            this.txtNguyenLieu.Leave += new System.EventHandler(this.txtNguyenLieu_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tìm kiếm nhanh nguyên liệu";
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguyenLieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvNguyenLieu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieu.Location = new System.Drawing.Point(12, 232);
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.RowHeadersVisible = false;
            this.dgvNguyenLieu.RowHeadersWidth = 62;
            this.dgvNguyenLieu.RowTemplate.Height = 28;
            this.dgvNguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguyenLieu.Size = new System.Drawing.Size(488, 356);
            this.dgvNguyenLieu.TabIndex = 11;
            this.dgvNguyenLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguyenLieu_CellClick);
            this.dgvNguyenLieu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNguyenLieu_CellFormatting);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Controls.Add(this.cbboxNhanVien);
            this.groupBox3.Controls.Add(this.dateLapPhieu);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtMaPhieu);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(605, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(657, 130);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phiếu ghi thông tin";
            // 
            // cbboxNhanVien
            // 
            this.cbboxNhanVien.BackColor = System.Drawing.SystemColors.Info;
            this.cbboxNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxNhanVien.FormattingEnabled = true;
            this.cbboxNhanVien.Location = new System.Drawing.Point(433, 27);
            this.cbboxNhanVien.Name = "cbboxNhanVien";
            this.cbboxNhanVien.Size = new System.Drawing.Size(215, 28);
            this.cbboxNhanVien.TabIndex = 20;
            // 
            // dateLapPhieu
            // 
            this.dateLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateLapPhieu.Location = new System.Drawing.Point(123, 74);
            this.dateLapPhieu.Name = "dateLapPhieu";
            this.dateLapPhieu.Size = new System.Drawing.Size(180, 26);
            this.dateLapPhieu.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nhân viên ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ngày lập ";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.BackColor = System.Drawing.Color.SkyBlue;
            this.txtMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.ForeColor = System.Drawing.Color.Firebrick;
            this.txtMaPhieu.Location = new System.Drawing.Point(123, 27);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(180, 26);
            this.txtMaPhieu.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã phiếu";
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieu.Location = new System.Drawing.Point(605, 232);
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.RowHeadersVisible = false;
            this.dgvPhieu.RowHeadersWidth = 62;
            this.dgvPhieu.RowTemplate.Height = 28;
            this.dgvPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieu.Size = new System.Drawing.Size(657, 356);
            this.dgvPhieu.TabIndex = 13;
            this.dgvPhieu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPhieu_CellFormatting);
            // 
            // txtTang
            // 
            this.txtTang.BackColor = System.Drawing.Color.White;
            this.txtTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTang.Location = new System.Drawing.Point(519, 297);
            this.txtTang.Name = "txtTang";
            this.txtTang.Size = new System.Drawing.Size(64, 26);
            this.txtTang.TabIndex = 21;
            this.txtTang.Text = "1";
            this.txtTang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGiam
            // 
            this.txtGiam.BackColor = System.Drawing.Color.White;
            this.txtGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiam.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGiam.Location = new System.Drawing.Point(519, 418);
            this.txtGiam.Name = "txtGiam";
            this.txtGiam.Size = new System.Drawing.Size(64, 26);
            this.txtGiam.TabIndex = 22;
            this.txtGiam.Text = "1";
            this.txtGiam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(516, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "S.Lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(516, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Tăng >>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.IndianRed;
            this.label10.Location = new System.Drawing.Point(516, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "<< Giảm";
            // 
            // btnGiam
            // 
            this.btnGiam.FlatAppearance.BorderSize = 2;
            this.btnGiam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiam.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGiam.Image = global::QuanLyKhoHang.Properties.Resources.btnGiamSoLuong;
            this.btnGiam.Location = new System.Drawing.Point(515, 452);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(74, 48);
            this.btnGiam.TabIndex = 20;
            this.btnGiam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // btnTang
            // 
            this.btnTang.FlatAppearance.BorderSize = 2;
            this.btnTang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTang.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTang.Image = global::QuanLyKhoHang.Properties.Resources.btnThemSoLuong;
            this.btnTang.Location = new System.Drawing.Point(515, 330);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(74, 48);
            this.btnTang.TabIndex = 19;
            this.btnTang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatAppearance.BorderSize = 2;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLuu.Image = global::QuanLyKhoHang.Properties.Resources.btnLuu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(1105, 614);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(157, 50);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu phiếu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnQuayRa
            // 
            this.btnQuayRa.FlatAppearance.BorderSize = 2;
            this.btnQuayRa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayRa.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnQuayRa.Image = global::QuanLyKhoHang.Properties.Resources.btnQuayLai;
            this.btnQuayRa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayRa.Location = new System.Drawing.Point(1118, 6);
            this.btnQuayRa.Name = "btnQuayRa";
            this.btnQuayRa.Size = new System.Drawing.Size(144, 50);
            this.btnQuayRa.TabIndex = 26;
            this.btnQuayRa.Text = "Quay ra";
            this.btnQuayRa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuayRa.UseVisualStyleBackColor = true;
            this.btnQuayRa.Click += new System.EventHandler(this.btnQuayRa_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.txtTongSoLuong);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtTongNguyenLieu);
            this.groupBox4.Location = new System.Drawing.Point(605, 599);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 75);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nguyên liệu và số lượng";
            // 
            // txtTongSoLuong
            // 
            this.txtTongSoLuong.BackColor = System.Drawing.Color.White;
            this.txtTongSoLuong.Enabled = false;
            this.txtTongSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSoLuong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTongSoLuong.Location = new System.Drawing.Point(391, 27);
            this.txtTongSoLuong.Name = "txtTongSoLuong";
            this.txtTongSoLuong.Size = new System.Drawing.Size(57, 26);
            this.txtTongSoLuong.TabIndex = 31;
            this.txtTongSoLuong.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(278, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nguyên liệu";
            // 
            // txtTongNguyenLieu
            // 
            this.txtTongNguyenLieu.BackColor = System.Drawing.Color.White;
            this.txtTongNguyenLieu.Enabled = false;
            this.txtTongNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongNguyenLieu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTongNguyenLieu.Location = new System.Drawing.Point(205, 27);
            this.txtTongNguyenLieu.Name = "txtTongNguyenLieu";
            this.txtTongNguyenLieu.Size = new System.Drawing.Size(57, 26);
            this.txtTongNguyenLieu.TabIndex = 29;
            this.txtTongNguyenLieu.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(12, 599);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(488, 75);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Lưu ý";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.IndianRed;
            this.label11.Location = new System.Drawing.Point(6, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(405, 22);
            this.label11.TabIndex = 4;
            this.label11.Text = "Kiểm tra đầy đủ thông tin trước khi lưu phiếu";
            // 
            // lbLoaiPhieu
            // 
            this.lbLoaiPhieu.AutoSize = true;
            this.lbLoaiPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiPhieu.Location = new System.Drawing.Point(18, 31);
            this.lbLoaiPhieu.Name = "lbLoaiPhieu";
            this.lbLoaiPhieu.Size = new System.Drawing.Size(115, 22);
            this.lbLoaiPhieu.TabIndex = 29;
            this.lbLoaiPhieu.Text = "Loại phiếu: ";
            // 
            // FrmTaoPhieuNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 686);
            this.ControlBox = false;
            this.Controls.Add(this.lbLoaiPhieu);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnQuayRa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGiam);
            this.Controls.Add(this.txtTang);
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.btnTang);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvPhieu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvNguyenLieu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTaoPhieuNhapXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo phiếu - Team06";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNguyenLieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNguyenLieu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateLapPhieu;
        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Windows.Forms.ComboBox cbboxNhanVien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.TextBox txtTang;
        private System.Windows.Forms.TextBox txtGiam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnQuayRa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTongSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongNguyenLieu;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbLoaiPhieu;
    }
}