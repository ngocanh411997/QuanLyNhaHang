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
    public partial class frmChiTietPhieuYC : Form
    {
        ChiTietPhieuYeuCau obj = new ChiTietPhieuYeuCau();
        PhieuYeuCauBUS Bus = new PhieuYeuCauBUS();
        private int fluu = 1;
        public frmChiTietPhieuYC()
        {
            InitializeComponent();
        }
        string ma="";
        public frmChiTietPhieuYC(string text):this()
        {
            ma = text;
        }
        public void ShowMA()
        {
            DataTable dt = new DataTable();
            dt = Bus.GetListMonAn();
            cbMonAn.DataSource = dt;
            cbMonAn.DisplayMember = "TENMON";
            cbMonAn.ValueMember = "MAMON";
        }
        private void DisEnl(bool e)
        {
            btnThemCT.Enabled = !e;
            btnXoaCT.Enabled = !e;
            btnSuaCT.Enabled = !e;
            btnLuuCT.Enabled = e;
            btnHuy.Enabled = e;
            txtSoLuong.Enabled = e;
            cbMonAn.Enabled = e;
            txtGia.Enabled = e;
        }
        private void HienThi()
        {
            txt_MaPhieu.Text = ma;
            dgvChiTietPYC.DataSource = Bus.DataCTYC("SELECT CHITIETPHIEUYC.MAPHIEU,TENMON,SOLUONG,CHITIETPHIEUYC.GIA,THANHTIEN FROM dbo.CHITIETPHIEUYC INNER JOIN dbo.MONAN ON MONAN.MAMON = CHITIETPHIEUYC.MAMON AND CHITIETPHIEUYC.MAPHIEU like '" + txt_MaPhieu.Text.Trim() + "'");
            txt_MaPhieu.Enabled = false;
            ShowMA();
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            fluu = 0;
            DisEnl(true);
            txt_MaPhieu.Enabled = false;
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txt_MaPhieu.Enabled = false;
            cbMonAn.Enabled = false;
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteDataCT(txt_MaPhieu.Text, cbMonAn.SelectedValue.ToString());
                    MessageBox.Show("Xóa thành công!");
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            if (txt_MaPhieu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbMonAn.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập món ăn! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int _soLuong;
            int.TryParse(txtSoLuong.Text, out _soLuong);

            int _gia;
            int.TryParse(txtGia.Text, out _gia);

            obj.MAMON = cbMonAn.SelectedValue.ToString();
            obj.MAPHIEU = txt_MaPhieu.Text;
            obj.SOLUONG = _soLuong;
            obj.GIA = _gia;

            if (txt_MaPhieu.Text != "" && txtSoLuong.Text != "" && cbMonAn.Text != "" && txtGia.Text !="" && fluu == 0)
            {
                try
                {
                    Bus.InsertDataCT(obj);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmChiTietPhieuYC_Load(sender, e);
                    DisEnl(false);
                    fluu = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
            else if (txt_MaPhieu.Text != "" && txtSoLuong.Text != "" && cbMonAn.Text != "" && txtGia.Text != "" && fluu != 0)
            {
                try
                {
                    Bus.UpdateDataCT(obj);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmChiTietPhieuYC_Load(sender, e);
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
                fluu = 1;

            }
            else
                return;
        }

        private void btnDSCT_Click(object sender, EventArgs e)
        {
            dgvChiTietPYC.DataSource = Bus.DataCTYC("SELECT CHITIETPHIEUYC.MAPHIEU,TENMON,SOLUONG,CHITIETPHIEUYC.GIA,THANHTIEN FROM dbo.CHITIETPHIEUYC INNER JOIN dbo.MONAN ON MONAN.MAMON = CHITIETPHIEUYC.MAMON ");
            DisEnl(true);
            txt_MaPhieu.Enabled = false;
            btnLuuCT.Enabled=false;
            ShowMA();
           
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThanhToan TT = new frmThanhToan(txt_MaPhieu.Text);
            TT.ShowDialog();
            this.Show();
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

        private void frmChiTietPhieuYC_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvChiTietPYC_CellClick(object sender, DataGridViewCellEventArgs e)
        {        
            cbMonAn.Text = Convert.ToString(dgvChiTietPYC.CurrentRow.Cells["TENMON"].Value);
            txtSoLuong.Text = Convert.ToString(dgvChiTietPYC.CurrentRow.Cells["SoLuong"].Value);
            txtGia.Text = Convert.ToString(dgvChiTietPYC.CurrentRow.Cells["GIA"].Value);
        }

        private void dgvChiTietPYC_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvChiTietPYC.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnDSMon_Click(object sender, EventArgs e)
        {
            frmMonAn MonAn = new frmMonAn();
            MonAn.Show();

        }
    }
}
