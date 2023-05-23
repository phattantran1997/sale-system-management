using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace Data_Access_Layer
{
    public class SQL_KHACHHANG
    {
        KetnoiDB cn = new KetnoiDB();
        // THÊM DỮ LIỆU
        public void AddData(KHACH_HANG ex)
        {
            cn.ExecuteReader(@"INSERT INTO KHACH_HANG (MaKH, TenKH, DiaChiKH, SDTKH) VALUES (N'" + ex.MaKH + "',N'" + ex.TenKH + "', N'" + ex.DiaChiKH + "',N'" + ex.SDTKH + "')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(KHACH_HANG ex)
        {
            cn.ExecuteReader(@"UPDATE KHACH_HANG SET TenKH =N'" + ex.TenKH + "', DiaChiKH =N'" + ex.DiaChiKH + "', SDTKH =N'" + ex.SDTKH + "' Where MaKH=N'" + ex.MaKH + "'");
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(KHACH_HANG ex)
        {
            cn.ExecuteReader(@"DELETE FROM KHACH_HANG Where MaKH=N'" + ex.MaKH + "'");
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return cn.GetDataTable("Select * from KHACH_HANG " + Condition);
        }
        public DataTable GetMaKH()
        {
            return cn.GetDataTable("SELECT TOP (1) RIGHT(MaNCC,4) AS MaNCC FROM NHA_CUNG_CAP ORDER BY MaNCC DESC ");
        }
        public DataTable SearchKH(string Condition)
        {
            return cn.GetDataTable("SELECT MaKH, TenKH, DiaChiKH, SDTKH, DiemTichLuy FROM KHACH_HANG Where TenKH =N" + Condition);
        }
        public DataTable GetPoint(string Condition)
        {
            return cn.GetDataTable("SELECT DiemTichLuy FROM KHACH_HANG Where TenKH =N'" + Condition + "'");
        }
        public void AddPoint(KHACH_HANG ex)
        {
            cn.ExecuteReader("UPDATE KHACH_HANG SET  DiemTichLuy = N'" + ex.DiemTichLuy + "' Where MaKH=N'" + ex.MaKH + "'");
        }
    }
}
