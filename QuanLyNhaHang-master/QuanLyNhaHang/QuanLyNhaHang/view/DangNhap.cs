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
using QuanLyNhaHang.controller;

namespace QuanLyNhaHang.view
{
    public partial class DangNhap : UserControl
    {
        NguoiDung nd = new NguoiDung();
        NguoiDungCrt ndCrt = new NguoiDungCrt();
        public DangNhap()
        {
            InitializeComponent();
        }
        public static DangNhap dn = new DangNhap();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            frmMain main = new frmMain();
            main.Show();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
