namespace SISCONVAL
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cONTROLDEDEUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOBRANZACOACTIVAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONTROLDEDEUDAToolStripMenuItem,
            this.cOBRANZACOACTIVAToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1078, 73);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cONTROLDEDEUDAToolStripMenuItem
            // 
            this.cONTROLDEDEUDAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cONTROLDEDEUDAToolStripMenuItem.Image")));
            this.cONTROLDEDEUDAToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cONTROLDEDEUDAToolStripMenuItem.Name = "cONTROLDEDEUDAToolStripMenuItem";
            this.cONTROLDEDEUDAToolStripMenuItem.Size = new System.Drawing.Size(131, 69);
            this.cONTROLDEDEUDAToolStripMenuItem.Text = "CONTROL DE DEUDA";
            this.cONTROLDEDEUDAToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cONTROLDEDEUDAToolStripMenuItem.Click += new System.EventHandler(this.cONTROLDEDEUDAToolStripMenuItem_Click);
            // 
            // cOBRANZACOACTIVAToolStripMenuItem
            // 
            this.cOBRANZACOACTIVAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cOBRANZACOACTIVAToolStripMenuItem.Image")));
            this.cOBRANZACOACTIVAToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cOBRANZACOACTIVAToolStripMenuItem.Name = "cOBRANZACOACTIVAToolStripMenuItem";
            this.cOBRANZACOACTIVAToolStripMenuItem.Size = new System.Drawing.Size(141, 69);
            this.cOBRANZACOACTIVAToolStripMenuItem.Text = "COBRANZA COACTIVA";
            this.cOBRANZACOACTIVAToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cOBRANZACOACTIVAToolStripMenuItem.Click += new System.EventHandler(this.cOBRANZACOACTIVAToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sALIRToolStripMenuItem.Image")));
            this.sALIRToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(58, 69);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 678);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1094, 717);
            this.MinimumSize = new System.Drawing.Size(1094, 717);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTIÓN DE CUENTAS - OFICINA DE TRIBUTACIÓN DE LA MUNICIPALIDAD DISTRITAL DE WANC" +
    "HAQ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cONTROLDEDEUDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOBRANZACOACTIVAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
    }
}