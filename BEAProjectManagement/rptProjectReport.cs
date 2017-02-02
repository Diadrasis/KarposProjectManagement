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
    public partial class rptProjectReport : Form
    {
        public string projectTtile;
        public rptProjectReport()
        {
            InitializeComponent();
        }

        private void rptProjectReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.rptProjectDesign2' table. You can move, or remove it, as needed.
            this.rptProjectDesign2TableAdapter.Fill(this.beaDBDataSet.rptProjectDesign2, this.projectTtile);

            this.reportViewer1.RefreshReport();
        }
    }
}
