using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Business_Layer;
namespace UI
{
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }
        BUS_NHACUNGCAP bus = new BUS_NHACUNGCAP();
        NHA_CUNG_CAP ex = new NHA_CUNG_CAP();
        DataTable ncc = new DataTable();
        bool addnew;
        void CloseNCC()
        {
            textBox_ncc_tenncc.Enabled = false;
            textBox_ncc_sdt.Enabled = false;
            textBox_ncc_dc.Enabled = false;
            textBox_ncc_mancc.BackColor = Color.DarkGray;
            textBox_ncc_tenncc.BackColor = Color.DarkGray;
            textBox_ncc_sdt.BackColor = Color.DarkGray;
            textBox_ncc_dc.BackColor = Color.DarkGray;

            button_ncc_them.Enabled = true;
            button_ncc_luu.Enabled = false;
            button_ncc_sua.Enabled = false;
            button_ncc_xoa.Enabled = false;
            button_ncc_huybo.Enabled = false;
        }
        void OpenNCC()
        {
            textBox_ncc_tenncc.Enabled = true;
            textBox_ncc_sdt.Enabled = true;
            textBox_ncc_dc.Enabled = true;
            textBox_ncc_tenncc.BackColor = Color.White;
            textBox_ncc_sdt.BackColor = Color.White;
            textBox_ncc_dc.BackColor = Color.White;

            button_ncc_them.Enabled = false;
            button_ncc_luu.Enabled = false;
            button_ncc_sua.Enabled = false;
            button_ncc_xoa.Enabled = false;
            button_ncc_huybo.Enabled = false;
        }
        void setnull()
        {
            textBox_ncc_dc.Text="";
            textBox_ncc_mancc.Text="";
            textBox_ncc_sdt.Text="";
            textBox_ncc_tenncc.Text="";
            comboBox_timkiem.Text = "";
        }
        void AutoNCC()
        {
            ncc = bus.GetMaNCC();
            if (ncc == null || ncc.Rows.Count == 0)
            {
                textBox_ncc_mancc.Text = "NCC0001";
            }
            else
            {
                int tam1 = int.Parse(ncc.Rows[0][0].ToString());
                if (tam1 < 10)
                {
                    tam1 = tam1 + 1;
                    textBox_ncc_mancc.Text  = "NCC000" + Convert.ToString(tam1);
                }
                else
                    if (tam1 < 100)
                    {
                        tam1 = tam1 + 1;
                        textBox_ncc_mancc.Text = "NCC00" + Convert.ToString(tam1);
                    }
                    else
                        if (tam1 < 1000)
                        {
                            tam1 = tam1 + 1;
                            textBox_ncc_mancc.Text = "NCC0" + Convert.ToString(tam1);
                        }
            }
        }
        void Display()
        {
            dataGridView_ncc.DataSource = bus.GetData("");
        }

        private void button_ncc_them_Click(object sender, EventArgs e)
        {
            OpenNCC();
            setnull();
            addnew = true;
            button_ncc_luu.Enabled = true;
            button_ncc_huybo.Enabled = true;
            AutoNCC();
            this.textBox_ncc_tenncc.Focus();
        }

        private void button_ncc_luu_Click(object sender, EventArgs e)
        {
            if (textBox_ncc_mancc.Text == "")
            {
                MessageBox.Show("Lỗi mã nhà cung cấp !");
                return;
            }
            if (textBox_ncc_tenncc.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại tên nhà cung cấp !");
                return;
            }
            if (textBox_ncc_sdt.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại số điện thoại của nhà cung cấp !");
                return;
            }
            if (textBox_ncc_dc.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại địa chỉ của nhà cung cấp !");
                return;
            }
            if (addnew == true)
            {
                try
                {
                    if (textBox_ncc_sdt.Text.Length < 10)
                    {
                        MessageBox.Show("Số điện thoại không đúng !");
                        return;
                    }
                    else
                    {
                        if (textBox_ncc_sdt.Text.Length == 10 || textBox_ncc_sdt.Text.Length == 11)
                        {
                            ex.MaNCC = textBox_ncc_mancc.Text;
                            ex.TenNCC = textBox_ncc_tenncc.Text;
                            ex.SDTNCC = textBox_ncc_sdt.Text;
                            ex.DiaChiNCC = textBox_ncc_dc.Text;
                            bus.AddData(ex);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể thêm mới được !");
                    return;
                }
            }
            else
            {
                try
                {
                    if (textBox_ncc_sdt.Text.Length < 10)
                    {
                        MessageBox.Show("Số điện thoại không đúng !");
                        return;
                    }
                    else
                    {
                        if (textBox_ncc_sdt.Text.Length == 10 || textBox_ncc_sdt.Text.Length == 11)
                        {
                            ex.MaNCC = textBox_ncc_mancc.Text;
                            ex.TenNCC = textBox_ncc_tenncc.Text;
                            ex.SDTNCC = textBox_ncc_sdt.Text;
                            ex.DiaChiNCC = textBox_ncc_dc.Text;
                            bus.EditData(ex);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể sửa được !");
                    return;
                }

            }
            CloseNCC();
            Display();
        }

        private void button_ncc_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_ncc_mancc.Text == "" || textBox_ncc_tenncc.Text == "")
                {
                    MessageBox.Show("Vui lòng nhấp chọn bên dưới !","Thông báo !");
                    return;
                }
                OpenNCC();
                addnew = false;
                button_ncc_luu.Enabled = true;
                button_ncc_huybo.Enabled = true;
                this.textBox_ncc_tenncc.Focus();
                Display();
            }
            catch { }
        }

        private void button_ncc_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_ncc_mancc.Text == "" || textBox_ncc_tenncc.Text == "")
                {
                    MessageBox.Show("Vui lòng nhấp chọn bên dưới !","Thông báo !");
                    return;
                }
                ex.MaNCC = textBox_ncc_mancc.Text;
                bus.DeleteData(ex);
                setnull();
                Display();
                CloseNCC();
            }
            catch
            {
                MessageBox.Show("Không thể xóa !");
            }
        }

        private void button_ncc_huybo_Click(object sender, EventArgs e)
        {
            setnull();
            CloseNCC();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            CloseNCC();
            Display();
            textBox_ncc_mancc.Enabled = false;
            comboBox_timkiem.DataSource = bus.GetData("");
            comboBox_timkiem.ValueMember = "TenNCC";
            comboBox_timkiem.Text = "";
        }

        private void dataGridView_ncc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CloseNCC();
            button_ncc_sua.Enabled = true;
            button_ncc_xoa.Enabled = true;
            button_ncc_huybo.Enabled = true;
            try
            {
                  textBox_ncc_mancc.Text = dataGridView_ncc.Rows[e.RowIndex].Cells[0].Value.ToString();
                   textBox_ncc_tenncc.Text = dataGridView_ncc.Rows[e.RowIndex].Cells[1].Value.ToString();
                  textBox_ncc_sdt.Text = dataGridView_ncc.Rows[e.RowIndex].Cells[2].Value.ToString();
                  textBox_ncc_dc.Text = dataGridView_ncc.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void dataGridView_ncc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenNCC();
            button_ncc_luu.Enabled = true;
            button_ncc_huybo.Enabled = true;
            addnew = false;
            this.textBox_ncc_tenncc.Focus();
        }

        private void button_ncc_tc_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Trangchinh tc = new Trangchinh();
            tc.ShowDialog();
        }

        private void textBox_ncc_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            dataGridView_ncc.DataSource = bus.SearchNCC("'" + comboBox_timkiem.Text + "'");
            CloseNCC();
            button_ncc_sua.Enabled = true;
            button_ncc_huybo.Enabled = true;
            button_ncc_xoa.Enabled = true;

        }
    }
}