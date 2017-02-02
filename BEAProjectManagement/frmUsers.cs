using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmUsers : BEAProjectManagement.frmTemplate
    {
        DataGridView dgv;
        BindingNavigator bnv;

        public frmUsers()
        {
            InitializeComponent();
        }

        private void tblUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.vUserRoles' table. You can move, or remove it, as needed.
            this.vUserRolesTableAdapter.Fill(this.beaDBDataSet.vUserRoles);
            // TODO: This line of code loads data into the 'beaDBDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.beaDBDataSet.tblUsers);

            dgv = this.tblUsersDataGridView;
            bnv = this.tblUsersBindingNavigator;
            DesignHelper.DesignDataGridView(dgv);
            DesignHelper.DesignDataGridNavigator(bnv);

            this.Text = "Χρήστες Εφαρμογής";

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn2"].HeaderText = "Όνομα Χρήστη";
            dgv.Columns["dataGridViewTextBoxColumn2"].Width = 150;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Όνομα";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 150;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Επώνυμο";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width = 150;

            dgv.Columns["dataGridViewTextBoxColumn5"].Visible = false;
            dgv.Columns["dataGridViewTextBoxColumn5"].HeaderText = "Κωδικός";
            dgv.Columns["dataGridViewTextBoxColumn5"].Width = 150;

            dgv.Columns["userMail"].HeaderText = "Mail";
            dgv.Columns["userMail"].Width = 120;

            dgv.Columns["userTelephone"].HeaderText = "Τηλέφωνο";
            dgv.Columns["userTelephone"].Width = 120;

            dgv.Columns["dataGridViewTextBoxColumn6"].HeaderText = "Ρόλος";
            dgv.Columns["dataGridViewTextBoxColumn6"].Width = 200;           

        }

       

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           // SaveChanges();
        }

        private void SaveChanges()
        {
            this.Validate();
            this.tblUsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);
        }
    }
}
