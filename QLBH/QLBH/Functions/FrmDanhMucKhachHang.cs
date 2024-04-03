using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH.Functions
{
    public partial class FrmDanhMucKhachHang : Form
    {
        string connectionString = QLBH.Properties.Settings.Default.QLBHConnectionString;

        public FrmDanhMucKhachHang()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm dùng để load danh sách cấu hình
        /// </summary>
        public void LoadDanhMucKhachHang()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = "SELECT * FROM customers";

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        adapter.Fill(qLBHDataSet.customers);

                        // Hiển thị dữ liệu
                        //configsBindingSource.DataSource = null;
                        customersBindingSource.DataSource = qLBHDataSet.customers;
                        customersDataGridView.DataSource = customersBindingSource;
                        customersDataGridView.Refresh();

                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }

                }
            }

        }

        private void FrmDanhMucKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.customers' table. You can move, or remove it, as needed.
            LoadDanhMucKhachHang();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(last_nameTextBox.Text) || String.IsNullOrEmpty(first_nameTextBox.Text)
              || String.IsNullOrEmpty(companyTextBox.Text) || String.IsNullOrEmpty(phoneNumericUpDown.Text) 
              || String.IsNullOrEmpty(address1TextBox.Text) || String.IsNullOrEmpty(address2TextBox.Text)
              || String.IsNullOrEmpty(cityTextBox.Text) || String.IsNullOrEmpty(stateTextBox.Text)
              || String.IsNullOrEmpty(countryTextBox.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại, dữ liệu nhập chưa đầy đủ!");
                return;
            }
            // Tạo câu lệnh để thực thi đến database
            string queryInsert = @"INSERT INTO customers([last_name], [first_name], [email], [company], [phone], [address1], [address2], [city], [state], [postal_code], [country]) VALUES(@last_name, @first_name, @email, @company, @phone, @address1, @address2, @city, @state, @postal_code, @country)";

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryInsert, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Truyền dữ liệu vào đúng tham số
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@last_name", last_nameTextBox.Text);
                        command.Parameters.AddWithValue("@first_name", first_nameTextBox.Text);
                        command.Parameters.AddWithValue("@email", first_nameTextBox.Text);
                        command.Parameters.AddWithValue("@company", companyTextBox.Text);
                        command.Parameters.AddWithValue("@phone", phoneNumericUpDown.Text);
                        command.Parameters.AddWithValue("@address1", address1TextBox.Text);
                        command.Parameters.AddWithValue("@address2", address2TextBox.Text);
                        command.Parameters.AddWithValue("@city", cityTextBox.Text);
                        command.Parameters.AddWithValue("@state", stateTextBox.Text);
                        command.Parameters.AddWithValue("@postal_code", postal_codeTextBox.Text);
                        command.Parameters.AddWithValue("@country", countryTextBox.Text);
                        
                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();

                        // Ngắt kết nối đến Database Server
                        connection.Close();

                        // Load lại danh sách cấu hình
                        LoadDanhMucKhachHang();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
