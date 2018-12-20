using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmResourcesMenu : BEAProjectManagement.frmTemplate
    {
        public frmResourcesMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmStaffContracts frm = new frmStaffContracts();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPersons frm = new frmPersons();
            frm.Show();
        }
    }
}
