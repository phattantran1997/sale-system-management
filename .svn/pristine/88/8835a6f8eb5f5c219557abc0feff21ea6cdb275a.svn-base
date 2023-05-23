using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace Data_Access_Layer
{
    public class SQL_CHUC_VU
    {
        KetnoiDB cn = new KetnoiDB();
        // THÊM DỮ LIỆU
        public void AddData(CHUC_VU ex)
        {
            cn.ExecuteReader(@"INSERT INTO CHUC_VU (MaCV, TenCV) VALUES(N'" + ex.MaCV + "',N;" + ex.TenCV + "')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(CHUC_VU ex)
        {
            cn.ExecuteReader(@"UPDATE CHUC_VU SET TenCV =N'" +ex.TenCV + "' Where MaCV=N'" + ex.MaCV + "'");
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(CHUC_VU ex)
        {
            cn.ExecuteReader(@"DELETE FROM CHUC_VU Where MaCV=N'" + ex.MaCV + "'");
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return cn.GetDataTable("Select * from CHUC_VU " + Condition);
        }
    }
}
