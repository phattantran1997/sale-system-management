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
    public partial class FrmDatHang : Form
    {
        private void FrmDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.qLBHDataSet.products);

            Load_order_details();
            LoadEmployees();
            LoadCustomers();
            LoadDanhMucCauHinh();

            // Chuyển đổi trạng thái của Form
            this.FormStatus = "View";
        }

        /* Biến lưu trữ Trạng thái của Form. 
         * Các trạng thái của Form: 
         * - View   : chỉ xem, không được hiệu chỉnh gì
         * - Create : clear dữ liệu, cho phép nhập dữ liệu
         * - Edit   : lấy dữ liệu cũ, cho phép hiệu chỉnh dữ liệu đang có
         * => Mặc định khi mở Form sẽ là trạng thái VIEW
         */
        string _formStatus = "View";

        string connectionString = QLBH.Properties.Settings.Default.QLBHConnectionString;
        SortedDictionary<int, string> listEmployees = new SortedDictionary<int, string>();
        SortedDictionary<int, string> listCustomers = new SortedDictionary<int, string>();
        SortedDictionary<int, string> listProducts = new SortedDictionary<int, string>();
        public FrmDatHang()
        {
            InitializeComponent();
        }

        //Xử lý trạng thái của các controls khi Form thay đổi trạng thái
        public string FormStatus
        {
            get
            {
                return _formStatus;
            }
            set
            {
                _formStatus = value;
                // Thay đổi trạng thái của các Controls tương ứng với Trạng thái của Form
                switch (_formStatus)
                {
                    case "View":
                        // Danh sách Đơn hàng
                        dtpTuNgay.Enabled = true;
                        dtpDenNgay.Enabled = true;
                        btnLoadOrder.Enabled = true;

                        // Thông tin Đơn hàng
                        grpThongTinDonHang.Enabled = false;

                        // Thông tin Chi tiết Đơn hàng
                        grpThongTinChiTietDonHang.Enabled = false;

                        // Set trạng thái các nút button
                        btnInHoaDon.Enabled = true;
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                        btnLuu.Enabled = false;
                        btnThoat.Enabled = true;
                        btnThoat.Text = "Thoát";
                        break;
                    case "Create":
                        // Danh sách Đơn hàng
                        dtpTuNgay.Enabled = false;
                        dtpDenNgay.Enabled = false;
                        btnLoadOrder.Enabled = false;

                        // Thông tin Đơn hàng
                        grpThongTinDonHang.Enabled = true;

                        // Thông tin Chi tiết Đơn hàng
                        grpThongTinChiTietDonHang.Enabled = true;

                        // Set trạng thái các nút button
                        btnInHoaDon.Enabled = false;
                        btnThem.Enabled = false;
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnLuu.Enabled = true;
                        btnThoat.Enabled = true;
                        btnThoat.Text = "Hủy bỏ";
                        break;
                    case "Edit":
                        // Danh sách Đơn hàng
                        dtpTuNgay.Enabled = false;
                        dtpDenNgay.Enabled = false;
                        btnLoadOrder.Enabled = false;

                        // Thông tin Đơn hàng
                        grpThongTinDonHang.Enabled = true;

                        // Thông tin Chi tiết Đơn hàng
                        grpThongTinChiTietDonHang.Enabled = true;

                        // Set trạng thái các nút button
                        btnInHoaDon.Enabled = false;
                        btnThem.Enabled = false;
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnLuu.Enabled = true;
                        btnThoat.Enabled = true;
                        btnThoat.Text = "Hủy bỏ";
                        break;
                }
            }
        }

        public void Load_order()
        {
            string fromDate = dtpTuNgay.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string toDate = dtpDenNgay.Value.ToString("yyyy-MM-dd HH:mm:ss");
            // Tạo câu lệnh để thực thi đến database
            string queryStringOrder = string.Format("SELECT * FROM orders where order_date BETWEEN '{0}' and '{1}'", fromDate, toDate);

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryStringOrder, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        adapter.Fill(qLBHDataSet.orders);

                        // Hiển thị dữ liệu
                        //configsBindingSource.DataSource = null;
                        ordersBindingSource.DataSource = qLBHDataSet.orders;
                        

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

        public void Load_order_details()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = "SELECT * FROM order_details";

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
                        order_detailsBindingSource.DataSource = qLBHDataSet.order_details;
                        dgvChiTietDonHang.DataSource = order_detailsBindingSource;
                        dgvChiTietDonHang.Refresh();

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

        public void LoadEmployees()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM employees");

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
                        adapter.Fill(qLBHDataSet.employees);

                        // Hiển thị dữ liệu
                        foreach (DataRow row in qLBHDataSet.employees.Rows)
                        {
                            int key = Convert.ToInt32(row["id"]);
                            string value = row["first_name"].ToString();
                            listEmployees.Add(key, value);
                        }
                        cbbEmployee.DataSource = new BindingSource(listEmployees, null);
                        cbbEmployee.DisplayMember = "Value";
                        cbbEmployee.ValueMember = "Key";

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

        /// Hàm dùng để load danh sách khách hàng
        /// </summary>
        public void LoadCustomers()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM customers");

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
                        adapter.Fill(qLBHDataSet.employees);

                        // Hiển thị dữ liệu
                        foreach (DataRow row in qLBHDataSet.employees.Rows)
                        {
                            int key = Convert.ToInt32(row["id"]);
                            string value = row["first_name"].ToString();
                            listCustomers.Add(key, value);
                        }
                        cbbCustomer.DataSource = new BindingSource(listCustomers, null);
                        cbbCustomer.DisplayMember = "Value";
                        cbbCustomer.ValueMember = "Key";

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


        /// Hàm dùng để load danh sách sản phẩm
        /// </summary>
        public void LoadProducts()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM products");

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
                        adapter.Fill(qLBHDataSet.products);

                        // Hiển thị dữ liệu
                        foreach (DataRow row in qLBHDataSet.products.Rows)
                        {
                            int key = Convert.ToInt32(row["id"]);
                            string value = row["product_name"].ToString();
                            listProducts.Add(key, value);
                        }
                        cbbProduct.DataSource = new BindingSource(listProducts, null);
                        cbbProduct.DisplayMember = "Value";
                        cbbProduct.ValueMember = "Key";

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

               

        /// Hàm dùng để load danh sách cấu hình -> dùng để sử dụng cho FormReport
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
                        adapter.Fill(qLBHDataSet.configs);

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

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            // Chuẩn bị dữ liệu
            qLBHDataSet.ReportHoaDonBanHang.Rows.Clear();
            foreach (QLBHDataSet.order_detailsRow orderDetailRow in qLBHDataSet.order_details.Rows)
            {
                var row = qLBHDataSet.ReportHoaDonBanHang.NewReportHoaDonBanHangRow();

                // Nạp thông tin Chung về Công ty lấy từ Cấu hình (config)
                // Sử dụng cú pháp LINQ: collection.Where(p => p...).FirstOrDefault() để lấy dòng dữ liệu thỏa điều kiện
                row.report_company_name = qLBHDataSet.configs.Where(p => p.key == "company.name").FirstOrDefault().value;


                // Nạp thông tin về Khách hàng (customer)

                // Nạp thông tin về Đơn hàng (order)
                row.report_ordered_date_day = order_dateDateTimePicker.Value.Day.ToString();
                row.report_ordered_date_month = order_dateDateTimePicker.Value.Month.ToString();
                row.report_ordered_date_year = order_dateDateTimePicker.Value.Year.ToString();

                // Nạp thông tin về Đơn hàng Chi tiết (order_detail)
                row.report_order_detail_product_name = orderDetailRow.product_id.ToString();

                // Add dòng dữ liệu vào DataTable
                qLBHDataSet.ReportHoaDonBanHang.AddReportHoaDonBanHangRow(row);
            }

            // Hiển thị FormReport
            FormReport frm = new FormReport();
            frm.reportViewerCommon.LocalReport.ReportEmbeddedResource = "QLBH.Reports.ReportHoaDonBanHang.rdlc";
            frm.ReportDataSourceName = "DataSetReportOrder";
            frm.Data = qLBHDataSet.ReportHoaDonBanHang;
            frm.ShowDialog();
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Chỉ xử lý Binding khi Form đang ở trạng thái "View"
            if (this.FormStatus != "View")
            {
                return;
            }

            // Nếu đang chọn dòng dữ liệu (RowIndex > 0)
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu của dòng dữ liệu đang chọn
                DataGridViewRow row = this.dgvDonHang.Rows[e.RowIndex];

                // Binding vào các ComboBox tương ứng
                // - ComboBox Nhân viên (Employee)
                if (row.Cells["employee_id"].Value != null && row.Cells["employee_id"].Value != DBNull.Value)
                {
                    var idEmployee = Convert.ToInt32(row.Cells["employee_id"].Value);
                    cbbEmployee.SelectedItem = cbbEmployee.Items.Cast<KeyValuePair<int, string>>().First(item => item.Key == idEmployee);
                }

                // - ComboBox Khách hàng (Customer)
                if (row.Cells["customer_id"].Value != null && row.Cells["customer_id"].Value != DBNull.Value)
                {
                    var idCustomer = Convert.ToInt32(row.Cells["customer_id"].Value);
                    cbbCustomer.SelectedItem = cbbCustomer.Items.Cast<KeyValuePair<int, string>>().First(item => item.Key == idCustomer);
                }

                // Binding vào các textbox thông tin Order tương ứng
                // TODO: bổ sung đầy đủ Binding cho các trường cần thiết
                if (row.Cells["orderdateDataGridViewTextBoxColumn"].Value != null && row.Cells["orderdateDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    order_dateDateTimePicker.Text = row.Cells["orderdateDataGridViewTextBoxColumn"].Value.ToString();
                }
                if (row.Cells["shippeddateDataGridViewTextBoxColumn"].Value != null && row.Cells["shippeddateDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    ship_nameTextBox.Text = row.Cells["shippeddateDataGridViewTextBoxColumn"].Value.ToString();
                }

                // Load chi tiết đơn hàng bởi ID đơn hàng
                if (row.Cells["id"].Value != null && row.Cells["id"].Value != DBNull.Value)
                {
                    var idDonHang = Convert.ToInt32(row.Cells["id"].Value);
                    LoadChiTietDonHang(idDonHang);
                }
            }
        }

        /// Hàm dùng để load chi tiết đơn hàng bởi ID đơn hàng
        /// </summary>
        public void LoadChiTietDonHang(int idDonHang)
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM order_details WHERE order_id = {0}", idDonHang);

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
                        qLBHDataSet.order_details.Clear();
                        adapter.Fill(qLBHDataSet.order_details);

                        // Hiển thị dữ liệu
                        order_detailsBindingSource.DataSource = qLBHDataSet.order_details;
                        dgvChiTietDonHang.Refresh();

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













        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employee_idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void btnLoadOrder_Click(object sender, EventArgs e)
        {
            Load_order();
            
        }


    }
}
