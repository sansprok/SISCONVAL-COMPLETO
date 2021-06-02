using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
using System.Drawing.Printing;


namespace SISCONVAL
{
    public partial class FrmReportCrisResolucionIniciocs : Form
    {
        int pFNNRORESOLUCION, pFNANIOEXPED;
        string pFAIDCIUDADANO;
        string pFANROEXPEDIENTE;
        SqlConnection sqlcon = new SqlConnection(@"Data Source=192.168.1.28\SQLMDW28;Initial Catalog=AUXWANCHAQ;User ID=sa;Password=wanchaqsql-2013");
       // SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=AUXWANCHAQ;Integrated Security=True");
        public FrmReportCrisResolucionIniciocs(int FNNRORESOLUCION, int FNANIOEXPED,  string FAIDCIUDADANO, string FANROEXPEDIENTE)
        {
            InitializeComponent();
            pFNNRORESOLUCION = FNNRORESOLUCION;
            pFAIDCIUDADANO = FAIDCIUDADANO;
            pFANROEXPEDIENTE = FANROEXPEDIENTE;
            pFNANIOEXPED = FNANIOEXPED;
          //  rpvCoacInicio.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
          //  rpvCoacInicio.ShowZoomControl = true;


        }
        private void FrmReportCrisResolucionIniciocs_Load(object sender, EventArgs e)
        {
            // this.pA_COAC_RESOLUCIONINICIOTableAdapter.Fill(this.dS_COAC_RESINI.PA_COAC_RESOLUCIONINICIO, pFNNRORESOLUCION, pFAIDCIUDADANO, pFANROEXPEDIENTE);
            // this.crvResolucionInicioCoac.Refresh();

            //Instantiate variables
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("PA_COAC_RESOLUCIONINICIO",sqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@FNNRONRESOLUCION",pFNNRORESOLUCION);
            sqlda.SelectCommand.Parameters.AddWithValue("@FNANIOEXPEDIENTE", pFNANIOEXPED);
            sqlda.SelectCommand.Parameters.AddWithValue("@FAIDCIUDADANO", pFAIDCIUDADANO);
            sqlda.SelectCommand.Parameters.AddWithValue("@FANROEXPED", pFANROEXPEDIENTE);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            sqlcon.Close();
            SISCONVAL.ReportResolucionDeInicio reportResolucionDeInicio = new ReportResolucionDeInicio();
            reportResolucionDeInicio.Database.Tables["PA_COAC_RESOLUCIONINICIO"].SetDataSource(dtbl);
            crvResolucionInicioCoac.ReportSource = null;
            crvResolucionInicioCoac.ReportSource = reportResolucionDeInicio;






        }

        private void crvResolucionInicioCoac_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //    ReportDocument reporte = new ReportDocument();
            //    reporte.Load("ReportResolucionDeInicio.rpt");


            //    PrinterSettings printerName = new PrinterSettings();

            //    string defaultPrinter;

            //    crvResolucionInicioCoac.Refresh();
            //    defaultPrinter = printerName.PrinterName;
            //    reporte.PrintOptions.PrinterName = defaultPrinter;
            //    reporte.PrintToPrinter(1, false, 0, 0);
            //
        }
        
    }
}
