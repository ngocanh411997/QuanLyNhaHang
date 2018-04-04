using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.model
{
    class NhanVien
    {
        public string MANV { get; set; }
        public string TENNV { get; set; }
        public string GT { get; set; }
        public DateTime NGAYSINH { get; set; }
        public string DIACHI { get; set; }
        public string MABP { get; set; }
        public string TENBP { get; set; }
        public int LUONG { get; set; }
        public string DIENTHOAI { get; set; }

        public NhanVien()
        {
            MANV = "";
            TENNV = "";
            GT = "";
            NGAYSINH= DateTime.Parse("1/1/1997");
            DIACHI = "";
            MABP = "";
            TENBP = "";
            LUONG = 0;
            DIENTHOAI = "";
        }
        public NhanVien(string _MaNV, string _TenNV, string _GT, DateTime _NgaySinh, string _DiaChi, string _MaPB,string _TenPB,int _Luong, string _SDT)

        {
            MANV = _MaNV;
            TENNV = _TenNV;
            GT = _GT;
            NGAYSINH = _NgaySinh;
            DIACHI = _DiaChi;
            MABP = _MaPB;
            TENBP = _TenPB;
            LUONG = _Luong;
            DIENTHOAI = _SDT;
        }
    }
}
