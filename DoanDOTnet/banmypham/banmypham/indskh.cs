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
    public partial class indskh : Form
    {
        public indskh()
        {
            InitializeComponent();
        }

        private void indskh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QL_MYPHAMDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.KHACHHANGTableAdapter.Fill(this.QL_MYPHAMDataSet.KHACHHANG);

            this.reportViewer1.RefreshReport();
        }
    }
}
