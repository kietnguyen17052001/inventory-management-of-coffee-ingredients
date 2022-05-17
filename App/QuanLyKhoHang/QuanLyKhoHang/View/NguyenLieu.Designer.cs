
namespace QuanLyKhoHang.View
{
    partial class FrmNguyenLieu
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
            this.btnXemNCC = new System.Windows.Forms.Button();
            this.cbboxNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbboxKhoHang = new System.Windows.Forms.ComboBox();
            this.txtTenNguyenLieu = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtMaNguyenLieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnQuayRa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(306, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 55);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(84, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nguyên liệu";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBox2.Controls.Add(this.btnXemNCC);
            this.groupBox2.Controls.Add(this.cbboxNhaCungCap);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbboxKhoHang);
            this.groupBox2.Controls.Add(this.txtTenNguyenLieu);
            this.groupBox2.Controls.Add(this.txtDonViTinh);
            this.groupBox2.Controls.Add(this.txtMaNguyenLieu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(26, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(981, 144);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btnXemNCC
            // 
            this.btnXemNCC.FlatAppearance.BorderSize = 2;
            this.btnXemNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemNCC.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnXemNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemNCC.Location = new System.Drawing.Point(837, 100);
            this.btnXemNCC.Name = "btnXemNCC";
            this.btnXemNCC.Size = new System.Drawing.Size(129, 38);
            this.btnXemNCC.TabIndex = 21;
            this.btnXemNCC.Text = "Xem - Thêm";
            this.btnXemNCC.UseVisualStyleBackColor = true;
            this.btnXemNCC.Click += new System.EventHandler(this.btnXemNCC_Click);
            // 
            // cbboxNhaCungCap
            // 
            this.cbboxNhaCungCap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbboxNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxNhaCungCap.FormattingEnabled = true;
            this.cbboxNhaCungCap.Location = new System.Drawing.Point(598, 106);
            this.cbboxNhaCungCap.Name = "cbboxNhaCungCap";
            this.cbboxNhaCungCap.Size = new System.Drawing.Size(230, 28);
            this.cbboxNhaCungCap.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(445, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nhà C.Cấp";
            // 
            // cbboxKhoHang
            // 
            this.cbboxKhoHang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbboxKhoHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxKhoHang.FormattingEnabled = true;
            this.cbboxKhoHang.Location = new System.Drawing.Point(598, 62);
            this.cbboxKhoHang.Name = "cbboxKhoHang";
            this.cbboxKhoHang.Size = new System.Drawing.Size(230, 28);
            this.cbboxKhoHang.TabIndex = 8;
            // 
            // txtTenNguyenLieu
            // 
            this.txtTenNguyenLieu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTenNguyenLieu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(196, 64);
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(234, 26);
            this.txtTenNguyenLieu.TabIndex = 7;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.BackColor = System.Drawing.Color.White;
            this.txtDonViTinh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDonViTinh.Location = new System.Drawing.Point(598, 21);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(230, 26);
            this.txtDonViTinh.TabIndex = 6;
            // 
            // txtMaNguyenLieu
            // 
            this.txtMaNguyenLieu.BackColor = System.Drawing.Color.SkyBlue;
            this.txtMaNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNguyenLieu.ForeColor = System.Drawing.Color.Firebrick;
            this.txtMaNguyenLieu.Location = new System.Drawing.Point(196, 21);
            this.txtMaNguyenLieu.Name = "txtMaNguyenLieu";
            this.txtMaNguyenLieu.Size = new System.Drawing.Size(234, 26);
            this.txtMaNguyenLieu.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(445, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kho hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nguyên liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nguyên liệu";
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguyenLieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvNguyenLieu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieu.Location = new System.Drawing.Point(26, 312);
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.RowHeadersVisible = false;
            this.dgvNguyenLieu.RowHeadersWidth = 62;
            this.dgvNguyenLieu.RowTemplate.Height = 28;
            this.dgvNguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguyenLieu.Size = new System.Drawing.Size(966, 338);
            this.dgvNguyenLieu.TabIndex = 17;
            this.dgvNguyenLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguyenLieu_CellClick);
            this.dgvNguyenLieu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNguyenLieu_CellFormatting);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(47, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tìm kiếm nhanh";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.ForeColor = System.Drawing.Color.Silver;
            this.txtTimKiem.Location = new System.Drawing.Point(51, 280);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(425, 26);
            this.txtTimKiem.TabIndex = 20;
            this.txtTimKiem.Text = "Nhập mã, tên nguyên liệu hoặc kho hàng, nhà cung cấp";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatAppearance.BorderSize = 2;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLuu.Image = global::QuanLyKhoHang.Properties.Resources.btnLuu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(494, 222);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 50);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.FlatAppearance.BorderSize = 2;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.ForeColor = System.Drawing.Color.IndianRed;
            this.btnHuyBo.Image = global::QuanLyKhoHang.Properties.Resources.btnHuyBoChucNang;
            this.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.Location = new System.Drawing.Point(610, 222);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(197, 50);
            this.btnHuyBo.TabIndex = 22;
            this.btnHuyBo.Text = "Hủy chức năng";
            this.btnHuyBo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnQuayRa
            // 
            this.btnQuayRa.FlatAppearance.BorderSize = 2;
            this.btnQuayRa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayRa.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnQuayRa.Image = global::QuanLyKhoHang.Properties.Resources.btnQuayLai;
            this.btnQuayRa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayRa.Location = new System.Drawing.Point(863, 7);
            this.btnQuayRa.Name = "btnQuayRa";
            this.btnQuayRa.Size = new System.Drawing.Size(144, 50);
            this.btnQuayRa.TabIndex = 21;
            this.btnQuayRa.Text = "Quay ra";
            this.btnQuayRa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuayRa.UseVisualStyleBackColor = true;
            this.btnQuayRa.Click += new System.EventHandler(this.btnQuayRa_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderSize = 2;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSua.Image = global::QuanLyKhoHang.Properties.Resources.btnSua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(378, 222);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 50);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderSize = 2;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnThem.Image = global::QuanLyKhoHang.Properties.Resources.buttonThem;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(256, 222);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 50);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmNguyenLieu
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 662);
            this.ControlBox = false;
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnQuayRa);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvNguyenLieu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nguyên liệu - Team06";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbboxKhoHang;
        private System.Windows.Forms.TextBox txtTenNguyenLieu;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtMaNguyenLieu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNguyenLieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbboxNhaCungCap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXemNCC;
        private System.Windows.Forms.Button btnQuayRa;
        private System.Windows.Forms.Button btnHuyBo;
    }
}