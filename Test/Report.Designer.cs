namespace Test
{
    partial class Report
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
            this.rbtnQuy = new System.Windows.Forms.RadioButton();
            this.rbtnThang = new System.Windows.Forms.RadioButton();
            this.rbtnNgaylap = new System.Windows.Forms.RadioButton();
            this.cbxQuyThang = new System.Windows.Forms.ComboBox();
            this.dtpNgaybd = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstvThongtintour = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lotrinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soluongdangky = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.giatien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaydi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngayve = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInphieu = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgaykt = new System.Windows.Forms.DateTimePicker();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnQuy
            // 
            this.rbtnQuy.AutoSize = true;
            this.rbtnQuy.Location = new System.Drawing.Point(53, 50);
            this.rbtnQuy.Name = "rbtnQuy";
            this.rbtnQuy.Size = new System.Drawing.Size(55, 21);
            this.rbtnQuy.TabIndex = 5;
            this.rbtnQuy.TabStop = true;
            this.rbtnQuy.Text = "Quý";
            this.rbtnQuy.UseVisualStyleBackColor = true;
            this.rbtnQuy.CheckedChanged += new System.EventHandler(this.rbtnQuy_CheckedChanged);
            // 
            // rbtnThang
            // 
            this.rbtnThang.AutoSize = true;
            this.rbtnThang.Location = new System.Drawing.Point(150, 50);
            this.rbtnThang.Name = "rbtnThang";
            this.rbtnThang.Size = new System.Drawing.Size(74, 21);
            this.rbtnThang.TabIndex = 6;
            this.rbtnThang.TabStop = true;
            this.rbtnThang.Text = "Tháng ";
            this.rbtnThang.UseVisualStyleBackColor = true;
            this.rbtnThang.CheckedChanged += new System.EventHandler(this.rbtnThang_CheckedChanged);
            // 
            // rbtnNgaylap
            // 
            this.rbtnNgaylap.AutoSize = true;
            this.rbtnNgaylap.Location = new System.Drawing.Point(271, 50);
            this.rbtnNgaylap.Name = "rbtnNgaylap";
            this.rbtnNgaylap.Size = new System.Drawing.Size(124, 21);
            this.rbtnNgaylap.TabIndex = 7;
            this.rbtnNgaylap.TabStop = true;
            this.rbtnNgaylap.Text = "Ngày lập phiếu\r\n";
            this.rbtnNgaylap.UseVisualStyleBackColor = true;
            this.rbtnNgaylap.CheckedChanged += new System.EventHandler(this.rbtnNgaylap_CheckedChanged);
            // 
            // cbxQuyThang
            // 
            this.cbxQuyThang.FormattingEnabled = true;
            this.cbxQuyThang.Location = new System.Drawing.Point(53, 88);
            this.cbxQuyThang.Name = "cbxQuyThang";
            this.cbxQuyThang.Size = new System.Drawing.Size(171, 24);
            this.cbxQuyThang.TabIndex = 8;
            // 
            // dtpNgaybd
            // 
            this.dtpNgaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaybd.Location = new System.Drawing.Point(341, 86);
            this.dtpNgaybd.Name = "dtpNgaybd";
            this.dtpNgaybd.Size = new System.Drawing.Size(124, 22);
            this.dtpNgaybd.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstvThongtintour);
            this.groupBox1.Location = new System.Drawing.Point(53, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 376);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tour";
            // 
            // lstvThongtintour
            // 
            this.lstvThongtintour.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lotrinh,
            this.soluongdangky,
            this.giatien,
            this.ngaydi,
            this.ngayve});
            this.lstvThongtintour.GridLines = true;
            this.lstvThongtintour.Location = new System.Drawing.Point(7, 21);
            this.lstvThongtintour.Name = "lstvThongtintour";
            this.lstvThongtintour.Size = new System.Drawing.Size(834, 348);
            this.lstvThongtintour.TabIndex = 0;
            this.lstvThongtintour.UseCompatibleStateImageBehavior = false;
            this.lstvThongtintour.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "BÁO CÁO THỐNG KÊ";
            // 
            // lotrinh
            // 
            this.lotrinh.Text = "Lộ trình";
            this.lotrinh.Width = 150;
            // 
            // soluongdangky
            // 
            this.soluongdangky.Text = "Số lượng đăng ký";
            this.soluongdangky.Width = 130;
            // 
            // giatien
            // 
            this.giatien.Text = "Giá tour";
            this.giatien.Width = 100;
            // 
            // ngaydi
            // 
            this.ngaydi.Text = "Ngày đi";
            this.ngaydi.Width = 100;
            // 
            // ngayve
            // 
            this.ngayve.Text = "Ngày về";
            this.ngayve.Width = 100;
            // 
            // btnInphieu
            // 
            this.btnInphieu.Location = new System.Drawing.Point(60, 496);
            this.btnInphieu.Name = "btnInphieu";
            this.btnInphieu.Size = new System.Drawing.Size(124, 37);
            this.btnInphieu.TabIndex = 12;
            this.btnInphieu.Text = "In Phiếu";
            this.btnInphieu.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(681, 76);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(94, 40);
            this.btnTimkiem.TabIndex = 13;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTongtien
            // 
            this.txtTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongtien.Location = new System.Drawing.Point(647, 500);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(247, 27);
            this.txtTongtien.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tổng tiền ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Từ ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "đến";
            // 
            // dtpNgaykt
            // 
            this.dtpNgaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaykt.Location = new System.Drawing.Point(527, 86);
            this.dtpNgaykt.Name = "dtpNgaykt";
            this.dtpNgaykt.Size = new System.Drawing.Size(124, 22);
            this.dtpNgaykt.TabIndex = 18;
            this.dtpNgaykt.Validated += new System.EventHandler(this.dtpNgaykt_Validated);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(803, 76);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(97, 40);
            this.btnLammoi.TabIndex = 19;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 538);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.dtpNgaykt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnInphieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpNgaybd);
            this.Controls.Add(this.cbxQuyThang);
            this.Controls.Add(this.rbtnNgaylap);
            this.Controls.Add(this.rbtnThang);
            this.Controls.Add(this.rbtnQuy);
            this.Name = "Report";
            this.Text = "Report";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnQuy;
        private System.Windows.Forms.RadioButton rbtnThang;
        private System.Windows.Forms.RadioButton rbtnNgaylap;
        private System.Windows.Forms.ComboBox cbxQuyThang;
        private System.Windows.Forms.DateTimePicker dtpNgaybd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstvThongtintour;
        private System.Windows.Forms.ColumnHeader lotrinh;
        private System.Windows.Forms.ColumnHeader soluongdangky;
        private System.Windows.Forms.ColumnHeader giatien;
        private System.Windows.Forms.ColumnHeader ngaydi;
        private System.Windows.Forms.ColumnHeader ngayve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInphieu;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgaykt;
        private System.Windows.Forms.Button btnLammoi;
    }
}