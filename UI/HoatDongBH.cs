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
using Data_Access_Layer;
using Business_Layer;

namespace UI
{
    public partial class HoatDongBanHang : Form
    {
        public HoatDongBanHang()
        {
            InitializeComponent();
        }
        bool changeUI;
        int a = 0;
        BUS_HOADONBAN hdb = new BUS_HOADONBAN();
        BUS_PHIEUNHAP pn = new BUS_PHIEUNHAP();
        BUS_SANPHAM sp1 = new BUS_SANPHAM();
        DataTable sp = new DataTable();
        private void HoatDongBanHang_Load_1(object sender, EventArgs e)
        {
            reportViewer_bh.Hide();
            reportViewer_nh.Hide();
        }

        private void button_hdbh_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchinh tc = new Trangchinh();
            tc.ShowDialog();
        }

        private void button_hdbh_lochd_Click(object sender, EventArgs e)
        {
            try
            {
                if (changeUI == true)
                {
                    if (a == 1)
                    {
                        this.CHI_TIET_PNTableAdapter.SP(this.BH.CHI_TIET_PN, comboBox_tim_masp.Text);
                        this.reportViewer_nh.RefreshReport();
                    }
                    if (a == 2)
                    {
                        this.CHI_TIET_PNTableAdapter.HD(this.BH.CHI_TIET_PN, comboBox_tim_mahd.Text);
                        this.reportViewer_nh.RefreshReport();
                    }
                    if (a == 3)
                    {
                        this.CHI_TIET_PNTableAdapter.Ngay(this.BH.CHI_TIET_PN, dateTimePicker_hdbh_dt.Value.Date.ToString("yyyy/MM/dd"));
                        this.reportViewer_nh.RefreshReport();
                    }
                }
                else
                {
                    if (a == 1)
                    {
                        this.CHI_TIET_HDBANTableAdapter.Fill(this.BH.CHI_TIET_HDBAN, comboBox_tim_masp.Text);
                        this.reportViewer_bh.RefreshReport();
                    }
                    if (a == 2)
                    {
                        this.CHI_TIET_HDBANTableAdapter.FillBy(this.BH.CHI_TIET_HDBAN, comboBox_tim_mahd.Text);
                        this.reportViewer_bh.RefreshReport();
                    }
                    if (a == 3)
                    {
                        this.CHI_TIET_HDBANTableAdapter.FillBy1(this.BH.CHI_TIET_HDBAN, dateTimePicker_hdbh_dt.Value.Date.ToString("yyyy/MM/dd"));
                        this.reportViewer_bh.RefreshReport();
                    }
                }
                a = 0;
                comboBox_tim_mahd.Text = "";
                comboBox_tim_masp.Text = "";
                label_sp.Enabled = true;
                label_dt.Enabled = true;
                label_hdbh_timma.Enabled = true;
                comboBox_tim_mahd.Enabled = true;
                comboBox_tim_masp.Enabled = true;
                dateTimePicker_hdbh_dt.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu hệ thống !");
                return;
            }
        }

        private void reportViewer_nh_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_bh_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox_tim_mahd.DataSource = null;
                comboBox_tim_mahd.Items.Clear();
                //------
                sp = sp1.GetData("");
                comboBox_tim_masp.DataSource = sp;
                comboBox_tim_masp.ValueMember = "MaSP";
                //-----
                sp = hdb.GetData("");
                comboBox_tim_mahd.DataSource = sp;
                comboBox_tim_mahd.ValueMember = "MaHD";
                //-----
                reportViewer_bh.Show();
                reportViewer_nh.Hide();
                this.CHI_TIET_HDBANTableAdapter.FillBy2(this.BH.CHI_TIET_HDBAN);
                this.reportViewer_bh.RefreshReport();
                comboBox_tim_mahd.Text = "";
                comboBox_tim_masp.Text = "";
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu hệ thống !");
                return;
            }
        }

        private void radioButton_nh_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox_tim_mahd.DataSource = null;
                comboBox_tim_mahd.Items.Clear();
                //----
                sp = sp1.GetData("");
                comboBox_tim_masp.DataSource = sp;
                comboBox_tim_masp.ValueMember = "MaSP";
                //----
                sp = pn.GetData("");
                comboBox_tim_mahd.DataSource = sp;
                comboBox_tim_mahd.ValueMember = "MaPN";
                //-----
                changeUI = true;
                reportViewer_nh.Show();
                reportViewer_bh.Hide();
                this.CHI_TIET_PNTableAdapter.Fill(this.BH.CHI_TIET_PN);
                this.reportViewer_nh.RefreshReport();
                comboBox_tim_mahd.Text = "";
                comboBox_tim_masp.Text = "";
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu hệ thống !");
                return;
            }
        }

        private void dateTimePicker_hdbh_dt_ValueChanged(object sender, EventArgs e)
        {
            a = 3;
            label_hdbh_timma.Enabled = false;
            label_sp.Enabled = false;
            comboBox_tim_mahd.Enabled = false;
            comboBox_tim_masp.Enabled = false;
        }

        private void comboBox_tim_mahd_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = 2;
            label_dt.Enabled = false;
            label_sp.Enabled = false;
            comboBox_tim_masp.Enabled = false;
            dateTimePicker_hdbh_dt.Enabled = false;
        }
        private void comboBox_tim_masp_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = 1;
            label_hdbh_timma.Enabled = false;
            label_dt.Enabled = false;
            comboBox_tim_mahd.Enabled = false;
            dateTimePicker_hdbh_dt.Enabled = false;
        }
    }
}
