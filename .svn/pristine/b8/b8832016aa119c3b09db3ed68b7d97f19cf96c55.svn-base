using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace Data_Access_Layer
{
    public class SQL_NHACUNGCAP
    {
        KetnoiDB cn = new KetnoiDB();
        // THÊM DỮ LIỆU
        public void AddData(NHA_CUNG_CAP ex)
        {
            cn.ExecuteReader(@"INSERT INTO NHA_CUNG_CAP(MaNCC, TenNCC, DiaChiNCC, SDTNCC) VALUES(N'" + ex.MaNCC + "',N'" + ex.TenNCC + "',N'" + ex.DiaChiNCC + "',N'" + ex.SDTNCC + "')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(NHA_CUNG_CAP ex)
        {
            cn.ExecuteReader(@"UPDATE NHA_CUNG_CAP SET TenNCC =N'" + ex.TenNCC + "', DiaChiNCC =N'" + ex.DiaChiNCC + "', SDTNCC =N'" + ex.SDTNCC + "' Where MaNCC=N'" + ex.MaNCC + "'");
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(NHA_CUNG_CAP ex)
        {
            cn.ExecuteReader(@"DELETE FROM NHA_CUNG_CAP Where MaNCC=N'" + ex.MaNCC + "'");
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return cn.GetDataTable("Select * from NHA_CUNG_CAP" + Condition);
        }
        public DataTable GetMaNCC()
        {
            return cn.GetDataTable("SELECT TOP (1) RIGHT(MaNCC,4) AS MaNCC FROM NHA_CUNG_CAP ORDER BY MaNCC DESC ");
        }
        public DataTable SearchNCC(string Condition)
        {
            return cn.GetDataTable("SELECT MaNCC, TenNCC, SDTNCC, DiaChiNCC FROM NHA_CUNG_CAP Where TenNCC =N" + Condition);
        }

    }
}
