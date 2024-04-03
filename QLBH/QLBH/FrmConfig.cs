using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH
{
    public partial class FrmConfig : Form
    {
        string connectionString = QLBH.Properties.Settings.Default.QLBHConnectionString;

        public FrmConfig()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm dùng để load danh sách cấu hình
        /// </summary>
        public void LoadDanhMucCauHinh()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = "SELECT * FROM configs";

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
                        qLBHDataSet.configs.Clear();
                        adapter.Fill(qLBHDataSet.configs);

                        // Hiển thị dữ liệu
                        configsBindingSource.DataSource = qLBHDataSet.configs;
                        configsDataGridView.DataSource = configsBindingSource;
                       
                        configsDataGridView.Refresh();

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


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            LoadDanhMucCauHinh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(keyTextBox.Text) || String.IsNullOrEmpty(valueTextBox.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập");
                return;
            }
            // Tạo câu lệnh để thực thi đến database
            string queryString = @"INSERT INTO configs([key], [value]) VALUES(@key, @value)";

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

                        // Truyền dữ liệu vào đúng tham số
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@key", keyTextBox.Text);
                        command.Parameters.AddWithValue("@value", valueTextBox.Text);

                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();

                        // Ngắt kết nối đến Database Server
                        connection.Close();

                        // Load lại danh sách cấu hình
                        LoadDanhMucCauHinh();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Tạo câu lệnh để thực thi đến database
            string queryDelete = @"Delete from configs where [key] = @key";

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryDelete, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Truyền dữ liệu vào đúng tham số
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@key", keyTextBox.Text);
                        
                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();

                        // Ngắt kết nối đến Database Server
                        connection.Close();

                        // Load lại danh sách cấu hình
                        LoadDanhMucCauHinh();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Tạo câu lệnh để thực thi đến database
            string queryUpdate = @"Update configs set [key] = @key, [value] = @value where [id] = @id ";

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryUpdate, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Truyền dữ liệu vào đúng tham số
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@key", keyTextBox.Text);
                        command.Parameters.AddWithValue("@value", valueTextBox.Text);
                        command.Parameters.AddWithValue("@id", idTextBox.Text);                        

                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();

                        // Ngắt kết nối đến Database Server
                        connection.Close();

                        // Load lại danh sách cấu hình
                        LoadDanhMucCauHinh();
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
