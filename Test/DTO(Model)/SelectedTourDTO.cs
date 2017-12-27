using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DTO_Model_
{
    class SelectedTourDTO
    {
        private string maTour;
        private string loTrinh;
        private string hanhTrinh;
        private int giaTour;
        private int soLuongdangky;

        public string MaTour { get => maTour; set => maTour = value; }
        public string LoTrinh { get => loTrinh; set => loTrinh = value; }
        public string HanhTrinh { get => hanhTrinh; set => hanhTrinh = value; }
        public int GiaTour { get => giaTour; set => giaTour = value; }
        public int SoLuongdangky { get => soLuongdangky; set => soLuongdangky = value; }
        public SelectedTourDTO(string matour,string lotrinh, string hanhtrinh, int giatour, int soluongdangky)
        {
            this.MaTour = matour;
            this.LoTrinh = lotrinh;
            this.HanhTrinh = hanhtrinh;
            this.GiaTour = giatour;
            this.SoLuongdangky = soluongdangky;
        }
        public SelectedTourDTO(DataRow r)
        {
            this.MaTour = r["MaTour"].ToString();
            this.LoTrinh = r["LoTrinh"].ToString();
            this.HanhTrinh = r["HanhTrinh"].ToString();
            this.GiaTour = Int32.Parse(r["GiaTour"].ToString());
            this.SoLuongdangky =Int32.Parse(r["SoluongDangky"].ToString());
        }
    }
}
