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
    public partial class frmPhieuYC : Form
    {
        PhieuYeuCau obj = new PhieuYeuCau();
        ChiTietPhieuYeuCau CT = new ChiTietPhieuYeuCau();
        PhieuYeuCauBUS Bus = new PhieuYeuCauBUS();
        private int fluu=1;
        public frmPhieuYC()
        {
            InitializeComponent();
        }       
        public void ShowNV()
        {
            DataTable dt = new DataTable();
            dt = Bus.GetListNV();
            cbMaNV.DataSource = dt;
            cbMaNV.DisplayMember = "MANV";
            cbMaNV.ValueMember = "MANV";
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
            cbMaNV.Enabled = e;
            dtNgayNhap.Enabled = e;           
        }
        private void clearData()
        {
            txtMaPhieu.Text = "";
            txtMaKH.Text = "";
            cbMaNV.Text = "";
        }
        private void HienThi()
        {
            dgvPhieuYeuCau.DataSource = Bus.GetDataProc();
            dgvPhieuYeuCau.AutoResizeColumns();
            ShowNV();
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

        private void frmPhieuYC_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);                          
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
            if (cbMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nhân viên! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if (dtNgayNhap.Value != DateTime.Now)
            //{
            //    MessageBox.Show("Bạn nhập sai ngày! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            obj.MAPHIEU = txtMaPhieu.Text;
            obj.MAKH = txtMaKH.Text;
            obj.MANV = cbMaNV.Text;
            obj.NGAYNHAP = dtNgayNhap.Value;
            if (txtMaPhieu.Text != "" && txtMaKH.Text != ""&& cbMaNV.Text != "" && fluu == 0)
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
            else if (txtMaPhieu.Text != "" && txtMaKH.Text != "" && cbMaNV.Text != "" && fluu != 0)
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
                cbMaNV.Text = Convert.ToString(dgvPhieuYeuCau.CurrentRow.Cells["MANV"].Value);
                dtNgayNhap.Text = Convert.ToString(dgvPhieuYeuCau.CurrentRow.Cells["NGAYNHAP"].Value);             
            }
            else if(fluu !=0 && fluu!=-1)
            {
                txtMaPhieu.Text= Convert.ToString(dgvPhieuYeuCau.CurrentRow.Cells["MAPHIEU"].Value);            
                txtMaKH.Text = Convert.ToString(dgvPhieuYeuCau.CurrentRow.Cells["MAKH"].Value);
                cbMaNV.Text = Convert.ToString(dgvPhieuYeuCau.CurrentRow.Cells["MANV"].Value);
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
                dgvPhieuYeuCau.DataSource = Bus.TimKiemPYC("SELECT MAPHIEU,KHACHHANG.MAKH,TENKH,MANV,NGAYNHAP,TRANGTHAI FROM dbo.PHIEUYC INNER JOIN dbo.KHACHHANG ON KHACHHANG.MAKH = PHIEUYC.MAKH WHERE MAPHIEU like '%" + txtTimKiem.Text.Trim() + "%' and TRANGTHAI=N'Chưa thanh toán' ");
            }
            if (cbTimKiem.Text == "Khách Hàng")
            {
                dgvPhieuYeuCau.DataSource = Bus.TimKiemPYC("SELECT MAPHIEU,KHACHHANG.MAKH,TENKH,MANV,NGAYNHAP,TRANGTHAI FROM dbo.PHIEUYC INNER JOIN dbo.KHACHHANG ON KHACHHANG.MAKH = PHIEUYC.MAKH WHERE TENKH like N'%" + txtTimKiem.Text.Trim() + "%' and TRANGTHAI=N'Chưa thanh toán' ");
            }
            if (cbTimKiem.Text == "Nhân Viên")
            {
                dgvPhieuYeuCau.DataSource = Bus.TimKiemPYC("SELECT MAPHIEU,KHACHHANG.MAKH,TENKH,MANV,NGAYNHAP,TRANGTHAI FROM dbo.PHIEUYC INNER JOIN dbo.KHACHHANG ON KHACHHANG.MAKH = PHIEUYC.MAKH WHERE MANV like '%" + txtTimKiem.Text.Trim() + "%' and TRANGTHAI=N'Chưa thanh toán' ");
            }
            if (cbTimKiem.Text == "Ngày Nhập")
            {
                dgvPhieuYeuCau.DataSource = Bus.TimKiemPYC("SELECT MAPHIEU,KHACHHANG.MAKH,TENKH,MANV,NGAYNHAP,TRANGTHAI FROM dbo.PHIEUYC INNER JOIN dbo.KHACHHANG ON KHACHHANG.MAKH = PHIEUYC.MAKH WHERE NGAYNHAP like '%" + txtTimKiem.Text.Trim() + "%' and TRANGTHAI=N'Chưa thanh toán' ");
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
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

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            if(txtMaPhieu.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn mã phiếu! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                this.Hide();
                frmChiTietPhieuYC CT = new frmChiTietPhieuYC(txtMaPhieu.Text);
                CT.ShowDialog();
                this.Show();
            }        
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            files.ExportToExcel(dgvPhieuYeuCau);
        }

        /// <summary>
        /// CHi tiet phieu yeu cau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



    }
}
