using Microsoft.Reporting.WinForms;
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
        public int personID;
        public string personName;
        public DateTime rpDateFrom;
        public DateTime rpDateTo;

        public rptTimeSheet2()
        {
            InitializeComponent();
        }

        private void rptTimeSheet2_Load(object sender, EventArgs e)
        {

            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("el-GR");
            string MonthYear=rpDateFrom.ToString("MMMM", culture) + " " + rpDateFrom.Year.ToString();

            // TODO: This line of code loads data into the 'beaDBDataSet.rptTimeSheet' table. You can move, or remove it, as needed.
            this.rptTimeSheetTableAdapter.Fill(this.beaDBDataSet.rptTimeSheet, rpDateFrom.ToString(), rpDateTo.ToString());
            

            ReportParameter rp1 = new ReportParameter("rpPerson", this.personID.ToString());
            ReportParameter rp2 = new ReportParameter("rpPersonName", this.personName.ToString());
            ReportParameter rp3 = new ReportParameter("rpMonthYear", MonthYear);

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1,rp2,rp3 });            
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
