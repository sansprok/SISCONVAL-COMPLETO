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
    public partial class frmReporteOrdenPagoP3 : Form
    {
        public frmReporteOrdenPagoP3()
        {
            InitializeComponent();
        }

        private void FrmReporteOrdenPagoP3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_VALORES.ORDENESPAGOP1P2P3' Puede moverla o quitarla según sea necesario.
            this.ORDENESPAGOP3TableAdapter.Fill(this.DS_VALORES.ORDENESPAGOP3);
            rpvOrdenPagoP3.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rpvOrdenPagoP3.ShowZoomControl = true;
            this.rpvOrdenPagoP3.RefreshReport();

        }
    }
}
