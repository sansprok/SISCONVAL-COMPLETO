namespace SISCONVAL
{
    partial class FrmReportCrysResolucionRentencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportCrysResolucionRentencion));
            this.crvResRetencion = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportResolucionRetencion2 = new SISCONVAL.ReportResolucionRetencion();
            this.ReportResolucionRetencion1 = new SISCONVAL.ReportResolucionRetencion();
            this.SuspendLayout();
            // 
            // crvResRetencion
            // 
            this.crvResRetencion.ActiveViewIndex = 0;
            this.crvResRetencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvResRetencion.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvResRetencion.DisplayStatusBar = false;
            this.crvResRetencion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvResRetencion.Location = new System.Drawing.Point(0, 0);
            this.crvResRetencion.Margin = new System.Windows.Forms.Padding(2);
            this.crvResRetencion.Name = "crvResRetencion";
            this.crvResRetencion.ReportSource = this.ReportResolucionRetencion2;
            this.crvResRetencion.Size = new System.Drawing.Size(830, 620);
            this.crvResRetencion.TabIndex = 0;
            this.crvResRetencion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmReportCrysResolucionRentencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 620);
            this.Controls.Add(this.crvResRetencion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReportCrysResolucionRentencion";
            this.Text = "RESOLUCIÓN DE RETENCIÓN";
            this.Load += new System.EventHandler(this.FrmReportCrysResolucionRentencion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvResRetencion;
        private ReportResolucionRetencion ReportResolucionRetencion1;
        private ReportResolucionRetencion ReportResolucionRetencion2;
    }
}