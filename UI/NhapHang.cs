using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Access_Layer;
using Model;
using Business_Layer;

namespace UI
{
    public partial class NhapHang : Form
    {
        public NhapHang()
        {
            InitializeComponent();
        }
        /// KHỞI TẠO CÁC THÔNG SỐ 
        BUS_CHITIETPN ctpn = new BUS_CHITIETPN();
        BUS_PHIEUNHAP pn = new BUS_PHIEUNHAP();
        BUS_NHANVIEN nv = new BUS_NHANVIEN();
        BUS_SANPHAM sp = new BUS_SANPHAM();
        BUS_NHACUNGCAP ncc = new BUS_NHACUNGCAP();
        BUS_NHOMSANPHAM nsp = new BUS_NHOMSANPHAM();
        NHA_CUNG_CAP ncc1 = new NHA_CUNG_CAP();
        SAN_PHAM sp1 = new SAN_PHAM();
        NHAN_VIEN nv1 = new NHAN_VIEN();
        CHI_TIET_PN ctpn1 = new CHI_TIET_PN();
        PHIEU_NHAP pn1 = new PHIEU_NHAP();
        DataTable sp2 = new DataTable();
        DataTable sp3 = new DataTable();
        DataTable load = new DataTable();
        Int64 tongcong;
        Int64 thanhtien;
        bool addnew;
        bool exit;
        bool fail = false;
        /// ----------------------------------------------------------
        void Open()
        {
            comboBox_nh_tenhang.Enabled = true;
            comboBox_nh_manhom.Enabled = true;
            comboBox_nh_tennhom.Enabled = true;
            comboBox_nh_dvt.Enabled = true;
            textBox_nh_sl.Text = "1";
            textBox_nh_sl.Enabled = true;
            comboBox_nh_dgn.Enabled = true;
        }
        void CloseCB()
        {
            comboBox_nh_mh.Enabled = false;
            comboBox_nh_tenhang.Enabled = false;
            comboBox_nh_manhom.Enabled = false;
            comboBox_nh_tennhom.Enabled = false;
            comboBox_nh_dvt.Enabled = false;
            textBox_nh_sl.Text = "0";
            textBox_nh_sl.Enabled = false;
            comboBox_nh_dgn.Enabled = false;
        }
        void testButton()
        {
            if (dataGridView_nh.Rows[0].Cells[0].Value == null)
            {
                button_nh_them.Enabled = true;
                button_nh_save.Enabled = false;
                button_nh_sua.Enabled = false;
                button_nh_xoa.Enabled = false;
            }
            else
            {
                button_nh_them.Enabled = true;
                button_nh_save.Enabled = false;
                button_nh_sua.Enabled = true;
                button_nh_xoa.Enabled = true;
            }
        }
        void SetNull()
        {
            comboBox_nh_mancc.Text = "";
            comboBox_nh_tenhang.Text = "";
            comboBox_nh_tennhom.Text = "";
            comboBox_nh_mh.Text = "";
            comboBox_nh_dvt.Text = "";
            textBox_nh_sl.Text = "";
            comboBox_nh_dgn.Text = "";
        }
        void AuToMaSP()
        {
            // MÃ SẢN PHẨM TỰ SINH
            sp2 = sp.GetAUTOMaSP();
            if (sp2 == null || sp2.Rows.Count == 0)
            {
                comboBox_nh_mh.Text = "SP000001";
            }
            else
            {
                int tam1 = int.Parse(sp2.Rows[0][0].ToString());
                if (tam1 < 10)
                {
                    tam1 = tam1 + 1;
                    comboBox_nh_mh.Text = "SP00000" + Convert.ToString(tam1);
                }
                else
                    if (tam1 < 100)
                    {
                        tam1 = tam1 + 1;
                        comboBox_nh_mh.Text = "SP0000" + Convert.ToString(tam1);
                    }
                    else
                        if (tam1 < 1000)
                        {
                            tam1 = tam1 + 1;
                            comboBox_nh_mh.Text = "SP000" + Convert.ToString(tam1);
                        }
                        else
                            if (tam1 < 10000)
                            {
                                tam1 = tam1 + 1;
                                comboBox_nh_mh.Text = "SP00" + Convert.ToString(tam1);
                            }
                            else
                                if (tam1 < 100000)
                                {
                                    tam1 = tam1 + 1;
                                    comboBox_nh_mh.Text = "SP0" + Convert.ToString(tam1);
                                }
                                else
                                    if (tam1 < 1000000)
                                    {
                                        tam1 = tam1 + 1;
                                        comboBox_nh_mh.Text = "SP" + Convert.ToString(tam1);
                                    }
            }
            //----------------------------------------------------------------------------------------
        }
        private void button_nh_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchinh tc = new Trangchinh();
            tc.ShowDialog();
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            comboBox_nh_mh.Enabled = false;
            exit = false;
            // MÃ HÓA ĐƠN TỰ SINH
            sp2 = pn.GetData_HD("");
            if (sp2 == null || sp2.Rows.Count == 0)
            {
                comboBox_nh_mahd.Text = "HDN000001";
            }
            else
            {
                int tam1 = int.Parse(sp2.Rows[0][0].ToString());
                    if (tam1 < 10)
                    {
                        tam1 = tam1 + 1;
                        comboBox_nh_mahd.Text = "HDN00000" + Convert.ToString(tam1);
                    }
                    else
                        if (tam1 < 100)
                        {
                            tam1 = tam1 + 1;
                            comboBox_nh_mahd.Text = "HDN0000" + Convert.ToString(tam1);
                        }
                        else
                            if (tam1 < 1000)
                            {
                                tam1 = tam1 + 1;
                                comboBox_nh_mahd.Text = "HDN000" + Convert.ToString(tam1);
                            }
                            else
                                if (tam1 < 10000)
                                {
                                    tam1 = tam1 + 1;
                                    comboBox_nh_mahd.Text = "HDN00" + Convert.ToString(tam1);
                                }
                                else
                                    if (tam1 < 100000)
                                    {
                                        tam1 = tam1 + 1;
                                        comboBox_nh_mahd.Text = "HDN0" + Convert.ToString(tam1);
                                    }
                                    else
                                        if (tam1 < 1000000)
                                        {
                                            tam1 = tam1 + 1;
                                            comboBox_nh_mahd.Text = "HDN" + Convert.ToString(tam1);
                                        }
            }
            //----------------------------------------------------------------------------------------
            // NHÀ CUNG CẤP
            sp2 = ncc.GetData("");
            comboBox_nh_mancc.DataSource = sp2;
            comboBox_nh_mancc.ValueMember = "MaNCC";
            // NHÂN VIÊN
            sp2 = nv.Select("");
            comboBox_nh_manv.DataSource = sp2;
            comboBox_nh_tennv.DataSource = sp2;
            comboBox_nh_manv.ValueMember = "MaNV";
            comboBox_nh_tennv.ValueMember = "TenNV";
            // HÀNG HÓA
            sp2 = sp.GetData("");
            comboBox_nh_mh.DataSource = sp2;
            comboBox_nh_tenhang.DataSource = sp2;
            comboBox_nh_dvt.DataSource = sp2;
            comboBox_nh_dgn.DataSource = sp2;
            comboBox_nh_mh.ValueMember = "MaSP";
            comboBox_nh_tenhang.ValueMember = "TenSP";
            comboBox_nh_dvt.ValueMember = "DonviTinh";
            comboBox_nh_dgn.ValueMember = "GiaNhap";
            //----------------------------------------------------------------------------------------
            // TẠO TRƯỜNG HIỂN THỊ LÊN DATAGRIDVIEW
            sp3.Columns.Add("MaSP");
            sp3.Columns.Add("TenSP");
            sp3.Columns.Add("DonViTinh");
            sp3.Columns.Add("SoLuong");
            sp3.Columns.Add("GiaNhap");
            sp3.Columns.Add("ThanhTienNhap");
            sp3.Columns.Add("GiaBan");
            sp3.Columns.Add("MaNhom");
            sp3.Columns.Add("TenNhom");
            sp3.Columns.Add("MaNCC");
            addnew = false;
            //----------------------------------------------------------------------------------------
            CloseCB();
            exit = false;
            SetNull();
            //----------------------------------------------------------------------------------------
        }
        private void dataGridView_nh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                comboBox_nh_mh.Text = dataGridView_nh.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBox_nh_tenhang.Text = dataGridView_nh.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBox_nh_dgn.Text = dataGridView_nh.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox_nh_sl.Text = dataGridView_nh.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBox_nh_dvt.Text = dataGridView_nh.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBox_nh_tennhom.Text = dataGridView_nh.Rows[e.RowIndex].Cells[8].Value.ToString();
                comboBox_nh_mancc.Text = dataGridView_nh.Rows[e.RowIndex].Cells[9].Value.ToString();
                CloseCB();
            }
            catch
            {
            }
        }

        private void button_bh_thoat_Click(object sender, EventArgs e)
        {
            if (exit == false)
            {
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn chưa lưu hóa đơn nhập ! \n Bạn có muốn lưu ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
                if (thongbao == DialogResult.Yes)
                    MessageBox.Show("Vui lòng nhấn nút lưu !");
                else
                {
                    this.Hide();
                    Trangchinh tc = new Trangchinh();
                    tc.ShowDialog();
                }
            }
            else
            {
                this.Hide();
                Trangchinh tc = new Trangchinh();
                tc.ShowDialog();
            }
        }

        private void button_nh_luu_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Vui lòng xem kỹ hóa đơn trước khi lưu ! \n Bạn đã chắc chắn chưa ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
            {
                // LƯU VÀO KHO SẢN PHẨM
                try
                {
                    sp2 = sp.GetData("");
                    for (int i = 0; i < dataGridView_nh.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j <= sp2.Rows.Count - 1; j++)
                        {
                            if (dataGridView_nh.Rows[i].Cells[0].Value.ToString() == sp2.Rows[j][0].ToString())
                            {
                                DataTable luu = new DataTable();
                                luu = sp.GetSL(dataGridView_nh.Rows[i].Cells[0].Value.ToString());
                                sp1.MaSP = dataGridView_nh.Rows[i].Cells[0].Value.ToString();
                                sp1.MaNhom = dataGridView_nh.Rows[i].Cells[7].Value.ToString();
                                sp1.TenSP = dataGridView_nh.Rows[i].Cells[1].Value.ToString();
                                sp1.DonViTinh = dataGridView_nh.Rows[i].Cells[2].Value.ToString();
                                sp1.SLTon = int.Parse(luu.Rows[0][0].ToString()) + int.Parse(dataGridView_nh.Rows[i].Cells[3].Value.ToString());
                                sp1.GiaBan = int.Parse(dataGridView_nh.Rows[i].Cells[6].Value.ToString());
                                sp1.GiaNhap = int.Parse(dataGridView_nh.Rows[i].Cells[4].Value.ToString());
                                sp1.MaNCC = dataGridView_nh.Rows[i].Cells[9].Value.ToString();
                                sp.EditData(sp1);
                            }
                        }
                        sp1.MaSP = dataGridView_nh.Rows[i].Cells[0].Value.ToString();
                        sp1.MaNhom = dataGridView_nh.Rows[i].Cells[7].Value.ToString();
                        sp1.TenSP = dataGridView_nh.Rows[i].Cells[1].Value.ToString();
                        sp1.DonViTinh = dataGridView_nh.Rows[i].Cells[2].Value.ToString();
                        sp1.SLTon = int.Parse(dataGridView_nh.Rows[i].Cells[3].Value.ToString());
                        sp1.GiaBan = int.Parse(dataGridView_nh.Rows[i].Cells[6].Value.ToString());
                        sp1.GiaNhap = int.Parse(dataGridView_nh.Rows[i].Cells[4].Value.ToString());
                        sp1.MaNCC = dataGridView_nh.Rows[i].Cells[9].Value.ToString();
                        sp.AddData(sp1);
                    }
                }
                catch
                {
                    fail = true;
                }
                //--------------------------------------------------------------------------------------------------------------
                // LƯU VÀO HÓA ĐƠN
                pn1.MaPN = comboBox_nh_mahd.Text;
                pn1.MaNCC = comboBox_nh_mancc.Text;
                pn1.MaNV = comboBox_nh_manv.Text;
                pn1.NgayNhap = dateTimePicker_nh.Value;
                pn1.TongTienNhap = int.Parse(string.Format("{0}", tongcong));
                try
                {
                    pn.AddData(pn1);
                }
                catch
                {
                    MessageBox.Show("Không thể lưu được !");
                    fail = true;
                }
                //------------------------------------------------------------------------------
                // LƯU VÀO CHI TIẾT HÓA ĐƠN
                try
                {
                    for (int i = 0; i < dataGridView_nh.Rows.Count - 1; i++)
                    {
                        // LƯU VÀO CHI TIẾT HÓA ĐƠN NHẬP
                        ctpn1.MaPN = comboBox_nh_mahd.Text;
                        ctpn1.MaSP = dataGridView_nh.Rows[i].Cells[0].Value.ToString();
                        ctpn1.SLNhap = int.Parse(dataGridView_nh.Rows[i].Cells[3].Value.ToString());
                        ctpn1.DonGiaNhap = int.Parse(dataGridView_nh.Rows[i].Cells[4].Value.ToString());
                        ctpn1.ThanhTienNhap = Convert.ToInt32(dataGridView_nh.Rows[i].Cells[5].Value.ToString());
                        ctpn.AddData(ctpn1);
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể lưu được !");

                }
                //-----------------------------------------------------------------------------------------
                if (fail == true)
                {
                    MessageBox.Show("Không thể lưu hóa đơn !");
                    return;
                }
                else
                {
                    MessageBox.Show("Lưu hóa đơn thành công !");
                    button_nh_thanhtoan.Enabled = false;
                    comboBox_nh_tenhang.Enabled = false;
                    textBox_nh_sl.Enabled = false;
                    comboBox_nh_mh.Enabled = false;
                    comboBox_nh_tennv.Enabled = false;
                    comboBox_nh_mancc.Enabled = false;
                    comboBox_nh_manhom.Enabled = false;
                    comboBox_nh_dvt.Enabled = false;
                    comboBox_nh_tennv.Enabled = false;
                    comboBox_nh_dgn.Enabled = false;
                    textBox_nh_tongcong.Enabled = false;
                    button_nh_xoa.Enabled = false;
                    button_nh_them.Enabled = false;
                    button_nh_sua.Enabled = false;
                    dataGridView_nh.Enabled = false;
                }
            }
            else
                return;
            //---------------
            exit = true;
            // IN HOA DON 
            HDNhap inhd = new HDNhap();
            inhd.FilterString = " [MaPN] = '" + comboBox_nh_mahd.Text + "'";
            inhd.CreateDocument();
            HOADONBAN inhdb = new HOADONBAN();
            inhdb.documentViewer1.DocumentSource = inhd;
            inhdb.ShowDialog();
        }

        private void button_bh_xoa_Click(object sender, EventArgs e)
        {
            if (comboBox_nh_mh.Text == "" || comboBox_nh_tenhang.Text == "" || textBox_nh_sl.Text == "" || comboBox_nh_dgn.Text == "" || comboBox_nh_dvt.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chọn bên dưới để xóa !", "Thông báo");
                return;
            }
            thanhtien = int.Parse(textBox_nh_sl.Text) * int.Parse(comboBox_nh_dgn.Text);
            sp3.Rows.RemoveAt(dataGridView_nh.CurrentRow.Index);
            tongcong = 0;
            for (int i = 0; i < dataGridView_nh.Rows.Count; i++)
            {
                tongcong = tongcong + Convert.ToInt64(dataGridView_nh.Rows[i].Cells[5].Value);
            }
            textBox_nh_tongcong.Text = String.Format("{0:0,0}", tongcong);
            testButton();
            CloseCB();
        }

        private void button_bh_nhap_Click(object sender, EventArgs e)
        {
            AuToMaSP();
            addnew = false;
            button_nh_save.Enabled = true;
            button_nh_them.Enabled = false;
            button_nh_sua.Enabled = false;
            button_nh_xoa.Enabled = false;
            Open();
            sp2 = nsp.GetData("");
            comboBox_nh_manhom.DataSource = sp2;
            comboBox_nh_tennhom.DataSource = sp2;
            comboBox_nh_pt.DataSource = sp2;
            comboBox_nh_manhom.ValueMember = "MaNhom";
            comboBox_nh_tennhom.ValueMember = "TenNhom";
            comboBox_nh_pt.ValueMember = "PTTang";
            comboBox_nh_dvt.Text = "";
            comboBox_nh_dgn.Text = "0";
            textBox_nh_sl.Text = "1";
            comboBox_nh_tenhang.Text = "";
            this.comboBox_nh_mh.Focus();
        }

        private void button_bh_suahang_Click(object sender, EventArgs e)
        {
            if (comboBox_nh_mh.Text == "" || comboBox_nh_tenhang.Text == "" || textBox_nh_sl.Text == "" || comboBox_nh_dgn.Text == "" || comboBox_nh_dvt.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chọn bên dưới để xóa !", "Thông báo");
                return;
            }
            addnew = true;
            textBox_nh_sl.Enabled = true;
            button_nh_save.Enabled = true;
            button_nh_them.Enabled = false;
            button_nh_sua.Enabled = false;
            button_nh_xoa.Enabled = false;
            Open();
            this.textBox_nh_sl.Focus();
        }

        private void dataGridView_nh_Click(object sender, EventArgs e)
        {
            CloseCB();
            testButton();
        }
        private void comboBox_nh_manhom_Click(object sender, EventArgs e)
        {
        }

        private void textBox_nh_sl_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_nh_sl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox_nh_dgb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_nh_save_Click(object sender, EventArgs e)
        {
            // NẾU LÀ NÚT SỬA THÌ XÓA DÒNG HIỆN TẠI ĐỂ THÊM DÒNG MỚI
            // HIỂN THỊ LÊN DATAGRIDVIEW
            if (comboBox_nh_tenhang.Text == "" )
            {
                MessageBox.Show("Xin mời nhập lại tên sản phẩm !");
                return;
            }
            //-----------------------------------------------------------
            if (comboBox_nh_mh.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại mã sản phẩm !");
                return;
            }
            //-----------------------------------------------------------
            if(comboBox_nh_mancc.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại nhà cung cấp !");
                return;
            }
            //-----------------------------------------------------------
            if (comboBox_nh_dgn.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại đơn giá nhập !");
                return;
            }
            //-----------------------------------------------------------
            if (comboBox_nh_dvt.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại đơn vị tính !");
                return;
            }
            //-----------------------------------------------------------
            if (textBox_nh_sl.Text == "" || int.Parse(textBox_nh_sl.Text) == 0)
            {
                MessageBox.Show("Xin mời nhập lại số lượng nhập !");
                return;
            }
            //-----------------------------------------------------------
            if (comboBox_nh_tennhom.Text == "" || comboBox_nh_manhom.Text =="" || comboBox_nh_pt.Text=="")
            {
                MessageBox.Show("Xin mời nhập lại nhóm loại sản phẩm !");
                return;
            }
            //-----------------------------------------------------------
            if (addnew == true)
            {
                sp3.Rows.RemoveAt(dataGridView_nh.CurrentRow.Index);
            }
            else
            {
                // SO SÁNH NẾU TRÙNG SẢN PHẨM THÌ CỘNG DỒN
                if (dataGridView_nh.Rows.Count >= 2)
                {
                    try
                    {
                        for (int i = 0; i <= dataGridView_nh.Rows.Count - 1; i++)
                        {
                            string chuoi1 = comboBox_nh_mh.Text;
                            string chuoi = dataGridView_nh.Rows[i].Cells[0].Value.ToString();
                            if (chuoi == chuoi1)
                            {
                                textBox_nh_sl.Text = Convert.ToString(int.Parse(textBox_nh_sl.Text) + int.Parse(dataGridView_nh.Rows[i].Cells[3].Value.ToString()));
                                dataGridView_nh.Rows.RemoveAt(i);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi thêm mới sản phẩm !");
                        fail = true;
                    }
                }
            }
            // HIỂN THỊ
            try
            {
                thanhtien = int.Parse(textBox_nh_sl.Text) * int.Parse(comboBox_nh_dgn.Text);
                sp3.Rows.Add(comboBox_nh_mh.Text, comboBox_nh_tenhang.Text, comboBox_nh_dvt.Text, textBox_nh_sl.Text, comboBox_nh_dgn.Text, thanhtien, int.Parse(comboBox_nh_dgn.Text)+(int.Parse(comboBox_nh_dgn.Text)*int.Parse(comboBox_nh_pt.Text)/100), comboBox_nh_manhom.Text, comboBox_nh_tennhom.Text,comboBox_nh_mancc.Text);
                dataGridView_nh.DataSource = sp3;
                // TÍNH TỔNG CỘNG
                tongcong = 0;
                for (int i = 0; i < dataGridView_nh.Rows.Count; i++)
                {
                    tongcong = tongcong + Convert.ToInt64(dataGridView_nh.Rows[i].Cells[5].Value);
                }
                textBox_nh_tongcong.Text = String.Format("{0:0,0}", tongcong);
                testButton();
                CloseCB();
            }
            catch
            {
                MessageBox.Show("Lỗi tính tiền sản phẩm !");
                fail = true;
            }
        }

        private void comboBox_nh_pt_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_nh_pt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridView_nh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label_bh_soluong_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_nh_tennhom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_nh_mh_DropDown(object sender, EventArgs e)
        {
        }

        private void comboBox_nh_dgn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void label_nh_manhom_Click(object sender, EventArgs e)
        {

        }
    }
}
