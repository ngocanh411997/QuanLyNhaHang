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
    public partial class frmBoPhan : Form
    {
        public frmBoPhan()
        {
            InitializeComponent();
        }
        void dis_end(bool e)
        {
            textMaBP.Enabled = e;
            textTenBP.Enabled = e;
            btnLamMoi.Enabled = e;
            btnLuu.Enabled = e;
            btnSua.Enabled = !e;
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
        }
       
        void clear_data()
        {
            textTenBP.ResetText();
            textMaBP.ResetText();
            txtTimKiem.ResetText();
            //load_contro();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            dis_end(false);
            clear_data();
        }

        private void textMaBP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dis_end(true);
            clear_data();
        }
    }
}
