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
    public partial class The_Stop : Form
    {
        public The_Stop()
        {
            InitializeComponent();
            DefaultDisableControls(false);
        }
        #region methods
        void DefaultDisableControls(bool tag)
        {
            LoadTheStopList();
            ClearText();
            TheStopBinding();
            txtMadiem.Enabled = tag;
            txtTendiem.Enabled = tag;
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
            txtMadiem.Clear();
            txtTendiem.Clear();
        }
        void LoadTheStopList()
        {
            dtgvDiemdungchan.DataSource = TheStopDAO.Instance.LoadTheStopList();
        }
        void TheStopBinding()
        {
            //Clear các dữ liệu có trước đó và binding dữ liệu mới vào
            txtMadiem.DataBindings.Clear();
            txtTendiem.DataBindings.Clear();
            //Bắt đầu binding dữ liệu mới từ dtgv vào các text box 
            txtMadiem.DataBindings.Add("Text", dtgvDiemdungchan.DataSource, "MaDiemDung", true, DataSourceUpdateMode.Never);
            txtTendiem.DataBindings.Add("Text", dtgvDiemdungchan.DataSource, "TenDiem", true, DataSourceUpdateMode.Never);
        }
        void InsertTheStop()
        {
            string madiem = txtMadiem.Text;
            string tendiem = txtTendiem.Text;
            if (TheStopDAO.Instance.InsertTheStop(madiem, tendiem))
            {
                MessageBox.Show("Thêm thông tin khách hàng thành cồng", "Thông Báo");
                DefaultDisableControls(true);
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông Báo");
        }
        void UpdateHotel()
        {
            string madiem = txtMadiem.Text;
            string tendiem = txtTendiem.Text;

            if (TheStopDAO.Instance.UpdateTheStop(madiem, tendiem))
            {
                MessageBox.Show("Thông tin được sửa thành công", "Thông Báo");
                DefaultDisableControls(true);
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông Báo");
        }
        void DeleteTheStop()
        {
            string madiem = dtgvDiemdungchan.CurrentRow.Cells[0].Value.ToString();
            if (TheStopDAO.Instance.DeleteTheStop(madiem))
            {
                MessageBox.Show("Bạn có chắc muốn xóa ? ", "Thông Báo", MessageBoxButtons.OKCancel);
                ClearText();
                LoadTheStopList();
                TheStopBinding();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông Báo");
        }

        #endregion methods

        private void txtMadiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMadiem.Text))
            {
                MessageBox.Show("Vui lòng nhập mã điểm", "Thông Báo");
                txtMadiem.Focus();
            }
        }

        private void txtTendiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTendiem.Text))
            {
                MessageBox.Show("Vui lòng nhập tên điểm dừng", "Thông Báo");
                txtTendiem.Focus();
            }
        }
        #region events
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTendiem.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo");
                txtTendiem.Focus();
            }
            else if (string.IsNullOrEmpty(txtMadiem.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo");
                txtMadiem.Focus();
            }
            else
            {
                if (btnSua.Enabled == true)
                {
                    UpdateHotel();
                }
                else if (btnThem.Enabled == true)
                {
                    InsertTheStop();
                    dtgvDiemdungchan.Enabled = true;
                }
                DefaultDisableControls(false);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DefaultDisableControls(true);
            ClearText();
            dtgvDiemdungchan.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DefaultDisableControls(true);
            txtMadiem.Enabled = false;
            dtgvDiemdungchan.Enabled = true;
            btnSua.Enabled = true;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DefaultDisableControls(false);
        }
        #endregion events 
    }
}
