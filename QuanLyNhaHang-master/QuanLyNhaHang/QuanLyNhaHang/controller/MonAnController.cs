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

        public static List<MonAn> TimKiem(int type, string TuKhoa)
        {
            string query = "";
            KetNoi_A conn = new KetNoi_A();
            switch (type)
            {
                case 0:
                    query = string.Format("SELECT * FROM dbo.MONAN WHERE MAMON LIKE '%{0}%'", TuKhoa);
                    return Helper.ToListof<MonAn>(conn.GetDataStr(query));
                case 1:

                    query = string.Format("SELECT * FROM dbo.MonAn WHERE TENMON LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<MonAn>(conn.GetDataStr(query));
                case 2:
                    query = string.Format(" SELECT * FROM dbo.MonAn WHERE MANHOMMON LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<MonAn>(conn.GetDataStr(query));
                case 3:
                    query = string.Format("SELECT * FROM dbo.MonAn WHERE DONVITINH LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<MonAn>(conn.GetDataStr(query));
                case 4:
                    query = string.Format("SELECT * FROM dbo.MonAn WHERE GIA LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<MonAn>(conn.GetDataStr(query));
            }
            return Helper.ToListof<MonAn>(conn.GetDataStr("SELECT * FROM dbo.MONAN"));
        }
    }
}
