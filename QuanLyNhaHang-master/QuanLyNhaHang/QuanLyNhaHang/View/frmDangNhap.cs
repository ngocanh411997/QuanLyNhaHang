using QuanLyNhaHang.controller;
using QuanLyNhaHang.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang.view
{
    public partial class frmDangNhap : Form
    {
        NguoiDung nd = new NguoiDung();
        NguoiDungCrt ndCrt = new NguoiDungCrt();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //string sql = string.Format("select TenDangNhap from NGUOIDUNG where TenDangNhap='{0}' and MatKhau='{1}'",
            //    txtTenDangNhap.Text, txtMatKhau.Text);
            //DataTable dt =model.ConnectString.GetData(sql);
            //if (dt.Rows.Count == 1)
            //{
            //    SingletonData.Getlates().nd = new NguoiDung() { TAIKHOAN = txtTenDangNhap.Text };
            //    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //////////////////////
            //    this.Close();
            //    frmMain main = new frmMain();
            //    main.ShowDialog();
            //    this.Hide();
            //}
            //else
            //{
            //    SingletonData.Getlates().nd = null;
            //    MessageBox.Show("Đăng nhập thất bại. Xem lại tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            //if (txtTenDangNhap.Text == "" && txtMatKhau.Text == nd.TAIKHOAN)
            //{
            //    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Đăng nhập thất bại. Xem lại tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
            //this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát chương trình ?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
