namespace SISCONVAL
{
    partial class frmReporteOrdenPagoP3
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
            this.ORDENESPAGOP3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_VALORES = new SISCONVAL.DS_VALORES();
            this.rpvOrdenPagoP3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ORDENESPAGOP3TableAdapter = new SISCONVAL.DS_VALORESTableAdapters.ORDENESPAGOP3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ORDENESPAGOP3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_VALORES)).BeginInit();
            this.SuspendLayout();
            // 
            // ORDENESPAGOP3BindingSource
            // 
            this.ORDENESPAGOP3BindingSource.DataMember = "ORDENESPAGOP3";
            this.ORDENESPAGOP3BindingSource.DataSource = this.DS_VALORES;
            // 
            // DS_VALORES
            // 
            this.DS_VALORES.DataSetName = "DS_VALORES";
            this.DS_VALORES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvOrdenPagoP3
            // 
            this.rpvOrdenPagoP3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ORDENESPAGOP3BindingSource;
            this.rpvOrdenPagoP3.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvOrdenPagoP3.LocalReport.ReportEmbeddedResource = "SISCONVAL.ORDENPAGOP3.rdlc";
            this.rpvOrdenPagoP3.Location = new System.Drawing.Point(0, 0);
            this.rpvOrdenPagoP3.Name = "rpvOrdenPagoP3";
            this.rpvOrdenPagoP3.ServerReport.BearerToken = null;
            this.rpvOrdenPagoP3.Size = new System.Drawing.Size(800, 450);
            this.rpvOrdenPagoP3.TabIndex = 0;
            // 
            // ORDENESPAGOP3TableAdapter
            // 
            this.ORDENESPAGOP3TableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteOrdenPagoP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvOrdenPagoP3);
            this.Name = "frmReporteOrdenPagoP3";
            this.Text = "frmReporteOrdenPagoP3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteOrdenPagoP3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ORDENESPAGOP3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_VALORES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvOrdenPagoP3;
        private DS_VALORES DS_VALORES;
        private System.Windows.Forms.BindingSource ORDENESPAGOP3BindingSource;
        private DS_VALORESTableAdapters.ORDENESPAGOP3TableAdapter ORDENESPAGOP3TableAdapter;
    }
}