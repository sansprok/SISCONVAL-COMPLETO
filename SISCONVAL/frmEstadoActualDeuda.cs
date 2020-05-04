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
    public partial class frmEstadoActualDeuda : Form
    {
        ValoresDataContext BD = new ValoresDataContext();
        
        public frmEstadoActualDeuda()
        {
            InitializeComponent();

        }

        private void FrmEstadoActualDeuda_Load(object sender, EventArgs e)
        {
            dgvSituacionRDsGENERAL.MultiSelect = true;
            dgvSituacionRDsGENERAL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSituacionRDsGENERAL.ReadOnly = true;
            dgvSituacionRDsGENERAL.AllowUserToAddRows = false;
            dgvSituacionRDsGENERAL.BackgroundColor = Color.White;
            dgvSituacionRDsGENERAL.RowHeadersVisible = false;
            dgvSituacionRDsGENERAL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSituacionRDsGENERAL.DataSource = from E in BD.SITUACIONACTUALRDS select E;   
        }
    }
}
