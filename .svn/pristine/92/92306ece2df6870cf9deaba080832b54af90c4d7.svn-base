using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
namespace Data_Access_Layer
{
    public class SQL_CHITIETHDBAN
    {
        KetnoiDB cn = new KetnoiDB();
    // THÊM DỮ LIỆU
        public void AddData(CHI_TIET_HDBAN ex)
        {
            cn.ExecuteReader(@"INSERT INTO CHI_TIET_HDBAN (MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan) VALUES (N'" + ex.MaHD + "',N'" + ex.MaSP + "',N'" + ex.SLBan + "',N'" + ex.DonGiaBan + "',N'" + ex.ThanhTienBan + "')");
        }
    //  SỬA DỮ LIỆU
        public void EditData(CHI_TIET_HDBAN ex)
        {
            cn.ExecuteReader(@"UPDATE CHI_TIET_HDBAN SET SLBan =N'" + ex.SLBan + "', DonGiaBan =N'" + ex.DonGiaBan + "', ThanhTienBan =N'" + ex.ThanhTienBan + "' Where MaHD=N'" + ex.MaHD + "'");
        }
    //  XÓA DỮ LIỆU
        public void DeleteData(CHI_TIET_HDBAN ex)
        {
            cn.ExecuteReader(@"DELETE FROM CHI_TIET_HDBAN Where MaHD=N'" + ex.MaHD + "'");
        }
    //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return cn.GetDataTable("Select * from CHI_TIET_HDBAN " + Condition);
        }
        public DataTable GetData_HD(string Condition)
        {
            return cn.GetDataTable("SELECT MaHD FROM HOA_DON_BAN " + Condition);
        }
        public DataTable GetData_SP(string Condition)
        {
            return cn.GetDataTable("Select MaSP,TenSP from SAN_PHAM " + Condition);
        }
        public DataTable HDBH(string Condition)
        {
            return cn.GetDataTable("SELECT SUM(CHI_TIET_HDBAN.ThanhTienBan) AS ThanhTienBan FROM CHI_TIET_HDBAN INNER JOIN HOA_DON_BAN ON CHI_TIET_HDBAN.MaHD = HOA_DON_BAN.MaHD  Where MONTH(CONVERT(Datetime, HOA_DON_BAN.NgayBan,3)) = " + Condition);
        }
        public DataTable TongDTBan(string Condition)
        {
            return cn.GetDataTable("SELECT SUM(CHI_TIET_HDBAN.SLBan) AS SoLuongBan, SUM(CHI_TIET_HDBAN.ThanhTienBan) AS TongTienBan FROM SAN_PHAM INNER JOIN CHI_TIET_HDBAN ON SAN_PHAM.MaSP = CHI_TIET_HDBAN.MaSP WHERE TenSP = " + Condition);
        }
        public DataTable DTTheoNgay(string Condition)
        {
            return cn.GetDataTable("SELECT SUM(CHI_TIET_HDBAN.SLBan), SUM(CHI_TIET_HDBAN.ThanhTienBan) FROM CHI_TIET_HDBAN INNER JOIN HOA_DON_BAN ON CHI_TIET_HDBAN.MaHD = HOA_DON_BAN.MaHD WHERE MONTH( NgayBan ) = " + Condition);
        }
        public DataTable DTHangNgay(string Condition,string Condition1)
        {
            return cn.GetDataTable("SELECT SUM(CHI_TIET_HDBAN.SLBan) AS SoLuongBan , SUM(CHI_TIET_HDBAN.ThanhTienBan) AS TongTienBan FROM CHI_TIET_HDBAN INNER JOIN HOA_DON_BAN ON CHI_TIET_HDBAN.MaHD = HOA_DON_BAN.MaHD INNER JOIN SAN_PHAM ON CHI_TIET_HDBAN.MaSP = SAN_PHAM.MaSP WHERE (CONVERT(DATE, HOA_DON_BAN.NgayBan) =" + Condition + ") AND (SAN_PHAM.TenSP = " + Condition1 + ")");
        }
    }
}
