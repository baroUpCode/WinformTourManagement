using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DTO_Model_
{
    class RegisterFormDTO
    {
        private string maPhieudk;
        private string maNhanvien;
        private string maKhachhang;
        private DateTime ngayLap;

        public string MaPhieudk { get => maPhieudk; set => maPhieudk = value; }
        public string MaNhanvien { get => maNhanvien; set => maNhanvien = value; }
        public string MaKhachhang { get => maKhachhang; set => maKhachhang = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public RegisterFormDTO(string mapdk, string manv, string makh, DateTime ngaylap)
        {
            this.MaPhieudk = mapdk;
            this.MaNhanvien = manv;
            this.MaKhachhang = makh;
            this.NgayLap = ngaylap;
        }
        public RegisterFormDTO(DataRow r)
        {
            this.MaPhieudk = r["MaPDK"].ToString();
            this.MaNhanvien = r["MaNV"].ToString();
            this.MaKhachhang = r["MaKH"].ToString() ;
            this.NgayLap = DateTime.Parse(r["NgayLap"].ToString());
        }
    }
}
