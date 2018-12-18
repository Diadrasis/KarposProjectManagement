using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmMainMenu : BEAProjectManagement.frmTemplate
    {
        public int userID;

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmResourcesMenu frm = new frmResourcesMenu();
            frm.Show();
            //NoConnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmReportMenu frm = new frmReportMenu();
            frm.Show();
            //NoConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProgrammingMenu frm = new frmProgrammingMenu();
            frm.Show();
            //NoConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //NoConnection();
            frmReportingMenu frm = new frmReportingMenu();
            frm.Show();
        }

        private void NoConnection()
        {
            MessageBox.Show("Δεν έχουν φορτωθεί δεδομένα...");        

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            this.Text = "Επιλογές";
            this.labelUser.Text = bea.userFullName;
            /*
            if (bea.userRole == 1)
            {
                this.button1.Enabled = false;

            }
            */
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmParametersMenu frm = new frmParametersMenu();
            frm.Show();
        }
    }
}
