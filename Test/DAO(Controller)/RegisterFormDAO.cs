using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAO_Controller_
{
    class PhieuDangKyDAO
    {
        public PhieuDangKyDAO() { }
        private static PhieuDangKyDAO instance;

        internal static PhieuDangKyDAO Instance
        {
            get { if (instance == null) instance = new PhieuDangKyDAO();
                return PhieuDangKyDAO.instance;
            }
            private set => PhieuDangKyDAO.instance = value;
        }
        /// <summary>
        /// Thêm thông tin phiếu đăng ký bao gồm mã phiếu và mã khách hàng sau đó thêm chi tiết các tour vào CHi tiết phiếu đăng ký 
        /// </summary>
        /// <param name="mapdk"></param>
        /// <param name="makh"></param>
        /// <returns></returns>
        public bool InsertRegisForm(string mapdk, string makh )
        {
            string query = "insert into dbo.PhieuDangKyTour(MaPDK,MaNV,MaKH,NgayLap) values( @mapdk , null , @makh , GETDATE())";
            var dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] {mapdk, makh});
            return dt > 0;
        }
        public bool UpdateRegisForm(string mapdk, string manv,string makh)
        {
            string query = "update dbo.PhieuDangKyTour set MaNV = @manv , MaKH = @makh where MaPDK = @maphieu ";
            var dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] { manv, makh, mapdk });
            return dt > 0;
        }
        //Xoa toan bo thong tin cua phieu dang ky 
        public bool DeleteTourFromRegisForm(string mapdk)
        {
            string query = "delete from dbo.PhieuDangKyTour where MaPDK = " + mapdk;
            var dt = DataProvider.Instance.ExecuteNonQuery(query);
            return dt > 0;
        }
    }
}
