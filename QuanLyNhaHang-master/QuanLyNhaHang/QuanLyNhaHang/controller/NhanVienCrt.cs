using QuanLyNhaHang.model;
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
        public static List<NhanVien> TimKiem(int type, string TuKhoa)
        {
            string query = "";
            switch (type)
            {
                case 0:
                    query = string.Format("SELECT * FROM dbo.NHANVIEN WHERE MANV LIKE '%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVien>(model.ConnectString.GetData(query));
                case 1:

                    query = string.Format("SELECT * FROM dbo.NHANVIEN WHERE TENNV LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVien>(model.ConnectString.GetData(query));
                case 2:
                    query = string.Format("SELECT * FROM dbo.NHANVIEN WHERE GIOITINH LIKE '%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVien>(model.ConnectString.GetData(query));
                case 3:
                    query = string.Format("SELECT * FROM dbo.NHANVIEN WHERE NGAYSINH LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVien>(model.ConnectString.GetData(query));
                case 4:
                    query = string.Format("SELECT * FROM dbo.NHANVIEN WHERE DIACHI LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVien>(model.ConnectString.GetData(query));
                case 5:
                    query = string.Format("SELECT * FROM dbo.NHANVIEN WHERE MABP LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVien>(model.ConnectString.GetData(query));
                case 6:
                    query = string.Format("SELECT * FROM dbo.NHANVIEN WHERE DIENTHOAI LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVien>(model.ConnectString.GetData(query));
                case 7:
                    query = string.Format("SELECT * FROM dbo.NHANVIEN ", TuKhoa);
                    return Helper.ToListof<NhanVien>(model.ConnectString.GetData(query));
            }
            return Helper.ToListof<NhanVien>(model.ConnectString.GetData("SELECT * FROM dbo.NHANVIEN"));
        }
    }
}
