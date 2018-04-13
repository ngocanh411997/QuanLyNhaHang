using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Model
{
    public class ChiTietPhieuYeuCau
    {
        public string MAPHIEU { get; set; }
        public string MAMON { get; set; }
        public int SOLUONG { get; set;}

        public ChiTietPhieuYeuCau()
        {
            MAPHIEU = "";
            MAMON = "";
            SOLUONG = 0;
        }
        public ChiTietPhieuYeuCau(string _MAPHIEU, string _MAMON, int _SOLUONG)
        {
            MAPHIEU = _MAPHIEU;
            MAMON = _MAMON;
            SOLUONG = _SOLUONG;
        }
    }
}
