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
    public partial class rptProjectsReview : Form
    {
        public rptProjectsReview()
        {
            InitializeComponent();
        }

        private void rptProjectsReview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.rptProjectReview' table. You can move, or remove it, as needed.
            this.rptProjectsReviewTableAdapter.Fill(this.beaDBDataSet.rptProjectsReview);
            this.reportViewer1.RefreshReport();            
        }
    }
}
