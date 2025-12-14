using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProyectoFinal.Clases
{
    internal class ValidacionLogin : InfoLogin
    {
        public int ID_Cliente { get; private set; }
        public string NombreCompleto { get; private set; }
        public string EmailReal { get; private set; }

        public ValidacionLogin(string usuario, string contrasena, string tipoAcceso)
        {
            _Usuario = usuario;
            _Contrasena = contrasena;
            _TipoAcceso = tipoAcceso;
        }

        // Método para codificar Base64
        private string CodificarBase64(string texto)
        {
            byte[] datos = Encoding.UTF8.GetBytes(texto);
            return Convert.ToBase64String(datos);
        }

        public bool EsValido()
        {
            // Solo validar clientes
            if (_TipoAcceso != "Cliente")
            {
                Console.WriteLine($" Acceso no Invalido: {_TipoAcceso}");
                return false;
            }

            try
            {

                string contrasenaCodificada = CodificarBase64(_Contrasena);
                Console.WriteLine($" Contraseña codificada: {contrasenaCodificada}");

                string connectionString =
                    @"Data Source=CAVALLINI\CURSOSQL2022;
                      Initial Catalog=SISTEMA_VENTA_AUTOS_USADOS;
                      User ID=sa;Password=12345678";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            U.ID_Usuario, 
                            U.Email, 
                            U.Password, 
                            C.ID_Cliente, 
                            C.Nombre, 
                            C.Primer_Apellido
                        FROM USUARIOS U
                        INNER JOIN CLIENTES C ON U.ID_Usuario = C.ID_Usuario
                        WHERE U.Email = @email 
                        AND U.Password = @password
                        AND U.Estado = 1
                        AND C.Estado = 1";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", _Usuario);
                    cmd.Parameters.AddWithValue("@password", contrasenaCodificada);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        ID_Cliente = reader.GetInt32(reader.GetOrdinal("ID_Cliente"));
                        NombreCompleto = $"{reader["Nombre"]} {reader["Primer_Apellido"]}";
                        EmailReal = reader["Email"].ToString();

                        Console.WriteLine($" Login exitoso: {NombreCompleto} (ID: {ID_Cliente})");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($" No se encontró usuario en BD: {_Usuario}");
                        return false;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($" ERROR SQL: {sqlEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($" ERROR: {ex.Message}");
                return false;
            }
        }

        public string MensajeBienvenida()
        {
            return $"Bienvenido {NombreCompleto}";
        }
    }
}