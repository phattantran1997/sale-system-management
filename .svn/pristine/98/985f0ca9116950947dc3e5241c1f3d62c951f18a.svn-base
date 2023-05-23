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
    public class BUS_KHACHHANG
    {
        SQL_KHACHHANG bus = new SQL_KHACHHANG();
        public void AddData(KHACH_HANG ex)
        {
            bus.AddData(ex);
        }
        //  SỬA DỮ LIỆU
        public void EditData(KHACH_HANG ex)
        {
            bus.EditData(ex);
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(KHACH_HANG ex)
        {
            bus.DeleteData(ex);
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }
        public DataTable SearchKH(string Condition)
        {
            return bus.SearchKH(Condition);
        }
        public DataTable GetMaKH()
        {
            return bus.GetMaKH();
        }
        public DataTable GetPoint(string Condition)
        {
            return bus.GetPoint(Condition);
        }
        public void AddPoint(KHACH_HANG ex)
        {
            bus.AddPoint(ex);
        }
    }
}
