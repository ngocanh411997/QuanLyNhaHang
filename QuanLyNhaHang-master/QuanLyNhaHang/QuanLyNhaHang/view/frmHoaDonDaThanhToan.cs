using QuanLyNhaHang.BUS;
using QuanLyNhaHang.Helper;
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
    public partial class frmHoaDonDaThanhToan : Form
    {
        PhieuYeuCau obj = new PhieuYeuCau();
        ChiTietPhieuYeuCau CT = new ChiTietPhieuYeuCau();
        PhieuYeuCauBUS Bus = new PhieuYeuCauBUS();
        public frmHoaDonDaThanhToan()
        {
            InitializeComponent();
        }
        private void HienThi()
        {
            dgvHoaDon.DataSource = Bus.GetDataHoaDonTT();
            dgvHoaDon.AutoResizeColumns();
        }
        private void HienThiCT()
        {
            dgvChiTietHoaDon.DataSource = Bus.DataCTYC("SELECT MAPHIEU,TENMON,SOLUONG,CHITIETPHIEUYC.GIA,THANHTIEN FROM dbo.CHITIETPHIEUYC INNER JOIN dbo.MONAN ON MONAN.MAMON = CHITIETPHIEUYC.MAMON WHERE MAPHIEU = '"+txtMaPhieu.Text+"'");
            dgvChiTietHoaDon.AutoResizeColumns();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {             
                this.Close();
            }
            else
                HienThi();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieu.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MAPHIEU"].Value);           
            HienThiCT();            
        }

        private void dgvHoaDon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHoaDon.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvChiTietHoaDon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvChiTietHoaDon.Rows[e.RowIndex].Cells["_STT"].Value = e.RowIndex + 1;
        }

        private void frmHoaDonDaThanhToan_Load(object sender, EventArgs e)
        {
            HienThi();
            txtMaPhieu.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
            txtMaPhieu.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (cbTimKiem.Text == "Mã Phiếu")
            {
                dgvHoaDon.DataSource = Bus.TimKiemPYC("SELECT CHITIETPHIEUYC.MAPHIEU,TENKH,MANV,NGAYNHAP,SUM(THANHTIEN) AS TONGTIEN FROM dbo.KHACHHANG INNER JOIN dbo.PHIEUYC ON PHIEUYC.MAKH = KHACHHANG.MAKH INNER JOIN dbo.CHITIETPHIEUYC ON CHITIETPHIEUYC.MAPHIEU = PHIEUYC.MAPHIEU WHERE CHITIETPHIEUYC.MAPHIEU = 'Đã thanh toán' and CHITIETPHIEUYC.MAPHIEU like '"+txtMaPhieu.Text+"'  GROUP BY CHITIETPHIEUYC.MAPHIEU, TENKH, MANV, NGAYNHAP");
            }
            if (cbTimKiem.Text == "Khách Hàng")
            {
                dgvHoaDon.DataSource = Bus.TimKiemPYC("SELECT CHITIETPHIEUYC.MAPHIEU,TENKH,MANV,NGAYNHAP,SUM(THANHTIEN) AS TONGTIEN FROM dbo.KHACHHANG INNER JOIN dbo.PHIEUYC ON PHIEUYC.MAKH = KHACHHANG.MAKH INNER JOIN dbo.CHITIETPHIEUYC ON CHITIETPHIEUYC.MAPHIEU = PHIEUYC.MAPHIEU WHERE CHITIETPHIEUYC.MAPHIEU = 'Đã thanh toán' and TENKH like N'" + txtMaPhieu.Text + "'  GROUP BY CHITIETPHIEUYC.MAPHIEU, TENKH, MANV, NGAYNHAP");
            }
            if (cbTimKiem.Text == "Nhân Viên")
            {
                dgvHoaDon.DataSource = Bus.TimKiemPYC("SELECT CHITIETPHIEUYC.MAPHIEU,TENKH,MANV,NGAYNHAP,SUM(THANHTIEN) AS TONGTIEN FROM dbo.KHACHHANG INNER JOIN dbo.PHIEUYC ON PHIEUYC.MAKH = KHACHHANG.MAKH INNER JOIN dbo.CHITIETPHIEUYC ON CHITIETPHIEUYC.MAPHIEU = PHIEUYC.MAPHIEU WHERE CHITIETPHIEUYC.MAPHIEU = 'Đã thanh toán' and MANV like '" + txtMaPhieu.Text + "'  GROUP BY CHITIETPHIEUYC.MAPHIEU, TENKH, MANV, NGAYNHAP");
            }
            if (cbTimKiem.Text == "Ngày Nhập")
            {
                dgvHoaDon.DataSource = Bus.TimKiemPYC("SELECT CHITIETPHIEUYC.MAPHIEU,TENKH,MANV,NGAYNHAP,SUM(THANHTIEN) AS TONGTIEN FROM dbo.KHACHHANG INNER JOIN dbo.PHIEUYC ON PHIEUYC.MAKH = KHACHHANG.MAKH INNER JOIN dbo.CHITIETPHIEUYC ON CHITIETPHIEUYC.MAPHIEU = PHIEUYC.MAPHIEU WHERE CHITIETPHIEUYC.MAPHIEU = 'Đã thanh toán' and NGAYNHAP like '" + txtMaPhieu.Text + "'  GROUP BY CHITIETPHIEUYC.MAPHIEU, TENKH, MANV, NGAYNHAP");
            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            files.ExportToExcel(dgvHoaDon);
        }
    }
}
