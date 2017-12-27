using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DTO_Model_
{
    public class TourDTO
    {
        private string maTour;
        private string hanhTrinh;
        private string loTrinh;
        private float giaTour;
        private int soluonghientai;
        private int maQuy;
        private DateTime ngayDi;
        private DateTime ngayVe;
        private int maTrangthai;
        public string MaTour { get => maTour; set => maTour = value; }
        public string HanhTrinh { get => hanhTrinh; set => hanhTrinh = value; }
        public string LoTrinh { get => loTrinh; set => loTrinh = value; }
        public int SoluongHientai { get => soluonghientai; set => soluonghientai = value; }
        public float GiaTour { get => giaTour; set => giaTour = value; }
        public int MaQuy { get => maQuy; set => maQuy = value; }
        public int MaTrangthai { get => maTrangthai; set => maTrangthai = value; }
        public DateTime NgayDi { get => ngayDi; set => ngayDi = value; }
        public DateTime NgayVe { get => ngayVe; set => ngayVe = value; }

        public TourDTO(string matour, string lotrinh, string hanhtrinh,float giatour,int maquy,int matrangthai,int soluonghientai, DateTime ngaydi, DateTime ngayve)
        {
            this.MaTour = matour;
            this.HanhTrinh = hanhtrinh;
            this.LoTrinh = lotrinh;
            this.GiaTour = giatour;
            this.MaQuy = maquy;
            this.MaTrangthai = matrangthai;
            this.SoluongHientai = soluonghientai;
            this.NgayDi = ngaydi;
            this.NgayVe = ngayve;
        }
        /// <summary>
        /// Chuyển đổi kiểu dữ liệu từ Table phía SQL thành kiểu đối tượng(Model) để View có thể dễ dàng lấy dữ liệu
        /// Hàm Tour(DataRow row) là hàm khởi tạo để nhâm các giá trị từ table phía DAO về và chuyển thành Model
        /// </summary>
        /// <param name="row"></param>
        public TourDTO(DataRow row=null)
        {
            this.MaTour = row["MaTour"].ToString();
            this.LoTrinh = row["LoTrinh"].ToString();
            this.HanhTrinh = row["HanhTrinh"].ToString();
            this.GiaTour = Int64.Parse(row["GiaTour"].ToString());
            this.SoluongHientai = Int32.Parse(row["SoluongHientai"].ToString());
            this.MaTrangthai = Int32.Parse(row["MaTrangThai"].ToString());
            this.MaQuy = Int32.Parse(row["MaQuy"].ToString());
            this.NgayDi = DateTime.Parse(row["NgayDi"].ToString());
            this.NgayVe = DateTime.Parse(row["NgayVe"].ToString());

        }

    }
}
