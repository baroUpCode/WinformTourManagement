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
            
        }
      
        public void LoadListTour()
        {
            dtgvTour.DataSource = TourDAO.Instance.GetListTour();
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string matour = txtMatour.Text;
            string hanhtrinh = txtHanhtrinh.Text;
            string lotrinh = txtLotrinh.Text;
            if (TourDAO.Instance.InsertTour(matour, hanhtrinh, lotrinh))
            {
                MessageBox.Show("Thêm tour thành công", "Thông báo");
                LoadListTour();
            }
            else
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
        }
    }
}
