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
    public partial class frmAuxiliar : Form
    {
        ValoresDataContext BD = new ValoresDataContext();
        public frmAuxiliar()
        {
            InitializeComponent();
            dgvAuxiliarCoac.DataSource = from N in BD.AUXILIAR select N;

            dgvAuxiliarCoac.MultiSelect = true;
            dgvAuxiliarCoac.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuxiliarCoac.ReadOnly = true;
            dgvAuxiliarCoac.AllowUserToAddRows = false;
            dgvAuxiliarCoac.BackgroundColor = Color.White;
            dgvAuxiliarCoac.RowHeadersVisible = false;
            dgvAuxiliarCoac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnIngresarAuxiliar_Click(object sender, EventArgs e)
        {
            AUXILIAR N = new AUXILIAR();
            N.FANOMAUXI = txtAuxNombreAuxiliar.Text;
            N.FANOMCORT = txtAuxNombreCorto.Text;

            int EXISTE = (from R in BD.AUXILIAR where R.FANOMCORT == txtAuxNombreCorto.Text select R.FANOMCORT).Count();
            if (EXISTE == 1)
            {
                MessageBox.Show("YA EXISTE NOMBRE CORTO");
            }
            else
            {
                BD.AUXILIAR.InsertOnSubmit(N);
                BD.SubmitChanges();
            }
            dgvAuxiliarCoac.DataSource = from G in BD.AUXILIAR select G;
        }

        private void btnModificarAuxiliar_Click(object sender, EventArgs e)
        {
            try
            {
                AUXILIAR N = (from I in BD.AUXILIAR where I.FANOMCORT == txtAuxNombreCorto.Text select I).First();
                N.FANOMCORT = txtAuxNombreCorto.Text;
                N.FANOMAUXI = txtAuxNombreAuxiliar.Text;
                //BD.NOTIFICADOR.(N);
                BD.SubmitChanges();

                dgvAuxiliarCoac.DataSource = from G in BD.AUXILIAR select G;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnEliminarAuxiliar_Click(object sender, EventArgs e)
        {
            try
            {
                AUXILIAR N = (from I in BD.AUXILIAR where I.FANOMCORT == txtAuxNombreCorto.Text select I).First();
                BD.AUXILIAR.DeleteOnSubmit(N);
                BD.SubmitChanges();
                dgvAuxiliarCoac.DataSource = from G in BD.AUXILIAR select G;
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAuxiliarCoac_SelectionChanged(object sender, EventArgs e)
        {
            txtAuxNombreCorto.Text = dgvAuxiliarCoac.Rows[dgvAuxiliarCoac.CurrentRow.Index].Cells["FANOMCORT"].Value.ToString();
            txtAuxNombreAuxiliar.Text = dgvAuxiliarCoac.Rows[dgvAuxiliarCoac.CurrentRow.Index].Cells["FANOMAUXI"].Value.ToString();
        }
    }
}
