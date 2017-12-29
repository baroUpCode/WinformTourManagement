using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.DTO_Model_;

namespace Test.DAO_Controller_
{
    class RegisterFormDetailsDAO
    {
        public RegisterFormDetailsDAO() { }
        private static RegisterFormDetailsDAO instance;

        internal static RegisterFormDetailsDAO Instance
        {
            get { if (instance == null) instance = new RegisterFormDetailsDAO(); return RegisterFormDetailsDAO.instance; }
            private set => RegisterFormDetailsDAO.instance = value;
        }
        /// <summary>
        /// Thêm thông tin chi tiết phiếu đăng ký sau khi đã tạo phiếu đăng ký 
        /// </summary>
        /// <param name="matour"></param>
        /// <param name="maphieu"></param>
        /// <param name="soluongdangky"></param>
        /// <returns></returns>
        public bool InsertRegisFormDetails(string matour, string maphieu , int soluongdangky) {
            string query = "exec proc_InsertRegisFormDetails @mapdk , @matour , @soluongdangky ";
            var dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maphieu, matour,  soluongdangky });
            return dt > 0;
        }
        /// <summary>
        /// Cập nhật thông tin phiếu đăng ký , chỉ cập nhật số lượng người đi cho tour trong phiếu đăng ký đó 
        /// </summary>
        /// <param name="matour"></param>
        /// <param name="maphieu"></param>
        /// <param name="soluongdangky"></param>
        /// <returns></returns>
        public bool UpdateRegisFormDetails(string matour, string maphieu, int soluongdangky)
        {
            string query = "update Chitiet_PhieuDangKy set SoluongDangky = @soluong where MaPDK = @maphieu and MaTour = @matour";
            var dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] {soluongdangky,maphieu, matour });
            return dt > 0;
        }
        //Xoa thong tin cua tour ra khoi phieu dang ky 
        public bool DeleteRegisFormDetails(string maphieu,string matour)
        {
            string query = "delete from Chitiet_PhieuDangKy where MaPDK = @mapdk and MaTour = @matour ";
            var dt = DataProvider.Instance.ExecuteNonQuery(query,new object[] {maphieu,matour });
            return dt > 0;
        }
        public List<RegisterFormDetailsDTO> GetRegisDetailsByID(string mapdk)
        {
            List<RegisterFormDetailsDTO> list = new List<RegisterFormDetailsDTO>();
            string query = "exec proc_GetRegisDetailsByID @mapdk ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query,new object[] {mapdk });
            foreach(DataRow r in dt.Rows)
            {
                RegisterFormDetailsDTO re = new RegisterFormDetailsDTO(r);
                    list.Add(re);
            }
            return list;
        }

    }
}
