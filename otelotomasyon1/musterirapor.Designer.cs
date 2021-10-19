namespace otelotomasyon1
{
    partial class musterirapor
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
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelveritabaniDataSet = new otelotomasyon1.otelveritabaniDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.musterilerTableAdapter = new otelotomasyon1.otelveritabaniDataSetTableAdapters.musterilerTableAdapter();
            this.otelveritabaniDataSet1 = new otelotomasyon1.otelveritabaniDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelveritabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelveritabaniDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataMember = "musteriler";
            this.musterilerBindingSource.DataSource = this.otelveritabaniDataSet;
            // 
            // otelveritabaniDataSet
            // 
            this.otelveritabaniDataSet.DataSetName = "otelveritabaniDataSet";
            this.otelveritabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.musterilerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "otelotomasyon1.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(670, 387);
            this.reportViewer1.TabIndex = 0;
            // 
            // musterilerTableAdapter
            // 
            this.musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // otelveritabaniDataSet1
            // 
            this.otelveritabaniDataSet1.DataSetName = "otelveritabaniDataSet1";
            this.otelveritabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musterirapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 387);
            this.Controls.Add(this.reportViewer1);
            this.Name = "musterirapor";
            this.Text = "Tüm Müşteri Bilgileri";
            this.Load += new System.EventHandler(this.musterirapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelveritabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelveritabaniDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource musterilerBindingSource;
        private otelveritabaniDataSet otelveritabaniDataSet;
        private otelveritabaniDataSetTableAdapters.musterilerTableAdapter musterilerTableAdapter;
        private otelveritabaniDataSet1 otelveritabaniDataSet1;
    }
}