using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmProjectExpences : BEAProjectManagement.frmTemplate
    {
        public int projectID;
        DataGridView dgv;
        BindingNavigator bnv;
        int CurrentRow;

        public frmProjectExpences()
        {
            InitializeComponent();
        }

        private void tblProjectSpendigsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblProjectSpendigsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void frmProjectExpences_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.vCostTypes' table. You can move, or remove it, as needed.
            this.vCostTypesTableAdapter.Fill(this.beaDBDataSet.vCostTypes);
            try
            {
                this.tblProjectSpendigsTableAdapter.Fill(this.beaDBDataSet.tblProjectSpendigs, projectID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            dgv = this.tblProjectSpendigsDataGridView;
            bnv = this.tblProjectSpendigsBindingNavigator;
            DesignHelper.DesignDataGridView(dgv);
            DesignHelper.DesignDataGridNavigator(bnv);
            this.Text = "Έξοδα Έργου";

            this.Size = new Size(1200, 550);

            this.lblCurrentProject.Text = bea.currentProject;
            this.lblCurrentProject.Location = new Point(320, 110);

            this.monthCalendar1.Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;
            dgv.Columns["dataGridViewTextBoxColumn2"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Δραστηριότητα";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 120;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Τύπος Κόστους";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width = 200;

            dgv.Columns["dataGridViewTextBoxColumn5"].HeaderText = "Ποσό";
            dgv.Columns["dataGridViewTextBoxColumn5"].Width = 100;

            dgv.Columns["dataGridViewTextBoxColumn6"].HeaderText = "Ημερομηνία";
            dgv.Columns["dataGridViewTextBoxColumn6"].Width = 120;
            DesignHelper.InactivateColumn(dgv, 3);

            dgv.Columns["dataGridViewTextBoxColumn7"].HeaderText = "Περιγραφή";
            dgv.Columns["dataGridViewTextBoxColumn7"].Width = 250;

            dgv.Columns["dataGridViewTextBoxColumn8"].HeaderText = "Παραστατικό";
            dgv.Columns["dataGridViewTextBoxColumn8"].Width = 80;

            dgv.Columns["colCalendar"].HeaderText = "";
            dgv.Columns["colCalendar"].Width = 120;


           
            

           

            
        }

        private void tblProjectSpendigsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                CurrentRow = e.RowIndex;
                if (e.ColumnIndex == dgv.Columns["colCalendar"].Index && this.monthCalendar1.Visible == false)
                {
                    this.monthCalendar1.Visible = true;
                    this.monthCalendar1.Location = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
                    if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value != System.DBNull.Value)
                    {
                        this.monthCalendar1.SetDate(Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value));
                    }
                }
            }
        }

        private void tblProjectSpendigsDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value == System.DBNull.Value)
            {
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value = this.projectID;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dgv.Rows[CurrentRow].Cells["dataGridViewTextBoxColumn6"].Value = this.monthCalendar1.SelectionStart;
            this.monthCalendar1.Visible = false;
        }
    }
}
