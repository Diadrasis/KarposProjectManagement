namespace BEAProjectManagement
{
    partial class frmActivityWorks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivityWorks));
            this.beaDBDataSet = new BEAProjectManagement.beaDBDataSet();
            this.tblActivityWorksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblActivityWorksTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.tblActivityWorksTableAdapter();
            this.tableAdapterManager = new BEAProjectManagement.beaDBDataSetTableAdapters.TableAdapterManager();
            this.tblActivityWorksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblActivityWorksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblActivityWorksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkActions = new System.Windows.Forms.DataGridViewImageColumn();
            this.WorkDetails = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActivityWorksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActivityWorksBindingNavigator)).BeginInit();
            this.tblActivityWorksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblActivityWorksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // beaDBDataSet
            // 
            this.beaDBDataSet.DataSetName = "beaDBDataSet";
            this.beaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblActivityWorksBindingSource
            // 
            this.tblActivityWorksBindingSource.DataMember = "tblActivityWorks";
            this.tblActivityWorksBindingSource.DataSource = this.beaDBDataSet;
            // 
            // tblActivityWorksTableAdapter
            // 
            this.tblActivityWorksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblActivityTeamTableAdapter = null;
            this.tableAdapterManager.tblActivityWorkByIDTableAdapter = null;
            this.tableAdapterManager.tblActivityWorksTableAdapter = this.tblActivityWorksTableAdapter;
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
            // tblActivityWorksBindingNavigator
            // 
            this.tblActivityWorksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblActivityWorksBindingNavigator.BindingSource = this.tblActivityWorksBindingSource;
            this.tblActivityWorksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblActivityWorksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblActivityWorksBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tblActivityWorksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblActivityWorksBindingNavigatorSaveItem});
            this.tblActivityWorksBindingNavigator.Location = new System.Drawing.Point(9, 102);
            this.tblActivityWorksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblActivityWorksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblActivityWorksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblActivityWorksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblActivityWorksBindingNavigator.Name = "tblActivityWorksBindingNavigator";
            this.tblActivityWorksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblActivityWorksBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.tblActivityWorksBindingNavigator.TabIndex = 3;
            this.tblActivityWorksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblActivityWorksBindingNavigatorSaveItem
            // 
            this.tblActivityWorksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblActivityWorksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblActivityWorksBindingNavigatorSaveItem.Image")));
            this.tblActivityWorksBindingNavigatorSaveItem.Name = "tblActivityWorksBindingNavigatorSaveItem";
            this.tblActivityWorksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblActivityWorksBindingNavigatorSaveItem.Text = "Save Data";
            this.tblActivityWorksBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblActivityWorksBindingNavigatorSaveItem_Click);
            // 
            // tblActivityWorksDataGridView
            // 
            this.tblActivityWorksDataGridView.AutoGenerateColumns = false;
            this.tblActivityWorksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblActivityWorksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.From,
            this.dataGridViewTextBoxColumn6,
            this.To,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.WorkActions,
            this.WorkDetails});
            this.tblActivityWorksDataGridView.DataSource = this.tblActivityWorksBindingSource;
            this.tblActivityWorksDataGridView.Location = new System.Drawing.Point(40, 152);
            this.tblActivityWorksDataGridView.MultiSelect = false;
            this.tblActivityWorksDataGridView.Name = "tblActivityWorksDataGridView";
            this.tblActivityWorksDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tblActivityWorksDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tblActivityWorksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblActivityWorksDataGridView.Size = new System.Drawing.Size(562, 220);
            this.tblActivityWorksDataGridView.TabIndex = 5;
            this.tblActivityWorksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblActivityWorksDataGridView_CellContentClick);
            this.tblActivityWorksDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblActivityWorksDataGridView_RowValidated);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "actwrkID";
            this.dataGridViewTextBoxColumn1.HeaderText = "actwrkID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "practID";
            this.dataGridViewTextBoxColumn2.HeaderText = "practID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "actwrkCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "actwrkCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "actwrkTitle";
            this.dataGridViewTextBoxColumn4.HeaderText = "actwrkTitle";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "actwrkDesc";
            this.dataGridViewTextBoxColumn5.HeaderText = "actwrkDesc";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // From
            // 
            this.From.HeaderText = "From";
            this.From.Image = global::BEAProjectManagement.Properties.Resources.calendar4;
            this.From.Name = "From";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "actwrkStart";
            this.dataGridViewTextBoxColumn6.HeaderText = "actwrkStart";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // To
            // 
            this.To.HeaderText = "To";
            this.To.Image = global::BEAProjectManagement.Properties.Resources.calendar4;
            this.To.Name = "To";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "actwrkFinish";
            this.dataGridViewTextBoxColumn7.HeaderText = "actwrkFinish";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "actwrkWorkBudget";
            this.dataGridViewTextBoxColumn8.HeaderText = "actwrkWorkBudget";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // WorkActions
            // 
            this.WorkActions.HeaderText = "Work";
            this.WorkActions.Image = global::BEAProjectManagement.Properties.Resources.process;
            this.WorkActions.Name = "WorkActions";
            // 
            // WorkDetails
            // 
            this.WorkDetails.HeaderText = "WorkDetails";
            this.WorkDetails.Image = global::BEAProjectManagement.Properties.Resources.details;
            this.WorkDetails.Name = "WorkDetails";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblDescription.Location = new System.Drawing.Point(351, 108);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(101, 19);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "lblDescription";
            // 
            // frmActivityWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 573);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tblActivityWorksDataGridView);
            this.Controls.Add(this.tblActivityWorksBindingNavigator);
            this.Name = "frmActivityWorks";
            this.Load += new System.EventHandler(this.frmActivityWorks_Load);
            this.Controls.SetChildIndex(this.tblActivityWorksBindingNavigator, 0);
            this.Controls.SetChildIndex(this.tblActivityWorksDataGridView, 0);
            this.Controls.SetChildIndex(this.lblDescription, 0);
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActivityWorksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActivityWorksBindingNavigator)).EndInit();
            this.tblActivityWorksBindingNavigator.ResumeLayout(false);
            this.tblActivityWorksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblActivityWorksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private beaDBDataSet beaDBDataSet;
        private System.Windows.Forms.BindingSource tblActivityWorksBindingSource;
        private beaDBDataSetTableAdapters.tblActivityWorksTableAdapter tblActivityWorksTableAdapter;
        private beaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblActivityWorksBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblActivityWorksBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblActivityWorksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewImageColumn WorkActions;
        private System.Windows.Forms.DataGridViewImageColumn WorkDetails;
        private System.Windows.Forms.Label lblDescription;
    }
}
