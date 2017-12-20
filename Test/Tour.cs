using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.DAO;
using Test.DTO_Model_;

namespace Test
{
    public partial class Tour : Form
    {
        public Tour()
        {
            InitializeComponent();
            LoadQuy();
            LoadListTour();
            DefaultControl();
            LoadTrangThai();

        }
        #region
        void DefaultControl()
        {
            TourBinding();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThoat.Enabled = true;
            txtMatour.Enabled = false;
            txtHanhtrinh.Enabled = false;
            txtLotrinh.Enabled = false;
            txtDadangky.Enabled = false;
            txtGiatour.Enabled = false;
            cbxMaquy.Enabled = false;
            cbxTrangthai.Enabled = false;
            dtgvTour.Enabled = true;

        }
         void ClearText()
        {
            txtMatour.Clear();
            txtHanhtrinh.Clear();
            txtLotrinh.Clear();
            txtDadangky.Clear();
            txtGiatour.Clear();
            cbxMaquy.Text = "";
        }

        void EnableText()
        {
            txtMatour.Enabled = true;
            txtHanhtrinh.Enabled = true;
            txtLotrinh.Enabled = true;
            txtDadangky.Enabled = true;
            txtGiatour.Enabled = true;
            cbxMaquy.Enabled = true;
        }
        void EnableButton()
        {
            if (btnThem.Enabled == true)
            {
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnHuy.Enabled = true;
            }
            else if (btnSua.Enabled == true)
            {
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = true;
            }
        }
        void LoadListTour()
        {
            dtgvTour.DataSource = TourDAO.Instance.GetListTour();

        }
        void LoadQuy()
        {
            cbxMaquy.DataSource = TourDAO.Instance.LoadListQuy();
            cbxMaquy.DisplayMember = "MaQuy";
            cbxMaquy.ValueMember = "MaQuy";

        }
        /// <summary>
        /// Tạo đối tượng danh sách TrangThai để load lên và dễ dàng thao tác khi thêm xóa sửa;
        /// </summary>
        void LoadTrangThai()
        {
            cbxTrangthai.DataSource = TourDAO.Instance.LoadListTrangThai();
            cbxTrangthai.DisplayMember = "TrangThai";
            cbxTrangthai.ValueMember = "MaTrangThai";
            cbxTrangthai.SelectedValue = 1;
        }
        void TourBinding()
        {
            //Xóa dữ liệu control đang nắm sau đó binding lại dữ liệu mới 
            txtMatour.DataBindings.Clear();
            txtHanhtrinh.DataBindings.Clear();
            txtLotrinh.DataBindings.Clear();
            txtGiatour.DataBindings.Clear();
            txtDadangky.DataBindings.Clear();
            cbxTrangthai.DataBindings.Clear();
            cbxMaquy.DataBindings.Clear();
            //true là chấp nhận ép kiểu cho txtMatour va Matour khi 2 thuộc tính không giống kiểu, DataSourceUpdateMode.Never là giá trị không thể thay đổi khi load focus từ textbox đang focus sang textbox khác hoặc thay đổi giá trị ngay khi nhập giá trị khác tại đối tượng textbox
            txtMatour.DataBindings.Add("Text", dtgvTour.DataSource, "Matour", true, DataSourceUpdateMode.Never);
            txtHanhtrinh.DataBindings.Add("Text", dtgvTour.DataSource, "HanhTrinh", true, DataSourceUpdateMode.Never);
            txtLotrinh.DataBindings.Add("Text", dtgvTour.DataSource, "LoTrinh", true, DataSourceUpdateMode.Never);
            txtGiatour.DataBindings.Add("Text",dtgvTour.DataSource,"Giatour",true,DataSourceUpdateMode.Never);
            txtDadangky.DataBindings.Add("Text",dtgvTour.DataSource,"Soluonghientai",true,DataSourceUpdateMode.Never);
            cbxMaquy.DataBindings.Add("Text", dtgvTour.DataSource, "MaQuy", true, DataSourceUpdateMode.Never);
            cbxTrangthai.DataBindings.Add("Text", dtgvTour.DataSource, "TrangThai", true, DataSourceUpdateMode.Never);
        }
        void ThemTour()
        {       
                string matour = txtMatour.Text;
                string hanhtrinh = txtHanhtrinh.Text;
                string lotrinh = txtLotrinh.Text;
                float giatour = (float)Convert.ToDouble(txtGiatour.Text); 
                int maquy = Int32.Parse(cbxMaquy.Text);
                int trangthai = Int32.Parse(cbxTrangthai.SelectedValue.ToString());
                int dadangky = !string.IsNullOrEmpty(txtDadangky.Text)?Int32.Parse(txtDadangky.Text) : 0;
                if (TourDAO.Instance.InsertTour(matour, hanhtrinh, lotrinh, giatour, maquy, trangthai, dadangky))
                   {
                     MessageBox.Show("Thêm tour thành công", "Thông báo");
                   }
                else
                   {
                    MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
                     txtMatour.Focus();
                   }  
            }
        void SuaTour()
        {
            string matour = txtMatour.Text;
            string hanhtrinh = txtHanhtrinh.Text;
            string lotrinh = txtLotrinh.Text;
            float giatour = (float)Convert.ToDouble(txtGiatour.Text);
            int maquy = Int32.Parse(cbxMaquy.Text);
            int matrangthai = Int32.Parse(cbxTrangthai.SelectedValue.ToString());
            int dadangky = Int32.Parse(txtDadangky.Text);
            if (TourDAO.Instance.UpdateTour(matour, hanhtrinh, lotrinh,giatour,maquy, matrangthai, dadangky))
            {
                MessageBox.Show("Thông tin tour được sửa thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
                txtMatour.Focus();
            }
        }
      
        #endregion
        #region events
        private void btnThem_Click(object sender, EventArgs e)
        {

            cbxTrangthai.DataBindings.Clear();
            cbxTrangthai.SelectedIndex = 0;
            btnSua.Enabled = false;
            dtgvTour.Enabled = false;
            cbxTrangthai.Enabled = false;
            EnableButton();
            ClearText();
            EnableText();

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string matour = dtgvTour.CurrentRow.Cells[0].Value.ToString();
            if (TourDAO.Instance.DeleteTour(matour))
            {
                MessageBox.Show("Bạn có chắc muốn xóa ? ", "Thông Báo", MessageBoxButtons.OKCancel);
                ClearText();
                LoadListTour();
            }
            else
                MessageBox.Show("Có lỗi xảy ra!", "Thông Báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            btnThem.Enabled = false;
            EnableButton();
            EnableText();
            cbxTrangthai.Enabled = true;
            txtMatour.Enabled = false;

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMatour.Text == "" || txtLotrinh.Text == "" || txtHanhtrinh.Text == "" || txtGiatour.Text == "" || txtDadangky.Text == "" || cbxMaquy.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ! ","Thông Báo");
                txtMatour.Focus();
            }
            else
            {
                if (btnSua.Enabled == false)
                {
                    ThemTour();
                }
                else if (btnThem.Enabled == false)
                {
                    SuaTour();
                }
                LoadListTour();
                DefaultControl();
            }
         
        }
        /// <summary>
        /// Khi Hủy thì Load lại dtgvTour và set lại DefaultControl sau đó clear toàn bộ TextControl để trả về trạng thái Default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadListTour();
            DefaultControl();
            ClearText();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Nếu tồn tại chuỗi trong control với sự kiện KeyPress thì handle lại và không cho nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGiatour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Nếu tồn tại chuỗi trong control với sự kiện KeyPress thì handle lại và không cho nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDadangky_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Không được để trống và không được trùng với TourID khi change focus 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMatour_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatour.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập mã tour ! ", "Thông Báo");
                txtMatour.Focus();
            }
            if(TourDAO.Instance.GetMaTour(txtMatour.Text))
            {
                MessageBox.Show("Mã tour đã tồn tại", "Thông Báo");
                txtMatour.Focus();
            } 
        }
        /// <summary>
        /// Không được để trống khi change focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGiatour_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGiatour.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập giá tour! ", "Thông Báo");
            }
        }
        /// <summary>
        /// Không được để trống khi change focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxMaquy_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxMaquy.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn quý ! ", "Thông Báo");
                cbxMaquy.Focus();
            }
        }
        /// <summary>
        /// Không được để trống khi change focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtHanhtrinh_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHanhtrinh.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập hành trình ! ", "Thông Báo");
                txtHanhtrinh.Focus();
            }
        }
        /// <summary>
        /// Không được để trống khi change focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLotrinh_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLotrinh.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập lộ trình! ", "Thông Báo");
                txtLotrinh.Focus();
            }
        }

        private void cbxTrangthai_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = true;
        }

        private void cbxMaquy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
    #endregion


}
