using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH.Functions
{
    public partial class FrmDanhMucSanPham : Form
    {
        public FrmDanhMucSanPham()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);

        }

        private void FrmDanhMucSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.qLBHDataSet.products);

        }
    }
}
