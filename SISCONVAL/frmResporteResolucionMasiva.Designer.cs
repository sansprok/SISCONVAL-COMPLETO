namespace SISCONVAL
{
    partial class frmResporteResolucionMasiva
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
            this.crvResolucionMasiva = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportResolucionMasiva1 = new SISCONVAL.ReportResolucionMasiva();
            //this.ReportEstadoCuentaMasivo1 = new SISCONVAL.ReportEstadoCuentaMasivo();
            this.ReportResolucionMasiva2 = new SISCONVAL.ReportResolucionMasiva();
            this.SuspendLayout();
            // 
            // crvResolucionMasiva
            // 
            this.crvResolucionMasiva.ActiveViewIndex = 0;
            this.crvResolucionMasiva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvResolucionMasiva.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvResolucionMasiva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvResolucionMasiva.Location = new System.Drawing.Point(0, 0);
            this.crvResolucionMasiva.Name = "crvResolucionMasiva";
            this.crvResolucionMasiva.ReportSource = this.ReportResolucionMasiva2;
            this.crvResolucionMasiva.Size = new System.Drawing.Size(800, 450);
            this.crvResolucionMasiva.TabIndex = 0;
            this.crvResolucionMasiva.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmResporteResolucionMasiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvResolucionMasiva);
            this.Name = "frmResporteResolucionMasiva";
            this.Text = "frmResporteResolucionMasiva";
            this.Load += new System.EventHandler(this.FrmResporteResolucionMasiva_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvResolucionMasiva;
        private ReportResolucionMasiva ReportResolucionMasiva1;
        //private ReportEstadoCuentaMasivo ReportEstadoCuentaMasivo1;
        private ReportResolucionMasiva ReportResolucionMasiva2;
    }
}