using QuanLyNhaHang.controller;
using QuanLyNhaHang.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.BUS
{
    public class PhieuYeuCauBUS
    {
        PhieuYeuCauController da = new PhieuYeuCauController();
        public DataTable GetDataProc()
        {
            return da.GetDataProc();
        }
        public DataTable GetDataThanhToan(string Str)
        {
            return da.GetDataThanhToan(Str);
        }
        public int InsertData(PhieuYeuCau PYC)
        {
            return da.InsertData(PYC);
        }
        public int UpdateData(PhieuYeuCau PYC)
        {
            return da.UpdateData(PYC);
        }
        public int DeleteData(string ID)
        {
            return da.DeleteData(ID);
        }
        public string TangMa()
        {
            return da.TangMa();
        }
        public DataTable TimKiemPYC(string strTimKiem)
        {
            return da.TimKiemPYC(strTimKiem);
        }
        ////////////////

        public DataTable DataCTYC(string strCTYC)
        {
            return da.DataCTYC(strCTYC);
        }
        public int InsertDataCT(ChiTietPhieuYeuCau CTPYC)
        {
            return da.InsertDataCT(CTPYC);
        }
        public int UpdateDataCT(ChiTietPhieuYeuCau CTPYC)
        {
            return da.UpdateDataCT(CTPYC);
        }
        public int DeleteDataCT(string ID)
        {
            return da.DeleteData(ID);
        }
        public DataTable GetListMonAn()
        {
            return da.GetListMonAn();
        }

    }
}
