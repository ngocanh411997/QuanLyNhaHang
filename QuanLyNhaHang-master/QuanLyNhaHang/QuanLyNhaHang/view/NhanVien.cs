using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHang.model;
using System.Data.SqlClient;
using QuanLyNhaHang.controller;

namespace QuanLyNhaHang.view
{
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        int flag;
        public static NhanVien nv = new NhanVien();
        DataTable dt = new DataTable();
        private void NhanVien_Load(object sender, EventArgs e)
        {
            dt = controller.NhanVienCrt.GetListNhanVien();
            dgvNhanVien.DataSource = dt;
            Showdulieu();


        }
        void Showdulieu()
        {
            model.ketnoi kn = new ketnoi();
            SqlCommand mysqlcommand = new SqlCommand();
            mysqlcommand.Connection = kn.kn;
            mysqlcommand.CommandText = "select *from Bophan";
            kn.kn_csdl();
            SqlDataAdapter mysqladatareader = new SqlDataAdapter();
            mysqladatareader.SelectCommand = mysqlcommand;
            DataSet mydataset = new DataSet();
            mysqladatareader.Fill(mydataset, "KQ");
            DataTable table_MK = new DataTable();
            table_MK = mydataset.Tables["KQ"];
            cbMaPB.DataSource = table_MK;
            cbMaPB.DisplayMember = table_MK.Columns["TENBP"].ToString();
            cbMaPB.ValueMember = table_MK.Columns["MABP"].ToString();


            kn.kn.Close();
        }
        private void dgvNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvNhanVien.Rows[e.RowIndex].Cells["stt"].Value = e.RowIndex + 1;
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
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clear_data();
            dis_end(true);
            //load_contro();
        }

        private void dgvNhanVien_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
               dgvNhanVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            NhanVien_Load(sender, e);
            dis_end(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
            //load_contro();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

           

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMaNV, "");
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenNV, "");
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
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
                cbMaPB.Text = (dgvNhanVien.CurrentRow.Cells["TENBP"].Value.ToString());
                dtNgaySinh.Text= (dgvNhanVien.CurrentRow.Cells["NGAYSINH"].Value.ToString());

            }

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
                int i = kn.xulydulieu("delete from NhanVien where MANV='" + txtMaNV.Text+ "'");
                DialogResult dg = MessageBox.Show("Bạn chắc chắc muốn xóa", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    if (i > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        NhanVien_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }             
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
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
