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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void ttkh_Click(object sender, EventArgs e)
        {
            QLKH kh = new QLKH();
            kh.Show();
        }

        private void ttsp_Click(object sender, EventArgs e)
        {
            QLSP sp = new QLSP();
            sp.Show();
        }

        private void ttnsx_Click(object sender, EventArgs e)
        {
            QLNSX nsx = new QLNSX();
            nsx.Show();
        }

        private void ttdx_Click(object sender, EventArgs e)
        {
            DN dn = new DN();
            dn.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            indskh dskh = new indskh();
            dskh.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            indshd dshd = new indshd();
            dshd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inhoadon ihd = new inhoadon();
            ihd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            demkh dkh = new demkh();
            dkh.Show();
        }

        private void ttttsv_Click(object sender, EventArgs e)
        {
            ttsv tt = new ttsv();
            tt.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
