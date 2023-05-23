using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace Data_Access_Layer
{
    public class SQL_SANPHAM
    {
        KetnoiDB cn = new KetnoiDB();
        // THÊM DỮ LIỆU
        public void AddData(SAN_PHAM ex)
        {
            cn.ExecuteReader(@"INSERT INTO SAN_PHAM (MaSP, MaNhom, TenSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC) VALUES (N'" + ex.MaSP + "',N'" + ex.MaNhom + "',N'" + ex.TenSP + "',N'" + ex.DonViTinh + "',N'" + ex.SLTon + "',N'" + ex.GiaBan + "',N'" + ex.GiaNhap + "',N'" + ex.MaNCC + "')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(SAN_PHAM ex)
        {
            cn.ExecuteReader(@"UPDATE SAN_PHAM  SET  MaNhom =N'" + ex.MaNhom + "', TenSP =N'" + ex.TenSP + "', DonViTinh =N'" + ex.DonViTinh + "', SLTon =N'" + ex.SLTon + "', GiaBan =N'" + ex.GiaBan + "', GiaNhap =N'" + ex.GiaNhap + "', MaNCC=N'" + ex.MaNCC + "' Where MaSP=N'" + ex.MaSP + "'");
        }
        public void EditSL(SAN_PHAM ex)
        {
            cn.ExecuteReader(@"UPDATE SAN_PHAM SET SLTon = N'" + ex.SLTon + "' Where MaSP = '" + ex.MaSP + "'");
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(SAN_PHAM ex)
        {
            cn.ExecuteReader(@"DELETE FROM SAN_PHAM Where MaSP =N'" + ex.MaSP + "'");
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return cn.GetDataTable("Select * from SAN_PHAM " + Condition);
        }
        public DataTable GetSL(string Condition)
        {
            return cn.GetDataTable(@"SELECT SLTon FROM SAN_PHAM Where MaSP = '" + Condition + "'");
        }
        public DataTable Show(string Condition)
        {
            return cn.GetDataTable("SELECT SAN_PHAM.MaSP, SAN_PHAM.TenSP, SAN_PHAM.DonViTinh, CHI_TIET_HDBAN.SLTon, CHI_TIET_HDBAN.DonGiaBan, CHI_TIET_HDBAN.ThanhTienBan FROM SAN_PHAM INNER JOIN CHI_TIET_HDBAN ON SAN_PHAM.MaSP = CHI_TIET_HDBAN.MaSP INNER JOIN HOA_DON_BAN ON CHI_TIET_HDBAN.MaHD = HOA_DON_BAN.MaHD" + Condition);
        }
        public DataTable GetMaSP(string Condition)
        {
            return cn.GetDataTable("SELECT MaSP, TenSP, DonViTinh, GiaBan FROM SAN_PHAM" + Condition);
        }
        public DataTable GetMaKH(string Condition)
        {
            return cn.GetDataTable("SELECT MaKH,TenKH,DiemTichLuy FROM KHACH_HANG " + Condition);
        }
        public DataTable GetAUTOMaSP()
        {
            return cn.GetDataTable("SELECT TOP(1) RIGHT(MaSP,6) FROM SAN_PHAM ORDER BY MaSP DESC ");
        }
    }
}
