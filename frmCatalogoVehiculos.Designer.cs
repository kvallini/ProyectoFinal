namespace ProyectoFinal
{
    partial class frmCatalogoVehiculos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogoVehiculos));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.cmbVehiculos = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblEspecificaciones = new System.Windows.Forms.Label();
            this.lblInformacionBasica = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPuertas = new System.Windows.Forms.Label();
            this.lblPasajeros = new System.Windows.Forms.Label();
            this.lblTransmision = new System.Windows.Forms.Label();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.lblKilometraje = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtKilometraje = new System.Windows.Forms.TextBox();
            this.txtCombustible = new System.Windows.Forms.TextBox();
            this.txtTransmision = new System.Windows.Forms.TextBox();
            this.txtPasajeros = new System.Windows.Forms.TextBox();
            this.txtPuertas = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.pbImg2 = new System.Windows.Forms.PictureBox();
            this.pbImg3 = new System.Windows.Forms.PictureBox();
            this.pbImg4 = new System.Windows.Forms.PictureBox();
            this.pbImg1 = new System.Windows.Forms.PictureBox();
            this.pbImagenGrande = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.grpInformacionBasica = new System.Windows.Forms.GroupBox();
            this.grpEspecificaciones = new System.Windows.Forms.GroupBox();
            this.dgvEquipamiento = new System.Windows.Forms.DataGridView();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSeleccioneVehiculo = new System.Windows.Forms.Label();
            this.grpEquipamiento = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosAdicionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMisCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDelSistemaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDelSIstemaColaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenGrande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamiento)).BeginInit();
            this.grpEquipamiento.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(98, 43);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(125, 75);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // cmbVehiculos
            // 
            this.cmbVehiculos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVehiculos.FormattingEnabled = true;
            this.cmbVehiculos.Location = new System.Drawing.Point(33, 175);
            this.cmbVehiculos.Name = "cmbVehiculos";
            this.cmbVehiculos.Size = new System.Drawing.Size(301, 24);
            this.cmbVehiculos.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightGray;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(33, 219);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightGray;
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(155, 219);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblEspecificaciones
            // 
            this.lblEspecificaciones.AutoSize = true;
            this.lblEspecificaciones.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecificaciones.Location = new System.Drawing.Point(30, 496);
            this.lblEspecificaciones.Name = "lblEspecificaciones";
            this.lblEspecificaciones.Size = new System.Drawing.Size(127, 16);
            this.lblEspecificaciones.TabIndex = 35;
            this.lblEspecificaciones.Text = "Especificaciones";
            // 
            // lblInformacionBasica
            // 
            this.lblInformacionBasica.AutoSize = true;
            this.lblInformacionBasica.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacionBasica.Location = new System.Drawing.Point(30, 292);
            this.lblInformacionBasica.Name = "lblInformacionBasica";
            this.lblInformacionBasica.Size = new System.Drawing.Size(147, 16);
            this.lblInformacionBasica.TabIndex = 34;
            this.lblInformacionBasica.Text = "Información Básica";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(30, 662);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(58, 16);
            this.lblEstado.TabIndex = 33;
            this.lblEstado.Text = "Estado:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(30, 637);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(41, 16);
            this.lblTipo.TabIndex = 32;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblPuertas
            // 
            this.lblPuertas.AutoSize = true;
            this.lblPuertas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuertas.Location = new System.Drawing.Point(30, 612);
            this.lblPuertas.Name = "lblPuertas";
            this.lblPuertas.Size = new System.Drawing.Size(117, 16);
            this.lblPuertas.TabIndex = 31;
            this.lblPuertas.Text = "Número Puertas:";
            // 
            // lblPasajeros
            // 
            this.lblPasajeros.AutoSize = true;
            this.lblPasajeros.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasajeros.Location = new System.Drawing.Point(30, 587);
            this.lblPasajeros.Name = "lblPasajeros";
            this.lblPasajeros.Size = new System.Drawing.Size(130, 16);
            this.lblPasajeros.TabIndex = 30;
            this.lblPasajeros.Text = "Número Pasajeros:";
            // 
            // lblTransmision
            // 
            this.lblTransmision.AutoSize = true;
            this.lblTransmision.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransmision.Location = new System.Drawing.Point(30, 562);
            this.lblTransmision.Name = "lblTransmision";
            this.lblTransmision.Size = new System.Drawing.Size(89, 16);
            this.lblTransmision.TabIndex = 29;
            this.lblTransmision.Text = "Transmisión:";
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustible.Location = new System.Drawing.Point(30, 537);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(146, 16);
            this.lblCombustible.TabIndex = 28;
            this.lblCombustible.Text = "Tipo de Combustible:";
            // 
            // lblKilometraje
            // 
            this.lblKilometraje.AutoSize = true;
            this.lblKilometraje.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometraje.Location = new System.Drawing.Point(30, 452);
            this.lblKilometraje.Name = "lblKilometraje";
            this.lblKilometraje.Size = new System.Drawing.Size(85, 16);
            this.lblKilometraje.TabIndex = 27;
            this.lblKilometraje.Text = "Kilometraje:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(30, 427);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 16);
            this.lblPrecio.TabIndex = 26;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(30, 402);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(46, 16);
            this.lblColor.TabIndex = 25;
            this.lblColor.Text = "Color:";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(30, 377);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(38, 16);
            this.lblAño.TabIndex = 24;
            this.lblAño.Text = "Año:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(30, 352);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(59, 16);
            this.lblModelo.TabIndex = 23;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(30, 327);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 16);
            this.lblMarca.TabIndex = 22;
            this.lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(204, 322);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 38;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(204, 372);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 39;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(204, 398);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 40;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(204, 426);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 41;
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.Location = new System.Drawing.Point(204, 452);
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(100, 20);
            this.txtKilometraje.TabIndex = 42;
            // 
            // txtCombustible
            // 
            this.txtCombustible.Location = new System.Drawing.Point(204, 536);
            this.txtCombustible.Name = "txtCombustible";
            this.txtCombustible.Size = new System.Drawing.Size(100, 20);
            this.txtCombustible.TabIndex = 43;
            // 
            // txtTransmision
            // 
            this.txtTransmision.Location = new System.Drawing.Point(204, 560);
            this.txtTransmision.Name = "txtTransmision";
            this.txtTransmision.Size = new System.Drawing.Size(100, 20);
            this.txtTransmision.TabIndex = 44;
            // 
            // txtPasajeros
            // 
            this.txtPasajeros.Location = new System.Drawing.Point(204, 586);
            this.txtPasajeros.Name = "txtPasajeros";
            this.txtPasajeros.Size = new System.Drawing.Size(100, 20);
            this.txtPasajeros.TabIndex = 45;
            // 
            // txtPuertas
            // 
            this.txtPuertas.Location = new System.Drawing.Point(204, 611);
            this.txtPuertas.Name = "txtPuertas";
            this.txtPuertas.Size = new System.Drawing.Size(100, 20);
            this.txtPuertas.TabIndex = 46;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(204, 633);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 47;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(204, 348);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 48;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(204, 658);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 49;
            // 
            // pbImg2
            // 
            this.pbImg2.BackColor = System.Drawing.Color.LightGray;
            this.pbImg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg2.Location = new System.Drawing.Point(736, 327);
            this.pbImg2.Name = "pbImg2";
            this.pbImg2.Size = new System.Drawing.Size(120, 80);
            this.pbImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg2.TabIndex = 50;
            this.pbImg2.TabStop = false;
            // 
            // pbImg3
            // 
            this.pbImg3.BackColor = System.Drawing.Color.LightGray;
            this.pbImg3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg3.Location = new System.Drawing.Point(872, 327);
            this.pbImg3.Name = "pbImg3";
            this.pbImg3.Size = new System.Drawing.Size(120, 80);
            this.pbImg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg3.TabIndex = 51;
            this.pbImg3.TabStop = false;
            // 
            // pbImg4
            // 
            this.pbImg4.BackColor = System.Drawing.Color.LightGray;
            this.pbImg4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg4.Location = new System.Drawing.Point(998, 327);
            this.pbImg4.Name = "pbImg4";
            this.pbImg4.Size = new System.Drawing.Size(120, 80);
            this.pbImg4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg4.TabIndex = 52;
            this.pbImg4.TabStop = false;
            // 
            // pbImg1
            // 
            this.pbImg1.BackColor = System.Drawing.Color.LightGray;
            this.pbImg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg1.Location = new System.Drawing.Point(610, 327);
            this.pbImg1.Name = "pbImg1";
            this.pbImg1.Size = new System.Drawing.Size(120, 80);
            this.pbImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg1.TabIndex = 53;
            this.pbImg1.TabStop = false;
            // 
            // pbImagenGrande
            // 
            this.pbImagenGrande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagenGrande.Location = new System.Drawing.Point(675, 68);
            this.pbImagenGrande.Name = "pbImagenGrande";
            this.pbImagenGrande.Size = new System.Drawing.Size(360, 240);
            this.pbImagenGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenGrande.TabIndex = 54;
            this.pbImagenGrande.TabStop = false;
            this.pbImagenGrande.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(560, 672);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(170, 48);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(822, 672);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(170, 48);
            this.btnSeleccionar.TabIndex = 56;
            this.btnSeleccionar.Text = "&Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // grpInformacionBasica
            // 
            this.grpInformacionBasica.Location = new System.Drawing.Point(27, 278);
            this.grpInformacionBasica.Name = "grpInformacionBasica";
            this.grpInformacionBasica.Size = new System.Drawing.Size(277, 215);
            this.grpInformacionBasica.TabIndex = 57;
            this.grpInformacionBasica.TabStop = false;
            // 
            // grpEspecificaciones
            // 
            this.grpEspecificaciones.Location = new System.Drawing.Point(13, 500);
            this.grpEspecificaciones.Name = "grpEspecificaciones";
            this.grpEspecificaciones.Size = new System.Drawing.Size(291, 190);
            this.grpEspecificaciones.TabIndex = 58;
            this.grpEspecificaciones.TabStop = false;
            // 
            // dgvEquipamiento
            // 
            this.dgvEquipamiento.AllowUserToAddRows = false;
            this.dgvEquipamiento.AllowUserToDeleteRows = false;
            this.dgvEquipamiento.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEquipamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTipo,
            this.colDescripcion});
            this.dgvEquipamiento.Location = new System.Drawing.Point(6, 22);
            this.dgvEquipamiento.Name = "dgvEquipamiento";
            this.dgvEquipamiento.Size = new System.Drawing.Size(1002, 173);
            this.dgvEquipamiento.TabIndex = 59;
            // 
            // colTipo
            // 
            this.colTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.colTipo.HeaderText = "Tipo de equipamiento";
            this.colTipo.Name = "colTipo";
            this.colTipo.Width = 5;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Width = 5;
            // 
            // lblSeleccioneVehiculo
            // 
            this.lblSeleccioneVehiculo.AutoSize = true;
            this.lblSeleccioneVehiculo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccioneVehiculo.Location = new System.Drawing.Point(33, 136);
            this.lblSeleccioneVehiculo.Name = "lblSeleccioneVehiculo";
            this.lblSeleccioneVehiculo.Size = new System.Drawing.Size(301, 23);
            this.lblSeleccioneVehiculo.TabIndex = 60;
            this.lblSeleccioneVehiculo.Text = "SELECCIONE UN VEHÍCULO";
            // 
            // grpEquipamiento
            // 
            this.grpEquipamiento.AutoSize = true;
            this.grpEquipamiento.Controls.Add(this.dgvEquipamiento);
            this.grpEquipamiento.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEquipamiento.Location = new System.Drawing.Point(341, 417);
            this.grpEquipamiento.Name = "grpEquipamiento";
            this.grpEquipamiento.Size = new System.Drawing.Size(1014, 212);
            this.grpEquipamiento.TabIndex = 61;
            this.grpEquipamiento.TabStop = false;
            this.grpEquipamiento.Text = "Equipamiento";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.colaboradoresToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1361, 24);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "Barra Menu";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.inicioToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoDeVehiculosToolStripMenuItem,
            this.serviciosAdicionalesToolStripMenuItem,
            this.verMisCitasToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // catalogoDeVehiculosToolStripMenuItem
            // 
            this.catalogoDeVehiculosToolStripMenuItem.Name = "catalogoDeVehiculosToolStripMenuItem";
            this.catalogoDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.catalogoDeVehiculosToolStripMenuItem.Text = "Catalogo de Vehiculos";
            // 
            // serviciosAdicionalesToolStripMenuItem
            // 
            this.serviciosAdicionalesToolStripMenuItem.Name = "serviciosAdicionalesToolStripMenuItem";
            this.serviciosAdicionalesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.serviciosAdicionalesToolStripMenuItem.Text = "Servicios Adicionales";
            // 
            // verMisCitasToolStripMenuItem
            // 
            this.verMisCitasToolStripMenuItem.Name = "verMisCitasToolStripMenuItem";
            this.verMisCitasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.verMisCitasToolStripMenuItem.Text = "Ver mis Citas";
            // 
            // colaboradoresToolStripMenuItem
            // 
            this.colaboradoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem,
            this.facturacionToolStripMenuItem,
            this.agentesToolStripMenuItem,
            this.recepcionToolStripMenuItem});
            this.colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            this.colaboradoresToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.colaboradoresToolStripMenuItem.Text = "Colaboradores";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // agentesToolStripMenuItem
            // 
            this.agentesToolStripMenuItem.Name = "agentesToolStripMenuItem";
            this.agentesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.agentesToolStripMenuItem.Text = "Agentes";
            // 
            // recepcionToolStripMenuItem
            // 
            this.recepcionToolStripMenuItem.Name = "recepcionToolStripMenuItem";
            this.recepcionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.recepcionToolStripMenuItem.Text = "Recepcion";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDelSistemaClientesToolStripMenuItem,
            this.manualDelSIstemaColaboradoresToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDelSistemaClientesToolStripMenuItem
            // 
            this.manualDelSistemaClientesToolStripMenuItem.Name = "manualDelSistemaClientesToolStripMenuItem";
            this.manualDelSistemaClientesToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.manualDelSistemaClientesToolStripMenuItem.Text = "Manual del Sistema Clientes";
            // 
            // manualDelSIstemaColaboradoresToolStripMenuItem
            // 
            this.manualDelSIstemaColaboradoresToolStripMenuItem.Name = "manualDelSIstemaColaboradoresToolStripMenuItem";
            this.manualDelSIstemaColaboradoresToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.manualDelSIstemaColaboradoresToolStripMenuItem.Text = "Manual del SIstema Colaboradores";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(1071, 672);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(170, 48);
            this.btnVolver.TabIndex = 63;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmCatalogoVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1361, 714);
            this.ControlBox = false;
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblSeleccioneVehiculo);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pbImagenGrande);
            this.Controls.Add(this.pbImg3);
            this.Controls.Add(this.pbImg4);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.pbImg1);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.pbImg2);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtPuertas);
            this.Controls.Add(this.txtPasajeros);
            this.Controls.Add(this.txtTransmision);
            this.Controls.Add(this.txtCombustible);
            this.Controls.Add(this.txtKilometraje);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblEspecificaciones);
            this.Controls.Add(this.lblInformacionBasica);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblPuertas);
            this.Controls.Add(this.lblPasajeros);
            this.Controls.Add(this.lblTransmision);
            this.Controls.Add(this.lblCombustible);
            this.Controls.Add(this.lblKilometraje);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbVehiculos);
            this.Controls.Add(this.grpInformacionBasica);
            this.Controls.Add(this.grpEspecificaciones);
            this.Controls.Add(this.grpEquipamiento);
            this.Name = "frmCatalogoVehiculos";
            this.Text = "Catalogo de Vehiculos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCatalogoVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenGrande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamiento)).EndInit();
            this.grpEquipamiento.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ComboBox cmbVehiculos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblEspecificaciones;
        private System.Windows.Forms.Label lblInformacionBasica;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPuertas;
        private System.Windows.Forms.Label lblPasajeros;
        private System.Windows.Forms.Label lblTransmision;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.Label lblKilometraje;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtKilometraje;
        private System.Windows.Forms.TextBox txtCombustible;
        private System.Windows.Forms.TextBox txtTransmision;
        private System.Windows.Forms.TextBox txtPasajeros;
        private System.Windows.Forms.TextBox txtPuertas;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.PictureBox pbImg2;
        private System.Windows.Forms.PictureBox pbImg3;
        private System.Windows.Forms.PictureBox pbImg4;
        private System.Windows.Forms.PictureBox pbImg1;
        private System.Windows.Forms.PictureBox pbImagenGrande;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.GroupBox grpInformacionBasica;
        private System.Windows.Forms.GroupBox grpEspecificaciones;
        private System.Windows.Forms.DataGridView dgvEquipamiento;
        private System.Windows.Forms.Label lblSeleccioneVehiculo;
        private System.Windows.Forms.GroupBox grpEquipamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosAdicionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMisCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDelSistemaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDelSIstemaColaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button btnVolver;
    }
}