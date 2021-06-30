
namespace SISCONVAL
{
    partial class frmPlantillaResolucionMasiva
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
            this.DS_VALORES = new SISCONVAL.DS_VALORES();
            this.PA_CONTROLDEUDA_DATOSVALOR_MASIVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PA_CONTROLDEUDA_DATOSVALOR_MASIVTableAdapter = new SISCONVAL.DS_VALORESTableAdapters.PA_CONTROLDEUDA_DATOSVALOR_MASIVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DS_VALORES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_CONTROLDEUDA_DATOSVALOR_MASIVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PA_CONTROLDEUDA_DATOSVALOR_MASIVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISCONVAL.Reportes.ReportResolucionMasivaPlantilla.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(49, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(871, 623);
            this.reportViewer1.TabIndex = 0;
            // 
            // DS_VALORES
            // 
            this.DS_VALORES.DataSetName = "DS_VALORES";
            this.DS_VALORES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_CONTROLDEUDA_DATOSVALOR_MASIVBindingSource
            // 
            this.PA_CONTROLDEUDA_DATOSVALOR_MASIVBindingSource.DataMember = "PA_CONTROLDEUDA_DATOSVALOR_MASIV";
            this.PA_CONTROLDEUDA_DATOSVALOR_MASIVBindingSource.DataSource = this.DS_VALORES;
            // 
            // PA_CONTROLDEUDA_DATOSVALOR_MASIVTableAdapter
            // 
            this.PA_CONTROLDEUDA_DATOSVALOR_MASIVTableAdapter.ClearBeforeFill = true;
            // 
            // frmPlantillaResolucionMasiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 701);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmPlantillaResolucionMasiva";
            this.Text = "frmPlantillaResolucionMasiva";
            this.Load += new System.EventHandler(this.frmPlantillaResolucionMasiva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_VALORES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_CONTROLDEUDA_DATOSVALOR_MASIVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PA_CONTROLDEUDA_DATOSVALOR_MASIVBindingSource;
        private DS_VALORES DS_VALORES;
        private DS_VALORESTableAdapters.PA_CONTROLDEUDA_DATOSVALOR_MASIVTableAdapter PA_CONTROLDEUDA_DATOSVALOR_MASIVTableAdapter;
    }
}