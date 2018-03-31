using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang.view
{
    public partial class DangNhap : UserControl
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public static DangNhap dn = new DangNhap();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "" || txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Ban chua nhap du thong tin ", "loi");
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
