namespace Test
{
    partial class Staff
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgvNhanvien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(744, 145);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(617, 145);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 28);
            this.btnHuy.TabIndex = 22;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(482, 145);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 28);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(327, 145);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(177, 145);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(24, 145);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgvNhanvien
            // 
            this.dtgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvNhanvien.Location = new System.Drawing.Point(0, 181);
            this.dtgvNhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvNhanvien.Name = "dtgvNhanvien";
            this.dtgvNhanvien.Size = new System.Drawing.Size(889, 247);
            this.dtgvNhanvien.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tên Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Số Điện Thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Địa Chỉ";
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Location = new System.Drawing.Point(169, 36);
            this.txtManhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Size = new System.Drawing.Size(265, 22);
            this.txtManhanvien.TabIndex = 29;
            this.txtManhanvien.Leave += new System.EventHandler(this.txtManhanvien_Leave);
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Location = new System.Drawing.Point(169, 69);
            this.txtTennhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(265, 22);
            this.txtTennhanvien.TabIndex = 30;
            this.txtTennhanvien.Leave += new System.EventHandler(this.txtTennhanvien_Leave);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(603, 36);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(241, 22);
            this.txtDiachi.TabIndex = 31;
            this.txtDiachi.Leave += new System.EventHandler(this.txtDiachi_Leave);
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Location = new System.Drawing.Point(603, 74);
            this.txtSodienthoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(241, 22);
            this.txtSodienthoai.TabIndex = 32;
            this.txtSodienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSodienthoai_KeyPress);
            this.txtSodienthoai.Leave += new System.EventHandler(this.txtSodienthoai_Leave);
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinh.Location = new System.Drawing.Point(169, 108);
            this.dtpNgaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaysinh.MaxDate = new System.DateTime(2017, 12, 24, 0, 0, 0, 0);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(265, 22);
            this.dtpNgaysinh.TabIndex = 33;
            this.dtpNgaysinh.Value = new System.DateTime(2017, 12, 24, 0, 0, 0, 0);
            this.dtpNgaysinh.Leave += new System.EventHandler(this.dtpNgaysinh_Leave);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(603, 110);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(168, 22);
            this.txtTimkiem.TabIndex = 97;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(779, 108);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(65, 26);
            this.btnTimkiem.TabIndex = 99;
            this.btnTimkiem.Text = "Tìm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 100;
            this.label7.Text = "Tìm kiếm";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 428);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.txtSodienthoai);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTennhanvien);
            this.Controls.Add(this.txtManhanvien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgvNhanvien);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Staff";
            this.Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgvNhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label7;
    }
}