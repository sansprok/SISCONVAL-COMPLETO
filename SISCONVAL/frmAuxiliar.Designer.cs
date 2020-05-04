namespace SISCONVAL
{
    partial class frmAuxiliar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuxiliar));
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvAuxiliarCoac = new System.Windows.Forms.DataGridView();
            this.btnEliminarAuxiliar = new System.Windows.Forms.Button();
            this.btnModificarAuxiliar = new System.Windows.Forms.Button();
            this.btnIngresarAuxiliar = new System.Windows.Forms.Button();
            this.txtAuxNombreAuxiliar = new System.Windows.Forms.TextBox();
            this.txtAuxNombreCorto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuxiliarCoac)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(405, 480);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 85);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvAuxiliarCoac
            // 
            this.dgvAuxiliarCoac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAuxiliarCoac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuxiliarCoac.Location = new System.Drawing.Point(21, 102);
            this.dgvAuxiliarCoac.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAuxiliarCoac.MultiSelect = false;
            this.dgvAuxiliarCoac.Name = "dgvAuxiliarCoac";
            this.dgvAuxiliarCoac.ReadOnly = true;
            this.dgvAuxiliarCoac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuxiliarCoac.Size = new System.Drawing.Size(484, 358);
            this.dgvAuxiliarCoac.TabIndex = 25;
            this.dgvAuxiliarCoac.SelectionChanged += new System.EventHandler(this.dgvAuxiliarCoac_SelectionChanged);
            // 
            // btnEliminarAuxiliar
            // 
            this.btnEliminarAuxiliar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarAuxiliar.Image")));
            this.btnEliminarAuxiliar.Location = new System.Drawing.Point(238, 480);
            this.btnEliminarAuxiliar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarAuxiliar.Name = "btnEliminarAuxiliar";
            this.btnEliminarAuxiliar.Size = new System.Drawing.Size(92, 85);
            this.btnEliminarAuxiliar.TabIndex = 24;
            this.btnEliminarAuxiliar.Text = "Eliminar";
            this.btnEliminarAuxiliar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminarAuxiliar.UseVisualStyleBackColor = true;
            this.btnEliminarAuxiliar.Click += new System.EventHandler(this.btnEliminarAuxiliar_Click);
            // 
            // btnModificarAuxiliar
            // 
            this.btnModificarAuxiliar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarAuxiliar.Image")));
            this.btnModificarAuxiliar.Location = new System.Drawing.Point(130, 480);
            this.btnModificarAuxiliar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarAuxiliar.Name = "btnModificarAuxiliar";
            this.btnModificarAuxiliar.Size = new System.Drawing.Size(85, 85);
            this.btnModificarAuxiliar.TabIndex = 23;
            this.btnModificarAuxiliar.Text = "Modificar";
            this.btnModificarAuxiliar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificarAuxiliar.UseVisualStyleBackColor = true;
            this.btnModificarAuxiliar.Click += new System.EventHandler(this.btnModificarAuxiliar_Click);
            // 
            // btnIngresarAuxiliar
            // 
            this.btnIngresarAuxiliar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresarAuxiliar.Image")));
            this.btnIngresarAuxiliar.Location = new System.Drawing.Point(22, 480);
            this.btnIngresarAuxiliar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresarAuxiliar.Name = "btnIngresarAuxiliar";
            this.btnIngresarAuxiliar.Size = new System.Drawing.Size(85, 85);
            this.btnIngresarAuxiliar.TabIndex = 22;
            this.btnIngresarAuxiliar.Text = "Ingresar";
            this.btnIngresarAuxiliar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIngresarAuxiliar.UseVisualStyleBackColor = true;
            this.btnIngresarAuxiliar.Click += new System.EventHandler(this.btnIngresarAuxiliar_Click);
            // 
            // txtAuxNombreAuxiliar
            // 
            this.txtAuxNombreAuxiliar.Location = new System.Drawing.Point(96, 60);
            this.txtAuxNombreAuxiliar.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuxNombreAuxiliar.Name = "txtAuxNombreAuxiliar";
            this.txtAuxNombreAuxiliar.Size = new System.Drawing.Size(409, 22);
            this.txtAuxNombreAuxiliar.TabIndex = 21;
            // 
            // txtAuxNombreCorto
            // 
            this.txtAuxNombreCorto.Location = new System.Drawing.Point(123, 15);
            this.txtAuxNombreCorto.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuxNombreCorto.Name = "txtAuxNombreCorto";
            this.txtAuxNombreCorto.Size = new System.Drawing.Size(132, 22);
            this.txtAuxNombreCorto.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre Corto";
            // 
            // frmAuxiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 581);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvAuxiliarCoac);
            this.Controls.Add(this.btnEliminarAuxiliar);
            this.Controls.Add(this.btnModificarAuxiliar);
            this.Controls.Add(this.btnIngresarAuxiliar);
            this.Controls.Add(this.txtAuxNombreAuxiliar);
            this.Controls.Add(this.txtAuxNombreCorto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(543, 628);
            this.MinimumSize = new System.Drawing.Size(543, 628);
            this.Name = "frmAuxiliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUXILIAR COACTIVO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuxiliarCoac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvAuxiliarCoac;
        private System.Windows.Forms.Button btnEliminarAuxiliar;
        private System.Windows.Forms.Button btnModificarAuxiliar;
        private System.Windows.Forms.Button btnIngresarAuxiliar;
        private System.Windows.Forms.TextBox txtAuxNombreAuxiliar;
        private System.Windows.Forms.TextBox txtAuxNombreCorto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}