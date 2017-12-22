using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DTO_Model_
{
    class HotelDTO
    {
        private string maKhachsan;
        private string tenKhachsan;
        private string dienThoai;
        private string diaChi;
        //private string maDiemdung;
        private string tenDiemdung;

        public string MaKhachsan { get => maKhachsan; set => maKhachsan = value; }
        public string TenKhachsan { get => tenKhachsan; set => tenKhachsan = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        //public string MaDiemdung { get => maDiemdung; set => maDiemdung = value; }
        public string TenDiemdung { get => tenDiemdung; set => tenDiemdung = value; }

        public HotelDTO(string maks,string tenks,string dienthoai,string diachi,string madiemdung,string tendiemdung)
        {
            this.MaKhachsan = maks;
            this.TenKhachsan = tenks;
            this.DienThoai = dienthoai;
            this.DiaChi = diachi;
            //this.MaDiemdung = madiemdung;
            this.TenDiemdung = tendiemdung;

        }
        /// <summary>
        /// Chuyển đổi kiểu dữ liệu từ Table phía SQL thành kiểu đối tượng(Model) để View có thể dễ dàng lấy dữ liệu
        /// Hàm Tour(DataRow row) là hàm khởi tạo để nhâm các giá trị từ table phía DAO về và chuyển thành Model
        /// </summary>
        /// <param name="row"></param>
        public HotelDTO(DataRow r)
        {
            this.MaKhachsan = r["MaKS"].ToString();
            this.TenKhachsan = r["TenKS"].ToString();
            this.DienThoai = r["DienThoai"].ToString();
            this.DiaChi = r["DiaChi"].ToString();
            //this.MaDiemdung = r["MaDiemDung"].ToString();
            this.TenDiemdung = r["TenDiem"].ToString();
        }
    }
}
