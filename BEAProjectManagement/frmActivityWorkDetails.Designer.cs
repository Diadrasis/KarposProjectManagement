namespace BEAProjectManagement
{
    partial class frmActivityWorkDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label actwrkIDLabel;
            System.Windows.Forms.Label actwrkDescLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivityWorkDetails));
            this.beaDBDataSet = new BEAProjectManagement.beaDBDataSet();
            this.tblActivityWorkByIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblActivityWorkByIDTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.tblActivityWorkByIDTableAdapter();
            this.tableAdapterManager = new BEAProjectManagement.beaDBDataSetTableAdapters.TableAdapterManager();
            this.tblActivityWorkByIDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tblActivityWorkByIDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.actwrkIDTextBox = new System.Windows.Forms.TextBox();
            this.actwrkDescTextBox = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            actwrkIDLabel = new System.Windows.Forms.Label();
            actwrkDescLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActivityWorkByIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActivityWorkByIDBindingNavigator)).BeginInit();
            this.tblActivityWorkByIDBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // actwrkIDLabel
            // 
            actwrkIDLabel.AutoSize = true;
            actwrkIDLabel.Location = new System.Drawing.Point(12, 115);
            actwrkIDLabel.Name = "actwrkIDLabel";
            actwrkIDLabel.Size = new System.Drawing.Size(56, 13);
            actwrkIDLabel.TabIndex = 5;
            actwrkIDLabel.Text = "actwrk ID:";
            actwrkIDLabel.Visible = false;
            // 
            // actwrkDescLabel
            // 
            actwrkDescLabel.AutoSize = true;
            actwrkDescLabel.Location = new System.Drawing.Point(27, 169);
            actwrkDescLabel.Name = "actwrkDescLabel";
            actwrkDescLabel.Size = new System.Drawing.Size(65, 13);
            actwrkDescLabel.TabIndex = 13;
            actwrkDescLabel.Text = "Περιγραφή:";
            // 
            // beaDBDataSet
            // 
            this.beaDBDataSet.DataSetName = "beaDBDataSet";
            this.beaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblActivityWorkByIDBindingSource
            // 
            this.tblActivityWorkByIDBindingSource.DataMember = "tblActivityWorkByID";
            this.tblActivityWorkByIDBindingSource.DataSource = this.beaDBDataSet;
            // 
            // tblActivityWorkByIDTableAdapter
            // 
            this.tblActivityWorkByIDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblActivityTeamTableAdapter = null;
            this.tableAdapterManager.tblActivityWorkByIDTableAdapter = this.tblActivityWorkByIDTableAdapter;
            this.tableAdapterManager.tblActivityWorksTableAdapter = null;
            this.tableAdapterManager.tblAvailabilityTableAdapter = null;
            this.tableAdapterManager.tblDepartmentsTableAdapter = null;
            this.tableAdapterManager.tblMonthsTableAdapter = null;
            this.tableAdapterManager.tblOccupationsTableAdapter = null;
            this.tableAdapterManager.tblPersonAvailabilityTableAdapter = null;
            this.tableAdapterManager.tblPersonCostTableAdapter = null;
            this.tableAdapterManager.tblPersonHourAvailabilityTableAdapter = null;
            this.tableAdapterManager.tblPersonsTableAdapter = null;
            this.tableAdapterManager.tblProjectActivitiesTableAdapter = null;
            this.tableAdapterManager.tblProjectRolesTableAdapter = null;
            this.tableAdapterManager.tblProjectsTableAdapter = null;
            this.tableAdapterManager.tblProjectTeamTableAdapter = null;
            this.tableAdapterManager.tblUserRolesTableAdapter = null;
            this.tableAdapterManager.tblUsers1TableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.tblWorkActionsTableAdapter = null;
            this.tableAdapterManager.tblYearsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BEAProjectManagement.beaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblActivityWorkByIDBindingNavigator
            // 
            this.tblActivityWorkByIDBindingNavigator.AddNewItem = null;
            this.tblActivityWorkByIDBindingNavigator.BindingSource = this.tblActivityWorkByIDBindingSource;
            this.tblActivityWorkByIDBindingNavigator.CountItem = null;
            this.tblActivityWorkByIDBindingNavigator.DeleteItem = null;
            this.tblActivityWorkByIDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tblActivityWorkByIDBindingNavigatorSaveItem});
            this.tblActivityWorkByIDBindingNavigator.Location = new System.Drawing.Point(0, 90);
            this.tblActivityWorkByIDBindingNavigator.MoveFirstItem = null;
            this.tblActivityWorkByIDBindingNavigator.MoveLastItem = null;
            this.tblActivityWorkByIDBindingNavigator.MoveNextItem = null;
            this.tblActivityWorkByIDBindingNavigator.MovePreviousItem = null;
            this.tblActivityWorkByIDBindingNavigator.Name = "tblActivityWorkByIDBindingNavigator";
            this.tblActivityWorkByIDBindingNavigator.PositionItem = null;
            this.tblActivityWorkByIDBindingNavigator.Size = new System.Drawing.Size(546, 25);
            this.tblActivityWorkByIDBindingNavigator.TabIndex = 3;
            this.tblActivityWorkByIDBindingNavigator.Text = "bindingNavigator1";
            // 
            // tblActivityWorkByIDBindingNavigatorSaveItem
            // 
            this.tblActivityWorkByIDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblActivityWorkByIDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblActivityWorkByIDBindingNavigatorSaveItem.Image")));
            this.tblActivityWorkByIDBindingNavigatorSaveItem.Name = "tblActivityWorkByIDBindingNavigatorSaveItem";
            this.tblActivityWorkByIDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblActivityWorkByIDBindingNavigatorSaveItem.Text = "Save Data";
            this.tblActivityWorkByIDBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblActivityWorkByIDBindingNavigatorSaveItem_Click);
            // 
            // actwrkIDTextBox
            // 
            this.actwrkIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblActivityWorkByIDBindingSource, "actwrkID", true));
            this.actwrkIDTextBox.Location = new System.Drawing.Point(12, 131);
            this.actwrkIDTextBox.Name = "actwrkIDTextBox";
            this.actwrkIDTextBox.Size = new System.Drawing.Size(74, 20);
            this.actwrkIDTextBox.TabIndex = 6;
            this.actwrkIDTextBox.Visible = false;
            // 
            // actwrkDescTextBox
            // 
            this.actwrkDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblActivityWorkByIDBindingSource, "actwrkDesc", true));
            this.actwrkDescTextBox.Location = new System.Drawing.Point(139, 166);
            this.actwrkDescTextBox.Multiline = true;
            this.actwrkDescTextBox.Name = "actwrkDescTextBox";
            this.actwrkDescTextBox.Size = new System.Drawing.Size(352, 115);
            this.actwrkDescTextBox.TabIndex = 14;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblDescription.Location = new System.Drawing.Point(135, 112);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(101, 19);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "lblDescription";
            // 
            // frmActivityWorkDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(546, 306);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(actwrkIDLabel);
            this.Controls.Add(this.actwrkIDTextBox);
            this.Controls.Add(actwrkDescLabel);
            this.Controls.Add(this.actwrkDescTextBox);
            this.Controls.Add(this.tblActivityWorkByIDBindingNavigator);
            this.Name = "frmActivityWorkDetails";
            this.Load += new System.EventHandler(this.frmActivityWorkDetails_Load);
            this.Controls.SetChildIndex(this.tblActivityWorkByIDBindingNavigator, 0);
            this.Controls.SetChildIndex(this.actwrkDescTextBox, 0);
            this.Controls.SetChildIndex(actwrkDescLabel, 0);
            this.Controls.SetChildIndex(this.actwrkIDTextBox, 0);
            this.Controls.SetChildIndex(actwrkIDLabel, 0);
            this.Controls.SetChildIndex(this.lblDescription, 0);
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActivityWorkByIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActivityWorkByIDBindingNavigator)).EndInit();
            this.tblActivityWorkByIDBindingNavigator.ResumeLayout(false);
            this.tblActivityWorkByIDBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private beaDBDataSet beaDBDataSet;
        private System.Windows.Forms.BindingSource tblActivityWorkByIDBindingSource;
        private beaDBDataSetTableAdapters.tblActivityWorkByIDTableAdapter tblActivityWorkByIDTableAdapter;
        private beaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblActivityWorkByIDBindingNavigator;
        private System.Windows.Forms.ToolStripButton tblActivityWorkByIDBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox actwrkIDTextBox;
        private System.Windows.Forms.TextBox actwrkDescTextBox;
        private System.Windows.Forms.Label lblDescription;
    }
}
