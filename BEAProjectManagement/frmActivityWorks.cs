using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmActivityWorks : BEAProjectManagement.frmTemplate
    {
        public int practID;
        public string practCodeTitle;

        DataGridView dgv;
        BindingNavigator bnv;

        public frmActivityWorks()
        {
            InitializeComponent();
        }

        private void tblActivityWorksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }       

        private void frmActivityWorks_Load(object sender, EventArgs e)
        {
            try
            {
                this.tblActivityWorksTableAdapter.Fill(this.beaDBDataSet.tblActivityWorks, this.practID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            dgv = this.tblActivityWorksDataGridView;
            bnv = this.tblActivityWorksBindingNavigator;
            DesignHelper.DesignDataGridView(dgv);
            DesignHelper.DesignDataGridNavigator(bnv);

            this.Text = "Ενέργειες Δραστηριότητας";
            this.lblDescription.Text = this.practCodeTitle;

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;
            dgv.Columns["dataGridViewTextBoxColumn2"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Κωδικός";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 70;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Τίτλος";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width = 300;

            dgv.Columns["dataGridViewTextBoxColumn5"].Visible = false;

            dgv.Columns["From"].HeaderText = "";
            dgv.Columns["From"].Width = 70;

            dgv.Columns["dataGridViewTextBoxColumn6"].HeaderText = "Από";
            dgv.Columns["dataGridViewTextBoxColumn6"].Width = 70;

            dgv.Columns["To"].HeaderText = "";
            dgv.Columns["To"].Width = 70;

            dgv.Columns["dataGridViewTextBoxColumn7"].HeaderText = "Έως";
            dgv.Columns["dataGridViewTextBoxColumn7"].Width = 70;

            dgv.Columns["dataGridViewTextBoxColumn8"].HeaderText = "Απασχόληση";
            dgv.Columns["dataGridViewTextBoxColumn8"].Width = 100;

            dgv.Columns["WorkDetails"].HeaderText = "Περιγραφή";
            dgv.Columns["WorkDetails"].Width = 70;

            dgv.Columns["WorkActions"].HeaderText = "Εργασίες";
            dgv.Columns["WorkActions"].Width = 70;
            dgv.Columns["WorkActions"].Visible = false;

        }

        private void tblActivityWorksDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value == System.DBNull.Value)
            {
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value = this.practID;
            }
        }

        private void tblActivityWorksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SaveData();
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == dgv.Columns["WorkActions"].Index)
                {
                    frmWorkActions frm = new frmWorkActions();
                    frm.actwrkID = Convert.ToInt16(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                    frm.Show();
                }
                else if (e.ColumnIndex == dgv.Columns["WorkDetails"].Index)
                {
                    frmActivityWorkDetails frm = new frmActivityWorkDetails();
                    frm.actwrkID = Convert.ToInt16(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                    frm.actwrkDesc = dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value.ToString() + "-" + dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                    frm.Show();
                }
            }
        }

        private void SaveData()
        {
            this.Validate();
            this.tblActivityWorksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);
        }
    }
}
