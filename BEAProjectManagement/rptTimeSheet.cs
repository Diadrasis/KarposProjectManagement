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
    public partial class rptTimeSheet : Form
    {
        public  int  rpPersonID;
        public  DateTime rpDateFrom;
        public  DateTime rpDateTo;

        public rptTimeSheet()
        {
            InitializeComponent();
        }

        private void rptTimeSheet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.rptTimeSheet' table. You can move, or remove it, as needed.
            //rpPersonID = 1;
            //rpDateTo = DateTime.Now;
            //rpDateFrom = DateTime.Now.AddDays(-30);
            this.rptTimeSheetTableAdapter.Fill(this.beaDBDataSet.rptTimeSheet, rpDateFrom.ToString(), rpDateTo.ToString());

            /*
            List<ReportParameter> paramList = new List<ReportParameter>();
            paramList.Add(new ReportParameter("personID", rpPersonID.ToString(), true));
            paramList.Add(new ReportParameter("rpDateFrom", rpDateFrom.ToString(), true));
            paramList.Add(new ReportParameter("rpDateTo", rpDateTo.ToString(), true));
            this.reportViewer1.LocalReport.SetParameters(paramList);
            */
            
            this.reportViewer1.RefreshReport();


           
        }
    }
}
