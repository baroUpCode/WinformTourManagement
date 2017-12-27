namespace Test
{
    partial class Registration_Form
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
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTour = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaphieu = new System.Windows.Forms.TextBox();
            this.btnThemtour = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvTour = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvKhachhang = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoatour = new System.Windows.Forms.Button();
            this.grbxTourduochon = new System.Windows.Forms.GroupBox();
            this.listvTourdachon = new System.Windows.Forms.ListView();
            this.MaTour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoTrinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HanhTrinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaTour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTour)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachhang)).BeginInit();
            this.grbxTourduochon.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(93, 122);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(229, 22);
            this.txtSoluong.TabIndex = 68;
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 63;
            this.label5.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Mã Phiếu";
            // 
            // cbxTour
            // 
            this.cbxTour.FormattingEnabled = true;
            this.cbxTour.Location = new System.Drawing.Point(93, 79);
            this.cbxTour.Name = "cbxTour";
            this.cbxTour.Size = new System.Drawing.Size(229, 24);
            this.cbxTour.TabIndex = 80;
            this.cbxTour.SelectedIndexChanged += new System.EventHandler(this.cbxTour_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 81;
            this.label9.Text = "Tour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "THÔNG TIN PHIẾU ĐĂNG KÝ";
            // 
            // txtMaphieu
            // 
            this.txtMaphieu.Location = new System.Drawing.Point(93, 46);
            this.txtMaphieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaphieu.Name = "txtMaphieu";
            this.txtMaphieu.Size = new System.Drawing.Size(229, 22);
            this.txtMaphieu.TabIndex = 82;
            // 
            // btnThemtour
            // 
            this.btnThemtour.Location = new System.Drawing.Point(25, 154);
            this.btnThemtour.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemtour.Name = "btnThemtour";
            this.btnThemtour.Size = new System.Drawing.Size(100, 40);
            this.btnThemtour.TabIndex = 83;
            this.btnThemtour.Text = "Thêm Tour";
            this.btnThemtour.UseVisualStyleBackColor = true;
            this.btnThemtour.Click += new System.EventHandler(this.btnThemtour_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvTour);
            this.groupBox1.Location = new System.Drawing.Point(12, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 113);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết tour ";
            // 
            // dtgvTour
            // 
            this.dtgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTour.Location = new System.Drawing.Point(13, 21);
            this.dtgvTour.Name = "dtgvTour";
            this.dtgvTour.RowTemplate.Height = 24;
            this.dtgvTour.Size = new System.Drawing.Size(536, 86);
            this.dtgvTour.TabIndex = 91;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpNgaysinh);
            this.groupBox2.Controls.Add(this.txtSodienthoai);
            this.groupBox2.Controls.Add(this.txtDiachi);
            this.groupBox2.Controls.Add(this.txtTenkh);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(349, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 132);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinh.Location = new System.Drawing.Point(141, 71);
            this.dtpNgaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(146, 22);
            this.dtpNgaysinh.TabIndex = 61;
            this.dtpNgaysinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpNgaysinh_KeyPress);
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Location = new System.Drawing.Point(418, 71);
            this.txtSodienthoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(158, 22);
            this.txtSodienthoai.TabIndex = 60;
            this.txtSodienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSodienthoai_KeyPress);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(418, 31);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(158, 22);
            this.txtDiachi.TabIndex = 59;
            // 
            // txtTenkh
            // 
            this.txtTenkh.Location = new System.Drawing.Point(141, 31);
            this.txtTenkh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(146, 22);
            this.txtTenkh.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Ngày Sinh";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(457, 151);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 42);
            this.btnThoat.TabIndex = 88;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(349, 153);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 42);
            this.btnHuy.TabIndex = 87;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvKhachhang);
            this.groupBox3.Location = new System.Drawing.Point(575, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 294);
            this.groupBox3.TabIndex = 92;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách hàng";
            // 
            // dtgvKhachhang
            // 
            this.dtgvKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhachhang.Location = new System.Drawing.Point(14, 21);
            this.dtgvKhachhang.Name = "dtgvKhachhang";
            this.dtgvKhachhang.RowTemplate.Height = 24;
            this.dtgvKhachhang.Size = new System.Drawing.Size(459, 267);
            this.dtgvKhachhang.TabIndex = 91;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(571, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 24);
            this.label10.TabIndex = 62;
            this.label10.Text = "Tìm khách hàng";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(767, 162);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(158, 22);
            this.txtTimkiem.TabIndex = 62;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(954, 153);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(100, 41);
            this.btnTimkiem.TabIndex = 93;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(241, 153);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 42);
            this.btnThem.TabIndex = 95;
            this.btnThem.Text = "Tạo phiếu";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoatour
            // 
            this.btnXoatour.Location = new System.Drawing.Point(133, 153);
            this.btnXoatour.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoatour.Name = "btnXoatour";
            this.btnXoatour.Size = new System.Drawing.Size(100, 42);
            this.btnXoatour.TabIndex = 96;
            this.btnXoatour.Text = "Xóa Tour";
            this.btnXoatour.UseVisualStyleBackColor = true;
            // 
            // grbxTourduochon
            // 
            this.grbxTourduochon.Controls.Add(this.listvTourdachon);
            this.grbxTourduochon.Location = new System.Drawing.Point(14, 321);
            this.grbxTourduochon.Name = "grbxTourduochon";
            this.grbxTourduochon.Size = new System.Drawing.Size(553, 176);
            this.grbxTourduochon.TabIndex = 92;
            this.grbxTourduochon.TabStop = false;
            this.grbxTourduochon.Text = "Tour được chọn";
            // 
            // listvTourdachon
            // 
            this.listvTourdachon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaTour,
            this.LoTrinh,
            this.HanhTrinh,
            this.SoLuong,
            this.GiaTour});
            this.listvTourdachon.Location = new System.Drawing.Point(6, 33);
            this.listvTourdachon.Name = "listvTourdachon";
            this.listvTourdachon.Size = new System.Drawing.Size(541, 137);
            this.listvTourdachon.TabIndex = 92;
            this.listvTourdachon.UseCompatibleStateImageBehavior = false;
            // 
            // MaTour
            // 
            this.MaTour.Text = "Mã Tour";
            // 
            // LoTrinh
            // 
            this.LoTrinh.Text = "Lộ Trình";
            // 
            // HanhTrinh
            // 
            this.HanhTrinh.Text = "Hành Trình";
            // 
            // GiaTour
            // 
            this.GiaTour.DisplayIndex = 3;
            this.GiaTour.Text = "Giá Tour";
            // 
            // SoLuong
            // 
            this.SoLuong.DisplayIndex = 4;
            this.SoLuong.Text = "Số lượng";
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 510);
            this.Controls.Add(this.grbxTourduochon);
            this.Controls.Add(this.btnXoatour);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemtour);
            this.Controls.Add(this.txtMaphieu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxTour);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registration_Form";
            this.Text = "Registration_Form";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTour)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachhang)).EndInit();
            this.grbxTourduochon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaphieu;
        private System.Windows.Forms.Button btnThemtour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvTour;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvKhachhang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoatour;
        private System.Windows.Forms.GroupBox grbxTourduochon;
        private System.Windows.Forms.ListView listvTourdachon;
        private System.Windows.Forms.ColumnHeader MaTour;
        private System.Windows.Forms.ColumnHeader LoTrinh;
        private System.Windows.Forms.ColumnHeader HanhTrinh;
        private System.Windows.Forms.ColumnHeader GiaTour;
        private System.Windows.Forms.ColumnHeader SoLuong;
    }
}