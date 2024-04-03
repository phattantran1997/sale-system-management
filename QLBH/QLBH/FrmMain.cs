using QLBH.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cấuHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfig frmconfig = new FrmConfig();
            frmconfig.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanhMucKhachHang f1 = new FrmDanhMucKhachHang();
            f1.Show();
        }

        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatHang fDH = new FrmDatHang();
            fDH.Show();
        }
    }
}
