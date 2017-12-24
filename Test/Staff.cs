using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.DAO_Controller_;

namespace Test
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            LoadStaffList();
            dtpNgaysinh.MaxDate = DateTime.Now.AddDays(1);
            DefaultDisableControls(false);
        }
        #region methods
        void LoadStaffList()
        {
            dtgvNhanvien.DataSource = StaffDAO.Instance.LoadStaffList();
        }
        void InsertStaff()
        {
            string manv = txtManhanvien.Text;
            string tennv = txtTennhanvien.Text;
            string diachi = txtDiachi.Text;
            DateTime ngaysinh = DateTime.Parse(dtpNgaysinh.Value.ToShortDateString());
            string dienthoai = txtSodienthoai.Text.ToString();
            if (StaffDAO.Instance.InsertStaff(manv,tennv, diachi, dienthoai, ngaysinh))
            {
                MessageBox.Show("Thêm thông tin khách hàng thành cồng", "Thông Báo");
                DefaultDisableControls(true);
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông Báo");
        }
        void UpdateStaff()
        {
            string manv = dtgvNhanvien.CurrentRow.Cells[0].Value.ToString();
            string tennv = txtTennhanvien.Text;
            string diachi = txtDiachi.Text;
            DateTime ngaysinh = dtpNgaysinh.Value;
            string dienthoai = txtSodienthoai.Text.ToString();
            if (StaffDAO.Instance.UpdateStaff(manv, tennv, diachi, dienthoai, ngaysinh))
            {
                MessageBox.Show("Thông tin được sửa thành công", "Thông Báo");
                DefaultDisableControls(true);
                LoadStaffList();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông Báo");
        }
        void DeleteStaff()
        {
            string manv = dtgvNhanvien.CurrentRow.Cells[0].Value.ToString();
            if (StaffDAO.Instance.DeleteStaff(manv))
            {
                MessageBox.Show("Thông tin đã được xóa! ", "Thông Báo");
                ClearText();
                LoadStaffList();
                StaffBinding();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông Báo");
        }
        void DefaultDisableControls(bool tag)
        {

            ClearText();
            StaffBinding();
            txtManhanvien.Enabled = tag;
            txtDiachi.Enabled = tag;
            txtSodienthoai.Enabled = tag;
            txtTennhanvien.Enabled = tag;
            dtpNgaysinh.Enabled = tag;
            btnLuu.Enabled = tag;
            btnHuy.Enabled = tag;
            dtpNgaysinh.Enabled = tag;
            btnLuu.Enabled = tag;
            btnHuy.Enabled = tag;
            dtgvNhanvien.Enabled = !tag;
            btnTimkiem.Enabled = !tag;
            txtTimkiem.Enabled = !tag;
            btnXoa.Enabled = !tag;
            btnThem.Enabled = !tag;
            btnSua.Enabled = !tag;
        }
        void ClearText()
        {
            txtManhanvien.Clear();
            txtDiachi.Clear();
            txtSodienthoai.Clear();
            txtTennhanvien.Clear();
            dtpNgaysinh.Value = DateTime.Now;
        }
        void StaffBinding()
        {
            txtManhanvien.DataBindings.Clear();
            txtDiachi.DataBindings.Clear();
            txtTennhanvien.DataBindings.Clear();
            txtSodienthoai.DataBindings.Clear();
            dtpNgaysinh.DataBindings.Clear();
            txtManhanvien.DataBindings.Add("Text", dtgvNhanvien.DataSource, "MaNV", true, DataSourceUpdateMode.Never);
            txtDiachi.DataBindings.Add("Text", dtgvNhanvien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never);
            txtTennhanvien.DataBindings.Add("Text", dtgvNhanvien.DataSource, "TenNV", true, DataSourceUpdateMode.Never);
            txtSodienthoai.DataBindings.Add("Text", dtgvNhanvien.DataSource, "DienThoai", true, DataSourceUpdateMode.Never);
            dtpNgaysinh.DataBindings.Add("Text", dtgvNhanvien.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never);
        }
        #endregion methods
        #region events
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            DefaultDisableControls(true);
            btnThem.Enabled = true;
            ClearText();
            dtgvNhanvien.Enabled = false;
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteStaff();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            
            DefaultDisableControls(true);
            btnSua.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtManhanvien.Text=="" || txtTennhanvien.Text == "" || dtpNgaysinh.Value >= DateTime.Now || txtSodienthoai.Text == "" || txtDiachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ! ", "Thông Báo");
                txtManhanvien.Focus();
            }
            else
            {
                if (btnThem.Enabled == false)
                {
                    UpdateStaff();
                }
                else if (btnSua.Enabled == false)
                {
                    InsertStaff();
                    dtgvNhanvien.Enabled = false;
                }
                DefaultDisableControls(false);
                LoadStaffList();
                
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DefaultDisableControls(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtManhanvien_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtManhanvien.Text.Trim()))
            {
                MessageBox.Show("Vui lòng mã nhân viên ! ", "Thông Báo");
                txtManhanvien.Focus();
            }
        }

        private void txtTennhanvien_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTennhanvien.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên! ", "Thông Báo");
                txtTennhanvien.Focus();
            }
        }

        private void dtpNgaysinh_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtpNgaysinh.Text.Trim()) || dtpNgaysinh.Value
                 >= DateTime.Now)
            {
                MessageBox.Show("Vui lòng nhập ngày sinh! ", "Thông Báo");
                dtpNgaysinh.Focus();
            }
        }

        private void txtDiachi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiachi.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ ! ", "Thông Báo");
                txtDiachi.Focus();
            }
        }

        private void txtSodienthoai_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSodienthoai.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại! ", "Thông Báo");
                txtSodienthoai.Focus();
            }
        }

        private void txtSodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& char.MaxValue == '\uffffff'*/)
            {
                e.Handled = true;
            }
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimkiem.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm !", "Thông Báo");
            }
            else
            {
                string search = txtTimkiem.Text;
                var id = StaffDAO.Instance.GetStaffByID(search);
                //var phone = StaffDAO.Instance.GetCustomerByPhone(search);
                if (id.Rows.Count > 0)
                {
                    dtgvNhanvien.DataSource = id;
                }
                //else if (phone.Rows.Count > 0)
                //{
                //    dtgvKhachhang.DataSource = phone;
                //}
                else
                {
                    var phone = StaffDAO.Instance.GetStaffByPhone(search);
                    if (phone.Rows.Count > 0)
                    {
                        dtgvNhanvien.DataSource = phone;
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng không tồn tại!", "Thông Báo");
                        txtTimkiem.Focus();
                    }
                }
            }
        }

        #endregion events
    }
}
