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
    public partial class frmReportCristalEstadoMasivo : Form
    {
        string pFAIDCIUDADANO;
        string pFADIRECCION;
        int pFATIPO;
        SqlConnection sqlcon= new SqlConnection(@"Data Source=192.168.1.28\sqlmdw28;Initial Catalog=AUXWANCHAQ;User ID=sa;Password=wanchaqsql-2013");
        //SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=AUXWANCHAQ;User ID=sa;Password=Server2010");
        public frmReportCristalEstadoMasivo(string FAIDCIUDADANO, string FADIRECCION, int FATIPO)
        {
            InitializeComponent();
            pFADIRECCION = FADIRECCION;
            pFAIDCIUDADANO = FAIDCIUDADANO;
            pFATIPO = FATIPO;
        }

        private void FrmReportCristalEstadoMasivo_Load(object sender, EventArgs e)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("PA_ESTADOCUENTA",sqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@FAIDCIUDADANO", pFAIDCIUDADANO);
            sqlda.SelectCommand.Parameters.AddWithValue("@FADIRECCION", pFADIRECCION);
            sqlda.SelectCommand.Parameters.AddWithValue("@FATIPO", pFATIPO);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            sqlcon.Close();
            SISCONVAL.ReportEstadoCuentaMasivo reporteMasivo = new ReportEstadoCuentaMasivo();
            reporteMasivo.Database.Tables["PA_ESTADOCUENTA"].SetDataSource(dtbl);
            crvEstadoCuentaMasivo.ReportSource = null;
            crvEstadoCuentaMasivo.ReportSource = reporteMasivo;

        }
    }
}
