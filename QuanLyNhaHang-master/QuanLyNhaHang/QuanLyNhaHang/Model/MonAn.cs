using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.model
{
    public class MonAn
    {
        public string MaMon { get; set; }
        public string MaNhomMon { get; set; }
        public string TenMon { get; set; }
        public string DonViTinh { get; set; }
        public int Gia { get; set; }
        public string TenNhomMon { get; set; }

        public MonAn()
        {
            MaMon = "";
            MaNhomMon = "";
            TenMon = "";
            DonViTinh = "";
            Gia = 0;
            TenNhomMon = "";
        }
        public MonAn(string _MaMon, string _MaNhomMon, string _TenMon, string _DonViTinh, int _Gia, string _TenNhomMon)
        {
            MaMon = _MaMon;
            MaNhomMon = _MaNhomMon;
            TenMon = _TenMon;
            DonViTinh = _DonViTinh;
            Gia = _Gia;
            TenNhomMon = _TenNhomMon;
        }
    }
}
