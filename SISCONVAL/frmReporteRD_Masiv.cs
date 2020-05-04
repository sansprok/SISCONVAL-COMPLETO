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
    public partial class frmReporteRD_Masiv : Form
    {
        int pFAANIORESOLUCION;
        int pFANRORESOLUCION_INI;
        int pFANRORESOLUCION_FIN;
        SqlConnection sqlcon = new SqlConnection(@"Data Source=USUARIO-4HQE76I\SSQLMDWPMSER06;Initial Catalog=AUXWANCHAQ;User ID=sa;Password=wanchaqsql-2013");
        public frmReporteRD_Masiv(int FAANIORESOLUCION, int FNNRORESOLUCION_INI, int FNNRORESOLUCION_FIN)
        {
            InitializeComponent();
            pFAANIORESOLUCION = FAANIORESOLUCION;
            pFANRORESOLUCION_INI = FNNRORESOLUCION_INI;
            pFANRORESOLUCION_FIN = FNNRORESOLUCION_FIN;
        }

        private void FrmReporteRD_Masiv_Load(object sender, EventArgs e)
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
            SISCONVAL.ReportRD_Masiv reportResolucionMasiv = new ReportRD_Masiv();
            reportResolucionMasiv.Database.Tables["PA_CONTROLDEUDA_DATOSVALOR_MASIV"].SetDataSource(dtbl);
            crvREPORTE_RD_MASIV.ReportSource = null;
            crvREPORTE_RD_MASIV.ReportSource = reportResolucionMasiv;
        }
    }
}
