using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCONVAL
{
    public partial class frmControlDeuda : Form
    {
        ValoresDataContext BD = new ValoresDataContext();

        public frmControlDeuda()
        {
            InitializeComponent();
            this.ActiveControl = txtNroResolucion;
            //llenamos el combo con los estados del valor
            cmbEstadoValor.Enabled = false;
            var estadovalor = from E in BD.ESTADORD select new {CodigoEstado= E.facodestadord, Estado=E.fadesestado };
            cmbEstadoValor.DataSource = estadovalor;
            cmbEstadoValor.DisplayMember = "Estado";
            cmbEstadoValor.ValueMember = "CodigoEstado";
            //CARGAMOS COMBO DE ORDENES DE PAGO
            

            //cargando resumen de valores
            dgvResumenValoresControlDeuda.MultiSelect = true;
            dgvResumenValoresControlDeuda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResumenValoresControlDeuda.ReadOnly = true;
            dgvResumenValoresControlDeuda.AllowUserToAddRows = false;
            dgvResumenValoresControlDeuda.BackgroundColor = Color.White;
            dgvResumenValoresControlDeuda.RowHeadersVisible = false;
            dgvResumenValoresControlDeuda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //configuracion de grid
            dgvOPlistadeOrdenesPago.MultiSelect = true;
            dgvOPlistadeOrdenesPago.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOPlistadeOrdenesPago.ReadOnly = true;
            dgvOPlistadeOrdenesPago.AllowUserToAddRows = false;
            dgvOPlistadeOrdenesPago.BackgroundColor = Color.White;
            dgvOPlistadeOrdenesPago.RowHeadersVisible = false;
            dgvOPlistadeOrdenesPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dgvEstadoCuentaListaDirecciones.MultiSelect = true;
            dgvEstadoCuentaListaDirecciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstadoCuentaListaDirecciones.ReadOnly = true;
            dgvEstadoCuentaListaDirecciones.AllowUserToAddRows = false;
            dgvEstadoCuentaListaDirecciones.BackgroundColor = Color.White;
            dgvEstadoCuentaListaDirecciones.RowHeadersVisible = false;
            dgvEstadoCuentaListaDirecciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvEstadoCuentaDetalles.MultiSelect = true;
            dgvEstadoCuentaDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstadoCuentaDetalles.ReadOnly = true;
            dgvEstadoCuentaDetalles.AllowUserToAddRows = false;
            dgvEstadoCuentaDetalles.BackgroundColor = Color.White;
            dgvEstadoCuentaDetalles.RowHeadersVisible = false;
            dgvEstadoCuentaDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //agrupando usando la tabla valoresgen, aqui no hay detalles
            var resumen = from V in BD.VALORESGEN
                          group V by V.FAESTADOVALOR into g
                          
                          select new
                          {
                              Codigo = g.First().FAESTADOVALOR,
                              cantidad = g.Count().ToString()
                          };

            //agrupando usando la tabla valoresdet para detalles
         /*   var resumen2 = from D in BD.VALORESDET
                          group D by D.FAANIORESOLUCION && D.FAESTADORD into g

                          select new
                          {
                              Codigo = g.First().,
                              cantidad = g.Count().ToString()
                          };
                          */


            dgvResumenValoresControlDeuda.DataSource = resumen;



            //this.txtNroResolucion.Focus();
            dgvValores.MultiSelect = true;
            dgvValores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvValores.ReadOnly = true;
            dgvValores.AllowUserToAddRows = false;
            dgvValores.BackgroundColor = Color.White;
            dgvValores.RowHeadersVisible = false;
            dgvValores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //llenango el grid con la informacion de los valores
            dgvValores.DataSource = from V in BD.VALORESGEN
                                    orderby V.FNNRORESOLUCION descending
                                    select new { NroResolucion = V.FNNRORESOLUCION, IdCiudadano = V.FAIDCIUDADANO, Ciudadano = V.FAAPELLIDOSYNOMBRES, Estado = V.FAESTADOVALOR, Desde = V.FADESDE, Hasta = V.FAHASTA, Total = V.FNTOTALVALOR, Notificacion = V.FDFECHANOTIF, Vencimiento = V.FDFECHAVENCI, DiasTranscurridos= V.FNDIASTRANS,Observacion = V.FMOBSERVACION };

           // txtNroResolucion.Text = dgvValores.Rows[0].Cells[0].Value.ToString();
            //Cargamos el combo de estado de RD
            cmbEstadoRD.DataSource = from E in BD.ESTADORD select new { FACODESTADORD = E.facodestadord, FADESCRIPCION = E.fadesestado };
            cmbEstadoRD.DisplayMember = "FADESCRIPCION";
            cmbEstadoRD.ValueMember = "FACODESTADORD";

            cmbOPEstado.DataSource = from E in BD.ESTADORD select new { FACODESTADORD = E.facodestadord, FADESCRIPCION = E.fadesestado }; ;
            cmbOPEstado.DisplayMember = "FADESCRIPCION";
            cmbOPEstado.ValueMember = "FACODESTADORD";
            

            //Cargamos a los notificadores en su respectivo combobox
            cmbNotificador.DataSource = from N in BD.NOTIFICADOR select new { CODIGO = N.FACODNOTI, NOMBRE = N.FANOMNOTR };
            cmbNotificador.DisplayMember = "NOMBRE";
            cmbNotificador.ValueMember = "CODIGO";

            cmbOPNotificador.DataSource = from N in BD.NOTIFICADOR select new { CODIGO = N.FACODNOTI, NOMBRE = N.FANOMNOTR };
            cmbOPNotificador.DisplayMember = "NOMBRE";
            cmbOPNotificador.ValueMember = "CODIGO";
            

            txtAnioResolucion.Text = (from V in BD.VALORESGEN orderby V.FAANIORESOLUCION descending select V.FAANIORESOLUCION).Max().ToString();

            lblPendientesNotificar.Text = (from R in BD.VALORESGEN where R.FAESTADOVALOR == "P" select R.FNNRORESOLUCION).Count().ToString();
            lblNotificados.Text = (from R in BD.VALORESGEN where R.FAESTADOVALOR == "N" select R.FNNRORESOLUCION).Count().ToString();
            lblVencidos.Text = (from R in BD.VALORESGEN where R.FDFECHAVENCI.Value.Year !=1990 && R.FDFECHAVENCI.Value<DateTime.Today select R.FNNRORESOLUCION).Count().ToString();

            /*llenado ordenes de pago segundo tab*/
            OP_LlenarDatos(0);

            /*llenando pestaña estado cuenta*/
            // var Listadirecciones = (from D in BD.DEUDAMASIVA orderby D.DIRECCION descending select D.DIRECCION);


            //var Listadirecciones = from D in BD.DEUDAMASIVA
            //                       orderby D.DIRECCION
            //              group D by D.DIRECCION into g
            //              select new
            //              {
            //                  Direccion = g.First().DIRECCION,
            //                  cantidad = g.Count().ToString()
            //              };

            //dgvEstadoCuentaListaDirecciones.DataSource = Listadirecciones;
            // var listadirecciones = (from D in BD.DEUDAMASIVA orderby D.DIRECCION select new { Direccion = D.DIRECCION });
            var listadirecciones = BD.PA_ESTADOCUENTA_RESUMEN("");
            dgvEstadoCuentaListaDirecciones.DataSource = listadirecciones;
            //cmbEstadoCuentaDireccion.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbEstadoCuentaDireccion.DataSource = listadirecciones;
            cmbEstadoCuentaDireccion.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbEstadoCuentaDireccion.AutoCompleteSource = AutoCompleteSource.ListItems;
            


        }
        public void ActualizarDiasTrascurridos()
        {
            //var Resoluciones = from R in BD.VALORESDET select R;
            //VALORESGEN valor = new VALORESGEN();
           // valor = 

        }

        private void dgvValores_SelectionChanged(object sender, EventArgs e)
        {//hacer una evaluacion de la funcionalidad del modulo, definir es es necesaria esta opcion, o si solo se filtrar por ciudadano, notificador, rago de rds, etc
            try
            {/*
                txtNroResolucion.Text = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["NroResolucion"].Value.ToString();
                txtCodigoContrib.Text = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["IdCiudadano"].Value.ToString();
                cmbEstadoRD.Text     = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString();
                var Resolucion = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == txtCodigoContrib.Text select R).First();
                dtpFechaNotificacion.Value = Resolucion.FDFECHANOTIF.Value;
              */
            }
#pragma warning disable CS0168 // La variable 'error' se ha declarado pero nunca se usa
            catch (Exception error)
#pragma warning restore CS0168 // La variable 'error' se ha declarado pero nunca se usa
            {
                //
            }
        }

        private void dgvValores_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaNotificacion_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtpFechaVencimiento.Value = dtpFechaNotificacion.Value.Add(TimeSpan.FromDays(28));
                //MessageBox.Show(dtpFechaNotificacion.Value.DayOfWeek.ToString());

                //VALIDAR SI ES DIA HABIL(NO SABADO Y DOMINGO)
                if (dtpFechaNotificacion.Value.DayOfWeek.ToString() == "Saturday" || dtpFechaNotificacion.Value.DayOfWeek.ToString() == "Sunday")
                {
                    MessageBox.Show("Seleccionar un dia habil de lunes a viernes");
                    // MessageBox.Show(dtpFechaNotificacion.Value.DayOfWeek.ToString());
                }
                //validando los 20 dias habiles de notificacion 
                if (dtpFechaNotificacion.Value.Add(TimeSpan.FromDays(28)).DayOfWeek.ToString() == "Saturday")
                {
                    dtpFechaVencimiento.Value = dtpFechaNotificacion.Value.Add(TimeSpan.FromDays(30));
                }
                if (dtpFechaNotificacion.Value.Add(TimeSpan.FromDays(28)).DayOfWeek.ToString() == "Sunday")
                {
                    dtpFechaVencimiento.Value = dtpFechaNotificacion.Value.Add(TimeSpan.FromDays(29));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DURANTE LA OPERACIÓN: dtpFechaNotificacion_ValueChanged, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
            }
            
        }

        private void btnActualizarNotificador_Click(object sender, EventArgs e)
        {
                try
                {
                    frmNotificador Noti = new frmNotificador();
                    Noti.ShowDialog();
                    cmbNotificador.DataSource = from N in BD.NOTIFICADOR select new { CODIGO = N.FACODNOTI, NOMBRE = N.FANOMNOTR };
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR DURANTE LA OPERACIÓN: btnActualizarNotificador_Click, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
                }
            
        }

        private void txtNroResolucion_TextChanged(object sender, EventArgs e)
        {
            /*
            try
            {
               // if (dgvValores.Rows.Count == 1)
                {
                    dgvValores.DataSource = from V in BD.VALORESGEN where V.FNNRORESOLUCION == int.Parse(txtNroResolucion.Text) && V.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text)  select new { NroResolucion = V.FNNRORESOLUCION, IdCiudadano = V.FAIDCIUDADANO, Ciudadano = V.FAAPELLIDOSYNOMBRES, Estado = V.FAESTADOVALOR, Desde = V.FADESDE, Hasta = V.FAHASTA, Total = V.FNTOTALVALOR, Notificacion = V.FDFECHANOTIF, Vencimiento = V.FDFECHAVENCI, DiasTranscurridos = V.FNDIASTRANS, Observacion = V.FMOBSERVACION };

                    txtCodigoContrib.Text = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["IdCiudadano"].Value.ToString();
                    cmbEstadoRD.Text = (from V in BD.ESTADORD where V.facodestadord == dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString() select V.fadesestado).First().ToString();
                    //cmbEstadoRD.Text = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString();
                    //cmbEstadoRD.ValueMember = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString();
                    var Resolucion = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == txtCodigoContrib.Text && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R).First();
                    dtpFechaNotificacion.Value = Resolucion.FDFECHANOTIF.Value;
                }
                
            }
            catch (Exception error)
            {
                if (txtNroResolucion.Text.Length>0)
                {
                    MessageBox.Show("NUMERO DE RD NO EXISTE O ERROR DURANTE LA OPERACIÓN: txtNroResolucion_TextChanged, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
                }
               
            }
            */
        }

        private void txtCodigoContrib_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (dgvValores.Rows.Count==1)
                if(txtCodigoContrib.Text.Length==9)
                {
                    var Resolucion = from V in BD.VALORESGEN where V.FAIDCIUDADANO == txtCodigoContrib.Text  && V.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select new { NroResolucion = V.FNNRORESOLUCION, IdCiudadano = V.FAIDCIUDADANO, Ciudadano = V.FAAPELLIDOSYNOMBRES, Estado = V.FAESTADOVALOR, Desde = V.FADESDE, Hasta = V.FAHASTA, Total = V.FNTOTALVALOR, Notificacion = V.FDFECHANOTIF, Vencimiento = V.FDFECHAVENCI, DiasTranscurridos = V.FNDIASTRANS, Observacion = V.FMOBSERVACION };
                    dgvValores.DataSource = Resolucion;
                    txtNroResolucion.Text = Resolucion.First().NroResolucion.ToString();
                    cmbEstadoRD.Text = (from E in BD.ESTADORD where E.facodestadord == dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString() select E.fadesestado).First().ToString();
                    //dtpFechaNotificacion.Value = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == txtCodigoContrib.Text && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FDFECHANOTIF).First().Value;
                    //dtpFechaNotificacion.Value = Resolucion.First().Notificacion.Value;
                    dtpFechaNotificacion.Value = (from V in BD.VALORESGEN
                                                 where V.FAIDCIUDADANO == txtCodigoContrib.Text && V.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text)
                                                 select V.FDFECHANOTIF).First().Value;
                    //txtObservacionRD.Text = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == txtCodigoContrib.Text && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FMOBSERVACION).First().ToString();
                    txtObservacionRD.Text = Resolucion.First().Observacion;
                    //cmbNotificador.SelectedValue = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == txtCodigoContrib.Text && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FNIDNOTIFICADOR).First();
                    cmbNotificador.SelectedValue = (from V in BD.VALORESGEN where V.FAIDCIUDADANO == txtCodigoContrib.Text && V.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select V.FNIDNOTIFICADOR).First().Value;

                }
                
            }
#pragma warning disable CS0168 // La variable 'error' se ha declarado pero nunca se usa
            catch (Exception error)
#pragma warning restore CS0168 // La variable 'error' se ha declarado pero nunca se usa
            {
                //if (txtCodigoContrib.Text.Length == 0 || txtCodigoContrib.Text.Length == 9)
                if ( txtCodigoContrib.Text.Length == 9)
                {
                    // MessageBox.Show("CODIGO NO EXISTE O ERROR DURANTE LA OPERACIÓN: txtCodigoContrib_TextChanged, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
                    DialogResult dr = MessageBox.Show("EL CODIGO NO TIENE RESOLUCION, DESEA GENERAR ?",
                       "Advertecia", MessageBoxButtons.YesNo);
                        switch (dr)
                    {
                        case DialogResult.Yes:
                            frmGenerarRDByCodigo newreso = new frmGenerarRDByCodigo(txtCodigoContrib.Text,txtAnioResolucion.Text);
                            newreso.ShowDialog();
                            break;
                        case DialogResult.No:
                            
                            break;
                    }
                }
                
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int anioResolucion = int.Parse(txtAnioResolucion.Text);
                //int nroResolucion = int.Parse(txtNroResolucion.Text);
                int nroResolucion = int.Parse(dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["NroResolucion"].Value.ToString());


                DialogResult dr = MessageBox.Show("Desea Modificar la Resolucion NÚMERO "+nroResolucion.ToString()+" ?", "Advertecia", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        BD.PA_CONTROLDEUDA_MODIFICARVALORCAB(anioResolucion, nroResolucion, cmbEstadoRD.SelectedValue.ToString(), txtObservacionRD.Text, dtpFechaNotificacion.Value, dtpFechaVencimiento.Value, int.Parse(cmbNotificador.SelectedValue.ToString()));
                        var Resolucion = from V in BD.VALORESGEN where V.FNNRORESOLUCION == int.Parse(txtNroResolucion.Text) select new { NroResolucion = V.FNNRORESOLUCION, IdCiudadano = V.FAIDCIUDADANO, Ciudadano = V.FAAPELLIDOSYNOMBRES, Estado = V.FAESTADOVALOR, Desde = V.FADESDE, Hasta = V.FAHASTA, Total = V.FNTOTALVALOR, Notificacion = V.FDFECHANOTIF, Vencimiento = V.FDFECHAVENCI, DiasTranscurridos = V.FNDIASTRANS, Observacion = V.FMOBSERVACION };
                        dgvValores.DataSource = Resolucion;
                        txtNroResolucion.Text = Resolucion.First().NroResolucion.ToString();
                        cmbEstadoRD.Text = (from E in BD.ESTADORD where E.facodestadord == Resolucion.First().Estado select E.fadesestado).First().ToString();
                        dtpFechaNotificacion.Value = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == txtCodigoContrib.Text && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FDFECHANOTIF).First().Value;
                        txtObservacionRD.Text = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == txtCodigoContrib.Text && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FMOBSERVACION).First().ToString();
                        cmbNotificador.SelectedValue = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == txtCodigoContrib.Text && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FNIDNOTIFICADOR).First();
                        MessageBox.Show("Se modifico la informacion.");
                        break;
                    case DialogResult.No:
                        break;
                }


                
            }
#pragma warning disable CS0168 // La variable 'Error' se ha declarado pero nunca se usa
            catch (Exception Error)
#pragma warning restore CS0168 // La variable 'Error' se ha declarado pero nunca se usa
            {
                MessageBox.Show("ERROR DURANTE LA OPERACIÓN: btnActualizar_Click, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoContrib.Text = "";
            txtNroResolucion.Text = "";
            try
            {
                dgvValores.MultiSelect = true;
                dgvValores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvValores.ReadOnly = true;
                dgvValores.AllowUserToAddRows = false;
                dgvValores.BackgroundColor = Color.White;
                dgvValores.RowHeadersVisible = false;
                dgvValores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //llenango el grid con la informacion de los valores
                dgvValores.DataSource = from V in BD.VALORESGEN
                                        orderby V.FNNRORESOLUCION descending
                                        select new { NroResolucion = V.FNNRORESOLUCION, IdCiudadano = V.FAIDCIUDADANO, Ciudadano = V.FAAPELLIDOSYNOMBRES, Estado = V.FAESTADOVALOR, Desde = V.FADESDE, Hasta = V.FAHASTA, Total = V.FNTOTALVALOR, Notificacion = V.FDFECHANOTIF, Vencimiento = V.FDFECHAVENCI, DiasTranscurridos = V.FNDIASTRANS, Observacion = V.FMOBSERVACION };

                // txtNroResolucion.Text = dgvValores.Rows[0].Cells[0].Value.ToString();
                //Cargamos el combo de estado de RD
                cmbEstadoRD.DataSource = from E in BD.ESTADORD select new { FACODESTADORD = E.facodestadord, FADESCRIPCION = E.fadesestado };
                cmbEstadoRD.DisplayMember = "FADESCRIPCION";
                cmbEstadoRD.ValueMember = "FACODESTADORD";
                //Cargamos a los notificadores en su respectivo combobox
                cmbNotificador.DataSource = from N in BD.NOTIFICADOR select new { CODIGO = N.FACODNOTI, NOMBRE = N.FANOMNOTR };
                cmbNotificador.DisplayMember = "NOMBRE";
                cmbNotificador.ValueMember = "CODIGO";

                txtAnioResolucion.Text = (from V in BD.VALORESGEN orderby V.FAANIORESOLUCION descending select V.FAANIORESOLUCION).Max().ToString();

                lblPendientesNotificar.Text = (from R in BD.VALORESGEN where R.FAESTADOVALOR == "P" select R.FNNRORESOLUCION).Count().ToString();
                lblNotificados.Text = (from R in BD.VALORESGEN where R.FAESTADOVALOR == "N" select R.FNNRORESOLUCION).Count().ToString();
                lblVencidos.Text = (from R in BD.VALORESGEN where R.FDFECHAVENCI.Value.Year != 1990 && R.FDFECHAVENCI.Value < DateTime.Today select R.FNNRORESOLUCION).Count().ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Error en Limpiar");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void txtAnioResolucion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                            {
                                e.Handled = true;
                            }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DURANTE LA OPERACIÓN: txtAnioResolucion_KeyPress, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
            }
            
        }

        

        private void txtNroResolucion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DURANTE LA OPERACIÓN: txtNroResolucion_KeyPress, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
            }
           
        }

        private void txtCodigoContrib_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    while (txtCodigoContrib.Text.Length < 9)
                    {
                        txtCodigoContrib.Text = "0" + txtCodigoContrib.Text;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DURANTE LA OPERACIÓN: txtCodigoContrib_KeyPress, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
            }
            
        }

        private void dgvValores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int nroresolucion = int.Parse(dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["NroResolucion"].Value.ToString());
            // string idciudadano = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["IdCiudadano"].Value.ToString();
            var Resolucion = from V in BD.VALORESGEN where V.FNNRORESOLUCION == nroresolucion && V.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select new { NroResolucion = V.FNNRORESOLUCION, IdCiudadano = V.FAIDCIUDADANO, Ciudadano = V.FAAPELLIDOSYNOMBRES, Estado = V.FAESTADOVALOR, Desde = V.FADESDE, Hasta = V.FAHASTA, Total = V.FNTOTALVALOR, Notificacion = V.FDFECHANOTIF, Vencimiento = V.FDFECHAVENCI, DiasTranscurridos = V.FNDIASTRANS, Observacion = V.FMOBSERVACION };
            dgvValores.DataSource = Resolucion;
            txtNroResolucion.Text = Resolucion.First().NroResolucion.ToString();
            cmbEstadoRD.Text = (from E in BD.ESTADORD where E.facodestadord == dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString() select E.fadesestado).First().ToString();
            dtpFechaNotificacion.Value = (from R in BD.VALORESGEN where R.FNNRORESOLUCION == int.Parse(txtNroResolucion.Text) && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FDFECHANOTIF).First().Value;
            txtObservacionRD.Text = (from R in BD.VALORESGEN where R.FNNRORESOLUCION == int.Parse(txtNroResolucion.Text) && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FMOBSERVACION).First().ToString();
            cmbNotificador.SelectedValue = (from R in BD.VALORESGEN where R.FNNRORESOLUCION == int.Parse(txtNroResolucion.Text) && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FNIDNOTIFICADOR).First();

        }

        private void btnImprimirRD_Click(object sender, EventArgs e)
        {
            try
            {
               
                int ANIORESO = int.Parse(txtAnioResolucion.Text);
                int NRORESO = int.Parse(dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["NroResolucion"].Value.ToString());
                frmReporteResolucion RESO = new frmReporteResolucion(ANIORESO, NRORESO, NRORESO);
                RESO.Show();


            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DURANTE LA OPERACIÓN: dgvValores_CellDoubleClick, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodigoContrib.Text.Length == 9)
            {
                // MessageBox.Show("CODIGO NO EXISTE O ERROR DURANTE LA OPERACIÓN: txtCodigoContrib_TextChanged, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
                DialogResult dr = MessageBox.Show("EL CODIGO TIENE RESOLUCION, DESEA GENERAR ?",
                   "Advertecia", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:

                        frmGenerarRDByCodigo newreso = new frmGenerarRDByCodigo(txtCodigoContrib.Text, txtAnioResolucion.Text);
                        newreso.ShowDialog();

                        //Process.Start("I:\\SETUP-GENERARCIONRD\\SISCONVAL.exe", txtCodigoContrib.Text+" "+"2019"+" "+"SISCONVAL");
                        break;
                    case DialogResult.No:

                        break;
                }
            }

        }

        private void dgvValores_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (DateTime.Parse(dgvValores.Rows[e.RowIndex].Cells["Vencimiento"].Value.ToString()).Year!=1990)
            {
                if (DateTime.Parse(dgvValores.Rows[e.RowIndex].Cells["Vencimiento"].Value.ToString()) < DateTime.Today)
                {
                    dgvValores.Rows[e.RowIndex].Cells["Vencimiento"].Style.BackColor = Color.Red;
                    //dgvValores.Rows[e.RowIndex].Cells["DiasTranscurridos"].Value = DateTime.Today.Day- DateTime.Parse(dgvValores.Rows[e.RowIndex].Cells["Vencimiento"].Value.ToString()).Day;
                }
            }
            
        }

        private void btnP1P2_Click(object sender, EventArgs e)
        {
            frmReporteOrdenPagoP1P2 op = new frmReporteOrdenPagoP1P2();
            op.ShowDialog();
        }

        private void btnP2_Click(object sender, EventArgs e)
        {
            frmReporteOrdenPagoP2 op = new frmReporteOrdenPagoP2();
            op.ShowDialog();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiltro.Checked==true)
            {
                cmbEstadoValor.Enabled = true;
            }
            else
            {
                cmbEstadoValor.Enabled = false;
            }
        }

        private void DtpOPFechaNotificacion_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtpOPFechaVencimiento.Value = dtpOPFechaNotificacion.Value.Add(TimeSpan.FromDays(28));
                //MessageBox.Show(dtpFechaNotificacion.Value.DayOfWeek.ToString());

                //VALIDAR SI ES DIA HABIL(NO SABADO Y DOMINGO)
                if (dtpOPFechaNotificacion.Value.DayOfWeek.ToString() == "Saturday" || dtpOPFechaNotificacion.Value.DayOfWeek.ToString() == "Sunday")
                {
                    MessageBox.Show("Seleccionar un dia habil de lunes a viernes");
                    // MessageBox.Show(dtpFechaNotificacion.Value.DayOfWeek.ToString());
                }
                //validando los 20 dias habiles de notificacion 
                if (dtpOPFechaNotificacion.Value.Add(TimeSpan.FromDays(28)).DayOfWeek.ToString() == "Saturday")
                {
                    dtpOPFechaVencimiento.Value = dtpOPFechaNotificacion.Value.Add(TimeSpan.FromDays(30));
                }
                if (dtpOPFechaNotificacion.Value.Add(TimeSpan.FromDays(28)).DayOfWeek.ToString() == "Sunday")
                {
                    dtpOPFechaVencimiento.Value = dtpOPFechaNotificacion.Value.Add(TimeSpan.FromDays(29));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DURANTE LA OPERACIÓN: dtpFechaNotificacion_ValueChanged, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
            }
        }

        private void BtnOPnotificador_Click(object sender, EventArgs e)
        {
            try
            {
                frmNotificador Noti = new frmNotificador();
                Noti.ShowDialog();
                cmbOPNotificador.DataSource = from N in BD.NOTIFICADOR select new { CODIGO = N.FACODNOTI, NOMBRE = N.FANOMNOTR };
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DURANTE LA OPERACIÓN: btnActualizarNotificador_Click, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
            }
        }

        private void CmbOPEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
           // dgvOPlistadeOrdenesPago.DataSource = from O in BD.ORDENESPAGOGEN where O.FAESTADOOP == cmbOPEstado.ValueMember select O;
            
        }

        private void TxtOPNro_TextChanged(object sender, EventArgs e)
        {
            if (txtOPNro.Text.Length==0)
            {
                OP_LlenarDatos(0);
            }
            //

        }
        public void OP_LlenarDatos(int NroOP)
        {
            try
            {//validar para el caso de idciudadano = 0 porque, en el textchange de idciudadano, estamos pasando nro rd 0, y por eso no funciona
                if (txtOPNro.Text.Length > 0)
                {
                    string codigo = (from O in BD.ORDENESPAGOGEN
                                     where O.FNNROOP == NroOP
                                     select O.FAIDCIUDADANO).First().ToString();

                    var Orden = (from O in BD.ORDENESPAGOGEN where O.FAIDCIUDADANO == codigo /*O.FNNROOP == int.Parse(txtOPNro.Text)*/ select new { Año = O.FAANIOOP, Numero = O.FNNROOP, Estado = O.FAESTADOOP, IdCiudadano = O.FAIDCIUDADANO, Nombres = O.FANOMBRES, Periodos = O.FAPERIODOS, Insoluto = O.FNINSOLUTO, GasAdmin = O.FNGASADMIN, Moras = O.FNMORA, TOTAL = O.FNTOTAL, FechaGeneracion = O.FDFECHAGENERACION, FechaNotif = O.FDFECHANOTIF, FechaVenci = O.FDFECHAVENCI, Notificador = O.FNIDNOTIFICADOR, Observacion = O.FAOBSERVACION });
                    dgvOPlistadeOrdenesPago.DataSource = Orden;


                    txtOPCodigoCiudadano.Text = dgvOPlistadeOrdenesPago.Rows[dgvOPlistadeOrdenesPago.CurrentCell.RowIndex].Cells["IdCiudadano"].Value.ToString();
                    cmbOPEstado.Text = (from E in BD.ESTADORD where E.facodestadord == dgvOPlistadeOrdenesPago.Rows[dgvOPlistadeOrdenesPago.CurrentCell.RowIndex].Cells["Estado"].Value.ToString() select E.fadesestado).First().ToString();

                    if (Orden.First().FechaNotif != null)
                    {
                        dtpOPFechaNotificacion.Value = Orden.First().FechaNotif.Value;
                        dtpOPFechaVencimiento.Value = Orden.First().FechaVenci.Value;
                    }
                    else
                    {
                        dtpOPFechaNotificacion.Value = DateTime.Today;
                    }

                    txtOPobservacion.Text = Orden.First().Observacion;
                    cmbOPNotificador.SelectedValue = Orden.First().Notificador;
                }
                else
                {
                    dgvOPlistadeOrdenesPago.DataSource = (from O in BD.ORDENESPAGOGEN where O.FAANIOOP == txtOPAnio.Text select new { Año = O.FAANIOOP, Numero = O.FNNROOP, Estado = O.FAESTADOOP, IdCiudadano = O.FAIDCIUDADANO, Nombres = O.FANOMBRES, Periodos = O.FAPERIODOS, Insoluto = O.FNINSOLUTO, GasAdmin = O.FNGASADMIN, Moras = O.FNMORA, TOTAL = O.FNTOTAL, FechaGeneracion = O.FDFECHAGENERACION, FechaNotif = O.FDFECHANOTIF, FechaVenci = O.FDFECHAVENCI, Notificador = O.FNIDNOTIFICADOR, Observacion = O.FAOBSERVACION });
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error, vuelva a intentarlo.");
            }
           
        }
        public void OP_LlenarDatos2(int NroOP)
        {
            if (txtOPNro.Text.Length > 0)
            {
               /* string codigo = (from O in BD.ORDENESPAGOGEN
                                 where O.FNNROOP == NroOP
                                 select O.FAIDCIUDADANO).First().ToString();*/

                var Orden = (from O in BD.ORDENESPAGOGEN where O.FNNROOP == NroOP select new { Año = O.FAANIOOP, Numero = O.FNNROOP, Estado = O.FAESTADOOP, IdCiudadano = O.FAIDCIUDADANO, Nombres = O.FANOMBRES, Periodos = O.FAPERIODOS, Insoluto = O.FNINSOLUTO, GasAdmin = O.FNGASADMIN, Moras = O.FNMORA, TOTAL = O.FNTOTAL, FechaGeneracion = O.FDFECHAGENERACION, FechaNotif = O.FDFECHANOTIF, FechaVenci = O.FDFECHAVENCI, Notificador = O.FNIDNOTIFICADOR, Observacion = O.FAOBSERVACION });


                txtOPNro.Text = dgvOPlistadeOrdenesPago.Rows[dgvOPlistadeOrdenesPago.CurrentCell.RowIndex].Cells["Numero"].Value.ToString();
                txtOPCodigoCiudadano.Text = dgvOPlistadeOrdenesPago.Rows[dgvOPlistadeOrdenesPago.CurrentCell.RowIndex].Cells["IdCiudadano"].Value.ToString();
                cmbOPEstado.Text = (from E in BD.ESTADORD where E.facodestadord == dgvOPlistadeOrdenesPago.Rows[dgvOPlistadeOrdenesPago.CurrentCell.RowIndex].Cells["Estado"].Value.ToString() select E.fadesestado).First().ToString();

                if (Orden.First().FechaNotif != null)
                {
                    dtpOPFechaNotificacion.Value = Orden.First().FechaNotif.Value;
                    dtpOPFechaVencimiento.Value = Orden.First().FechaVenci.Value;
                }
                else
                {
                    dtpOPFechaNotificacion.Value = DateTime.Today;
                }

                txtOPobservacion.Text = Orden.First().Observacion;
                cmbOPNotificador.SelectedValue = Orden.First().Notificador;
            }
        }

        private void BtnOPActualizar_Click(object sender, EventArgs e)
        {
            
            BD.PA_CONTROLDEUDA_MODIFICAR_OP(int.Parse(txtOPAnio.Text), int.Parse(txtOPNro.Text), cmbOPEstado.SelectedValue.ToString(), txtOPobservacion.Text, dtpOPFechaNotificacion.Value, dtpOPFechaVencimiento.Value, int.Parse(cmbOPNotificador.SelectedValue.ToString()));

            MessageBox.Show("Se Modifico la informacion");
            OP_LlenarDatos(int.Parse(txtOPNro.Text));

        }

        private void BtnOPSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOPVistaPrevia_Click(object sender, EventArgs e)
        {
            string Periodos = dgvOPlistadeOrdenesPago.Rows[dgvOPlistadeOrdenesPago.CurrentCell.RowIndex].Cells["Periodos"].Value.ToString();
            if (Periodos == "P1P2")
            {

            }
            if (Periodos == "P2")
            {

            }
        }

        private void BtnActualizarFecha_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach (DataGridViewRow Filas in dgvValores.SelectedRows)
            {
                int fnnroresolucion = int.Parse(dgvValores.Rows[Filas.Index].Cells["NroResolucion"].Value.ToString());
                int faanioresolucion = 2019;
                //MessageBox.Show("nro resolucion: "+fnnroresolucion.ToString()+" faanioresolucion: "+faanioresolucion.ToString());
                BD.PA_CONTROLDEUDA_MODIFICAR_FECHEMISI(fnnroresolucion, faanioresolucion, DateTime.Now);

                contador++;

            }
            MessageBox.Show("Se actualizaron " + contador.ToString() + " registros");
        }

        private void TxtOPCodigoCiudadano_TextChanged(object sender, EventArgs e)
        {
            /*  if (txtOPCodigoCiudadano.Text.Length == 9)
              {
                  txtOPNro.Text = (from O in BD.ORDENESPAGOGEN where O.FAIDCIUDADANO == txtOPCodigoCiudadano.Text && O.FAANIOOP == txtOPAnio.Text select O.FNNROOP).First().ToString();
                  OP_LlenarDatos();
              }
              */
            if (txtOPCodigoCiudadano.Text.Length==0)
            {
                OP_LlenarDatos(0);
            }
        }

        private void TxtOPCodigoCiudadano_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    while (txtOPCodigoCiudadano.Text.Length < 9)
                    {
                        txtOPCodigoCiudadano.Text = "0" + txtOPCodigoCiudadano.Text;
                    }
                    if (txtOPCodigoCiudadano.Text.Length == 9)
                    {
                        txtOPNro.Text = (from O in BD.ORDENESPAGOGEN where O.FAIDCIUDADANO == txtOPCodigoCiudadano.Text && O.FAANIOOP == txtOPAnio.Text select O.FNNROOP).First().ToString();
                        OP_LlenarDatos(int.Parse(txtOPNro.Text));
                    }

                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DURANTE LA OPERACIÓN: TxtOPCodigoCiudadano_KeyPress, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
            }
        }

        private void BtnEstadoCuentaImprimir_Click(object sender, EventArgs e)
        {
            
            string DIRECCION = dgvEstadoCuentaListaDirecciones.Rows[dgvEstadoCuentaListaDirecciones.CurrentCell.RowIndex].Cells["Direccion"].Value.ToString().Trim();
            if (chkDeudaMAsiva.Checked == true)
            {
                frmReportCristalEstadoMasivo cuenta = new frmReportCristalEstadoMasivo("", "", 2);
                cuenta.ShowDialog();
            }
            else
            {
                if (chbEstCuentPorId.Checked == true && chbEstCuenPorDireccion.Checked == true)
                {
                    frmReportCristalEstadoMasivo cuenta = new frmReportCristalEstadoMasivo(txtEstadoCuentaIdCiudadano.Text.Trim(), DIRECCION, 0);
                    cuenta.ShowDialog();
                }
                else
                {
                    if (chbEstCuentPorId.Checked == true)
                    {
                        if (txtEstadoCuentaIdCiudadano.Text.Length > 0)
                        {
                            frmReportCristalEstadoMasivo cuenta = new frmReportCristalEstadoMasivo(txtEstadoCuentaIdCiudadano.Text.Trim(), "", 1);
                            cuenta.ShowDialog();
                        }

                    }
                    else
                    {
                        if (DIRECCION.Length > 0)
                        {
                            frmReportCristalEstadoMasivo cuenta = new frmReportCristalEstadoMasivo("", DIRECCION, 0);
                            cuenta.ShowDialog();
                        }

                    }
                }
            }
            
            

            
        }

        private void TxtEstadoCuentaDireccion_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void TxtEstadoCuentaDireccion_KeyDown(object sender, KeyEventArgs e)
        {

            if (txtEstadoCuentaDireccion.Text.Length > 0 && e.KeyCode== Keys.Enter)
            {
               /*
                var Listadirecciones = from D in BD.DEUDAMASIVA
                                       where SqlMethods.Like(D.DIRECCION, "%" + txtEstadoCuentaDireccion.Text + "%") && D.ESTADO=="PENDIENTE"
                                       orderby D.DIRECCION ascending
                                       select new
                                       {
                                           Direccion = D.DIRECCION
                                       };

                dgvEstadoCuentaListaDirecciones.DataSource = Listadirecciones.Distinct();*/
            }
        }

        private void DgvEstadoCuentaListaDirecciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEstadoCuentaListaDirecciones.Rows.Count>0)
            {
                String direccion = dgvEstadoCuentaListaDirecciones.Rows[dgvEstadoCuentaListaDirecciones.CurrentCell.RowIndex].Cells["Direccion"].Value.ToString();
                if (direccion.ToString().Length >= 0)
                {
                    //var detalles = from D in BD.DEUDAMASIVA where D.DIRECCION == direccion && D.ESTADO == "PENDIENTE" select new { Id = D.IDCIUDADANO, Nombre = D.NOMBRECOMPLETO, Direccion = D.DIRECCION, Numero = D.NUMERO };
                    //var detalles =  (from D in BD.PA_ESTADOCUETA_DETALLES(direccion)  select new {Id= D.Id, Nombre= D.Nombre }).ToList();  
                    var detalles = BD.PA_ESTADOCUETA_DETALLES(direccion).ToList();
                    dgvEstadoCuentaDetalles.DataSource = detalles;
                    lblEstadoCuentaCantidad.Text = detalles.Count().ToString();
                    lblPredialInsoluto.Text = decimal.Parse((from C in detalles select C.PREDIAL_INSOLUTO).Sum().ToString()).ToString("N2");
                    lblPredialMora.Text = decimal.Parse((from C in detalles select C.PREDIAL_MORA).Sum().ToString()).ToString("N2");
                    lblPredialGasAdmin.Text = decimal.Parse((from C in detalles select C.PREDIAL_GASADMIN).Sum().ToString()).ToString("N2");
                    lblPredialTotal.Text = decimal.Parse((from C in detalles select C.PREDIAL_TOTAL).Sum().ToString()).ToString("N2");
                    lblTotalSeguridad.Text = decimal.Parse((from C in detalles select C.SEGURIDAD).Sum().ToString()).ToString("N2");
                }
            }
            
        }
        public void ResumenEstadoCuentaByDireccion()
        {
            float Insoluto = 0;
            float GasAdmin = 0;
            float Mora = 0;
            float SubTotalPRedial = 0;
            float SubTotalSeguridad = 0;
            
            for (int i = 0; i < dgvEstadoCuentaDetalles.Rows.Count; i++)
            {
                Insoluto = Insoluto + float.Parse(dgvEstadoCuentaDetalles.Rows[i].Cells["PREDIAL_INSOLUTO"].Value.ToString());
                GasAdmin = GasAdmin + float.Parse(dgvEstadoCuentaDetalles.Rows[i].Cells["PREDIAL_GASADMIN"].Value.ToString());
                Mora = Mora + float.Parse(dgvEstadoCuentaDetalles.Rows[i].Cells["PREDIAL_MORA"].Value.ToString());
                SubTotalSeguridad = SubTotalSeguridad + float.Parse(dgvEstadoCuentaDetalles.Rows[i].Cells["SEGURIDAD"].Value.ToString());
            }
            SubTotalPRedial = Insoluto + GasAdmin + Mora;
        }

        private void ChbEstCuenPorDireccion_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEstCuenPorDireccion.Checked== true)
            {
                txtEstadoCuentaDireccion.Enabled = true;
            }
            else
            {
                txtEstadoCuentaDireccion.Enabled = false;
                txtEstadoCuentaDireccion.Text = "";
            }
        }

        private void ChbEstCuentPorId_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEstCuentPorId.Checked==true)
            {
                txtEstadoCuentaIdCiudadano.Enabled = true;
                chbEstCuenPorDireccion.Checked = false;
            }
            else
            {
                txtEstadoCuentaIdCiudadano.Enabled = false;
                chbEstCuenPorDireccion.Checked = true;
            }
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (txtEstadoCuentaDireccion.Text.Length > 0 )
            {

                /*var Listadirecciones = from D in BD.DEUDAMASIVA
                                       where SqlMethods.Like(D.DIRECCION, "%" + txtEstadoCuentaDireccion.Text + "%") && D.ESTADO == "PENDIENTE"
                                       orderby D.DIRECCION ascending
                                       select new
                                       {
                                           Direccion = D.DIRECCION
                                       };*/

                var Listadirecciones = BD.PA_ESTADOCUENTA_RESUMEN(txtEstadoCuentaDireccion.Text);
                dgvEstadoCuentaListaDirecciones.DataSource = Listadirecciones;
            }
            else
            {
                if (txtEstadoCuentaDireccion.Text.Length == 0)
                {
                    var Listadirecciones = BD.PA_ESTADOCUENTA_RESUMEN(txtEstadoCuentaDireccion.Text);
                    dgvEstadoCuentaListaDirecciones.DataSource = Listadirecciones;
                }
            }
        }

        private void BtnImprimirOps_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkP1.Checked == true && chkP2.Checked == true && chkP3.Checked == true && chkP4.Checked == false)
                {
                    frmReporteOrdenPagoP1P2P3 reporteP1P2P3 = new frmReporteOrdenPagoP1P2P3();
                    reporteP1P2P3.ShowDialog();
                }
                if (chkP1.Checked == false && chkP2.Checked == true && chkP3.Checked == true && chkP4.Checked == false)
                {
                    frmReporteOrdenPagoP2P3 reportP2P3 = new frmReporteOrdenPagoP2P3();
                    reportP2P3.ShowDialog();
                }
                if (chkP1.Checked == false && chkP2.Checked == true && chkP3.Checked == false && chkP4.Checked == false)
                {
                    frmReporteOrdenPagoP2 reporteP2 = new frmReporteOrdenPagoP2();
                    reporteP2.ShowDialog();
                }
                if (chkP1.Checked == false && chkP2.Checked == false && chkP3.Checked == true && chkP4.Checked == false)
                {
                    frmReporteOrdenPagoP3 reporteP3 = new frmReporteOrdenPagoP3();
                    reporteP3.ShowDialog();
                }
                if (chkP1.Checked == true && chkP2.Checked == true && chkP3.Checked == false && chkP4.Checked == false)
                {
                    frmReporteOrdenPagoP1P2 reporteP1P2 = new frmReporteOrdenPagoP1P2();
                    reporteP1P2.ShowDialog();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void DgvOPlistadeOrdenesPago_SelectionChanged(object sender, EventArgs e)
        {

            
        }

        private void DgvOPlistadeOrdenesPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string NroOP = dgvOPlistadeOrdenesPago.Rows[dgvOPlistadeOrdenesPago.CurrentCell.RowIndex].Cells["Numero"].Value.ToString();
            txtOPNro.Text = NroOP;
            OP_LlenarDatos2(int.Parse(NroOP));
        }

        private void TxtOPNro_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtOPNro.Text.Length > 0 && e.KeyCode == Keys.Enter)
            {
                OP_LlenarDatos(int.Parse(txtOPNro.Text));
            }
        }

        private void TxtNroResolucion_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtAnioResolucion.Text.Length > 0 && e.KeyCode == Keys.Enter)
            {
                try
                {
                    // if (dgvValores.Rows.Count == 1)
                    {
                        var Resolucion = (from R in BD.VALORESGEN where R.FNNRORESOLUCION == int.Parse(txtNroResolucion.Text) && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R).First();

                        dgvValores.DataSource = from V in BD.VALORESGEN where V.FAIDCIUDADANO==Resolucion.FAIDCIUDADANO && V.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select new { NroResolucion = V.FNNRORESOLUCION, IdCiudadano = V.FAIDCIUDADANO, Ciudadano = V.FAAPELLIDOSYNOMBRES, Estado = V.FAESTADOVALOR, Desde = V.FADESDE, Hasta = V.FAHASTA, Total = V.FNTOTALVALOR, Notificacion = V.FDFECHANOTIF, Vencimiento = V.FDFECHAVENCI, DiasTranscurridos = V.FNDIASTRANS, Observacion = V.FMOBSERVACION };

                        txtCodigoContrib.Text = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["IdCiudadano"].Value.ToString();
                        cmbEstadoRD.Text = (from V in BD.ESTADORD where V.facodestadord == dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString() select V.fadesestado).First().ToString();
                        //cmbEstadoRD.Text = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString();
                        //cmbEstadoRD.ValueMember = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString();
                        //var Resolucion = (from R in BD.VALORESGEN where R.FNNRORESOLUCION == int.Parse(txtNroResolucion.Text) && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R).First();
                        dtpFechaNotificacion.Value = Resolucion.FDFECHANOTIF.Value;
                        txtObservacionRD.Text = Resolucion.FMOBSERVACION;
                        cmbNotificador.SelectedValue = Resolucion.FNIDNOTIFICADOR.ToString();

                    }

                }
#pragma warning disable CS0168 // La variable 'error' se ha declarado pero nunca se usa
                catch (Exception error)
#pragma warning restore CS0168 // La variable 'error' se ha declarado pero nunca se usa
                {
                    if (txtNroResolucion.Text.Length > 0)
                    {
                        MessageBox.Show("NUMERO DE RD NO EXISTE O ERROR DURANTE LA OPERACIÓN: txtNroResolucion_TextChanged, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
                    }

                }
            }
        }

        private void DgvValores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //if (dgvValores.Rows.Count==1)
                {
                    int NroResolucion = int.Parse(dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["NroResolucion"].Value.ToString());
                    var Resolucion = from V in BD.VALORESGEN where V.FNNRORESOLUCION == NroResolucion && V.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select new { NroResolucion = V.FNNRORESOLUCION, IdCiudadano = V.FAIDCIUDADANO, Ciudadano = V.FAAPELLIDOSYNOMBRES, Estado = V.FAESTADOVALOR, Desde = V.FADESDE, Hasta = V.FAHASTA, Total = V.FNTOTALVALOR, Notificacion = V.FDFECHANOTIF, Vencimiento = V.FDFECHAVENCI, DiasTranscurridos = V.FNDIASTRANS, Observacion = V.FMOBSERVACION };
                    //dgvValores.DataSource = Resolucion;
                    txtNroResolucion.Text = Resolucion.First().NroResolucion.ToString();
                    cmbEstadoRD.Text = (from E in BD.ESTADORD where E.facodestadord == dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString() select E.fadesestado).First().ToString();
                    dtpFechaNotificacion.Value = (from R in BD.VALORESGEN where R.FNNRORESOLUCION == NroResolucion && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FDFECHANOTIF).First().Value;
                    txtObservacionRD.Text = (from R in BD.VALORESGEN where R.FNNRORESOLUCION == NroResolucion && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FMOBSERVACION).First().ToString();
                    cmbNotificador.SelectedValue = (from R in BD.VALORESGEN where R.FNNRORESOLUCION == NroResolucion && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FNIDNOTIFICADOR).First();

                }

            }
#pragma warning disable CS0168 // La variable 'error' se ha declarado pero nunca se usa
            catch (Exception error)
#pragma warning restore CS0168 // La variable 'error' se ha declarado pero nunca se usa
            {
                //if (txtCodigoContrib.Text.Length == 0 || txtCodigoContrib.Text.Length == 9)
                if (txtCodigoContrib.Text.Length == 9)
                {
                    // MessageBox.Show("CODIGO NO EXISTE O ERROR DURANTE LA OPERACIÓN: txtCodigoContrib_TextChanged, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
                    DialogResult dr = MessageBox.Show("EL CODIGO NO TIENE RESOLUCION, DESEA GENERAR ?",
                       "Advertecia", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            frmGenerarRDByCodigo newreso = new frmGenerarRDByCodigo(txtCodigoContrib.Text, txtAnioResolucion.Text);
                            newreso.ShowDialog();
                            break;
                        case DialogResult.No:

                            break;
                    }
                }

            }
        }

        private void BtnMasivo_Click(object sender, EventArgs e)
        {
            frmReporteResolucion resolucionmasiv = new frmReporteResolucion(2019, 2560, 2560);
            resolucionmasiv.ShowDialog();
            /*frmResporteResolucionMasiva resomasiv = new frmResporteResolucionMasiva(2019, 2560,2570);
            resomasiv.ShowDialog();*/
            /*frmReporteRD_Masiv report = new frmReporteRD_Masiv(2019,1,1714);*/
            /*report.ShowDialog();*/
        }

        private void txtAnioResolucion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarByNro_Click(object sender, EventArgs e)
        {
            try
            {
                // if (dgvValores.Rows.Count == 1)
                {
                    dgvValores.DataSource = from V in BD.VALORESGEN where V.FNNRORESOLUCION == int.Parse(txtNroResolucion.Text) && V.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select new { NroResolucion = V.FNNRORESOLUCION, IdCiudadano = V.FAIDCIUDADANO, Ciudadano = V.FAAPELLIDOSYNOMBRES, Estado = V.FAESTADOVALOR, Desde = V.FADESDE, Hasta = V.FAHASTA, Total = V.FNTOTALVALOR, Notificacion = V.FDFECHANOTIF, Vencimiento = V.FDFECHAVENCI, DiasTranscurridos = V.FNDIASTRANS, Observacion = V.FMOBSERVACION };

                    txtCodigoContrib.Text = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["IdCiudadano"].Value.ToString();
                    cmbEstadoRD.Text = (from V in BD.ESTADORD where V.facodestadord == dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString() select V.fadesestado).First().ToString();
                    //cmbEstadoRD.Text = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString();
                    //cmbEstadoRD.ValueMember = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString();
                    var Resolucion = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == txtCodigoContrib.Text && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R).First();
                    dtpFechaNotificacion.Value = Resolucion.FDFECHANOTIF.Value;
                }

            }
            catch (Exception error)
            {
                if (txtNroResolucion.Text.Length > 0)
                {
                    MessageBox.Show("NUMERO DE RD NO EXISTE O ERROR DURANTE LA OPERACIÓN: txtNroResolucion_TextChanged, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
                }

            }
        }
    }
}
