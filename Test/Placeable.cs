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
            DefaultText(false);
            LoadPlaceableList();
        }
#region methods
        void LoadPlaceableList()
        {
            dtgvDdtq.DataSource = PlaceableDAO.Instance.LoadPlaceableList();
        }
        void DefaultText(bool tag)
        {
            ClearText();
            txtMadd.Enabled = tag;
            txtDienthoai.Enabled = tag;
            txtTendiem.Enabled = tag;
            cbxDiemdungchan.Enabled = tag;
            btnHuy.Enabled = tag;
            btnLuu.Enabled = tag;
            btnXoa.Enabled = !tag;
            btnThem.Enabled = !tag;
            btnSua.Enabled = !tag;
           
        }
        void DefaultTextAfter()
        {
            dtgvDdtq.Enabled = false;
            DefaultText(true);
        }
        void ClearText()
        {
            txtDienthoai.Clear();
            txtMadd.Clear();
            txtDienthoai.Clear();
            txtTendiem.Clear();
        }
#endregion methods
#region events
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMadd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMadd.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập mã địa điểm ! ", "Thông Báo");
                txtMadd.Focus();
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

        private void txtDienthoai_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDienthoai.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại ! ", "Thông Báo");
                txtDienthoai.Focus();
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
        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion events

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            DefaultTextAfter();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            DefaultTextAfter();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //if (btnThem.Enabled == false)
            //{
            //    SuaDiaDiem();
            //}
            //else if (btnSua.Enabled == false)
            //{
            //    ThemDiaDiem();
            //}
            DefaultText(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DefaultText(false); 
        }
    }
}
