namespace SISCONVAL
{
    partial class frmReporteResolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteResolucion));
            this.PA_CONTROLDEUDA_DATOSVALOR_MASIVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_VALORES = new SISCONVAL.DS_VALORES();
            this.PA_CONTROLDEUDA_DATOSVALORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvResolucion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PA_CONTROLDEUDA_DATOSVALORTableAdapter = new SISCONVAL.DS_VALORESTableAdapters.PA_CONTROLDEUDA_DATOSVALORTableAdapter();
            this.PA_CONTROLDEUDA_DATOSVALOR_MASIVTableAdapter = new SISCONVAL.DS_VALORESTableAdapters.PA_CONTROLDEUDA_DATOSVALOR_MASIVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PA_CONTROLDEUDA_DATOSVALOR_MASIVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_VALORES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_CONTROLDEUDA_DATOSVALORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PA_CONTROLDEUDA_DATOSVALOR_MASIVBindingSource
            // 
            this.PA_CONTROLDEUDA_DATOSVALOR_MASIVBindingSource.DataMember = "PA_CONTROLDEUDA_DATOSVALOR_MASIV";
            this.PA_CONTROLDEUDA_DATOSVALOR_MASIVBindingSource.DataSource = this.DS_VALORES;
            // 
            // DS_VALORES
            // 
            this.DS_VALORES.DataSetName = "DS_VALORES";
            this.DS_VALORES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_CONTROLDEUDA_DATOSVALORBindingSource
            // 
            this.PA_CONTROLDEUDA_DATOSVALORBindingSource.DataMember = "PA_CONTROLDEUDA_DATOSVALOR";
            this.PA_CONTROLDEUDA_DATOSVALORBindingSource.DataSource = this.DS_VALORES;
            // 
            // rpvResolucion
            // 
            this.rpvResolucion.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_VALORESDET";
            reportDataSource1.Value = this.PA_CONTROLDEUDA_DATOSVALOR_MASIVBindingSource;
            this.rpvResolucion.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvResolucion.LocalReport.ReportEmbeddedResource = "SISCONVAL.FormatoResolucionDeterminacion.rdlc";
            this.rpvResolucion.Location = new System.Drawing.Point(0, 0);
            this.rpvResolucion.Margin = new System.Windows.Forms.Padding(2);
            this.rpvResolucion.Name = "rpvResolucion";
            this.rpvResolucion.ServerReport.BearerToken = null;
            this.rpvResolucion.Size = new System.Drawing.Size(733, 548);
            this.rpvResolucion.TabIndex = 0;
            // 
            // PA_CONTROLDEUDA_DATOSVALORTableAdapter
            // 
            this.PA_CONTROLDEUDA_DATOSVALORTableAdapter.ClearBeforeFill = true;
            // 
            // PA_CONTROLDEUDA_DATOSVALOR_MASIVTableAdapter
            // 
            this.PA_CONTROLDEUDA_DATOSVALOR_MASIVTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteResolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 548);
            this.Controls.Add(this.rpvResolucion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReporteResolucion";
            this.Text = "RESOLUCIÓN DE DETERMINACIÓN DE DEUDA";
            this.Load += new System.EventHandler(this.frmResolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_CONTROLDEUDA_DATOSVALOR_MASIVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_VALORES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_CONTROLDEUDA_DATOSVALORBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvResolucion;
        private System.Windows.Forms.BindingSource PA_CONTROLDEUDA_DATOSVALORBindingSource;
        private DS_VALORES DS_VALORES;
        private DS_VALORESTableAdapters.PA_CONTROLDEUDA_DATOSVALORTableAdapter PA_CONTROLDEUDA_DATOSVALORTableAdapter;
        private System.Windows.Forms.BindingSource PA_CONTROLDEUDA_DATOSVALOR_MASIVBindingSource;
        private DS_VALORESTableAdapters.PA_CONTROLDEUDA_DATOSVALOR_MASIVTableAdapter PA_CONTROLDEUDA_DATOSVALOR_MASIVTableAdapter;
    }
}