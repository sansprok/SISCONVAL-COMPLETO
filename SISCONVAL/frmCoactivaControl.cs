using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCONVAL
{
    public partial class frmCoactivaControl : Form
    {
        ValoresDataContext BD = new ValoresDataContext();
        string TipoValor="RD";
        public frmCoactivaControl()
        {
            InitializeComponent();
            txtExpedienteAnio.Text = DateTime.Today.Year.ToString();
            //dgvExpedientesCoac.DataSource = from R in BD.REQCOACGEN where R.FAANIOEXPED==txtExpedienteAnio.Text && R.FATIPOVALOR==TipoValor select new {R.FAANIOEXPED, R.FANROEXPED, R.FAANIORESOLUCION, R.FANRORESOLUCION, R.FAIDCIUDADANO,R.FAAPELLIDOSYNOMBRES, R.FAANIOINICIO,R.FAANIOFIN,R.FAREQCALIFICA,R.FNIMPCOACT, R.FNCOSPROCE, R.FADOMFISCAL };
            /*INICIO DE CONFIGURACION DEL GRID*/

            dgvExpedientesCoac.MultiSelect = true;
            dgvExpedientesCoac.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpedientesCoac.ReadOnly = true;
            dgvExpedientesCoac.AllowUserToAddRows = false;
            dgvExpedientesCoac.BackgroundColor = Color.White;
            dgvExpedientesCoac.RowHeadersVisible = false;
            dgvExpedientesCoac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //pintarGridCoac();
            /*FIN DE CONFIGURACION DEL GRID*/
                cmbExpedienteCalifica.DataSource = from C in BD.CALIFICACION select C;
                cmbExpedienteCalifica.DisplayMember = "FADESCALIFI";
                cmbExpedienteCalifica.ValueMember = "FACODCALIFI";

            cmbExpedienteEstado.DataSource = from D in BD.ESTADOREQCOAC select D;
            cmbExpedienteEstado.DisplayMember = "FADESESTADOREQ";
            cmbExpedienteEstado.ValueMember = "FACODESTADOREQ";

            cmbExpedienteNotificador.DataSource = from N in BD.NOTIFICADOR select new { CODIGO = N.FACODNOTI, NOMBRE = N.FANOMNOTR };
            cmbExpedienteNotificador.DisplayMember = "NOMBRE";
            cmbExpedienteNotificador.ValueMember = "CODIGO";

            cmbExpedienteAuxiliar.DataSource = from N in BD.AUXILIAR select new { CODIGO = N.FACODAUX, NOMBRE = N.FANOMAUXI };
            cmbExpedienteAuxiliar.DisplayMember = "NOMBRE";
            cmbExpedienteAuxiliar.ValueMember = "CODIGO";

            
            txtFechaResolucion.Text = DateTime.Today.ToShortDateString();
            //controles del reporte
            cmbResporteCoacEstado.DataSource = from C in BD.CALIFICACION select C;
            cmbResporteCoacEstado.DisplayMember = "FADESCALIFI";
            cmbResporteCoacEstado.ValueMember = "FACODCALIFI";
            txtReporteCoacAnioExpediente.Text = (from R in BD.REQCOACGEN orderby R.FAANIOEXPED descending select R.FAANIOEXPED).First().ToString();

            dgvExpedientesCoac.ClearSelection();
        }

        private void btnExpSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtExpedienteIdCiudadano_TextChanged(object sender, EventArgs e)
        {
            try
            {
                /*if (txtExpedienteIdCiudadano.Text.Length >= 9 && rdbRD.Checked == true)
                {
                    dgvExpedientesCoac.DataSource = from R in BD.REQCOACGEN where R.FAIDCIUDADANO == txtExpedienteIdCiudadano.Text && R.FATIPOVALOR=="RD" select new { R.FAANIOEXPED, R.FANROEXPED, R.FAANIORESOLUCION, R.FANRORESOLUCION, R.FAIDCIUDADANO, R.FAAPELLIDOSYNOMBRES, R.FAANIOINICIO, R.FAANIOFIN, R.FAREQCALIFICA, R.FNIMPCOACT, R.FNCOSPROCE, R.FADOMFISCAL };
                    var expediente = (from R in BD.REQCOACGEN where R.FAIDCIUDADANO == txtExpedienteIdCiudadano.Text && R.FATIPOVALOR=="RD" select R).First();
                    lblExpFechaEnvio.Text = expediente.FDFECENVIO.ToString();
                    txtExpedienteNroReso.Text = expediente.FANRORESOLUCION;
                    txtExpedienteNro.Text = expediente.FANROEXPED;
                    txtExpedienteAnio.Text = expediente.FAANIOEXPED;
                    cmbExpedienteCalifica.Text = (from C in BD.CALIFICACION where C.FACODCALIFI == expediente.FAREQCALIFICA select C.FADESCALIFI).First().ToString();
                    dtpExpedienteFechaNotificacion.Text = expediente.FDFECNOTIF.ToString();
                    txtExpObservacion.Text = expediente.FAOBSERVACION;
                    cmbExpedienteAuxiliar.SelectedValue = expediente.FNCODAUXILIAR;
                    cmbExpedienteNotificador.SelectedValue = expediente.FNCODNOTIFICADOR;
                }
                else
                {
                    dgvExpedientesCoac.DataSource = from R in BD.REQCOACGEN where R.FAIDCIUDADANO == txtExpedienteIdCiudadano.Text && R.FATIPOVALOR == "OP" select new { R.FAANIOEXPED, R.FANROEXPED, R.FAANIORESOLUCION, R.FANRORESOLUCION, R.FAIDCIUDADANO, R.FAAPELLIDOSYNOMBRES, R.FAANIOINICIO, R.FAANIOFIN, R.FAREQCALIFICA, R.FNIMPCOACT, R.FNCOSPROCE, R.FADOMFISCAL };
                    var expediente = (from R in BD.REQCOACGEN where R.FAIDCIUDADANO == txtExpedienteIdCiudadano.Text && R.FATIPOVALOR == "OP" select R).First();
                    lblExpFechaEnvio.Text = expediente.FDFECENVIO.ToString();
                    txtExpedienteNroReso.Text = expediente.FANRORESOLUCION;
                    txtExpedienteNro.Text = expediente.FANROEXPED;
                    txtExpedienteAnio.Text = expediente.FAANIOEXPED;
                    cmbExpedienteCalifica.Text = (from C in BD.CALIFICACION where C.FACODCALIFI == expediente.FAREQCALIFICA select C.FADESCALIFI).First().ToString();
                    dtpExpedienteFechaNotificacion.Text = expediente.FDFECNOTIF.ToString();
                    txtExpObservacion.Text = expediente.FAOBSERVACION;
                    cmbExpedienteAuxiliar.SelectedValue = expediente.FNCODAUXILIAR;
                    cmbExpedienteNotificador.SelectedValue = expediente.FNCODNOTIFICADOR;
                }*/
                if (txtExpedienteIdCiudadano.Text.Length >= 9)
                {
                    dgvExpedientesCoac.DataSource = from R in BD.REQCOACGEN where R.FAIDCIUDADANO == txtExpedienteIdCiudadano.Text && R.FATIPOVALOR == (rdbRD.Checked?"RD":"OP") select new { R.FAANIOEXPED, R.FANROEXPED, R.FAANIORESOLUCION, R.FANRORESOLUCION, R.FAIDCIUDADANO, R.FAAPELLIDOSYNOMBRES, R.FAANIOINICIO, R.FAANIOFIN, R.FAREQCALIFICA, R.FNIMPCOACT, R.FNCOSPROCE, R.FADOMFISCAL };
                    var expediente = (from R in BD.REQCOACGEN where R.FAIDCIUDADANO == txtExpedienteIdCiudadano.Text && R.FATIPOVALOR == (rdbRD.Checked ? "RD" : "OP") select R).First();
                    lblExpFechaEnvio.Text = expediente.FDFECENVIO.ToString();
                    txtExpedienteNroReso.Text = expediente.FANRORESOLUCION;
                    txtExpedienteNro.Text = expediente.FANROEXPED;
                    txtExpedienteAnio.Text = expediente.FAANIOEXPED;
                    txtAnioValor.Text = expediente.FAANIORESOLUCION;
                    cmbExpedienteCalifica.Text = (from C in BD.CALIFICACION where C.FACODCALIFI == expediente.FAREQCALIFICA select C.FADESCALIFI).First().ToString();
                    dtpExpedienteFechaNotificacion.Text = expediente.FDFECNOTIF.ToString();
                    txtExpObservacion.Text = expediente.FAOBSERVACION;
                    cmbExpedienteAuxiliar.SelectedValue = expediente.FNCODAUXILIAR;
                    cmbExpedienteNotificador.SelectedValue = expediente.FNCODNOTIFICADOR;
                    dgvExpedientesCoac.ClearSelection();
                  //  PintarGrid_EstadoCuentaIP(txtExpedienteIdCiudadano.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("VALOR PENDIENTE DE REMISION");
               // dgvExpedientesCoac.ClearSelection();
               // PintarGrid_EstadoCuentaIP(txtExpedienteIdCiudadano.Text);
            }
            
        }

        private void txtExpedienteIdCiudadano_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    while (txtExpedienteIdCiudadano.Text.Length < 9)
                    {
                        txtExpedienteIdCiudadano.Text = "0" + txtExpedienteIdCiudadano.Text;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DURANTE LA OPERACIÓN: txtExpedienteIdCiudadano_KeyPress, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
            }
        }

        private void dgvExpedientesCoac_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void btnExpedienteActualizarNotifi_Click(object sender, EventArgs e)
        {
            try
            {
                frmAuxiliar Noti = new frmAuxiliar();
                Noti.ShowDialog();
                cmbExpedienteAuxiliar.DataSource = from N in BD.AUXILIAR select new { CODIGO = N.FACODAUX, NOMBRE = N.FANOMAUXI };
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DURANTE LA OPERACIÓN: btnExpedienteActualizarNotifi_Click, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
            }
        }

        private void btnExpedienteActualizarNoti_Click(object sender, EventArgs e)
        {
            try
            {
                frmNotificador Noti = new frmNotificador();
                Noti.ShowDialog();
                cmbExpedienteNotificador.DataSource = from N in BD.NOTIFICADOR select new { CODIGO = N.FACODNOTI, NOMBRE = N.FANOMNOTR };
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DURANTE LA OPERACIÓN: btnExpedienteActualizarNoti_Click, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
            }
        }
        public void PintarGrid_EstadoCuentaIP(string idciudadano)
        {
            try
            {
                for (int i = 0; i < dgvExpedientesCoac.Rows.Count; i++)
                {
                    string auxidciudadano = dgvExpedientesCoac.Rows[i].Cells["FAIDCIUDADANO"].Value.ToString();
                    int desde = int.Parse(dgvExpedientesCoac.Rows[i].Cells["FAANIOINICIO"].Value.ToString());
                    int hasta = int.Parse(dgvExpedientesCoac.Rows[i].Cells["FAANIOFIN"].Value.ToString());
                    var ESTADOACTUAL = (from E in BD.PA_COAC_ESTADODEDEUDA_IP(auxidciudadano, desde, hasta) select E).First();

                    var REQCOAC = from R in BD.REQCOACGEN where R.FAIDCIUDADANO == txtExpedienteIdCiudadano.Text && R.FAANIOEXPED == txtExpedienteAnio.Text && R.FAANIORESOLUCION == txtAnioValor.Text && R.FANRORESOLUCION == txtExpedienteNroReso.Text select R;

                    decimal totalvalor = decimal.Parse(REQCOAC.First().FNIMPINSOLUTO.ToString()) + decimal.Parse(REQCOAC.First().FNIMPGASADMIN.ToString());
                    float totalpagado = float.Parse(ESTADOACTUAL.PAGADOINSOLUTO.Value.ToString()) + float.Parse(ESTADOACTUAL.PAGADOGASADMIN.Value.ToString());
                    float totalsaldo = float.Parse(ESTADOACTUAL.SALDOINSOLUTO.Value.ToString()) + float.Parse(ESTADOACTUAL.SALDOGASADMIN.Value.ToString()) ;

                    //pago total
                    if (totalsaldo == 0)
                    {
                        //dgvExpedientesCoac.Rows[i].Cells["Vencimiento"].Style.BackColor = Color.Red;
                        dgvExpedientesCoac.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }

                    //pago parcial
                    if (totalsaldo > 0 && totalpagado>0)
                    {
                        dgvExpedientesCoac.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    }

                    //no hico pago alguno
                    if ( totalpagado == 0)
                    {
                        dgvExpedientesCoac.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }

                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
            }
            
        }

        private void txtExpedienteNroReso_TextChanged(object sender, EventArgs e)
        {
            /*try
            {
                
                {

                    dgvExpedientesCoac.DataSource = from V in BD.REQCOACGEN where V.FANRORESOLUCION == txtExpedienteNroReso.Text && V.FAANIOEXPED == txtExpedienteAnio.Text && V.FATIPOVALOR == (rdbRD.Checked ? "RD" : "OP") select new { V.FAANIOEXPED, V.FANROEXPED, V.FAANIORESOLUCION, V.FANRORESOLUCION, IDCIUDADANO = V.FAIDCIUDADANO, V.FAAPELLIDOSYNOMBRES, V.FAANIOINICIO, V.FAANIOFIN, V.FAREQCALIFICA, V.FNIMPCOACT, V.FNCOSPROCE, V.FADOMFISCAL };
                    //if (dgvExpedientesCoac.Rows.Count==0)
                    //{
                    //    MessageBox.Show("VALOR PENDIENTE DE TRANSFERENCIA A EJECUCIÓN COACTIVA", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    txtExpedienteIdCiudadano.Text = dgvExpedientesCoac.Rows[dgvExpedientesCoac.CurrentCell.RowIndex].Cells["IDCIUDADANO"].Value.ToString();
                    // cmbExpedienteCalifica.Text = (from V in BD.CALIFICACION where V.FACODCALIFI == dgvExpedientesCoac.Rows[dgvExpedientesCoac.CurrentCell.RowIndex].Cells["FAREQCALIFICA"].Value.ToString() select V.FADESCALIFI).First().ToString();
                    var Resolucion = (from R in BD.REQCOACGEN where R.FAIDCIUDADANO == txtExpedienteIdCiudadano.Text && R.FANRORESOLUCION == txtExpedienteNroReso.Text && R.FATIPOVALOR == (rdbRD.Checked ? "RD" : "OP") select R).First();
                    dtpExpedienteFechaNotificacion.Value = Resolucion.FDFECNOTIF.Value;

                    txtExpedienteAnio.Text = Resolucion.FAANIOEXPED;
                    txtExpedienteNro.Text = Resolucion.FANROEXPED;

                    // txtExpedienteNroReso.Text = Resolucion.FANROEXPED;
                    cmbExpedienteCalifica.Text = (from C in BD.CALIFICACION where C.FACODCALIFI == Resolucion.FAREQCALIFICA select C.FADESCALIFI).First().ToString();
                    dtpExpedienteFechaNotificacion.Value = Resolucion.FDFECNOTIF.Value;
                    dtpExpedienteFechaVencimiento.Value = Resolucion.FDFECVENCI.Value;
                    txtExpObservacion.Text = Resolucion.FAOBSERVACION;

                    string valorcajacostas = decimal.Parse((from C in BD.PA_COAC_COSTASPROCESALES(txtExpedienteIdCiudadano.Text) select C.Saldo).First().ToString()).ToString("N2");

                    if (valorcajacostas != Resolucion.FNCOSPROCE.ToString())
                    {
                        MessageBox.Show("DEBE ACTUALIZAR LAS COSTAS PROCESALES ANTES DE CONTINUAR.  Valor correcto: "+valorcajacostas);
                        //txtExpedienteCostasProc.Text = Resolucion.FNCOSPROCE.ToString();
                        txtExpedienteCostasProc.Text = valorcajacostas;
                    }
                    else
                    {
                        txtExpedienteCostasProc.Text = Resolucion.FNCOSPROCE.ToString();
                    }

                    
                    cmbExpedienteAuxiliar.SelectedValue = Resolucion.FNCODAUXILIAR;
                    cmbExpedienteNotificador.SelectedValue = Resolucion.FNCODNOTIFICADOR;
                    txtFechaResolucion.Text = Resolucion.FDFECIMPRE;
                    txtAnioValor.Text = Resolucion.FAANIORESOLUCION;//////////////////
                    dgvExpedientesCoac.ClearSelection();
                    PintarGrid_EstadoCuentaIP(txtExpedienteIdCiudadano.Text);
                }
            }
#pragma warning disable CS0168 // La variable 'error' se ha declarado pero nunca se usa
            catch (Exception error)
#pragma warning restore CS0168 // La variable 'error' se ha declarado pero nunca se usa
            {
                if (txtExpedienteNroReso.Text.Length > 0)
                {
                   // MessageBox.Show("NUMERO DE RD NO EXISTE O ERROR DURANTE LA OPERACIÓN: txtExpedienteNroReso_TextChanged, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
                }

            }*/
        }

        private void txtExpedienteNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar== Convert.ToChar(Keys.Enter))
                {//mandar mensaje cuando no tenga nada
                    //if ((from V in BD.REQCOACGEN where V.FANRORESOLUCION == txtExpedienteNroReso.Text && V.FAANIOEXPED == txtExpedienteAnio.Text && V.FATIPOVALOR == (rdbRD.Checked ? "RD" : "OP") select V).Count() == 0)
                    //{
                    //    MessageBox.Show("VALOR PENDIENTE DE TRANSFERENCIA A EJECUCIÓN COACTIVA", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DURANTE LA OPERACIÓN: txtNroResolucion_KeyPress, VUELVA A INTENTARLO. SI EL PROBLEMA CONTINUA COMUNÍQUESE CON EL ÁREA DE INFORMÁTICA. ");
            }
        }

        private void btnExpLimpiar_Click(object sender, EventArgs e)
        {
            DateTime venvimiento2015p1 = DateTime.Parse("01-03-2015");
            DateTime venvimiento2015p2 = DateTime.Parse("01-06-2015");
            DateTime venvimiento2015p3 = DateTime.Parse("01-09-2015");
            DateTime venvimiento2015p4 = DateTime.Parse("01-12-2015");

            DateTime venvimiento2016p1 = DateTime.Parse("01-03-2016");
            DateTime venvimiento2016p2 = DateTime.Parse("01-06-2016");
            DateTime venvimiento2016p3 = DateTime.Parse("01-09-2016");
            DateTime venvimiento2016p4 = DateTime.Parse("01-12-2016");

            DateTime venvimiento2017p1 = DateTime.Parse("01-03-2017");
            DateTime venvimiento2017p2 = DateTime.Parse("01-06-2017");
            DateTime venvimiento2017p3 = DateTime.Parse("01-09-2017");
            DateTime venvimiento2017p4 = DateTime.Parse("01-12-2017");

            DateTime venvimiento2018p1 = DateTime.Parse("01-03-2018");
            DateTime venvimiento2018p2 = DateTime.Parse("01-06-2018");
            DateTime venvimiento2018p3 = DateTime.Parse("01-09-2018");
            DateTime venvimiento2018p4 = DateTime.Parse("01-12-2018");

            DateTime venvimiento2019p1 = DateTime.Parse("01-03-2019");
            DateTime venvimiento2019p2 = DateTime.Parse("01-06-2019");
            DateTime venvimiento2019p3 = DateTime.Parse("01-09-2019");
            DateTime venvimiento2019p4 = DateTime.Parse("01-12-2019");

            int NroDiasTrans201501 = (DateTime.Today - venvimiento2015p1).Days;
            int NroDiasTrans201502 = (DateTime.Today - venvimiento2015p2).Days;
            int NroDiasTrans201503 = (DateTime.Today - venvimiento2015p3).Days;
            int NroDiasTrans201504 = (DateTime.Today - venvimiento2015p4).Days;

            int NroDiasTrans201601 = (DateTime.Today - venvimiento2016p1).Days;
            int NroDiasTrans201602 = (DateTime.Today - venvimiento2016p2).Days;
            int NroDiasTrans201603 = (DateTime.Today - venvimiento2016p3).Days;
            int NroDiasTrans201604 = (DateTime.Today - venvimiento2016p4).Days;

            int NroDiasTrans201701 = (DateTime.Today - venvimiento2017p1).Days;
            int NroDiasTrans201702 = (DateTime.Today - venvimiento2017p2).Days;
            int NroDiasTrans201703 = (DateTime.Today - venvimiento2017p3).Days;
            int NroDiasTrans201704 = (DateTime.Today - venvimiento2017p4).Days;

            int NroDiasTrans201801 = (DateTime.Today - venvimiento2018p1).Days;
            int NroDiasTrans201802 = (DateTime.Today - venvimiento2018p2).Days;
            int NroDiasTrans201803 = (DateTime.Today - venvimiento2018p3).Days;
            int NroDiasTrans201804 = (DateTime.Today - venvimiento2018p4).Days;

            int NroDiasTrans201901 = (DateTime.Today - venvimiento2019p1).Days;
            int NroDiasTrans201902 = (DateTime.Today - venvimiento2019p2).Days;
            int NroDiasTrans201903 = (DateTime.Today - venvimiento2019p3).Days;
            int NroDiasTrans201904 = (DateTime.Today - venvimiento2019p4).Days;

            MessageBox.Show("");

            

        }

        private void btnExpActualizar_Click(object sender, EventArgs e)
        {
            try
            {
               // string aniovalor= 
                BD.PA_COAC_MODIFICARREQGEN(txtExpedienteIdCiudadano.Text, txtExpedienteNroReso.Text,txtExpedienteNro.Text,txtExpedienteAnio.Text,int.Parse(cmbExpedienteAuxiliar.SelectedValue.ToString()),int.Parse(cmbExpedienteNotificador.SelectedValue.ToString()), txtAnioValor.Text,cmbExpedienteCalifica.SelectedValue.ToString(),decimal.Parse(txtExpedienteCostasProc.Text), txtExpObservacion.Text,DateTime.Parse(lblExpFechaEnvio.Text),dtpExpedienteFechaNotificacion.Value,dtpExpedienteFechaVencimiento.Value,txtFechaResolucion.Text,(rdbRD.Checked?"RD":"OP")) ;

                dgvExpedientesCoac.DataSource = from R in BD.REQCOACGEN where R.FANRORESOLUCION == txtExpedienteNroReso.Text && R.FAIDCIUDADANO==txtExpedienteIdCiudadano.Text select new { R.FAANIOEXPED, R.FANROEXPED, R.FAANIORESOLUCION, R.FANRORESOLUCION, R.FAIDCIUDADANO, R.FAAPELLIDOSYNOMBRES, R.FAANIOINICIO, R.FAANIOFIN, R.FAREQCALIFICA, R.FNIMPCOACT, R.FNCOSPROCE, R.FADOMFISCAL };
                //txtExpedienteNroReso.Text = Expediente.First().FANROEXPED;
                //txtExpedienteIdCiudadano.Text = Expediente.First().FAIDCIUDADANO;
                var Expediente = from R in BD.REQCOACGEN
                                 where R.FAIDCIUDADANO == txtExpedienteIdCiudadano.Text && R.FANRORESOLUCION == txtExpedienteNroReso.Text
                                 select new { R.FAANIOEXPED, R.FANROEXPED, R.FAANIORESOLUCION, R.FANRORESOLUCION, R.FAIDCIUDADANO, R.FAAPELLIDOSYNOMBRES, R.FAANIOINICIO, R.FAANIOFIN, R.FAREQCALIFICA, R.FNIMPCOACT, R.FNCOSPROCE, R.FADOMFISCAL, R.FDFECNOTIF, R.FDFECVENCI, R.FAOBSERVACION , R.FNCODAUXILIAR, R.FNCODNOTIFICADOR};
                txtExpedienteAnio.Text = Expediente.First().FAANIOEXPED;
                txtExpedienteNro.Text = Expediente.First().FANROEXPED; 
                cmbExpedienteCalifica.SelectedValue = Expediente.First().FAREQCALIFICA;
                dtpExpedienteFechaNotificacion.Value = Expediente.First().FDFECNOTIF.Value;
                dtpExpedienteFechaVencimiento.Value = Expediente.First().FDFECVENCI.Value;
                txtExpObservacion.Text = Expediente.First().FAOBSERVACION;
                txtExpedienteCostasProc.Text = Expediente.First().FNCOSPROCE.ToString();
                cmbExpedienteAuxiliar.SelectedValue = Expediente.First().FNCODAUXILIAR;
                cmbExpedienteNotificador.SelectedValue = Expediente.First().FNCODNOTIFICADOR;

                MessageBox.Show("Se actualizo la informacion.");
                LlenarEstadoRequerimientos();
                dgvExpedientesCoac.ClearSelection();
            }
            catch (Exception ERR)
            {
                MessageBox.Show("Asegurese de completar los campos: calificacion, Auxiliar, Notificador y Ejecutor antes de continuar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show(ERR.ToString());
            }
        }

        private void btnExpImprimirRD_Click(object sender, EventArgs e)
        {
            // frmReporteCoacResolucionInicio Resolucion = new frmReporteCoacResolucionInicio(int.Parse(txtExpedienteNroReso.Text),txtExpedienteIdCiudadano.Text,txtExpedienteNro.Text);
            //Resolucion.ShowDialog();
            try
            {
                if (rdbOP.Checked==true)
                {
                    FrmReportCrisResolucionInicioOP ResolucionOP = new FrmReportCrisResolucionInicioOP(int.Parse(txtExpedienteNroReso.Text), txtExpedienteIdCiudadano.Text, txtExpedienteNro.Text, int.Parse(txtAnioValor.Text));
                    ResolucionOP.ShowDialog();
                }
                else
                {
                    FrmReportCrisResolucionIniciocs Resolucion = new FrmReportCrisResolucionIniciocs(int.Parse(txtExpedienteNroReso.Text),int.Parse(txtExpedienteAnio.Text), txtExpedienteIdCiudadano.Text, txtExpedienteNro.Text);
                    Resolucion.ShowDialog();
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show("Error durante la operación, verificar los datos o comuníquese con informática "+error.ToString());
            }
           
        }

        private void txtExpedienteNro_Leave(object sender, EventArgs e)
        {
            /*
            while (txtExpedienteNro.Text.Length<4)
            {
                txtExpedienteNro.Text = "0"+txtExpedienteNro.Text;
            }
            */
        }

        private void btnResRetencion_Click(object sender, EventArgs e)
        {
            try
            {
                var ResolucionCoac = from R in BD.REQCOACGEN where R.FANRORESOLUCION == txtExpedienteNroReso.Text && R.FATIPOVALOR == (rdbRD.Checked?"RD":"OP") && R.FAANIOEXPED == txtExpedienteAnio.Text && R.FAIDCIUDADANO == txtExpedienteIdCiudadano.Text select R;
                int anioini = int.Parse(ResolucionCoac.First().FAANIOINICIO.ToString());
                int aniofin = int.Parse(ResolucionCoac.First().FAANIOFIN.ToString());



                MessageBox.Show("anio ini: "+anioini +" anio fin:"+aniofin);
                var VistaPreviaRes = from V in BD.PA_COAC_EMISIONRESORETENCION(txtExpedienteIdCiudadano.Text, anioini, aniofin, int.Parse(txtExpedienteNroReso.Text), int.Parse(txtAnioValor.Text),int.Parse(txtExpedienteAnio.Text), (rdbRD.Checked?"RD":"OP"), 6) select V;

                DateTime fechaactualizacion = VistaPreviaRes.First().FECHAULTIMAACTUALIZACION.Value;
                // DateTime fechageneracion = VistaPreviaRes.First().FECHAGENERACION_RESRET.Date;
                //if (fechaactualizacion.Year != DateTime.Now.Date.Year && fechaactualizacion.Month != DateTime.Now.Date.Month && fechaactualizacion.Day != DateTime.Now.Date.Day)
                if (fechaactualizacion.Date != DateTime.Today.Date)
                {
                    MessageBox.Show("SE DEBE ACTUALIZAR DEUDA, LA DEUDA ESTA AL :" + fechaactualizacion.ToString().Substring(0, 10), "IMPORTANTE..¡¡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if ((from R in BD.REQCOAC_RESRET where R.IdCiudadano == txtExpedienteIdCiudadano.Text && R.FANRORESOLUCION == txtExpedienteNroReso.Text && R.FAANIOEXPED == txtExpedienteAnio.Text && R.FANROEXPED == txtExpedienteNro.Text select R).Count() == 0)
                    {
                        //SE VERIFICA Q LAS FECHA COENCIDAN CON LAS ACTUALES, Y SE PROCEDE A LA INSERCION EN LA TABLA REQCOAC_RESRET
                        BD.PA_COAC_GEN_RESOLUCIONRETENCION(txtExpedienteIdCiudadano.Text, anioini, aniofin, int.Parse(txtExpedienteNroReso.Text), int.Parse(txtAnioValor.Text), int.Parse(txtExpedienteAnio.Text), "RD", 6);
                        BD.PA_COAC_CARGARMORAS_RESRET(txtExpedienteIdCiudadano.Text, 0, anioini, aniofin);

                    }
                    FrmReportCrysResolucionRentencion Retencion = new FrmReportCrysResolucionRentencion(int.Parse(txtExpedienteNroReso.Text), txtExpedienteIdCiudadano.Text, txtExpedienteNro.Text, "RD", 2019);
                    Retencion.ShowDialog();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Se produjo un error, PENDIENTE DE TRANSFERENCIA A COAC: *"+err.ToString());
            }
            


            
        }

        private void btnP1P2_Click(object sender, EventArgs e)
        {
            //frmReporteOrdenPagoP1P2 op = new frmReporteOrdenPagoP1P2();
            //op.ShowDialog();
        }

        private void btnP2_Click(object sender, EventArgs e)
        {
            //frmReporteOrdenPagoP2 op = new frmReporteOrdenPagoP2();
            //op.ShowDialog();
        }
        public void LlenarEstadoRequerimientos()
        { /*
            var tablareqcoac = from R in BD.REQCOACGEN select R;
            lblAdmitidos.Text = (from R in BD.REQCOACGEN where R.FAANIOEXPED== txtExpedienteAnio.Text && R.FAREQCALIFICA == "A" && R.FATIPOVALOR == (rdbOP.Checked ? "OP" : "RD") select R).Count().ToString();
            lblDevueltos.Text = (from R in BD.REQCOACGEN where R.FAANIOEXPED == txtExpedienteAnio.Text && R.FAREQCALIFICA == "D" && R.FATIPOVALOR == (rdbOP.Checked ? "OP" : "RD") select R).Count().ToString();
            lblPendientesdeCalificacion.Text = (from R in BD.REQCOACGEN where R.FAANIOEXPED == txtExpedienteAnio.Text && R.FAREQCALIFICA == "C" && R.FATIPOVALOR == (rdbOP.Checked ? "OP" : "RD") select R).Count().ToString();
            lblObservados.Text = (from R in BD.REQCOACGEN where R.FAANIOEXPED == txtExpedienteAnio.Text && R.FAREQCALIFICA == "O" && R.FATIPOVALOR == (rdbOP.Checked ? "OP" : "RD") select R).Count().ToString();
            lblOtros.Text = (from R in BD.REQCOACGEN where R.FAANIOEXPED == txtExpedienteAnio.Text && R.FAREQCALIFICA == "S" || R.FAREQCALIFICA == "P" || R.FAREQCALIFICA == "N" || R.FAREQCALIFICA == "X" && R.FATIPOVALOR == (rdbOP.Checked ? "OP" : "RD") select R).Count().ToString();

            */
        }
        private void frmCoactivaControl_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_VALORES.PA_COAC_RESUMENRESOLUCIONES' Puede moverla o quitarla según sea necesario.
            LlenarEstadoRequerimientos();
        }

        private void btnCargarReporte_Click(object sender, EventArgs e)
        {
            this.PA_COAC_RESUMENRESOLUCIONESTableAdapter.Fill(this.DS_VALORES.PA_COAC_RESUMENRESOLUCIONES,cmbResporteCoacEstado.SelectedValue.ToString(),txtReporteCoacAnioExpediente.Text);
            rpvCoacResoluciones.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rpvCoacResoluciones.ShowZoomControl = true;
            this.rpvCoacResoluciones.RefreshReport();
        }

        private void DgvExpedientesCoac_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

            //string idciudadano = dgvExpedientesCoac.Rows[e.RowIndex].Cells["FAIDCIUDADANO"].Value.ToString();
            //int nroresolucion = int.Parse(dgvExpedientesCoac.Rows[e.RowIndex].Cells["FANRORESOLUCION"].Value.ToString());
            //float Saldo = float.Parse((from S in BD.PA_COAC_ESTADOACTUALDEUDA(idciudadano, nroresolucion) select S.SALDO).Sum().ToString());
            //float Pagado = float.Parse((from S in BD.PA_COAC_ESTADOACTUALDEUDA(idciudadano, nroresolucion) select S.PAGADO).Sum().ToString());
            //if (Pagado > 0 && Saldo > 0)
            //{
            //    dgvExpedientesCoac.Rows[e.RowIndex].Cells["FAIDCIUDADANO"].Style.BackColor = Color.Orange;
            //}
            //else
            //{
            //    if (Pagado > 0 && Saldo <= 0)
            //    {
            //        dgvExpedientesCoac.Rows[e.RowIndex].Cells["FAIDCIUDADANO"].Style.BackColor = Color.Green;
            //    }
            //    //else
            //    //{
            //    //    if (Pagado<=0 && Saldo>0)
            //    //    {
            //    //        dgvExpedientesCoac.Rows[e.RowIndex].Cells["FAIDCIUDADANO"].Style.BackColor = Color.Red;
            //    //    }
            //    //}
            //}
            //pintarGridCoac();

        }
        public void pintarGridCoac()
        {

            for (int i = 0; i < dgvExpedientesCoac.Rows.Count; i++)
            {
                string idciudadano = dgvExpedientesCoac.Rows[i].Cells["FAIDCIUDADANO"].Value.ToString();
                int nroresolucion = int.Parse(dgvExpedientesCoac.Rows[i].Cells["FANRORESOLUCION"].Value.ToString());
                float Saldo = float.Parse((from S in BD.PA_COAC_ESTADOACTUALDEUDA(idciudadano, nroresolucion) select S.SALDO).Sum().ToString());
                float Pagado = float.Parse((from S in BD.PA_COAC_ESTADOACTUALDEUDA(idciudadano, nroresolucion) select S.PAGADO).Sum().ToString());
                if (Pagado > 0 && Saldo > 0)
                {
                    dgvExpedientesCoac.Rows[i].Cells["FAIDCIUDADANO"].Style.BackColor = Color.Orange;
                }
                else
                {
                    if (Pagado > 0 && Saldo <= 0)
                    {
                        dgvExpedientesCoac.Rows[i].Cells["FAIDCIUDADANO"].Style.BackColor = Color.Green;
                    }
                    
                }

            }
            dgvExpedientesCoac.ClearSelection();
        }

        private void RdbOP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOP.Checked==true)
            {
                TipoValor = "OP";
                
            }
            else
            {
                TipoValor = "RD";
            }
           // LlenarEstadoRequerimientos();
        }

        private void RdbRD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRD.Checked == true)
            {
                dgvExpedientesCoac.DataSource = from R in BD.REQCOACGEN where R.FATIPOVALOR == "RD" && R.FAANIOEXPED==txtExpedienteAnio.Text select new { R.FAANIOEXPED, R.FANROEXPED, R.FAANIORESOLUCION, R.FANRORESOLUCION, R.FAIDCIUDADANO, R.FAAPELLIDOSYNOMBRES, R.FAANIOINICIO, R.FAANIOFIN, R.FAREQCALIFICA, R.FNIMPCOACT, R.FNCOSPROCE, R.FADOMFISCAL };
            }
            else
            {
                if (rdbOP.Checked == true)
                {
                    dgvExpedientesCoac.DataSource = from R in BD.REQCOACGEN where R.FATIPOVALOR == "OP" && R.FAANIOEXPED == txtExpedienteAnio.Text select new { R.FAANIOEXPED, R.FANROEXPED, R.FAANIORESOLUCION, R.FANRORESOLUCION, R.FAIDCIUDADANO, R.FAAPELLIDOSYNOMBRES, R.FAANIOINICIO, R.FAANIOFIN, R.FAREQCALIFICA, R.FNIMPCOACT, R.FNCOSPROCE, R.FADOMFISCAL };
                }
            }
            dgvExpedientesCoac.ClearSelection();
        }

        private void txtExpedienteAnio_TextChanged(object sender, EventArgs e)
        {
            if (txtExpedienteAnio.Text.Length == 4)
            {
                if (rdbRD.Checked == true)
                {
                    //dgvExpedientesCoac.DataSource = from R in BD.REQCOACGEN where R.FATIPOVALOR == "RD" && R.FAANIOEXPED == txtExpedienteAnio.Text select new { R.FAANIOEXPED, R.FANROEXPED, R.FAANIORESOLUCION, R.FANRORESOLUCION, R.FAIDCIUDADANO, R.FAAPELLIDOSYNOMBRES, R.FAANIOINICIO, R.FAANIOFIN, R.FAREQCALIFICA, R.FNIMPCOACT, R.FNCOSPROCE, R.FADOMFISCAL };
                }
                else
                {
                    if (rdbOP.Checked == true)
                    {
                      //  dgvExpedientesCoac.DataSource = from R in BD.REQCOACGEN where R.FATIPOVALOR == "OP" && R.FAANIOEXPED == txtExpedienteAnio.Text select new { R.FAANIOEXPED, R.FANROEXPED, R.FAANIORESOLUCION, R.FANRORESOLUCION, R.FAIDCIUDADANO, R.FAAPELLIDOSYNOMBRES, R.FAANIOINICIO, R.FAANIOFIN, R.FAREQCALIFICA, R.FNIMPCOACT, R.FNCOSPROCE, R.FADOMFISCAL };
                    }
                }
            }
            dgvExpedientesCoac.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvExpedientesCoac.DataSource = from V in BD.REQCOACGEN where V.FANRORESOLUCION == txtExpedienteNroReso.Text && V.FAANIOEXPED == txtExpedienteAnio.Text && V.FATIPOVALOR == (rdbRD.Checked ? "RD" : "OP") select new { V.FAANIOEXPED, V.FANROEXPED, V.FAANIORESOLUCION, V.FANRORESOLUCION, FAIDCIUDADANO = V.FAIDCIUDADANO, V.FAAPELLIDOSYNOMBRES, V.FAANIOINICIO, V.FAANIOFIN, V.FAREQCALIFICA, V.FNIMPCOACT, V.FNCOSPROCE, V.FADOMFISCAL };
                //if (dgvExpedientesCoac.Rows.Count==0)
                //{
                //    MessageBox.Show("VALOR PENDIENTE DE TRANSFERENCIA A EJECUCIÓN COACTIVA", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                if (dgvExpedientesCoac.Rows.Count==1)
                {
                    txtExpedienteIdCiudadano.Text = dgvExpedientesCoac.Rows[dgvExpedientesCoac.CurrentCell.RowIndex].Cells["FAIDCIUDADANO"].Value.ToString();
                    var Resolucion = (from R in BD.REQCOACGEN where R.FAIDCIUDADANO == txtExpedienteIdCiudadano.Text && R.FANRORESOLUCION == txtExpedienteNroReso.Text && R.FATIPOVALOR == (rdbRD.Checked ? "RD" : "OP") select R).First();
                    dtpExpedienteFechaNotificacion.Value = Resolucion.FDFECNOTIF.Value;

                    txtExpedienteAnio.Text = Resolucion.FAANIOEXPED;
                    txtAnioValor.Text = Resolucion.FAANIORESOLUCION;
                    txtExpedienteNro.Text = Resolucion.FANROEXPED;

                    // txtExpedienteNroReso.Text = Resolucion.FANROEXPED;
                    cmbExpedienteCalifica.Text = (from C in BD.CALIFICACION where C.FACODCALIFI == Resolucion.FAREQCALIFICA select C.FADESCALIFI).First().ToString();
                    dtpExpedienteFechaNotificacion.Value = Resolucion.FDFECNOTIF.Value;
                    dtpExpedienteFechaVencimiento.Value = Resolucion.FDFECVENCI.Value;
                    txtExpObservacion.Text = Resolucion.FAOBSERVACION;

                    // MessageBox.Show(BD.PA_COAC_COSTASPROCESALES(txtExpedienteIdCiudadano.Text).First().Saldo.ToString());
                   // PintarGrid_EstadoCuentaIP(txtExpedienteIdCiudadano.Text);

                    if ( Convert.ToInt32(BD.PA_COAC_COSTASPROCESALES(txtExpedienteIdCiudadano.Text).First().Saldo.Value) == decimal.Parse("0") )//se corrigio el sp
                    {
                        MessageBox.Show("PENDIENTE DE GENERAR LAS ORDENES DE PAGO DE LAS COSTAS PROCESALES.");
                    }
                    else
                    {
                        string valorcajacostas = decimal.Parse((from C in BD.PA_COAC_COSTASPROCESALES(txtExpedienteIdCiudadano.Text) select C.Saldo).First().ToString()).ToString("N2");
                        //string valorcajacostas = "";
                        if (valorcajacostas != Resolucion.FNCOSPROCE.ToString())
                        {
                            MessageBox.Show("DEBE ACTUALIZAR LAS COSTAS PROCESALES ANTES DE CONTINUAR.  Valor correcto: " + valorcajacostas);
                            //txtExpedienteCostasProc.Text = Resolucion.FNCOSPROCE.ToString();
                            txtExpedienteCostasProc.Text = valorcajacostas;
                        }
                        else
                        {
                            txtExpedienteCostasProc.Text = Resolucion.FNCOSPROCE.ToString();
                        }


                        cmbExpedienteAuxiliar.SelectedValue = Resolucion.FNCODAUXILIAR;
                        cmbExpedienteNotificador.SelectedValue = Resolucion.FNCODNOTIFICADOR;
                        txtFechaResolucion.Text = Resolucion.FDFECIMPRE;
                        txtAnioValor.Text = Resolucion.FAANIORESOLUCION;//////////////////
                        dgvExpedientesCoac.ClearSelection();
                        
                    }
                    PintarGrid_EstadoCuentaIP(txtExpedienteIdCiudadano.Text);

                }
                else
                {
                    //dgvExpedientesCoac.DataSource = from V in BD.REQCOACGEN where V.FANRORESOLUCION == txtExpedienteNroReso.Text && V.FAANIOEXPED == txtExpedienteAnio.Text && V.FATIPOVALOR == (rdbRD.Checked ? "RD" : "OP") select new { V.FAANIOEXPED, V.FANROEXPED, V.FAANIORESOLUCION, V.FANRORESOLUCION, FAIDCIUDADANO = V.FAIDCIUDADANO, V.FAAPELLIDOSYNOMBRES, V.FAANIOINICIO, V.FAANIOFIN, V.FAREQCALIFICA, V.FNIMPCOACT, V.FNCOSPROCE, V.FADOMFISCAL };
                    if (dgvExpedientesCoac.Rows.Count==0)
                    {
                        MessageBox.Show("El codigo NO tiene RDs");
                    }
                    else
                    {
                        MessageBox.Show("El codigo tiene mas de un valor");
                    }
                    
                    
                    //dgvExpedientesCoac.DataSource = from V in BD.REQCOACGEN where V.FANRORESOLUCION == txtExpedienteNroReso.Text && V.FAANIOEXPED == txtExpedienteAnio.Text && V.FATIPOVALOR == (rdbRD.Checked ? "RD" : "OP") select new { V.FAANIOEXPED, V.FANROEXPED, V.FAANIORESOLUCION, V.FANRORESOLUCION, FAIDCIUDADANO = V.FAIDCIUDADANO, V.FAAPELLIDOSYNOMBRES, V.FAANIOINICIO, V.FAANIOFIN, V.FAREQCALIFICA, V.FNIMPCOACT, V.FNCOSPROCE, V.FADOMFISCAL };
                    //txtExpedienteIdCiudadano.Text = dgvExpedientesCoac.Rows[dgvExpedientesCoac.CurrentCell.RowIndex].Cells["FAIDCIUDADANO"].Value.ToString();
                    //txtExpedienteIdCiudadano.Text = dgvExpedientesCoac.Rows[1].Cells["FAIDCIUDADANO"].Value.ToString();

                    //txtExpedienteIdCiudadano.Text = (from C in BD.REQCOACGEN where C.FANRORESOLUCION == txtExpedienteNro.Text && C.FATIPOVALOR == (rdbOP.Checked == true ? "OP" : "RD") select C.FAIDCIUDADANO).First().ToString();
                }
                
                // cmbExpedienteCalifica.Text = (from V in BD.CALIFICACION where V.FACODCALIFI == dgvExpedientesCoac.Rows[dgvExpedientesCoac.CurrentCell.RowIndex].Cells["FAREQCALIFICA"].Value.ToString() select V.FADESCALIFI).First().ToString();
                
            }
            catch (Exception ERR)
            {
                MessageBox.Show("Se presento un error, vuelva a intentarlo: *"+ERR.ToString());
            }
            
        }

        private void btnExpedienteBuscarEjecutor_Click(object sender, EventArgs e)
        {

        }
    } 
}
