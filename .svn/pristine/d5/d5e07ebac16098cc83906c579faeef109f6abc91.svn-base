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
    public class BUS_NHANVIEN
    {
        SQL_NHANVIEN bus = new SQL_NHANVIEN();
        public void AddData(NHAN_VIEN ex)
        {
            bus.AddData(ex);
        }
        //  SỬA DỮ LIỆU
        public void EditData(NHAN_VIEN ex)
        {
            bus.EditData(ex);
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(NHAN_VIEN ex)
        {
            bus.DeleteData(ex);
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }
        public DataTable Select(string Condition)
        {
            return bus.Select(Condition);
        }
        public DataTable GetMaNV()
        {
            return bus.GetMaNV();
        }
        public DataTable SearchNV(string Condition)
        {
            return bus.SearchNV(Condition);
        }
    }
}
