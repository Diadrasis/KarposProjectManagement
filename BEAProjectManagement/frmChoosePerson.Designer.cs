namespace BEAProjectManagement
{
    partial class frmChoosePerson
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vPersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beaDBDataSet = new BEAProjectManagement.beaDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.vPersonsTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.vPersonsTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tblYearsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beaDBDataSet2 = new BEAProjectManagement.beaDBDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tblMonthsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beaDBDataSet1 = new BEAProjectManagement.beaDBDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tblMonthsTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.tblMonthsTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tblYearsTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.tblYearsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vPersonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYearsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonthsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.vPersonsBindingSource;
            this.comboBox1.DisplayMember = "personName";
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 25);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "personID";
            // 
            // vPersonsBindingSource
            // 
            this.vPersonsBindingSource.DataMember = "vPersons";
            this.vPersonsBindingSource.DataSource = this.beaDBDataSet;
            // 
            // beaDBDataSet
            // 
            this.beaDBDataSet.DataSetName = "beaDBDataSet";
            this.beaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Εργαζόμενος";
            // 
            // vPersonsTableAdapter
            // 
            this.vPersonsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tblYearsBindingSource;
            this.comboBox2.DisplayMember = "yearNo";
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(58, 100);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(94, 25);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "yearNo";
            // 
            // tblYearsBindingSource
            // 
            this.tblYearsBindingSource.DataMember = "tblYears";
            this.tblYearsBindingSource.DataSource = this.beaDBDataSet2;
            // 
            // beaDBDataSet2
            // 
            this.beaDBDataSet2.DataSetName = "beaDBDataSet";
            this.beaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(63, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Έτος";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(186, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Μήνας";
            // 
            // tblMonthsBindingSource
            // 
            this.tblMonthsBindingSource.DataMember = "tblMonths";
            this.tblMonthsBindingSource.DataSource = this.beaDBDataSet1;
            // 
            // beaDBDataSet1
            // 
            this.beaDBDataSet1.DataSetName = "beaDBDataSet";
            this.beaDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Image = global::BEAProjectManagement.Properties.Resources.undo;
            this.button2.Location = new System.Drawing.Point(237, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::BEAProjectManagement.Properties.Resources.ok;
            this.button1.Location = new System.Drawing.Point(58, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblMonthsTableAdapter
            // 
            this.tblMonthsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.tblMonthsBindingSource;
            this.comboBox3.DisplayMember = "monthName";
            this.comboBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(189, 100);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(123, 25);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.ValueMember = "monthNo";
            // 
            // tblYearsTableAdapter
            // 
            this.tblYearsTableAdapter.ClearBeforeFill = true;
            // 
            // frmChoosePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 206);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmChoosePerson";
            this.Text = "frmChoosePerson";
            this.Load += new System.EventHandler(this.frmChoosePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vPersonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYearsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonthsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private beaDBDataSet beaDBDataSet;
        private System.Windows.Forms.BindingSource vPersonsBindingSource;
        private beaDBDataSetTableAdapters.vPersonsTableAdapter vPersonsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private beaDBDataSet beaDBDataSet1;
        private System.Windows.Forms.BindingSource tblMonthsBindingSource;
        private beaDBDataSetTableAdapters.tblMonthsTableAdapter tblMonthsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private beaDBDataSet beaDBDataSet2;
        private System.Windows.Forms.BindingSource tblYearsBindingSource;
        private beaDBDataSetTableAdapters.tblYearsTableAdapter tblYearsTableAdapter;
    }
}