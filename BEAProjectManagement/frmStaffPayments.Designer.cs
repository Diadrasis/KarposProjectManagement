namespace BEAProjectManagement
{
    partial class frmStaffPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffPayments));
            this.beaDBDataSet = new BEAProjectManagement.beaDBDataSet();
            this.tblStaffPaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStaffPaymentsTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.tblStaffPaymentsTableAdapter();
            this.tableAdapterManager = new BEAProjectManagement.beaDBDataSetTableAdapters.TableAdapterManager();
            this.tblStaffPaymentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblStaffPaymentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.personIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.personIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tblStaffPaymentsDataGridView = new System.Windows.Forms.DataGridView();
            this.lblCurrentPerson = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.vStaffPaymentReasonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vStaffPaymentReasonsTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.vStaffPaymentReasonsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffPaymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffPaymentsBindingNavigator)).BeginInit();
            this.tblStaffPaymentsBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffPaymentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vStaffPaymentReasonsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // beaDBDataSet
            // 
            this.beaDBDataSet.DataSetName = "beaDBDataSet";
            this.beaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStaffPaymentsBindingSource
            // 
            this.tblStaffPaymentsBindingSource.DataMember = "tblStaffPayments";
            this.tblStaffPaymentsBindingSource.DataSource = this.beaDBDataSet;
            // 
            // tblStaffPaymentsTableAdapter
            // 
            this.tblStaffPaymentsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tblProjectBudgetTableAdapter = null;
            this.tableAdapterManager.tblProjectPaymentsTableAdapter = null;
            this.tableAdapterManager.tblProjectRolesTableAdapter = null;
            this.tableAdapterManager.tblProjectSpendigsTableAdapter = null;
            this.tableAdapterManager.tblProjectsTableAdapter = null;
            this.tableAdapterManager.tblProjectTeamTableAdapter = null;
            this.tableAdapterManager.tblStaffContractsTableAdapter = null;
            this.tableAdapterManager.tblStaffPaymentsTableAdapter = this.tblStaffPaymentsTableAdapter;
            this.tableAdapterManager.tblUserRolesTableAdapter = null;
            this.tableAdapterManager.tblUsers1TableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.tblWorkActionsTableAdapter = null;
            this.tableAdapterManager.tblYearsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BEAProjectManagement.beaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblStaffPaymentsBindingNavigator
            // 
            this.tblStaffPaymentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblStaffPaymentsBindingNavigator.BindingSource = this.tblStaffPaymentsBindingSource;
            this.tblStaffPaymentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblStaffPaymentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblStaffPaymentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblStaffPaymentsBindingNavigatorSaveItem});
            this.tblStaffPaymentsBindingNavigator.Location = new System.Drawing.Point(0, 90);
            this.tblStaffPaymentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblStaffPaymentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblStaffPaymentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblStaffPaymentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblStaffPaymentsBindingNavigator.Name = "tblStaffPaymentsBindingNavigator";
            this.tblStaffPaymentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblStaffPaymentsBindingNavigator.Size = new System.Drawing.Size(1008, 25);
            this.tblStaffPaymentsBindingNavigator.TabIndex = 3;
            this.tblStaffPaymentsBindingNavigator.Text = "bindingNavigator1";
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
            // tblStaffPaymentsBindingNavigatorSaveItem
            // 
            this.tblStaffPaymentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblStaffPaymentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblStaffPaymentsBindingNavigatorSaveItem.Image")));
            this.tblStaffPaymentsBindingNavigatorSaveItem.Name = "tblStaffPaymentsBindingNavigatorSaveItem";
            this.tblStaffPaymentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblStaffPaymentsBindingNavigatorSaveItem.Text = "Save Data";
            this.tblStaffPaymentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblStaffPaymentsBindingNavigatorSaveItem_Click);
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personIDToolStripLabel,
            this.personIDToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 115);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1008, 25);
            this.fillToolStrip.TabIndex = 4;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // personIDToolStripLabel
            // 
            this.personIDToolStripLabel.Name = "personIDToolStripLabel";
            this.personIDToolStripLabel.Size = new System.Drawing.Size(57, 22);
            this.personIDToolStripLabel.Text = "personID:";
            // 
            // personIDToolStripTextBox
            // 
            this.personIDToolStripTextBox.Name = "personIDToolStripTextBox";
            this.personIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // tblStaffPaymentsDataGridView
            // 
            this.tblStaffPaymentsDataGridView.AutoGenerateColumns = false;
            this.tblStaffPaymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblStaffPaymentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.colDate,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tblStaffPaymentsDataGridView.DataSource = this.tblStaffPaymentsBindingSource;
            this.tblStaffPaymentsDataGridView.Location = new System.Drawing.Point(83, 161);
            this.tblStaffPaymentsDataGridView.Name = "tblStaffPaymentsDataGridView";
            this.tblStaffPaymentsDataGridView.Size = new System.Drawing.Size(300, 220);
            this.tblStaffPaymentsDataGridView.TabIndex = 5;
            this.tblStaffPaymentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblStaffPaymentsDataGridView_CellContentClick);
            this.tblStaffPaymentsDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblStaffPaymentsDataGridView_RowValidated);
            // 
            // lblCurrentPerson
            // 
            this.lblCurrentPerson.AutoSize = true;
            this.lblCurrentPerson.Location = new System.Drawing.Point(425, 97);
            this.lblCurrentPerson.Name = "lblCurrentPerson";
            this.lblCurrentPerson.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentPerson.TabIndex = 6;
            this.lblCurrentPerson.Text = "label2";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(281, 236);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // vStaffPaymentReasonsBindingSource
            // 
            this.vStaffPaymentReasonsBindingSource.DataMember = "vStaffPaymentReasons";
            this.vStaffPaymentReasonsBindingSource.DataSource = this.beaDBDataSet;
            // 
            // vStaffPaymentReasonsTableAdapter
            // 
            this.vStaffPaymentReasonsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "staffPaymentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "staffPaymentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "personID";
            this.dataGridViewTextBoxColumn2.HeaderText = "personID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // colDate
            // 
            this.colDate.HeaderText = "colDate";
            this.colDate.Image = global::BEAProjectManagement.Properties.Resources.calendar;
            this.colDate.Name = "colDate";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "staffPaymentDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "staffPaymentDate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "staffPaymentReasonID";
            this.dataGridViewTextBoxColumn3.DataSource = this.vStaffPaymentReasonsBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "staffPaymentReasonDescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "staffPaymentReasonID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "staffPaymentReasonID";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "staffPaymentAmount";
            this.dataGridViewTextBoxColumn4.HeaderText = "staffPaymentAmount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "staffPaymentEmployeeContribution";
            this.dataGridViewTextBoxColumn5.HeaderText = "staffPaymentEmployeeContribution";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // frmStaffPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 573);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblCurrentPerson);
            this.Controls.Add(this.tblStaffPaymentsDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.tblStaffPaymentsBindingNavigator);
            this.Name = "frmStaffPayments";
            this.Load += new System.EventHandler(this.frmStaffPayments_Load);
            this.Controls.SetChildIndex(this.tblStaffPaymentsBindingNavigator, 0);
            this.Controls.SetChildIndex(this.fillToolStrip, 0);
            this.Controls.SetChildIndex(this.tblStaffPaymentsDataGridView, 0);
            this.Controls.SetChildIndex(this.lblCurrentPerson, 0);
            this.Controls.SetChildIndex(this.monthCalendar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffPaymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffPaymentsBindingNavigator)).EndInit();
            this.tblStaffPaymentsBindingNavigator.ResumeLayout(false);
            this.tblStaffPaymentsBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffPaymentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vStaffPaymentReasonsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private beaDBDataSet beaDBDataSet;
        private System.Windows.Forms.BindingSource tblStaffPaymentsBindingSource;
        private beaDBDataSetTableAdapters.tblStaffPaymentsTableAdapter tblStaffPaymentsTableAdapter;
        private beaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblStaffPaymentsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblStaffPaymentsBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel personIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox personIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView tblStaffPaymentsDataGridView;
        private System.Windows.Forms.Label lblCurrentPerson;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.BindingSource vStaffPaymentReasonsBindingSource;
        private beaDBDataSetTableAdapters.vStaffPaymentReasonsTableAdapter vStaffPaymentReasonsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
