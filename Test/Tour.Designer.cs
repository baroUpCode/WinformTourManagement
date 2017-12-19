namespace Test
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
            this.dtgvTour = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLotrinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Giatour = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDadangky = new System.Windows.Forms.TextBox();
            this.txtGiatour = new System.Windows.Forms.TextBox();
            this.cbxTrangthai = new System.Windows.Forms.ComboBox();
            this.cbxMaquy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTour)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHanhtrinh
            // 
            this.txtHanhtrinh.Location = new System.Drawing.Point(169, 66);
            this.txtHanhtrinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtHanhtrinh.Name = "txtHanhtrinh";
            this.txtHanhtrinh.Size = new System.Drawing.Size(265, 22);
            this.txtHanhtrinh.TabIndex = 48;
            this.txtHanhtrinh.Leave += new System.EventHandler(this.txtHanhtrinh_Leave);
            // 
            // txtMatour
            // 
            this.txtMatour.Location = new System.Drawing.Point(169, 33);
            this.txtMatour.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatour.Name = "txtMatour";
            this.txtMatour.Size = new System.Drawing.Size(265, 22);
            this.txtMatour.TabIndex = 47;
            this.txtMatour.Leave += new System.EventHandler(this.txtMatour_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Hành Trình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Lộ Trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Mã Tour";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(780, 202);
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
            this.btnHuy.Location = new System.Drawing.Point(638, 202);
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
            this.btnLuu.Location = new System.Drawing.Point(488, 202);
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
            this.btnSua.Location = new System.Drawing.Point(334, 202);
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
            this.btnXoa.Location = new System.Drawing.Point(190, 202);
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
            // dtgvTour
            // 
            this.dtgvTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvTour.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTour.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvTour.Location = new System.Drawing.Point(0, 249);
            this.dtgvTour.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvTour.Name = "dtgvTour";
            this.dtgvTour.Size = new System.Drawing.Size(895, 161);
            this.dtgvTour.TabIndex = 35;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Mã quý";
            // 
            // Giatour
            // 
            this.Giatour.AutoSize = true;
            this.Giatour.Location = new System.Drawing.Point(26, 146);
            this.Giatour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Giatour.Name = "Giatour";
            this.Giatour.Size = new System.Drawing.Size(64, 17);
            this.Giatour.TabIndex = 52;
            this.Giatour.Text = "Giá Tour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(553, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Trạng thái Tour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(553, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Đã đăng ký";
            // 
            // txtDadangky
            // 
            this.txtDadangky.Location = new System.Drawing.Point(719, 105);
            this.txtDadangky.Margin = new System.Windows.Forms.Padding(4);
            this.txtDadangky.Name = "txtDadangky";
            this.txtDadangky.Size = new System.Drawing.Size(161, 22);
            this.txtDadangky.TabIndex = 55;
            this.txtDadangky.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDadangky_KeyPress);
            // 
            // txtGiatour
            // 
            this.txtGiatour.Location = new System.Drawing.Point(169, 146);
            this.txtGiatour.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiatour.Name = "txtGiatour";
            this.txtGiatour.Size = new System.Drawing.Size(265, 22);
            this.txtGiatour.TabIndex = 58;
            this.txtGiatour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiatour_KeyPress);
            this.txtGiatour.Leave += new System.EventHandler(this.txtGiatour_Leave);
            // 
            // cbxTrangthai
            // 
            this.cbxTrangthai.FormattingEnabled = true;
            this.cbxTrangthai.Location = new System.Drawing.Point(719, 64);
            this.cbxTrangthai.Name = "cbxTrangthai";
            this.cbxTrangthai.Size = new System.Drawing.Size(161, 24);
            this.cbxTrangthai.TabIndex = 59;
            // 
            // cbxMaquy
            // 
            this.cbxMaquy.FormattingEnabled = true;
            this.cbxMaquy.Location = new System.Drawing.Point(719, 26);
            this.cbxMaquy.Name = "cbxMaquy";
            this.cbxMaquy.Size = new System.Drawing.Size(161, 24);
            this.cbxMaquy.TabIndex = 60;
            this.cbxMaquy.Leave += new System.EventHandler(this.cbxMaquy_Leave);
            // 
            // Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 410);
            this.Controls.Add(this.cbxMaquy);
            this.Controls.Add(this.cbxTrangthai);
            this.Controls.Add(this.txtGiatour);
            this.Controls.Add(this.txtDadangky);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Giatour);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.dtgvTour);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tour";
            this.Text = "Tour";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTour)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgvTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLotrinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Giatour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDadangky;
        private System.Windows.Forms.TextBox txtGiatour;
        private System.Windows.Forms.ComboBox cbxTrangthai;
        private System.Windows.Forms.ComboBox cbxMaquy;
    }
}

