using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAO
{
    public class DataProvider
    {
        private string ConnectSql = "Data Source=ADMIN;Initial Catalog=QLBANHANG;Integrated Security=True";
        /*Singleton một khai báo sử dụng cho tất cả các class*/
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; } //khai báo private sử dụng trong nội bộ 
        }
        public DataTable ExcuteQuery(string proc,string query,object[] parameter = null) {
            DataTable dtb = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectSql))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(proc, conn);
                if (parameter != null) { 
                    string [] listPara = query.Split(',');
                    int i = 0;
                    foreach (string item in listPara) {
                        if (item.Contains('@')) {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtb);

                conn.Close();

            }
            return dtb;
        }
        public int ExecuteNonQuery(string proc, string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(ConnectSql))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(proc, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(',');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                cmd.CommandType = CommandType.StoredProcedure;
                data = cmd.ExecuteNonQuery();

                conn.Close();

            }
            return data;
        }
    }
}
