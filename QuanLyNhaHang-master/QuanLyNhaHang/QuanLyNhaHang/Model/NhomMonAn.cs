using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.model
{
    public class NhomMonAn
    {
        public string MANHOMMON { get; set; }
        public string TENNHOMMON { get; set; }

        public NhomMonAn()
        {
            MANHOMMON = "";
            TENNHOMMON = "";
        }

        public NhomMonAn( string _MaNhomMon, string _TenNhomMon)
        {
            MANHOMMON = _MaNhomMon;
            TENNHOMMON = _TenNhomMon;
        }
    }
}
