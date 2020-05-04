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
    public partial class frmReporteOrdenPagoP1P2P3 : Form
    {
        public frmReporteOrdenPagoP1P2P3()
        {
            InitializeComponent();
        }

        private void FrmReporteOrdenPagoP1P2P3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_VALORES.ORDENESPAGOP1P2P3' Puede moverla o quitarla según sea necesario.
            this.ORDENESPAGOP1P2P3TableAdapter.Fill(this.DS_VALORES.ORDENESPAGOP1P2P3);
            rpvOrdenPagoP1P2P3.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rpvOrdenPagoP1P2P3.ShowZoomControl = true; 
            this.rpvOrdenPagoP1P2P3.RefreshReport();
                   
                
            
        }


    }
}
