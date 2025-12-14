using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinal
{
    public partial class frmCatalogoVehiculos : Form
    {
        public frmCatalogoVehiculos()
        {
            InitializeComponent();
            cmbVehiculos.DisplayMember = "Text";
            cmbVehiculos.ValueMember = "Value";

            pbImg1.Click += PictureBox_Click;
            pbImg2.Click += PictureBox_Click;
            pbImg3.Click += PictureBox_Click;
            pbImg4.Click += PictureBox_Click;

            // Configurar PictureBox grande
            ConfigurarPictureBoxGrande();
        }
        private void ConfigurarPictureBoxGrande()
        {
            if (pbImagenGrande == null)
            {
                pbImagenGrande = new PictureBox();
                pbImagenGrande.Name = "pbImagenGrande";
                pbImagenGrande.Location = new Point(570, 55);
                pbImagenGrande.Size = new Size(250, 180);
                pbImagenGrande.Visible = false;
                pbImagenGrande.BorderStyle = BorderStyle.FixedSingle;
                pbImagenGrande.SizeMode = PictureBoxSizeMode.Zoom;
                this.Controls.Add(pbImagenGrande);
            }
        }

        private void grpBusqueda_Enter(object sender, EventArgs e)
        {

        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCatalogoVehiculos_Load(object sender, EventArgs e)
        {
            CargarVehiculosEnComboBox();
        }

        private void CargarVehiculosEnComboBox()
        {
            try
            {
                string connectionString =  @"Data Source=CAVALLINI\CURSOSQL2022;Initial Catalog=SISTEMA_VENTA_AUTOS_USADOS;
                                           User ID=sa;Password=12345678";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT ID_Vehiculo, Marca + ' ' + Modelo + ' (' + CAST(Año AS VARCHAR(4)) + ')' AS NombreCompleto                      
                FROM VEHICULOS 
                WHERE Estado_Vehiculo = 'Disponible'
                ORDER BY Marca, Modelo, Año DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbVehiculos.Items.Clear();
                    cmbVehiculos.Items.Add(new { Text = "      Clic Aquí     ", Value = 0 });

                    while (reader.Read())
                    {
                        cmbVehiculos.Items.Add(new
                        {
                            Text = reader["NombreCompleto"].ToString(),
                            Value = (int)reader["ID_Vehiculo"]
                        });
                    }

                    if (cmbVehiculos.Items.Count > 0)
                        cmbVehiculos.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vehículos: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbVehiculos.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor seleccione un vehículo", "Advertencia",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID del vehículo seleccionado
            dynamic selectedItem = cmbVehiculos.SelectedItem;
            int idVehiculo = selectedItem.Value;

            if (idVehiculo > 0)
            {
                CargarDatosVehiculo(idVehiculo);
            }
        }
        private void LimpiarControles()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtAño.Clear();
            txtColor.Clear();
            txtPrecio.Clear();
            txtKilometraje.Clear();
            txtCombustible.Clear();
            txtTransmision.Clear();
            txtPasajeros.Clear();
            txtPuertas.Clear();
            txtTipo.Clear();
            txtEstado.Clear();

            dgvEquipamiento.Rows.Clear();
            LimpiarImagenes();
        }
        private void CargarDatosVehiculo(int idVehiculo)
        {
            try
            {
                string connectionString = @"Data Source=CAVALLINI\CURSOSQL2022;Initial Catalog=SISTEMA_VENTA_AUTOS_USADOS;User ID=sa;Password=12345678";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT 
                    Marca, Modelo, Año, Color, 
                    Precio, Kilometraje, 
                    Tipo_Combustible, Transmision, 
                    Numero_Pasajeros, Numero_Puertas, 
                    Tipo_Vehiculo, Estado_Vehiculo,
                    Equipamiento_Basico, Equipamiento_Confort, Equipamiento_Seguridad, Descripcion,
                    
                    Imagen_Principal, Imagen_Secundaria1, 
                    Imagen_Secundaria2, Imagen_Secundaria3

                FROM VEHICULOS 
                WHERE ID_Vehiculo = @idVehiculo";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idVehiculo", idVehiculo);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Cargar datos en los TextBox
                        txtMarca.Text = reader["Marca"].ToString();
                        txtModelo.Text = reader["Modelo"].ToString();
                        txtAño.Text = reader["Año"].ToString();
                        txtColor.Text = reader["Color"].ToString();
                        txtPrecio.Text = string.Format("${0:N2}", reader["Precio"]);
                        txtKilometraje.Text = string.Format("{0:N0} km", reader["Kilometraje"]);
                        txtCombustible.Text = reader["Tipo_Combustible"].ToString();
                        txtTransmision.Text = reader["Transmision"].ToString();
                        txtPasajeros.Text = reader["Numero_Pasajeros"].ToString();
                        txtPuertas.Text = reader["Numero_Puertas"].ToString();
                        txtTipo.Text = reader["Tipo_Vehiculo"].ToString();
                        txtEstado.Text = reader["Estado_Vehiculo"].ToString();



                        CargarEquipamientoEnDataGrid(reader);
                        CargarImagenes(reader);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el vehículo seleccionado",
                                      "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del vehículo: " + ex.Message,
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (cmbVehiculos.Items.Count > 0)
                cmbVehiculos.SelectedIndex = 0;

            LimpiarControles();
        }
        private void CargarEquipamientoEnDataGrid(SqlDataReader reader)
        {
            // Limpiar el DataGridView
            dgvEquipamiento.Rows.Clear(); 

            //  Equipamiento Básico
            string basico = reader["Equipamiento_Basico"].ToString();
            if (!string.IsNullOrEmpty(basico) && basico.Trim().Length > 0)
            {
                dgvEquipamiento.Rows.Add("Equipamiento Básico", basico);
            }

            // Equipamiento Confort
            string confort = reader["Equipamiento_Confort"].ToString();
            if (!string.IsNullOrEmpty(confort) && confort.Trim().Length > 0)
            {
                dgvEquipamiento.Rows.Add("Equipamiento Confort", confort);
            }

            //  Equipamiento Seguridad
            string seguridad = reader["Equipamiento_Seguridad"].ToString();
            if (!string.IsNullOrEmpty(seguridad) && seguridad.Trim().Length > 0)
            {
                dgvEquipamiento.Rows.Add("Equipamiento Seguridad", seguridad);
            }

            //  Descripción General
            string descripcion = reader["Descripcion"].ToString();
            if (!string.IsNullOrEmpty(descripcion) && descripcion.Trim().Length > 0)
            {
                dgvEquipamiento.Rows.Add("Descripción General", descripcion);
            }
        }
        private void CargarImagenes(SqlDataReader reader)
        {
            try
            {
                CargarUnaImagen(pbImg1, reader["Imagen_Principal"].ToString());
                CargarUnaImagen(pbImg2, reader["Imagen_Secundaria1"].ToString());
                CargarUnaImagen(pbImg3, reader["Imagen_Secundaria2"].ToString());
                CargarUnaImagen(pbImg4, reader["Imagen_Secundaria3"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar imágenes: " + ex.Message,
                               "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CargarUnaImagen(PictureBox pictureBox, string nombreArchivo)
        {
            try
            {
                // Verificar si hay nombre de archivo
                if (string.IsNullOrWhiteSpace(nombreArchivo))
                {
                    CrearPlaceholder(pictureBox);
                    return;
                }

                string rutaBase = @"C:\C#2025\IIICUATRI\PROYECTO\FOTOSVEH\";
                string rutaCompleta = Path.Combine(rutaBase, nombreArchivo);

                if (!File.Exists(rutaCompleta))
                {
                    string[] extensiones = { "", ".jpg", ".jpeg", ".png", ".bmp", ".gif" };

                    foreach (string ext in extensiones)
                    {
                        string rutaConExtension = rutaCompleta + ext;
                        if (File.Exists(rutaConExtension))
                        {
                            rutaCompleta = rutaConExtension;
                            break;
                        }
                    }
                }

                // Cargar imagen si existe
                if (File.Exists(rutaCompleta))
                {
                    // Liberar imagen anterior
                    if (pictureBox.Image != null)
                    {
                        pictureBox.Image.Dispose();
                    }

                    pictureBox.Image = Image.FromFile(rutaCompleta);
                    pictureBox.BackColor = SystemColors.Window;
                }
                else
                {
                    // Si no existe, mostrar el placeholder
                    CrearPlaceholder(pictureBox);

                    MessageBox.Show($"No se encontró: {rutaCompleta}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Si hay error, mostrar el placeholder
                CrearPlaceholder(pictureBox);

                MessageBox.Show($"Error cargando {nombreArchivo}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CrearPlaceholder(PictureBox pictureBox)
        {
            Bitmap placeholder = new Bitmap(pictureBox.Width, pictureBox.Height);

            using (Graphics g = Graphics.FromImage(placeholder))
            {
                g.Clear(Color.LightGray);
                g.DrawRectangle(Pens.DarkGray, 0, 0, placeholder.Width - 1, placeholder.Height - 1);

                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                g.DrawString("Sin imagen",
                            new Font("Arial", 8, FontStyle.Bold),
                            Brushes.DarkGray,
                            new RectangleF(0, 0, placeholder.Width, placeholder.Height),
                            format);
            }

            pictureBox.Image = placeholder;
            pictureBox.BackColor = Color.LightGray;
        }
        private void LimpiarImagenes()
        {
            // Liberar imágenes actuales
            if (pbImg1.Image != null)
            {
                pbImg1.Image.Dispose();
                pbImg1.Image = null;
            }
            if (pbImg2.Image != null)
            {
                pbImg2.Image.Dispose();
                pbImg2.Image = null;
            }
            if (pbImg3.Image != null)
            {
                pbImg3.Image.Dispose();
                pbImg3.Image = null;
            }
            if (pbImg4.Image != null)
            {
                pbImg4.Image.Dispose();
                pbImg4.Image = null;
            }

            // Crear placeholders
            CrearPlaceholder(pbImg1);
            CrearPlaceholder(pbImg2);
            CrearPlaceholder(pbImg3);
            CrearPlaceholder(pbImg4);
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pbSeleccionada = sender as PictureBox;

            if (pbSeleccionada != null && pbSeleccionada.Image != null)
            {
                // Mostrar PictureBox grande
                pbImagenGrande.Visible = true;
                pbImagenGrande.Image = pbSeleccionada.Image;

                // Resaltar la imagen seleccionada
                ResaltarPictureBox(pbSeleccionada);
            }
        }
        private void ResaltarPictureBox(PictureBox pbSeleccionada)
        {
            
            pbImg1.BorderStyle = BorderStyle.FixedSingle;
            pbImg2.BorderStyle = BorderStyle.FixedSingle;
            pbImg3.BorderStyle = BorderStyle.FixedSingle;
            pbImg4.BorderStyle = BorderStyle.FixedSingle;

            
            pbSeleccionada.BorderStyle = BorderStyle.Fixed3D;
            pbSeleccionada.BackColor = Color.LightYellow;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar selección
                if (cmbVehiculos.SelectedIndex <= 0)
                {
                    MessageBox.Show("Seleccione un vehículo");
                    return;
                }

                // 2. Validar sesión de cliente
                if (Sesion.ID_Cliente == 0)
                {
                    MessageBox.Show("Debe iniciar sesión como cliente primero.",
                                   "Sesión requerida",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                    return;
                }

                // 3. Obtener ID del vehículo seleccionado
                dynamic selectedItem = cmbVehiculos.SelectedItem;
                int idVehiculo = selectedItem.Value; // ← ESTE ES EL ID IMPORTANTE

                // DEBUG: Verificar
                MessageBox.Show($"DEBUG: ID_Vehiculo seleccionado = {idVehiculo}\n" +
                               $"Debe ser 2, 3 o 4 según tu BD",
                               "Verificación",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                // 4. Obtener precio (solo números)
                string textoPrecio = txtPrecio.Text;
                textoPrecio = textoPrecio.Replace("$", "").Replace(",", "");
                decimal precio = decimal.Parse(textoPrecio);

                // 5. Crear y pasar datos COMPLETOS
                frmServicios formServicios = new frmServicios();
                formServicios.Marca = txtMarca.Text;
                formServicios.Modelo = txtModelo.Text;
                formServicios.PrecioVehiculo = precio;
                formServicios.IdVehiculo = idVehiculo; // ← ESTE FALTABA
                formServicios.IdCliente = Sesion.ID_Cliente; // ← ESTE FALTABA

                // 6. Mostrar
                formServicios.Show();
                this.Hide(); // Ocultar catálogo
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void verMisCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
