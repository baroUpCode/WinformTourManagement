using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAO_Controller_
{
    class TheStopDAO
    {
        public TheStopDAO() { }
        private static TheStopDAO instance;

        internal static TheStopDAO Instance {
            get { if (instance == null) instance = new TheStopDAO();
                return TheStopDAO.instance;
            }
            private set => TheStopDAO.instance = value; }
        public bool InsertTheStop(string madiemdung, string tendiemdung)
        {
            string query = "insert into DiemDung(MaDiemDung,TenDiem) values( @madiemdung , @tendiem )";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] { madiemdung,tendiemdung});
            return dt > 0;
        }
        public bool UpdateTheStop(string madiemdung, string tendiemdung)
        {
            string query = "update dbo.DiemDung SET TenDiem = @tendiemdung WHERE MaDiemDung = @madiemdung ";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tendiemdung,madiemdung });
            return dt > 0;
        }
        public bool DeleteTheStop(string madiemdung)
        {
            string query ="DELETE FROM dbo.DiemDung WHERE MaDTQ = " + madiemdung;
            int dt = DataProvider.Instance.ExecuteNonQuery(query);
            return dt > 0;
        }
        public DataTable LoadTheStopList()
        {
            string query = "select * from DiemDung";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable GetTheStopByID(string search)
        {
            string query = "select * from DiemDung where MaDiemDung = " +search;                
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}