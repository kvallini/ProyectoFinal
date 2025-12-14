using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            frmCatalogoVehiculos catalogo = new frmCatalogoVehiculos();
            catalogo.Show();
            this.Hide();
        }

        private void catalogoDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatalogoVehiculos catalogo = new frmCatalogoVehiculos();
            catalogo.Show();
        }

        private void btnCatalogo_Click_1(object sender, EventArgs e)
        {
            frmCatalogoVehiculos catalogo = new frmCatalogoVehiculos();
            catalogo.Show();
        }

        private void serviciosAdicionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicios servicios = new frmServicios();
            servicios.Show();
        }

        private void btnServiciosAdicionales_Click(object sender, EventArgs e)
        {
            frmServicios servicios = new frmServicios();
            servicios.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void btnMisCitas_Click(object sender, EventArgs e)
        {

        }
    }
}
