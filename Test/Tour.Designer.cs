﻿namespace Test
{
    partial class Tour
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
            this.txtHanhtrinh = new System.Windows.Forms.TextBox();
            this.txtMatour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLotrinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Giatour = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDadangky = new System.Windows.Forms.TextBox();
            this.txtGiatour = new System.Windows.Forms.TextBox();
            this.cbxTrangthai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgaydi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpNgayve = new System.Windows.Forms.DateTimePicker();
            this.dtgvTour = new System.Windows.Forms.DataGridView();
            this.cbxDiemdungchan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemdtq = new System.Windows.Forms.Button();
            this.dtgvThongtindtq = new System.Windows.Forms.DataGridView();
            this.dtgvDtqdachon = new System.Windows.Forms.DataGridView();
            this.btnXoadtq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongtindtq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDtqdachon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHanhtrinh
            // 
            this.txtHanhtrinh.Location = new System.Drawing.Point(169, 66);
            this.txtHanhtrinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtHanhtrinh.Name = "txtHanhtrinh";
            this.txtHanhtrinh.Size = new System.Drawing.Size(265, 22);
            this.txtHanhtrinh.TabIndex = 48;
            // 
            // txtMatour
            // 
            this.txtMatour.Location = new System.Drawing.Point(169, 33);
            this.txtMatour.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatour.Name = "txtMatour";
            this.txtMatour.Size = new System.Drawing.Size(265, 22);
            this.txtMatour.TabIndex = 47;
            this.txtMatour.TextChanged += new System.EventHandler(this.txtMatour_TextChanged);
            this.txtMatour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatour_KeyPress);
            this.txtMatour.Leave += new System.EventHandler(this.txtMatour_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Hành Trình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Lộ Trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Mã Tour";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(711, 202);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 41;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(564, 202);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 28);
            this.btnHuy.TabIndex = 40;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(429, 202);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 28);
            this.btnLuu.TabIndex = 39;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(297, 202);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(169, 202);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(29, 202);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "THÔNG TIN TOUR";
            // 
            // txtLotrinh
            // 
            this.txtLotrinh.Location = new System.Drawing.Point(169, 110);
            this.txtLotrinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtLotrinh.Name = "txtLotrinh";
            this.txtLotrinh.Size = new System.Drawing.Size(265, 22);
            this.txtLotrinh.TabIndex = 49;
            this.txtLotrinh.Leave += new System.EventHandler(this.txtLotrinh_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 50;
            // 
            // Giatour
            // 
            this.Giatour.AutoSize = true;
            this.Giatour.Location = new System.Drawing.Point(465, 31);
            this.Giatour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Giatour.Name = "Giatour";
            this.Giatour.Size = new System.Drawing.Size(64, 17);
            this.Giatour.TabIndex = 52;
            this.Giatour.Text = "Giá Tour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Trạng thái Tour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Số lượng hiện tại";
            // 
            // txtDadangky
            // 
            this.txtDadangky.Location = new System.Drawing.Point(579, 107);
            this.txtDadangky.Margin = new System.Windows.Forms.Padding(4);
            this.txtDadangky.Name = "txtDadangky";
            this.txtDadangky.Size = new System.Drawing.Size(231, 22);
            this.txtDadangky.TabIndex = 55;
            this.txtDadangky.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDadangky_KeyPress);
            this.txtDadangky.Validated += new System.EventHandler(this.txtDadangky_Validated);
            // 
            // txtGiatour
            // 
            this.txtGiatour.Location = new System.Drawing.Point(579, 28);
            this.txtGiatour.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiatour.Name = "txtGiatour";
            this.txtGiatour.Size = new System.Drawing.Size(231, 22);
            this.txtGiatour.TabIndex = 58;
            this.txtGiatour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiatour_KeyPress);
            this.txtGiatour.Leave += new System.EventHandler(this.txtGiatour_Leave);
            // 
            // cbxTrangthai
            // 
            this.cbxTrangthai.FormattingEnabled = true;
            this.cbxTrangthai.Location = new System.Drawing.Point(579, 66);
            this.cbxTrangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTrangthai.Name = "cbxTrangthai";
            this.cbxTrangthai.Size = new System.Drawing.Size(231, 24);
            this.cbxTrangthai.TabIndex = 59;
            this.cbxTrangthai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxTrangthai_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 156);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 61;
            this.label9.Text = "Ngày đi";
            // 
            // dtpNgaydi
            // 
            this.dtpNgaydi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaydi.Location = new System.Drawing.Point(169, 151);
            this.dtpNgaydi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaydi.Name = "dtpNgaydi";
            this.dtpNgaydi.Size = new System.Drawing.Size(265, 22);
            this.dtpNgaydi.TabIndex = 62;
            this.dtpNgaydi.Leave += new System.EventHandler(this.dtpNgaydi_Leave);
            this.dtpNgaydi.Validated += new System.EventHandler(this.dtpNgaydi_Validated);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(464, 156);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 63;
            this.label10.Text = "Ngày về";
            // 
            // dtpNgayve
            // 
            this.dtpNgayve.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayve.Location = new System.Drawing.Point(579, 151);
            this.dtpNgayve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayve.Name = "dtpNgayve";
            this.dtpNgayve.Size = new System.Drawing.Size(231, 22);
            this.dtpNgayve.TabIndex = 64;
            this.dtpNgayve.Leave += new System.EventHandler(this.dtpNgayve_Leave);
            this.dtpNgayve.Validated += new System.EventHandler(this.dtpNgayve_Validated);
            // 
            // dtgvTour
            // 
            this.dtgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTour.Location = new System.Drawing.Point(31, 242);
            this.dtgvTour.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvTour.Name = "dtgvTour";
            this.dtgvTour.Size = new System.Drawing.Size(887, 209);
            this.dtgvTour.TabIndex = 65;
            // 
            // cbxDiemdungchan
            // 
            this.cbxDiemdungchan.FormattingEnabled = true;
            this.cbxDiemdungchan.Location = new System.Drawing.Point(1045, 26);
            this.cbxDiemdungchan.Name = "cbxDiemdungchan";
            this.cbxDiemdungchan.Size = new System.Drawing.Size(268, 24);
            this.cbxDiemdungchan.TabIndex = 67;
            this.cbxDiemdungchan.SelectedIndexChanged += new System.EventHandler(this.cbxDiemdungchan_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(923, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "Điểm dừng chân ";
            // 
            // btnThemdtq
            // 
            this.btnThemdtq.Location = new System.Drawing.Point(1002, 189);
            this.btnThemdtq.Name = "btnThemdtq";
            this.btnThemdtq.Size = new System.Drawing.Size(130, 46);
            this.btnThemdtq.TabIndex = 70;
            this.btnThemdtq.Text = "Thêm điểm tham quan";
            this.btnThemdtq.UseVisualStyleBackColor = true;
            this.btnThemdtq.Click += new System.EventHandler(this.btnThemdtq_Click);
            // 
            // dtgvThongtindtq
            // 
            this.dtgvThongtindtq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongtindtq.Location = new System.Drawing.Point(926, 57);
            this.dtgvThongtindtq.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvThongtindtq.Name = "dtgvThongtindtq";
            this.dtgvThongtindtq.Size = new System.Drawing.Size(387, 124);
            this.dtgvThongtindtq.TabIndex = 71;
            // 
            // dtgvDtqdachon
            // 
            this.dtgvDtqdachon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDtqdachon.Location = new System.Drawing.Point(926, 242);
            this.dtgvDtqdachon.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDtqdachon.Name = "dtgvDtqdachon";
            this.dtgvDtqdachon.Size = new System.Drawing.Size(387, 209);
            this.dtgvDtqdachon.TabIndex = 72;
            // 
            // btnXoadtq
            // 
            this.btnXoadtq.Location = new System.Drawing.Point(1150, 188);
            this.btnXoadtq.Name = "btnXoadtq";
            this.btnXoadtq.Size = new System.Drawing.Size(130, 46);
            this.btnXoadtq.TabIndex = 73;
            this.btnXoadtq.Text = "Xóa điêm tham quan";
            this.btnXoadtq.UseVisualStyleBackColor = true;
            this.btnXoadtq.Click += new System.EventHandler(this.btnXoadtq_Click);
            // 
            // Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 457);
            this.Controls.Add(this.btnXoadtq);
            this.Controls.Add(this.dtgvDtqdachon);
            this.Controls.Add(this.dtgvThongtindtq);
            this.Controls.Add(this.btnThemdtq);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxDiemdungchan);
            this.Controls.Add(this.dtgvTour);
            this.Controls.Add(this.dtpNgayve);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpNgaydi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxTrangthai);
            this.Controls.Add(this.txtGiatour);
            this.Controls.Add(this.txtDadangky);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Giatour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLotrinh);
            this.Controls.Add(this.txtHanhtrinh);
            this.Controls.Add(this.txtMatour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tour";
            this.Text = "Tour";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongtindtq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDtqdachon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHanhtrinh;
        private System.Windows.Forms.TextBox txtMatour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLotrinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Giatour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDadangky;
        private System.Windows.Forms.TextBox txtGiatour;
        private System.Windows.Forms.ComboBox cbxTrangthai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNgaydi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgayve;
        private System.Windows.Forms.DataGridView dtgvTour;
        private System.Windows.Forms.ComboBox cbxDiemdungchan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemdtq;
        private System.Windows.Forms.DataGridView dtgvThongtindtq;
        private System.Windows.Forms.DataGridView dtgvDtqdachon;
        private System.Windows.Forms.Button btnXoadtq;
    }
}

