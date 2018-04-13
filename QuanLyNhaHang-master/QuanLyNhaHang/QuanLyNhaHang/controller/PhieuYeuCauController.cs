using QuanLyNhaHang.model;
using QuanLyNhaHang.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.controller
{
    public class PhieuYeuCauController
    {
        KetNoi_A conn = new KetNoi_A();
        public DataTable GetDataProc()
        {
            return conn.GetDataProc("PYC_SelectAll", null);
        }
        public DataTable GetDataThanhToan(string Str)
        {
            return conn.GetDataStr(Str);
        }
        public int InsertData(PhieuYeuCau PYC)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAPHIEU",PYC.MAPHIEU),
                new SqlParameter("MAKH",PYC.MAKH),
                new SqlParameter("MANV",PYC.MANV),
                new SqlParameter("NGAYNHAP",PYC.NGAYNHAP)       
            };
            return conn.ExcuteSQL("ThemPYC", para);
        }
        public int UpdateData(PhieuYeuCau PYC)
        {
            SqlParameter[] para =
           {
                new SqlParameter("MAPHIEU",PYC.MAPHIEU),
                new SqlParameter("MAKH",PYC.MAKH),
                new SqlParameter("MANV",PYC.MANV),
                new SqlParameter("NGAYNHAP",PYC.NGAYNHAP)
            };
            return conn.ExcuteSQL("SuaPYC", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAPHIEU",ID)
        };
            return conn.ExcuteSQL("XoaPYC", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From PHIEUYC", "MP");
        }
        public DataTable TimKiemPYC(string strTimKiem)
        {
            return conn.GetDataStr(strTimKiem);
        }

        ////////////////////
        public DataTable DataCTYC(string strCTYC)
        {
            return conn.GetDataStr(strCTYC);
        }
        public int InsertDataCT(ChiTietPhieuYeuCau CTPYC)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAPHIEU",CTPYC.MAPHIEU),
                new SqlParameter("MAMON",CTPYC.MAMON),
                new SqlParameter("SOLUONG",CTPYC.SOLUONG)
              
            };
            return conn.ExcuteSQL("ThemCTPYC", para);
        }
        public int UpdateDataCT(ChiTietPhieuYeuCau CTPYC)
        {
            SqlParameter[] para =
           {
               new SqlParameter("MAPHIEU",CTPYC.MAPHIEU),
                new SqlParameter("MAMON",CTPYC.MAMON),
                new SqlParameter("SOLUONG",CTPYC.SOLUONG)
            };
            return conn.ExcuteSQL("SuaCTPYC", para);
        }
        public int DeleteDataCT(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAPHIEU",ID)
        };
            return conn.ExcuteSQL("XoaCTPYC", para);
        }
        public DataTable GetListMonAn()
        {
            return conn.GetDataProc("MA_SelectAll ", null);
        }
    }
}
