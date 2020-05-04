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
    public partial class frmReporteOrdenPagoP1P2 : Form
    {
        public frmReporteOrdenPagoP1P2()
        {
            InitializeComponent();
        }

        private void frmReporteOrdenPagoP1P2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_VALORES.ORDENESPAGOP1P2' Puede moverla o quitarla según sea necesario.
            this.ORDENESPAGOP1P2TableAdapter.Fill(this.DS_VALORES.ORDENESPAGOP1P2);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ShowZoomControl = true;
            this.reportViewer1.RefreshReport();
        }
    }
}
