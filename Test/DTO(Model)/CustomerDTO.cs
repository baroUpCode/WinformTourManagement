using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DTO_Model_
{
    class CustomerDTO
    {
        private string maKH;
        private string tenKH;
        private string diaChi;
        private string dienThoai;
        private DateTime ngaySinh;

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public CustomerDTO(string makh,string tenkh, string diachi,string dienthoai, DateTime ngaysinh )
        {
            this.MaKH = makh;
            this.TenKH = tenkh;
            this.DiaChi = diachi;
            this.DienThoai = dienthoai;
            this.NgaySinh = ngaysinh;
        }
        public CustomerDTO(DataRow r)
        {
            this.MaKH = r["MaKH"].ToString();
            this.TenKH = r["TenKH"].ToString();
            this.DiaChi = r["DiaChi"].ToString();
            this.DienThoai = r["DienThoai"].ToString();
            this.NgaySinh = DateTime.Parse(r["NgaySinh"].ToString());
        }
    }
}
