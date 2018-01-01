using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DTO_Model_
{
    class ShowRegisDetailsTourAndCusDTO
    {
        //ListViewItem lst = new ListViewItem(item1.LoTrinh.ToString());
        //lst.SubItems.Add(item1.HanhTrinh.ToString());
        //lst.SubItems.Add(item1.NgayDi.ToShortDateString());
        //lst.SubItems.Add(item1.NgayVe.ToShortDateString());
        //lst.SubItems.Add(item1.SoluongDangky.ToString());
        //lst.SubItems.Add(item1.TenKH.ToString());
        //lst.SubItems.Add(item1.Sodienthoai.ToString());
        //lst.SubItems.Add(item1.DiaChi.ToString());
        //listvThongtintour.Items.Add(lst);
        private string maTour;
        private string loTrinh;
        private string hanhTrinh;
        private DateTime ngaySinh;
        private DateTime ngayDi;
        private DateTime ngayVe;
        private int soluongDangky;
        private string tenKH;
        private string dienThoai;
        private string diaChi;
        private int trangThaiPhieu;
        private string maPDK;

        public string LoTrinh { get => loTrinh; set => loTrinh = value; }
        public string HanhTrinh { get => hanhTrinh; set => hanhTrinh = value; }
        public DateTime NgayDi { get => ngayDi; set => ngayDi = value; }
        public DateTime NgayVe { get => ngayVe; set => ngayVe = value; }
        public int SoluongDangky { get => soluongDangky; set => soluongDangky = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaTour { get => maTour; set => maTour = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public int TrangThaiPhieu { get => trangThaiPhieu; set => trangThaiPhieu = value; }
        public string MaPDK { get => maPDK; set => maPDK = value; }

        public ShowRegisDetailsTourAndCusDTO(string matour, string lotrinh,string hanhtrinh,DateTime ngaydi,DateTime ngayve,int soluongdangky,string tenkh,string dienthoai,string diachi,DateTime ngaysinh,int trangthaiphieu,string mapdk)
        {
            this.MaTour = matour;
            this.LoTrinh = lotrinh;
            this.HanhTrinh = hanhtrinh;
            this.NgayDi = ngaydi;
            this.NgayVe = ngayve;
            this.SoluongDangky = soluongdangky;
            this.TenKH = tenkh;
            this.DienThoai = dienthoai;
            this.DiaChi = diachi;
            this.NgaySinh = ngaysinh;
            this.TrangThaiPhieu = trangthaiphieu;
            this.MaPDK = mapdk;
        }
        public ShowRegisDetailsTourAndCusDTO(DataRow r)
        {
            this.MaTour = r["MaTour"].ToString();
            this.LoTrinh = r["LoTrinh"].ToString();
            this.HanhTrinh = r["HanhTrinh"].ToString();
            this.NgayDi = DateTime.Parse(r["NgayDi"].ToString());
            this.NgayVe = DateTime.Parse(r["NgayVe"].ToString());
            this.SoluongDangky = Int32.Parse(r["SoluongDangky"].ToString());
            this.TenKH = r["TenKH"].ToString();
            this.DienThoai = r["DienThoai"].ToString();
            this.DiaChi = r["DiaChi"].ToString();
            this.NgaySinh = DateTime.Parse(r["NgaySinh"].ToString());
            this.TrangThaiPhieu = Int32.Parse(r["TrangThaiPhieu"].ToString());
            this.MaPDK = r["MaPDK"].ToString();
        }
    }
}
