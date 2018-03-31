using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.controller
{
    class NhanVienCrt
    {
        public static DataTable GetListNhanVien()
        {
            return model.ConnectString.GetData("SELECT MANV, TENNV, GT, NGAYSINH, dbo.NHANVIEN.DIACHI,TENBP, LUONG, DIENTHOAI FROM dbo.NHANVIEN ,dbo.BOPHAN WHERE NHANVIEN.MABP=BOPHAN.MABP");
        }
    }
}
