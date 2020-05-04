namespace SISCONVAL
{
    partial class frmReporteOrdenPagoP1P2
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
            this.ORDENESPAGOP1P2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_VALORES = new SISCONVAL.DS_VALORES();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ORDENESPAGOP1P2TableAdapter = new SISCONVAL.DS_VALORESTableAdapters.ORDENESPAGOP1P2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ORDENESPAGOP1P2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_VALORES)).BeginInit();
            this.SuspendLayout();
            // 
            // ORDENESPAGOP1P2BindingSource
            // 
            this.ORDENESPAGOP1P2BindingSource.DataMember = "ORDENESPAGOP1P2";
            this.ORDENESPAGOP1P2BindingSource.DataSource = this.DS_VALORES;
            // 
            // DS_VALORES
            // 
            this.DS_VALORES.DataSetName = "DS_VALORES";
            this.DS_VALORES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ORDENESPAGOP1P2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISCONVAL.ORDENPAGOP1P2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(951, 633);
            this.reportViewer1.TabIndex = 0;
            // 
            // ORDENESPAGOP1P2TableAdapter
            // 
            this.ORDENESPAGOP1P2TableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteOrdenPagoP1P2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 633);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteOrdenPagoP1P2";
            this.Text = "frmReporteOrdenPagoP1P2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReporteOrdenPagoP1P2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ORDENESPAGOP1P2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_VALORES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ORDENESPAGOP1P2BindingSource;
        private DS_VALORES DS_VALORES;
        private DS_VALORESTableAdapters.ORDENESPAGOP1P2TableAdapter ORDENESPAGOP1P2TableAdapter;
    }
}