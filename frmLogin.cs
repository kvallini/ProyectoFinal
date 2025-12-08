using ProyectoFinal.Clases;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text.Trim();
                string contrasena = txtContrasena.Text.Trim();

                string tipoAcceso = "Cliente";

                InfoLogin info = new InfoLogin(usuario, contrasena, tipoAcceso);

                ValidacionLogin valida = new ValidacionLogin(
                    info._Usuario,
                    info._Contrasena,
                    info._TipoAcceso
                );

                if (valida.EsValido())
                {
                    MessageBox.Show(valida.MensajeBienvenida(),
                                    "Acceso correcto",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    frmMenuPrincipal frm = new frmMenuPrincipal();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.",
                                    "Acceso denegado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtContrasena.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            frmRegistroCliente f = new frmRegistroCliente();
            f.Show();
            this.Hide();
        }

        private void btnAccesoColaboradores_Click(object sender, EventArgs e)
        {
            frmLoginColab f = new frmLoginColab();
            f.Show();
            this.Hide();
        }
    }
}
