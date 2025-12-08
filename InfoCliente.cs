using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    internal class InfoCliente
    {
        // Campos protegidos
        protected string tipoId;
        protected string numeroId;
        protected string nombre;
        protected string primerApellido;
        protected string segundoApellido;
        protected string telefono;
        protected string email;
        protected string direccion;
        protected string usuario;
        protected string contrasena;

        // Propiedades (mismo estilo que el ejemplo del profe)
        public string _TipoId
        {
            get => tipoId;
            set => tipoId = value;
        }

        public string _NumeroId
        {
            get => numeroId;
            set => numeroId = value;
        }

        public string _Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string _PrimerApellido
        {
            get => primerApellido;
            set => primerApellido = value;
        }

        public string _SegundoApellido
        {
            get => segundoApellido;
            set => segundoApellido = value;
        }

        public string _Telefono
        {
            get => telefono;
            set => telefono = value;
        }

        public string _Email
        {
            get => email;
            set => email = value;
        }

        public string _Direccion
        {
            get => direccion;
            set => direccion = value;
        }

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

        // Método tipo datos()
        public string datosRegistro()
        {
            return "El cliente " + this.nombre + " " + this.primerApellido +
                   " con ID " + this.tipoId + " " + this.numeroId +
                   " y usuario '" + this.usuario + "'" +
                   " ha sido registrado correctamente.";
        }

        // Constructor con parámetros
        public InfoCliente(string tipoId, string numeroId,
                           string nombre, string primerApellido, string segundoApellido,
                           string telefono, string email, string direccion,
                           string usuario, string contrasena)
        {
            this.tipoId = tipoId;
            this.numeroId = numeroId;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.telefono = telefono;
            this.email = email;
            this.direccion = direccion;
            this.usuario = usuario;
            this.contrasena = contrasena;
        }

        // Constructor vacío
        public InfoCliente()
        {
        }
    }
}
