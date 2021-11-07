using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banmypham
{
    class nhasanxuart
    {
         database db;
        public nhasanxuart()
        {
            db = new database("LAPTOP-QF4UJQ33\\SQLEXPRESS","QL_MYPHAM",true,"chien","123");
        }
        public DataTable LaydanhsachNSX()
        {
            return db.Execute("select * from NHASANXUAT");
        }
        public void Themnhasx(string mansx, string diachi, string dienthoai)
        {
            string sql = "Insert into NHASANXUAT(MANSX, DIACHI, DIENTHOAI) VALUES('" + mansx + "',N'" + diachi + "'," + dienthoai + "')";
            db.ExecuteNonQuery(sql);
        }
        public void XoaNSX(string index_sp)
        {
            string sql = "Delete from NHASANXUAT where MANSX =" + "'" + index_sp + "'";
            db.ExecuteNonQuery(sql);
        }
        public void CapnhatNSX(string diachi, string dienthoai, string mansx)
        {
            string str = string.Format("Update NHASANXUAT set DIACHI = N'{0}', DIENTHOAI = '{1}'  where MANSX ='{2}' ", diachi, dienthoai, mansx);
            db.ExecuteNonQuery(str);
        }
    }
}
