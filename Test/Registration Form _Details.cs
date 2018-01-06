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
using Test.DTO_Model_;

namespace Test
{
    public partial class Registration_Form__Details : Form
    {
        public Registration_Form__Details()
        {
            InitializeComponent();
            btnHuyphieu.Enabled = false;
        }
        /// <summary>
        /// Tìm kiếm theo mã khách hàng và số điên thoại show ra các tour của khách hàng đó 
        /// tìm theo số điện thoại => mã khách hàng => phiếu đăng ký 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            listvThongtinpdk.Items.Clear();
            listvDiemthamquan.Items.Clear();
            List<ShowRegisDetailsTourAndCusDTO> list = RegisterFormDetailsDAO.Instance.ShowRegisDetailsTourAndCus(txtTimkiem.Text);
           
            foreach (ShowRegisDetailsTourAndCusDTO item in list)
            {
                //thong tin phieu
                ListViewItem lst = new ListViewItem(item.LoTrinh.ToString());
                lst.SubItems.Add(item.HanhTrinh.ToString());
                lst.SubItems.Add(item.NgayDi.ToShortDateString());
                lst.SubItems.Add(item.NgayVe.ToShortDateString());
                lst.SubItems.Add(item.SoluongDangky.ToString());
                lst.SubItems.Add(item.TenKH.ToString());
                lst.SubItems.Add(item.DienThoai.ToString());
                lst.SubItems.Add(item.DiaChi.ToString());
                listvThongtinpdk.Items.Add(lst);
                listvThongtinpdk.Tag = item.MaPDK;
                //thong tin diem tham quan
                List<PlaceableDTO> listplace = PlaceableDAO.Instance.LoadPlaceableListChoose(item.MaTour);
                foreach(var item1 in listplace)
                {
                    ListViewItem lst1 = new ListViewItem(item1.TenDiemThamQuan.ToString());
                    lst1.SubItems.Add(item1.DiaChi.ToString());
                    listvDiemthamquan.Items.Add(lst1);
                }
                if (item.TrangThaiPhieu == 1)
                {
                    listvThongtinpdk.ForeColor = Color.Black;
                }
                else { 
                    listvThongtinpdk.ForeColor = Color.Red;
                listvThongtinpdk.Enabled = false;
                listvDiemthamquan.Enabled = false;
                }
            }
            if(listvThongtinpdk.Items.Count > 0)
            {
                btnHuyphieu.Enabled = true;
            }
        }

        private void txtTimkiem_Validated(object sender, EventArgs e)
        {
            txtTimkiem.MaxLength = 12;
        }

        private void txtTimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            btnHuyphieu.Enabled = false;
            txtTimkiem.Clear();
            listvThongtinpdk.Enabled = true;
            listvDiemthamquan.Enabled = true;
            listvThongtinpdk.Items.Clear();
            listvDiemthamquan.Items.Clear();
        }

        private void btnHuyphieu_Click(object sender, EventArgs e)
        {
            if (RegisterFormDAO.Instance.UpdateRegisForm(listvThongtinpdk.Tag.ToString(), 2))
            {
                MessageBox.Show("Hủy phiếu thành công.");
                listvThongtinpdk.Enabled = false;
                listvDiemthamquan.Enabled = false ;
                listvThongtinpdk.ForeColor = Color.Red;
            }else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại");
            }
        }
    }
}
