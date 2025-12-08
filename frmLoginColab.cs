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
    public partial class frmLoginColab : Form
    {
        public frmLoginColab()
        {
            InitializeComponent();

            // Opcional: manejar aquí los otros botones
            btnSalirColab.Click += btnSalirColab_Click;
            btnLoginColab.Click += btnLoginColab_Click;
        }

        private void btnEntrarColab_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Leer datos de pantalla
                string usuario = txtColab.Text.Trim();
                string contrasena = txtContrasena.Text.Trim();
                string tipoAcceso = "Colaborador";

                // 2. Validar que no vayan vacíos
                if (usuario == "" || contrasena == "")
                {
                    MessageBox.Show("Debe ingresar usuario y contraseña.",
                                    "Datos incompletos",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtColab.Focus();
                    return;
                }

                // 3. Aquí usaríamos la clase de validación (cuando tengamos BD)
                //    De momento, para probar, dejamos un ejemplo básico:

                bool credencialesOk = (usuario == "colab" && contrasena == "1234");

                if (credencialesOk)
                {
                    MessageBox.Show("Bienvenido " + usuario + " (" + tipoAcceso + ")",
                                    "Acceso correcto",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    // Abrir menú principal del administrador o del rol que corresponda
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
                    txtColab.Focus();
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

        private void btnSalirColab_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoginColab_Click(object sender, EventArgs e)
        {
            // Volver al login de clientes
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }
    }
}