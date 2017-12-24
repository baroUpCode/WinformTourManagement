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
    public partial class Hotel : Form
    {
        public Hotel()
        {
            InitializeComponent();
            DefaultDisableControls(false);
        }
        #region methods
        void DefaultDisableControls(bool tag)
        {
            LoadCbxDiemdung();
            LoadHotelList();
            ClearText();
            HotelBinding();
            cbxMadiem.Enabled = tag;
            txtDiachi.Enabled = tag;
            txtDienthoai.Enabled = tag;
            txtMaks.Enabled = tag;
            txtTenks.Enabled = tag;
            btnLuu.Enabled = tag;
            btnHuy.Enabled = tag;
            btnLuu.Enabled = tag;
            btnHuy.Enabled = tag;
            btnXoa.Enabled = !tag;
            btnThem.Enabled = !tag;
            btnSua.Enabled = !tag;
        
        }
        void ClearText()
        {
            cbxMadiem.SelectedText = "";
            txtDiachi.Clear();
            txtDienthoai.Clear();
            txtMaks.Clear();
            txtTenks.Clear();
        }
        void LoadHotelList()
        {
            dtgvKhachsan.DataSource = HotelDAO.Instance.LoadHotelList();
        }
        void HotelBinding()
        {
            //Clear các dữ liệu có trước đó và binding dữ liệu mới vào
            txtMaks.DataBindings.Clear();
            txtTenks.DataBindings.Clear();
            txtDiachi.DataBindings.Clear();
            txtDienthoai.DataBindings.Clear();
            cbxMadiem.DataBindings.Clear();
            //Bắt đầu binding dữ liệu mới từ dtgv vào các text box 
            txtMaks.DataBindings.Add("Text", dtgvKhachsan.DataSource, "MaKhachsan", true, DataSourceUpdateMode.Never);
            txtTenks.DataBindings.Add("Text", dtgvKhachsan.DataSource, "TenKhachsan", true, DataSourceUpdateMode.Never);
            txtDiachi.DataBindings.Add("Text", dtgvKhachsan.DataSource, "DiaChi", true, DataSourceUpdateMode.Never);
            txtDienthoai.DataBindings.Add("Text", dtgvKhachsan.DataSource, "DienThoai", true, DataSourceUpdateMode.Never);
            cbxMadiem.DataBindings.Add("Text", dtgvKhachsan.DataSource, "TenDiemdung", true, DataSourceUpdateMode.Never);
        }
        void InsertHotel()
        {
            string maks = txtMaks.Text;
            string tenks = txtTenks.Text;
            string diachi = txtDiachi.Text;
            string dienthoai = txtDienthoai.Text;
            string madiemdung = cbxMadiem.SelectedValue.ToString();
            if (HotelDAO.Instance.InsertHotel(maks.ToUpper(), tenks, dienthoai, diachi, madiemdung))
            {
                MessageBox.Show("Thêm thông tin khách hàng thành cồng", "Thông Báo");
                DefaultDisableControls(true);
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông Báo");
        }
        void UpdateHotel()
        {
            string maks = txtMaks.Text;
            string tenks = txtTenks.Text;
            string diachi = txtDiachi.Text;
            string dienthoai = txtDienthoai.Text;
            string madiemdung = cbxMadiem.SelectedValue.ToString();
            if (HotelDAO.Instance.UpdateHotel(maks,tenks, dienthoai, diachi, madiemdung))
            {
                MessageBox.Show("Thông tin được sửa thành công", "Thông Báo");
                DefaultDisableControls(true);
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông Báo");
        }
        void DeleteHotel()
        {
            string maks = dtgvKhachsan.CurrentRow.Cells[0].Value.ToString();
            if (HotelDAO.Instance.DeleteHotel(maks))
            {
                MessageBox.Show("Bạn có chắc muốn xóa ? ", "Thông Báo", MessageBoxButtons.OKCancel);
                ClearText();
                LoadHotelList();
                HotelBinding();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông Báo");
        }
        void LoadCbxDiemdung()
        {
            cbxMadiem.DataSource = HotelDAO.Instance.LoadCbxDiemDung();
            cbxMadiem.DisplayMember = "TenDiem";
            cbxMadiem.ValueMember = "MaDiemDung";
        }
        #endregion methods

        #region events
        private void txtMaks_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaks.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập mã khách sạn! ", "Thông Báo");
                txtMaks.Focus();
            }
            else if(HotelDAO.Instance.GetHotelByID(txtMaks.Text.ToUpper()).Rows.Count >= 1)
            {
                MessageBox.Show("Mã khách sạn đã tồn tại");
                txtMaks.Focus();
            }
        }
        private void txtTenks_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenks.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên khách sạn ! ", "Thông Báo");
                txtTenks.Focus();
            }
        }
        private void cbxMadiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxMadiem.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn tỉnh thành ! ", "Thông Báo");
                cbxMadiem.Focus();
            }
        }
        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDienthoai.MaxLength = 12;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDienthoai_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDienthoai.Text.Trim()) || txtDienthoai.TextLength < 1)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại! ", "Thông Báo");
                txtDienthoai.Focus();
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            DefaultDisableControls(true);
            ClearText();
            dtgvKhachsan.Enabled = false;
            btnThem.Enabled = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteHotel();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            DefaultDisableControls(true);
            txtMaks.Enabled = false;
            dtgvKhachsan.Enabled = true;
            btnSua.Enabled = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaks.Text==""||txtDiachi.Text == "" ||txtDienthoai.Text == "" || txtDiachi.Text == "" || Int32.Parse(txtDienthoai.Text) < 1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ! ", "Thông Báo");
                txtMaks.Focus();
            }else
            { 
            if (btnSua.Enabled == true)
            {
                UpdateHotel();
            }
            else if (btnThem.Enabled == true)
            {
                InsertHotel();
                dtgvKhachsan.Enabled = true;
            }
            DefaultDisableControls(false);
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
        private void txtMaks_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMaks.MaxLength = 20;

        }

    }
    #endregion events
}
