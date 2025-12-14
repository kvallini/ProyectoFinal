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
        public int IdCliente = 1;

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
                lblVehiculo.Text = $"{Marca} {Modelo}";
                lblPrecio.Text = $"${PrecioVehiculo:N2}";

                CargarInstitucionesFinancieras();

                cmbBancos.SelectedIndexChanged += CmbBancos_SelectedIndexChanged;
                chkSeguro.CheckedChanged += (s, ev) => CalcularCuotaTotal();
                btnAceptar.Click += BtnAceptar_Click;
                btnCancelar.Click += (s, ev) => this.Close();

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
            if (cmbBancos.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un banco");
                return;
            }

            // CALCULAR TODO
            decimal prima = PrecioVehiculo * 0.20m;
            decimal cuotaMensual = (PrecioVehiculo - prima) / 60 * 1.1m;

            if (chkSeguro.Checked)
                cuotaMensual += 28;

            // MOSTRAR RESUMEN
            string resumen =
                $" RESUMEN DE COMPRA\n\n" +
                $"Vehículo: {Marca} {Modelo}\n" +
                $"Precio: ${PrecioVehiculo:N2}\n" +
                $"Prima (20%): ${prima:N2}\n" +
                $"Financiamiento: {cmbBancos.SelectedItem}\n" +
                $"Seguro: {(chkSeguro.Checked ? "Sí (+$28/mes)" : "No")}\n" +
                $"Cuota mensual: ${cuotaMensual:N2}\n\n" +
                $" Se solicitará:\n" +
                $"• Reserva del vehículo\n" +
                $"• Cita para mañana\n" +
                $"• Recepcionista asignará agente\n\n" +
                $"¿Confirmar?";

            DialogResult respuesta = MessageBox.Show(resumen,
                                                   "Confirmar Compra y Solicitar Cita",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (ProcesarCompraCompleta())
                {
                    MessageBox.Show(" Proceso completado.\nVehículo reservado.\nCita solicitada.",
                                   "Éxito",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private bool ProcesarCompraCompleta()
        {
            SqlTransaction transaction = null;
            try
            {
                string connStr = @"Data Source=CAVALLINI\CURSOSQL2022;Initial Catalog=SISTEMA_VENTA_AUTOS_USADOS;User ID=sa;Password=12345678";

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // VERIFICAR CLIENTE EXISTE
                    string sqlCheckCliente = "SELECT COUNT(*) FROM CLIENTES WHERE ID_Cliente = @cliente";
                    using (SqlCommand cmdCheck = new SqlCommand(sqlCheckCliente, conn, transaction))
                    {
                        cmdCheck.Parameters.AddWithValue("@cliente", IdCliente);
                        if ((int)cmdCheck.ExecuteScalar() == 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Cliente no encontrado en el sistema",
                                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    //  VERIFICAR VEHÍCULO DISPONIBLE
                    string sqlCheckVehiculo = "SELECT Estado_Vehiculo FROM VEHICULOS WHERE ID_Vehiculo = @vehiculo";
                    using (SqlCommand cmdCheck = new SqlCommand(sqlCheckVehiculo, conn, transaction))
                    {
                        cmdCheck.Parameters.AddWithValue("@vehiculo", IdVehiculo);
                        object resultado = cmdCheck.ExecuteScalar();

                        if (resultado == null)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Vehículo no encontrado",
                                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        string estado = resultado.ToString();
                        if (estado != "Disponible")
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Vehículo no disponible. Estado actual: {estado}",
                                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    // RESERVAR VEHÍCULO
                    string sqlReserva = "UPDATE VEHICULOS SET Estado_Vehiculo = 'Reservado' WHERE ID_Vehiculo = @id";
                    using (SqlCommand cmdReserva = new SqlCommand(sqlReserva, conn, transaction))
                    {
                        cmdReserva.Parameters.AddWithValue("@id", IdVehiculo);
                        cmdReserva.ExecuteNonQuery();
                    }

                    //  INSERTAR CITA
                    string sqlCita = @"
                INSERT INTO CITAS 
                (ID_Cliente, ID_Agente, ID_Vehiculo, Fecha_Cita, Tipo_Cita, Estado_Cita, Motivo, Fecha_Creacion) 
                VALUES 
                (@cliente, 
                 NULL,
                 @vehiculo, 
                 DATEADD(DAY, 1, GETDATE()),
                 'Negociación',
                 'Pendiente',
                 'Solicitud de cita para negociación de compra',
                 GETDATE())";

                    using (SqlCommand cmdCita = new SqlCommand(sqlCita, conn, transaction))
                    {
                        cmdCita.Parameters.AddWithValue("@cliente", IdCliente);
                        cmdCita.Parameters.AddWithValue("@vehiculo", IdVehiculo);
                        cmdCita.ExecuteNonQuery();
                    }

                    // CONFIRMAR TRANSACCIÓN
                    transaction.Commit();

                    MessageBox.Show(" Solicitud procesada exitosamente\n\n" +
                                  "• Vehículo reservado\n" +
                                  "• Cita creada (Estado: Pendiente)\n" +
                                  "• La recepcionista contactará para confirmar fecha y hora",
                                  "Solicitud Completada",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

                    return true;
                }
            }
            catch (SqlException sqlEx)
            {
                transaction?.Rollback();

                if (sqlEx.Message.Contains("CHECK constraint"))
                {
                    MessageBox.Show("Error en datos de la cita. Contacte al administrador.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Error de base de datos: {sqlEx.Message}",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}