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

namespace SISCONVAL
{
    public partial class FrmReportCrysResolucionRentencion : Form
    {
        int pFNNRORESOLUCION;
        string pFAIDCIUDADANO;
        string pFANROEXPEDIENTE;
        string pFATIPOVALOR;
        int pFAANIOEXPED;
        SqlConnection sqlcon = new SqlConnection(@"Data Source=192.168.1.28\SQLMDW28;Initial Catalog=AUXWANCHAQ;User ID=sa;Password=wanchaqsql-2013");
        //SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=AUXWANCHAQ;Integrated Security=True");


        public FrmReportCrysResolucionRentencion(int FNNRORESOLUCION, string FAIDCIUDADANO, string FANROEXPEDIENTE, string FATIPOVALOR, int FAANIOEXPED)
        {
            InitializeComponent();
            pFNNRORESOLUCION = FNNRORESOLUCION;
            pFAIDCIUDADANO = FAIDCIUDADANO;
            pFANROEXPEDIENTE = FANROEXPEDIENTE;
            pFATIPOVALOR = FATIPOVALOR;
            pFAANIOEXPED = FAANIOEXPED;
        }

        private void FrmReportCrysResolucionRentencion_Load(object sender, EventArgs e)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("PA_COAC_RESOLUCIONRETENCION", sqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@FNNRORESOLUCION", pFNNRORESOLUCION);
            sqlda.SelectCommand.Parameters.AddWithValue("@FAIDCIUDADANO", pFAIDCIUDADANO);
            sqlda.SelectCommand.Parameters.AddWithValue("@FANROEXPED", pFANROEXPEDIENTE);
            sqlda.SelectCommand.Parameters.AddWithValue("@FATIPOVALOR", pFATIPOVALOR);
            sqlda.SelectCommand.Parameters.AddWithValue("@FAANIOEXPED", pFAANIOEXPED);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            sqlcon.Close();
            SISCONVAL.ReportResolucionRetencion reportResolucionDeRetencion = new ReportResolucionRetencion();
            reportResolucionDeRetencion.Database.Tables["PA_COAC_RESOLUCIONRETENCION"].SetDataSource(dtbl);
            crvResRetencion.ReportSource = null;
            crvResRetencion.ReportSource = reportResolucionDeRetencion;
        }
    }
}
