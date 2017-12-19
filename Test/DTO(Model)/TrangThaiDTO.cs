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
        public TrangThaiDTO(DataRow dr)
        {
            this.MaTrangthai = Int32.Parse(dr["MaTrangThai"].ToString());
            this.TrangThai = dr["TrangThai"].ToString();
        }
    }

}
