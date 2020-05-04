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
    public partial class frmNotificador : Form
    {
        ValoresDataContext BD = new ValoresDataContext();
        public frmNotificador()
        {
            InitializeComponent();
            dgvNotificadores.DataSource = from N in BD.NOTIFICADOR select N;

            dgvNotificadores.MultiSelect = true;
            dgvNotificadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotificadores.ReadOnly = true;
            dgvNotificadores.AllowUserToAddRows = false;
            dgvNotificadores.BackgroundColor = Color.White;
            dgvNotificadores.RowHeadersVisible = false;
            dgvNotificadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnIngresarNotificador_Click(object sender, EventArgs e)
        {
            NOTIFICADOR N = new NOTIFICADOR();
            N.FANOMNOTR = txtNombreNotificador.Text;
            N.FANOMCORT = txtNombreCorto.Text;

            int EXISTE = (from R in BD.NOTIFICADOR where R.FANOMCORT == txtNombreCorto.Text select R.FANOMCORT).Count();
            if (EXISTE == 1)
            {
                MessageBox.Show("YA EXISTE NOMBRE CORTO");
            }
            else
            {
                BD.NOTIFICADOR.InsertOnSubmit(N);
                BD.SubmitChanges();
            }
            dgvNotificadores.DataSource = from G in BD.NOTIFICADOR select G;


        }

        private void txtModificarNotificador_Click(object sender, EventArgs e)
        {
            try
            {
                NOTIFICADOR N = (from I in BD.NOTIFICADOR where I.FANOMCORT == txtNombreCorto.Text select I).First();
                N.FANOMCORT = txtNombreCorto.Text;
                N.FANOMNOTR = txtNombreNotificador.Text;
                //BD.NOTIFICADOR.(N);
                BD.SubmitChanges();

                dgvNotificadores.DataSource = from G in BD.NOTIFICADOR select G;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void txtEliminarNotificador_Click(object sender, EventArgs e)
        {
            try
            {
                NOTIFICADOR N = (from I in BD.NOTIFICADOR where I.FANOMCORT == txtNombreCorto.Text select I).First();
                BD.NOTIFICADOR.DeleteOnSubmit(N);
                BD.SubmitChanges();
                dgvNotificadores.DataSource = from G in BD.NOTIFICADOR select G;
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

        private void dgvNotificadores_SelectionChanged(object sender, EventArgs e)
        {
            txtNombreCorto.Text = dgvNotificadores.Rows[dgvNotificadores.CurrentRow.Index].Cells["FANOMCORT"].Value.ToString();
            txtNombreNotificador.Text = dgvNotificadores.Rows[dgvNotificadores.CurrentRow.Index].Cells["FANOMNOTR"].Value.ToString();
        }
    }
}
