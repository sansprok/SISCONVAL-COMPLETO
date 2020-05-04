namespace SISCONVAL
{
    partial class FrmReportCrisResolucionInicioOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportCrisResolucionInicioOP));
            this.crvResolucionInicioOP = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportResolucionDeInicio___OP1 = new SISCONVAL.ReportResolucionDeInicio___OP();
            this.SuspendLayout();
            // 
            // crvResolucionInicioOP
            // 
            this.crvResolucionInicioOP.ActiveViewIndex = 0;
            this.crvResolucionInicioOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvResolucionInicioOP.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvResolucionInicioOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvResolucionInicioOP.Location = new System.Drawing.Point(0, 0);
            this.crvResolucionInicioOP.Name = "crvResolucionInicioOP";
            this.crvResolucionInicioOP.ReportSource = this.ReportResolucionDeInicio___OP1;
            this.crvResolucionInicioOP.Size = new System.Drawing.Size(800, 450);
            this.crvResolucionInicioOP.TabIndex = 0;
            this.crvResolucionInicioOP.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmReportCrisResolucionInicioOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvResolucionInicioOP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportCrisResolucionInicioOP";
            this.Text = "RESOLUCIÓN DE INICIO DE EJECUCIÓN COACTIVA - ORDEN DE PAGO";
            this.Load += new System.EventHandler(this.FrmReportCrisResolucionInicioOP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvResolucionInicioOP;
        private ReportResolucionDeInicio___OP ReportResolucionDeInicio___OP1;
    }
}