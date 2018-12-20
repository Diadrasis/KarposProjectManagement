using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmStaffPayments : BEAProjectManagement.frmTemplate
    {

        public int personID;
        DataGridView dgv;
        BindingNavigator bnv;
        int CurrentRow;

        public frmStaffPayments()
        {
            InitializeComponent();
        }

        private void tblStaffPaymentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblStaffPaymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void frmStaffPayments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.vStaffPaymentReasons' table. You can move, or remove it, as needed.
            this.vStaffPaymentReasonsTableAdapter.Fill(this.beaDBDataSet.vStaffPaymentReasons);
            try
            {
                this.tblStaffPaymentsTableAdapter.Fill(this.beaDBDataSet.tblStaffPayments, new System.Nullable<int>(((int)(System.Convert.ChangeType(personIDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            dgv = this.tblStaffPaymentsDataGridView;
            bnv = this.tblStaffPaymentsBindingNavigator;
            DesignHelper.DesignDataGridView(dgv);
            DesignHelper.DesignDataGridNavigator(bnv);
            this.Text = "Πληρωμές Εργζαόμενου";

            this.Size = new Size(1200, 550);

            this.lblCurrentPerson.Text = bea.currentProject;
            this.lblCurrentPerson.Location = new Point(320, 110);

            this.monthCalendar1.Visible = false;
        }

        private void tblStaffPaymentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void tblStaffPaymentsDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value == System.DBNull.Value)
            {
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value = this.personID;
            }
        }
    }
}
