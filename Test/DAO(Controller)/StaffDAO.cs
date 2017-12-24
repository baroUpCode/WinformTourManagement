using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.DTO_Model_;

namespace Test.DAO_Controller_
{
    class StaffDAO
    {
        private static StaffDAO instance;

        internal static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO();
            return StaffDAO.instance;
            }
            set => StaffDAO.instance = value;
        }
        public StaffDAO() { }
        public bool InsertStaff(string manv,string tennv, string diachi, string dienthoai, DateTime ngaysinh)
        {
            string query = "insert dbo.NhanVien(MaNV , TenNV, DiaChi, Dienthoai,NgaySinh) values( @manv , @tennv , @diachi , @dienthoai , @ngaysinh )";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] { manv, tennv, diachi, dienthoai, ngaysinh });
             return dt > 0;
        }
        public bool UpdateStaff(string manv, string tennv, string diachi, string dienthoai, DateTime ngaysinh)
        {
            string query = " update dbo.NhanVien SET TenNV = @tennv , DiaChi = @diachi , DienThoai = @dienthoai , NgaySinh = @ngaysinh WHERE MaNV = @manv ";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tennv, diachi, dienthoai, ngaysinh, manv });
            return dt > 0;
        }
        public bool DeleteStaff(string manv)
        {
            string query = "DELETE FROM dbo.NhanVien WHERE  MaNV = @manv ";
            int dt = DataProvider.Instance.ExecuteNonQuery(query,new object[] {manv});
            return dt > 0;
        }
        public List<StaffDTO> LoadStaffList()
        {
            List<StaffDTO> list = new List<StaffDTO>();
            string query = "select * from dbo.NhanVien";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow r in dt.Rows)
            {
                StaffDTO staff = new StaffDTO(r);
                list.Add(staff);
            }
            return list;
        }
        public DataTable GetStaffByID(string search)
        {
            string query = string.Format("exec GetCustomerByID '{0}' ", search);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable GetStaffByPhone(string search)
        {
            string query = string.Format("exec GetCustomerByPhone '{0}' ", search);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
