using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCONVAL
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
           //// Application.Run(new frmReportCristalEstadoMasivo("", "urb. ttio norte", 0));
            //Application.Run(new frmEstadoActualDeuda());

            // Application.Run(new frmControlDeuda());C:\Users\USER\OneDrive\SISTEMAS WANCHAQ\ControlValores\VERSION DE TRABAJO\SISCONVAL\SISCONVAL\Program.cs
            //Application.Run(new frmCoactivaControl());
            // Application.Run(new frmResolucion());
            // Application.Run(new frmGenerarRDByCodigo("00007063W", "2019"));
            //Application.Run(new FrmReportCrisResolucionIniciocs(1700, "00002295H","1"));
            //Application.Run(new frmReportCristalEstadoMasivo("", "manco inca"));
            //Application.Run(new frmReporteOrdenPagoP3());
        }
    }
}
