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
            txtMatour.Enabled = false;
            txtHanhtrinh.Enabled = false;
            txtLotrinh.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            LoadListTour();
            TourBinding();
        }
        #region
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
            txtMatour.DataBindings.Add("Text", dtgvTour.DataSource,"Matour");
            txtHanhtrinh.DataBindings.Add("Text",dtgvTour.DataSource,"HanhTrinh");
            txtLotrinh.DataBindings.Add("Text", dtgvTour.DataSource, "LoTrinh");
        }
        void ThemTour()
        {
            string matour = txtMatour.Text;
            string hanhtrinh = txtHanhtrinh.Text;
            string lotrinh = txtLotrinh.Text;
            if (TourDAO.Instance.InsertTour(matour, hanhtrinh, lotrinh))
            {
                MessageBox.Show("Thêm tour thành công", "Thông báo");
                LoadListTour();
                ClearText();
                btnXoa.Enabled = true;
                btnSua.Enabled = true;

            }
            else
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
        }
        void SuaTour()
        {
            string matour = txtMatour.Text;
            string hanhtrinh = txtHanhtrinh.Text;
            string lotrinh = txtLotrinh.Text;
            if (TourDAO.Instance.UpdateTour(matour, hanhtrinh, lotrinh))
            {
                MessageBox.Show("Thông tin tour được sửa thành công.", "Thông báo");
                LoadListTour();
                //TourBinding();
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
            }else
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
            if (btnThem.Enabled == true)
            {
                ThemTour();
            }
            else if (btnSua.Enabled == true)
            {
                SuaTour();
            }
        }

        #endregion

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearText();
        }
    }
}
