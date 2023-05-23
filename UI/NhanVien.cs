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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        BUS_NHANVIEN bus = new BUS_NHANVIEN();
        NHAN_VIEN ex = new NHAN_VIEN();
        DataTable nv = new DataTable();
        bool addnew;
        bool gioitinh;
        void OpenNV()
        {
            textBox_nv_macv.Text = "002";
            textBox_nv_manv.Enabled = false;
            textBox_nv_tennv.Enabled = false;
            textBox_nv_macv.Enabled = false;
            dateTimePicker_ns.Enabled = false;
            textBox_nv_sdt.Enabled = false;
            textBox_nv_dc.Enabled = false;
            textBox_nv_macv.BackColor = Color.DarkGray;
            textBox_nv_manv.BackColor = Color.DarkGray;
            textBox_nv_tennv.BackColor = Color.DarkGray;
            textBox_nv_macv.BackColor = Color.DarkGray;
            dateTimePicker_ns.BackColor = Color.DarkGray;
            textBox_nv_sdt.BackColor = Color.DarkGray;
            textBox_nv_dc.BackColor = Color.DarkGray;

            button_nv_them.Enabled = true;
            button_nv_luu.Enabled = false;
            button_nv_sua.Enabled = false;
            button_nv_xoa.Enabled = false;
            button_nv_huybo.Enabled = false;
        }
        void CloseNV()
        {
            textBox_nv_tennv.Enabled = true;
            dateTimePicker_ns.Enabled = true;
            textBox_nv_sdt.Enabled = true;
            textBox_nv_dc.Enabled = true;
            textBox_nv_macv.BackColor = Color.White;
            textBox_nv_tennv.BackColor = Color.White;
            textBox_nv_macv.BackColor = Color.White;
            dateTimePicker_ns.BackColor = Color.White;
            textBox_nv_sdt.BackColor = Color.White;
            textBox_nv_dc.BackColor = Color.White;

            button_nv_them.Enabled = false;
            button_nv_luu.Enabled = false;
            button_nv_sua.Enabled = false;
            button_nv_xoa.Enabled = false;
            button_nv_huybo.Enabled = false;
        }
        void SetNull()
        {
            textBox_nv_manv.Text = "";
            textBox_nv_tennv.Text = "";
            dateTimePicker_ns.Text = "";
            textBox_nv_sdt.Text = "";
            textBox_nv_dc.Text = "";
            comboBox_timkiem.Text = "";
        }
        void AutoNV()
        {
            nv = bus.GetMaNV();
            if (nv == null || nv.Rows.Count == 0)
            {
                textBox_nv_manv.Text = "NV0001";
            }
            else
            {
                int tam1 = int.Parse(nv.Rows[0][0].ToString());
                if (tam1 < 10)
                {
                    tam1 = tam1 + 1;
                    textBox_nv_manv.Text = "NV000" + Convert.ToString(tam1);
                }
                else
                    if (tam1 < 100)
                    {
                        tam1 = tam1 + 1;
                        textBox_nv_manv.Text = "NV00" + Convert.ToString(tam1);
                    }
                    else
                        if (tam1 < 1000)
                        {
                            tam1 = tam1 + 1;
                            textBox_nv_manv.Text = "NV0" + Convert.ToString(tam1);
                        }
            }
        }
        void Display()
        {
            dataGridView_nv.DataSource = bus.GetData("");
        }

        private void label_nv_sdt_Click(object sender, EventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            comboBox_timkiem.DataSource = bus.GetData("");
            comboBox_timkiem.ValueMember = "TenNV";
            comboBox_timkiem.Text = "";
            OpenNV();
            Display();
        }

        private void button_nv_them_Click(object sender, EventArgs e)
        {
            CloseNV();
            SetNull();
            addnew = true;
            button_nv_luu.Enabled = true;
            button_nv_huybo.Enabled = true;
            AutoNV();
            Display();
            this.textBox_nv_manv.Focus();
        }

        private void button_nv_luu_Click(object sender, EventArgs e)
        {
            if (textBox_nv_manv.Text == "")
            {
                MessageBox.Show("Lỗi mã nhân viên !");
                return;
            }
            if (textBox_nv_tennv.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại tên nhân viên !");
                return;
            }
            if (textBox_nv_sdt.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại số điện thoại !");
                return;
            }
            if (textBox_nv_dc.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại địa chỉ của nhân viên !");
                return;
            }
            if (addnew == true)
            {
                try
                {
                    if(textBox_nv_sdt.Text.Length < 10)
                    {
                        MessageBox.Show("Số điện thoại không đúng !");
                        return;
                    }
                    else
                    {
                        if (textBox_nv_sdt.Text.Length == 10 || textBox_nv_sdt.Text.Length == 11)
                            {
                            int tuoi = DateTime.Now.Year - dateTimePicker_ns.Value.Year; 
                              if(tuoi > 0 &&tuoi < 18)
                                   {
                                        MessageBox.Show("Nhân viên chưa đủ tuổi lao động ! ");
                                        return;
                                   }                 
                               else
                                  if (tuoi <= 0)
                                  {
                                      MessageBox.Show("Lỗi năm sinh !");
                                      return;
                                  }
                                  else
                                  {
                                      ex.MaNV = textBox_nv_manv.Text;
                                      ex.TenNV = textBox_nv_tennv.Text;
                                      ex.MaCV = textBox_nv_macv.Text;
                                      ex.NgaySinh = dateTimePicker_ns.Value.Date.ToString("dd/MM/yyyy");
                                      ex.SDTNV = textBox_nv_sdt.Text;
                                      if (gioitinh == true)
                                      {
                                          ex.GioiTinh = "Nam ";
                                      }
                                      else
                                      {
                                          ex.GioiTinh = "Nữ ";
                                      }
                                      ex.DiaChiNV = textBox_nv_dc.Text;
                                      bus.AddData(ex);
                                  }
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
                    if (textBox_nv_sdt.Text.Length < 10)
                    {
                        MessageBox.Show("Số điện thoại không đúng !");
                        return;
                    }
                    else
                    {
                        if (textBox_nv_sdt.Text.Length == 10 || textBox_nv_sdt.Text.Length == 11)
                        {
                            int tuoi = DateTime.Now.Year - dateTimePicker_ns.Value.Year; 
                              if(tuoi >0 && tuoi < 18)
                                   {
                                        MessageBox.Show("Nhân viên chưa đủ tuổi lao động ! ");
                                        return;
                                   }                 
                               else
                                    if(tuoi <= 0)
                              {                 
                                       MessageBox.Show("Lỗi năm sinh !");
                                       return;
                                  }
                                      else
                                    {
                            ex.MaNV = textBox_nv_manv.Text;
                            ex.TenNV = textBox_nv_tennv.Text;
                            ex.MaCV = textBox_nv_macv.Text;
                            ex.NgaySinh = dateTimePicker_ns.Value.Date.ToString("dd/MM/yyyy");
                            ex.SDTNV = textBox_nv_sdt.Text;
                            if (gioitinh == true)
                                {
                                    ex.GioiTinh = "Nam ";
                                }
                            else
                                {
                                    ex.GioiTinh = "Nữ ";
                                }
                            ex.DiaChiNV = textBox_nv_dc.Text;
                            bus.EditData(ex);
                                                    }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể sửa được !");
                    return;
                }
            }
            OpenNV();
            Display();
        }

        private void button_nv_sua_Click(object sender, EventArgs e)
        {
            if (textBox_nv_manv.Text == "" || textBox_nv_tennv.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chọn bên dưới !","Thông báo !");
                return;
            }
            CloseNV();
            addnew = false;
            button_nv_luu.Enabled = true;
            button_nv_huybo.Enabled = true;
            this.textBox_nv_tennv.Focus();
        }

        private void button_nv_huybo_Click(object sender, EventArgs e)
        {
            SetNull();
            OpenNV();
        }
        private void dataGridView_nv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OpenNV();
            button_nv_sua.Enabled = true;
            button_nv_xoa.Enabled = true;
            button_nv_them.Enabled = false;
            button_nv_huybo.Enabled = true;
            try
            {
                textBox_nv_manv.Text = dataGridView_nv.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox_nv_tennv.Text = dataGridView_nv.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox_nv_macv.Text = dataGridView_nv.Rows[e.RowIndex].Cells[1].Value.ToString();
                if( dataGridView_nv.Rows[e.RowIndex].Cells[5].Value.ToString() == "Nam ")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
                dateTimePicker_ns.Text = dataGridView_nv.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox_nv_sdt.Text = dataGridView_nv.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox_nv_dc.Text = dataGridView_nv.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
        private void dataGridView_nv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_nv_xoa_Click(object sender, EventArgs e)
        {
            if (textBox_nv_manv.Text == "" || textBox_nv_tennv.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chọn bên dưới !","Thông báo !");
                return;
            }
            ex.MaNV = textBox_nv_manv.Text;
            bus.DeleteData(ex);
            OpenNV();
            SetNull();
            Display();
        }

        private void button_nv_tc_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Trangchinh tc = new Trangchinh();
            tc.ShowDialog();
        }

        private void textBox_nv_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gioitinh = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gioitinh = false;
        }

        private void button_nv_timkiem_Click(object sender, EventArgs e)
        {
            dataGridView_nv.DataSource = bus.SearchNV("N'" + comboBox_timkiem.Text + "'");
            CloseNV();
            button_nv_huybo.Enabled = true;
            button_nv_sua.Enabled = true;
            button_nv_xoa.Enabled = true;
        }
    }
}
