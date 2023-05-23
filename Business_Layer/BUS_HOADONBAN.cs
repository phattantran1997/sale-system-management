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
    public class BUS_HOADONBAN
    {
        SQL_HOADONBAN bus = new SQL_HOADONBAN();
        public void AddData(HOA_DON_BAN ex)
        {
            bus.AddData(ex);
        }
        //  SỬA DỮ LIỆU
        public void EditData(HOA_DON_BAN ex)
        {
            bus.EditData(ex);
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(HOA_DON_BAN ex)
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
    }
}
