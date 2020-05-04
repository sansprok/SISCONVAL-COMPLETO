namespace SISCONVAL
{
    partial class FrmReportCrisResolucionEmbargo
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
            this.crvResolucionEmbargo = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportResolucionRetencion1 = new SISCONVAL.ReportResolucionRetencion();
            this.SuspendLayout();
            // 
            // crvResolucionEmbargo
            // 
            this.crvResolucionEmbargo.ActiveViewIndex = -1;
            this.crvResolucionEmbargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvResolucionEmbargo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.crvResolucionEmbargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvResolucionEmbargo.Location = new System.Drawing.Point(0, 0);
            this.crvResolucionEmbargo.Name = "crvResolucionEmbargo";
            this.crvResolucionEmbargo.ReportSource = this.ReportResolucionRetencion1;
            this.crvResolucionEmbargo.Size = new System.Drawing.Size(1030, 706);
            this.crvResolucionEmbargo.TabIndex = 0;
            // 
            // FrmReportCrisResolucionEmbargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 706);
            this.Controls.Add(this.crvResolucionEmbargo);
            this.Name = "FrmReportCrisResolucionEmbargo";
            this.Text = "frmResolucionCrisEmbargo";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvResolucionEmbargo;
        private ReportResolucionRetencion ReportResolucionRetencion1;
    }
}