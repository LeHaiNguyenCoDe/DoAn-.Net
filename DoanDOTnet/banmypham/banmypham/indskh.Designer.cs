namespace banmypham
{
    partial class indskh
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
            this.KHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KHACHHANGTableAdapter = new banmypham.QL_MYPHAMDataSetTableAdapters.KHACHHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QL_MYPHAMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHACHHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KHACHHANGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "banmypham.indskh.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(743, 468);
            this.reportViewer1.TabIndex = 0;
            // 
            // QL_MYPHAMDataSet
            // 
            this.QL_MYPHAMDataSet.DataSetName = "QL_MYPHAMDataSet";
            this.QL_MYPHAMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KHACHHANGBindingSource
            // 
            this.KHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.KHACHHANGBindingSource.DataSource = this.QL_MYPHAMDataSet;
            // 
            // KHACHHANGTableAdapter
            // 
            this.KHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // indskh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 468);
            this.Controls.Add(this.reportViewer1);
            this.Name = "indskh";
            this.Text = "indskh";
            this.Load += new System.EventHandler(this.indskh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QL_MYPHAMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHACHHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KHACHHANGBindingSource;
        private QL_MYPHAMDataSet QL_MYPHAMDataSet;
        private QL_MYPHAMDataSetTableAdapters.KHACHHANGTableAdapter KHACHHANGTableAdapter;
    }
}