using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace Data_Access_Layer
{
    public class SQL_NHANVIEN
    {
        KetnoiDB cn = new KetnoiDB();
        // THÊM DỮ LIỆU
        public void AddData(NHAN_VIEN ex)
        {
            cn.ExecuteReader(@"INSERT INTO NHAN_VIEN (MaNV, MaCV, TenNV, DiaChiNV, SDTNV, GioiTinh, NgaySinh) VALUES (N'" + ex.MaNV + "',N'" + ex.MaCV + "',N'" + ex.TenNV + "',N'" + ex.DiaChiNV + "',N'" + ex.SDTNV + "',N'" + ex.GioiTinh + "',N'" + ex.NgaySinh + "')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(NHAN_VIEN ex)
        {
            cn.ExecuteReader(@"UPDATE NHAN_VIEN SET TenNV =N'" + ex.TenNV + "', DiaChiNV =N'" + ex.DiaChiNV + "', SDTNV =N'" + ex.SDTNV + "', GioiTinh =N'" + ex.GioiTinh + "', NgaySinh =N'" + ex.NgaySinh + "'  Where MaNV = N'" + ex.MaNV + "'");
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(NHAN_VIEN ex)
        {
            cn.ExecuteReader(@"DELETE FROM NHAN_VIEN Where MaNV=N'" + ex.MaNV + "'");
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return cn.GetDataTable("Select * from NHAN_VIEN " + Condition);
        }
        public DataTable Select(string Condition)
        {
            return cn.GetDataTable("Select MaNV,TenNV from NHAN_VIEN" + Condition);
        }
        public DataTable GetMaNV()
        {
            return cn.GetDataTable("SELECT TOP (1) RIGHT(MaNV,4) AS MaNV FROM NHAN_VIEN ORDER BY MaNV DESC ");
        }
        public DataTable SearchNV(string Condition)
        {
            return cn.GetDataTable("SELECT MaNV, MaCV, TenNV, DiaChiNV, SDTNV, GioiTinh, NgaySinh FROM NHAN_VIEN Where TenNV = " + Condition);
        }
    }
}
