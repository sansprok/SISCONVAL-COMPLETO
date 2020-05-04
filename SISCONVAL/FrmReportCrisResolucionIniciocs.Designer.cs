namespace SISCONVAL
{
    partial class FrmReportCrisResolucionIniciocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportCrisResolucionIniciocs));
            this.PA_COAC_RESOLUCIONINICIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_COAC_RESINI = new SISCONVAL.DS_COAC_RESINI();
            this.pA_COAC_RESOLUCIONINICIOTableAdapter = new SISCONVAL.DS_COAC_RESINITableAdapters.PA_COAC_RESOLUCIONINICIOTableAdapter();
            this.crvResolucionInicioCoac = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportResolucionDeInicio1 = new SISCONVAL.ReportResolucionDeInicio();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PA_COAC_RESOLUCIONINICIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_COAC_RESINI)).BeginInit();
            this.SuspendLayout();
            // 
            // PA_COAC_RESOLUCIONINICIOBindingSource
            // 
            this.PA_COAC_RESOLUCIONINICIOBindingSource.DataMember = "PA_COAC_RESOLUCIONINICIO";
            this.PA_COAC_RESOLUCIONINICIOBindingSource.DataSource = this.dS_COAC_RESINI;
            // 
            // dS_COAC_RESINI
            // 
            this.dS_COAC_RESINI.DataSetName = "DS_COAC_RESINI";
            this.dS_COAC_RESINI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pA_COAC_RESOLUCIONINICIOTableAdapter
            // 
            this.pA_COAC_RESOLUCIONINICIOTableAdapter.ClearBeforeFill = true;
            // 
            // crvResolucionInicioCoac
            // 
            this.crvResolucionInicioCoac.ActiveViewIndex = 0;
            this.crvResolucionInicioCoac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvResolucionInicioCoac.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvResolucionInicioCoac.DisplayStatusBar = false;
            this.crvResolucionInicioCoac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvResolucionInicioCoac.Location = new System.Drawing.Point(0, 0);
            this.crvResolucionInicioCoac.Name = "crvResolucionInicioCoac";
            this.crvResolucionInicioCoac.ReportSource = this.ReportResolucionDeInicio1;
            this.crvResolucionInicioCoac.Size = new System.Drawing.Size(1224, 827);
            this.crvResolucionInicioCoac.TabIndex = 0;
            this.crvResolucionInicioCoac.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvResolucionInicioCoac.Load += new System.EventHandler(this.crvResolucionInicioCoac_Load);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(588, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(125, 44);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FrmReportCrisResolucionIniciocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 827);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.crvResolucionInicioCoac);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportCrisResolucionIniciocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESOLUCIÓN DE INICIO DE EJECUCIÓN COACTIVA";
            this.Load += new System.EventHandler(this.FrmReportCrisResolucionIniciocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_COAC_RESOLUCIONINICIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_COAC_RESINI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvResolucionInicioCoac;
        private ReportResolucionDeInicio ReportResolucionDeInicio1;
        private System.Windows.Forms.BindingSource PA_COAC_RESOLUCIONINICIOBindingSource;
        private DS_COAC_RESINI dS_COAC_RESINI;
        private DS_COAC_RESINITableAdapters.PA_COAC_RESOLUCIONINICIOTableAdapter pA_COAC_RESOLUCIONINICIOTableAdapter;
        private System.Windows.Forms.Button btnImprimir;
    }
}