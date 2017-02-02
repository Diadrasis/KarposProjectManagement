namespace BEAProjectManagement
{
    partial class frmProjectActivities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectActivities));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblProjectActivitiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblProjectActivitiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblProjectActivitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.lblCurrentProject = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblRemainingBudget = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblProjectActivitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beaDBDataSet = new BEAProjectManagement.beaDBDataSet();
            this.tblProjectActivitiesTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.tblProjectActivitiesTableAdapter();
            this.tableAdapterManager = new BEAProjectManagement.beaDBDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.practCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFrom = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTo = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.practBudget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.practTeam = new System.Windows.Forms.DataGridViewImageColumn();
            this.Works = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectActivitiesBindingNavigator)).BeginInit();
            this.tblProjectActivitiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectActivitiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectActivitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblProjectActivitiesBindingNavigator
            // 
            this.tblProjectActivitiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblProjectActivitiesBindingNavigator.BindingSource = this.tblProjectActivitiesBindingSource;
            this.tblProjectActivitiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblProjectActivitiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblProjectActivitiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblProjectActivitiesBindingNavigatorSaveItem});
            this.tblProjectActivitiesBindingNavigator.Location = new System.Drawing.Point(0, 90);
            this.tblProjectActivitiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblProjectActivitiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblProjectActivitiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblProjectActivitiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblProjectActivitiesBindingNavigator.Name = "tblProjectActivitiesBindingNavigator";
            this.tblProjectActivitiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblProjectActivitiesBindingNavigator.Size = new System.Drawing.Size(1008, 25);
            this.tblProjectActivitiesBindingNavigator.TabIndex = 1;
            this.tblProjectActivitiesBindingNavigator.Text = "bindingNavigator1";
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
            // tblProjectActivitiesBindingNavigatorSaveItem
            // 
            this.tblProjectActivitiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblProjectActivitiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblProjectActivitiesBindingNavigatorSaveItem.Image")));
            this.tblProjectActivitiesBindingNavigatorSaveItem.Name = "tblProjectActivitiesBindingNavigatorSaveItem";
            this.tblProjectActivitiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblProjectActivitiesBindingNavigatorSaveItem.Text = "Save Data";
            this.tblProjectActivitiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblProjectActivitiesBindingNavigatorSaveItem_Click);
            // 
            // tblProjectActivitiesDataGridView
            // 
            this.tblProjectActivitiesDataGridView.AutoGenerateColumns = false;
            this.tblProjectActivitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProjectActivitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.practCode,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dateFrom,
            this.dataGridViewTextBoxColumn5,
            this.dateTo,
            this.dataGridViewTextBoxColumn6,
            this.practBudget,
            this.dataGridViewTextBoxColumn7,
            this.practTeam,
            this.Works});
            this.tblProjectActivitiesDataGridView.DataSource = this.tblProjectActivitiesBindingSource;
            this.tblProjectActivitiesDataGridView.Location = new System.Drawing.Point(102, 161);
            this.tblProjectActivitiesDataGridView.MultiSelect = false;
            this.tblProjectActivitiesDataGridView.Name = "tblProjectActivitiesDataGridView";
            this.tblProjectActivitiesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tblProjectActivitiesDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tblProjectActivitiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblProjectActivitiesDataGridView.Size = new System.Drawing.Size(540, 220);
            this.tblProjectActivitiesDataGridView.TabIndex = 3;
            this.tblProjectActivitiesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblProjectActivitiesDataGridView_CellContentClick);
            this.tblProjectActivitiesDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblProjectActivitiesDataGridView_RowValidated);
            // 
            // lblCurrentProject
            // 
            this.lblCurrentProject.AutoSize = true;
            this.lblCurrentProject.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCurrentProject.Location = new System.Drawing.Point(320, 97);
            this.lblCurrentProject.Name = "lblCurrentProject";
            this.lblCurrentProject.Size = new System.Drawing.Size(52, 19);
            this.lblCurrentProject.TabIndex = 4;
            this.lblCurrentProject.Text = "label2";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(622, 219);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 6;
            this.monthCalendar2.Visible = false;
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(391, 295);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // lblRemainingBudget
            // 
            this.lblRemainingBudget.AutoSize = true;
            this.lblRemainingBudget.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblRemainingBudget.Location = new System.Drawing.Point(805, 122);
            this.lblRemainingBudget.Name = "lblRemainingBudget";
            this.lblRemainingBudget.Size = new System.Drawing.Size(47, 17);
            this.lblRemainingBudget.TabIndex = 11;
            this.lblRemainingBudget.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(648, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblBudget.Location = new System.Drawing.Point(805, 99);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(47, 17);
            this.lblBudget.TabIndex = 9;
            this.lblBudget.Text = "label3";
            this.lblBudget.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(647, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // tblProjectActivitiesBindingSource
            // 
            this.tblProjectActivitiesBindingSource.DataMember = "tblProjectActivities";
            this.tblProjectActivitiesBindingSource.DataSource = this.beaDBDataSet;
            // 
            // beaDBDataSet
            // 
            this.beaDBDataSet.DataSetName = "beaDBDataSet";
            this.beaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProjectActivitiesTableAdapter
            // 
            this.tblProjectActivitiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblActivityTeamTableAdapter = null;
            this.tableAdapterManager.tblActivityWorksTableAdapter = null;
            this.tableAdapterManager.tblAvailabilityTableAdapter = null;
            this.tableAdapterManager.tblDepartmentsTableAdapter = null;
            this.tableAdapterManager.tblMonthsTableAdapter = null;
            this.tableAdapterManager.tblOccupationsTableAdapter = null;
            this.tableAdapterManager.tblPersonAvailabilityTableAdapter = null;
            this.tableAdapterManager.tblPersonCostTableAdapter = null;
            this.tableAdapterManager.tblPersonHourAvailabilityTableAdapter = null;
            this.tableAdapterManager.tblPersonsTableAdapter = null;
            this.tableAdapterManager.tblProjectActivitiesTableAdapter = this.tblProjectActivitiesTableAdapter;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "practID";
            this.dataGridViewTextBoxColumn1.HeaderText = "practID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "projID";
            this.dataGridViewTextBoxColumn2.HeaderText = "projID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // practCode
            // 
            this.practCode.DataPropertyName = "practCode";
            this.practCode.HeaderText = "practCode";
            this.practCode.Name = "practCode";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "practTitle";
            this.dataGridViewTextBoxColumn3.HeaderText = "practTitle";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "practDesc";
            this.dataGridViewTextBoxColumn4.HeaderText = "practDesc";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dateFrom
            // 
            this.dateFrom.HeaderText = "Column1";
            this.dateFrom.Image = global::BEAProjectManagement.Properties.Resources.calendar4;
            this.dateFrom.Name = "dateFrom";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "practStart";
            this.dataGridViewTextBoxColumn5.HeaderText = "practStart";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dateTo
            // 
            this.dateTo.HeaderText = "Column1";
            this.dateTo.Image = global::BEAProjectManagement.Properties.Resources.calendar4;
            this.dateTo.Name = "dateTo";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "practFinish";
            this.dataGridViewTextBoxColumn6.HeaderText = "practFinish";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // practBudget
            // 
            this.practBudget.DataPropertyName = "practBudget";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.practBudget.DefaultCellStyle = dataGridViewCellStyle1;
            this.practBudget.HeaderText = "practBudget";
            this.practBudget.Name = "practBudget";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "practWorkBudget";
            this.dataGridViewTextBoxColumn7.HeaderText = "practWorkBudget";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // practTeam
            // 
            this.practTeam.HeaderText = "Column1";
            this.practTeam.Image = global::BEAProjectManagement.Properties.Resources.users1;
            this.practTeam.Name = "practTeam";
            // 
            // Works
            // 
            this.Works.HeaderText = "Works";
            this.Works.Image = global::BEAProjectManagement.Properties.Resources.process;
            this.Works.Name = "Works";
            // 
            // frmProjectActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblRemainingBudget);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblCurrentProject);
            this.Controls.Add(this.tblProjectActivitiesDataGridView);
            this.Controls.Add(this.tblProjectActivitiesBindingNavigator);
            this.Name = "frmProjectActivities";
            this.Load += new System.EventHandler(this.frmProjectActivities_Load);
            this.Controls.SetChildIndex(this.tblProjectActivitiesBindingNavigator, 0);
            this.Controls.SetChildIndex(this.tblProjectActivitiesDataGridView, 0);
            this.Controls.SetChildIndex(this.lblCurrentProject, 0);
            this.Controls.SetChildIndex(this.monthCalendar1, 0);
            this.Controls.SetChildIndex(this.monthCalendar2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblBudget, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lblRemainingBudget, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectActivitiesBindingNavigator)).EndInit();
            this.tblProjectActivitiesBindingNavigator.ResumeLayout(false);
            this.tblProjectActivitiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectActivitiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectActivitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private beaDBDataSet beaDBDataSet;
        private System.Windows.Forms.BindingSource tblProjectActivitiesBindingSource;
        private beaDBDataSetTableAdapters.tblProjectActivitiesTableAdapter tblProjectActivitiesTableAdapter;
        private beaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblProjectActivitiesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblProjectActivitiesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblProjectActivitiesDataGridView;
        private System.Windows.Forms.Label lblCurrentProject;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblRemainingBudget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn practCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn practBudget;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn practTeam;
        private System.Windows.Forms.DataGridViewImageColumn Works;
    }
}
