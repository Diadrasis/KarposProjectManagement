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
    public partial class frmChoosePerson : Form
    {
        public int tsType;

        public frmChoosePerson()
        {
            InitializeComponent();
        }

        private void frmChoosePerson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet2.tblYears' table. You can move, or remove it, as needed.
            this.tblYearsTableAdapter.Fill(this.beaDBDataSet2.tblYears);
            // TODO: This line of code loads data into the 'beaDBDataSet1.tblMonths' table. You can move, or remove it, as needed.
            this.tblMonthsTableAdapter.Fill(this.beaDBDataSet1.tblMonths);
            // TODO: This line of code loads data into the 'beaDBDataSet.vPersons' table. You can move, or remove it, as needed.
            this.vPersonsTableAdapter.Fill(this.beaDBDataSet.vPersons);

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            int y = (int)(this.comboBox2.SelectedValue);
            int m = (int)this.comboBox3.SelectedValue;
            int d = 1;
            //DateTime dateFrom = new DateTime((int)this.comboBox2.SelectedItem, (int)this.comboBox3.SelectedValue, d);
            DateTime dateFrom = new DateTime(y, m, d);
            DateTime dateTo = new DateTime();
            dateTo = (dateFrom.AddMonths(1)).AddDays(-1);

            if (this.tsType == 1)            {

                rptTimeSheet frm = new rptTimeSheet();
                frm.rpDateFrom = dateFrom;
                frm.rpDateTo = dateTo;
                frm.Show();

            }
            else
            {
                rptTimeSheet2 frm2 = new rptTimeSheet2();
                frm2.rpDateFrom = dateFrom;
                frm2.rpDateTo = dateTo;
                frm2.Show();
            }

          
          
        }
    }
}
