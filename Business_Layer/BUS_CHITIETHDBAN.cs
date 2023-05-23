using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data_Access_Layer;
using Model;

namespace Business_Layer
{
    public class BUS_CHITIETHDBAN
    {
        SQL_CHITIETHDBAN bus = new SQL_CHITIETHDBAN();
        // THÊM DỮ LIỆU
        public void AddData(CHI_TIET_HDBAN ex)
        {
            bus.AddData(ex);
        }
        //  SỬA DỮ LIỆU
        public void EditData(CHI_TIET_HDBAN ex)
        {
            bus.EditData(ex);
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(CHI_TIET_HDBAN ex)
        {
            bus.DeleteData(ex);
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }
        public DataTable GetData_HD(string Condition)
        {
            return bus.GetData_HD(Condition);
        }
        public DataTable GetData_SP(string Condition)
        {
            return bus.GetData_SP(Condition);
        }
         public DataTable HDBH(string Condition)
        {
            return bus.HDBH(Condition);
        }
         public DataTable TongDTBan(string Condition)
         {
             return bus.TongDTBan(Condition);
         }
         public DataTable DTTheoNgay(string Condition)
         {
             return bus.DTTheoNgay(Condition);
         }
        public DataTable DTHangNgay(string Condition,string Condition1)
         {
             return bus.DTHangNgay(Condition, Condition1);
         }
    }
}
