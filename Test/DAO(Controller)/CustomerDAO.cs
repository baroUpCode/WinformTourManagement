using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.DTO_Model_;

namespace Test.DAO_Controller_
{
    class CustomerDAO
    {
        private CustomerDAO() { }

        private static CustomerDAO instance;
        internal static CustomerDAO Instance
        {
            get
            {
                if (instance == null) instance = new CustomerDAO();
                return CustomerDAO.instance;
            }
            private set { CustomerDAO.instance = value; }
        }
        #region methods
        /// <summary>
        /// trả dữ liệu về kiểu danh sách đối tượng để có thể thao tác dễ dàng với các trường dữ liệu trong đối tượng
        /// </summary>
        /// <returns></returns>
        public List<CustomerDTO> LoadCustomer()
        {
            string query = "select * from Khachhang";
            List<CustomerDTO> list = new List<CustomerDTO>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow r in dt.Rows)
            {
                CustomerDTO cus = new CustomerDTO(r);
                list.Add(cus);
            }
            return list;
        }
        public bool InsertCustomer(string tenkh, string diachi,string dienthoai, DateTime ngaysinh)
        {
            string query = "insert dbo.Khachhang(TenKH, DiaChi, Dienthoai,NgaySinh) values( @tenkh , @diachi , @dienthoai , @ngaysinh )";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] {tenkh,diachi,dienthoai,ngaysinh });
            return dt > 0;
            ;
        }
        public bool UpdateCustomer(string makh, string tenkh, string diachi,string dienthoai, DateTime ngaysinh)
        {
            string query = "update dbo.Khachhang SET  ,TenKH= @tenkh, DiaChi = @diachi , Dienthoai = @dienthoai , NgaySinh= @ngaysinh WHERE MaKH= @makh";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenkh, diachi, dienthoai, ngaysinh, makh });
            return dt > 0;
        }
        public bool DeleteCustomer(int makh)
        {
            string query = "DELETE FROM dbo.Khachhang WHERE  MaKH = " + makh;
            int dt = DataProvider.Instance.ExecuteNonQuery(query);
            return dt > 0;
        }
        public DataTable GetCustomerByID(int makh)
        {
            string query = "exec GetCustomerByID " + makh;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        #endregion methods
        //loaddtgv
        //insert update delete
        //searching
    }
}
