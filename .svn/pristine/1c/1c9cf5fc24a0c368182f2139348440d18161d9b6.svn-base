using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
    
namespace Data_Access_Layer
{
    public class SQL_HOADONBAN
    {
        KetnoiDB cn = new KetnoiDB();
        // THÊM DỮ LIỆU
        public void AddData(HOA_DON_BAN ex)
        {
            cn.ExecuteReader(@"INSERT INTO HOA_DON_BAN (MaHD, MaNV, MaKH, NgayBan, TongTienBan) VALUES (N'" + ex.MaHD + "',N'" + ex.MaNV + "',N'" + ex.MaKH + "',N'" + ex.NgayBan + "',N'" + ex.TongTienBan + "')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(HOA_DON_BAN ex)
        {
            cn.ExecuteReader(@"UPDATE HOA_DON_BAN SET  MaNV =N'" + ex.MaNV + "', MaKH =N'" + ex.MaKH + "', NgayBan =N'" + ex.NgayBan + "' Where MaHD=N'" + ex.MaHD + "'");
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(HOA_DON_BAN ex)
        {
            cn.ExecuteReader(@"DELETE FROM HOA_DON_BAN Where MaHD=N'" + ex.MaHD + "'");
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return cn.GetDataTable("Select * from HOA_DON_BAN " + Condition);
        }
        public DataTable GetData_HD(string Condition)
        {
            return cn.GetDataTable("SELECT TOP (1) RIGHT(MaHD,5) AS MaHD FROM HOA_DON_BAN ORDER BY MaHD DESC " + Condition);
        }
    }
}
