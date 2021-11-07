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
    public partial class QLNSX : Form
    {
        nhasanxuart nsx;
        DataTable dt;
        bool themmoi = true;
        public QLNSX()
        {
            InitializeComponent();
            nsx = new nhasanxuart();
            dt = new DataTable();

        }
        public void HienthidsNSX()
        {
            dt = nsx.LaydanhsachNSX();
            lvsnsx.Items.Clear();
            lvsnsx.View = View.Details;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lvsnsx.Items.Add(dt.Rows[i]["MANSX"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["DIACHI"].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
            }
        }

        private void lvsnsx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsnsx.SelectedIndices.Count > 0)
            {
                txtmansx.Text = lvsnsx.SelectedItems[0].SubItems[0].Text;
                txtdc.Text = lvsnsx.SelectedItems[0].SubItems[1].Text;
                txtdt.Text = lvsnsx.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void QLNSX_Load(object sender, EventArgs e)
        {
            HienthidsNSX();
            setButton(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            themmoi = true;
            txtmansx.Focus();
            setButton(true);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            txtmansx.Text = "";
            txtdc.Text = "";
            txtdt.Text = "";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lvsnsx.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn khách hàng cần cập nhật", "Cập nhật khách hàng");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvsnsx.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nsx.XoaNSX(lvsnsx.SelectedItems[0].SubItems[0].Text);
                    lvsnsx.Items.RemoveAt(lvsnsx.SelectedIndices[0]);
                    clearForm();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cần xóa");
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            {
                if (themmoi)
                {
                    
                    nsx.Themnhasx(txtmansx.Text, txtdc.Text, txtdt.Text);
                    MessageBox.Show("Thêm mới thành công");

                }
                else
                {
                    nsx.CapnhatNSX(txtdc.Text, txtdt.Text, txtmansx.Text);
                    MessageBox.Show("Cập nhật thành công");
                }
                HienthidsNSX();
                clearForm();
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }
        }
    }

