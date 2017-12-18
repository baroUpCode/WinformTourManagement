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


namespace Test
{
    public partial class Tour : Form
    {
        public Tour()
        {
            InitializeComponent();
            LoadQuy();
            LoadTrangThai();
            LoadListTour();
            DefaultControl();

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

        }
         void ClearText()
        {
            txtMatour.Clear();
            txtHanhtrinh.Clear();
            txtLotrinh.Clear();
            txtDadangky.Clear();
            txtGiatour.Clear();
            cbxMaquy.Text = "";
            cbxTrangthai.Text = "";
        }

        void EnableText()
        {
            txtMatour.Enabled = true;
            txtHanhtrinh.Enabled = true;
            txtLotrinh.Enabled = true;
            txtDadangky.Enabled = true;
            txtGiatour.Enabled = true;
            cbxMaquy.Enabled = true;
            cbxTrangthai.Enabled = true;
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
        void LoadTrangThai()
        {
            cbxTrangthai.DataSource = TourDAO.Instance.LoadListTrangThai();
            cbxTrangthai.DisplayMember = "TrangThai";
            cbxTrangthai.ValueMember = "MaTrangThai";
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
            if(txtMatour.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã tour.", "Thông Báo",MessageBoxButtons.OK);
            }
            else{
                string matour = txtMatour.Text;
                string hanhtrinh = txtHanhtrinh.Text;
                string lotrinh = txtLotrinh.Text;
                float giatour = float.Parse(txtGiatour.Text);
                int maquy = Int32.Parse(cbxMaquy.Text);
                int matrangthai= Int32.Parse(cbxTrangthai.Text);
                int soluonghientai = Int32.Parse(txtDadangky.Text);
                if (TourDAO.Instance.InsertTour(matour, hanhtrinh, lotrinh,giatour,maquy,matrangthai,soluonghientai))
                {
                    MessageBox.Show("Thêm tour thành công", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
                }
            }
        }
        void SuaTour()
        {
            string matour = txtMatour.Text;
            string hanhtrinh = txtHanhtrinh.Text;
            string lotrinh = txtLotrinh.Text;
            if (TourDAO.Instance.UpdateTour(matour, hanhtrinh, lotrinh))
            {
                MessageBox.Show("Thông tin tour được sửa thành công.", "Thông báo");
                //LoadListTour();
                //DisableButton();
                //DisableText();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
            }
        }
      
        #endregion
        #region events
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
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

        }
        private void btnLuu_Click(object sender, EventArgs e)
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
        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadListTour();
            DefaultControl();
        }

        #endregion

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
