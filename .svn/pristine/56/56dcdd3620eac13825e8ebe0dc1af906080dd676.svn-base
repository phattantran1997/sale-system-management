using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace Data_Access_Layer
{
    public class SQL_PHIEUNHAP
    {
        KetnoiDB cn = new KetnoiDB();
        // THÊM DỮ LIỆU
        public void AddData(PHIEU_NHAP ex)
        {
            cn.ExecuteReader(@"INSERT INTO PHIEU_NHAP (MaPN, MaNCC, MaNV, NgayNhap, TongTienNhap) VALUES (N'" + ex.MaPN + "',N'" + ex.MaNCC + "',N'" + ex.MaNV + "',N'" + ex.NgayNhap + "',N'" + ex.TongTienNhap + "')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(PHIEU_NHAP ex)
        {
            cn.ExecuteReader(@"UPDATE PHIEU_NHAP SET MaNCC =N'" + ex.MaNCC + "', NgayNhap =N'" + ex.NgayNhap + "', MaNV =N'" + ex.MaNV + "' Where MaPN =N'" + ex.MaPN + "'");
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(PHIEU_NHAP ex)
        {
            cn.ExecuteReader(@"DELETE FROM PHIEU_NHAP Where MaPN =N'" + ex.MaPN + "'");
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return cn.GetDataTable("Select * from PHIEU_NHAP " + Condition);
        }
        public DataTable GetData_HD(string Condition)
        {
            return cn.GetDataTable("SELECT TOP (1) RIGHT(MaPN,5) AS MaPN FROM PHIEU_NHAP ORDER BY MaPN DESC " + Condition);
        }
    }
}
