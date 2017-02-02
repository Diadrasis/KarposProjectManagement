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
    public partial class rptProjectActivities : Form
    {
        public string projectTitle;

        public rptProjectActivities()
        {
            InitializeComponent();
        }

        private void rptProjectActivities_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.rptProjectDesign2' table. You can move, or remove it, as needed.
            this.rptProjectDesign2TableAdapter.Fill(this.beaDBDataSet.rptProjectDesign2, this.projectTitle);
            // TODO: This line of code loads data into the 'beaDBDataSet.rptProjectActivitiesDesign' table. You can move, or remove it, as needed.
            this.rptProjectActivitiesDesignTableAdapter.Fill(this.beaDBDataSet.rptProjectActivitiesDesign, this.projectTitle);

            this.reportViewer1.RefreshReport();
        }
    }
}
