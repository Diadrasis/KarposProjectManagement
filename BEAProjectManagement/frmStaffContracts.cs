using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmStaffContracts : BEAProjectManagement.frmTemplate
    {
        DataGridView dgv;
        BindingNavigator bnv;
        int CurrentRow;

        public frmStaffContracts()
        {
            InitializeComponent();
        }

        private void tblStaffContractsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblStaffContractsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);

        }

        private void frmStaffContracts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.vPersons' table. You can move, or remove it, as needed.
            this.vPersonsTableAdapter.Fill(this.beaDBDataSet.vPersons);
            // TODO: This line of code loads data into the 'beaDBDataSet.tblStaffContracts' table. You can move, or remove it, as needed.
            this.tblStaffContractsTableAdapter.Fill(this.beaDBDataSet.tblStaffContracts);

            dgv = this.tblStaffContractsDataGridView;
            bnv = this.tblStaffContractsBindingNavigator;
            DesignHelper.DesignDataGridView(dgv);
            DesignHelper.DesignDataGridNavigator(bnv);

            //MessageBox.Show(dgv.RowTemplate.Height.ToString());
            this.monthCalendar1.Visible = false;
            this.monthCalendar2.Visible = false;

            //this.WindowState = FormWindowState.Maximized;
            this.Width = 1400;

            this.Text = "Συμβάσεις Προσωπικού";

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn2"].HeaderText = "Εργαζόμενος";
            dgv.Columns["dataGridViewTextBoxColumn2"].Width = 200;

            dgv.Columns["dataGridViewTextBoxColumn3"].Visible = false;

            dgv.Columns["contStartCalendar"].HeaderText = "";
            dgv.Columns["contStartCalendar"].Width = 40;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Έναρξη";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width = 90;
            DesignHelper.InactivateColumn(dgv, dgv.Columns["dataGridViewTextBoxColumn4"].Index);

            dgv.Columns["contFinishCalendar"].HeaderText = "";
            dgv.Columns["contFinishCalendar"].Width = 40;

            dgv.Columns["dataGridViewTextBoxColumn5"].HeaderText = "Λήξη";
            dgv.Columns["dataGridViewTextBoxColumn5"].Width = 90;
            DesignHelper.InactivateColumn(dgv, dgv.Columns["dataGridViewTextBoxColumn5"].Index);

            dgv.Columns["dataGridViewTextBoxColumn6"].HeaderText = "Μηνιαία Αμοιβή";
            dgv.Columns["dataGridViewTextBoxColumn6"].Width = 100;

            dgv.Columns["dataGridViewTextBoxColumn7"].HeaderText = "'Ωρες Εργασίας";
            dgv.Columns["dataGridViewTextBoxColumn7"].Width = 50;

            dgv.Columns["dataGridViewCheckBoxColumn1"].HeaderText = "Δ";
            dgv.Columns["dataGridViewCheckBoxColumn1"].Width = 30;

            dgv.Columns["dataGridViewCheckBoxColumn2"].HeaderText = "Τ";
            dgv.Columns["dataGridViewCheckBoxColumn2"].Width = 30;

            dgv.Columns["dataGridViewCheckBoxColumn3"].HeaderText = "Τ";
            dgv.Columns["dataGridViewCheckBoxColumn3"].Width = 30;

            dgv.Columns["dataGridViewCheckBoxColumn4"].HeaderText = "Π";
            dgv.Columns["dataGridViewCheckBoxColumn4"].Width = 30;

            dgv.Columns["dataGridViewCheckBoxColumn5"].HeaderText = "Π";
            dgv.Columns["dataGridViewCheckBoxColumn5"].Width = 30;

            dgv.Columns["dataGridViewCheckBoxColumn6"].HeaderText = "Ενεργή";
            dgv.Columns["dataGridViewCheckBoxColumn6"].Width = 50;
        }

        private void tblStaffContractsDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn1"].Value == System.DBNull.Value)
            {
                dgv.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn1"].Value = false;
            }

            if (dgv.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn2"].Value == System.DBNull.Value)
            {
                dgv.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn2"].Value = false;
            }

            if (dgv.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn3"].Value == System.DBNull.Value)
            {
                dgv.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn3"].Value = false;
            }

            if (dgv.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn4"].Value == System.DBNull.Value)
            {
                dgv.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn4"].Value = false;
            }

            if (dgv.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn5"].Value == System.DBNull.Value)
            {
                dgv.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn5"].Value = false;
            }

            if (dgv.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn6"].Value == System.DBNull.Value)
            {
                dgv.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn6"].Value = false;
            }
        }

        private void tblStaffContractsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                CurrentRow = e.RowIndex;
                if (e.ColumnIndex == dgv.Columns["contStartCalendar"].Index && this.monthCalendar2.Visible == false)
                {
                    this.monthCalendar1.Visible = true;
                    this.monthCalendar1.Location = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
                    if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value != System.DBNull.Value)
                    {
                        this.monthCalendar1.SetDate(Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value));
                    }
                }

                if (e.ColumnIndex == dgv.Columns["contFinishCalendar"].Index && this.monthCalendar1.Visible == false)
                {
                    this.monthCalendar2.Visible = true;
                    this.monthCalendar2.Location = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
                    if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value != System.DBNull.Value)
                    {
                        this.monthCalendar2.SetDate(Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value));
                    }
                }
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dgv.Rows[CurrentRow].Cells["dataGridViewTextBoxColumn4"].Value = this.monthCalendar1.SelectionStart;
            this.monthCalendar1.Visible = false;
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            dgv.Rows[CurrentRow].Cells["dataGridViewTextBoxColumn5"].Value = this.monthCalendar2.SelectionStart;
            this.monthCalendar2.Visible = false;
        }
    }
}
