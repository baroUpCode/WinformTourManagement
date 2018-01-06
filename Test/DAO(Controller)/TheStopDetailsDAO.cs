using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAO_Controller_
{
    class TheStopDetailsDAO
    {
        private static TheStopDetailsDAO instance;
        internal static TheStopDetailsDAO Instance
        {
            get
            {
                if (instance == null) instance = new TheStopDetailsDAO();
                return TheStopDetailsDAO.instance;
            }
            private set { TheStopDetailsDAO.instance = value; }
        }
        public bool InsertTheStopDetails(string madiemdung,string matour,string madtq)
        {
            string query = "insert Chitiet_DiemDung(MaDiemDung,MaTour,MaDTQ) values( @madiemdung , @matour , @madtq )";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] { madiemdung, matour, madtq });
            return dt > 0;
        }
        public bool DeleteTheStopDetails(string madiem,string matour,string madtq)
        {
            string query = "DELETE FROM dbo.Chitiet_Diemdung WHERE  MaDiemDung = @madiem and MaTour = @matour and MaDTQ = @madtq ";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] { madiem, matour, madtq });
            return dt > 1;
        }
        public string GetMaDTQ(string matour)
        {
            string query = "select dtq.MaDTQ from DiemThamQuan dtq , Chitiet_DiemDung ct where dtq.MaDiemDung = ct.MaDiemDung and ct.MaTour= @matour ";
            string dt = (string)DataProvider.Instance.ExecuteScalar(query, new object[] { matour });
            return dt;
        }
        public string GetMadd(string madtq)
        {
            string query = "select dtq.MaDiemDung from DiemThamQuan dtq, DiemDung dd where MaDTQ = @madtq and dtq.MaDiemDung = dd.MaDiemDung";
            string dt = (string)DataProvider.Instance.ExecuteScalar(query, new object[] {madtq });
            return dt;
        }
    }
}
