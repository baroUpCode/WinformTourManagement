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
    public partial class Placeable : Form
    {
        public Placeable()
        {
            InitializeComponent();
            LoadCbxDiemdungchan();
            LoadPlaceableList();
            DefaultDisableControls(false);
            
        }
#region methods
        void LoadPlaceableList()
        {
            dtgvDdtq.DataSource = PlaceableDAO.Instance.LoadPlaceableList();
        }
        void LoadCbxDiemdungchan()
        {
            cbxDiemdungchan.DataSource = TheStopDAO.Instance.LoadTheStopList();
            cbxDiemdungchan.DisplayMember = "TenDiem";
            cbxDiemdungchan.ValueMember = "MaDiemDung";
        }
        //void DefaultText(bool tag)
        //{
        //    ClearText();
        //    txtMadtq.Enabled = tag;
        //    txtDiachi.Enabled = tag;
        //    txtTendiem.Enabled = tag;
        //    cbxDiemdungchan.Enabled = tag;
        //    btnHuy.Enabled = tag;
        //    btnLuu.Enabled = tag;
        //    btnXoa.Enabled = !tag;
        //    btnThem.Enabled = !tag;
        //    btnSua.Enabled = !tag;

        //}
        void DefaultDisableControls(bool tag)
        {

            ClearText();
            DataBinding();
            txtDiachi.Enabled = tag;
            txtMadtq.Enabled = tag;
            txtTendiem.Enabled = tag;
            btnLuu.Enabled = tag;
            btnHuy.Enabled = tag;
            cbxDiemdungchan.Enabled = tag;
            //btnTimkiem.Enabled = !tag;
            //txtTimkiem.Enabled = !tag;
            btnXoa.Enabled = !tag;
            btnThem.Enabled = !tag;
            btnSua.Enabled = !tag;
        }
        //void DefaultTextAfter()
        //{
        //    dtgvDdtq.Enabled = false;
        //    DefaultText(true);
        //}
        void ClearText()
        {
            txtDiachi.Clear();
            txtMadtq.Clear();
            cbxDiemdungchan.SelectedValue = "";
            txtTendiem.Clear();
        }
        void InsertPlaceable()
        {
            string madtq = txtMadtq.Text;
            string madiemdung = cbxDiemdungchan.SelectedValue.ToString();
            string diachi = txtDiachi.Text;
            string tendtq = txtTendiem.Text;
            if(PlaceableDAO.Instance.InsertPlaceable(madtq.ToUpper(), madiemdung, diachi, tendtq)){
                MessageBox.Show("Thêm điểm tham quan thành công!");
                DefaultDisableControls(false);
                LoadPlaceableList();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra !","Thông Báo");
                txtMadtq.Focus();
            }
        }
        void UpdatePlaceable()
        {
            string madtq = txtMadtq.Text;
            string madiemdung = cbxDiemdungchan.SelectedValue.ToString();
            string diachi = txtDiachi.Text;
            string tendtq = txtTendiem.Text;
            if (PlaceableDAO.Instance.UpdatePlaceable(madtq, madiemdung, diachi, tendtq))
            {
                MessageBox.Show("Thông tin được sửa thành công ! ");
                DefaultDisableControls(false);
                LoadPlaceableList();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra !", "Thông Báo");
                txtMadtq.Focus();
            }
        }
        void DeletePlaceable()
        {
            string madtq = dtgvDdtq.CurrentRow.Cells[0].Value.ToString();
            if (PlaceableDAO.Instance.DeletePlaceable(madtq))
            {
                MessageBox.Show("Thông tin đã được xóa!");
                LoadPlaceableList();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra !", "Thông Báo");
            }
        }
        void DataBinding()
        {
            txtMadtq.DataBindings.Clear();
            txtTendiem.DataBindings.Clear();
            txtDiachi.DataBindings.Clear();
            cbxDiemdungchan.DataBindings.Clear();
            txtMadtq.DataBindings.Add("Text",dtgvDdtq.DataSource,"MaDTQ",true,DataSourceUpdateMode.Never);
            txtTendiem.DataBindings.Add("Text", dtgvDdtq.DataSource, "TenDTQ", true, DataSourceUpdateMode.Never);
            txtDiachi.DataBindings.Add("Text", dtgvDdtq.DataSource, "DiaChi", true, DataSourceUpdateMode.Never);
            cbxDiemdungchan.DataBindings.Add("Text", dtgvDdtq.DataSource, "TenDiem", true, DataSourceUpdateMode.Never);
        }
        #endregion methods
        #region events
        private void btnThoat_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void txtMadd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMadtq.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập mã địa điểm ! ", "Thông Báo");
                txtMadtq.Focus();
            }
        }

        private void txtTendiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTendiem.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên địa điểm ! ", "Thông Báo");
                txtTendiem.Focus();
            }
        }
        private void cbxDiemdungchan_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxDiemdungchan.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn điểm dừng chân ! ", "Thông Báo");
                cbxDiemdungchan.Focus();
            }
        }
        #endregion events

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            DefaultDisableControls(true);
            ClearText();
            btnThem.Enabled = true;
            dtgvDdtq.Enabled = false;
            
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
                UpdatePlaceable();
            }
            else if (btnThem.Enabled ==true)
            {
                
                InsertPlaceable();
            }
            DefaultDisableControls(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DefaultDisableControls(false); 
        }

        private void txtDiachi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiachi.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ ! ", "Thông Báo");
                txtDiachi.Focus();
            }
        }

        private void txtMadd_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMadtq.MaxLength = 5;
        }
    }
}
