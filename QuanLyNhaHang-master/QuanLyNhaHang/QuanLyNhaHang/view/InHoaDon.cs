using CrystalDecisions.CrystalReports.Engine;
using QuanLyNhaHang.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaHang
{
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }

        KetNoi_A dblayer = new KetNoi_A();
        ReportDocument cry = new ReportDocument();
        string ma;
        public InHoaDon(string text):this()
        {
            ma = text;
        }
        private void InHoaDon_Load(object sender, EventArgs e)
        {
            txtMaPhieu.Text = ma;
            txtMaPhieu.Enabled = false;
            List<HoaDon> _List = new List<HoaDon>();
            DataSet ds1 = dblayer.HD1("SELECT TENMON,SOLUONG,DONVITINH,CHITIETPHIEUYC.GIA,THANHTIEN FROM dbo.CHITIETPHIEUYC INNER JOIN dbo.MONAN ON MONAN.MAMON = CHITIETPHIEUYC.MAMON WHERE MAPHIEU='" + txtMaPhieu.Text + "'");
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                _List.Add(new HoaDon
                {
                    TENMON = dr["TENMON"].ToString(),
                    DONVITINH = dr["DONVITINH"].ToString(),
                    SOLUONG = Convert.ToInt32(dr["SOLUONG"].ToString()),
                    GIA = Convert.ToInt32(dr["GIA"].ToString()),
                    THANHTIEN = Convert.ToInt32(dr["THANHTIEN"].ToString())
                });
            }

            cry.Load(@"C:\Users\NgocAnh\Documents\GitHub\QuanLyNhaHang\QuanLyNhaHang-master\QuanLyNhaHang\QuanLyNhaHang\view\HoaDon.rpt");
            cry.SetDataSource(ds1);
            crystalReportViewer1.ReportSource = cry;
            //
            DataSet ds2 = dblayer.HD2("SELECT CHITIETPHIEUYC.MAPHIEU,MANV,NGAYNHAP,KHACHHANG.MAKH,TENKH,SUM(THANHTIEN) AS TONGTIEN FROM dbo.KHACHHANG INNER JOIN dbo.PHIEUYC ON PHIEUYC.MAKH = KHACHHANG.MAKH INNER JOIN dbo.CHITIETPHIEUYC ON CHITIETPHIEUYC.MAPHIEU = PHIEUYC.MAPHIEU INNER JOIN dbo.MONAN ON MONAN.MAMON = CHITIETPHIEUYC.MAMON WHERE CHITIETPHIEUYC.MAPHIEU='"+txtMaPhieu.Text+"' GROUP BY CHITIETPHIEUYC.MAPHIEU, MANV, NGAYNHAP, KHACHHANG.MAKH, TENKH");
            foreach(DataRow dr in ds2.Tables[0].Rows)
            {
                hoaDon1.SetDataSource(_List);
                hoaDon1.SetParameterValue("pMaPhieu",dr["MAPHIEU"].ToString());
                hoaDon1.SetParameterValue("pMaNV", dr["MANV"].ToString());
                hoaDon1.SetParameterValue("pNgay", dr["NGAYNHAP"].ToString());
                hoaDon1.SetParameterValue("pMaKH", dr["MAKH"].ToString());
                hoaDon1.SetParameterValue("pTenKH", dr["TENKH"].ToString());
                hoaDon1.SetParameterValue("pTongTien", Convert.ToInt32(dr["TONGTIEN"].ToString()));         
            }
            crystalReportViewer1.ReportSource = hoaDon1;

        }
        

    }
}
