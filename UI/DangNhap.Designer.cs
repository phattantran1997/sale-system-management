namespace UI
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.button_thoatdangnhap = new System.Windows.Forms.Button();
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtidngdung = new System.Windows.Forms.TextBox();
            this.label_matkhau = new System.Windows.Forms.Label();
            this.label_tennguoidung = new System.Windows.Forms.Label();
            this.pictureBox_bh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bh)).BeginInit();
            this.SuspendLayout();
            // 
            // button_thoatdangnhap
            // 
            this.button_thoatdangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thoatdangnhap.Location = new System.Drawing.Point(456, 318);
            this.button_thoatdangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.button_thoatdangnhap.Name = "button_thoatdangnhap";
            this.button_thoatdangnhap.Size = new System.Drawing.Size(147, 55);
            this.button_thoatdangnhap.TabIndex = 12;
            this.button_thoatdangnhap.Text = "Thoát";
            this.button_thoatdangnhap.UseVisualStyleBackColor = true;
            this.button_thoatdangnhap.Click += new System.EventHandler(this.button_thoatdangnhap_Click);
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dangnhap.Location = new System.Drawing.Point(295, 318);
            this.button_dangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(132, 55);
            this.button_dangnhap.TabIndex = 11;
            this.button_dangnhap.Text = "Đăng nhập";
            this.button_dangnhap.UseVisualStyleBackColor = true;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.HideSelection = false;
            this.txtmatkhau.Location = new System.Drawing.Point(468, 247);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtmatkhau.MaxLength = 20;
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(137, 26);
            this.txtmatkhau.TabIndex = 10;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // txtidngdung
            // 
            this.txtidngdung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidngdung.Location = new System.Drawing.Point(468, 198);
            this.txtidngdung.Margin = new System.Windows.Forms.Padding(2);
            this.txtidngdung.MaxLength = 20;
            this.txtidngdung.Name = "txtidngdung";
            this.txtidngdung.Size = new System.Drawing.Size(137, 26);
            this.txtidngdung.TabIndex = 9;
            // 
            // label_matkhau
            // 
            this.label_matkhau.AutoSize = true;
            this.label_matkhau.BackColor = System.Drawing.Color.DimGray;
            this.label_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_matkhau.ForeColor = System.Drawing.Color.Black;
            this.label_matkhau.Location = new System.Drawing.Point(291, 247);
            this.label_matkhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_matkhau.Name = "label_matkhau";
            this.label_matkhau.Size = new System.Drawing.Size(94, 24);
            this.label_matkhau.TabIndex = 8;
            this.label_matkhau.Text = "Mật khẩu";
            // 
            // label_tennguoidung
            // 
            this.label_tennguoidung.AutoSize = true;
            this.label_tennguoidung.BackColor = System.Drawing.Color.DimGray;
            this.label_tennguoidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tennguoidung.Location = new System.Drawing.Point(291, 198);
            this.label_tennguoidung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_tennguoidung.Name = "label_tennguoidung";
            this.label_tennguoidung.Size = new System.Drawing.Size(160, 24);
            this.label_tennguoidung.TabIndex = 7;
            this.label_tennguoidung.Text = "Tên người dùng";
            // 
            // pictureBox_bh
            // 
            this.pictureBox_bh.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_bh.Image = global::UI.Properties.Resources.coollogo_com_10784956;
            this.pictureBox_bh.Location = new System.Drawing.Point(34, 45);
            this.pictureBox_bh.Name = "pictureBox_bh";
            this.pictureBox_bh.Size = new System.Drawing.Size(825, 99);
            this.pictureBox_bh.TabIndex = 29;
            this.pictureBox_bh.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.shopping_supermarket_1;
            this.ClientSize = new System.Drawing.Size(896, 463);
            this.Controls.Add(this.pictureBox_bh);
            this.Controls.Add(this.button_thoatdangnhap);
            this.Controls.Add(this.button_dangnhap);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txtidngdung);
            this.Controls.Add(this.label_matkhau);
            this.Controls.Add(this.label_tennguoidung);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DangNhap";
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.Form_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_thoatdangnhap;
        private System.Windows.Forms.Button button_dangnhap;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtidngdung;
        private System.Windows.Forms.Label label_matkhau;
        private System.Windows.Forms.Label label_tennguoidung;
        private System.Windows.Forms.PictureBox pictureBox_bh;
    }
}

