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
    public partial class frmResporteResolucionMasiva : Form
    {
        int pFAANIORESOLUCION;
        int pFANRORESOLUCION_INI;
        int pFANRORESOLUCION_FIN;
        /*CONEXION WANCHAQ*/  SqlConnection sqlcon = new SqlConnection(@"Data Source=192.168.1.28\sqlmdw28;Initial Catalog=AUXWANCHAQ;User ID=sa;Password=wanchaqsql-2013");
       // /*CONEXION LOCAL*/SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=AUXWANCHAQ;User ID=sa;Password=Server2010");
        public frmResporteResolucionMasiva(int FAANIORESOLUCION, int FNNRORESOLUCION_INI, int FNNRORESOLUCION_FIN)
        {
            InitializeComponent();
            pFAANIORESOLUCION = FAANIORESOLUCION;
            pFANRORESOLUCION_INI = FNNRORESOLUCION_INI;
            pFANRORESOLUCION_FIN = FNNRORESOLUCION_FIN;
        }
        private void FrmResporteResolucionMasiva_Load(object sender, EventArgs e)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("PA_CONTROLDEUDA_DATOSVALOR_MASIV", sqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@FAANIORESOLUCION", pFAANIORESOLUCION);
            sqlda.SelectCommand.Parameters.AddWithValue("@FNNRORESOLUCION_INI", pFANRORESOLUCION_INI);
            sqlda.SelectCommand.Parameters.AddWithValue("@FNNRORESOLUCION_FIN", pFANRORESOLUCION_FIN);     
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            sqlcon.Close();
            SISCONVAL.ReportResolucionMasiva reportResolucionMasiv = new ReportResolucionMasiva();
            reportResolucionMasiv.Database.Tables["PA_CONTROLDEUDA_DATOSVALOR_MASIV"].SetDataSource(dtbl);
            crvResolucionMasiva.ReportSource = null;
            crvResolucionMasiva.ReportSource = reportResolucionMasiv;
        }
    }
}

