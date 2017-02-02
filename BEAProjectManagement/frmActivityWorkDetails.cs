using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmActivityWorkDetails : BEAProjectManagement.frmTemplate
    {
        public int actwrkID;
        public string actwrkDesc;

        public frmActivityWorkDetails()
        {
            InitializeComponent();
        }

        private void tblActivityWorkByIDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblActivityWorkByIDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);

        }      

        private void frmActivityWorkDetails_Load(object sender, EventArgs e)
        {
            this.lblDescription.Text = this.actwrkDesc;

            try
            {
                this.tblActivityWorkByIDTableAdapter.Fill(this.beaDBDataSet.tblActivityWorkByID, actwrkID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
