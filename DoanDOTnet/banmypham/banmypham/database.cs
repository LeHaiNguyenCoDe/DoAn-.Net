using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace banmypham
{
    class database
    {
        SqlConnection sqlconn;
        SqlDataAdapter da;
        public database(string svrName, string dbName, bool intergratedMode, string usrName, string pwd) {
            string connStr;
            if (intergratedMode == true) {
            //Đăng nhập SQL Server s dụng Windows Authentication Mode.
            connStr = "server=" + svrName + "; database=" + dbName + "; Integrated Security = True";
            }
            else {
            //Đăng nhập SQL Server dụng SQL Server Authentication Mode.
            connStr = "server=" + svrName + "; uid=" + usrName + "; pwd=" + pwd + " ;database=" + dbName;
            }
            sqlconn = new SqlConnection(connStr);
                }
            public DataTable Execute(string strQuery) {
            da = new SqlDataAdapter(strQuery, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
                }
            public void ExecuteNonQuery(string strquery)
            {
            SqlCommand sqlcom = new SqlCommand(strquery, sqlconn);

            sqlconn.Open(); //M kết nối
            sqlcom.ExecuteNonQuery(); //Thực hiện câu lệnh truy vấn đã cung cấp trên
            sqlconn.Close(); //Đóng kết nối
            }
          
            public void Update(string strQuery, DataTable table) {
            da = new SqlDataAdapter(strQuery, sqlconn);
            SqlCommandBuilder sqlcb = new SqlCommandBuilder(da);
            da.Update(table);
            }
    }
}
