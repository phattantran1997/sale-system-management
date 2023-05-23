using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace Data_Access_Layer
{
    public class SQL_NHOMSANPHAM
    {
        KetnoiDB cn = new KetnoiDB();
        // THÊM DỮ LIỆU
        public void AddData(NHOM_SAN_PHAM ex)
        {
            cn.ExecuteReader(@"INSERT INTO NHOM_SAN_PHAM  (MaNhom, TenNhom, PTTang) VALUES (N'" + ex.MaNhom + "',N'" + ex.TenNhom + "',N'" + ex.PTTang + "')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(NHOM_SAN_PHAM ex)
        {
            cn.ExecuteReader(@"UPDATE NHOM_SAN_PHAM SET TenNhom =N'" + ex.TenNhom + "', PTTang=N'" + ex.PTTang + "' Where MaNhom=N'" + ex.MaNhom + "'");
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(NHOM_SAN_PHAM ex)
        {
            cn.ExecuteReader(@"DELETE FROM NHOM_SAN_PHAM Where MaNhom=N'" + ex.MaNhom + "'");
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return cn.GetDataTable("Select * from NHOM_SAN_PHAM" + Condition);
        }
    }
}
