using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmProgrammingMenu : BEAProjectManagement.frmTemplate
    {
        public frmProgrammingMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProjects frm = new frmProjects();
            frm.Show();
        }

        private void frmProgrammingMenu_Load(object sender, EventArgs e)
        {
            this.Text = "Προγραμματισμός";
            this.labelUser.Text = bea.userFullName;
        }
    }
}
