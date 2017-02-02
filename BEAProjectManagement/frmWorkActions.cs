using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmWorkActions : BEAProjectManagement.frmTemplate
    {
        public int actwrkID;
        DataGridView dgv;
        BindingNavigator bnv;

        public frmWorkActions()
        {
            InitializeComponent();
        }

        private void tblWorkActionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblWorkActionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);

        }

       

        private void frmWorkActions_Load(object sender, EventArgs e)
        {
            try
            {
                this.tblWorkActionsTableAdapter.Fill(this.beaDBDataSet.tblWorkActions, this.actwrkID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            dgv = this.tblWorkActionsDataGridView;
            bnv = this.tblWorkActionsBindingNavigator;
            DesignHelper.DesignDataGridView(dgv);
            DesignHelper.DesignDataGridNavigator(bnv);
            this.Text = "Εργασίες";

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;
            dgv.Columns["dataGridViewTextBoxColumn2"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Κωδικός";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 70;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Τίτλος";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width = 400;

            dgv.Columns["dataGridViewTextBoxColumn5"].Visible = false;
        }

        private void tblWorkActionsDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value == System.DBNull.Value)
            {
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value = this.actwrkID;
            }
        }
    }
}
