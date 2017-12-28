using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DTO_Model_
{
    class RegisterFormDetailsDTO
    {
        private string maPhieu;
        private string maTour;
        //private string loTrinh;
        //private string hanhTrinh;
        private int soLuong;
        //private int giaTour;

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string MaTour { get => maTour; set => maTour = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        //public string LoTrinh { get => loTrinh; set => loTrinh = value; }
        //public string HanhTrinh { get => hanhTrinh; set => hanhTrinh = value; }
        //public int GiaTour { get => giaTour; set => giaTour = value; }

        public RegisterFormDetailsDTO(string maphieu, string matour/*,string lotrinh,string hanhtrinh,*/, int soluong/*,int giatour*/)
        {
            this.MaPhieu = maphieu;
            this.MaTour = matour;
            this.SoLuong = soluong;
            //this.LoTrinh = lotrinh;
            //this.HanhTrinh = hanhtrinh;
            //this.GiaTour = giatour;
        }
        public RegisterFormDetailsDTO(DataRow r)
        {
            this.MaPhieu = r["MaPDK"].ToString();
            this.MaTour = r["MaTour"].ToString();
            this.SoLuong = Int32.Parse(r["Sô lượng đăng ký"].ToString());
            //this.LoTrinh = r["LoTrinh"].ToString();
            //this.HanhTrinh = r["HanhTrinh"].ToString();
            //this.GiaTour = Int32.Parse(r["GiaTour"].ToString());
        }
    }
}
