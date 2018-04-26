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
            dgvThanhToan.DataSource = Bus.GetDataThanhToan("SELECT CHITIETPHIEUYC.MAPHIEU,TENKH, SUM(THANHTIEN) AS TONGTIEN FROM dbo.CHITIETPHIEUYC INNER JOIN dbo.PHIEUYC ON PHIEUYC.MAPHIEU = CHITIETPHIEUYC.MAPHIEU INNER JOIN dbo.KHACHHANG ON KHACHHANG.MAKH = PHIEUYC.MAKH WHERE CHITIETPHIEUYC.MAPHIEU = '"+txtMaPhieu.Text+"' GROUP BY CHITIETPHIEUYC.MAPHIEU, TENKH");           
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

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dgvThanhToan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvThanhToan.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            obj.MAPHIEU = txtMaPhieu.Text;
            Bus.UpdateDataTT(obj);
            MessageBox.Show("Xuất hóa đơn thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            InHoaDon HD = new InHoaDon(txtMaPhieu.Text);
            HD.ShowDialog();
            this.Show();
        }
    }
}
