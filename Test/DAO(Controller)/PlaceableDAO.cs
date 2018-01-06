using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.DTO_Model_;

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
            private set { PlaceableDAO.instance = value; }
        }
        private PlaceableDAO() { }
        public DataTable LoadPlaceableList()
        {
            string query = "select MaDTQ ,DiaChi,TenDTQ,dd.TenDiem from DiemThamQuan dtq left join DiemDung dd on dtq.MaDiemDung=dd.MaDiemDung";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public bool InsertPlaceable(string madtq, string madiemdungchan, string diachi, string tendtq)
        {
            string query = "insert dbo.DiemThamQuan(MaDTQ, MaDiemDung, DiaChi, TenDTQ) values( @madd , @madiemdungchan , @diachi , @diemtq )";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] { madtq, madiemdungchan, diachi, tendtq });
            return dt > 0;
            ;
        }
        public bool UpdatePlaceable(string madtq, string madiemdungchan, string diachi, string tendtq)
        {
            string query = "update dbo.DiemThamQuan SET MaDiemDung = @madiemdung , DiaChi = @diachi , TenDTQ = @diemtq WHERE MaDTQ= @madd";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] { madiemdungchan, diachi, tendtq, madtq });
            return dt > 0;
        }
        public bool DeletePlaceable(string madtq)
        {
            string query = "DELETE FROM dbo.DiemThamQuan WHERE MaDTQ = " + madtq;
            int dt = DataProvider.Instance.ExecuteNonQuery(query);
            return dt > 0;
        }
        public DataTable GetPlaceableByTheStop(string madd)
        {
            string query = "exec GetPlaceableByTheStop @madd ";
            var dt = DataProvider.Instance.ExecuteQuery(query, new object[] { madd });
            return dt;
        }
        public List<PlaceableDTO> LoadPlaceableListChoose(string matour)
        {
            List<PlaceableDTO> list = new List<PlaceableDTO>();
            string query = "select dtq.TenDTQ,dtq.DiaChi, ct.MaDTQ from DiemThamQuan dtq, Chitiet_DiemDung ct where dtq.MaDTQ=ct.MaDTQ and ct.MaTour = @matour ";
            var dt = DataProvider.Instance.ExecuteQuery(query, new object[] { matour });
            foreach(DataRow r in dt.Rows) {
                PlaceableDTO pl = new PlaceableDTO(r);
                list.Add(pl);
            }
            return list;
        }
    }
}
