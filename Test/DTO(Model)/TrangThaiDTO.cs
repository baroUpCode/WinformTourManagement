using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DTO_Model_
{
    class TrangThaiDTO
    {
        private int maTrangthai;
        private string trangThai;

        public int MaTrangthai { get => maTrangthai; set => maTrangthai = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public TrangThaiDTO(int matrangthai, string trangthai)
        {
            this.MaTrangthai = matrangthai;
            this.TrangThai = trangthai;
        }
        /// <summary>
        /// Chuyển đổi kiểu dữ liệu từ Table phía SQL thành kiểu đối tượng(Model) để View có thể dễ dàng lấy dữ liệu
        /// Hàm Tour(DataRow row) là hàm khởi tạo để nhâm các giá trị từ table phía DAO về và chuyển thành Model
        /// </summary>
        /// <param name="row"></param>
        public TrangThaiDTO(DataRow dr)
        {
            this.MaTrangthai = Int32.Parse(dr["MaTrangThai"].ToString());
            this.TrangThai = dr["TrangThai"].ToString();
        }
    }

}
