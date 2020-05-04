namespace SISCONVAL
{
    partial class frmReporteOrdenPagoP1P2P3
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
            this.ORDENESPAGOP1P2P3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_VALORES = new SISCONVAL.DS_VALORES();
            this.rpvOrdenPagoP1P2P3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ORDENESPAGOP1P2P3TableAdapter = new SISCONVAL.DS_VALORESTableAdapters.ORDENESPAGOP1P2P3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ORDENESPAGOP1P2P3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_VALORES)).BeginInit();
            this.SuspendLayout();
            // 
            // ORDENESPAGOP1P2P3BindingSource
            // 
            this.ORDENESPAGOP1P2P3BindingSource.DataMember = "ORDENESPAGOP1P2P3";
            this.ORDENESPAGOP1P2P3BindingSource.DataSource = this.DS_VALORES;
            // 
            // DS_VALORES
            // 
            this.DS_VALORES.DataSetName = "DS_VALORES";
            this.DS_VALORES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvOrdenPagoP1P2P3
            // 
            this.rpvOrdenPagoP1P2P3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ORDENESPAGOP1P2P3BindingSource;
            this.rpvOrdenPagoP1P2P3.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvOrdenPagoP1P2P3.LocalReport.ReportEmbeddedResource = "SISCONVAL.ORDENPAGOP1P2P3.rdlc";
            this.rpvOrdenPagoP1P2P3.Location = new System.Drawing.Point(0, 0);
            this.rpvOrdenPagoP1P2P3.Name = "rpvOrdenPagoP1P2P3";
            this.rpvOrdenPagoP1P2P3.ServerReport.BearerToken = null;
            this.rpvOrdenPagoP1P2P3.Size = new System.Drawing.Size(800, 450);
            this.rpvOrdenPagoP1P2P3.TabIndex = 0;
            // 
            // ORDENESPAGOP1P2P3TableAdapter
            // 
            this.ORDENESPAGOP1P2P3TableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteOrdenPagoP1P2P3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvOrdenPagoP1P2P3);
            this.Name = "frmReporteOrdenPagoP1P2P3";
            this.Text = "frmReporteOrdenPagoP1P2P3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteOrdenPagoP1P2P3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ORDENESPAGOP1P2P3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_VALORES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvOrdenPagoP1P2P3;
        private System.Windows.Forms.BindingSource ORDENESPAGOP1P2P3BindingSource;
        private DS_VALORES DS_VALORES;
        private DS_VALORESTableAdapters.ORDENESPAGOP1P2P3TableAdapter ORDENESPAGOP1P2P3TableAdapter;
    }
}