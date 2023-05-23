using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class KetnoiDB
    {
        public static SqlConnection ConnectDB;
        // MỞ KẾT NỐI TỚI SQL SERVER
        public void OpenConnect()
                {
                        if(KetnoiDB.ConnectDB == null)
                            KetnoiDB.ConnectDB = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\HOAN THANH\CHUONG TRINH PHAN MEM\Data_Access_Layer\QuanLyCuaHangBanLe.mdf;Integrated Security=True");
                        if (KetnoiDB.ConnectDB.State != ConnectionState.Open)
                            KetnoiDB.ConnectDB.Open();
                }
        // ĐÓNG KẾT NỐI TỚI SQL SERVER
        public void CloseConnect()
                {
                    if (KetnoiDB.ConnectDB != null)
                        KetnoiDB.ConnectDB.Close();
                }
        // LẤY BẢNG DỮ LIỆU
        public DataTable GetDataTable(string strSQL)
        {
            try
            {
                OpenConnect();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, ConnectDB);
                sqlda.Fill(dt);
                CloseConnect();
                return dt;
            }
            catch
            {
                return null;
            }
        }
        // TRUY VẤN DỮ LIỆU
        public void ExecuteReader(string strSQL)
        {
            try
            {
                OpenConnect();
                SqlCommand sqlcmd = new SqlCommand(strSQL,ConnectDB);
                sqlcmd.ExecuteNonQuery();
                CloseConnect();
            }
            catch
            {

            }
        }
        // LẤY GIÁ TRỊ DỮ LIỆU
        public string GetValue(string strSQL)
        {
            string temp = null;
            OpenConnect();
            SqlCommand sqlcmd = new SqlCommand(strSQL, ConnectDB);
            SqlDataReader   sqldr = sqlcmd.ExecuteReader();
            while(sqldr.Read())
                    temp = sqldr[0].ToString();
            CloseConnect();
            return temp;
        }
    }
}