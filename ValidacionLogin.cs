using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    internal class ValidacionLogin : InfoLogin
    {
        public ValidacionLogin(string usuario, string contrasena, string tipoAcceso)
        {
            _Usuario = usuario;
            _Contrasena = contrasena;
            _TipoAcceso = tipoAcceso;
        }

        // Validación básica "quemada" para pruebas
        public bool EsValido()
        {
            // LOGIN DE CLIENTE
            if (_Usuario == "cliente" && _Contrasena == "1111" && _TipoAcceso == "Cliente")
                return true;

            // LOGIN DE COLABORADORES
            // Admin
            if (_Usuario == "admin" && _Contrasena == "1234" && _TipoAcceso == "Administrador")
                return true;

            // Agente
            if (_Usuario == "agente1" && _Contrasena == "2222" && _TipoAcceso == "Agente")
                return true;

            // Recepcionista
            if (_Usuario == "recep1" && _Contrasena == "3333" && _TipoAcceso == "Recepcionista")
                return true;

            // Cajera
            if (_Usuario == "cajera1" && _Contrasena == "4444" && _TipoAcceso == "Cajera")
                return true;

            return false;
        }

        public string MensajeBienvenida()
        {
            return "Bienvenido " + this.usuario + " (" + this.tipoAcceso + ")";
        }
    }
}