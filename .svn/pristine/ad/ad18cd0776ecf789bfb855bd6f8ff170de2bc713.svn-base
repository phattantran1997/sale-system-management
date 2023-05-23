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
    public class BUS_SANPHAM
    {
        SQL_SANPHAM bus = new SQL_SANPHAM();
        public void AddData(SAN_PHAM ex)
        {
            bus.AddData(ex);
        }
        //  SỬA DỮ LIỆU
        public void EditData(SAN_PHAM ex)
        {
            bus.EditData(ex);
        }
        //  CẬP NHẬT SỐ LƯỢNG
        public void EditSL(SAN_PHAM ex)
        {
            bus.EditSL(ex);
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(SAN_PHAM ex)
        {
            bus.DeleteData(ex);
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }
        public DataTable GetSL(string Condition)
        {
            return bus.GetSL(Condition);
        }
        public DataTable Show(string Condition)
        {
            return bus.Show(Condition);
        }
        public DataTable GetMaSP(string Condition)
        {
            return bus.GetMaSP(Condition);
        }
        public DataTable GetMaKH(string Condition)
        {
            return bus.GetMaKH(Condition);
        }
        public DataTable GetAUTOMaSP()
        {
            return bus.GetAUTOMaSP();
        }
    }
}
