using System;

namespace ProyectoFinal
{
    public static class DatosCompra
    {
        // Vehículo
        public static int IdVehiculo { get; set; }
        public static string Marca { get; set; }
        public static string Modelo { get; set; }
        public static int Año { get; set; } // CON TILDE
        public static decimal Precio { get; set; }

        // Financiamiento
        public static int BancoId { get; set; }
        public static string BancoNombre { get; set; }
        public static decimal CuotaBanco { get; set; }

        // Seguro
        public static bool Seguro { get; set; }

        // Total
        public static decimal CuotaTotal
        {
            get
            {
                decimal total = CuotaBanco;
                if (Seguro) total += 28;
                return total;
            }
        }

        public static void Limpiar()
        {
            IdVehiculo = 0;
            Marca = "";
            Modelo = "";
            Año = 0;
            Precio = 0;
            BancoId = 0;
            BancoNombre = "";
            CuotaBanco = 0;
            Seguro = false;
        }
    }
}