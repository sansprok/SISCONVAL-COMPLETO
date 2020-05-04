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
    public partial class frmReporteResolucion : Form
    {
        int pANIORESO, pNRORESO_INI, pNRORESO_FIN;
        public frmReporteResolucion(int ANIORESO, int NRORESO_INI, int NRORESO_FIN)
        {
            InitializeComponent();
            // this.Controls.Add(this.reportViewer1);
            //reportViewer1.Dock = DockStyle.Fill;
            //reportViewer1.
            rpvResolucion.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rpvResolucion.ShowZoomControl = true;
            pANIORESO = ANIORESO;
            pNRORESO_INI = NRORESO_INI;
            pNRORESO_FIN = NRORESO_FIN;
            
        }

        private void frmResolucion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_VALORES.PA_CONTROLDEUDA_DATOSVALOR_MASIV' Puede moverla o quitarla según sea necesario.
            this.PA_CONTROLDEUDA_DATOSVALOR_MASIVTableAdapter.Fill(this.DS_VALORES.PA_CONTROLDEUDA_DATOSVALOR_MASIV,pANIORESO,pNRORESO_INI,pNRORESO_FIN);
            // TODO: esta línea de código carga datos en la tabla 'DS_VALORES.PA_CONTROLDEUDA_DATOSVALOR' Puede moverla o quitarla según sea necesario.
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //this.PA_CONTROLDEUDA_DATOSVALORTableAdapter.Fill(this.DS_VALORES.PA_CONTROLDEUDA_DATOSVALOR,pANIORESO,pNRORESO);

            this.rpvResolucion.RefreshReport();

            
        }
    }
}
