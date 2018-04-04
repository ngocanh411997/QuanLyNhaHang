using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.model
{
    public class NguoiDung
    {
        public string TAIKHOAN { get; set; }
        public string MATKHAU { get; set; }

        public NguoiDung()
        {
            TAIKHOAN = "";
            MATKHAU = "";
        }
        public NguoiDung(string _TaiKhoan, string _MatKhau)
        {
            TAIKHOAN = _TaiKhoan;
            MATKHAU = _MatKhau;
        }
    }
}
