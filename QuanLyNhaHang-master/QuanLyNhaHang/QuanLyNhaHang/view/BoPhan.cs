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
    public partial class BoPhan : UserControl
    {
        public BoPhan()
        {
            InitializeComponent();
        }
        int flag;
        public static BoPhan bp = new BoPhan();
        DataTable dt = new DataTable();
        void dis_end(bool e)
        {
            textMaBP.Enabled = e;
            textTenBP.Enabled = e;
            txtDiachi.Enabled = e;
            btnLamMoi.Enabled = e;
            btnLuu.Enabled = e;
            btnSua.Enabled = !e;
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
        }

        void clear_data()
        {
            textMaBP.Text = "";
            textTenBP.Text = "";
            txtDiachi.Text = "";
            //load_contro();
        }
        private void BoPhan_Load(object sender, EventArgs e)
        {
            dis_end(false);
            dt = controller.BoPhanCrt.GetListBoPhan();
            dgvBoPhan.DataSource = dt;
            dgvBoPhan.AutoResizeColumns();
        }

        private void dgvBoPhan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvBoPhan.Rows[e.RowIndex].Cells["stt"].Value = e.RowIndex + 1;
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clear_data();
            dis_end(true);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }
    }
}
