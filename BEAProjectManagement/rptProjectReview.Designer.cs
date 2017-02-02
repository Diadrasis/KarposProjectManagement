namespace BEAProjectManagement
{
    partial class rptProjectReview
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
            this.rptProjectReviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptProjectReviewTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.rptProjectReviewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptProjectReviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsProjectReview";
            reportDataSource1.Value = this.rptProjectReviewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BEAProjectManagement.rptProjectReview.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(932, 367);
            this.reportViewer1.TabIndex = 0;
            // 
            // beaDBDataSet
            // 
            this.beaDBDataSet.DataSetName = "beaDBDataSet";
            this.beaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptProjectReviewBindingSource
            // 
            this.rptProjectReviewBindingSource.DataMember = "rptProjectReview";
            this.rptProjectReviewBindingSource.DataSource = this.beaDBDataSet;
            // 
            // rptProjectReviewTableAdapter
            // 
            this.rptProjectReviewTableAdapter.ClearBeforeFill = true;
            // 
            // rptProjectReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 367);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptProjectReview";
            this.Text = "rptProjectReview";
            this.Load += new System.EventHandler(this.rptProjectReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptProjectReviewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rptProjectReviewBindingSource;
        private beaDBDataSet beaDBDataSet;
        private beaDBDataSetTableAdapters.rptProjectReviewTableAdapter rptProjectReviewTableAdapter;
    }
}