using QuanLyNhaHang.BUS;
using QuanLyNhaHang.model;
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
    public partial class frmMonAn : Form
    {
        MonAn obj = new MonAn();
        MonAnBUS Bus = new MonAnBUS();
        private int fluu = 1;
        public frmMonAn()
        {
            InitializeComponent();
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaMon.Enabled = e;
            txtTenMon.Enabled = e;
            cbMaNhomMon.Enabled = e;
            cbDonViTinh.Enabled = e;
            txtGia.Enabled = e;
        }
        private void clearData()
        {
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            txtGia.Text = "";
            txtTimKiem.Text = "";
            cbDonViTinh.Text = "";
            cbMaNhomMon.Text = "";
            cbTimKiem.Text = "";
        }
        private void HienThi()
        {
            dgvMonAn.DataSource = Bus.GetDataProc();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmMain m = new frmMain();
                m.Show();
                this.Close();
            }
            else
                HienThi();
        }

        private void frmMonAn_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenMon.Text = Convert.ToString(dgvMonAn.CurrentRow.Cells["TENMON"].Value);
                txtGia.Text = Convert.ToString(dgvMonAn.CurrentRow.Cells["GIA"].Value);
                cbMaNhomMon.Text = Convert.ToString(dgvMonAn.CurrentRow.Cells["MaNHOMMON"].Value);
                cbDonViTinh.Text = Convert.ToString(dgvMonAn.CurrentRow.Cells["DONVITINH"].Value);
            }
            else
            {
                txtMaMon.Text = Convert.ToString(dgvMonAn.CurrentRow.Cells["MAMON"].Value);
                txtTenMon.Text = Convert.ToString(dgvMonAn.CurrentRow.Cells["TENMON"].Value);
                txtGia.Text = Convert.ToString(dgvMonAn.CurrentRow.Cells["GIA"].Value);
                cbMaNhomMon.Text = Convert.ToString(dgvMonAn.CurrentRow.Cells["MaNHOMMON"].Value);
                cbDonViTinh.Text = Convert.ToString(dgvMonAn.CurrentRow.Cells["DONVITINH"].Value);
            }
        }

        private void dgvMonAn_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvMonAn.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteData(txtMaMon.Text);
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaMon.Text = Bus.TangMa();
            DisEnl(true);
            txtMaMon.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaMon.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã món ăn! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenMon.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên món ăn! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá món ăn! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbDonViTinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đơn vị tính! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbMaNhomMon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã nhóm món ăn! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int _gia;
            int.TryParse(txtGia.Text, out _gia);

            obj.MaMon = txtMaMon.Text;
            obj.TenMon = txtTenMon.Text;
            obj.Gia = _gia;
            obj.DonViTinh = cbDonViTinh.Text;
            obj.MaNhomMon = cbMaNhomMon.Text;

            if (txtMaMon.Text != "" && txtTenMon.Text != "" && txtGia.Text != "" && cbMaNhomMon.Text != "" && cbDonViTinh.Text != "" && fluu == 0)
            {
                try
                {
                    Bus.InsertData(obj);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmMonAn_Load(sender, e);
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch
                {

                }
            }
            else if (txtMaMon.Text != "" && txtTenMon.Text != "" && txtGia.Text != "" && cbMaNhomMon.Text != "" && cbDonViTinh.Text != "" && fluu != 0)
            {
                try
                {
                    Bus.UpdateData(obj);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmMonAn_Load(sender, e);
                    clearData();
                    DisEnl(false);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text.Trim() == "" || txtTimKiem.Text.Trim().Length > 50)
                {
                    MessageBox.Show("Lỗi Từ khóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvMonAn.Refresh();
                dgvMonAn.DataSource = controller.MonAnController.TimKiem(cbTimKiem.SelectedIndex, txtTimKiem.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }
    }
}
