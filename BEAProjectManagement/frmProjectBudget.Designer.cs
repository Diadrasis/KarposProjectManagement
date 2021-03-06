﻿namespace BEAProjectManagement
{
    partial class frmProjectBudget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectBudget));
            this.beaDBDataSet = new BEAProjectManagement.beaDBDataSet();
            this.tblProjectBudgetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProjectBudgetTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.tblProjectBudgetTableAdapter();
            this.tableAdapterManager = new BEAProjectManagement.beaDBDataSetTableAdapters.TableAdapterManager();
            this.tblProjectBudgetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblProjectBudgetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblProjectBudgetDataGridView = new System.Windows.Forms.DataGridView();
            this.lblCurrentProject = new System.Windows.Forms.Label();
            this.vCostTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vCostTypesTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.vCostTypesTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectBudgetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectBudgetBindingNavigator)).BeginInit();
            this.tblProjectBudgetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectBudgetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCostTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // beaDBDataSet
            // 
            this.beaDBDataSet.DataSetName = "beaDBDataSet";
            this.beaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProjectBudgetBindingSource
            // 
            this.tblProjectBudgetBindingSource.DataMember = "tblProjectBudget";
            this.tblProjectBudgetBindingSource.DataSource = this.beaDBDataSet;
            // 
            // tblProjectBudgetTableAdapter
            // 
            this.tblProjectBudgetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblActivityTeamTableAdapter = null;
            this.tableAdapterManager.tblActivityWorkByIDTableAdapter = null;
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
            this.tableAdapterManager.tblProjectBudgetTableAdapter = this.tblProjectBudgetTableAdapter;
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
            // tblProjectBudgetBindingNavigator
            // 
            this.tblProjectBudgetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblProjectBudgetBindingNavigator.BindingSource = this.tblProjectBudgetBindingSource;
            this.tblProjectBudgetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblProjectBudgetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblProjectBudgetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblProjectBudgetBindingNavigatorSaveItem});
            this.tblProjectBudgetBindingNavigator.Location = new System.Drawing.Point(0, 90);
            this.tblProjectBudgetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblProjectBudgetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblProjectBudgetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblProjectBudgetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblProjectBudgetBindingNavigator.Name = "tblProjectBudgetBindingNavigator";
            this.tblProjectBudgetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblProjectBudgetBindingNavigator.Size = new System.Drawing.Size(1008, 25);
            this.tblProjectBudgetBindingNavigator.TabIndex = 3;
            this.tblProjectBudgetBindingNavigator.Text = "bindingNavigator1";
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
            // tblProjectBudgetBindingNavigatorSaveItem
            // 
            this.tblProjectBudgetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblProjectBudgetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblProjectBudgetBindingNavigatorSaveItem.Image")));
            this.tblProjectBudgetBindingNavigatorSaveItem.Name = "tblProjectBudgetBindingNavigatorSaveItem";
            this.tblProjectBudgetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblProjectBudgetBindingNavigatorSaveItem.Text = "Save Data";
            this.tblProjectBudgetBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblProjectBudgetBindingNavigatorSaveItem_Click);
            // 
            // tblProjectBudgetDataGridView
            // 
            this.tblProjectBudgetDataGridView.AutoGenerateColumns = false;
            this.tblProjectBudgetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProjectBudgetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tblProjectBudgetDataGridView.DataSource = this.tblProjectBudgetBindingSource;
            this.tblProjectBudgetDataGridView.Location = new System.Drawing.Point(103, 179);
            this.tblProjectBudgetDataGridView.Name = "tblProjectBudgetDataGridView";
            this.tblProjectBudgetDataGridView.Size = new System.Drawing.Size(300, 220);
            this.tblProjectBudgetDataGridView.TabIndex = 5;
            // 
            // lblCurrentProject
            // 
            this.lblCurrentProject.AutoSize = true;
            this.lblCurrentProject.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCurrentProject.Location = new System.Drawing.Point(408, 96);
            this.lblCurrentProject.Name = "lblCurrentProject";
            this.lblCurrentProject.Size = new System.Drawing.Size(52, 19);
            this.lblCurrentProject.TabIndex = 7;
            this.lblCurrentProject.Text = "label2";
            // 
            // vCostTypesBindingSource
            // 
            this.vCostTypesBindingSource.DataMember = "vCostTypes";
            this.vCostTypesBindingSource.DataSource = this.beaDBDataSet;
            // 
            // vCostTypesTableAdapter
            // 
            this.vCostTypesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "projectBudgetID";
            this.dataGridViewTextBoxColumn1.HeaderText = "projectBudgetID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "projectID";
            this.dataGridViewTextBoxColumn2.HeaderText = "projectID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "costtypeID";
            this.dataGridViewTextBoxColumn3.DataSource = this.vCostTypesBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "costtypeName";
            this.dataGridViewTextBoxColumn3.HeaderText = "costtypeID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "costtypeID";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "costDescription";
            this.dataGridViewTextBoxColumn4.HeaderText = "costDescription";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "costDescription2";
            this.dataGridViewTextBoxColumn5.HeaderText = "costDescription2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "costUnitAmount";
            this.dataGridViewTextBoxColumn6.HeaderText = "costUnitAmount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "costUnitType";
            this.dataGridViewTextBoxColumn7.HeaderText = "costUnitType";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "costUnitNo";
            this.dataGridViewTextBoxColumn8.HeaderText = "costUnitNo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // frmProjectBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 573);
            this.Controls.Add(this.lblCurrentProject);
            this.Controls.Add(this.tblProjectBudgetDataGridView);
            this.Controls.Add(this.tblProjectBudgetBindingNavigator);
            this.Name = "frmProjectBudget";
            this.Load += new System.EventHandler(this.frmProjectBudget_Load);
            this.Controls.SetChildIndex(this.tblProjectBudgetBindingNavigator, 0);
            this.Controls.SetChildIndex(this.tblProjectBudgetDataGridView, 0);
            this.Controls.SetChildIndex(this.lblCurrentProject, 0);
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectBudgetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectBudgetBindingNavigator)).EndInit();
            this.tblProjectBudgetBindingNavigator.ResumeLayout(false);
            this.tblProjectBudgetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectBudgetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCostTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private beaDBDataSet beaDBDataSet;
        private System.Windows.Forms.BindingSource tblProjectBudgetBindingSource;
        private beaDBDataSetTableAdapters.tblProjectBudgetTableAdapter tblProjectBudgetTableAdapter;
        private beaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblProjectBudgetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblProjectBudgetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblProjectBudgetDataGridView;
        private System.Windows.Forms.Label lblCurrentProject;
        private System.Windows.Forms.BindingSource vCostTypesBindingSource;
        private beaDBDataSetTableAdapters.vCostTypesTableAdapter vCostTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}
