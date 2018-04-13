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
    public partial class frmPhieuYC : Form
    {
        PhieuYeuCau obj = new PhieuYeuCau();
        ChiTietPhieuYeuCau CT = new ChiTietPhieuYeuCau();
        PhieuYeuCauBUS Bus = new PhieuYeuCauBUS();
        private int fluu = 1;
        public frmPhieuYC()
        {
            InitializeComponent();
        }
        public void ShowMonAn()
        {
            DataTable dt = new DataTable();
            dt = Bus.GetListMonAn();
            cbMonAn.DataSource = dt;
            cbMonAn.DisplayMember = "TENMON";
            cbMonAn.ValueMember = "MAMON";

        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaPhieu.Enabled = e;
            txtMaKH.Enabled = e;
            txtMaNV.Enabled = e;
            dtNgayNhap.Enabled = e;           
        }
        private void DisEnlCT(bool e)
        {
            btnThemCT.Enabled = !e;
            btnXoaCT.Enabled = !e;
            btnSuaCT.Enabled = !e;
            btnLuuCT.Enabled = e;
            btnHuy.Enabled = e;
            txt_MaPhieu.Enabled = e;
            cbMonAn.Enabled = e;
            txtSoLuong.Enabled = e;    
        }
        private void clearData()
        {
            txtMaPhieu.Text = "";
            txtMaKH.Text = "";
            txtMaNV.Text = "";
        }
        private void HienThi()
        {
            dgvPhieuYeuCau.DataSource = Bus.GetDataProc();
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

        private void frmPhieuYC_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
            DisEnlCT(false);
            ShowMonAn();
            txt_MaPhieu.Enabled = false;
            btnThanhToan.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {           
                fluu = 0;
                txtMaPhieu.Text = Bus.TangMa();
                DisEnl(true);
                txtMaPhieu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaPhieu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteData(txtMaPhieu.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaPhieu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu yêu cầu! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập khách hàng! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nhân viên! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            obj.MAPHIEU = txtMaPhieu.Text;
            obj.MAKH = txtMaKH.Text;
            obj.MANV = txtMaNV.Text;
            obj.NGAYNHAP = dtNgayNhap.Value;


            if (txtMaPhieu.Text != "" && txtMaKH.Text != ""&& txtMaNV.Text != "" && fluu == 0)
            {
                try
                {
                    Bus.InsertData(obj);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmPhieuYC_Load(sender, e);
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch
                {

                }
            }
            else if (txtMaPhieu.Text != "" && txtMaKH.Text != "" && txtMaNV.Text != "" && fluu != 0)
            {
                try
                {
                    Bus.UpdateData(obj);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmPhieuYC_Load(sender, e);
                    clearData();
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
                DisEnlCT(false);
                fluu = 1;

            }
            else
                return;
        }

        private void btnLamTrong_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void dgvPhieuYeuCau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtMaKH.Text = Convert.ToString(dgvPhieuYeuCau.CurrentRow.Cells["MAKH"].Value);
                txtMaNV.Text = Convert.ToString(dgvPhieuYeuCau.CurrentRow.Cells["MANV"].Value);
                dtNgayNhap.Text = Convert.ToString(dgvPhieuYeuCau.CurrentRow.Cells["NGAYNHAP"].Value);
            }
            else if(fluu !=0 && fluu!=-1)
            {
                txtMaPhieu.Text= Convert.ToString(dgvPhieuYeuCau.CurrentRow.Cells["MAPHIEU"].Value);
                txt_MaPhieu.Text = Convert.ToString(dgvPhieuYeuCau.CurrentRow.Cells["MAPHIEU"].Value);
                txtMaKH.Text = Convert.ToString(dgvPhieuYeuCau.CurrentRow.Cells["MAKH"].Value);
                txtMaNV.Text = Convert.ToString(dgvPhieuYeuCau.CurrentRow.Cells["MANV"].Value);
                dtNgayNhap.Text = Convert.ToString(dgvPhieuYeuCau.CurrentRow.Cells["NGAYNHAP"].Value);
            }
        }

        private void dgvPhieuYeuCau_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvPhieuYeuCau.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Mã Phiếu")
            {
                dgvPhieuYeuCau.DataSource = Bus.TimKiemPYC("SELECT * from PHIEUYEUCAU WHERE MAPHIEU like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Khách Hàng")
            {
                dgvPhieuYeuCau.DataSource = Bus.TimKiemPYC("SELECT * from PHIEUYEUCAU WHERE MAKH like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Nhân Viên")
            {
                dgvPhieuYeuCau.DataSource = Bus.TimKiemPYC("SELECT * from PHIEUYEUCAU WHERE MANV like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Ngày Nhập")
            {
                dgvPhieuYeuCau.DataSource = Bus.TimKiemPYC("SELECT * from PHIEUYEUCAU WHERE NGAYNHAP like '%" + txtTimKiem.Text.Trim() + "%'");
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            fluu = -1;
            DisEnlCT(true);
            txtMaKH.Enabled = false;
            txtMaNV.Enabled = false;
            dtNgayNhap.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
              
            txtMaPhieu.Enabled = false;
            txt_MaPhieu.Enabled = false;
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            if (txt_MaPhieu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu yêu cầu! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbMonAn.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã món! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int _soLuong;
            int.TryParse(txtSoLuong.Text, out _soLuong);


            CT.MAPHIEU = txt_MaPhieu.Text;
            CT.MAMON = cbMonAn.Text;
            CT.SOLUONG =_soLuong ;


            if (txtMaPhieu.Text != "" && cbMonAn.Text != "" && txtSoLuong.Text != "" && fluu == -1)
            {
                try
                {
                    Bus.InsertDataCT(CT);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    HienThiCT();
                    frmPhieuYC_Load(sender, e);
                    clearData();
                    DisEnl(false);
                    fluu = 22;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
            else if (txtMaPhieu.Text != "" && cbMonAn.Text != "" && txtSoLuong.Text != "" && fluu !=-1)
            {
                try
                {
                    Bus.UpdateDataCT(CT);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    HienThiCT();
                    frmPhieuYC_Load(sender, e);
                    clearData();
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }

        }

        private void dgvChiTietPYC_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvChiTietPYC.Rows[e.RowIndex].Cells["_STT"].Value = e.RowIndex + 1;
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            fluu = 2;
            DisEnl(true);
            DisEnlCT(true);
            btnLamMoi.Enabled = false;
            btnLuu.Enabled = false;
            txtMaPhieu.Enabled = false;
            txt_MaPhieu.Enabled = false;
            
        }

        private void HienThiCT()
        {
            dgvChiTietPYC.DataSource = Bus.DataCTYC("SELECT CHITIETPHIEUYC.MAPHIEU,MONAN.TENMON,SOLUONG, THANHTIEN=(SOLUONG*GIA) FROM dbo.CHITIETPHIEUYC INNER JOIN dbo.PHIEUYC ON PHIEUYC.MAPHIEU = CHITIETPHIEUYC.MAPHIEU INNER JOIN dbo.MONAN ON MONAN.MAMON = CHITIETPHIEUYC.MAMON AND CHITIETPHIEUYC.MAPHIEU='" + txt_MaPhieu.Text.Trim() + "'");
        }
        

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            frmThanhToan ThanhToan = new frmThanhToan(txt_MaPhieu.Text);
            ThanhToan.ShowDialog();
        }

        private void btnCT_Click(object sender, EventArgs e)
        {
            HienThiCT();
            btnThanhToan.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnDSCT_Click(object sender, EventArgs e)
        {
            dgvChiTietPYC.DataSource = Bus.DataCTYC("SELECT CHITIETPHIEUYC.MAPHIEU,MONAN.TENMON,SOLUONG, THANHTIEN=(SOLUONG*GIA) FROM dbo.CHITIETPHIEUYC INNER JOIN dbo.PHIEUYC ON PHIEUYC.MAPHIEU = CHITIETPHIEUYC.MAPHIEU INNER JOIN dbo.MONAN ON MONAN.MAMON = CHITIETPHIEUYC.MAMON");
            btnHuy.Enabled = true;
        }
    }
}
