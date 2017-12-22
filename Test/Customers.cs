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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();

            DefaultDisableControls(false);
        }
        #region methods
        void LoadCustomersList()
        {
            dtgvKhachhang.DataSource = CustomerDAO.Instance.LoadCustomer();
        }
        void InsertCustomer()
        {
            string tenkh = txtTenkh.Text;
            string diachi = txtDiachi.Text;
            DateTime ngaysinh = dtpNgaysinh.Value;
            string dienthoai = txtSodienthoai.Text.ToString();
            if (CustomerDAO.Instance.InsertCustomer(tenkh, diachi, dienthoai, ngaysinh))
            {
                MessageBox.Show("Thêm thông tin khách hàng thành cồng", "Thông Báo");
                DefaultDisableControls(true);
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông Báo");
        }
        void UpdateCustomer()
        {

        }
        void DeleteCustomer() { }
        void DefaultDisableControls(bool tag)
        {
            LoadCustomersList();
            ClearText();
            CustomerBinding();
            txtDiachi.Enabled = tag;
            txtSodienthoai.Enabled = tag;
            txtTenkh.Enabled = tag;
            btnLuu.Enabled = tag;
            btnHuy.Enabled = tag;
            dtpNgaysinh.Enabled = tag;
            btnLuu.Enabled = tag;
            btnHuy.Enabled = tag;
            btnXoa.Enabled = !tag;
            btnThem.Enabled = !tag;
            btnSua.Enabled = !tag;
        }
        void ClearText()
        {
            txtDiachi.Clear();
            txtSodienthoai.Clear();
            txtTenkh.Clear();
            dtpNgaysinh.Value = DateTime.Now;
        }
        void CustomerBinding()
        {
            txtDiachi.DataBindings.Clear();
            txtTenkh.DataBindings.Clear();
            txtSodienthoai.DataBindings.Clear();
            dtpNgaysinh.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dtgvKhachhang.DataSource, "DiaChi", true, DataSourceUpdateMode.Never);
            txtTenkh.DataBindings.Add("Text", dtgvKhachhang.DataSource, "TenKH", true, DataSourceUpdateMode.Never);
            txtSodienthoai.DataBindings.Add("Text", dtgvKhachhang.DataSource, "DienThoai", true, DataSourceUpdateMode.Never);
            dtpNgaysinh.DataBindings.Add("Text", dtgvKhachhang.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never);
        }
        #endregion methods
        #region events
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            DefaultDisableControls(true);
            ClearText();
            dtgvKhachhang.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int makh = Int32.Parse(dtgvKhachhang.CurrentRow.Cells[0].Value.ToString());
            if (CustomerDAO.Instance.DeleteCustomer(makh))
            {
                MessageBox.Show("Bạn có chắc muốn xóa ? ", "Thông Báo", MessageBoxButtons.OKCancel);
                ClearText();
                LoadCustomersList();
                CustomerBinding();
            }
            else
                MessageBox.Show("Có lỗi xảy ra!", "Thông Báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DefaultDisableControls(true);
            btnSua.Enabled = true;
        
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnSua.Enabled == true)
            {
                UpdateCustomer();
            }
            else if (btnThem.Enabled == true)
            {
                InsertCustomer();
                dtgvKhachhang.Enabled = true;
            }
            DefaultDisableControls(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DefaultDisableControls(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region leave events
      
        private void txtTenkh_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenkh.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng! ", "Thông Báo");
                txtTenkh.Focus();
            }
        }

        private void txtDiachi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiachi.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ! ", "Thông Báo");
                txtDiachi.Focus();
            }
        }
        private void txtSodienthoai_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSodienthoai.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số diện thoại! ", "Thông Báo");
                txtSodienthoai.Focus();
            }
        }
        private void dtpNgaysinh_Leave(object sender, EventArgs e)
        {
            if(dtpNgaysinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ ", "Thông Báo");
                dtpNgaysinh.Focus();
            }
        }
        #endregion leave 
        #region keypress events
        private void txtSodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion keypress events

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimkiem.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập mà khách hàng trước khi tìm kiếm!", "Thông Báo");
            }
            else
            { 
            int makh = Int32.Parse(txtTimkiem.Text);
            var dt = CustomerDAO.Instance.GetCustomerByID(makh);
            if (dt.Rows.Count > 0)
            {
                dtgvKhachhang.DataSource = dt;
            }else
            {
                MessageBox.Show("Khách hàng không tồn tại!", "Thông Báo");
                txtTimkiem.Focus();
            }
            }
        }
        private void txtTimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
#endregion
}
