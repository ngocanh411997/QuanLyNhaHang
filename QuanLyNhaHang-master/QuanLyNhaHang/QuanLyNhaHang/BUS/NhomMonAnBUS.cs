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
    public class NhomMonAnBUS
    {
        NhomMonAnController da = new NhomMonAnController();
        public DataTable GetDataProc()
        {
            return da.GetDataProc();
        }
        public int InsertData(NhomMonAn NM)
        {
            return da.InsertData(NM);
        }
        public int UpdateData(NhomMonAn NM)
        {
            return da.UpdateData(NM);
        }
        public int DeleteData(string ID)
        {
            return da.DeleteData(ID);
        }
        public string TangMa()
        {
            return da.TangMa();
        }
    }
}
