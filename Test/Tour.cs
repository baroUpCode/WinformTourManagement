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
        }
        void EnableText()
        {
            txtMatour.Enabled = true;
            txtHanhtrinh.Enabled = true;
            txtLotrinh.Enabled = true;
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
        void TourBinding()
        {
            //Xóa dữ liệu control đang nắm sau đó binding lại dữ liệu mới 
            txtMatour.DataBindings.Clear();
            txtHanhtrinh.DataBindings.Clear();
            txtLotrinh.DataBindings.Clear();
            //true là chấp nhận ép kiểu cho txtMatour va Matour khi 2 thuộc tính không giống kiểu, DataSourceUpdateMode.Never là giá trị không thể thay đổi khi load focus từ textbox đang focus sang textbox khác hoặc thay đổi giá trị ngay khi nhập giá trị khác tại đối tượng textbox
            txtMatour.DataBindings.Add("Text", dtgvTour.DataSource, "Matour", true, DataSourceUpdateMode.Never);
            txtHanhtrinh.DataBindings.Add("Text", dtgvTour.DataSource, "HanhTrinh", true, DataSourceUpdateMode.Never);
            txtLotrinh.DataBindings.Add("Text", dtgvTour.DataSource, "LoTrinh", true, DataSourceUpdateMode.Never);
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
                float giatour = 0;
                int maquy = 1;
                int matrangthai=1;
                int soluonghientai = 0;
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
        public void ClearText()
        {
            txtMatour.Clear();
            txtHanhtrinh.Clear();
            txtLotrinh.Clear();
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
