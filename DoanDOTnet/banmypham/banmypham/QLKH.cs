using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banmypham
{
    public partial class QLKH : Form
    {
        khachhang kh;
        DataTable dt;
        bool themmoi = true;
        public QLKH()
        {
            InitializeComponent();
            kh = new khachhang();
            dt = new DataTable();
        }
        public void HienthiDSKH()
        {
            dt = kh.LayDSKH();
            lvskh.Items.Clear();
            lvskh.View = View.Details;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lvskh.Items.Add(dt.Rows[i]["MAKH"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TENKH"].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
                lvi.SubItems.Add(dt.Rows[i][8].ToString());
            }
        }

        private void QLKH_Load(object sender, EventArgs e)
        {
            HienthiDSKH();
            setButton(true);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvskh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvskh.SelectedIndices.Count > 0)
            {
                txtmakh.Text = lvskh.SelectedItems[0].SubItems[0].Text;
                txttenkh.Text = lvskh.SelectedItems[0].SubItems[1].Text;
                txtdiachi.Text = lvskh.SelectedItems[0].SubItems[2].Text;
                txtdt.Text = lvskh.SelectedItems[0].SubItems[3].Text;
                txtngaysinh.Text = lvskh.SelectedItems[0].SubItems[4].Text;
                txtgioitinh.Text = lvskh.SelectedItems[0].SubItems[5].Text;
                txtemail.Text = lvskh.SelectedItems[0].SubItems[6].Text;
                txttk.Text = lvskh.SelectedItems[0].SubItems[7].Text;
                txtmk.Text = lvskh.SelectedItems[0].SubItems[8].Text;


            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setButton(bool value)
        {
            btnthem.Enabled = value;
            btnxoa.Enabled = value;
            btnsua.Enabled = value;
            btnluu.Enabled = !value;
            btnhuy.Enabled = !value;
            btnthoat.Enabled = value;
        }
        void clearForm()
        {
            txtmakh.Text = "";
            txttenkh.Text = "";
            txtgioitinh.Text = "";
            txtemail.Text = "";
            txtdiachi.Text = "";
            txtngaysinh.Text = "";
            txtdt.Text = "";
            txttk.Text = "";
            txtmk.Text = "";


        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            txtmakh.Focus();
            setButton(false);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lvskh.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn khách hàng cần cập nhật", "Cập nhật khách hàng");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvskh.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    kh.XoaKH(lvskh.SelectedItems[0].SubItems[0].Text);
                    lvskh.Items.RemoveAt(lvskh.SelectedIndices[0]);
                    clearForm();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cần xóa"); 
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (themmoi)
            {
                //--MAKH,TENKH,DIACHI,DIENTHOAI,NGAYSINH,GIOITINH,EMAIL,TAIKHOAN,MATKHAU
                kh.ThemKH(txtmakh.Text, txttenkh.Text, txtdiachi.Text, txtdt.Text, txtngaysinh.Text, txtgioitinh.Text, txtemail.Text, txttk.Text, txtmk.Text);
                MessageBox.Show("Thêm mới thành công");

            }
            else
            {
                kh.CapnhatKH(txttenkh.Text, txtdiachi.Text, txtdt.Text, txtngaysinh.Text, txtgioitinh.Text, txtemail.Text, txttk.Text, txtmk.Text, txtmakh.Text);
                MessageBox.Show("Cập nhật thành công");
            }
            HienthiDSKH();
            clearForm();
        }
    }
}
