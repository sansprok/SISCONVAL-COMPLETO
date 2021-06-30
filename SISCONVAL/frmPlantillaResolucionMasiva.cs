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
    public partial class frmPlantillaResolucionMasiva : Form
    {
        public frmPlantillaResolucionMasiva()
        {
            InitializeComponent();
        }

        private void frmPlantillaResolucionMasiva_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_VALORES.PA_CONTROLDEUDA_DATOSVALOR_MASIV' Puede moverla o quitarla según sea necesario.
            this.PA_CONTROLDEUDA_DATOSVALOR_MASIVTableAdapter.Fill(this.DS_VALORES.PA_CONTROLDEUDA_DATOSVALOR_MASIV, 2019, 2560, 2570);

            this.reportViewer1.RefreshReport();
        }
    }
}
