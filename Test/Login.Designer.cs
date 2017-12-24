namespace Test
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTendn = new System.Windows.Forms.TextBox();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.btnDn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtTendn
            // 
            this.txtTendn.Location = new System.Drawing.Point(183, 38);
            this.txtTendn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTendn.Name = "txtTendn";
            this.txtTendn.Size = new System.Drawing.Size(151, 22);
            this.txtTendn.TabIndex = 1;
            // 
            // txtMk
            // 
            this.txtMk.Location = new System.Drawing.Point(183, 96);
            this.txtMk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMk.Name = "txtMk";
            this.txtMk.PasswordChar = '*';
            this.txtMk.Size = new System.Drawing.Size(151, 22);
            this.txtMk.TabIndex = 2;
            this.txtMk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMk_KeyDown);
            // 
            // btnDn
            // 
            this.btnDn.Location = new System.Drawing.Point(72, 153);
            this.btnDn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDn.Name = "btnDn";
            this.btnDn.Size = new System.Drawing.Size(100, 28);
            this.btnDn.TabIndex = 3;
            this.btnDn.Text = "Đăng nhập";
            this.btnDn.UseVisualStyleBackColor = true;
            this.btnDn.Click += new System.EventHandler(this.btn__dn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(235, 153);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(441, 223);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDn);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.txtTendn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTendn;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.Button btnDn;
        private System.Windows.Forms.Button btnThoat;
    }
}