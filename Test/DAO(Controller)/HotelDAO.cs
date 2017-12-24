using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.DTO_Model_;

namespace Test.DAO_Controller_
{
    class HotelDAO
    {
        private static HotelDAO instance;

        internal static HotelDAO Instance {
            get
            {
                if (instance == null) instance = new HotelDAO();
                return HotelDAO.instance;
            }
            private set { HotelDAO.instance = value; }
        }
        private HotelDAO() { }
        public bool InsertHotel(string maks,string tenks, string dienthoai, string diachi, string madiemdung)
        {
            string query = "insert dbo.KhachSan(MaKS, TenKS, DienThoai, DiaChi,MaDiemDung) values( @maks , @tenks , @dienthoai , @diachi , @madiemdung ) ";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maks, tenks, dienthoai, diachi, madiemdung });
            return dt > 0;
        }
        public bool UpdateHotel(string maks, string tenks, string dienthoai, string diachi, string madiemdung)
        {
            string query = "update dbo.KhachSan SET TenKS = @diachi , DienThoai = @diemtq , DiaChi= @diachi , MaDiemDung= @madiemdung WHERE MaKS= @maks ";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenks, dienthoai, diachi, madiemdung, maks });
            return dt > 0;
        }
        public bool DeleteHotel(string maks)
        {
            string query = "DELETE FROM dbo.DiemThamQuan WHERE MaDTQ = " + maks;
            int dt = DataProvider.Instance.ExecuteNonQuery(query);
            return dt > 0;
        }
        public DataTable GetHotelByID(string search)
        {
            string query = "exec GetHotelByID " +search;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable GetHotelByTheStop(string search)
        {
            string query = "exec GetHotelByTheStop "+search;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public List<HotelDTO> LoadHotelList()
        {
            string query = "select MaKS,TenKS,DienThoai,DiaChi, d.TenDiem from KhachSan ks, DiemDung d where ks.MaDiemDung=d.MaDiemDung";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<HotelDTO> list = new List<HotelDTO>();
            foreach(DataRow r in dt.Rows)
            {
                //Duyệt các dòng trong dữ liệu kiểu datatable và gán các dữ liệu của từng dòng r được duyệt vào đối tượng Hotel theo kiểu khởi tạo có sẵn 
                HotelDTO hotel = new HotelDTO(r);
                //Sau đó add đối tượng vào list đã tạo sẵn để load về datasource hoặc các đối tượng cần load danh sách list
                list.Add(hotel);
            }
            return list;
        }
        /// <summary>
        /// Methods tạm để load cbx điểm dừng 
        /// </summary>
        /// <returns></returns>
        public DataTable LoadCbxDiemDung()
        {
            string query = "select * from DiemDung";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
