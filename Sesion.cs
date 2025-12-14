using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public static class Sesion
    {
        // Datos del usuario logeado
        public static int ID_Usuario { get; set; }
        public static string TipoUsuario { get; set; } // "Cliente", "Administrador", etc.
        public static string Nombre { get; set; }
        public static string Email { get; set; }

        // Datos específicos de cliente
        public static int ID_Cliente { get; set; }

        // Datos específicos de empleado
        public static int ID_Empleado { get; set; }
        public static string RolEmpleado { get; set; }

        // Verificar si hay cliente logeado
        public static bool ClienteEstaLogeado()
        {
            return ID_Cliente > 0 && TipoUsuario == "Cliente";
        }

        // Verificar si hay empleado logeado
        public static bool EmpleadoEstaLogeado()
        {
            return ID_Empleado > 0 && !string.IsNullOrEmpty(TipoUsuario);
        }

        // Limpiar sesión (logout)
        public static void Limpiar()
        {
            ID_Usuario = 0;
            TipoUsuario = "";
            Nombre = "";
            Email = "";
            ID_Cliente = 0;
            ID_Empleado = 0;
            RolEmpleado = "";
        }
    }
}