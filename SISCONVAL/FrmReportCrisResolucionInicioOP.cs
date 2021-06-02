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
    public partial class FrmReportCrisResolucionInicioOP : Form
    {
        int pFNNRORESOLUCION;
        string pFAIDCIUDADANO;
        string pFANROEXPEDIENTE;
        int pFAANIORESOLUCION;
        SqlConnection sqlcon = new SqlConnection(@"Data Source=192.168.1.28\SQLMDW28;Initial Catalog=AUXWANCHAQ;User ID=sa;Password=wanchaqsql-2013");
       // SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=AUXWANCHAQ;User ID=sa;Password=Server2010");
        //SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=AUXWANCHAQ;Integrated Security=True");
        public FrmReportCrisResolucionInicioOP(int FNNRORESOLUCION, string FAIDCIUDADANO, string FANROEXPEDIENTE, int FAANIORESOLUCION)
        {
            InitializeComponent();
            pFNNRORESOLUCION = FNNRORESOLUCION;
            pFAIDCIUDADANO = FAIDCIUDADANO;
            pFANROEXPEDIENTE = FANROEXPEDIENTE;
            pFAANIORESOLUCION = FAANIORESOLUCION;
        }

        private void FrmReportCrisResolucionInicioOP_Load(object sender, EventArgs e)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("PA_COAC_RESOLUCIONINICIO_OP", sqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@FNNRONRESOLUCION", pFNNRORESOLUCION);
            sqlda.SelectCommand.Parameters.AddWithValue("@FAIDCIUDADANO", pFAIDCIUDADANO);
            sqlda.SelectCommand.Parameters.AddWithValue("@FANROEXPED", pFANROEXPEDIENTE);
            sqlda.SelectCommand.Parameters.AddWithValue("@FAANIORESOLUCION", pFAANIORESOLUCION);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            sqlcon.Close();
            SISCONVAL.ReportResolucionDeInicio___OP reportResolucionDeInicio = new ReportResolucionDeInicio___OP();
            reportResolucionDeInicio.Database.Tables["PA_COAC_RESOLUCIONINICIO_OP"].SetDataSource(dtbl);
            crvResolucionInicioOP.ReportSource = null;
            crvResolucionInicioOP.ReportSource = reportResolucionDeInicio;
        }
    }
}
