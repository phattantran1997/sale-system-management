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
    public class BUS_PHIEUNHAP
    {
        SQL_PHIEUNHAP bus = new SQL_PHIEUNHAP();
        public void AddData(PHIEU_NHAP ex)
        {
            bus.AddData(ex);
        }
        //  SỬA DỮ LIỆU
        public void EditData(PHIEU_NHAP ex)
        {
            bus.EditData(ex);
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(PHIEU_NHAP ex)
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
