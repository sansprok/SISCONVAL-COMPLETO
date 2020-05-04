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
    public partial class frmReporteOrdenPagoP2 : Form
    {
        public frmReporteOrdenPagoP2()
        {
            InitializeComponent();
        }

        private void frmReporteOrdenPagoP2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_VALORES.ORDENESPAGOP2' Puede moverla o quitarla según sea necesario.
            this.ORDENESPAGOP2TableAdapter.Fill(this.DS_VALORES.ORDENESPAGOP2);
            rpvOrdenPagoP2.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rpvOrdenPagoP2.ShowZoomControl = true;
            this.rpvOrdenPagoP2.RefreshReport();
        }
    }
}
