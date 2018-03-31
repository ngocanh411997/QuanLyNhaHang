using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.controller
{
    class BoPhanCrt
    {

        public static DataTable GetListBoPhan()
        {
            return model.ConnectString.GetData("select *from bophan");
        }

    }
}
