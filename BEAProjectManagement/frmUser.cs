using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmUser : BEAProjectManagement.frmTemplate
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void tblUsersByIDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUsersByIDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.vUserRoles' table. You can move, or remove it, as needed.
            this.vUserRolesTableAdapter.Fill(this.beaDBDataSet.vUserRoles);
            // TODO: This line of code loads data into the 'beaDBDataSet.vUserRoles' table. You can move, or remove it, as needed.
            this.vUserRolesTableAdapter.Fill(this.beaDBDataSet.vUserRoles);

            try
            {
                this.tblUsers1TableAdapter.Fill(this.beaDBDataSet.tblUsersByID, bea.userID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tblUsersByIDBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUsersByIDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);

        }

       
    }
}
