namespace UI
{
    partial class KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.dataGridView_kh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_kh_them = new System.Windows.Forms.Button();
            this.button_kh_luu = new System.Windows.Forms.Button();
            this.button_kh_sua = new System.Windows.Forms.Button();
            this.button_kh_xoa = new System.Windows.Forms.Button();
            this.button_kh_huybo = new System.Windows.Forms.Button();
            this.textBox_kh_makh = new System.Windows.Forms.TextBox();
            this.textBox_kh_tenkh = new System.Windows.Forms.TextBox();
            this.textBox_kh_sdt = new System.Windows.Forms.TextBox();
            this.textBox_kh_dc = new System.Windows.Forms.TextBox();
            this.label_kh_makh = new System.Windows.Forms.Label();
            this.label_kh_tenkh = new System.Windows.Forms.Label();
            this.label_kh_sdt = new System.Windows.Forms.Label();
            this.label_kh_dc = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_kh_tc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_timkiem = new System.Windows.Forms.ComboBox();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.pictureBox_bh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_kh
            // 
            this.dataGridView_kh.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_kh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_kh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_kh.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_kh.Location = new System.Drawing.Point(-3, 400);
            this.dataGridView_kh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_kh.Name = "dataGridView_kh";
            this.dataGridView_kh.ReadOnly = true;
            this.dataGridView_kh.RowHeadersWidth = 62;
            this.dataGridView_kh.Size = new System.Drawing.Size(2032, 723);
            this.dataGridView_kh.TabIndex = 0;
            this.dataGridView_kh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_kh_CellContentClick);
            this.dataGridView_kh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_kh_CellContentClick);
            this.dataGridView_kh.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_kh_CellDoubleClick);
            this.dataGridView_kh.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_kh_CellDoubleClick);
            this.dataGridView_kh.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_kh_CellMouseClick);
            this.dataGridView_kh.Click += new System.EventHandler(this.button_kh_thoat_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Tên Khách Hàng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "SDTKH";
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "DiaChiKH";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DiemTichLuy";
            this.Column5.HeaderText = "Điểm Tích Lũy";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // button_kh_them
            // 
            this.button_kh_them.BackColor = System.Drawing.Color.Transparent;
            this.button_kh_them.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.button_kh_them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_kh_them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_kh_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kh_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kh_them.ForeColor = System.Drawing.Color.Lime;
            this.button_kh_them.Image = global::UI.Properties.Resources._48px_Crystal_Clear_action_db_add;
            this.button_kh_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kh_them.Location = new System.Drawing.Point(861, 311);
            this.button_kh_them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_kh_them.Name = "button_kh_them";
            this.button_kh_them.Size = new System.Drawing.Size(196, 80);
            this.button_kh_them.TabIndex = 1;
            this.button_kh_them.Text = "THÊM";
            this.button_kh_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kh_them.UseVisualStyleBackColor = false;
            this.button_kh_them.Click += new System.EventHandler(this.button_kh_them_Click);
            // 
            // button_kh_luu
            // 
            this.button_kh_luu.BackColor = System.Drawing.Color.Transparent;
            this.button_kh_luu.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.button_kh_luu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_kh_luu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_kh_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kh_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kh_luu.ForeColor = System.Drawing.Color.Lime;
            this.button_kh_luu.Image = global::UI.Properties.Resources.Save_as_icon;
            this.button_kh_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kh_luu.Location = new System.Drawing.Point(1066, 311);
            this.button_kh_luu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_kh_luu.Name = "button_kh_luu";
            this.button_kh_luu.Size = new System.Drawing.Size(196, 80);
            this.button_kh_luu.TabIndex = 2;
            this.button_kh_luu.Text = "LƯU";
            this.button_kh_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kh_luu.UseVisualStyleBackColor = false;
            this.button_kh_luu.Click += new System.EventHandler(this.button_kh_luu_Click);
            // 
            // button_kh_sua
            // 
            this.button_kh_sua.BackColor = System.Drawing.Color.Transparent;
            this.button_kh_sua.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.button_kh_sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_kh_sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_kh_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kh_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kh_sua.ForeColor = System.Drawing.Color.Lime;
            this.button_kh_sua.Image = global::UI.Properties.Resources._48px_Crystal_Clear_app_package_settings;
            this.button_kh_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kh_sua.Location = new System.Drawing.Point(1272, 311);
            this.button_kh_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_kh_sua.Name = "button_kh_sua";
            this.button_kh_sua.Size = new System.Drawing.Size(196, 80);
            this.button_kh_sua.TabIndex = 3;
            this.button_kh_sua.Text = "SỬA";
            this.button_kh_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kh_sua.UseVisualStyleBackColor = false;
            this.button_kh_sua.Click += new System.EventHandler(this.button_kh_sua_Click);
            // 
            // button_kh_xoa
            // 
            this.button_kh_xoa.BackColor = System.Drawing.Color.Transparent;
            this.button_kh_xoa.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.button_kh_xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_kh_xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_kh_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kh_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kh_xoa.ForeColor = System.Drawing.Color.Lime;
            this.button_kh_xoa.Image = global::UI.Properties.Resources._1439855765_1_04;
            this.button_kh_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kh_xoa.Location = new System.Drawing.Point(1479, 311);
            this.button_kh_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_kh_xoa.Name = "button_kh_xoa";
            this.button_kh_xoa.Size = new System.Drawing.Size(196, 80);
            this.button_kh_xoa.TabIndex = 4;
            this.button_kh_xoa.Text = "XÓA";
            this.button_kh_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kh_xoa.UseVisualStyleBackColor = false;
            this.button_kh_xoa.Click += new System.EventHandler(this.button_kh_xoa_Click);
            // 
            // button_kh_huybo
            // 
            this.button_kh_huybo.BackColor = System.Drawing.Color.Transparent;
            this.button_kh_huybo.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.button_kh_huybo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_kh_huybo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_kh_huybo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kh_huybo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kh_huybo.ForeColor = System.Drawing.Color.Lime;
            this.button_kh_huybo.Image = global::UI.Properties.Resources._1439854729_DeleteRed;
            this.button_kh_huybo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kh_huybo.Location = new System.Drawing.Point(1683, 311);
            this.button_kh_huybo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_kh_huybo.Name = "button_kh_huybo";
            this.button_kh_huybo.Size = new System.Drawing.Size(196, 80);
            this.button_kh_huybo.TabIndex = 5;
            this.button_kh_huybo.Text = "HỦY BỎ";
            this.button_kh_huybo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kh_huybo.UseVisualStyleBackColor = false;
            this.button_kh_huybo.Click += new System.EventHandler(this.button_kh_thoat_Click);
            // 
            // textBox_kh_makh
            // 
            this.textBox_kh_makh.BackColor = System.Drawing.Color.LightGray;
            this.textBox_kh_makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_kh_makh.ForeColor = System.Drawing.Color.Blue;
            this.textBox_kh_makh.Location = new System.Drawing.Point(338, 31);
            this.textBox_kh_makh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_kh_makh.Multiline = true;
            this.textBox_kh_makh.Name = "textBox_kh_makh";
            this.textBox_kh_makh.Size = new System.Drawing.Size(388, 69);
            this.textBox_kh_makh.TabIndex = 6;
            // 
            // textBox_kh_tenkh
            // 
            this.textBox_kh_tenkh.BackColor = System.Drawing.Color.LightGray;
            this.textBox_kh_tenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_kh_tenkh.ForeColor = System.Drawing.Color.Blue;
            this.textBox_kh_tenkh.Location = new System.Drawing.Point(338, 148);
            this.textBox_kh_tenkh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_kh_tenkh.Multiline = true;
            this.textBox_kh_tenkh.Name = "textBox_kh_tenkh";
            this.textBox_kh_tenkh.Size = new System.Drawing.Size(388, 69);
            this.textBox_kh_tenkh.TabIndex = 7;
            // 
            // textBox_kh_sdt
            // 
            this.textBox_kh_sdt.BackColor = System.Drawing.Color.LightGray;
            this.textBox_kh_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_kh_sdt.ForeColor = System.Drawing.Color.Blue;
            this.textBox_kh_sdt.Location = new System.Drawing.Point(1012, 31);
            this.textBox_kh_sdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_kh_sdt.MaxLength = 11;
            this.textBox_kh_sdt.Multiline = true;
            this.textBox_kh_sdt.Name = "textBox_kh_sdt";
            this.textBox_kh_sdt.Size = new System.Drawing.Size(388, 69);
            this.textBox_kh_sdt.TabIndex = 8;
            this.textBox_kh_sdt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox_kh_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_kh_sdt_KeyPress);
            // 
            // textBox_kh_dc
            // 
            this.textBox_kh_dc.BackColor = System.Drawing.Color.LightGray;
            this.textBox_kh_dc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_kh_dc.ForeColor = System.Drawing.Color.Blue;
            this.textBox_kh_dc.Location = new System.Drawing.Point(1012, 148);
            this.textBox_kh_dc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_kh_dc.Multiline = true;
            this.textBox_kh_dc.Name = "textBox_kh_dc";
            this.textBox_kh_dc.Size = new System.Drawing.Size(388, 69);
            this.textBox_kh_dc.TabIndex = 9;
            // 
            // label_kh_makh
            // 
            this.label_kh_makh.AutoSize = true;
            this.label_kh_makh.BackColor = System.Drawing.Color.Transparent;
            this.label_kh_makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kh_makh.ForeColor = System.Drawing.Color.Brown;
            this.label_kh_makh.Location = new System.Drawing.Point(30, 49);
            this.label_kh_makh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_kh_makh.Name = "label_kh_makh";
            this.label_kh_makh.Size = new System.Drawing.Size(250, 37);
            this.label_kh_makh.TabIndex = 10;
            this.label_kh_makh.Text = "Mã khách hàng";
            // 
            // label_kh_tenkh
            // 
            this.label_kh_tenkh.AutoSize = true;
            this.label_kh_tenkh.BackColor = System.Drawing.Color.Transparent;
            this.label_kh_tenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kh_tenkh.ForeColor = System.Drawing.Color.Brown;
            this.label_kh_tenkh.Location = new System.Drawing.Point(18, 162);
            this.label_kh_tenkh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_kh_tenkh.Name = "label_kh_tenkh";
            this.label_kh_tenkh.Size = new System.Drawing.Size(262, 37);
            this.label_kh_tenkh.TabIndex = 11;
            this.label_kh_tenkh.Text = "Tên khách hàng";
            this.label_kh_tenkh.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_kh_sdt
            // 
            this.label_kh_sdt.AutoSize = true;
            this.label_kh_sdt.BackColor = System.Drawing.Color.Transparent;
            this.label_kh_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kh_sdt.ForeColor = System.Drawing.Color.Brown;
            this.label_kh_sdt.Location = new System.Drawing.Point(758, 49);
            this.label_kh_sdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_kh_sdt.Name = "label_kh_sdt";
            this.label_kh_sdt.Size = new System.Drawing.Size(218, 37);
            this.label_kh_sdt.TabIndex = 12;
            this.label_kh_sdt.Text = "Số điện thoại";
            // 
            // label_kh_dc
            // 
            this.label_kh_dc.AutoSize = true;
            this.label_kh_dc.BackColor = System.Drawing.Color.Transparent;
            this.label_kh_dc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kh_dc.ForeColor = System.Drawing.Color.Brown;
            this.label_kh_dc.Location = new System.Drawing.Point(758, 162);
            this.label_kh_dc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_kh_dc.Name = "label_kh_dc";
            this.label_kh_dc.Size = new System.Drawing.Size(122, 37);
            this.label_kh_dc.TabIndex = 13;
            this.label_kh_dc.Text = "Địa chỉ";
            // 
            // button_kh_tc
            // 
            this.button_kh_tc.BackColor = System.Drawing.Color.Transparent;
            this.button_kh_tc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_kh_tc.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.button_kh_tc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_kh_tc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_kh_tc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kh_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kh_tc.ForeColor = System.Drawing.Color.Lime;
            this.button_kh_tc.Image = global::UI.Properties.Resources._48px_Crystal_Clear_action_reload;
            this.button_kh_tc.Location = new System.Drawing.Point(1888, 311);
            this.button_kh_tc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_kh_tc.Name = "button_kh_tc";
            this.button_kh_tc.Size = new System.Drawing.Size(128, 80);
            this.button_kh_tc.TabIndex = 6;
            this.button_kh_tc.UseVisualStyleBackColor = false;
            this.button_kh_tc.Click += new System.EventHandler(this.button_kh_tc_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(72, 315);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 33);
            this.label1.TabIndex = 83;
            this.label1.Text = "Tìm kiếm :";
            // 
            // comboBox_timkiem
            // 
            this.comboBox_timkiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_timkiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_timkiem.BackColor = System.Drawing.Color.DarkGray;
            this.comboBox_timkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_timkiem.ForeColor = System.Drawing.Color.Blue;
            this.comboBox_timkiem.FormattingEnabled = true;
            this.comboBox_timkiem.IntegralHeight = false;
            this.comboBox_timkiem.ItemHeight = 33;
            this.comboBox_timkiem.Location = new System.Drawing.Point(270, 311);
            this.comboBox_timkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timkiem.Name = "comboBox_timkiem";
            this.comboBox_timkiem.Size = new System.Drawing.Size(320, 47);
            this.comboBox_timkiem.TabIndex = 82;
            this.comboBox_timkiem.SelectedIndexChanged += new System.EventHandler(this.comboBox_timkiem_SelectedIndexChanged);
            // 
            // button_timkiem
            // 
            this.button_timkiem.BackColor = System.Drawing.Color.Gray;
            this.button_timkiem.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button_timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_timkiem.ForeColor = System.Drawing.Color.Red;
            this.button_timkiem.Image = global::UI.Properties.Resources._1438980118_search_icon_tm;
            this.button_timkiem.Location = new System.Drawing.Point(634, 308);
            this.button_timkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(112, 66);
            this.button_timkiem.TabIndex = 81;
            this.button_timkiem.UseVisualStyleBackColor = false;
            this.button_timkiem.Click += new System.EventHandler(this.button_timkiem_Click);
            // 
            // pictureBox_bh
            // 
            this.pictureBox_bh.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_bh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_bh.Image = global::UI.Properties.Resources.coollogo_com_877914721;
            this.pictureBox_bh.Location = new System.Drawing.Point(1432, 18);
            this.pictureBox_bh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_bh.Name = "pictureBox_bh";
            this.pictureBox_bh.Size = new System.Drawing.Size(582, 270);
            this.pictureBox_bh.TabIndex = 84;
            this.pictureBox_bh.TabStop = false;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.gray;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.pictureBox_bh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_timkiem);
            this.Controls.Add(this.button_timkiem);
            this.Controls.Add(this.button_kh_tc);
            this.Controls.Add(this.label_kh_dc);
            this.Controls.Add(this.label_kh_sdt);
            this.Controls.Add(this.label_kh_tenkh);
            this.Controls.Add(this.label_kh_makh);
            this.Controls.Add(this.textBox_kh_dc);
            this.Controls.Add(this.textBox_kh_sdt);
            this.Controls.Add(this.textBox_kh_tenkh);
            this.Controls.Add(this.textBox_kh_makh);
            this.Controls.Add(this.button_kh_huybo);
            this.Controls.Add(this.button_kh_xoa);
            this.Controls.Add(this.button_kh_sua);
            this.Controls.Add(this.button_kh_luu);
            this.Controls.Add(this.button_kh_them);
            this.Controls.Add(this.dataGridView_kh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHÁCH HÀNG";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.Click += new System.EventHandler(this.button_kh_thoat_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_kh;
        private System.Windows.Forms.Button button_kh_them;
        private System.Windows.Forms.Button button_kh_luu;
        private System.Windows.Forms.Button button_kh_sua;
        private System.Windows.Forms.Button button_kh_xoa;
        private System.Windows.Forms.Button button_kh_huybo;
        private System.Windows.Forms.TextBox textBox_kh_makh;
        private System.Windows.Forms.TextBox textBox_kh_tenkh;
        private System.Windows.Forms.TextBox textBox_kh_sdt;
        private System.Windows.Forms.TextBox textBox_kh_dc;
        private System.Windows.Forms.Label label_kh_makh;
        private System.Windows.Forms.Label label_kh_tenkh;
        private System.Windows.Forms.Label label_kh_sdt;
        private System.Windows.Forms.Label label_kh_dc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_kh_tc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_timkiem;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.PictureBox pictureBox_bh;
    }
}