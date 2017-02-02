namespace BEAProjectManagement
{
    partial class rptProjectReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.beaDBDataSet = new BEAProjectManagement.beaDBDataSet();
            this.rptProjectDesign2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptProjectDesign2TableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.rptProjectDesign2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptProjectDesign2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsProjectDesign";
            reportDataSource1.Value = this.rptProjectDesign2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BEAProjectManagement.rptProjectDesign2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(875, 368);
            this.reportViewer1.TabIndex = 0;
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
            // rptProjectDesign2TableAdapter
            // 
            this.rptProjectDesign2TableAdapter.ClearBeforeFill = true;
            // 
            // rptProjectReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 368);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptProjectReport";
            this.Text = "rptProjectReport";
            this.Load += new System.EventHandler(this.rptProjectReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptProjectDesign2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rptProjectDesign2BindingSource;
        private beaDBDataSet beaDBDataSet;
        private beaDBDataSetTableAdapters.rptProjectDesign2TableAdapter rptProjectDesign2TableAdapter;
    }
}