using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAO_Controller_
{
    class ThangDAO
    {
        private static ThangDAO instance;

        public static ThangDAO Instance
        {
            get
            {
                if (instance == null) instance = new ThangDAO();
                return ThangDAO.instance;
            }
            private set { ThangDAO.instance = value; }
        }
        private ThangDAO() { }
        public DataTable GetThang(int ngaydi)
        {
            string query = "select LoTrinh,GiaTour,SoluongHientai,NgayDi,NgayVe from Tour  where MONTH(NgayDi)= @ngaydi";
            var dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
