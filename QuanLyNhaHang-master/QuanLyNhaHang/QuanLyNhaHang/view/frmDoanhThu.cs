using QuanLyNhaHang.BUS;
using QuanLyNhaHang.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaHang.view
{
    public partial class frmDoanhThu : Form
    {
        PhieuYeuCau obj = new PhieuYeuCau();
        ChiTietPhieuYeuCau CT = new ChiTietPhieuYeuCau();
        PhieuYeuCauBUS Bus = new PhieuYeuCauBUS();
        public frmDoanhThu()
        {
            InitializeComponent();
        }
        private void HienThiNgay()
        {
            dgvDTNgay.DataSource = Bus.DTNgay();
            dgvDTThang.AutoResizeColumns();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            HienThiNgay();
        }
    }
}
