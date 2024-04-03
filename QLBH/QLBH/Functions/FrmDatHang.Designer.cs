namespace QLBH.Functions
{
    partial class FrmDatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label order_dateLabel;
            System.Windows.Forms.Label shipped_dateLabel;
            System.Windows.Forms.Label ship_nameLabel;
            System.Windows.Forms.Label ship_address1Label;
            System.Windows.Forms.Label ship_address2Label;
            System.Windows.Forms.Label ship_cityLabel;
            System.Windows.Forms.Label ship_stateLabel;
            System.Windows.Forms.Label ship_postal_codeLabel;
            System.Windows.Forms.Label ship_countryLabel;
            System.Windows.Forms.Label payment_typeLabel;
            System.Windows.Forms.Label payment_typeLabel1;
            System.Windows.Forms.Label paid_dateLabel;
            System.Windows.Forms.Label order_statusLabel;
            System.Windows.Forms.Label quantityLabel1;
            System.Windows.Forms.Label unit_priceLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label employee_idLabel1;
            System.Windows.Forms.Label customer_idLabel1;
            System.Windows.Forms.Label idLabel;
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipped_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ship_nameTextBox = new System.Windows.Forms.TextBox();
            this.ship_address1TextBox = new System.Windows.Forms.TextBox();
            this.ship_address2TextBox = new System.Windows.Forms.TextBox();
            this.ship_cityTextBox = new System.Windows.Forms.TextBox();
            this.ship_stateTextBox = new System.Windows.Forms.TextBox();
            this.ship_postal_codeTextBox = new System.Windows.Forms.TextBox();
            this.ship_countryTextBox = new System.Windows.Forms.TextBox();
            this.payment_typeTextBox = new System.Windows.Forms.TextBox();
            this.payment_typeTextBox1 = new System.Windows.Forms.TextBox();
            this.paid_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.order_statusTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpThongTinDonHang = new System.Windows.Forms.GroupBox();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.cbbEmployee = new System.Windows.Forms.ComboBox();
            this.grpThongTinChiTietDonHang = new System.Windows.Forms.GroupBox();
            this.cbbProduct = new System.Windows.Forms.ComboBox();
            this.discountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.order_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unit_priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLoadOrder = new System.Windows.Forms.Button();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippeddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ship_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ship_address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ship_address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ship_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ship_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ship_postal_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ship_country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipping_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.ordersTableAdapter = new QLBH.QLBHDataSetTableAdapters.ordersTableAdapter();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new QLBH.QLBHDataSetTableAdapters.productsTableAdapter();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            order_dateLabel = new System.Windows.Forms.Label();
            shipped_dateLabel = new System.Windows.Forms.Label();
            ship_nameLabel = new System.Windows.Forms.Label();
            ship_address1Label = new System.Windows.Forms.Label();
            ship_address2Label = new System.Windows.Forms.Label();
            ship_cityLabel = new System.Windows.Forms.Label();
            ship_stateLabel = new System.Windows.Forms.Label();
            ship_postal_codeLabel = new System.Windows.Forms.Label();
            ship_countryLabel = new System.Windows.Forms.Label();
            payment_typeLabel = new System.Windows.Forms.Label();
            payment_typeLabel1 = new System.Windows.Forms.Label();
            paid_dateLabel = new System.Windows.Forms.Label();
            order_statusLabel = new System.Windows.Forms.Label();
            quantityLabel1 = new System.Windows.Forms.Label();
            unit_priceLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            employee_idLabel1 = new System.Windows.Forms.Label();
            customer_idLabel1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).BeginInit();
            this.grpThongTinDonHang.SuspendLayout();
            this.grpThongTinChiTietDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit_priceNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // order_dateLabel
            // 
            order_dateLabel.AutoSize = true;
            order_dateLabel.Location = new System.Drawing.Point(30, 83);
            order_dateLabel.Name = "order_dateLabel";
            order_dateLabel.Size = new System.Drawing.Size(58, 13);
            order_dateLabel.TabIndex = 5;
            order_dateLabel.Text = "order date:";
            // 
            // shipped_dateLabel
            // 
            shipped_dateLabel.AutoSize = true;
            shipped_dateLabel.Location = new System.Drawing.Point(17, 109);
            shipped_dateLabel.Name = "shipped_dateLabel";
            shipped_dateLabel.Size = new System.Drawing.Size(71, 13);
            shipped_dateLabel.TabIndex = 7;
            shipped_dateLabel.Text = "shipped date:";
            // 
            // ship_nameLabel
            // 
            ship_nameLabel.AutoSize = true;
            ship_nameLabel.Location = new System.Drawing.Point(30, 134);
            ship_nameLabel.Name = "ship_nameLabel";
            ship_nameLabel.Size = new System.Drawing.Size(58, 13);
            ship_nameLabel.TabIndex = 9;
            ship_nameLabel.Text = "ship name:";
            // 
            // ship_address1Label
            // 
            ship_address1Label.AutoSize = true;
            ship_address1Label.Location = new System.Drawing.Point(13, 160);
            ship_address1Label.Name = "ship_address1Label";
            ship_address1Label.Size = new System.Drawing.Size(75, 13);
            ship_address1Label.TabIndex = 11;
            ship_address1Label.Text = "ship address1:";
            // 
            // ship_address2Label
            // 
            ship_address2Label.AutoSize = true;
            ship_address2Label.Location = new System.Drawing.Point(316, 29);
            ship_address2Label.Name = "ship_address2Label";
            ship_address2Label.Size = new System.Drawing.Size(75, 13);
            ship_address2Label.TabIndex = 13;
            ship_address2Label.Text = "ship address2:";
            // 
            // ship_cityLabel
            // 
            ship_cityLabel.AutoSize = true;
            ship_cityLabel.Location = new System.Drawing.Point(343, 52);
            ship_cityLabel.Name = "ship_cityLabel";
            ship_cityLabel.Size = new System.Drawing.Size(48, 13);
            ship_cityLabel.TabIndex = 15;
            ship_cityLabel.Text = "ship city:";
            // 
            // ship_stateLabel
            // 
            ship_stateLabel.AutoSize = true;
            ship_stateLabel.Location = new System.Drawing.Point(336, 79);
            ship_stateLabel.Name = "ship_stateLabel";
            ship_stateLabel.Size = new System.Drawing.Size(55, 13);
            ship_stateLabel.TabIndex = 17;
            ship_stateLabel.Text = "ship state:";
            // 
            // ship_postal_codeLabel
            // 
            ship_postal_codeLabel.AutoSize = true;
            ship_postal_codeLabel.Location = new System.Drawing.Point(304, 105);
            ship_postal_codeLabel.Name = "ship_postal_codeLabel";
            ship_postal_codeLabel.Size = new System.Drawing.Size(87, 13);
            ship_postal_codeLabel.TabIndex = 19;
            ship_postal_codeLabel.Text = "ship postal code:";
            // 
            // ship_countryLabel
            // 
            ship_countryLabel.AutoSize = true;
            ship_countryLabel.Location = new System.Drawing.Point(324, 130);
            ship_countryLabel.Name = "ship_countryLabel";
            ship_countryLabel.Size = new System.Drawing.Size(67, 13);
            ship_countryLabel.TabIndex = 21;
            ship_countryLabel.Text = "ship country:";
            // 
            // payment_typeLabel
            // 
            payment_typeLabel.AutoSize = true;
            payment_typeLabel.Location = new System.Drawing.Point(318, 156);
            payment_typeLabel.Name = "payment_typeLabel";
            payment_typeLabel.Size = new System.Drawing.Size(73, 13);
            payment_typeLabel.TabIndex = 23;
            payment_typeLabel.Text = "payment type:";
            // 
            // payment_typeLabel1
            // 
            payment_typeLabel1.AutoSize = true;
            payment_typeLabel1.Location = new System.Drawing.Point(503, 29);
            payment_typeLabel1.Name = "payment_typeLabel1";
            payment_typeLabel1.Size = new System.Drawing.Size(73, 13);
            payment_typeLabel1.TabIndex = 25;
            payment_typeLabel1.Text = "payment type:";
            // 
            // paid_dateLabel
            // 
            paid_dateLabel.AutoSize = true;
            paid_dateLabel.Location = new System.Drawing.Point(525, 56);
            paid_dateLabel.Name = "paid_dateLabel";
            paid_dateLabel.Size = new System.Drawing.Size(54, 13);
            paid_dateLabel.TabIndex = 27;
            paid_dateLabel.Text = "paid date:";
            // 
            // order_statusLabel
            // 
            order_statusLabel.AutoSize = true;
            order_statusLabel.Location = new System.Drawing.Point(514, 83);
            order_statusLabel.Name = "order_statusLabel";
            order_statusLabel.Size = new System.Drawing.Size(65, 13);
            order_statusLabel.TabIndex = 29;
            order_statusLabel.Text = "order status:";
            // 
            // quantityLabel1
            // 
            quantityLabel1.AutoSize = true;
            quantityLabel1.Location = new System.Drawing.Point(174, 28);
            quantityLabel1.Name = "quantityLabel1";
            quantityLabel1.Size = new System.Drawing.Size(47, 13);
            quantityLabel1.TabIndex = 44;
            quantityLabel1.Text = "quantity:";
            // 
            // unit_priceLabel
            // 
            unit_priceLabel.AutoSize = true;
            unit_priceLabel.Location = new System.Drawing.Point(326, 28);
            unit_priceLabel.Name = "unit_priceLabel";
            unit_priceLabel.Size = new System.Drawing.Size(53, 13);
            unit_priceLabel.TabIndex = 45;
            unit_priceLabel.Text = "unit price:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(502, 28);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(50, 13);
            discountLabel.TabIndex = 46;
            discountLabel.Text = "discount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 13);
            label1.TabIndex = 29;
            label1.Text = "From date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 13);
            label2.TabIndex = 31;
            label2.Text = "To date:";
            // 
            // employee_idLabel1
            // 
            employee_idLabel1.AutoSize = true;
            employee_idLabel1.Location = new System.Drawing.Point(22, 29);
            employee_idLabel1.Name = "employee_idLabel1";
            employee_idLabel1.Size = new System.Drawing.Size(66, 13);
            employee_idLabel1.TabIndex = 30;
            employee_idLabel1.Text = "employee id:";
            // 
            // customer_idLabel1
            // 
            customer_idLabel1.AutoSize = true;
            customer_idLabel1.Location = new System.Drawing.Point(24, 56);
            customer_idLabel1.Name = "customer_idLabel1";
            customer_idLabel1.Size = new System.Drawing.Size(64, 13);
            customer_idLabel1.TabIndex = 31;
            customer_idLabel1.Text = "customer id:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(9, 32);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 47;
            idLabel.Text = "id:";
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.qLBHDataSet;
            // 
            // order_dateDateTimePicker
            // 
            this.order_dateDateTimePicker.Location = new System.Drawing.Point(94, 79);
            this.order_dateDateTimePicker.Name = "order_dateDateTimePicker";
            this.order_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.order_dateDateTimePicker.TabIndex = 6;
            // 
            // shipped_dateDateTimePicker
            // 
            this.shipped_dateDateTimePicker.Location = new System.Drawing.Point(94, 105);
            this.shipped_dateDateTimePicker.Name = "shipped_dateDateTimePicker";
            this.shipped_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.shipped_dateDateTimePicker.TabIndex = 8;
            // 
            // ship_nameTextBox
            // 
            this.ship_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_name", true));
            this.ship_nameTextBox.Location = new System.Drawing.Point(94, 131);
            this.ship_nameTextBox.Name = "ship_nameTextBox";
            this.ship_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_nameTextBox.TabIndex = 10;
            // 
            // ship_address1TextBox
            // 
            this.ship_address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_address1", true));
            this.ship_address1TextBox.Location = new System.Drawing.Point(94, 157);
            this.ship_address1TextBox.Name = "ship_address1TextBox";
            this.ship_address1TextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_address1TextBox.TabIndex = 12;
            // 
            // ship_address2TextBox
            // 
            this.ship_address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_address2", true));
            this.ship_address2TextBox.Location = new System.Drawing.Point(397, 26);
            this.ship_address2TextBox.Name = "ship_address2TextBox";
            this.ship_address2TextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_address2TextBox.TabIndex = 14;
            // 
            // ship_cityTextBox
            // 
            this.ship_cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_city", true));
            this.ship_cityTextBox.Location = new System.Drawing.Point(397, 53);
            this.ship_cityTextBox.Name = "ship_cityTextBox";
            this.ship_cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_cityTextBox.TabIndex = 16;
            // 
            // ship_stateTextBox
            // 
            this.ship_stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_state", true));
            this.ship_stateTextBox.Location = new System.Drawing.Point(397, 79);
            this.ship_stateTextBox.Name = "ship_stateTextBox";
            this.ship_stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_stateTextBox.TabIndex = 18;
            // 
            // ship_postal_codeTextBox
            // 
            this.ship_postal_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_postal_code", true));
            this.ship_postal_codeTextBox.Location = new System.Drawing.Point(397, 105);
            this.ship_postal_codeTextBox.Name = "ship_postal_codeTextBox";
            this.ship_postal_codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_postal_codeTextBox.TabIndex = 20;
            // 
            // ship_countryTextBox
            // 
            this.ship_countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_country", true));
            this.ship_countryTextBox.Location = new System.Drawing.Point(397, 131);
            this.ship_countryTextBox.Name = "ship_countryTextBox";
            this.ship_countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_countryTextBox.TabIndex = 22;
            // 
            // payment_typeTextBox
            // 
            this.payment_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "payment_type", true));
            this.payment_typeTextBox.Location = new System.Drawing.Point(397, 157);
            this.payment_typeTextBox.Name = "payment_typeTextBox";
            this.payment_typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.payment_typeTextBox.TabIndex = 24;
            // 
            // payment_typeTextBox1
            // 
            this.payment_typeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "payment_type", true));
            this.payment_typeTextBox1.Location = new System.Drawing.Point(581, 26);
            this.payment_typeTextBox1.Name = "payment_typeTextBox1";
            this.payment_typeTextBox1.Size = new System.Drawing.Size(200, 20);
            this.payment_typeTextBox1.TabIndex = 26;
            // 
            // paid_dateDateTimePicker
            // 
            this.paid_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "paid_date", true));
            this.paid_dateDateTimePicker.Location = new System.Drawing.Point(581, 53);
            this.paid_dateDateTimePicker.Name = "paid_dateDateTimePicker";
            this.paid_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.paid_dateDateTimePicker.TabIndex = 28;
            // 
            // order_statusTextBox
            // 
            this.order_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_status", true));
            this.order_statusTextBox.Location = new System.Drawing.Point(581, 79);
            this.order_statusTextBox.Name = "order_statusTextBox";
            this.order_statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.order_statusTextBox.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Thêm SP";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvChiTietDonHang
            // 
            this.dgvChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDonHang.Location = new System.Drawing.Point(33, 56);
            this.dgvChiTietDonHang.Name = "dgvChiTietDonHang";
            this.dgvChiTietDonHang.Size = new System.Drawing.Size(765, 209);
            this.dgvChiTietDonHang.TabIndex = 44;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(441, 538);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 23);
            this.btnThem.TabIndex = 45;
            this.btnThem.Text = "Thêm đơn hàng";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(543, 536);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 23);
            this.btnSua.TabIndex = 45;
            this.btnSua.Text = "Sửa đơn hàng";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(636, 538);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 23);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xóa đơn hàng";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(734, 538);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 45;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(825, 538);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 45;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grpThongTinDonHang
            // 
            this.grpThongTinDonHang.Controls.Add(customer_idLabel1);
            this.grpThongTinDonHang.Controls.Add(this.cbbCustomer);
            this.grpThongTinDonHang.Controls.Add(employee_idLabel1);
            this.grpThongTinDonHang.Controls.Add(this.cbbEmployee);
            this.grpThongTinDonHang.Controls.Add(this.payment_typeTextBox1);
            this.grpThongTinDonHang.Controls.Add(this.paid_dateDateTimePicker);
            this.grpThongTinDonHang.Controls.Add(this.order_statusTextBox);
            this.grpThongTinDonHang.Controls.Add(order_statusLabel);
            this.grpThongTinDonHang.Controls.Add(paid_dateLabel);
            this.grpThongTinDonHang.Controls.Add(payment_typeLabel1);
            this.grpThongTinDonHang.Controls.Add(payment_typeLabel);
            this.grpThongTinDonHang.Controls.Add(this.payment_typeTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_countryLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_countryTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_postal_codeLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_postal_codeTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_stateLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_stateTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_cityLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_cityTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_address2Label);
            this.grpThongTinDonHang.Controls.Add(this.ship_address2TextBox);
            this.grpThongTinDonHang.Controls.Add(ship_address1Label);
            this.grpThongTinDonHang.Controls.Add(this.ship_address1TextBox);
            this.grpThongTinDonHang.Controls.Add(ship_nameLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_nameTextBox);
            this.grpThongTinDonHang.Controls.Add(shipped_dateLabel);
            this.grpThongTinDonHang.Controls.Add(this.shipped_dateDateTimePicker);
            this.grpThongTinDonHang.Controls.Add(order_dateLabel);
            this.grpThongTinDonHang.Controls.Add(this.order_dateDateTimePicker);
            this.grpThongTinDonHang.Location = new System.Drawing.Point(287, 26);
            this.grpThongTinDonHang.Name = "grpThongTinDonHang";
            this.grpThongTinDonHang.Size = new System.Drawing.Size(805, 197);
            this.grpThongTinDonHang.TabIndex = 46;
            this.grpThongTinDonHang.TabStop = false;
            this.grpThongTinDonHang.Text = "Thông tin đơn hàng";
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(94, 53);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbbCustomer.TabIndex = 32;
            // 
            // cbbEmployee
            // 
            this.cbbEmployee.FormattingEnabled = true;
            this.cbbEmployee.Location = new System.Drawing.Point(94, 26);
            this.cbbEmployee.Name = "cbbEmployee";
            this.cbbEmployee.Size = new System.Drawing.Size(121, 21);
            this.cbbEmployee.TabIndex = 31;
            // 
            // grpThongTinChiTietDonHang
            // 
            this.grpThongTinChiTietDonHang.Controls.Add(idLabel);
            this.grpThongTinChiTietDonHang.Controls.Add(this.cbbProduct);
            this.grpThongTinChiTietDonHang.Controls.Add(discountLabel);
            this.grpThongTinChiTietDonHang.Controls.Add(this.discountNumericUpDown);
            this.grpThongTinChiTietDonHang.Controls.Add(unit_priceLabel);
            this.grpThongTinChiTietDonHang.Controls.Add(this.unit_priceNumericUpDown);
            this.grpThongTinChiTietDonHang.Controls.Add(quantityLabel1);
            this.grpThongTinChiTietDonHang.Controls.Add(this.quantityTextBox);
            this.grpThongTinChiTietDonHang.Controls.Add(this.dgvChiTietDonHang);
            this.grpThongTinChiTietDonHang.Controls.Add(this.button1);
            this.grpThongTinChiTietDonHang.Location = new System.Drawing.Point(287, 246);
            this.grpThongTinChiTietDonHang.Name = "grpThongTinChiTietDonHang";
            this.grpThongTinChiTietDonHang.Size = new System.Drawing.Size(818, 285);
            this.grpThongTinChiTietDonHang.TabIndex = 47;
            this.grpThongTinChiTietDonHang.TabStop = false;
            this.grpThongTinChiTietDonHang.Text = "Thông tin chi tiết đơn hàng";
            // 
            // cbbProduct
            // 
            this.cbbProduct.FormattingEnabled = true;
            this.cbbProduct.Location = new System.Drawing.Point(33, 29);
            this.cbbProduct.Name = "cbbProduct";
            this.cbbProduct.Size = new System.Drawing.Size(121, 21);
            this.cbbProduct.TabIndex = 48;
            // 
            // discountNumericUpDown
            // 
            this.discountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_detailsBindingSource, "discount", true));
            this.discountNumericUpDown.Location = new System.Drawing.Point(552, 26);
            this.discountNumericUpDown.Name = "discountNumericUpDown";
            this.discountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.discountNumericUpDown.TabIndex = 47;
            // 
            // order_detailsBindingSource
            // 
            this.order_detailsBindingSource.DataMember = "order_details";
            this.order_detailsBindingSource.DataSource = this.qLBHDataSet;
            // 
            // unit_priceNumericUpDown
            // 
            this.unit_priceNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_detailsBindingSource, "unit_price", true));
            this.unit_priceNumericUpDown.Location = new System.Drawing.Point(378, 26);
            this.unit_priceNumericUpDown.Name = "unit_priceNumericUpDown";
            this.unit_priceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.unit_priceNumericUpDown.TabIndex = 46;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(221, 25);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 45;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoadOrder);
            this.groupBox3.Controls.Add(this.dgvDonHang);
            this.groupBox3.Controls.Add(this.dtpDenNgay);
            this.groupBox3.Controls.Add(label2);
            this.groupBox3.Controls.Add(this.dtpTuNgay);
            this.groupBox3.Controls.Add(label1);
            this.groupBox3.Location = new System.Drawing.Point(15, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 493);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách đơn hàng";
            // 
            // btnLoadOrder
            // 
            this.btnLoadOrder.Location = new System.Drawing.Point(9, 83);
            this.btnLoadOrder.Name = "btnLoadOrder";
            this.btnLoadOrder.Size = new System.Drawing.Size(251, 23);
            this.btnLoadOrder.TabIndex = 34;
            this.btnLoadOrder.Text = "Lấy danh sách đơn hàng";
            this.btnLoadOrder.UseVisualStyleBackColor = true;
            this.btnLoadOrder.Click += new System.EventHandler(this.btnLoadOrder_Click);
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AutoGenerateColumns = false;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderdateDataGridViewTextBoxColumn,
            this.shippeddateDataGridViewTextBoxColumn,
            this.id,
            this.employee_id,
            this.customer_id,
            this.ship_name,
            this.ship_address1,
            this.ship_address2,
            this.ship_city,
            this.ship_state,
            this.ship_postal_code,
            this.ship_country,
            this.shipping_fee,
            this.payment_type,
            this.paid_date,
            this.order_status});
            this.dgvDonHang.DataSource = this.ordersBindingSource;
            this.dgvDonHang.Location = new System.Drawing.Point(6, 112);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.Size = new System.Drawing.Size(251, 393);
            this.dgvDonHang.TabIndex = 33;
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "order_date";
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            // 
            // shippeddateDataGridViewTextBoxColumn
            // 
            this.shippeddateDataGridViewTextBoxColumn.DataPropertyName = "shipped_date";
            this.shippeddateDataGridViewTextBoxColumn.HeaderText = "shipped_date";
            this.shippeddateDataGridViewTextBoxColumn.Name = "shippeddateDataGridViewTextBoxColumn";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // employee_id
            // 
            this.employee_id.DataPropertyName = "employee_id";
            this.employee_id.HeaderText = "employee_id";
            this.employee_id.Name = "employee_id";
            this.employee_id.Visible = false;
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "customer_id";
            this.customer_id.Name = "customer_id";
            this.customer_id.Visible = false;
            // 
            // ship_name
            // 
            this.ship_name.DataPropertyName = "ship_name";
            this.ship_name.HeaderText = "ship_name";
            this.ship_name.Name = "ship_name";
            this.ship_name.Visible = false;
            // 
            // ship_address1
            // 
            this.ship_address1.DataPropertyName = "ship_address1";
            this.ship_address1.HeaderText = "ship_address1";
            this.ship_address1.Name = "ship_address1";
            this.ship_address1.Visible = false;
            // 
            // ship_address2
            // 
            this.ship_address2.DataPropertyName = "ship_address2";
            this.ship_address2.HeaderText = "ship_address2";
            this.ship_address2.Name = "ship_address2";
            this.ship_address2.Visible = false;
            // 
            // ship_city
            // 
            this.ship_city.DataPropertyName = "ship_city";
            this.ship_city.HeaderText = "ship_city";
            this.ship_city.Name = "ship_city";
            this.ship_city.Visible = false;
            // 
            // ship_state
            // 
            this.ship_state.DataPropertyName = "ship_state";
            this.ship_state.HeaderText = "ship_state";
            this.ship_state.Name = "ship_state";
            this.ship_state.Visible = false;
            // 
            // ship_postal_code
            // 
            this.ship_postal_code.DataPropertyName = "ship_postal_code";
            this.ship_postal_code.HeaderText = "ship_postal_code";
            this.ship_postal_code.Name = "ship_postal_code";
            this.ship_postal_code.Visible = false;
            // 
            // ship_country
            // 
            this.ship_country.DataPropertyName = "ship_country";
            this.ship_country.HeaderText = "ship_country";
            this.ship_country.Name = "ship_country";
            this.ship_country.Visible = false;
            // 
            // shipping_fee
            // 
            this.shipping_fee.DataPropertyName = "shipping_fee";
            this.shipping_fee.HeaderText = "shipping_fee";
            this.shipping_fee.Name = "shipping_fee";
            this.shipping_fee.Visible = false;
            // 
            // payment_type
            // 
            this.payment_type.DataPropertyName = "payment_type";
            this.payment_type.HeaderText = "payment_type";
            this.payment_type.Name = "payment_type";
            this.payment_type.Visible = false;
            // 
            // paid_date
            // 
            this.paid_date.DataPropertyName = "paid_date";
            this.paid_date.HeaderText = "paid_date";
            this.paid_date.Name = "paid_date";
            this.paid_date.Visible = false;
            // 
            // order_status
            // 
            this.order_status.DataPropertyName = "order_status";
            this.order_status.HeaderText = "order_status";
            this.order_status.Name = "order_status";
            this.order_status.Visible = false;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "paid_date", true));
            this.dtpDenNgay.Location = new System.Drawing.Point(59, 50);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpDenNgay.TabIndex = 32;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "paid_date", true));
            this.dtpTuNgay.Location = new System.Drawing.Point(60, 23);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpTuNgay.TabIndex = 30;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configsTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.order_detailsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLBH.QLBHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.qLBHDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(339, 538);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(96, 23);
            this.btnInHoaDon.TabIndex = 45;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // FrmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 579);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpThongTinChiTietDonHang);
            this.Controls.Add(this.grpThongTinDonHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnThem);
            this.Name = "FrmDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDatHang";
            this.Load += new System.EventHandler(this.FrmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).EndInit();
            this.grpThongTinDonHang.ResumeLayout(false);
            this.grpThongTinDonHang.PerformLayout();
            this.grpThongTinChiTietDonHang.ResumeLayout(false);
            this.grpThongTinChiTietDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit_priceNumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLBHDataSet qLBHDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.DateTimePicker order_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker shipped_dateDateTimePicker;
        private System.Windows.Forms.TextBox ship_nameTextBox;
        private System.Windows.Forms.TextBox ship_address1TextBox;
        private System.Windows.Forms.TextBox ship_address2TextBox;
        private System.Windows.Forms.TextBox ship_cityTextBox;
        private System.Windows.Forms.TextBox ship_stateTextBox;
        private System.Windows.Forms.TextBox ship_postal_codeTextBox;
        private System.Windows.Forms.TextBox ship_countryTextBox;
        private System.Windows.Forms.TextBox payment_typeTextBox;
        private System.Windows.Forms.TextBox payment_typeTextBox1;
        private System.Windows.Forms.DateTimePicker paid_dateDateTimePicker;
        private System.Windows.Forms.TextBox order_statusTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvChiTietDonHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grpThongTinDonHang;
        private System.Windows.Forms.GroupBox grpThongTinChiTietDonHang;
        private System.Windows.Forms.BindingSource order_detailsBindingSource;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.NumericUpDown discountNumericUpDown;
        private System.Windows.Forms.NumericUpDown unit_priceNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.Button btnLoadOrder;
        private System.Windows.Forms.ComboBox cbbEmployee;
        private QLBHDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippeddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ship_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ship_address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ship_address2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ship_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn ship_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn ship_postal_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ship_country;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipping_fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_status;
        private System.Windows.Forms.ComboBox cbbCustomer;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private QLBHDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.ComboBox cbbProduct;
        private System.Windows.Forms.Button btnInHoaDon;
    }
}