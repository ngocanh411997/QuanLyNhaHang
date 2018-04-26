using QuanLyNhaHang.BUS;
using QuanLyNhaHang.model;
using QuanLyNhaHang.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang.git
{
    public partial class frmNhomMonAn : Form
    {
        NhomMonAn obj = new NhomMonAn();
        NhomMonAnBUS Bus = new NhomMonAnBUS();
        private int fluu = 1;
        public frmNhomMonAn()
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
            txtMaNhom.Enabled = e;
            txtTenNhom.Enabled = e;            
        }
        private void clearData()
        {
            txtMaNhom.Text = "";
            txtTenNhom.Text = "";            
        }
        private void HienThi()
        {
            dgvNhomMonAn.DataSource = Bus.GetDataProc();
            dgvNhomMonAn.AutoResizeColumns();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                
                this.Hide();
            }
            else
                HienThi();
        }

        private void frmNhomMonAn_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvNhomMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenNhom.Text = Convert.ToString(dgvNhomMonAn.CurrentRow.Cells["TENNHOMMON"].Value);                
            }
            else
            {
                txtMaNhom.Text = Convert.ToString(dgvNhomMonAn.CurrentRow.Cells["MANHOMMON"].Value);
                txtTenNhom.Text = Convert.ToString(dgvNhomMonAn.CurrentRow.Cells["TENNHOMMON"].Value);
            }
        }

        private void dgvNhomMonAn_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvNhomMonAn.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteData(txtMaNhom.Text);
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
            txtMaNhom.Text = Bus.TangMa();
            DisEnl(true);
            txtMaNhom.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaNhom.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNhom.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhóm món ăn! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenNhom.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên món ăn! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            obj.MANHOMMON = txtMaNhom.Text;
            obj.TENNHOMMON = txtTenNhom.Text;
           

            if (txtMaNhom.Text != "" && txtTenNhom.Text != "" && fluu == 0)
            {
                try
                {
                    Bus.InsertData(obj);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmNhomMonAn_Load(sender, e);
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch
                {

                }
            }
            else if (txtMaNhom.Text != "" && txtTenNhom.Text != "" && fluu != 0)
            {
                try
                {
                    Bus.UpdateData(obj);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmNhomMonAn_Load(sender, e);
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnLamTrong_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Theo Mã")
            {
                dgvNhomMonAn.DataSource = Bus.TimKiemNM("SELECT * from NHOMMONAN WHERE MANHOMMON like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Theo Tên")
            {
                dgvNhomMonAn.DataSource = Bus.TimKiemNM("SELECT * from NHOMMONAN WHERE TENNHOMMON like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
        }
    }
}
