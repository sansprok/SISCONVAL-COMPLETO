namespace SISCONVAL
{
    partial class frmEmisionMasiva
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
            this.rpvEstadoCuentaMasivo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DS_VALORES = new SISCONVAL.DS_VALORES();
            this.PA_ESTADOCUENTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PA_ESTADOCUENTATableAdapter = new SISCONVAL.DS_VALORESTableAdapters.PA_ESTADOCUENTATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DS_VALORES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ESTADOCUENTABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvEstadoCuentaMasivo
            // 
            this.rpvEstadoCuentaMasivo.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1_ESTADOCUENTA";
            reportDataSource1.Value = this.PA_ESTADOCUENTABindingSource;
            this.rpvEstadoCuentaMasivo.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvEstadoCuentaMasivo.LocalReport.ReportEmbeddedResource = "SISCONVAL.Reportes.ReportEstadoCuentaMasivo.rdlc";
            this.rpvEstadoCuentaMasivo.Location = new System.Drawing.Point(0, 0);
            this.rpvEstadoCuentaMasivo.Name = "rpvEstadoCuentaMasivo";
            this.rpvEstadoCuentaMasivo.ServerReport.BearerToken = null;
            this.rpvEstadoCuentaMasivo.Size = new System.Drawing.Size(872, 653);
            this.rpvEstadoCuentaMasivo.TabIndex = 0;
            // 
            // DS_VALORES
            // 
            this.DS_VALORES.DataSetName = "DS_VALORES";
            this.DS_VALORES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_ESTADOCUENTABindingSource
            // 
            this.PA_ESTADOCUENTABindingSource.DataMember = "PA_ESTADOCUENTA";
            this.PA_ESTADOCUENTABindingSource.DataSource = this.DS_VALORES;
            // 
            // PA_ESTADOCUENTATableAdapter
            // 
            this.PA_ESTADOCUENTATableAdapter.ClearBeforeFill = true;
            // 
            // frmEmisionMasiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 653);
            this.Controls.Add(this.rpvEstadoCuentaMasivo);
            this.Name = "frmEmisionMasiva";
            this.Text = "ESTADOS DE CUENTA";
            this.Load += new System.EventHandler(this.FrmEmisionMasiva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_VALORES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ESTADOCUENTABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvEstadoCuentaMasivo;
        private System.Windows.Forms.BindingSource PA_ESTADOCUENTABindingSource;
        private DS_VALORES DS_VALORES;
        private DS_VALORESTableAdapters.PA_ESTADOCUENTATableAdapter PA_ESTADOCUENTATableAdapter;
    }
}