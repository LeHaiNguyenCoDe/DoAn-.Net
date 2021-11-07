using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banmypham
{
    public partial class DN : Form
    {
        public DN()
        {
            InitializeComponent();
        }
        bool GetAccount(string TenDangNhap, string MatKhau)
        {
            return Login.Instance.GetAccount(TenDangNhap, MatKhau);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rc = ClientRectangle;
            if (rc.IsEmpty)
                return;
            if (rc.Width == 0 || rc.Height == 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.White, Color.FromArgb(196, 232, 250), 90F))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txttk.Text;
            string MatKhau = txtmk.Text;

            if (Login.Instance.GetAccount(TenDangNhap, MatKhau))
            {
                MessageBox.Show("Đăng nhập thành công");//Nếu đang nhập thành công thì sẽ hiển thị form chính lên form chính m show ra bên dưới cái Message này 
                //form chính
                 menu mn = new menu();
                 this.Hide();
                 mn.Show();
                
                
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }

        private void DN_Load(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
