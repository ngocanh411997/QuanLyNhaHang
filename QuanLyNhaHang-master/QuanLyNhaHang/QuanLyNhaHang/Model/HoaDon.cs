using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhaHang.Model
{
    public class HoaDon
    {
        public string MAPHIEU { get; set; }
        public string MANV { get; set; }
        public DateTime NGAYNHAP { get; set; }
        public string MAKH { get; set; }
        public string TENKH { get; set; }
        public string TENMON { get; set; }
        public int SOLUONG { get; set; }
        public string DONVITINH { get; set; }
        public long GIA { get; set; }
        public int THANHTIEN { get; set; }
        public int TONGTIEN { get; set; }

        public HoaDon()
        {
            MAPHIEU = "";
            MANV = "";
            NGAYNHAP = DateTime.Parse("01/01/2017");
            MAKH = "";
            TENKH = "";
            TENMON = "";
            SOLUONG = 0;
            DONVITINH = "";
            GIA = 0;
            THANHTIEN = 0;
            TONGTIEN = 0;
        }
        public HoaDon(string _MAPHIEU, string _MANV, DateTime _NGAYNHAP, string _MAKH, string _TENKH, string _TENMON, int _SOLUONG, string _DONVITINH, long _GIA, int _THANHTIEN, int _TONGTIEN)
        {
            MAPHIEU = _MAPHIEU;
            MANV = _MAKH;
            NGAYNHAP = _NGAYNHAP;
            MAKH = _MAKH;
            TENKH = _TENKH;
            TENMON = _TENMON;
            SOLUONG = _SOLUONG;
            DONVITINH = _DONVITINH;
            GIA = _GIA;
            THANHTIEN = _THANHTIEN;
            TONGTIEN = _TONGTIEN;
        }
    }
}
