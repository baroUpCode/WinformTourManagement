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
        private int soLuongdangky;
        private int maQuy;
        private int maTrangthai;
        public string MaTour { get => maTour; set => maTour = value; }
        public string HanhTrinh { get => hanhTrinh; set => hanhTrinh = value; }
        public string LoTrinh { get => loTrinh; set => loTrinh = value; }
        public int SoLuongdangky { get => soLuongdangky; set => soLuongdangky = value; }
        public float GiaTour { get => giaTour; set => giaTour = value; }
        public int MaQuy { get => maQuy; set => maQuy = value; }
        public int MaTrangthai { get => maTrangthai; set => maTrangthai = value; }

        public TourDTO(string matour, string lotrinh, string hanhtrinh,float giatour,int maquy,int matrangthai,int soluongdangky)
        {
            this.MaTour = matour;
            this.HanhTrinh = hanhtrinh;
            this.LoTrinh = lotrinh;
            this.GiaTour = giatour;
            this.MaQuy = maquy;
            this.MaTrangthai = matrangthai;
            this.SoLuongdangky = soluongdangky;
        }
        /// <summary>
        /// Chuyển đổi kiểu dữ liệu từ Table phía SQL thành kiểu đối tượng(Model) để View có thể dễ dàng lấy dữ liệu
        /// Hàm Tour(DataRow row) là hàm khởi tạo để nhâm các giá trị từ table phía DAO về và chuyển thành Model
        /// </summary>
        /// <param name="row"></param>
        public TourDTO(DataRow row)
        {
            this.MaTour = row["Mã Tour"].ToString();
            this.LoTrinh = row["Lộ trình"].ToString();
            this.HanhTrinh = row["Hành trình"].ToString();
            this.GiaTour = Int32.Parse(row["Giá Tour"].ToString());
            this.SoLuongdangky = Int32.Parse(row["Đã đăng ký"].ToString());
            this.MaTrangthai = Int32.Parse(row["Trạng thái"].ToString());
            this.MaQuy = Int32.Parse(row["Quý"].ToString());


        }

    }
}
