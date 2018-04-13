using QuanLyNhaHang.BUS;
using QuanLyNhaHang.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang.view
{
    public partial class frmThanhToan : Form
    {
        PhieuYeuCau obj = new PhieuYeuCau();
        PhieuYeuCauBUS Bus = new PhieuYeuCauBUS();
        public frmThanhToan()
        {
            InitializeComponent();
        }
        string MaPhieu = "";
        public frmThanhToan(string text): this()
        {
            MaPhieu = text;
        }
        private void HienThi()
        {
            txtMaPhieu.Text = MaPhieu;
            txtMaPhieu.Enabled = false;
            dgvThanhToan.DataSource = Bus.GetDataThanhToan("SELECT A.MAPHIEU,TENKH,SUM(A.THANHTIEN) AS THANHTOAN FROM dbo.KHACHHANG, (SELECT CHITIETPHIEUYC.MAPHIEU, MAKH, CHITIETPHIEUYC.MAMON, SOLUONG, THANHTIEN = (SOLUONG * GIA) FROM dbo.CHITIETPHIEUYC INNER JOIN dbo.PHIEUYC ON PHIEUYC.MAPHIEU = CHITIETPHIEUYC.MAPHIEU INNER JOIN dbo.MONAN ON MONAN.MAMON = CHITIETPHIEUYC.MAMON AND CHITIETPHIEUYC.MAPHIEU = '"+txtMaPhieu.Text+"') A WHERE A.MAKH = KHACHHANG.MAKH GROUP BY A.MAPHIEU,TENKH");           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmQuanLyChung QL = new frmQuanLyChung();
                QL.Show();
                this.Close();
            }
            else
                HienThi();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dgvThanhToan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvThanhToan.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
