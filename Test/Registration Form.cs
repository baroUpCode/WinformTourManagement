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
using Test.DAO_Controller_;
using Test.DTO_Model_;

namespace Test
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
            DefaultDisableControls(false);
            
            LoadListViewTour();
        }
        #region methods
        void LoadListViewTour()
        {
            //ColumnHeader col = new ColumnHeader();
            //col.Text = "Mã Tour";
            //col.Width = 50;
            //ColumnHeader col1 = new ColumnHeader();
            //col1.Text = "Hành trình";
            //col1.Width =70;
            //ColumnHeader col2 = new ColumnHeader();
            //col2.Text = "Lộ trình";
            //col2.Width = 80;
            //ColumnHeader col3 = new ColumnHeader();
            //col3.Text = "Giá tour";
            //col3.Width = 50;
            //listvTourdachon.Columns.Add(col);
            //listvTourdachon.Columns.Add(col1);
            //listvTourdachon.Columns.Add(col2);
            //listvTourdachon.Columns.Add(col3);
        }
        void LoadComboboxTour()
        {
            cbxTour.DataSource = TourDAO.Instance.LoadTourListDTO();
            cbxTour.DisplayMember = "LoTrinh";
            cbxTour.ValueMember = "MaTour";
        }
        void DefaultDisableControls(bool tag)
        {
            ClearText();
            LoadComboboxTour();
            btnXoatour.Enabled = tag;
            btnHuy.Enabled = tag;
            dtpNgaysinh.Enabled = tag;
            btnThemtour.Enabled = !tag;
            dtpNgaysinh.MaxDate = DateTime.Now.AddDays(-1);
        }
        void ClearText()
        {
            txtMaphieu.Clear();
            cbxTour.SelectedText="";
            txtSoluong.Clear();
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
        }        //void RegistrationBinding()
        //{
        //    //DataRelation cho cbx va datagridview
        //    //Binding cho khach hang
        //    txtTenkh.DataBindings.Clear();
        //    txtDiachi.DataBindings.Clear();
        //    dtpNgaysinh.DataBindings.Clear();
        //    txtSodienthoai.DataBindings.Clear();
        //    txtTenkh.DataBindings.Add("Text", dtgvKhachhang.DataSource, "TenKH", true, DataSourceUpdateMode.Never);
        //    txtDiachi.DataBindings.Add("Text", dtgvKhachhang.DataSource, "DiaChi", true, DataSourceUpdateMode.Never);
        //    dtpNgaysinh.DataBindings.Add("Text", dtgvKhachhang.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never);
        //    txtSodienthoai.DataBindings.Add("Text", dtgvKhachhang.DataSource, "DienThoai", true, DataSourceUpdateMode.Never);

        //}
       DataTable LoadTourByMaTour(string id )
        {
            var dt = TourDAO.Instance.GetTourByID(id);

            return dt;
        }
        #endregion methods
        #region events
            //Bat dau code tu nut them, xme xet xu ly như thế nào ?
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DefaultDisableControls(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSoluong.MaxLength = 2;
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion events

        private void txtSodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSodienthoai.MaxLength = 12;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtpNgaysinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            dtpNgaysinh.MaxDate = DateTime.Now.AddDays(-1);
        }
        /// <summary>
        /// Tìm kiếm thông tin khách hàng bằng id hoặc số điện thoại
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
                string search = txtTimkiem.Text;
                var id = CustomerDAO.Instance.GetCustomerByID(search);
                if (id.Rows.Count > 0)
                {
                    dtgvKhachhang.DataSource = id;
                }
                else
                {
                    var phone = CustomerDAO.Instance.GetCustomerByPhone(search);
                    if (phone.Rows.Count > 0)
                    {
                        dtgvKhachhang.DataSource = phone;
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng không tồn tại!", "Thông Báo");
                        txtTimkiem.Focus();
                    }
                }
                CustomerBinding();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DefaultDisableControls(true);
            ClearText();
            dtgvKhachhang.Enabled = false;
        }
        void ShowRegisDetails(string id )
        {
            //list dang nam danh sach cac tour cua id(mapdk)
            List<RegisterFormDetailsDTO> list = RegisterFormDetailsDAO.Instance.GetRegisDetailsByID(id);
            foreach (RegisterFormDetailsDTO item in list)
            {
                ListViewItem lst = new ListViewItem(item.MaTour.ToString());
                lst.SubItems.Add(item.LoTrinh.ToString());
                lst.SubItems.Add(item.HanhTrinh.ToString());
                lst.SubItems.Add(item.SoLuong.ToString());
                lst.SubItems.Add(item.GiaTour.ToString());
            }
           x

        }
        private void btnThemtour_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Nếu giá trị trong combobox thay đổi thì gán về cho datgridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lấy item trong đối tượng combobox trong sender
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedItem ==null)
                return;
            //tạo đối tượng TourDTO để lấy thông tin Item đang được chọn trong combobox
            TourDTO selected = cb.SelectedItem as TourDTO;
            //lấy MaTour bằng biến id và truyền về hàm
            string id = selected.MaTour;
            var dt = LoadTourByMaTour(id);
            dtgvTour.DataSource = dt;
        }
    }
}
