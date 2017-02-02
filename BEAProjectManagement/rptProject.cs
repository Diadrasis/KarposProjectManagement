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
    public partial class rptProject : Form
    {
        public rptProject()
        {
            InitializeComponent();
        }

        private void rptProject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.rptProject' table. You can move, or remove it, as needed.
            this.rptProjectTableAdapter.Fill(this.beaDBDataSet.rptProject);

            this.reportViewer1.RefreshReport();
        }
    }
}
