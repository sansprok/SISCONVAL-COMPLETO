namespace SISCONVAL
{
    partial class frmReporteCoacResolucionInicio
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
            this.PA_COAC_RESOLUCIONINICIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_COAC_RESINI = new SISCONVAL.DS_COAC_RESINI();
            this.rpvCoacInicio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PA_COAC_RESOLUCIONINICIOTableAdapter = new SISCONVAL.DS_COAC_RESINITableAdapters.PA_COAC_RESOLUCIONINICIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PA_COAC_RESOLUCIONINICIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_COAC_RESINI)).BeginInit();
            this.SuspendLayout();
            // 
            // PA_COAC_RESOLUCIONINICIOBindingSource
            // 
            this.PA_COAC_RESOLUCIONINICIOBindingSource.DataMember = "PA_COAC_RESOLUCIONINICIO";
            this.PA_COAC_RESOLUCIONINICIOBindingSource.DataSource = this.DS_COAC_RESINI;
            // 
            // DS_COAC_RESINI
            // 
            this.DS_COAC_RESINI.DataSetName = "DS_COAC_RESINI";
            this.DS_COAC_RESINI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvCoacInicio
            // 
            this.rpvCoacInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_COAC_RESOLUCIONINICIO";
            reportDataSource1.Value = this.PA_COAC_RESOLUCIONINICIOBindingSource;
            this.rpvCoacInicio.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvCoacInicio.LocalReport.ReportEmbeddedResource = "SISCONVAL.ReporteCoacInicio.rdlc";
            this.rpvCoacInicio.Location = new System.Drawing.Point(0, 0);
            this.rpvCoacInicio.Name = "rpvCoacInicio";
            this.rpvCoacInicio.ServerReport.BearerToken = null;
            this.rpvCoacInicio.Size = new System.Drawing.Size(843, 573);
            this.rpvCoacInicio.TabIndex = 0;
            // 
            // PA_COAC_RESOLUCIONINICIOTableAdapter
            // 
            this.PA_COAC_RESOLUCIONINICIOTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteCoacResolucionInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 573);
            this.Controls.Add(this.rpvCoacInicio);
            this.Name = "frmReporteCoacResolucionInicio";
            this.Text = "frmCoacResolucionInicio";
            this.Load += new System.EventHandler(this.frmCoacResolucionInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_COAC_RESOLUCIONINICIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_COAC_RESINI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvCoacInicio;
        private System.Windows.Forms.BindingSource PA_COAC_RESOLUCIONINICIOBindingSource;
        private DS_COAC_RESINI DS_COAC_RESINI;
        private DS_COAC_RESINITableAdapters.PA_COAC_RESOLUCIONINICIOTableAdapter PA_COAC_RESOLUCIONINICIOTableAdapter;
    }
}