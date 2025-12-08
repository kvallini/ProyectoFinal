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
    public partial class frmManteColabcs : Form
    {
        public frmManteColabcs()
        {
            InitializeComponent();
        }

        private void btnGuardarColab_Click(object sender, EventArgs e)
        {
            // Por ahora solo para que compile y puedas probar:
            MessageBox.Show("Aquí luego grabamos el colaborador en la base de datos.",
                            "Guardar colaborador",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    
    }
}
