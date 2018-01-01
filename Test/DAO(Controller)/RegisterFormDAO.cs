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
            string query = " insert into dbo.PhieuDangKyTour(MaPDK,MaNV,MaKH,NgayLap,TrangThaiPhieu) values( @mapdk , null , @makh , GETDATE(), 1) ";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] {mapdk, makh});
            return dt > 0;
        }
        public bool UpdateRegisForm(string mapdk, /*string manv,*/ int trangthaiphieu=1)
        {
            string query = "update dbo.PhieuDangKyTour set TrangThaiPhieu = @trangthaiphieu where MaPDK = @maphieu ";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] { /*, makh,*/ trangthaiphieu , mapdk });
            return dt > 0;
        }
        //Xoa toan bo thong tin cua phieu dang ky 
        public bool DeleteTourFromRegisForm(string mapdk)
        {
            string query = "delete from dbo.PhieuDangKyTour where MaPDK = " + mapdk;
            int dt = DataProvider.Instance.ExecuteNonQuery(query);
            return dt > 0;
        }
        public bool GetRegisFormByID(string mapdk)
        {
            string query = "select * from PhieuDangKyTour where MaPDK = @maphieu ";
            int dt = DataProvider.Instance.ExecuteNonQuery(query,new object[] { mapdk });
            return dt > 0;
        }
        public string GetRegisFromByCusID(string makh)
        {
            string query = "select * from PhieuDangKyTour where MaKH = "+makh;
            string dt = (string)DataProvider.Instance.ExecuteScalar(query);
            return dt;
        }
    }
}
