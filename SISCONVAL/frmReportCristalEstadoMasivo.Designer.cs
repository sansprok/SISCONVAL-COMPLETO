namespace SISCONVAL
{
    partial class frmReportCristalEstadoMasivo
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
            this.crvEstadoCuentaMasivo = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportEstadoCuentaMasivo = new SISCONVAL.ReportEstadoCuentaMasivo();
            this.SuspendLayout();
            // 
            // crvEstadoCuentaMasivo
            // 
            this.crvEstadoCuentaMasivo.ActiveViewIndex = 0;
            this.crvEstadoCuentaMasivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvEstadoCuentaMasivo.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvEstadoCuentaMasivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvEstadoCuentaMasivo.Location = new System.Drawing.Point(0, 0);
            this.crvEstadoCuentaMasivo.Name = "crvEstadoCuentaMasivo";
            this.crvEstadoCuentaMasivo.ReportSource = this.ReportEstadoCuentaMasivo;
            this.crvEstadoCuentaMasivo.Size = new System.Drawing.Size(800, 450);
            this.crvEstadoCuentaMasivo.TabIndex = 0;
            this.crvEstadoCuentaMasivo.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReportCristalEstadoMasivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvEstadoCuentaMasivo);
            this.Name = "frmReportCristalEstadoMasivo";
            this.Text = "frmReportCristalEstadoMasivo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportCristalEstadoMasivo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvEstadoCuentaMasivo;
        private ReportEstadoCuentaMasivo ReportEstadoCuentaMasivo;
    }
}