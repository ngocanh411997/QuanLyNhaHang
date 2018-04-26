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
                new SqlParameter("NGAYNHAP",PYC.NGAYNHAP),
                new SqlParameter("TRANGTHAI",PYC.TRANGTHAI)
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
                new SqlParameter("NGAYNHAP",PYC.NGAYNHAP),
                new SqlParameter("TRANGTHAI",PYC.TRANGTHAI)
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
                new SqlParameter("SOLUONG",CTPYC.SOLUONG),
                new SqlParameter("GIA",CTPYC.GIA),
                new SqlParameter("THANHTIEN",CTPYC.THANHTIEN)

            };
            return conn.ExcuteSQL("ThemCTPYC", para);
        }
        public int UpdateDataCT(ChiTietPhieuYeuCau CTPYC)
        {
            SqlParameter[] para =
           {
               new SqlParameter("MAPHIEU",CTPYC.MAPHIEU),
                new SqlParameter("MAMON",CTPYC.MAMON),
                new SqlParameter("SOLUONG",CTPYC.SOLUONG),
                new SqlParameter("GIA",CTPYC.GIA),
                new SqlParameter("THANHTIEN",CTPYC.THANHTIEN)
            };
            return conn.ExcuteSQL("SuaCTPYC", para);
        }
        public int DeleteDataCT(string IDMP, string IDMM)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAPHIEU",IDMP),
                new SqlParameter("MAMON",IDMM)

        };
            return conn.ExcuteSQL("XoaCTPYC", para);
        }
        public DataTable GetListMonAn()
        {
            return conn.GetDataProc("MA_SelectAll ", null);
        }
        /// <summary>
        /// Sau khi thanh toán, trạng thái hóa đơn chuyển từ chưa thanh toán sang đã thanh toán
        /// </summary>
        /// <param name="PYC"></param>
        /// <returns></returns>
        public int UpdateDataTT(PhieuYeuCau PYC)
        {
            SqlParameter[] para =
           {
               new SqlParameter("MAPHIEU",PYC.MAPHIEU),
                new SqlParameter("TRANGTHAI",PYC.TRANGTHAI)
            };
            return conn.ExcuteSQL("DaTT", para);
        }
        // Quản lý hóa đơn đã thanh toán
        public DataTable GetDataHoaDonTT()
        {
            return conn.GetDataProc("HoaDonDaTT", null);
        }

        ///
        public DataTable GetListNV()
        {
            return conn.GetDataStr("Select * FROM dbo.NHANVIEN where MABP Like 'BP03'");
        }
        // Doanh thu
        public DataTable DTNgay()
        {
            return conn.GetDataProc("DTNgay", null);
        }


    }
}
