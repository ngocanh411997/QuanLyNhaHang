using QuanLyNhaHang.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.controller
{
    public class MonAnController
    {
        KetNoi_A conn = new KetNoi_A();
        public DataTable GetDataProc()
        {
            return conn.GetDataProc("MA_SelectAll", null);
        }
        public int InsertData(MonAn MA)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAMON",MA.MaMon),
                new SqlParameter("MANHOMMON",MA.MaNhomMon),
                new SqlParameter("TENMON",MA.TenMon),
                new SqlParameter("DONVITINH",MA.DonViTinh),
                new SqlParameter ("GIA",MA.Gia),
            };
            return conn.ExcuteSQL("ThemMA", para);
        }
        public int UpdateData(MonAn MA)
        {
            SqlParameter[] para =
           {
                new SqlParameter("MAMON",MA.MaMon),
                new SqlParameter("MANHOMMON",MA.MaNhomMon),
                new SqlParameter("TENMON",MA.TenMon),
                new SqlParameter("DONVITINH",MA.DonViTinh),
                new SqlParameter ("GIA",MA.Gia),
            };
            return conn.ExcuteSQL("SuaMA", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAMON",ID)
        };
            return conn.ExcuteSQL("XoaMA", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From MonAn", "MA");
        }
        public DataTable GetListNhomMon()
        {
            return conn.GetDataProc("NM_SelectAll ", null);
        }
        public DataTable TimKiemMA(string strTimKiem)
        {
            return conn.GetDataStr(strTimKiem);
        }
    }
}
