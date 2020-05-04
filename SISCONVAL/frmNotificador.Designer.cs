namespace SISCONVAL
{
    partial class frmNotificador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotificador));
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvNotificadores = new System.Windows.Forms.DataGridView();
            this.btnEliminarNotificador = new System.Windows.Forms.Button();
            this.btnModificarNotificador = new System.Windows.Forms.Button();
            this.btnIngresarNotificador = new System.Windows.Forms.Button();
            this.txtNombreNotificador = new System.Windows.Forms.TextBox();
            this.txtNombreCorto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(407, 480);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 85);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvNotificadores
            // 
            this.dgvNotificadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNotificadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificadores.Location = new System.Drawing.Point(23, 102);
            this.dgvNotificadores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNotificadores.MultiSelect = false;
            this.dgvNotificadores.Name = "dgvNotificadores";
            this.dgvNotificadores.ReadOnly = true;
            this.dgvNotificadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotificadores.Size = new System.Drawing.Size(484, 358);
            this.dgvNotificadores.TabIndex = 16;
            this.dgvNotificadores.SelectionChanged += new System.EventHandler(this.dgvNotificadores_SelectionChanged);
            // 
            // btnEliminarNotificador
            // 
            this.btnEliminarNotificador.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarNotificador.Image")));
            this.btnEliminarNotificador.Location = new System.Drawing.Point(240, 480);
            this.btnEliminarNotificador.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarNotificador.Name = "btnEliminarNotificador";
            this.btnEliminarNotificador.Size = new System.Drawing.Size(92, 85);
            this.btnEliminarNotificador.TabIndex = 15;
            this.btnEliminarNotificador.Text = "Eliminar";
            this.btnEliminarNotificador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminarNotificador.UseVisualStyleBackColor = true;
            this.btnEliminarNotificador.Click += new System.EventHandler(this.txtEliminarNotificador_Click);
            // 
            // btnModificarNotificador
            // 
            this.btnModificarNotificador.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarNotificador.Image")));
            this.btnModificarNotificador.Location = new System.Drawing.Point(132, 480);
            this.btnModificarNotificador.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarNotificador.Name = "btnModificarNotificador";
            this.btnModificarNotificador.Size = new System.Drawing.Size(85, 85);
            this.btnModificarNotificador.TabIndex = 14;
            this.btnModificarNotificador.Text = "Modificar";
            this.btnModificarNotificador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificarNotificador.UseVisualStyleBackColor = true;
            this.btnModificarNotificador.Click += new System.EventHandler(this.txtModificarNotificador_Click);
            // 
            // btnIngresarNotificador
            // 
            this.btnIngresarNotificador.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresarNotificador.Image")));
            this.btnIngresarNotificador.Location = new System.Drawing.Point(24, 480);
            this.btnIngresarNotificador.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresarNotificador.Name = "btnIngresarNotificador";
            this.btnIngresarNotificador.Size = new System.Drawing.Size(85, 85);
            this.btnIngresarNotificador.TabIndex = 13;
            this.btnIngresarNotificador.Text = "Ingresar";
            this.btnIngresarNotificador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIngresarNotificador.UseVisualStyleBackColor = true;
            this.btnIngresarNotificador.Click += new System.EventHandler(this.btnIngresarNotificador_Click);
            // 
            // txtNombreNotificador
            // 
            this.txtNombreNotificador.Location = new System.Drawing.Point(98, 60);
            this.txtNombreNotificador.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreNotificador.Name = "txtNombreNotificador";
            this.txtNombreNotificador.Size = new System.Drawing.Size(409, 22);
            this.txtNombreNotificador.TabIndex = 12;
            // 
            // txtNombreCorto
            // 
            this.txtNombreCorto.Location = new System.Drawing.Point(125, 15);
            this.txtNombreCorto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCorto.Name = "txtNombreCorto";
            this.txtNombreCorto.Size = new System.Drawing.Size(132, 22);
            this.txtNombreCorto.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre Corto";
            // 
            // frmNotificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 581);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvNotificadores);
            this.Controls.Add(this.btnEliminarNotificador);
            this.Controls.Add(this.btnModificarNotificador);
            this.Controls.Add(this.btnIngresarNotificador);
            this.Controls.Add(this.txtNombreNotificador);
            this.Controls.Add(this.txtNombreCorto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(543, 628);
            this.MinimumSize = new System.Drawing.Size(543, 628);
            this.Name = "frmNotificador";
            this.Text = "NOTIFICADOR";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvNotificadores;
        private System.Windows.Forms.Button btnEliminarNotificador;
        private System.Windows.Forms.Button btnModificarNotificador;
        private System.Windows.Forms.Button btnIngresarNotificador;
        private System.Windows.Forms.TextBox txtNombreNotificador;
        private System.Windows.Forms.TextBox txtNombreCorto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}