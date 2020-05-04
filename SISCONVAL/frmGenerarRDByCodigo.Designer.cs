namespace SISCONVAL
{
    partial class frmGenerarRDByCodigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerarRDByCodigo));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtAnioDesde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnioHasta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAnioEjercicio = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNombreCiudadano = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCiudadano = new System.Windows.Forms.Label();
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblInsoluto = new System.Windows.Forms.Label();
            this.lblMora = new System.Windows.Forms.Label();
            this.lblGasAdmin = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdCiudadano:";
            // 
            // txtAnioDesde
            // 
            this.txtAnioDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnioDesde.Location = new System.Drawing.Point(75, 62);
            this.txtAnioDesde.MaxLength = 4;
            this.txtAnioDesde.Name = "txtAnioDesde";
            this.txtAnioDesde.Size = new System.Drawing.Size(116, 27);
            this.txtAnioDesde.TabIndex = 3;
            this.txtAnioDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnioDesde_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde: ";
            // 
            // txtAnioHasta
            // 
            this.txtAnioHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnioHasta.Location = new System.Drawing.Point(75, 94);
            this.txtAnioHasta.MaxLength = 4;
            this.txtAnioHasta.Name = "txtAnioHasta";
            this.txtAnioHasta.Size = new System.Drawing.Size(116, 27);
            this.txtAnioHasta.TabIndex = 5;
            this.txtAnioHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnioDesde_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Año:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAnioEjercicio);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblNombreCiudadano);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblCiudadano);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAnioHasta);
            this.groupBox1.Controls.Add(this.txtAnioDesde);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 234);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS CIUDADANO";
            // 
            // txtAnioEjercicio
            // 
            this.txtAnioEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnioEjercicio.Location = new System.Drawing.Point(320, 28);
            this.txtAnioEjercicio.Name = "txtAnioEjercicio";
            this.txtAnioEjercicio.Size = new System.Drawing.Size(100, 30);
            this.txtAnioEjercicio.TabIndex = 13;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(10, 197);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(59, 20);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Direccion:";
            // 
            // lblNombreCiudadano
            // 
            this.lblNombreCiudadano.AutoSize = true;
            this.lblNombreCiudadano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCiudadano.Location = new System.Drawing.Point(10, 155);
            this.lblNombreCiudadano.Name = "lblNombreCiudadano";
            this.lblNombreCiudadano.Size = new System.Drawing.Size(59, 20);
            this.lblNombreCiudadano.TabIndex = 10;
            this.lblNombreCiudadano.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nombre:";
            // 
            // lblCiudadano
            // 
            this.lblCiudadano.AutoSize = true;
            this.lblCiudadano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudadano.Location = new System.Drawing.Point(109, 28);
            this.lblCiudadano.Name = "lblCiudadano";
            this.lblCiudadano.Size = new System.Drawing.Size(70, 25);
            this.lblCiudadano.TabIndex = 7;
            this.lblCiudadano.Text = "label5";
            // 
            // dgvVistaPrevia
            // 
            this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaPrevia.Location = new System.Drawing.Point(491, 12);
            this.dgvVistaPrevia.Name = "dgvVistaPrevia";
            this.dgvVistaPrevia.RowTemplate.Height = 24;
            this.dgvVistaPrevia.Size = new System.Drawing.Size(585, 234);
            this.dgvVistaPrevia.TabIndex = 9;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(16, 253);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(151, 90);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(492, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Insoluto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(492, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Interes Moratorio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(492, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Gastos Aministrativos:";
            // 
            // lblInsoluto
            // 
            this.lblInsoluto.AutoSize = true;
            this.lblInsoluto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsoluto.ForeColor = System.Drawing.Color.Blue;
            this.lblInsoluto.Location = new System.Drawing.Point(559, 255);
            this.lblInsoluto.Name = "lblInsoluto";
            this.lblInsoluto.Size = new System.Drawing.Size(82, 25);
            this.lblInsoluto.TabIndex = 18;
            this.lblInsoluto.Text = "label10";
            // 
            // lblMora
            // 
            this.lblMora.AutoSize = true;
            this.lblMora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMora.ForeColor = System.Drawing.Color.Blue;
            this.lblMora.Location = new System.Drawing.Point(626, 292);
            this.lblMora.Name = "lblMora";
            this.lblMora.Size = new System.Drawing.Size(82, 25);
            this.lblMora.TabIndex = 19;
            this.lblMora.Text = "label11";
            // 
            // lblGasAdmin
            // 
            this.lblGasAdmin.AutoSize = true;
            this.lblGasAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasAdmin.ForeColor = System.Drawing.Color.Blue;
            this.lblGasAdmin.Location = new System.Drawing.Point(668, 322);
            this.lblGasAdmin.Name = "lblGasAdmin";
            this.lblGasAdmin.Size = new System.Drawing.Size(82, 25);
            this.lblGasAdmin.TabIndex = 20;
            this.lblGasAdmin.Text = "label12";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(893, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Total RD:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblTotal.Location = new System.Drawing.Point(891, 292);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(99, 29);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "label11";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(175, 255);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(151, 90);
            this.btnGenerar.TabIndex = 23;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(334, 255);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(151, 90);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmGenerarRDByCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 356);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblGasAdmin);
            this.Controls.Add(this.lblMora);
            this.Controls.Add(this.lblInsoluto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvVistaPrevia);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1106, 403);
            this.MinimumSize = new System.Drawing.Size(1106, 403);
            this.Name = "frmGenerarRDByCodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GENERACIÓN DE RESOLUCIÓN DE DETERMINACIÓN DE DEUDA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtAnioDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnioHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNombreCiudadano;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCiudadano;
        private System.Windows.Forms.TextBox txtAnioEjercicio;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblInsoluto;
        private System.Windows.Forms.Label lblMora;
        private System.Windows.Forms.Label lblGasAdmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnSalir;
    }
}