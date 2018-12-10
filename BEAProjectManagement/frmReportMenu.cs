using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmReportMenu : BEAProjectManagement.frmTemplate
    {
        public frmReportMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmChoosePerson frm = new frmChoosePerson();
            frm.tsType = 1;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //rptProjectReview frm = new rptProjectReview();
            //frm.projectID =(int)this.comboBox1.SelectedValue;
            frmChooseProject frm = new frmChooseProject();
            frm.Show();
        }

        private void frmReportMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.vProjects' table. You can move, or remove it, as needed.
            this.vProjectsTableAdapter.Fill(this.beaDBDataSet.vProjects);
            this.Text = "Αναφορές";
            this.comboBox1.SelectedItem = this.comboBox1.Items[1];

            this.comboBox1.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            this.button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rptProjectReport frm = new rptProjectReport();
            frm.projectTtile = this.comboBox1.SelectedValue.ToString();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rptProjectActivities frm = new rptProjectActivities();
            frm.projectTitle = this.comboBox1.SelectedValue.ToString();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmChoosePerson frm = new frmChoosePerson();
            frm.tsType = 2;
            frm.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            rptProjectsReview frm = new rptProjectsReview();
            frm.Show();
        }
    }
}
