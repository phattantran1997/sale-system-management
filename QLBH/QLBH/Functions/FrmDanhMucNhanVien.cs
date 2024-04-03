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
    public partial class FrmDanhMucNhanVien : Form
    {
        public FrmDanhMucNhanVien()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);

        }

        private void FrmDanhMucNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.qLBHDataSet.employees);

        }
    }
}
