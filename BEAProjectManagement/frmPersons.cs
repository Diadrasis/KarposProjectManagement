using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmPersons : BEAProjectManagement.frmTemplate
    {
        DataGridView dgv;
        BindingNavigator bnv;
       
        public frmPersons()
        {
            InitializeComponent();
        }

        private void tblPersonsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblPersonsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);
        }

        private void frmPersons_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.tblPersons' table. You can move, or remove it, as needed.
            this.tblPersonsTableAdapter.Fill(this.beaDBDataSet.tblPersons);

            dgv = this.tblPersonsDataGridView;
            bnv = this.tblPersonsBindingNavigator;
            DesignHelper.DesignDataGridView(dgv);
            DesignHelper.DesignDataGridNavigator(bnv);

            this.Text = "Προσωπικό";

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn2"].HeaderText = "Όνομα";
            dgv.Columns["dataGridViewTextBoxColumn2"].Width = 200;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Επώνυμο";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 200;

            dgv.Columns["personActive"].HeaderText = "Ενεργός";
            dgv.Columns["personActive"].Width = 40;

            dgv.Columns["currentMonthCost"].HeaderText = "Μηνιαίο";
            dgv.Columns["currentMonthCost"].Width = 70;
            DesignHelper.InactivateColumn(dgv, dgv.Columns["currentMonthCost"].Index);

            dgv.Columns["currentWeekCost"].HeaderText = "Εβδομαδιαίο";
            dgv.Columns["currentWeekCost"].Width = 40;
            dgv.Columns["currentWeekCost"].Visible = false;


            dgv.Columns["currentDayCost"].HeaderText = "Ημερήσιο";
            dgv.Columns["currentDayCost"].Width = 70;
            DesignHelper.InactivateColumn(dgv, dgv.Columns["currentDayCost"].Index);

            dgv.Columns["currentHourCost"].HeaderText = "Ωριαίο";
            dgv.Columns["currentHourCost"].Width = 70;
            DesignHelper.InactivateColumn(dgv, dgv.Columns["currentHourCost"].Index);

            dgv.Columns["dataGridViewTextBoxColumn4"].Visible = false;

            dgv.Columns["Availability"].HeaderText = "Διαθεσιμότητα";
            dgv.Columns["Availability"].Width = 100;

            dgv.Columns["Cost"].HeaderText = "Κόστος";
            dgv.Columns["Cost"].Width = 75;

            dgv.Columns["timeSheet"].HeaderText = "Απασχόληση";
            dgv.Columns["timeSheet"].Width = 100;
            dgv.Columns["timeSheet"].Visible = false;

            dgv.Columns["TimeSheet2"].HeaderText = "Απασχόληση 2";
            dgv.Columns["TimeSheet2"].Width = 100;

        }

        private void tblPersonsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //pick calendar...
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == dgv.Columns["timeSheet"].Index)
                {
                    frmTimeSheet frm = new frmTimeSheet();
                    frm.personID = Convert.ToInt16(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                    frm.Show();
                }
                else if (e.ColumnIndex == dgv.Columns["Availability"].Index)
                {
                    frmPersonAvailability frm = new frmPersonAvailability();
                    frm.personID= Convert.ToInt16(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                    bea.currentPerson = bea.GetCurrentPerson(frm.personID);
                    frm.Show();
                }
                else if (e.ColumnIndex == dgv.Columns["Cost"].Index)
                {
                    frmPersonCost frm = new frmPersonCost();
                    frm.personID = Convert.ToInt16(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                    bea.currentPerson = bea.GetCurrentPerson(frm.personID);
                    frm.Show();
                }

                else if (e.ColumnIndex == dgv.Columns["timeSheet2"].Index)
                {
                    frmTimeSheet2 frm = new frmTimeSheet2();
                    frm.personID = Convert.ToInt16(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                    bea.currentPerson = bea.GetCurrentPerson(frm.personID);                    
                    frm.Show();
                }
            }
        }

        private void tblPersonsDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value == System.DBNull.Value)
            {
                MessageBox.Show("Ο εργαζόμενος πρέπει να έχει όνομα!");
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value ="Όνομα";
            }

            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value == System.DBNull.Value)
            {
                MessageBox.Show("Ο εργαζόμενος πρέπει να έχει επώνυμο!");
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value = "Επώνυμο";
            }

            if (dgv.Rows[e.RowIndex].Cells["personActive"].Value == System.DBNull.Value)
            {                
                dgv.Rows[e.RowIndex].Cells["personActive"].Value = false;
            }
        }
    }
}
