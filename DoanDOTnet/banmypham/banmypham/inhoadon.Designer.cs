namespace banmypham
{
    partial class inhoadon
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
            this.DONDATHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DONDATHANGTableAdapter = new banmypham.QL_MYPHAMDataSetTableAdapters.DONDATHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QL_MYPHAMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DONDATHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DONDATHANGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "banmypham.RP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(630, 454);
            this.reportViewer1.TabIndex = 0;
            // 
            // QL_MYPHAMDataSet
            // 
            this.QL_MYPHAMDataSet.DataSetName = "QL_MYPHAMDataSet";
            this.QL_MYPHAMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DONDATHANGBindingSource
            // 
            this.DONDATHANGBindingSource.DataMember = "DONDATHANG";
            this.DONDATHANGBindingSource.DataSource = this.QL_MYPHAMDataSet;
            // 
            // DONDATHANGTableAdapter
            // 
            this.DONDATHANGTableAdapter.ClearBeforeFill = true;
            // 
            // inhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 454);
            this.Controls.Add(this.reportViewer1);
            this.Name = "inhoadon";
            this.Text = "inhoadon";
            this.Load += new System.EventHandler(this.inhoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QL_MYPHAMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DONDATHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DONDATHANGBindingSource;
        private QL_MYPHAMDataSet QL_MYPHAMDataSet;
        private QL_MYPHAMDataSetTableAdapters.DONDATHANGTableAdapter DONDATHANGTableAdapter;
    }
}