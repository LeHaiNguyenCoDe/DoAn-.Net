namespace banmypham
{
    partial class demkh
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
            this.QL_MYPHAMDataSet = new banmypham.QL_MYPHAMDataSet();
            this.NHASANXUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NHASANXUATTableAdapter = new banmypham.QL_MYPHAMDataSetTableAdapters.NHASANXUATTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QL_MYPHAMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHASANXUATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NHASANXUATBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "banmypham.demkh.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(575, 389);
            this.reportViewer1.TabIndex = 0;
            // 
            // QL_MYPHAMDataSet
            // 
            this.QL_MYPHAMDataSet.DataSetName = "QL_MYPHAMDataSet";
            this.QL_MYPHAMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NHASANXUATBindingSource
            // 
            this.NHASANXUATBindingSource.DataMember = "NHASANXUAT";
            this.NHASANXUATBindingSource.DataSource = this.QL_MYPHAMDataSet;
            // 
            // NHASANXUATTableAdapter
            // 
            this.NHASANXUATTableAdapter.ClearBeforeFill = true;
            // 
            // demkh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 389);
            this.Controls.Add(this.reportViewer1);
            this.Name = "demkh";
            this.Text = "demkh";
            this.Load += new System.EventHandler(this.demkh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QL_MYPHAMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHASANXUATBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NHASANXUATBindingSource;
        private QL_MYPHAMDataSet QL_MYPHAMDataSet;
        private QL_MYPHAMDataSetTableAdapters.NHASANXUATTableAdapter NHASANXUATTableAdapter;
    }
}