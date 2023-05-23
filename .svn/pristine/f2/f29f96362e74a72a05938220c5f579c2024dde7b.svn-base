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
    public class BUS_NHOMSANPHAM
    {
        SQL_NHOMSANPHAM bus = new SQL_NHOMSANPHAM();
        public void AddData(NHOM_SAN_PHAM ex)
        {
            bus.AddData(ex);
        }
        //  SỬA DỮ LIỆU
        public void EditData(NHOM_SAN_PHAM ex)
        {
            bus.EditData(ex);
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(NHOM_SAN_PHAM ex)
        {
            bus.DeleteData(ex);
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }
    }
}
