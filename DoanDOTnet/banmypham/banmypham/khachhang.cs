using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banmypham
{
    class khachhang
    {
        database db;
        public khachhang()
        {
            db = new database("LAPTOP-QF4UJQ33\\SQLEXPRESS", "QL_MYPHAM", true, "chien", "123");
        }
        public DataTable LayDSKH()
        {
            return db.Execute("select MAKH, TENKH, DIACHI, DIENTHOAI, NGAYSINH, GIOITINH, EMAIL, TAIKHOAN, MATKHAU from KHACHHANG");
        }
        public void ThemKH(string makh, string tenkh, string diachi, string dienthoai, string ngaysinh, string gioitinh, string email, string taikhoan, string matkhau)
        {
            string sql = "insert into KHACHHANG(MAKH, TENKH, DIACHI, DIENTHOAI, NGAYSINH, GIOITINH, EMAIL, TAIKHOAN, MATKHAU) values('" + makh + "',N'" + tenkh + "',N'" + diachi + "','" + dienthoai + "','" + ngaysinh + "',N'" + gioitinh + "','" + email + "','" + taikhoan + "','" + matkhau + "')";
            db.ExecuteNonQuery(sql);
        }
        public void XoaKH(string index_kh)
        {
            string sql = "Delete from KHACHHANG where MAKH =" + "'" + index_kh + "'";
            db.ExecuteNonQuery(sql);
        }
        public void CapnhatKH(string tenkh, string diachi, string dienthoai, string ngaysinh, string gioitinh, string email, string taikhoan, string matkhau, string makh)
        {
            string str = string.Format("Update KHACHHANG set TENKH = N'{0}', DIACHI = N'{1}', DIENTHOAI = '{2}', NGAYSINH = '{3}', GIOITINH = N'{4}', EMAIL='{5}', TAIKHOAN = '{6}', MATKHAU = '{7}' where MAKH ='{8}' ", tenkh, diachi, dienthoai, ngaysinh, gioitinh, email, taikhoan, matkhau, makh);
            db.ExecuteNonQuery(str);
        }
      
    }
}
