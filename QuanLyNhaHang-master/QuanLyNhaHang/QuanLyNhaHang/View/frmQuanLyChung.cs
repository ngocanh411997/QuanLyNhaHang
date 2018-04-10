using QuanLyNhaHang.git;
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
    public partial class frmQuanLyChung : Form
    {
        public frmQuanLyChung()
        {
            InitializeComponent();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang fm = new frmKhachHang();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btnMon_Click(object sender, EventArgs e)
        {
            frmMonAn frm = new frmMonAn();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnPhieuYC_Click(object sender, EventArgs e)
        {
            frmPhieuYC frm = new frmPhieuYC();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            frmBan frm = new frmBan();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap frm = new frmHoaDonNhap();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            frmBoPhan frm = new frmBoPhan();
            this.Close();
            frm.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain Main = new frmMain();
            this.Close();
            Main.ShowDialog();
        }

        private void btnNhomMon_Click(object sender, EventArgs e)
        {
            frmNhomMonAn NhomMon = new frmNhomMonAn();
            this.Hide();
            NhomMon.ShowDialog();
            
        }
    }
}
