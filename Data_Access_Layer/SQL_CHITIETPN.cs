using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace Data_Access_Layer
{
    public class SQL_CHITIETPN
    {
        KetnoiDB cn = new KetnoiDB();
        // THÊM DỮ LIỆU
        public void AddData(CHI_TIET_PN ex)
        {
            cn.ExecuteReader(@"INSERT INTO CHI_TIET_PN (MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap) VALUES(N'" + ex.MaPN + "',N'" + ex.MaSP + "',N'" + ex.SLNhap + "',N'" + ex.DonGiaNhap + "',N'" + ex.ThanhTienNhap + "')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(CHI_TIET_PN ex)
        {
            cn.ExecuteReader(@"UPDATE CHI_TIET_PN SET SLNhap =N'" + ex.SLNhap + "', DonGiaNhap =N'" + ex.DonGiaNhap + "', ThanhTienNhap =N'" + ex.ThanhTienNhap + "' Where MaPN=N'" + ex.MaPN + "',MaSP=N'" + ex.MaSP + "'");
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(CHI_TIET_PN ex)
        {
            cn.ExecuteReader(@"DELETE FROM CHI_TIET_PN Where MaPN=N'" + ex.MaPN + "',MaSP=N'" + ex.MaSP + "'");
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return cn.GetDataTable("Select * from CHI_TIET_PN " + Condition);
        }
        public DataTable GetData_PN(string Condition)
        {
            return cn.GetDataTable("Select MaPN,MaNCC from PHIEU_NHAP " + Condition);
        }
        public DataTable GetData_SP(string Condition)
        {
            return cn.GetDataTable("Select MaSP,TenSP from SAN_PHAM " + Condition);
        }
        public DataTable HDBH(string Condition)
        {
            return cn.GetDataTable("SELECT SUM(CHI_TIET_PN.ThanhTienNhap) FROM CHI_TIET_PN INNER JOIN PHIEU_NHAP ON CHI_TIET_PN.MaPN = PHIEU_NHAP.MaPN Where MONTH(CONVERT(Datetime, PHIEU_NHAP.NgayNhap,3)) =  " + Condition);
        }
        public DataTable TongDTNhap(string Condition)
        {
            return cn.GetDataTable("SELECT SUM(CHI_TIET_PN.SLNhap) AS SoLuongNhap, SUM(CHI_TIET_PN.ThanhTienNhap) AS TongTienNhap FROM SAN_PHAM INNER JOIN CHI_TIET_PN ON SAN_PHAM.MaSP = CHI_TIET_PN.MaSP WHERE TenSP = " + Condition);
        }
        public DataTable DTTheoNgay(string Condition)
        {
            return cn.GetDataTable("SELECT SUM(CHI_TIET_PN.SLNhap), SUM(CHI_TIET_PN.ThanhTienNhap) FROM CHI_TIET_PN INNER JOIN PHIEU_NHAP ON CHI_TIET_PN.MaPN = PHIEU_NHAP.MaPN WHERE MONTH(NgayNhap) =  " + Condition);
        }
        public DataTable DTHangNgay(string Condition, string Condition1)
        {
            return cn.GetDataTable("SELECT SUM(CHI_TIET_PN.SLNhap) AS SoLuongNhap, SUM(CHI_TIET_PN.ThanhTienNhap) AS TongTienNhap FROM CHI_TIET_PN INNER JOIN PHIEU_NHAP ON CHI_TIET_PN.MaPN = PHIEU_NHAP.MaPN INNER JOIN SAN_PHAM ON CHI_TIET_PN.MaSP = SAN_PHAM.MaSP WHERE (CONVERT(DATE, PHIEU_NHAP.NgayNhap) = " + Condition + ") AND (SAN_PHAM.TenSP = " + Condition1 + ")");
        }

    }
}