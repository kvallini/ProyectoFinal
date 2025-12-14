using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoFinal
{
    public partial class frmFinanciamiento : Form
    {
        public frmFinanciamiento()
        {
            InitializeComponent();
            SetupForm();
            LoadData();
        }

        private void SetupForm()
        {
            this.Text = "Financiamiento";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = SystemColors.Control;

            // Título
            Label lblTitulo = new Label();
            lblTitulo.Text = "FINANCIAMIENTO Y SEGURO";
            lblTitulo.Font = new Font("Arial", 14, FontStyle.Bold);
            lblTitulo.Location = new Point(120, 20);
            lblTitulo.AutoSize = true;
            this.Controls.Add(lblTitulo);

            // Info vehículo
            Label lblVeh = new Label();
            lblVeh.Text = "Vehículo:";
            lblVeh.Location = new Point(50, 60);
            lblVeh.AutoSize = true;
            this.Controls.Add(lblVeh);

            lblVehiculo = new Label();
            lblVehiculo.Location = new Point(120, 60);
            lblVehiculo.Size = new Size(300, 20);
            this.Controls.Add(lblVehiculo);

            Label lblPrec = new Label();
            lblPrec.Text = "Precio:";
            lblPrec.Location = new Point(50, 85);
            lblPrec.AutoSize = true;
            this.Controls.Add(lblPrec);

            lblPrecio = new Label();
            lblPrecio.Location = new Point(120, 85);
            lblPrecio.Size = new Size(300, 20);
            this.Controls.Add(lblPrecio);

            // Bancos (GroupBox)
            GroupBox gb = new GroupBox();
            gb.Text = "SELECCIONE UN BANCO";
            gb.Location = new Point(50, 120);
            gb.Size = new Size(400, 120);
            this.Controls.Add(gb);
            gbBancos = gb;

            // Seguro
            chkSeguro = new CheckBox();
            chkSeguro.Text = "Incluir seguro CreditAuto INS (+$28.00/mes)";
            chkSeguro.Location = new Point(50, 250);
            chkSeguro.AutoSize = true;
            chkSeguro.CheckedChanged += (s, e) => Calcular();
            this.Controls.Add(chkSeguro);

            // Total
            Label lblTotal = new Label();
            lblTotal.Text = "Cuota mensual:";
            lblTotal.Font = new Font("Arial", 10, FontStyle.Bold);
            lblTotal.Location = new Point(50, 280);
            lblTotal.AutoSize = true;
            this.Controls.Add(lblTotal);

            lblTotalCuota = new Label();
            lblTotalCuota.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTotalCuota.ForeColor = Color.Blue;
            lblTotalCuota.Location = new Point(170, 280);
            lblTotalCuota.Size = new Size(150, 20);
            this.Controls.Add(lblTotalCuota);

            // Botones
            btnAceptar = new Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Location = new Point(100, 320);
            btnAceptar.Size = new Size(100, 30);
            btnAceptar.Click += btnAceptar_Click;
            this.Controls.Add(btnAceptar);

            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(220, 320);
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.Click += btnCancelar_Click;
            this.Controls.Add(btnCancelar);

            btnVolver = new Button();
            btnVolver.Text = "Volver";
            btnVolver.Location = new Point(340, 320);
            btnVolver.Size = new Size(100, 30);
            btnVolver.Click += (s, e) => { this.Close(); };
            this.Controls.Add(btnVolver);
        }

        // Controles
        private Label lblVehiculo;
        private Label lblPrecio;
        private GroupBox gbBancos;
        private CheckBox chkSeguro;
        private Label lblTotalCuota;
        private Button btnAceptar;
        private Button btnCancelar;

        private void LoadData()
        {
            // Mostrar datos del vehículo
            lblVehiculo.Text = $"{DatosCompra.Marca} {DatosCompra.Modelo} {DatosCompra.Año}";
            lblPrecio.Text = $"${DatosCompra.Precio:N2}";

            // Cargar bancos desde BD
            CargarBancos();
            Calcular();
        }

        private void CargarBancos()
        {
            try
            {
                string connStr = @"Data Source=CAVALLINI\CURSOSQL2022;Initial Catalog=SISTEMA_VENTA_AUTOS_USADOS;User ID=sa;Password=12345678";

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    // CONSULTA EXACTA a tu tabla SERVICIOS_ADICIONALES
                    string query = @"
                        SELECT ID_Servicio, Nombre_Servicio, Costo 
                        FROM SERVICIOS_ADICIONALES 
                        WHERE Estado = 1 
                        AND Tipo_Servicio = 'Financiamiento'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    int y = 20;

                    while (reader.Read())
                    {
                        RadioButton rb = new RadioButton();
                        int id = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        decimal costo = reader.GetDecimal(2);

                        rb.Text = $"{nombre} - ${costo:N2}/mes";
                        rb.Tag = new { Id = id, Nombre = nombre, Costo = costo };
                        rb.Location = new Point(20, y);
                        rb.Size = new Size(350, 25);
                        rb.Font = new Font("Arial", 9);
                        rb.CheckedChanged += (s, e) =>
                        {
                            if (rb.Checked)
                            {
                                dynamic datos = rb.Tag;
                                DatosCompra.BancoId = datos.Id;
                                DatosCompra.BancoNombre = datos.Nombre;
                                DatosCompra.CuotaBanco = datos.Costo;
                                Calcular();
                            }
                        };

                        gbBancos.Controls.Add(rb);
                        y += 30;
                    }

                    // Seleccionar primer banco
                    if (gbBancos.Controls.Count > 0)
                    {
                        ((RadioButton)gbBancos.Controls[0]).Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando bancos: " + ex.Message);
            }
        }

        private void Calcular()
        {
            DatosCompra.Seguro = chkSeguro.Checked;
            lblTotalCuota.Text = $"${DatosCompra.CuotaTotal:N2}/mes";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Compra confirmada!\n" +
                          $"Banco: {DatosCompra.BancoNombre}\n" +
                          $"Seguro: {(DatosCompra.Seguro ? "Sí" : "No")}\n" +
                          $"Cuota mensual: ${DatosCompra.CuotaTotal:N2}");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DatosCompra.Limpiar();
            this.Close();
        }

        private void InitializeComponent()
        {
            // Necesario para Windows Forms
        }
    }
}