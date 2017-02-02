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
    public partial class rptProjectChart : Form
    {
        public int projectID;
        public rptProjectChart()
        {
            InitializeComponent();
        }

        private void rptChartTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.rptProjectDesign' table. You can move, or remove it, as needed.
            this.rptProjectDesignTableAdapter.Fill(this.beaDBDataSet.rptProjectDesign, projectID);
            this.reportViewer1.RefreshReport();
        }
    }
}
