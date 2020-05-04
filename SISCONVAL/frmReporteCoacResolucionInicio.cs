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
    public partial class frmReporteCoacResolucionInicio : Form
    {
        int pFNNRORESOLUCION, pFNANIOEXPEDIENTE;

        string pFAIDCIUDADANO;
        string pFANROEXPEDIENTE;
        public frmReporteCoacResolucionInicio(int FNNRORESOLUCION,int FNANIOEXPEDIENTE, string FAIDCIUDADANO, string FANROEXPEDIENTE)
        {
            InitializeComponent();
            pFNNRORESOLUCION = FNNRORESOLUCION;
            pFAIDCIUDADANO = FAIDCIUDADANO;
            pFANROEXPEDIENTE = FANROEXPEDIENTE;
            pFNANIOEXPEDIENTE = FNANIOEXPEDIENTE;
            rpvCoacInicio.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rpvCoacInicio.ShowZoomControl = true;

        }

        private void frmCoacResolucionInicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_VALORES.PA_CONTROLDEUDA_DATOSVALOR' Puede moverla o quitarla según sea necesario.
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PA_COAC_RESOLUCIONINICIOTableAdapter.Fill(this.DS_COAC_RESINI.PA_COAC_RESOLUCIONINICIO,pFNNRORESOLUCION,pFNANIOEXPEDIENTE,pFAIDCIUDADANO,pFANROEXPEDIENTE);
            this.rpvCoacInicio.RefreshReport();
        }
    }
}
