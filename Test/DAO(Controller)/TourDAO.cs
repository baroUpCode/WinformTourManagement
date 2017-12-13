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
            string query = "select * from dbo.Tour";
            DataTable dt =  DataProvider.Instance.ExecuteQuery(query);
            return dt;

        }
        private TourDAO() { }
        public bool InsertTour(string matour,string hanhtrinh,string lotrinh)
        {
            string query = string.Format("insert dbo.TOUR(MaTour, HanhTrinh, LoTrinh) values(N'{0}', N'{1}', N'{2}')",matour,hanhtrinh,lotrinh);
            var result = DataProvider.Instance.ExecuteNonQuery(query);// bien tra ve kieu int, gia tri la so luong ca dong duoc them vao 
            //Tra ve true
            return result > 0;//result >0 == true , neu co 1 dong duoc them vao thanh cong thi result=1 va InsertTour() la true
        }
        public List<TourDTO> LoadTourList()
        {
            List<TourDTO> list = new List<TourDTO>();
            string query = "exec proc_GetTourList";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                //Duyệt từng dòng và khởi tạo đối tượng model Tour để giữ dữ liệu từng dòng sau đó add vào danh sách các Tour
                TourDTO tour = new TourDTO(row);
                list.Add(tour);
            }
            return list;
        }
    }
}
