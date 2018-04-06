using QuanLyNhaHang.controller;
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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        DataTable dn = new DataTable();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dis_end(false);
            Showdulieu();
            dn = controller.NhanVienCrt.GetListNhanVien();
            dgvNhanVien.DataSource = dn;
            dgvNhanVien.AutoResizeColumns();
            load_contro();
        }
        void dis_end(bool e)
        {
            txtTenNV.Enabled = e;
            txtMaNV.Enabled = e;
            dtNgaySinh.Enabled = e;
            cboGioitinh.Enabled = e;
            txtLuong.Enabled = e;
            cbMaPB.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            btnLamMoi.Enabled = e;
            btnLuu.Enabled = e;
            btnSua.Enabled = !e;
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        void load_contro()
        {
            cboGioitinh.Items.Clear();
            cboGioitinh.Items.Add("Nam");
            cboGioitinh.Items.Add("Nữ");
            cboGioitinh.Items.Add("Khác");
        }
        void clear_data()
        {
            txtTenNV.Text = "";
            txtMaNV.Text = "";
            txtLuong.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtTimKiem.Text = "";
            //load_contro();
        }
        public void Showdulieu()
        {
            DataTable dt = new DataTable();
            dt = controller.BoPhanCrt.GetListBoPhan();
            cbMaPB.DataSource = dt;
            cbMaPB.DisplayMember = "TENBP";
            cbMaPB.ValueMember = "MABP";

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            dis_end(true);
            flag = 0;
            load_contro();
        }
        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMaNV, "");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
            dis_end(false);
            clear_data();
            
        }
        int flag;
        private void btnSua_Click(object sender, EventArgs e)
        {

            flag = 1;
            dis_end(true);
            load_contro();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                if (txtMaNV.Text == "")
                {
                    errorProvider1.SetError(txtMaNV, "Bạn chưa nhập mã nhân viên ");
                }
                if (txtTenNV.Text == "")
                {
                    errorProvider1.SetError(txtTenNV, "Bạn chưa nhập tên nhân viên ");
                }

                if (txtMaNV.Text != "" && txtTenNV.Text != "")
                {
                    ketnoi kn = new ketnoi();
                    txtMaNV.Enabled = true;
                    int i = kn.xulydulieu("INSERT INTO dbo.NHANVIEN   ( MANV , TENNV ,GT ,NGAYSINH , DIACHI ,MABP ,LUONG ,DIENTHOAI)VALUES('"+txtMaNV.Text+"', N'"+txtTenNV.Text+"', N'"+cboGioitinh.Text+"',"+dtNgaySinh.Text+", N'"+txtDiaChi.Text+"', '"+cbMaPB.SelectedValue.ToString()+"',"+int.Parse(txtLuong.Text)+", '"+txtSDT.Text+"')"); 
                        if (i > 0)
                        {
                            MessageBox.Show("Thêm thành công");
                            frmNhanVien_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công");
                        }
                    
                }
            }
            else
            {
                if (txtMaNV.Text == "")
                {
                    errorProvider1.SetError(txtMaNV, "Bạn chưa nhập mã nhân viên ");
                }
                if (txtTenNV.Text == "")
                {
                    errorProvider1.SetError(txtTenNV, "Bạn chưa nhập tên nhân viên ");
                }
                if (txtMaNV.Text != "" && txtTenNV.Text != "")
                {
                    ketnoi kn = new ketnoi();
                    int i = kn.xulydulieu("UPDATE dbo.NHANVIEN SET MANV='" + txtMaNV.Text + "',TENNV=N'" + txtTenNV.Text + "',GT=N'" + cboGioitinh.Text + "',NGAYSINH='" + dtNgaySinh.Value + "',DIACHI = N'" + txtDiaChi.Text + "', MABP = '" + cbMaPB.SelectedValue.ToString() + "', LUONG =" + int.Parse(txtLuong.Text) + ", DIENTHOAI = '" + txtSDT.Text + "' WHERE MANV = '" + txtMaNV.Text + "'");
                    if (i > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                        frmNhanVien_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Sửa  không thành công");
                    }
                }
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaNV.Text =
               (dgvNhanVien.CurrentRow.Cells["MANV"].Value.ToString());
                txtTenNV.Text =
               Convert.ToString(dgvNhanVien.CurrentRow.Cells["TENNV"].Value);
                txtLuong.Text = (dgvNhanVien.CurrentRow.Cells["LUONG"].Value.ToString());
                txtDiaChi.Text = (dgvNhanVien.CurrentRow.Cells["diachi"].Value.ToString());
                txtSDT.Text = (dgvNhanVien.CurrentRow.Cells["DIENTHOAI"].Value.ToString());
                cboGioitinh.Text = (dgvNhanVien.CurrentRow.Cells["GT"].Value.ToString());
                cbMaPB.Text = (dgvNhanVien.CurrentRow.Cells["MABP"].Value.ToString());
                dtNgaySinh.Text = (dgvNhanVien.CurrentRow.Cells["NGAYSINH"].Value.ToString());

            }
        }

        private void dgvNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvNhanVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenNV, "");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                errorProvider1.SetError(txtMaNV, "Bạn chưa nhập mã nhân viên ");
            }
            if (txtTenNV.Text == "")
            {
                errorProvider1.SetError(txtTenNV, "Bạn chưa nhập tên nhân viên ");
            }

            if (txtMaNV.Text != "" && txtTenNV.Text != "")
            {
                ketnoi kn = new ketnoi();
                txtMaNV.Enabled = true;
                int i = kn.xulydulieu("delete from NhanVien where MANV='" + txtMaNV.Text + "'");
                DialogResult dg = MessageBox.Show("Bạn chắc chắc muốn xóa", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    if (i > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        frmNhanVien_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnLamMoi.Enabled = true;
            if (txtTimKiem.Text.Trim() == "" || txtTimKiem.Text.Trim().Length > 50)
            {
                MessageBox.Show("Lỗi Từ khóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvNhanVien.Refresh();
            dgvNhanVien.DataSource = NhanVienCrt.TimKiem(cbTimKiem.SelectedIndex, txtTimKiem.Text.Trim());
        }

    }
}
