using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn__dn_Click(object sender, EventArgs e)
        {
            //string connectionStr = "Data Source=LENOVO-PC/SQLEXPRESS;Initial Catalog=WFORMTOUR;Integrated Security=True";
            ////Tạo kết nối với DB bằng chuỗi kết nối được khai báo 
            //SqlConnection connection = new SqlConnection(connectionStr);
            //connection.Open();
            //string query = "select * from dbo.NhanVien";
            ////Thực thi câu truy vấn được khai báo tới DB đã kết nối từ đối tượng connection, command hiện tại đang giữ dữ liệu trả về
            ////khi truy vấn thành công
            //SqlCommand command = new SqlCommand(query, connection);
            //DataTable dt = new DataTable();
            ////Đối tượng adapter lấy dữ liệu từ comman và là trung gian để đổ dữ liệu từ command về dataTable
            ////Chuyển đổi từ sqlTable sang DataTable trên View để các đối tượng trên View có thể lấy dữ liệu và thao tác được
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //adapter.Fill(dt);
            //connection.Close();
            Main m = new Main();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình","Thông báo", MessageBoxButtons.OKCancel) !=System.Windows.Forms.DialogResult.OK)
                //e.cancel you cannot inplement the event 
                e.Cancel = true;
        }
    }
}
