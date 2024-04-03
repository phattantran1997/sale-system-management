namespace QLBH.Functions
{
    partial class FrmDanhMucSanPham
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
            System.Windows.Forms.Label product_codeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMucSanPham));
            System.Windows.Forms.Label product_nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label standard_costLabel;
            System.Windows.Forms.Label list_priceLabel;
            System.Windows.Forms.Label quantity_per_unitLabel;
            System.Windows.Forms.Label discontinuedLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label target_levelLabel;
            System.Windows.Forms.Label reorder_levelLabel;
            System.Windows.Forms.Label minimum_reorder_quantityLabel;
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new QLBH.QLBHDataSetTableAdapters.productsTableAdapter();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.product_codeTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.product_nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.standard_costTextBox = new System.Windows.Forms.TextBox();
            this.list_priceTextBox = new System.Windows.Forms.TextBox();
            this.quantity_per_unitTextBox = new System.Windows.Forms.TextBox();
            this.discontinuedTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.target_levelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.reorder_levelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minimum_reorder_quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            product_codeLabel = new System.Windows.Forms.Label();
            product_nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            standard_costLabel = new System.Windows.Forms.Label();
            list_priceLabel = new System.Windows.Forms.Label();
            quantity_per_unitLabel = new System.Windows.Forms.Label();
            discontinuedLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            target_levelLabel = new System.Windows.Forms.Label();
            reorder_levelLabel = new System.Windows.Forms.Label();
            minimum_reorder_quantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target_levelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reorder_levelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimum_reorder_quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configsTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.order_detailsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLBH.QLBHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productsBindingNavigatorSaveItem});
            this.productsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productsBindingNavigator.Size = new System.Drawing.Size(809, 25);
            this.productsBindingNavigator.TabIndex = 0;
            this.productsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // product_codeLabel
            // 
            product_codeLabel.AutoSize = true;
            product_codeLabel.Location = new System.Drawing.Point(62, 44);
            product_codeLabel.Name = "product_codeLabel";
            product_codeLabel.Size = new System.Drawing.Size(73, 13);
            product_codeLabel.TabIndex = 1;
            product_codeLabel.Text = "product code:";
            // 
            // product_codeTextBox
            // 
            this.product_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "product_code", true));
            this.product_codeTextBox.Location = new System.Drawing.Point(141, 41);
            this.product_codeTextBox.Name = "product_codeTextBox";
            this.product_codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_codeTextBox.TabIndex = 2;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // productsBindingNavigatorSaveItem
            // 
            this.productsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsBindingNavigatorSaveItem.Image")));
            this.productsBindingNavigatorSaveItem.Name = "productsBindingNavigatorSaveItem";
            this.productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productsBindingNavigatorSaveItem.Text = "Save Data";
            this.productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click);
            // 
            // product_nameLabel
            // 
            product_nameLabel.AutoSize = true;
            product_nameLabel.Location = new System.Drawing.Point(60, 70);
            product_nameLabel.Name = "product_nameLabel";
            product_nameLabel.Size = new System.Drawing.Size(75, 13);
            product_nameLabel.TabIndex = 3;
            product_nameLabel.Text = "product name:";
            // 
            // product_nameTextBox
            // 
            this.product_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "product_name", true));
            this.product_nameTextBox.Location = new System.Drawing.Point(141, 67);
            this.product_nameTextBox.Name = "product_nameTextBox";
            this.product_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_nameTextBox.TabIndex = 4;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(74, 96);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 13);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(141, 93);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // standard_costLabel
            // 
            standard_costLabel.AutoSize = true;
            standard_costLabel.Location = new System.Drawing.Point(61, 122);
            standard_costLabel.Name = "standard_costLabel";
            standard_costLabel.Size = new System.Drawing.Size(74, 13);
            standard_costLabel.TabIndex = 7;
            standard_costLabel.Text = "standard cost:";
            // 
            // standard_costTextBox
            // 
            this.standard_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "standard_cost", true));
            this.standard_costTextBox.Location = new System.Drawing.Point(141, 119);
            this.standard_costTextBox.Name = "standard_costTextBox";
            this.standard_costTextBox.Size = new System.Drawing.Size(100, 20);
            this.standard_costTextBox.TabIndex = 8;
            // 
            // list_priceLabel
            // 
            list_priceLabel.AutoSize = true;
            list_priceLabel.Location = new System.Drawing.Point(288, 44);
            list_priceLabel.Name = "list_priceLabel";
            list_priceLabel.Size = new System.Drawing.Size(48, 13);
            list_priceLabel.TabIndex = 9;
            list_priceLabel.Text = "list price:";
            // 
            // list_priceTextBox
            // 
            this.list_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "list_price", true));
            this.list_priceTextBox.Location = new System.Drawing.Point(342, 41);
            this.list_priceTextBox.Name = "list_priceTextBox";
            this.list_priceTextBox.Size = new System.Drawing.Size(120, 20);
            this.list_priceTextBox.TabIndex = 10;
            // 
            // quantity_per_unitLabel
            // 
            quantity_per_unitLabel.AutoSize = true;
            quantity_per_unitLabel.Location = new System.Drawing.Point(526, 44);
            quantity_per_unitLabel.Name = "quantity_per_unitLabel";
            quantity_per_unitLabel.Size = new System.Drawing.Size(85, 13);
            quantity_per_unitLabel.TabIndex = 17;
            quantity_per_unitLabel.Text = "quantity per unit:";
            // 
            // quantity_per_unitTextBox
            // 
            this.quantity_per_unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "quantity_per_unit", true));
            this.quantity_per_unitTextBox.Location = new System.Drawing.Point(617, 41);
            this.quantity_per_unitTextBox.Name = "quantity_per_unitTextBox";
            this.quantity_per_unitTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantity_per_unitTextBox.TabIndex = 18;
            // 
            // discontinuedLabel
            // 
            discontinuedLabel.AutoSize = true;
            discontinuedLabel.Location = new System.Drawing.Point(541, 70);
            discontinuedLabel.Name = "discontinuedLabel";
            discontinuedLabel.Size = new System.Drawing.Size(70, 13);
            discontinuedLabel.TabIndex = 19;
            discontinuedLabel.Text = "discontinued:";
            // 
            // discontinuedTextBox
            // 
            this.discontinuedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "discontinued", true));
            this.discontinuedTextBox.Location = new System.Drawing.Point(617, 67);
            this.discontinuedTextBox.Name = "discontinuedTextBox";
            this.discontinuedTextBox.Size = new System.Drawing.Size(100, 20);
            this.discontinuedTextBox.TabIndex = 20;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(560, 96);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(51, 13);
            categoryLabel.TabIndex = 21;
            categoryLabel.Text = "category:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(617, 93);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryTextBox.TabIndex = 22;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(12, 171);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.Size = new System.Drawing.Size(777, 220);
            this.productsDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "product_code";
            this.dataGridViewTextBoxColumn2.HeaderText = "product_code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "product_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "product_name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn4.HeaderText = "description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "standard_cost";
            this.dataGridViewTextBoxColumn5.HeaderText = "standard_cost";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "list_price";
            this.dataGridViewTextBoxColumn6.HeaderText = "list_price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "target_level";
            this.dataGridViewTextBoxColumn7.HeaderText = "target_level";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "reorder_level";
            this.dataGridViewTextBoxColumn8.HeaderText = "reorder_level";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "minimum_reorder_quantity";
            this.dataGridViewTextBoxColumn9.HeaderText = "minimum_reorder_quantity";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "quantity_per_unit";
            this.dataGridViewTextBoxColumn10.HeaderText = "quantity_per_unit";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "discontinued";
            this.dataGridViewTextBoxColumn11.HeaderText = "discontinued";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn12.HeaderText = "category";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(552, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(633, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Lưu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(714, 408);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // target_levelLabel
            // 
            target_levelLabel.AutoSize = true;
            target_levelLabel.Location = new System.Drawing.Point(274, 67);
            target_levelLabel.Name = "target_levelLabel";
            target_levelLabel.Size = new System.Drawing.Size(62, 13);
            target_levelLabel.TabIndex = 27;
            target_levelLabel.Text = "target level:";
            // 
            // target_levelNumericUpDown
            // 
            this.target_levelNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "target_level", true));
            this.target_levelNumericUpDown.Location = new System.Drawing.Point(342, 67);
            this.target_levelNumericUpDown.Name = "target_levelNumericUpDown";
            this.target_levelNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.target_levelNumericUpDown.TabIndex = 28;
            // 
            // reorder_levelLabel
            // 
            reorder_levelLabel.AutoSize = true;
            reorder_levelLabel.Location = new System.Drawing.Point(268, 93);
            reorder_levelLabel.Name = "reorder_levelLabel";
            reorder_levelLabel.Size = new System.Drawing.Size(68, 13);
            reorder_levelLabel.TabIndex = 28;
            reorder_levelLabel.Text = "reorder level:";
            // 
            // reorder_levelNumericUpDown
            // 
            this.reorder_levelNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "reorder_level", true));
            this.reorder_levelNumericUpDown.Location = new System.Drawing.Point(342, 93);
            this.reorder_levelNumericUpDown.Name = "reorder_levelNumericUpDown";
            this.reorder_levelNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.reorder_levelNumericUpDown.TabIndex = 29;
            // 
            // minimum_reorder_quantityLabel
            // 
            minimum_reorder_quantityLabel.AutoSize = true;
            minimum_reorder_quantityLabel.Location = new System.Drawing.Point(258, 120);
            minimum_reorder_quantityLabel.Name = "minimum_reorder_quantityLabel";
            minimum_reorder_quantityLabel.Size = new System.Drawing.Size(126, 13);
            minimum_reorder_quantityLabel.TabIndex = 29;
            minimum_reorder_quantityLabel.Text = "minimum reorder quantity:";
            // 
            // minimum_reorder_quantityNumericUpDown
            // 
            this.minimum_reorder_quantityNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "minimum_reorder_quantity", true));
            this.minimum_reorder_quantityNumericUpDown.Location = new System.Drawing.Point(390, 120);
            this.minimum_reorder_quantityNumericUpDown.Name = "minimum_reorder_quantityNumericUpDown";
            this.minimum_reorder_quantityNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.minimum_reorder_quantityNumericUpDown.TabIndex = 30;
            // 
            // FrmDanhMucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 451);
            this.Controls.Add(minimum_reorder_quantityLabel);
            this.Controls.Add(this.minimum_reorder_quantityNumericUpDown);
            this.Controls.Add(reorder_levelLabel);
            this.Controls.Add(this.reorder_levelNumericUpDown);
            this.Controls.Add(target_levelLabel);
            this.Controls.Add(this.target_levelNumericUpDown);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(discontinuedLabel);
            this.Controls.Add(this.discontinuedTextBox);
            this.Controls.Add(quantity_per_unitLabel);
            this.Controls.Add(this.quantity_per_unitTextBox);
            this.Controls.Add(list_priceLabel);
            this.Controls.Add(this.list_priceTextBox);
            this.Controls.Add(standard_costLabel);
            this.Controls.Add(this.standard_costTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(product_nameLabel);
            this.Controls.Add(this.product_nameTextBox);
            this.Controls.Add(product_codeLabel);
            this.Controls.Add(this.product_codeTextBox);
            this.Controls.Add(this.productsBindingNavigator);
            this.Name = "FrmDanhMucSanPham";
            this.Text = "FrmDanhMucSanPham";
            this.Load += new System.EventHandler(this.FrmDanhMucSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target_levelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reorder_levelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimum_reorder_quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLBHDataSet qLBHDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private QLBHDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox product_codeTextBox;
        private System.Windows.Forms.TextBox product_nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox standard_costTextBox;
        private System.Windows.Forms.TextBox list_priceTextBox;
        private System.Windows.Forms.TextBox quantity_per_unitTextBox;
        private System.Windows.Forms.TextBox discontinuedTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown target_levelNumericUpDown;
        private System.Windows.Forms.NumericUpDown reorder_levelNumericUpDown;
        private System.Windows.Forms.NumericUpDown minimum_reorder_quantityNumericUpDown;
    }
}