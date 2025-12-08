using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    // Esta es la "informacion" del ejemplo del profe,
    // pero aplicada a login
    internal class InfoLogin
    {
        // Campos protegidos
        protected string usuario;
        protected string contrasena;
        protected string tipoAcceso; // Cliente, Colaborador, Admin, etc.

        // Propiedades (mismo estilo _Nombre)
        public string _Usuario
        {
            get => usuario;
            set => usuario = value;
        }

        public string _Contrasena
        {
            get => contrasena;
            set => contrasena = value;
        }

        public string _TipoAcceso
        {
            get => tipoAcceso;
            set => tipoAcceso = value;
        }

        // Método "datos" igual que en el ejemplo
        public string datos()
        {
            return "El usuario " + this.usuario +
                   " intenta iniciar sesión como " + this.tipoAcceso;
        }

        // Constructor con parámetros
        public InfoLogin(string usuario, string contrasena, string tipoAcceso)
        {
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.tipoAcceso = tipoAcceso;
        }

        // Constructor vacío
        public InfoLogin()
        {

        }
    }
}