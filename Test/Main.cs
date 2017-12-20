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
using Test.DTO_Model_;

namespace Test
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadTour();
        }

        private void tourTool_Click(object sender, EventArgs e)
        {
            Tour t = new Tour();
            t.ShowDialog();
        }
        private void CTPDKTool_Click(object sender, EventArgs e)
        {
            Registration_Form__Details ct = new Registration_Form__Details();
            ct.Show();
        }
        private void DDTQTool_Click_1(object sender, EventArgs e)
        {
            Placeable pl = new Placeable();
            pl.Show();
        }

        private void NhanVienTool_Click_1(object sender, EventArgs e)
        {
            Staff st = new Staff();
            st.Show();
        }

        private void DangKyTool_Click_1(object sender, EventArgs e)
        {
            Registration_Form re = new Registration_Form();
            re.Show();
        }

        private void CTPDKTool_Click_1(object sender, EventArgs e)
        {
            Registration_Form__Details ct = new Registration_Form__Details();
            ct.Show();
        }

        private void QLKhachTool_Click_1(object sender, EventArgs e)
        {
       
            Customers cus = new Customers();
            cus.Show();
        
        }

        private void TinhTool_Click_1(object sender, EventArgs e)
        {
        
            The_Stop stop = new The_Stop();
            stop.Show();
        
        }

        private void KhachSanTool_Click_1(object sender, EventArgs e)
        {
        
            Hotel hotel = new Hotel();
            hotel.Show();
        

        }

        private void DichVuTool_Click_1(object sender, EventArgs e)
        {
       
            Service se = new Service();
            se.Show();
        

        }

        private void KhuyenMaiTool_Click_1(object sender, EventArgs e)
        {
        
            Seasioning_Prices KM = new Seasioning_Prices();
            KM.Show();
        
        }
        void LoadTour()
        {
            //Tạo một biến danh sách đối tượng Tour để lưu lại các Tour có trong DB
            List<TourDTO> tour = TourDAO.Instance.LoadTourList();
            //Duyệt qua danh sách và mỗi tour tạo một button 
            foreach (TourDTO item in tour)
            {
                Button btn = new Button() { Width = TourDAO.WidthTour,Height=TourDAO.HeightTour};
                btn.Text = item.LoTrinh + Environment.NewLine + "("+item.HanhTrinh+")";
                flpMain.Controls.Add(btn);
            }
        }

    }
}
