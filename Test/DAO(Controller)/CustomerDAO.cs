﻿using System;
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
            string query = "select * from KhachHang";
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
            string query = "insert dbo.KhachHang(TenKH, DiaChi, Dienthoai,NgaySinh) values( @tenkh , @diachi , @dienthoai , @ngaysinh )";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] {tenkh,diachi,dienthoai,ngaysinh });
            return dt > 0;
        }
        public bool UpdateCustomer(int makh, string tenkh, string diachi,string dienthoai, DateTime ngaysinh)
        {
            string query = " update dbo.KhachHang SET TenKH = @tenkh , DiaChi = @diachi , DienThoai = @dienthoai , NgaySinh = @ngaysinh WHERE MaKH = @makh ";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenkh, diachi, dienthoai, ngaysinh, makh });
            return dt > 0;
        }
        public bool DeleteCustomer(int makh)
        {
            string query = string.Format("DELETE FROM dbo.KhachHang WHERE  MaKH = {0} ", makh);
            int dt = DataProvider.Instance.ExecuteNonQuery(query);
            return dt > 0;
        }
        
        public DataTable GetCustomerByID(string search)
        {
            string query = string.Format("exec GetCustomerByID '{0}' ",search);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable GetCustomerByPhone(string search)
        {
            string query = string.Format("exec GetCustomerByPhone '{0}' ",search);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable GetMaxID()
        {
            string query = "select top 1 MaKH , TenKH,DiaChi,DienThoai,NgaySinh from dbo.KhachHang order by MaKH desc";
            var dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        //public List<CustomerDTO> GetCusByMaxID()
        //{
        //    List<CustomerDTO> list = new List<CustomerDTO>();
        //    string query = "select top 1 MaKH from dbo.KhachHang order by MaKH desc ";
        //    var dt = DataProvider.Instance.ExecuteQuery(query);
        //    foreach(DataRow r in dt.Rows)
        //    {
        //        CustomerDTO cus = new CustomerDTO(r);
        //        list.Add(cus);
        //    }
        //    return list;
        //}
        #endregion methods
        //loaddtgv
        //insert update delete
        //searching
    }
}
