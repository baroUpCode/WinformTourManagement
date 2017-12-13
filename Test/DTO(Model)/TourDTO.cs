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
        public string MaTour { get => maTour; set => maTour = value; }
        public string HanhTrinh { get => hanhTrinh; set => hanhTrinh = value; }
        public string LoTrinh { get => loTrinh; set => loTrinh = value; }
        public TourDTO(string matour, string lotrinh, string hanhtrinh)
        {
            this.MaTour = matour;
            this.HanhTrinh = hanhtrinh;
            this.LoTrinh = lotrinh;
        }
        /// <summary>
        /// Chuyển đổi kiểu dữ liệu từ Table phía SQL thành kiểu đối tượng(Model) để View có thể dễ dàng lấy dữ liệu
        /// Hàm Tour(DataRow row) là hàm khởi tạo để nhâm các giá trị từ table phía DAO về và chuyển thành Model
        /// </summary>
        /// <param name="row"></param>
        public TourDTO(DataRow row)
        {
            this.MaTour = row["MaTour"].ToString();
            this.LoTrinh = row["LoTrinh"].ToString();
            this.HanhTrinh = row["HanhTrinh"].ToString();
        }

    }
}
