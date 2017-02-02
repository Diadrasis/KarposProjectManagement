namespace BEAProjectManagement
{
    partial class frmUser
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
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label userFirstNameLabel;
            System.Windows.Forms.Label userSurnameLabel;
            System.Windows.Forms.Label userPasswordLabel;
            System.Windows.Forms.Label userRoleIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.beaDBDataSet = new BEAProjectManagement.beaDBDataSet();
            this.tblUsersByIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsers1TableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.tblUsers1TableAdapter();
            this.tableAdapterManager = new BEAProjectManagement.beaDBDataSetTableAdapters.TableAdapterManager();
            this.tblUsersByIDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tblUsersByIDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.userSurnameTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.userRoleIDComboBox = new System.Windows.Forms.ComboBox();
            this.vUserRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vUserRolesTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.vUserRolesTableAdapter();
            userIDLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            userFirstNameLabel = new System.Windows.Forms.Label();
            userSurnameLabel = new System.Windows.Forms.Label();
            userPasswordLabel = new System.Windows.Forms.Label();
            userRoleIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersByIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersByIDBindingNavigator)).BeginInit();
            this.tblUsersByIDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vUserRolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userIDLabel
            // 
            userIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(370, 173);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(44, 13);
            userIDLabel.TabIndex = 5;
            userIDLabel.Text = "user ID:";
            userIDLabel.Visible = false;
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            userNameLabel.Location = new System.Drawing.Point(331, 197);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(116, 19);
            userNameLabel.TabIndex = 7;
            userNameLabel.Text = "Όνομα Χρήστη:";
            // 
            // userFirstNameLabel
            // 
            userFirstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            userFirstNameLabel.AutoSize = true;
            userFirstNameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            userFirstNameLabel.Location = new System.Drawing.Point(383, 227);
            userFirstNameLabel.Name = "userFirstNameLabel";
            userFirstNameLabel.Size = new System.Drawing.Size(61, 19);
            userFirstNameLabel.TabIndex = 9;
            userFirstNameLabel.Text = "Όνομα:";
            // 
            // userSurnameLabel
            // 
            userSurnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            userSurnameLabel.AutoSize = true;
            userSurnameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            userSurnameLabel.Location = new System.Drawing.Point(369, 257);
            userSurnameLabel.Name = "userSurnameLabel";
            userSurnameLabel.Size = new System.Drawing.Size(76, 19);
            userSurnameLabel.TabIndex = 11;
            userSurnameLabel.Text = "Επώνυμο:";
            // 
            // userPasswordLabel
            // 
            userPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            userPasswordLabel.AutoSize = true;
            userPasswordLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            userPasswordLabel.Location = new System.Drawing.Point(376, 287);
            userPasswordLabel.Name = "userPasswordLabel";
            userPasswordLabel.Size = new System.Drawing.Size(68, 19);
            userPasswordLabel.TabIndex = 13;
            userPasswordLabel.Text = "Κωδικός:";
            // 
            // userRoleIDLabel
            // 
            userRoleIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            userRoleIDLabel.AutoSize = true;
            userRoleIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            userRoleIDLabel.Location = new System.Drawing.Point(384, 331);
            userRoleIDLabel.Name = "userRoleIDLabel";
            userRoleIDLabel.Size = new System.Drawing.Size(53, 17);
            userRoleIDLabel.TabIndex = 15;
            userRoleIDLabel.Text = "Ρόλος:";
            // 
            // beaDBDataSet
            // 
            this.beaDBDataSet.DataSetName = "beaDBDataSet";
            this.beaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersByIDBindingSource
            // 
            this.tblUsersByIDBindingSource.DataMember = "tblUsersByID";
            this.tblUsersByIDBindingSource.DataSource = this.beaDBDataSet;
            // 
            // tblUsers1TableAdapter
            // 
            this.tblUsers1TableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tblProjectActivitiesTableAdapter = null;
            this.tableAdapterManager.tblProjectRolesTableAdapter = null;
            this.tableAdapterManager.tblProjectsTableAdapter = null;
            this.tableAdapterManager.tblProjectTeamTableAdapter = null;
            this.tableAdapterManager.tblUserRolesTableAdapter = null;
            this.tableAdapterManager.tblUsers1TableAdapter = this.tblUsers1TableAdapter;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.tblWorkActionsTableAdapter = null;
            this.tableAdapterManager.tblYearsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BEAProjectManagement.beaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblUsersByIDBindingNavigator
            // 
            this.tblUsersByIDBindingNavigator.AddNewItem = null;
            this.tblUsersByIDBindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tblUsersByIDBindingNavigator.BindingSource = this.tblUsersByIDBindingSource;
            this.tblUsersByIDBindingNavigator.CountItem = null;
            this.tblUsersByIDBindingNavigator.DeleteItem = null;
            this.tblUsersByIDBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tblUsersByIDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tblUsersByIDBindingNavigatorSaveItem});
            this.tblUsersByIDBindingNavigator.Location = new System.Drawing.Point(459, 132);
            this.tblUsersByIDBindingNavigator.MoveFirstItem = null;
            this.tblUsersByIDBindingNavigator.MoveLastItem = null;
            this.tblUsersByIDBindingNavigator.MoveNextItem = null;
            this.tblUsersByIDBindingNavigator.MovePreviousItem = null;
            this.tblUsersByIDBindingNavigator.Name = "tblUsersByIDBindingNavigator";
            this.tblUsersByIDBindingNavigator.PositionItem = null;
            this.tblUsersByIDBindingNavigator.Size = new System.Drawing.Size(35, 25);
            this.tblUsersByIDBindingNavigator.TabIndex = 3;
            this.tblUsersByIDBindingNavigator.Text = "bindingNavigator1";
            // 
            // tblUsersByIDBindingNavigatorSaveItem
            // 
            this.tblUsersByIDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblUsersByIDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblUsersByIDBindingNavigatorSaveItem.Image")));
            this.tblUsersByIDBindingNavigatorSaveItem.Name = "tblUsersByIDBindingNavigatorSaveItem";
            this.tblUsersByIDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblUsersByIDBindingNavigatorSaveItem.Text = "Save Data";
            this.tblUsersByIDBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblUsersByIDBindingNavigatorSaveItem_Click_1);
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersByIDBindingSource, "userID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(459, 170);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.userIDTextBox.TabIndex = 6;
            this.userIDTextBox.Visible = false;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersByIDBindingSource, "userName", true));
            this.userNameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.userNameTextBox.Location = new System.Drawing.Point(459, 196);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(193, 23);
            this.userNameTextBox.TabIndex = 8;
            // 
            // userFirstNameTextBox
            // 
            this.userFirstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersByIDBindingSource, "userFirstName", true));
            this.userFirstNameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.userFirstNameTextBox.Location = new System.Drawing.Point(459, 227);
            this.userFirstNameTextBox.Name = "userFirstNameTextBox";
            this.userFirstNameTextBox.Size = new System.Drawing.Size(193, 23);
            this.userFirstNameTextBox.TabIndex = 10;
            // 
            // userSurnameTextBox
            // 
            this.userSurnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userSurnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersByIDBindingSource, "userSurname", true));
            this.userSurnameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.userSurnameTextBox.Location = new System.Drawing.Point(459, 258);
            this.userSurnameTextBox.Name = "userSurnameTextBox";
            this.userSurnameTextBox.Size = new System.Drawing.Size(193, 23);
            this.userSurnameTextBox.TabIndex = 12;
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersByIDBindingSource, "userPassword", true));
            this.userPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.userPasswordTextBox.Location = new System.Drawing.Point(459, 289);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(193, 23);
            this.userPasswordTextBox.TabIndex = 14;
            // 
            // userRoleIDComboBox
            // 
            this.userRoleIDComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userRoleIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblUsersByIDBindingSource, "userID", true));
            this.userRoleIDComboBox.DataSource = this.vUserRolesBindingSource;
            this.userRoleIDComboBox.DisplayMember = "userRoleName";
            this.userRoleIDComboBox.Enabled = false;
            this.userRoleIDComboBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.userRoleIDComboBox.FormattingEnabled = true;
            this.userRoleIDComboBox.Location = new System.Drawing.Point(459, 323);
            this.userRoleIDComboBox.Name = "userRoleIDComboBox";
            this.userRoleIDComboBox.Size = new System.Drawing.Size(193, 25);
            this.userRoleIDComboBox.TabIndex = 16;
            this.userRoleIDComboBox.ValueMember = "userRoleID";
            // 
            // vUserRolesBindingSource
            // 
            this.vUserRolesBindingSource.DataMember = "vUserRoles";
            this.vUserRolesBindingSource.DataSource = this.beaDBDataSet;
            // 
            // vUserRolesTableAdapter
            // 
            this.vUserRolesTableAdapter.ClearBeforeFill = true;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 433);
            this.Controls.Add(userIDLabel);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(userFirstNameLabel);
            this.Controls.Add(this.userFirstNameTextBox);
            this.Controls.Add(userSurnameLabel);
            this.Controls.Add(this.userSurnameTextBox);
            this.Controls.Add(userPasswordLabel);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(userRoleIDLabel);
            this.Controls.Add(this.userRoleIDComboBox);
            this.Controls.Add(this.tblUsersByIDBindingNavigator);
            this.Name = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.Controls.SetChildIndex(this.tblUsersByIDBindingNavigator, 0);
            this.Controls.SetChildIndex(this.userRoleIDComboBox, 0);
            this.Controls.SetChildIndex(userRoleIDLabel, 0);
            this.Controls.SetChildIndex(this.userPasswordTextBox, 0);
            this.Controls.SetChildIndex(userPasswordLabel, 0);
            this.Controls.SetChildIndex(this.userSurnameTextBox, 0);
            this.Controls.SetChildIndex(userSurnameLabel, 0);
            this.Controls.SetChildIndex(this.userFirstNameTextBox, 0);
            this.Controls.SetChildIndex(userFirstNameLabel, 0);
            this.Controls.SetChildIndex(this.userNameTextBox, 0);
            this.Controls.SetChildIndex(userNameLabel, 0);
            this.Controls.SetChildIndex(this.userIDTextBox, 0);
            this.Controls.SetChildIndex(userIDLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersByIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersByIDBindingNavigator)).EndInit();
            this.tblUsersByIDBindingNavigator.ResumeLayout(false);
            this.tblUsersByIDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vUserRolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private beaDBDataSet beaDBDataSet;
        private System.Windows.Forms.BindingSource tblUsersByIDBindingSource;
        private beaDBDataSetTableAdapters.tblUsers1TableAdapter tblUsers1TableAdapter;
        private beaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblUsersByIDBindingNavigator;
        private System.Windows.Forms.ToolStripButton tblUsersByIDBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox userFirstNameTextBox;
        private System.Windows.Forms.TextBox userSurnameTextBox;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.ComboBox userRoleIDComboBox;
        private System.Windows.Forms.BindingSource vUserRolesBindingSource;
        private beaDBDataSetTableAdapters.vUserRolesTableAdapter vUserRolesTableAdapter;
    }
}
