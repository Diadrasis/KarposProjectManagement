namespace BEAProjectManagement
{
    partial class rptProjectActivities
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptProjectActivitiesDesignBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beaDBDataSet = new BEAProjectManagement.beaDBDataSet();
            this.rptProjectDesign2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptProjectActivitiesDesignTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.rptProjectActivitiesDesignTableAdapter();
            this.rptProjectDesign2TableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.rptProjectDesign2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rptProjectActivitiesDesignBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptProjectDesign2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptProjectActivitiesDesignBindingSource
            // 
            this.rptProjectActivitiesDesignBindingSource.DataMember = "rptProjectActivitiesDesign";
            this.rptProjectActivitiesDesignBindingSource.DataSource = this.beaDBDataSet;
            // 
            // beaDBDataSet
            // 
            this.beaDBDataSet.DataSetName = "beaDBDataSet";
            this.beaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptProjectDesign2BindingSource
            // 
            this.rptProjectDesign2BindingSource.DataMember = "rptProjectDesign2";
            this.rptProjectDesign2BindingSource.DataSource = this.beaDBDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsProjectActivitiesDesign";
            reportDataSource1.Value = this.rptProjectActivitiesDesignBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.rptProjectDesign2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BEAProjectManagement.rptProjectActivities.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(955, 367);
            this.reportViewer1.TabIndex = 0;
            // 
            // rptProjectActivitiesDesignTableAdapter
            // 
            this.rptProjectActivitiesDesignTableAdapter.ClearBeforeFill = true;
            // 
            // rptProjectDesign2TableAdapter
            // 
            this.rptProjectDesign2TableAdapter.ClearBeforeFill = true;
            // 
            // rptProjectActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 367);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptProjectActivities";
            this.Text = "rptProjectActivities";
            this.Load += new System.EventHandler(this.rptProjectActivities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rptProjectActivitiesDesignBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptProjectDesign2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rptProjectActivitiesDesignBindingSource;
        private beaDBDataSet beaDBDataSet;
        private beaDBDataSetTableAdapters.rptProjectActivitiesDesignTableAdapter rptProjectActivitiesDesignTableAdapter;
        private System.Windows.Forms.BindingSource rptProjectDesign2BindingSource;
        private beaDBDataSetTableAdapters.rptProjectDesign2TableAdapter rptProjectDesign2TableAdapter;
    }
}