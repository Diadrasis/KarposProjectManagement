using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmParametersMenu : BEAProjectManagement.frmTemplate
    {
        public frmParametersMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPersons frm = new frmPersons();
            frm.Show();
        }

        private void frmParametersMenu_Load(object sender, EventArgs e)
        {
            this.Text = "Πόροι";
           
           if (bea.userRole == 2)
           {
               this.button2.Enabled = false;

           }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.Show();
        }
    }
}
