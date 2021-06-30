namespace SISCONVAL
{
    partial class frmReporteRD_Masiv
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
            this.crvREPORTE_RD_MASIV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvREPORTE_RD_MASIV
            // 
            this.crvREPORTE_RD_MASIV.ActiveViewIndex = -1;
            this.crvREPORTE_RD_MASIV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvREPORTE_RD_MASIV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvREPORTE_RD_MASIV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvREPORTE_RD_MASIV.Location = new System.Drawing.Point(0, 0);
            this.crvREPORTE_RD_MASIV.Name = "crvREPORTE_RD_MASIV";
            this.crvREPORTE_RD_MASIV.Size = new System.Drawing.Size(800, 450);
            this.crvREPORTE_RD_MASIV.TabIndex = 0;
            this.crvREPORTE_RD_MASIV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReporteRD_Masiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvREPORTE_RD_MASIV);
            this.Name = "frmReporteRD_Masiv";
            this.Text = "frmReporteRD_Masiv";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteRD_Masiv_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvREPORTE_RD_MASIV;
    }
}