using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.DTO_Model_;

namespace Test.DAO
{
    public class TourDAO
    {
        private static TourDAO instance;
        internal static TourDAO Instance
        {
            get { if (instance == null) instance = new TourDAO();
                return TourDAO.instance;
            }
            private set { TourDAO.instance = value; }
        }
        public static int WidthTour = 150;
        public static int HeightTour = 100;
        public DataTable GetListTour()
        {
            //DataTable dt = new DataTable();
            string query = "select MaTour,HanhTrinh,LoTrinh,GiaTour,MaQuy,SoluongHientai,NgayDi,NgayVe, tr.TrangThai from Tour t  Left Join  TrangThai tr on t.MaTrangThai=tr.MaTrangThai";
            DataTable dt =  DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        private TourDAO() { }
        public bool InsertTour(string matour,string hanhtrinh,string lotrinh,float giatour, int maquy, int trangthai, int dadangky,DateTime NgayDi , DateTime NgayVe)
        {
            string query = "insert dbo.Tour(MaTour, HanhTrinh, LoTrinh, GiaTour, MaQuy, MaTrangThai , SoluongHientai, NgayDi , NgayVe) values( @matour , @hanhtrinh , @lotrinh , @giatour , @maquy , @trangthai , @dadangky , @ngaydi , @ngayve )";/*, matour, hanhtrinh, lotrinh,giatour,maquy,matrangthai,soluonghientai);*//*"exec THEMTOUR @matour , @hanhtrinh , @lotrinh , @giatour , @maquy , @matrangthai , @soluonghientai ";*/
            var result = DataProvider.Instance.ExecuteNonQuery(query,new object[] {matour,hanhtrinh,lotrinh,giatour,maquy,trangthai,dadangky,NgayDi,NgayVe});// bien tra ve kieu int, gia tri la so luong ca dong duoc them vao 
            //Tra ve true
            return result > 0;//result >0 == true , neu co 1 dong duoc them vao thanh cong thi result=1 va InsertTour() la true
        }
        public bool DeleteTour(string matour)
        {
            string query = "exec XOATOUR" + ' ' + matour;
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateTour(string matour,string hanhtrinh, string lotrinh , float giatour, int maquy , int matrangthai , int dadangky,DateTime ngaydi , DateTime ngayve )
        {
            string query = "exec SUATOUR @matour , @hanhtrinh , @lotrinh , @giatour , @maquy , @matrangthai , @dadangky , @ngaydi , @ngayve";
            var result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {matour,hanhtrinh,lotrinh,giatour,maquy,matrangthai,dadangky,ngaydi,ngayve});
            return result > 0;
        }
        /// <summary>
        /// Cập nhật số lượng hiện tại của tour khi thêm mới hoặc update số lượng trong chi tiết phiếu đăng ký 
        /// </summary>
        /// <param name="matour"></param>
        /// <param name="soluongdangky"></param>
        /// <returns></returns>
        public bool UpdateTourQuantity(string matour,int soluongdangky)
        {
            string query = "exec proc_UpdateQuantityInTour @matour , @detailsquantity ";
            var result = DataProvider.Instance.ExecuteNonQuery(query,new object[] {matour,soluongdangky });
            return result > 0;
        }
        //public DataTable GetTourByMaTour(string matour)
        //{
        //    string query = "exec proc_GetTourByMaTour @matour";
        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] {matour});
        //    return dt;
        //}
        public List<TourDTO> GetTourDTOByID(string id )
        {
            List<TourDTO> list = new List<TourDTO>();
            string query = "Select * from Tour where MaTour = @matour ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] {id});
            foreach (DataRow row in dt.Rows)
            {
                //Duyệt từng dòng và khởi tạo đối tượng model Tour để giữ dữ liệu từng dòng sau đó add vào danh sách các Tour
                TourDTO tour = new TourDTO(row);
                list.Add(tour);
            }
            return list;
        }
        public List<TourDTO> LoadTourListDTO()
        {
            List<TourDTO> list = new List<TourDTO>();
            string query = "Select * from Tour ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                //Duyệt từng dòng và khởi tạo đối tượng model Tour để giữ dữ liệu từng dòng sau đó add vào danh sách các Tour
                TourDTO tour = new TourDTO(row);
                list.Add(tour);
            }
            return list;
        }
        public DataTable LoadListQuy()
        {
            string query = "select * from Quy";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable LoadListTrangThai()
        {
            string query = "exec GetTrangThaiList";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            //foreach(DataRow dr in dt.Rows)
            //{
            //    TrangThaiDTO tt = new TrangThaiDTO(dr);
            //    list.Add(tt);
            //}
            return dt;
        }
        public DataTable GetTourByID(string id)
        {
            string query = "exec GetTourByID "+id;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        } 
        public DataTable GetTourBeginDate(string id )
        {
            string query = "exec pro_GetTourBeginDate " + id;
            var dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public List<TourDTO> GetTourByBeginMonth(int ngaydi)
        {
            List<TourDTO> list = new List<TourDTO>();
            string query = "select * from Tour where MONTH(NgayDi) =  @ngaydi" ;
            var dt = DataProvider.Instance.ExecuteQuery(query,new object[] {ngaydi});
            foreach(DataRow r in dt.Rows)
            {
                TourDTO tour = new TourDTO(r);
                list.Add(tour);
            }
            return list;
        }
        public List<TourDTO> GetTourByQuy(int quy)
        {
            List<TourDTO> list = new List<TourDTO>();
            string query = "select * from Tour where MaQuy =  @quy";
            var dt = DataProvider.Instance.ExecuteQuery(query, new object[] { quy });
            foreach (DataRow r in dt.Rows)
            {
                TourDTO tour = new TourDTO(r);
                list.Add(tour);
            }
            return list;
        }
        public List<TourDTO> GetTourByCreateDay(DateTime ngaybd , DateTime ngaykt )
        {
            List<TourDTO> list = new List<TourDTO>();
            string query = "pro_GetTourByCreateDate @ngaybd , @ngaykt";
            var dt = DataProvider.Instance.ExecuteQuery(query, new object[] {ngaybd.ToShortDateString(), ngaykt.ToShortDateString() });
            foreach (DataRow r in dt.Rows)
            {
                TourDTO tour = new TourDTO(r);
                list.Add(tour);
            }
            return list;
        }
    }
}
