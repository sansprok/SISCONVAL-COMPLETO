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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            bool var = true;
            if (var)
            {
                cONTROLDEDEUDAToolStripMenuItem.Enabled = false;
                cONTROLDEDEUDAToolStripMenuItem.Visible = false;
            }
        }

        private void cONTROLDEDEUDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmControlDeuda Control = new frmControlDeuda();
            Control.MdiParent = this;
            Control.Show();
        }

        private void cOBRANZACOACTIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoactivaControl Coactiva = new frmCoactivaControl();
            Coactiva.MdiParent = this;
            Coactiva.Show();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
