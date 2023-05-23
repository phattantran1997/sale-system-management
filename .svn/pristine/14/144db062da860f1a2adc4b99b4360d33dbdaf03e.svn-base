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
    public class BUS_CHITIETPN
    {
        SQL_CHITIETPN bus = new SQL_CHITIETPN();
        public void AddData(CHI_TIET_PN ex)
        {
            bus.AddData(ex);
        }
        //  SỬA DỮ LIỆU
        public void EditData(CHI_TIET_PN ex)
        {
            bus.EditData(ex);
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(CHI_TIET_PN ex)
        {
            bus.DeleteData(ex);
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }
        public DataTable GetData_PN(string Condition)
        {
            return bus.GetData_PN(Condition);
        }
        public DataTable GetData_SP(string Condition)
        {
            return bus.GetData_SP(Condition);
        }
        public DataTable HDBH(string Condition)
        {
            return bus.HDBH(Condition);
        }
        public DataTable TongDTNhap(string Condition)
        {
            return bus.TongDTNhap(Condition);
        }
        public DataTable DTTheoNgay(string Condition)
        {
            return bus.DTTheoNgay(Condition);
        }
        public DataTable DTHangNgay(string Condition, string Condition1)
        {
            return bus.DTHangNgay(Condition, Condition1);
        }
    }
}
