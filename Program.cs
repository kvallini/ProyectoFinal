using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;   

namespace ProyectoFinal
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Configuración básica de Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Formulario inicial del sistema
           Application.Run(new frmLogin());   // Cambia frmLogin si quieres abrir otro form primero
           //Application.Run(new frmCatalogoVehiculos());
        }
    }
}