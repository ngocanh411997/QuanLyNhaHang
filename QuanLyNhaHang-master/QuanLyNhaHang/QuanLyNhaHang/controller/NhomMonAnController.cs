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
    public class NhomMonAnController
    {
        KetNoi_A conn = new KetNoi_A();
        public DataTable GetDataProc()
        {
            return conn.GetDataProc("NM_SelectAll", null);
        }
        public int InsertData(NhomMonAn NM)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MANHOMMON",NM.MANHOMMON),
                new SqlParameter("TENNHOMMON",NM.TENNHOMMON)               
            };
            return conn.ExcuteSQL("ThemNM", para);
        }
        public int UpdateData(NhomMonAn NM)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MANHOMMON",NM.MANHOMMON),
                new SqlParameter("TENNHOMMON",NM.TENNHOMMON)

        };
            return conn.ExcuteSQL("SuaNM", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MANHOMMON",ID)
        };
            return conn.ExcuteSQL("XoaNM", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From NhomMonAn", "MN");
        }
        public DataTable TimKiemNM(string strTimKiem)
        {
            return conn.GetDataStr(strTimKiem);
        }
    }
}
