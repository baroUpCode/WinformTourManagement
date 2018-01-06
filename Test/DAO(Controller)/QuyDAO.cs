using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAO_Controller_
{
    class QuyDAO
    {
        private static QuyDAO instance;

        public static QuyDAO Instance
        {
            get
            {
                if (instance == null) instance = new QuyDAO();
                return QuyDAO.instance;
            }
            private set { QuyDAO.instance = value; }
        }
        private QuyDAO() { }
        public DataTable GetQuy()
        {
            string query = "select * from Quy";
            var dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
