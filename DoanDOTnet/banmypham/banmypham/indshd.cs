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
    public partial class indshd : Form
    {
        public indshd()
        {
            InitializeComponent();
        }

        private void indshd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QL_MYPHAMDataSet.DONDATHANG' table. You can move, or remove it, as needed.
            this.DONDATHANGTableAdapter.Fill(this.QL_MYPHAMDataSet.DONDATHANG);

            this.reportViewer1.RefreshReport();
        }
    }
}
