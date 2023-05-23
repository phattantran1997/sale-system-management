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
    public class BUS_NHACUNGCAP
    {
        SQL_NHACUNGCAP bus = new SQL_NHACUNGCAP();
        public void AddData(NHA_CUNG_CAP ex)
        {
            bus.AddData(ex);
        }
        //  SỬA DỮ LIỆU
        public void EditData(NHA_CUNG_CAP ex)
        {
            bus.EditData(ex);
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(NHA_CUNG_CAP ex)
        {
            bus.DeleteData(ex);
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }
        public DataTable GetMaNCC()
        {
            return bus.GetMaNCC();
        }
        public DataTable SearchNCC(string Condition)
        {
            return bus.SearchNCC(Condition);
        }
    }
}
