using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class DataProvicder
    {
        private string connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=WFORMTOUR;Integrated Security=True";
        /// <summary>
        /// Trả về đối tượng dữ liệu bảng để thao tác binding data
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public DataTable ExecuteQuery(string query,object[] parameter = null)
        { 
            DataTable dt = new DataTable();
            
            using (SqlConnection connection = new SqlConnection(connectionStr)){ 
            connection.Open();
            //Thực thi câu truy vấn được khai báo tới DB đã kết nối từ đối tượng connection, command hiện tại đang giữ dữ liệu trả về
            //khi truy vấn thành công
            SqlCommand command = new SqlCommand(query, connection);
                //Tạo một biến tạm chứa các chuỗi của câu query được chia theo khoảng trắng (' '), xét các chuỗi trong danh sách nếu c chứa '@' thì nó là biến và add vào danh sách parameters 
                //vd: query="execute dbo.Nhanvien_GetNvByID @ID = "01" ", toàn bộ câu query được add vào listPara sau đó sẽ tìm '@' để xác định biến, câu query khi khai báo cần phải có khoảng trắng giữa các chuỗi 
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach(var item in listPara)
                {
                    if(item.Contains('@'))
                    {
                        //public SqlParameter AddWithValue(string parameterName, object value);
                        //Lưu giá trị của biến được tìm thấy bằng hàm AddWithValue với hai tham số truyền vào là tên para và giá trị của đối tượng, lưu chuỗi para vào đối tượng object có index=0 
                        command.Parameters.AddWithValue(item,parameter[i]);
                        i++;
                    }
                }
            //Đối tượng adapter lấy dữ liệu từ command và là trung gian để đổ dữ liệu từ command về đối tượng datatable trên View
            //Chuyển đổi từ sqlTable sang DataTable trên View để các đối tượng trên View có thể lấy dữ liệu và thao tác được
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connection.Close();
            }
            return dt;
        }
        /// <summary>
        /// Dùng để trả về số lượng dòng thực thi query thành công khi insert, update hoặc delete
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int dt = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                //Thực thi câu truy vấn được khai báo tới DB đã kết nối từ đối tượng connection, command hiện tại đang giữ dữ liệu trả về
                //khi truy vấn thành công
                SqlCommand command = new SqlCommand(query, connection);
                //Tạo một biến tạm chứa các chuỗi của câu query được chia theo khoảng trắng (' '), xét các chuỗi trong danh sách nếu c chứa '@' thì nó là biến và add vào danh sách parameters 
                //vd: query="execute dbo.Nhanvien_GetNvByID @ID = "01" ", toàn bộ câu query được add vào listPara sau đó sẽ tìm '@' để xác định biến, câu query khi khai báo cần phải có khoảng trắng giữa các chuỗi 
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (var item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        //public SqlParameter AddWithValue(string parameterName, object value);
                        //Lưu giá trị của biến được tìm thấy bằng hàm AddWithValue với hai tham số truyền vào là tên para và giá trị của đối tượng, lưu chuỗi para vào đối tượng object có index=0 
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
                //Đối tượng adapter lấy dữ liệu từ command và là trung gian để đổ dữ liệu từ command về đối tượng datatable trên View
                //Chuyển đổi từ sqlTable sang DataTable trên View để các đối tượng trên View có thể lấy dữ liệu và thao tác được
                dt = command.ExecuteNonQuery();
                connection.Close();
            }
            return dt;
        }
        /// <summary>
        /// Trả về dòng đầu tiên của đối tượng Table được query, thường dùng để đếm số lượng đối tượng , select count * bla bla 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object dt =0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                //Thực thi câu truy vấn được khai báo tới DB đã kết nối từ đối tượng connection, command hiện tại đang giữ dữ liệu trả về
                //khi truy vấn thành công
                SqlCommand command = new SqlCommand(query, connection);
                //Tạo một biến tạm chứa các chuỗi của câu query được chia theo khoảng trắng (' '), xét các chuỗi trong danh sách nếu c chứa '@' thì nó là biến và add vào danh sách parameters 
                //vd: query="execute dbo.Nhanvien_GetNvByID @ID = "01" ", toàn bộ câu query được add vào listPara sau đó sẽ tìm '@' để xác định biến, câu query khi khai báo cần phải có khoảng trắng giữa các chuỗi 
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (var item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        //public SqlParameter AddWithValue(string parameterName, object value);
                        //Lưu giá trị của biến được tìm thấy bằng hàm AddWithValue với hai tham số truyền vào là tên para và giá trị của đối tượng, lưu chuỗi para vào đối tượng object có index=0 
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
                //Đối tượng adapter lấy dữ liệu từ command và là trung gian để đổ dữ liệu từ command về đối tượng datatable trên View
                //Chuyển đổi từ sqlTable sang DataTable trên View để các đối tượng trên View có thể lấy dữ liệu và thao tác được
                dt = command.ExecuteScalar();
                connection.Close();
            }
            return dt;
        }
    }
}
