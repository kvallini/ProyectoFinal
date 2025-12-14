using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmServicios : Form
    {
        // Propiedades públicas (se llenan desde frmCatalogoVehiculos)
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal PrecioVehiculo { get; set; }
        public int IdVehiculo { get; set; }

        // ID Cliente (TEMPORAL - luego viene del login)
        private int IdCliente = 1;

        // Variables internas
        private decimal cuotaMensualBanco = 0;
        private string bancoSeleccionado = "";

        public frmServicios()
        {
            InitializeComponent();
        }

        private void frmServicios_Load_1(object sender, EventArgs e)
        {
            try
            {
                // 1. Mostrar datos del vehículo
                lblVehiculo.Text = $"{Marca} {Modelo}";
                lblPrecio.Text = $"${PrecioVehiculo:N2}";

                // 2. Cargar bancos desde la BD
                CargarInstitucionesFinancieras();

                // 3. Conectar eventos
                cmbBancos.SelectedIndexChanged += CmbBancos_SelectedIndexChanged;
                chkSeguro.CheckedChanged += (s, ev) => CalcularCuotaTotal();
                btnAceptar.Click += BtnAceptar_Click;
                btnCancelar.Click += (s, ev) => this.Close();

                // 4. Calcular cuota inicial
                CalcularCuotaTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar formulario: {ex.Message}");
            }
        }

        private void CargarInstitucionesFinancieras()
        {
            try
            {
                string connStr = @"Data Source=CAVALLINI\CURSOSQL2022;Initial Catalog=SISTEMA_VENTA_AUTOS_USADOS;User ID=sa;Password=12345678";

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = @"SELECT Nombre_Institucion, Tasa_Interes, Plazo_Maximo 
                                   FROM INSTITUCIONES_FINANCIERAS 
                                   WHERE Estado = 1 
                                   ORDER BY Tasa_Interes ASC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbBancos.Items.Clear();

                    while (reader.Read())
                    {
                        string nombre = reader["Nombre_Institucion"].ToString();
                        decimal tasa = Convert.ToDecimal(reader["Tasa_Interes"]);
                        int plazo = Convert.ToInt32(reader["Plazo_Maximo"]);

                        // Formato: "Banco Promerica (9.50% - 60 meses)"
                        cmbBancos.Items.Add($"{nombre} ({tasa}% - {plazo} meses)");
                    }

                    // Seleccionar el primer banco por defecto
                    if (cmbBancos.Items.Count > 0)
                        cmbBancos.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando bancos: {ex.Message}");
            }
        }

        private void CmbBancos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBancos.SelectedIndex >= 0)
            {
                string texto = cmbBancos.SelectedItem.ToString();
               
                bancoSeleccionado = texto.Split('(')[0].Trim();         
                cuotaMensualBanco = PrecioVehiculo / 60 * 1.1m; 

                // Recalcular total
                CalcularCuotaTotal();
            }
        }

        private void CalcularCuotaTotal()
        {
            decimal cuotaTotal = cuotaMensualBanco;

            // Agregar +28 
            if (chkSeguro.Checked)
                cuotaTotal += 28.00m;

            // Mostrar en el label
            lblTotal.Text = $"${cuotaTotal:N2}/mes";
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            // Validar selección de banco
            if (cmbBancos.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione una institución financiera.",
                              "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calcular prima del 20%
            decimal prima = PrecioVehiculo * 0.20m;

            // Mostrar confirmación con todos los detalles
            string mensajeConfirmacion =
                $"¿CONFIRMAR PROCESO DE COMPRA?\n\n" +
                $" RESUMEN DE COMPRA:\n" +
                $"────────────────────\n" +
                $"• Vehículo: {Marca} {Modelo}\n" +
                $"• Precio: ${PrecioVehiculo:N2}\n" +
                $"• Prima (20%): ${prima:N2}\n" +
                $"• Financiamiento: {bancoSeleccionado}\n" +
                $"• Cuota mensual: {lblTotal.Text}\n" +
                $"• Seguro: {(chkSeguro.Checked ? "SÍ (+$28/mes)" : "NO")}\n\n" +
                $" PROCESO AUTOMÁTICO:\n" +
                $"────────────────────\n" +
                $"1. Reserva inmediata del vehículo\n" +
                $"2. Cita automática: Mañana 10:00 AM\n" +
                $"3. Registro de prima del 20%\n\n" +
                $"¿Desea continuar?";

            DialogResult respuesta = MessageBox.Show(
                mensajeConfirmacion,
                "Confirmar Proceso Completo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                // Ejecutar todo el proceso
                if (ProcesarCompraCompleta())
                {
                    MessageBox.Show(
                        " ¡PROCESO COMPLETADO EXITOSAMENTE!\n\n" +
                        " Vehículo reservado\n" +
                        " Cita solicitada para mañana 10:00 AM\n" +
                        " Prima del 20% registrada\n" +
                        " Recepcionista contactará para confirmar cita\n\n" +
                        " Será contactado próximamente para detalles finales",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Cerrar formulario
                    this.Close();
                }
            }
        }

        private bool ProcesarCompraCompleta()
        {
            try
            {
                string connStr = @"Data Source=CAVALLINI\CURSOSQL2022;Initial Catalog=SISTEMA_VENTA_AUTOS_USADOS;User ID=sa;Password=12345678";

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // 1. RESERVAR VEHÍCULO
                    SqlCommand cmdReserva = new SqlCommand(
                        "UPDATE VEHICULOS SET Estado_Vehiculo = 'Reservado' WHERE ID_Vehiculo = @idVehiculo",
                        conn);
                    cmdReserva.Parameters.AddWithValue("@idVehiculo", IdVehiculo);
                    cmdReserva.ExecuteNonQuery();

                    // 2. CALCULAR PRIMA (20%)
                    decimal prima = PrecioVehiculo * 0.20m;

                    // 3. CREAR RESERVA
                    SqlCommand cmdInsertReserva = new SqlCommand(
                        @"INSERT INTO RESERVAS 
                  (ID_Cliente, ID_Vehiculo, Fecha_Reserva, Fecha_Vencimiento, Estado_Reserva, Deposito)
                  VALUES 
                  (@idCliente, @idVehiculo, GETDATE(), DATEADD(DAY, 7, GETDATE()), 'Activa', @deposito)",
                        conn);
                    cmdInsertReserva.Parameters.AddWithValue("@idCliente", IdCliente);
                    cmdInsertReserva.Parameters.AddWithValue("@idVehiculo", IdVehiculo);
                    cmdInsertReserva.Parameters.AddWithValue("@deposito", prima);
                    cmdInsertReserva.ExecuteNonQuery();

                    // 4. SOLICITAR CITA (SIN AGENTE ASIGNADO - NULL)
                    DateTime fechaCitaSolicitada = DateTime.Today.AddDays(1).AddHours(10);

                    SqlCommand cmdInsertCita = new SqlCommand(
                        @"INSERT INTO CITAS 
                  (ID_Cliente, ID_Agente, ID_Vehiculo, Fecha_Cita, Tipo_Cita, Estado_Cita, Motivo, Fecha_Creacion)
                  VALUES 
                  (@idCliente, NULL, @idVehiculo, @fechaCita, 'Venta', 'Solicitada', 
                  'Cliente solicita cita para revisión de documentación y firma de contrato. Prima del 20% registrada.', GETDATE())",
                        conn);
                    cmdInsertCita.Parameters.AddWithValue("@idCliente", IdCliente);
                    cmdInsertCita.Parameters.AddWithValue("@idVehiculo", IdVehiculo);
                    cmdInsertCita.Parameters.AddWithValue("@fechaCita", fechaCitaSolicitada);
                    cmdInsertCita.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }
    
    }
}