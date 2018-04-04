using QuanLyNhaHang.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHang.model;
namespace QuanLyNhaHang.controller
{
    public class NguoiDungCrt        
    {
      
       public DataTable DangNhap(string TaiKhoan, string MatKhau)
        {
            string sql = "";
            sql = string.Format("SELECT TAIKHOAN FROM dbo.NGUOIDUNG WHERE MANV='{0}' and MATKHAU = '{1}'",TaiKhoan ,MatKhau);

            return model.ConnectString.GetData("select * from NGUOIDUNG");
        }
         
        public DataTable GetUser()
        {
            throw new NotImplementedException();
        }
    }
}
