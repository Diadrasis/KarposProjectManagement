using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmProjectPayments : BEAProjectManagement.frmTemplate
    {
        public int projectID;
        DataGridView dgv;
        BindingNavigator bnv;
        int CurrentRow;

        public frmProjectPayments()
        {
            InitializeComponent();
        }

        private void tblProjectPaymentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblProjectPaymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void frmProjectPayments_Load(object sender, EventArgs e)
        {
            try
            {
                this.tblProjectPaymentsTableAdapter.Fill(this.beaDBDataSet.tblProjectPayments, projectID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            dgv = this.tblProjectPaymentsDataGridView;
            bnv = this.tblProjectPaymentsBindingNavigator;
            DesignHelper.DesignDataGridView(dgv);
            DesignHelper.DesignDataGridNavigator(bnv);
            this.Text = "Πληρωμές Έργου";

            this.Size = new Size(1200, 550);

            this.lblCurrentProject.Text = bea.currentProject;
            this.lblCurrentProject.Location = new Point(320, 110);

            this.monthCalendar1.Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;
            dgv.Columns["dataGridViewTextBoxColumn2"].Visible = false;

            dgv.Columns["colCalendar"].HeaderText = "Ποσό";
            dgv.Columns["colCalendar3"].Width = 120;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Ημερομηνία";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width = 200;
            DesignHelper.InactivateColumn(dgv, 3);

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Ποσό";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 120;

            dgv.Columns["dataGridViewTextBoxColumn5"].HeaderText = "Περιγραφή";
            dgv.Columns["dataGridViewTextBoxColumn5"].Width = 300;
        }

        private void tblProjectPaymentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                CurrentRow = e.RowIndex;
                if (e.ColumnIndex == dgv.Columns["colCalendar"].Index && this.monthCalendar1.Visible == false)
                {
                    this.monthCalendar1.Visible = true;
                    this.monthCalendar1.Location = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
                    if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value != System.DBNull.Value)
                    {
                        this.monthCalendar1.SetDate(Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value));
                    }
                }
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dgv.Rows[CurrentRow].Cells["dataGridViewTextBoxColumn4"].Value = this.monthCalendar1.SelectionStart;
            this.monthCalendar1.Visible = false;
        }

        private void tblProjectPaymentsDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value == System.DBNull.Value)
            {
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value = this.projectID;
            }
        }
    }
}
