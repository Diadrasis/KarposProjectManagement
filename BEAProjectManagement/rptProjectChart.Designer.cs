namespace BEAProjectManagement
{
    partial class rptProjectChart
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
            this.rptProjectDesignBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beaDBDataSet = new BEAProjectManagement.beaDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptProjectDesignTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.rptProjectDesignTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rptProjectDesignBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rptProjectDesignBindingSource
            // 
            this.rptProjectDesignBindingSource.DataMember = "rptProjectDesign";
            this.rptProjectDesignBindingSource.DataSource = this.beaDBDataSet;
            // 
            // beaDBDataSet
            // 
            this.beaDBDataSet.DataSetName = "beaDBDataSet";
            this.beaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rptProjectDesignBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BEAProjectManagement.rptProjectChart.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1008, 573);
            this.reportViewer1.TabIndex = 0;
            // 
            // rptProjectDesignTableAdapter
            // 
            this.rptProjectDesignTableAdapter.ClearBeforeFill = true;
            // 
            // rptProjectChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 573);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptProjectChart";
            this.Text = "rptChartTest";
            this.Load += new System.EventHandler(this.rptChartTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rptProjectDesignBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rptProjectDesignBindingSource;
        private beaDBDataSet beaDBDataSet;
        private beaDBDataSetTableAdapters.rptProjectDesignTableAdapter rptProjectDesignTableAdapter;
    }
}