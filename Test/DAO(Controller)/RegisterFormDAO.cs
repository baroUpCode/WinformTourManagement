using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAO_Controller_
{
    class RegisterFormDAO
    {
        public RegisterFormDAO() { }
        private static RegisterFormDAO instance;

        internal static RegisterFormDAO Instance
        {
            get { if (instance == null) instance = new RegisterFormDAO();
                return RegisterFormDAO.instance;
            }
            private set => RegisterFormDAO.instance = value;
        }
        /// <summary>
        /// Thêm thông tin phiếu đăng ký bao gồm mã phiếu và mã khách hàng sau đó thêm chi tiết các tour vào CHi tiết phiếu đăng ký 
        /// </summary>
        /// <param name="mapdk"></param>
        /// <param name="makh"></param>
        /// <returns></returns>
        public bool InsertRegisForm(string mapdk, int makh )
        {
            string query = " insert into dbo.PhieuDangKyTour(MaPDK,MaNV,MaKH,NgayLap) values( @mapdk , null , @makh , GETDATE()) ";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] {mapdk, makh});
            return dt > 0;
        }
        public bool UpdateRegisForm(string mapdk, string manv,int makh)
        {
            string query = "update dbo.PhieuDangKyTour set MaNV = @manv , MaKH = @makh where MaPDK = @maphieu ";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] { manv, makh, mapdk });
            return dt > 0;
        }
        //Xoa toan bo thong tin cua phieu dang ky 
        public bool DeleteTourFromRegisForm(string mapdk)
        {
            string query = "delete from dbo.PhieuDangKyTour where MaPDK = " + mapdk;
            int dt = DataProvider.Instance.ExecuteNonQuery(query);
            return dt > 0;
        }
        public bool GetRegisFormByID(string id)
        {
            string query = "select * from PhieuDangKyTour where MaPDK = @maphieu ";
            int dt = DataProvider.Instance.ExecuteNonQuery(query,new object[] {id});
            return dt > 0;
        }
    }
}
