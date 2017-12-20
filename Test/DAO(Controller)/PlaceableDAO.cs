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
    }
}
