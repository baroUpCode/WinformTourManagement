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
        bool isCusbinding = false;
        public Registration_Form()
        {
            
            InitializeComponent();
            dtgvKhachhang.Enabled = false;
            btnThemtour.Enabled = false;
            btnLuu.Enabled = false;
            DefaultDisableControls(false);
        }
        #region methods
        void LoadComboboxTour()
        {
            cbxTour.DataSource = TourDAO.Instance.LoadTourListDTO();
            cbxTour.DisplayMember = "LoTrinh";
            cbxTour.ValueMember = "MaTour";
        }
        void EnableControlsAfterInsert(bool tag)
        {
            txtMaphieu.Enabled = tag;
            txtTenkh.Enabled = tag;
            dtpNgaysinh.Enabled = tag;
            txtDiachi.Enabled = tag;
            txtSodienthoai.Enabled = tag;
            dtgvKhachhang.Enabled = tag;
        }
        void DefaultDisableControls(bool tag)
        {
           
            ClearText();
            LoadComboboxTour();
            btnXoatour.Enabled = false ;
            //txtSoluong.Enabled = tag;
            dtpNgaysinh.MaxDate = DateTime.Now.AddDays(-1);
        }
        void ClearText()
        {
            txtMaphieu.Clear();
            cbxTour.SelectedItem="";
            txtSoluong.Clear();
            txtTenkh.Clear();
            dtpNgaysinh.Text = DateTime.Now.AddDays(-1).ToShortDateString();
            txtDiachi.Clear();
            txtSodienthoai.Clear();
            txtTimkiem.Clear();
            dtgvKhachhang.DataSource = null;
            dtgvKhachhang.Refresh();
            listvTourdachon.Items.Clear();
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
            isCusbinding = true;
        } 
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
            EnableControlsAfterInsert(true);
            ClearText();
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
                if (string.IsNullOrEmpty(txtMaphieu.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã phiếu đăng ký ");
                    txtMaphieu.Focus();
                }
                else { 
                txtMaphieu.Enabled = false;
                txtTenkh.Enabled = false;
                dtpNgaysinh.Enabled = false;
                txtDiachi.Enabled = false;
                txtSodienthoai.Enabled = false;
                dtgvKhachhang.Enabled = true;
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
                            CustomerBinding();
                        }
                    else
                    {
                        MessageBox.Show("Khách hàng không tồn tại!", "Thông Báo");
                        txtTimkiem.Focus();
                    }
                }
              
                }
            }
        }
      /// <summary>
      /// Khi btnThem_Click diễn ra thì bắt đầu kiểm tra điều kiện các textbox
      /// nếu thỏa thì kiểm tra xem có cần tạo mới khách hàng(customer) hay không
      /// Nếu có thì lấy dữ liệu từ textbox để tạo mới customer với id tự động tăng, sau đó lấy id lớn nhất trong DB để gán tạo pdk tour 
      /// Nếu không thì lấy dữ liệu customer có sẵn đã tìm được từ ô tìm kiếm, lấy id ở datagridview và tạo pdk tour
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaphieu.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu.");
                txtSoluong.Focus();
            }
            else if (string.IsNullOrEmpty(txtTenkh.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.");
                txtTenkh.Focus();
            }
            else if (dtpNgaysinh.Value >= DateTime.Now)
            {
                MessageBox.Show("Vui lòng nhập ngày sinh.");
                dtpNgaysinh.Focus();
            }
            else if (string.IsNullOrEmpty(txtDiachi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.");
                txtDiachi.Focus();
            }
            else if (string.IsNullOrEmpty(txtSodienthoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.");
                txtSodienthoai.Focus();
            }
            else
            {
                if (isCusbinding == false)
                {
                    string tenkh = txtTenkh.Text;
                    string diachi = txtDiachi.Text;
                    string dienthoai = txtSodienthoai.Text;
                    DateTime ngaysinh = DateTime.Parse((dtpNgaysinh.Value.ToShortDateString()));
                    if (CustomerDAO.Instance.InsertCustomer(tenkh, diachi, dienthoai, ngaysinh))
                    {
                        dtgvKhachhang.DataSource =/* CustomerDAO.Instance.GetCustomerByID(*/CustomerDAO.Instance.GetMaxID();
                        int makh = Int32.Parse(dtgvKhachhang.Rows[0].Cells[0].Value.ToString());
                        string mapdk = txtMaphieu.Text;
                        //Lỗi makh 
                        //int makh = CustomerDAO.Instance.GetMaxID();
                        if (RegisterFormDAO.Instance.InsertRegisForm(mapdk.ToUpper(), makh))
                        {
                            MessageBox.Show("Tạo phiếu đăng ký thành công,vui lòng chọn tour!");
                            EnableControlsAfterInsert(false);
                            btnThemtour.Enabled = true;
                            cbxTour.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra vui lòng thử lại !");
                            txtMaphieu.Focus();
                        }
                    }
                }
                else if (isCusbinding == true)
                {
                    string mapdk = txtMaphieu.Text;
                    int makh = Int32.Parse(dtgvKhachhang.CurrentRow.Cells[4].Value.ToString());
                    if (RegisterFormDAO.Instance.InsertRegisForm(mapdk.ToUpper(), makh))
                    {
                        MessageBox.Show("Tạo phiếu đăng ký thành công,vui lòng chọn tour!");
                        EnableControlsAfterInsert(false);
                        btnThemtour.Enabled = true;
                        cbxTour.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra vui lòng thử lại !");
                    txtMaphieu.Focus();
                }
            }
        }
        private void btnThemtour_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoluong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                txtSoluong.Focus();
            }
            else
            { 
            List<TourDTO> list = TourDAO.Instance.GetTourDTOByID(cbxTour.SelectedValue.ToString());
            foreach (TourDTO item in list)
            {
                    if(Int32.Parse(txtSoluong.Text) > (50-item.SoluongHientai))
                    {
                        MessageBox.Show("Số lượng đăng ký vượt quá số chỗ còn lại, vui lòng chọn tour khác hoặc nhập lại số lượng!");
                        txtSoluong.Focus();
                    }else if((50 - Int32.Parse(item.SoluongHientai.ToString())) <= 0  )
                        {
                        MessageBox.Show("Số lượng đăng ký vượt quá số chỗ còn lại, vui lòng chọn tour khác hoặc nhập lại số lượng!");
                        cbxTour.Focus();
                    }
                    else
                    {
                        if (RegisterFormDetailsDAO.Instance.InsertRegisFormDetails(cbxTour.SelectedValue.ToString(), txtMaphieu.Text, Int32.Parse(txtSoluong.Text)))
                        {
                            MessageBox.Show("Tour được thêm thành công");
                            ListViewItem lst = new ListViewItem(item.LoTrinh);
                        lst.SubItems.Add(item.HanhTrinh);
                        lst.SubItems.Add(item.GiaTour.ToString());
                        lst.SubItems.Add(txtSoluong.Text);
                        lst.SubItems.Add(item.NgayDi.ToShortDateString());
                        lst.SubItems.Add(item.NgayVe.ToShortDateString());
                        lst.SubItems.Add(item.MaTour);
                        listvTourdachon.Items.Add(lst);
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra vui lòng thử lại !");
                            cbxTour.Focus();
                        }
                        btnXoatour.Enabled = true;
                        txtSoluong.Clear();

                    }
                }
            }
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
            if (cb.SelectedItem == null)
                return;
            //tạo đối tượng TourDTO để lấy thông tin Item đang được chọn trong combobox
            TourDTO selected = cb.SelectedItem as TourDTO;
            //lấy MaTour bằng biến id và truyền về hàm
            string id = selected.MaTour;
            List<TourDTO> list = TourDAO.Instance.GetTourDTOByID(id);
            foreach (TourDTO item in list)
            {
                if (item.SoluongHientai >= 50 || (50-item.SoluongHientai) <=0)
                {
                    listvThongtintour.Enabled = false;
                    txtSoluong.Enabled = false;
                }
                else if (item.SoluongHientai <50) 
                {
                    listvThongtintour.Enabled = true;
                    txtSoluong.Enabled = true;
                }
                listvThongtintour.Items.Clear();
                ListViewItem lst = new ListViewItem(item.LoTrinh.ToString());
                lst.SubItems.Add(item.HanhTrinh.ToString());
                lst.SubItems.Add(item.GiaTour.ToString());
                lst.SubItems.Add((50-item.SoluongHientai).ToString());
                lst.SubItems.Add(item.NgayDi.ToShortDateString());
                lst.SubItems.Add(item.NgayVe.ToShortDateString());
                lst.SubItems.Add(item.MaTour);
                listvThongtintour.Items.Add(lst);
            }
        }

        private void txtSoluong_Leave(object sender, EventArgs e)
        {

           if (string.IsNullOrEmpty(txtSoluong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                txtSoluong.Focus();
            }
        }
        private void btnXoatour_Click(object sender, EventArgs e)
        {
            if (listvTourdachon.SelectedItems.Count == 0)
                return;
            ListViewItem item = listvTourdachon.SelectedItems[0];
            if (RegisterFormDetailsDAO.Instance.DeleteRegisFormDetails(txtMaphieu.Text, item.SubItems[6].Text)){
                MessageBox.Show("yeah ya huuuu");
                listvTourdachon.Items.Remove(item);
            }
        }
        private void txtMaphieu_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaphieu.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu.");
                txtMaphieu.Focus();
            }
        }
       

        private void btnSuatour_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            cbxTour.Enabled = false;
            btnThemtour.Enabled = false;
            listvThongtintour.Enabled = false;
            ListViewItem item = listvTourdachon.SelectedItems[0];
            txtSoluong.Text = item.SubItems[3].Text;

        }

        private void txtMaphieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMaphieu.MaxLength = 5;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ListViewItem item = listvTourdachon.SelectedItems[0];
            if (RegisterFormDetailsDAO.Instance.UpdateRegisFormDetails(item.SubItems[6].Text, txtMaphieu.Text, Int32.Parse(txtSoluong.Text)))
            {
                MessageBox.Show("Số lượng được cập nhật thành công.");
                cbxTour.Enabled = true;
                btnThemtour.Enabled = true;
                listvThongtintour.Enabled = true;
                btnLuu.Enabled = false;
            }
            LoadSelectedTourList(txtMaphieu.Text);

        }
        /// <summary>
        /// Load lại listview tour đã chọn khi đã sửa 
        /// </summary>
        /// <param name="mapdk"></param>
        void LoadSelectedTourList(string mapdk)
        {
            listvTourdachon.Items.Clear();
            List<RegisterFormDetailsDTO> dt =RegisterFormDetailsDAO.Instance.GetRegisDetailsByID(mapdk);
            foreach(RegisterFormDetailsDTO re in dt)
            {
                List<TourDTO> listtour = TourDAO.Instance.GetTourDTOByID(re.MaTour);
                foreach(TourDTO item in listtour)
                {
                    ListViewItem lst = new ListViewItem(item.LoTrinh.ToString());
                    lst.SubItems.Add(item.HanhTrinh.ToString());
                    lst.SubItems.Add(item.GiaTour.ToString());
                    lst.SubItems.Add((50 - item.SoluongHientai).ToString());
                    lst.SubItems.Add(item.NgayDi.ToShortDateString());
                    lst.SubItems.Add(item.NgayVe.ToShortDateString());
                    lst.SubItems.Add(item.MaTour);
                    listvTourdachon.Items.Add(lst);
                }
            }
        }
        #endregion events
    }
}
