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
    public partial class frmEmisionMasiva : Form
    {
        public frmEmisionMasiva()
        {
            InitializeComponent();
        }

        private void FrmEmisionMasiva_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_VALORES.PA_ESTADOCUENTA' Puede moverla o quitarla según sea necesario.
            this.PA_ESTADOCUENTATableAdapter.Fill(this.DS_VALORES.PA_ESTADOCUENTA, "00000152z", "");

            this.rpvEstadoCuentaMasivo.RefreshReport();
        }
    }
}
