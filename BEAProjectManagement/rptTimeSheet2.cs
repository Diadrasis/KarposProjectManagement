using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class rptTimeSheet2 : Form
    {
        public DateTime rpDateFrom;
        public DateTime rpDateTo;

        public rptTimeSheet2()
        {
            InitializeComponent();
        }

        private void rptTimeSheet2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.rptTimeSheet' table. You can move, or remove it, as needed.
            this.rptTimeSheetTableAdapter.Fill(this.beaDBDataSet.rptTimeSheet, rpDateFrom.ToString(), rpDateTo.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
