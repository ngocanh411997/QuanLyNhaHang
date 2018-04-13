using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Model
{
    public class PhieuYeuCau
    {
        public string MAPHIEU { get; set; }
        public string MAKH { get; set; }
        public string MANV { get; set; }
        public DateTime NGAYNHAP { get; set; }

        //
        public string TENKH { get; set; }

        public PhieuYeuCau()
        {
            MAPHIEU = "";
            MAKH = "";
            MANV = "";
            NGAYNHAP = DateTime.Parse("01/01/2017");
            TENKH = "";
        }
        public PhieuYeuCau(string _MAPHIEU, string _MAKH, string _MANV, DateTime _NGAYNHAP, string _TENKH)
        {
            MAPHIEU = _MAPHIEU;
            MAKH = _MAKH;
            MANV = _MANV;
            NGAYNHAP = _NGAYNHAP;
            TENKH = _TENKH;
        }
    }
}
