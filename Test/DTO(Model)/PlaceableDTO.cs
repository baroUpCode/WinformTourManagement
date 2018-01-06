using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DTO_Model_
{
    class PlaceableDTO
    {
        private string tenDiemThamQuan;
        private string diaChi;
        private string maDTQ;

        public string TenDiemThamQuan { get => tenDiemThamQuan; set => tenDiemThamQuan = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaDTQ { get => maDTQ; set => maDTQ = value; }

        public PlaceableDTO(string tendtq, string diachi,string madtq)
        {
            this.TenDiemThamQuan = tendtq;
            this.DiaChi = diaChi;
            this.MaDTQ = madtq;
        }
        public PlaceableDTO(DataRow r)
        {
            this.TenDiemThamQuan = r["TenDTQ"].ToString();
            this.DiaChi = r["DiaChi"].ToString();
            this.MaDTQ = r["MaDTQ"].ToString();
        }
    }
}
