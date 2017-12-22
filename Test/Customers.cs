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
            string makh = dtgvKhachhang.CurrentRow.Cells[0].Value.ToString();
            string tenkh = txtTenkh.Text;
            string diachi = txtDiachi.Text;
            DateTime ngaysinh = dtpNgaysinh.Value;
            string dienthoai = txtSodienthoai.Text.ToString();
            if (CustomerDAO.Instance.UpdateCustomer(makh,tenkh, diachi, dienthoai, ngaysinh))
            {
                MessageBox.Show("Thông tin được sửa thành công", "Thông Báo");
                DefaultDisableControls(true);
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông Báo");
        }
        void DeleteCustomer()
        {
            string makh = dtgvKhachhang.CurrentRow.Cells[0].Value.ToString();
            if (CustomerDAO.Instance.DeleteCustomer(makh))
            {
                MessageBox.Show("Bạn có chắc muốn xóa ? ", "Thông Báo", MessageBoxButtons.OKCancel);
                ClearText();
                LoadCustomersList();
                CustomerBinding();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông Báo");
        }
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
            btnTimkiem.Enabled = !tag;
            txtTimkiem.Enabled = !tag;
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
            DeleteCustomer();
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
        /// <summary>
        /// Khi click vào btnTimkiem thì sẽ lấy chuỗi được nhập từ txtTimkiem để trả về 2 hàm tìm kiếm trong CustomerDAO để procedure, nếu tìm được id hoặc số điện thoại thì sẽ hiện ra dtgv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimkiem.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập mà khách hàng trước khi tìm kiếm!", "Thông Báo");
            }
            else
            { 
                string search =txtTimkiem.Text;
                var id = CustomerDAO.Instance.GetCustomerByID(search);
                //var phone = CustomerDAO.Instance.GetCustomerByPhone(search);
                if (id.Rows.Count > 0)
                {
                    dtgvKhachhang.DataSource = id;
                }
                //else if (phone.Rows.Count > 0)
                //{
                //    dtgvKhachhang.DataSource = phone;
                //}
                else
                {
                    var phone = CustomerDAO.Instance.GetCustomerByPhone(search);
                    if (phone.Rows.Count > 0)
                    {
                        dtgvKhachhang.DataSource = phone;
                    }else
                    {
                        MessageBox.Show("Khách hàng không tồn tại!", "Thông Báo");
                        txtTimkiem.Focus();
                    }
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
