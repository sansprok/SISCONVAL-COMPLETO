namespace SISCONVAL
{
    partial class frmReporteOrdenPagoP2
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
            this.ORDENESPAGOP2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_VALORES = new SISCONVAL.DS_VALORES();
            this.rpvOrdenPagoP2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ORDENESPAGOP2TableAdapter = new SISCONVAL.DS_VALORESTableAdapters.ORDENESPAGOP2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ORDENESPAGOP2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_VALORES)).BeginInit();
            this.SuspendLayout();
            // 
            // ORDENESPAGOP2BindingSource
            // 
            this.ORDENESPAGOP2BindingSource.DataMember = "ORDENESPAGOP2";
            this.ORDENESPAGOP2BindingSource.DataSource = this.DS_VALORES;
            // 
            // DS_VALORES
            // 
            this.DS_VALORES.DataSetName = "DS_VALORES";
            this.DS_VALORES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvOrdenPagoP2
            // 
            this.rpvOrdenPagoP2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ORDENESPAGOP2BindingSource;
            this.rpvOrdenPagoP2.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvOrdenPagoP2.LocalReport.ReportEmbeddedResource = "SISCONVAL.ORDENPAGOP2.rdlc";
            this.rpvOrdenPagoP2.Location = new System.Drawing.Point(0, 0);
            this.rpvOrdenPagoP2.Name = "rpvOrdenPagoP2";
            this.rpvOrdenPagoP2.ServerReport.BearerToken = null;
            this.rpvOrdenPagoP2.Size = new System.Drawing.Size(800, 450);
            this.rpvOrdenPagoP2.TabIndex = 0;
            // 
            // ORDENESPAGOP2TableAdapter
            // 
            this.ORDENESPAGOP2TableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteOrdenPagoP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvOrdenPagoP2);
            this.Name = "frmReporteOrdenPagoP2";
            this.Text = "frmReporteOrdenPagoP2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReporteOrdenPagoP2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ORDENESPAGOP2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_VALORES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvOrdenPagoP2;
        private System.Windows.Forms.BindingSource ORDENESPAGOP2BindingSource;
        private DS_VALORES DS_VALORES;
        private DS_VALORESTableAdapters.ORDENESPAGOP2TableAdapter ORDENESPAGOP2TableAdapter;
    }
}