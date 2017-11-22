using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rapidCargoEscritorio
{
    public partial class frmMenuGerente : Form
    {
        public frmMenuGerente()
        {
            InitializeComponent();
        }

        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRutas rutas = new frmRutas();
            rutas.Tag = this;
            rutas.Show(this);
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmVehiculos vehiculos = new frmVehiculos();
            vehiculos.Tag = this;
            vehiculos.Show(this);*/
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmPersonal personal = new frmPersonal();
            personal.Tag = this;
            personal.Show(this);*/
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmReportes reportes = new frmReportes();
            reportes.Tag = this;
            reportes.Show(this);*/
        }
    }
}
