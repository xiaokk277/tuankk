
namespace ThucHanhLTHSK
{
    partial class FormSinhVien
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
            this.components = new System.ComponentModel.Container();
            this.cbMaLopHC = new System.Windows.Forms.ComboBox();
            this.lbMaLopHC = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoaBo = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbSoDienThoai = new System.Windows.Forms.TextBox();
            this.tbTenSV = new System.Windows.Forms.TextBox();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSoDienThoai = new System.Windows.Forms.Label();
            this.lbHoTenSV = new System.Windows.Forms.Label();
            this.tbMaSV = new System.Windows.Forms.TextBox();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.lbThongTinSV = new System.Windows.Forms.Label();
            this.lbGiangVien = new System.Windows.Forms.Label();
            this.tbGiangVien = new System.Windows.Forms.TextBox();
            this.qUANLYGIANGDAY2DataSet = new ThucHanhLTHSK.QUANLYGIANGDAY2DataSet();
            this.qUANLYGIANGDAY2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYGIANGDAY2DataSet1 = new ThucHanhLTHSK.QUANLYGIANGDAY2DataSet1();
            this.qUANLYGIANGDAY2DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.sMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGIANGDAY2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGIANGDAY2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGIANGDAY2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGIANGDAY2DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMaLopHC
            // 
            this.cbMaLopHC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbMaLopHC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMaLopHC.FormattingEnabled = true;
            this.cbMaLopHC.Location = new System.Drawing.Point(221, 310);
            this.cbMaLopHC.Name = "cbMaLopHC";
            this.cbMaLopHC.Size = new System.Drawing.Size(395, 24);
            this.cbMaLopHC.TabIndex = 50;
            this.cbMaLopHC.SelectedIndexChanged += new System.EventHandler(this.cbMaLopHC_SelectedIndexChanged);
            this.cbMaLopHC.Validating += new System.ComponentModel.CancelEventHandler(this.cbMaLopHC_Validating);
            // 
            // lbMaLopHC
            // 
            this.lbMaLopHC.AutoSize = true;
            this.lbMaLopHC.Location = new System.Drawing.Point(26, 313);
            this.lbMaLopHC.Name = "lbMaLopHC";
            this.lbMaLopHC.Size = new System.Drawing.Size(73, 17);
            this.lbMaLopHC.TabIndex = 48;
            this.lbMaLopHC.Text = "Mã lớp HC";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.OrangeRed;
            this.btnTimKiem.Location = new System.Drawing.Point(672, 220);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(102, 34);
            this.btnTimKiem.TabIndex = 46;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoaBo
            // 
            this.btnXoaBo.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoaBo.Location = new System.Drawing.Point(672, 175);
            this.btnXoaBo.Name = "btnXoaBo";
            this.btnXoaBo.Size = new System.Drawing.Size(102, 36);
            this.btnXoaBo.TabIndex = 45;
            this.btnXoaBo.Text = "Xóa bỏ";
            this.btnXoaBo.UseVisualStyleBackColor = false;
            this.btnXoaBo.Click += new System.EventHandler(this.btnXoaBo_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.OrangeRed;
            this.btnChinhSua.Location = new System.Drawing.Point(672, 132);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(102, 37);
            this.btnChinhSua.TabIndex = 44;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBoQua.Location = new System.Drawing.Point(672, 84);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(102, 41);
            this.btnBoQua.TabIndex = 43;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThem.Enabled = false;
            this.btnThem.Location = new System.Drawing.Point(672, 39);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 39);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(326, 275);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(47, 21);
            this.rbtnNu.TabIndex = 41;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(221, 275);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(58, 21);
            this.rbtnNam.TabIndex = 40;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(221, 181);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(395, 22);
            this.tbDiaChi.TabIndex = 38;
            // 
            // tbSoDienThoai
            // 
            this.tbSoDienThoai.Location = new System.Drawing.Point(221, 139);
            this.tbSoDienThoai.Name = "tbSoDienThoai";
            this.tbSoDienThoai.Size = new System.Drawing.Size(395, 22);
            this.tbSoDienThoai.TabIndex = 37;
            this.tbSoDienThoai.TextChanged += new System.EventHandler(this.tbSoDienThoai_TextChanged);
            this.tbSoDienThoai.Validating += new System.ComponentModel.CancelEventHandler(this.tbSoDienThoai_Validating);
            // 
            // tbTenSV
            // 
            this.tbTenSV.Location = new System.Drawing.Point(221, 92);
            this.tbTenSV.Name = "tbTenSV";
            this.tbTenSV.Size = new System.Drawing.Size(395, 22);
            this.tbTenSV.TabIndex = 36;
            this.tbTenSV.Validating += new System.ComponentModel.CancelEventHandler(this.tbTenSV_Validating);
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(28, 275);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(60, 17);
            this.lbGioiTinh.TabIndex = 35;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(28, 227);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(71, 17);
            this.lbNgaySinh.TabIndex = 34;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(29, 181);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(51, 17);
            this.lbDiaChi.TabIndex = 33;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // lbSoDienThoai
            // 
            this.lbSoDienThoai.AutoSize = true;
            this.lbSoDienThoai.Location = new System.Drawing.Point(29, 139);
            this.lbSoDienThoai.Name = "lbSoDienThoai";
            this.lbSoDienThoai.Size = new System.Drawing.Size(91, 17);
            this.lbSoDienThoai.TabIndex = 32;
            this.lbSoDienThoai.Text = "Số điện thoại";
            // 
            // lbHoTenSV
            // 
            this.lbHoTenSV.AutoSize = true;
            this.lbHoTenSV.Location = new System.Drawing.Point(29, 92);
            this.lbHoTenSV.Name = "lbHoTenSV";
            this.lbHoTenSV.Size = new System.Drawing.Size(110, 17);
            this.lbHoTenSV.TabIndex = 31;
            this.lbHoTenSV.Text = "Họ tên sinh viên";
            // 
            // tbMaSV
            // 
            this.tbMaSV.Location = new System.Drawing.Point(221, 47);
            this.tbMaSV.Name = "tbMaSV";
            this.tbMaSV.Size = new System.Drawing.Size(395, 22);
            this.tbMaSV.TabIndex = 30;
            this.tbMaSV.TextChanged += new System.EventHandler(this.tbMaSV_TextChanged);
            this.tbMaSV.Validating += new System.ComponentModel.CancelEventHandler(this.tbMaSV_Validating);
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Location = new System.Drawing.Point(29, 50);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(87, 17);
            this.lbMaSV.TabIndex = 29;
            this.lbMaSV.Text = "Mã sinh viên";
            // 
            // lbThongTinSV
            // 
            this.lbThongTinSV.AutoSize = true;
            this.lbThongTinSV.Location = new System.Drawing.Point(29, 9);
            this.lbThongTinSV.Name = "lbThongTinSV";
            this.lbThongTinSV.Size = new System.Drawing.Size(128, 17);
            this.lbThongTinSV.TabIndex = 56;
            this.lbThongTinSV.Text = "Thông tin sinh viên";
            // 
            // lbGiangVien
            // 
            this.lbGiangVien.AutoSize = true;
            this.lbGiangVien.Location = new System.Drawing.Point(26, 350);
            this.lbGiangVien.Name = "lbGiangVien";
            this.lbGiangVien.Size = new System.Drawing.Size(76, 17);
            this.lbGiangVien.TabIndex = 57;
            this.lbGiangVien.Text = "Giảng viên";
            // 
            // tbGiangVien
            // 
            this.tbGiangVien.Location = new System.Drawing.Point(221, 347);
            this.tbGiangVien.Name = "tbGiangVien";
            this.tbGiangVien.Size = new System.Drawing.Size(395, 22);
            this.tbGiangVien.TabIndex = 58;
            // 
            // qUANLYGIANGDAY2DataSet
            // 
            this.qUANLYGIANGDAY2DataSet.DataSetName = "QUANLYGIANGDAY2DataSet";
            this.qUANLYGIANGDAY2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qUANLYGIANGDAY2DataSetBindingSource
            // 
            this.qUANLYGIANGDAY2DataSetBindingSource.DataSource = this.qUANLYGIANGDAY2DataSet;
            this.qUANLYGIANGDAY2DataSetBindingSource.Position = 0;
            // 
            // qUANLYGIANGDAY2DataSet1
            // 
            this.qUANLYGIANGDAY2DataSet1.DataSetName = "QUANLYGIANGDAY2DataSet1";
            this.qUANLYGIANGDAY2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qUANLYGIANGDAY2DataSet1BindingSource
            // 
            this.qUANLYGIANGDAY2DataSet1BindingSource.DataSource = this.qUANLYGIANGDAY2DataSet1;
            this.qUANLYGIANGDAY2DataSet1BindingSource.Position = 0;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaSV,
            this.sTenSV});
            this.dgvSinhVien.Location = new System.Drawing.Point(-2, 375);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(807, 82);
            this.dgvSinhVien.TabIndex = 59;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // sMaSV
            // 
            this.sMaSV.DataPropertyName = "sMaSV";
            this.sMaSV.HeaderText = "Mã sinh viên";
            this.sMaSV.MinimumWidth = 6;
            this.sMaSV.Name = "sMaSV";
            // 
            // sTenSV
            // 
            this.sTenSV.DataPropertyName = "sTenSV";
            this.sTenSV.HeaderText = "Tên sinh viên";
            this.sTenSV.MinimumWidth = 6;
            this.sTenSV.Name = "sTenSV";
            // 
            // FormSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.tbGiangVien);
            this.Controls.Add(this.lbGiangVien);
            this.Controls.Add(this.lbThongTinSV);
            this.Controls.Add(this.cbMaLopHC);
            this.Controls.Add(this.lbMaLopHC);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoaBo);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.rbtnNu);
            this.Controls.Add(this.rbtnNam);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.tbSoDienThoai);
            this.Controls.Add(this.tbTenSV);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbSoDienThoai);
            this.Controls.Add(this.lbHoTenSV);
            this.Controls.Add(this.tbMaSV);
            this.Controls.Add(this.lbMaSV);
            this.Name = "FormSinhVien";
            this.Text = "FormSinhVien";
            this.Load += new System.EventHandler(this.FormSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGIANGDAY2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGIANGDAY2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGIANGDAY2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGIANGDAY2DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbMaLopHC;
        private System.Windows.Forms.Label lbMaLopHC;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoaBo;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbSoDienThoai;
        private System.Windows.Forms.TextBox tbTenSV;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbSoDienThoai;
        private System.Windows.Forms.Label lbHoTenSV;
        private System.Windows.Forms.TextBox tbMaSV;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.Label lbThongTinSV;
        private System.Windows.Forms.Label lbGiangVien;
        private System.Windows.Forms.TextBox tbGiangVien;
        private System.Windows.Forms.BindingSource qUANLYGIANGDAY2DataSetBindingSource;
        private QUANLYGIANGDAY2DataSet qUANLYGIANGDAY2DataSet;
        private System.Windows.Forms.BindingSource qUANLYGIANGDAY2DataSet1BindingSource;
        private QUANLYGIANGDAY2DataSet1 qUANLYGIANGDAY2DataSet1;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenSV;
    }
}

