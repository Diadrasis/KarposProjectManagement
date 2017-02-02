namespace BEAProjectManagement
{
    partial class rptTimeSheet
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
            this.rptTimeSheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beaDBDataSet = new BEAProjectManagement.beaDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptTimeSheetTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.rptTimeSheetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rptTimeSheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rptTimeSheetBindingSource
            // 
            this.rptTimeSheetBindingSource.DataMember = "rptTimeSheet";
            this.rptTimeSheetBindingSource.DataSource = this.beaDBDataSet;
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
            reportDataSource1.Value = this.rptTimeSheetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BEAProjectManagement.rptTimeSheet.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1008, 573);
            this.reportViewer1.TabIndex = 0;
            // 
            // rptTimeSheetTableAdapter
            // 
            this.rptTimeSheetTableAdapter.ClearBeforeFill = true;
            // 
            // rptTimeSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 573);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptTimeSheet";
            this.Text = "rptTimeSheet";
            this.Load += new System.EventHandler(this.rptTimeSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rptTimeSheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rptTimeSheetBindingSource;
        private beaDBDataSet beaDBDataSet;
        private beaDBDataSetTableAdapters.rptTimeSheetTableAdapter rptTimeSheetTableAdapter;
    }
}