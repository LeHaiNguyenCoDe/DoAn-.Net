using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banmypham
{
    public class Login
    {
        private static Login instance;
    public static Login Instance
    {
     get { if(instance == null) instance = new Login(); return Login.instance; }
     private  set { Login.instance = value; }
    }
    private Login() { }
    public bool GetAccount(string TenDangNhap, string MatKhau)
    {
        string query = string.Format("select * from KHACHHANG where TAIKHOAN = '" + TenDangNhap + "' and MATKHAU = '" + MatKhau + "'");
        DataTable result = datadangnhap.Instance.ExecuteQuery(query);
        return result.Rows.Count > 0;
    }
    }
 }

