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
    public partial class demkh : Form
    {
        public demkh()
        {
            InitializeComponent();
        }

        private void demkh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QL_MYPHAMDataSet.NHASANXUAT' table. You can move, or remove it, as needed.
            this.NHASANXUATTableAdapter.Fill(this.QL_MYPHAMDataSet.NHASANXUAT);

            this.reportViewer1.RefreshReport();
        }
    }
}
