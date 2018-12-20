using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmProjectBudget : BEAProjectManagement.frmTemplate
    {
        public int projID;
        DataGridView dgv;
        BindingNavigator bnv;

        public frmProjectBudget()
        {
            InitializeComponent();
        }

        private void tblProjectBudgetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblProjectBudgetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void frmProjectBudget_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beaDBDataSet.vCostTypes' table. You can move, or remove it, as needed.
            this.vCostTypesTableAdapter.Fill(this.beaDBDataSet.vCostTypes);
            try
            {
                this.tblProjectBudgetTableAdapter.Fill(this.beaDBDataSet.tblProjectBudget, this.projID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            dgv = this.tblProjectBudgetDataGridView;
            bnv = this.tblProjectBudgetBindingNavigator;
            DesignHelper.DesignDataGridView(dgv);
            DesignHelper.DesignDataGridNavigator(bnv);
            this.Text = "Προυπολογισμός Έργου";

            this.Size = new Size(1200, 550);

            this.lblCurrentProject.Text = bea.currentProject;
            this.lblCurrentProject.Location = new Point(320, 110);

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;
            dgv.Columns["dataGridViewTextBoxColumn2"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Είδος Κόστους";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 120;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Περιγραφή";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width = 200;

            dgv.Columns["dataGridViewTextBoxColumn5"].HeaderText = "";
            dgv.Columns["dataGridViewTextBoxColumn5"].Width = 200;

            dgv.Columns["dataGridViewTextBoxColumn6"].HeaderText = "Άξία Μονάδας";
            dgv.Columns["dataGridViewTextBoxColumn6"].Width = 80;

            dgv.Columns["dataGridViewTextBoxColumn7"].HeaderText = "ΜΜ";
            dgv.Columns["dataGridViewTextBoxColumn7"].Width = 100;

            dgv.Columns["dataGridViewTextBoxColumn8"].HeaderText = "Αριθμός";
            dgv.Columns["dataGridViewTextBoxColumn8"].Width = 80;
        }
    }
}
