using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banmypham
{
   public class datadangnhap
    {
        private static datadangnhap instance;

        public static datadangnhap Instance
        {
            get { if (instance == null) instance = new datadangnhap(); return datadangnhap.instance; }
            private set { datadangnhap.instance = value; }
        }
        private datadangnhap()
        {

        }

        public static string connStr = @"Data Source=LAPTOP-QF4UJQ33\SQLEXPRESS;Initial Catalog=QL_MYPHAM;Integrated Security=True"; 
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            com.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                conn.Close();
            }
            return dt;

        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int dt = 0;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            com.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                dt = com.ExecuteNonQuery();
                conn.Close();
            }
            return dt;
        }
    }
}


