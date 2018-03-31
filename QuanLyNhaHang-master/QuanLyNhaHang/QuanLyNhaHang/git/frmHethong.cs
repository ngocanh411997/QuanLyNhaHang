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
    public partial class frmHethong : Form
    {
        public frmHethong()
        {
            InitializeComponent();
        }
        internal static List<byte> typePages = new List<byte>();
        public void ThemTab(UserControl uct, byte typeControl, string tenTab)
        {
            for (int i = 0; i < TabHienthi.TabPages.Count; i++)
            {
                if (TabHienthi.TabPages[i].Contains(uct) == true)
                {
                    TabHienthi.SelectedTab = TabHienthi.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = TabHienthi.Size;
            tab.Text = tenTab;
            TabHienthi.TabPages.Add(tab);
            TabHienthi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();
        }
        public void DongTabHientai()
        {
            TabHienthi.TabPages.Remove(TabHienthi.SelectedTab);
        }
        public void DongAllTab()
        {
            while (TabHienthi.TabPages.Count > 0)
            {
                DongTabHientai();
            }
        }
        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TabHienthi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void quảnLýNhânViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThemTab(NhanVien.nv, 4, "Quản lý nhân viên");
        }

        private void quảnLýPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTab(BoPhan.bp, 4, "Quản lý bộ phận");
        }
    }
}
