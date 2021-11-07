using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banmypham
{
    class sanpham
    {
        database db;
        public sanpham()
        {
            db = new database("LAPTOP-QF4UJQ33\\SQLEXPRESS","QL_MYPHAM",true,"chien","123");
        }
        public DataTable LaydanhsachSP()
        {
            return db.Execute("SELECT MASP, TENSP, DONGIA, DONVITINH, MOTA, TENCD FROM SANPHAM INNER JOIN CHU_DE ON SANPHAM.MACD = CHU_DE.MACD");
        }

        public void Themsanpham(string masp, string tensp, float dongia, string donvitinh, string mota, string macd) 
        {
       
            
            string sql = "Insert into SANPHAM(MASP,TENSP,DONGIA,DONVITINH,MOTA,MACD) VALUES('" + masp + "',N'" + tensp + "'," + dongia + ",N'" + donvitinh + "',N'" + mota + "','" + macd + "')";
            db.ExecuteNonQuery(sql);
        }
        public void Xoasanpham(string index_sp)
        {
            string sql = "Delete from SANPHAM where MASP ="+ "'"+ index_sp +"'";
            db.ExecuteNonQuery(sql);
        }
        public void Capnhatsanpham(string tensp, float dongia, string donvitinh, string mota, string macd, string masp)
        {
            string str = string.Format("Update SANPHAM set TENSP = N'{0}', DONGIA = '{1}', DONVITINH = N'{2}', MOTA = N'{3}', MACD = N'{4}' where MASP ='{5}' ", tensp, dongia, donvitinh, mota, macd, masp);
            db.ExecuteNonQuery(str);
        }
    }
}
