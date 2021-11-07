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
    public partial class QLSP : Form
    {
        sanpham sp;
        DataTable dt;
        bool themmoi = true;
        public QLSP()
        {
            InitializeComponent();
            sp = new sanpham();
            dt = new DataTable();
        }

        private void QLSP_Load(object sender, EventArgs e)
        {
            Hienthidssp();
            setButton(true);
        }
       
        public void Hienthidssp()
        {
            dt = sp.LaydanhsachSP();
            lvssp.Items.Clear();
            lvssp.View = View.Details;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lvssp.Items.Add(dt.Rows[i]["MASP"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TENSP"].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }

        private void lvssp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvssp.SelectedIndices.Count > 0)
            {
                txtmasp.Text = lvssp.SelectedItems[0].SubItems[0].Text;
                txttensp.Text = lvssp.SelectedItems[0].SubItems[1].Text;
                txtdg.Text = lvssp.SelectedItems[0].SubItems[2].Text;
                txtdvt.Text = lvssp.SelectedItems[0].SubItems[3].Text;
                txtmt.Text = lvssp.SelectedItems[0].SubItems[4].Text;
                cbbcd.Text = lvssp.SelectedItems[0].SubItems[5].Text;

            }

          
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
            txtmasp.Text="";
            txttensp.Text = "";
            txtdvt.Text = "";
            txtmt.Text = "";
            cbbcd.SelectedIndex = 0;
            txtdg.Text = "";

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            txtmasp.Focus();
            setButton(false);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lvssp.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu sản phẩm cần cập nhật", "Cập nhật sản phẩm");

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string mcd="";
            if (cbbcd.SelectedItem.Equals ("Sữa Rửa Mặt"))
                mcd = "M01";
            else if (cbbcd.SelectedItem.Equals("Toner Nước Hoa Hồng"))
                mcd = "M02";
            else if (cbbcd.SelectedItem.Equals("Dưỡng Ẩm"))
                mcd = "M03";
            else if (cbbcd.SelectedItem.Equals("Serum Tinh Dưỡng"))
                mcd = "M04";
            else if (cbbcd.SelectedItem.Equals("Dưỡng Trắng"))
                mcd = "M05";
            else if (cbbcd.SelectedItem.Equals("Chống Lão Hóa"))
                mcd = "M06";
            else if (cbbcd.SelectedItem.Equals("Chăm Sóc Vùng Da Mắt"))
                mcd = "M07";
            else if (cbbcd.SelectedItem.Equals("Trị Mụn"))
                mcd = "M08";
            else if (cbbcd.SelectedItem.Equals("Lotion Dưỡng Ẩm"))
                mcd = "M09";
            else if (cbbcd.SelectedItem.Equals("Tinh Chất Dưỡng"))
                mcd = "M10";
            else if (cbbcd.SelectedItem.Equals("Dưỡng Trắng"))
                mcd = "M11";
            else if (cbbcd.SelectedItem.Equals("Chống Lão Hóa"))
                mcd = "M12";
            else if (cbbcd.SelectedItem.Equals("Chăm Sóc Da Mặt"))
                mcd = "M13";
            else if (cbbcd.SelectedItem.Equals("Mặt Nạ Dưỡng Da"))
                mcd = "M14";
            else if (cbbcd.SelectedItem.Equals("Chống Nắng Bảo Vệ Da"))
                mcd = "M15";
            
            if(themmoi)
            {
                sp.Themsanpham(txtmasp.Text, txttensp.Text, float.Parse(txtdg.Text), txtdvt.Text, txtmt.Text, mcd);
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {

               
                
                sp.Capnhatsanpham(txttensp.Text, float.Parse(txtdg.Text), txtdvt.Text, txtmt.Text, mcd, lvssp.SelectedItems[0].SubItems[0].Text.ToString());
                MessageBox.Show("Cập nhật thành công");
            }
            Hienthidssp();
            clearForm();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvssp.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    sp.Xoasanpham(lvssp.SelectedItems[0].SubItems[0].Text);
                    lvssp.Items.RemoveAt(lvssp.SelectedIndices[0]);
                    clearForm();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cần xóa"); 
        }
    }
}
