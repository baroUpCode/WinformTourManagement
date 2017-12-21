using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAO_Controller_
{
    class PlaceableDAO
    {
        private static PlaceableDAO instance;
        internal static PlaceableDAO Instance
        {
            get
            {
                if (instance == null) instance = new PlaceableDAO();
                return PlaceableDAO.instance;
            }
            private set{ PlaceableDAO.instance = value;}
    }
        private PlaceableDAO() { }
        public DataTable LoadPlaceableList()
        {
            string query = "select * from DiaDiemTQ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public bool InsertPlaceable(string madd, string madiem , string diachi, string diemtq)
        {
            string query = "insert dbo.DiaDiemTQ(MaDD, MaDiem, DiaChi, DiemTQ) values( @madd , @madiem , @diachi , @diemtq )";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] { madd, madiem, diachi, diemtq });
            return dt > 0;
;        }
    }
}
