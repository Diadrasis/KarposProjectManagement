using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmReportingMenu : BEAProjectManagement.frmTemplate
    {
        public frmReportingMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmChooseProject frm = new frmChooseProject();
            frm.openForm = "projectPayments";
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            frmChooseProject frm = new frmChooseProject();
            frm.openForm = "projectExpenses";
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmChoosePerson frm = new frmChoosePerson();
            frm.openForm = "staffPayments";
            frm.Show();
        }
    }
}
