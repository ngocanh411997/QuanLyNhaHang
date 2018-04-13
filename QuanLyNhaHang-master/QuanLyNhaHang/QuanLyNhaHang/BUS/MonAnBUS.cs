using QuanLyNhaHang.controller;
using QuanLyNhaHang.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.BUS
{
    public class MonAnBUS
    {
        MonAnController da = new MonAnController();
        public DataTable GetDataProc()
        {
            return da.GetDataProc();
        }
        public int InsertData(MonAn MA)
        {
            return da.InsertData(MA);
        }
        public int UpdateData(MonAn MA)
        {
            return da.UpdateData(MA);
        }
        public int DeleteData(string ID)
        {
            return da.DeleteData(ID);
        }
        public string TangMa()
        {
            return da.TangMa();
        }
        public DataTable GetListNhomMon()
        {
            return da.GetListNhomMon();
        }
        public DataTable TimKiemMA(string strTimKiem)
        {
            return da.TimKiemMA(strTimKiem);
        }
    }
}
