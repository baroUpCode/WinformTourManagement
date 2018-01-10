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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            txtTongtien.Enabled = false;
            lstvThongtintour.Enabled = false;
        }
        public void LoadComboboxQuy()
        {
            cbxQuyThang.DataSource = QuyDAO.Instance.GetQuy();
            cbxQuyThang.DisplayMember = "MaQuy";
            cbxQuyThang.ValueMember = "MaQuy";
        }
        void DefaultControl()
        {
            if(cbxQuyThang.Enabled== true )
            {
                dtpNgaybd.Enabled = false;
                dtpNgaykt.Enabled = false;
            }else if (cbxQuyThang.Enabled == false)
            {
                dtpNgaybd.Enabled = true;
                dtpNgaykt.Enabled = true;
            }
        }
        public void LoadComboboxThang()
        {
            int[] s = { 1,2,3,4,5,6,7,8,9,10,11,12};
            this.cbxQuyThang.DataSource = s;
        }

        private void rbtnQuy_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgaybd.Enabled = false;
            DefaultControl();
            LoadComboboxQuy();
            lstvThongtintour.Tag = "quy";
            
        }
        private void rbtnThang_CheckedChanged(object sender, EventArgs e)
        {
            cbxQuyThang.Enabled = true;
            DefaultControl();
            LoadComboboxThang();
            lstvThongtintour.Tag = "thang";

        }
        private void rbtnNgaylap_CheckedChanged(object sender, EventArgs e)
        {
            cbxQuyThang.Enabled = false;
            DefaultControl();
            lstvThongtintour.Tag = "ngaylap";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstvThongtintour.Items.Clear();
            float tt = 0;
            if (lstvThongtintour.Tag.ToString() == "thang")
            {
                var thang = Int32.Parse(cbxQuyThang.SelectedValue.ToString());
                List<TourDTO> list = TourDAO.Instance.GetTourByBeginMonth(thang);
                foreach (TourDTO item in list)
                {
                    ListViewItem lst = new ListViewItem(item.LoTrinh.ToString());
                    lst.SubItems.Add(item.SoluongHientai.ToString());
                    lst.SubItems.Add(item.GiaTour.ToString());
                    lst.SubItems.Add(item.NgayDi.ToShortDateString());
                    lst.SubItems.Add(item.NgayVe.ToShortDateString());
                    lstvThongtintour.Items.Add(lst);
                    tt += item.TongTien;
                }
               
            }
            else if (lstvThongtintour.Tag.ToString() == "quy")
            {
                var quy = Int32.Parse(cbxQuyThang.SelectedValue.ToString());
                List<TourDTO> list = TourDAO.Instance.GetTourByQuy(quy);
                foreach (TourDTO item in list)
                {
                    ListViewItem lst = new ListViewItem(item.LoTrinh.ToString());
                    lst.SubItems.Add(item.SoluongHientai.ToString());
                    lst.SubItems.Add(item.GiaTour.ToString());
                    lst.SubItems.Add(item.NgayDi.ToShortDateString());
                    lst.SubItems.Add(item.NgayVe.ToShortDateString());
                    lstvThongtintour.Items.Add(lst);
                    tt += item.TongTien;
                }
            }
            else if(lstvThongtintour.Tag.ToString()== "ngaylap")
            {
                List<TourDTO> list = TourDAO.Instance.GetTourByCreateDay(DateTime.Parse(dtpNgaybd.Value.ToShortDateString()), DateTime.Parse(dtpNgaykt.Value.ToShortDateString()));
                foreach (TourDTO item in list)
                {
                    ListViewItem lst = new ListViewItem(item.LoTrinh.ToString());
                    lst.SubItems.Add(item.SoluongHientai.ToString());
                    lst.SubItems.Add(item.GiaTour.ToString());
                    lst.SubItems.Add(item.NgayDi.ToShortDateString());
                    lst.SubItems.Add(item.NgayVe.ToShortDateString());
                    lstvThongtintour.Items.Add(lst);
                    tt += item.TongTien;
                }
            }
            txtTongtien.Text = String.Format("{0:0,0}",tt);
        }

        private void dtpNgaykt_Validated(object sender, EventArgs e)
        {
            if(dtpNgaykt.Value < dtpNgaybd.Value)
            {
                MessageBox.Show("Có lỗi xảy ra ! Vui lòng nhập lại khoảng thời gian");
                dtpNgaykt.Focus();
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            cbxQuyThang.Text = "";
            dtpNgaybd.Value = DateTime.Now;
            dtpNgaybd.Value = DateTime.Now;
            lstvThongtintour.Items.Clear();
            txtTongtien.Clear();
        }

        private void btnInphieu_Click(object sender, EventArgs e)
        {

        }
    }
}
