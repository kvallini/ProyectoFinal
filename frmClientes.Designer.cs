namespace ProyectoFinal
{
    partial class frmClientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.picLogo = new System.Windows.Forms.PictureBox();
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
            this.picAutosBanner = new System.Windows.Forms.PictureBox();
            this.grpOpcionesCliente = new System.Windows.Forms.GroupBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnMisCitas = new System.Windows.Forms.Button();
            this.btnServiciosAdicionales = new System.Windows.Forms.Button();
            this.btnCatalogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAutosBanner)).BeginInit();
            this.grpOpcionesCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(76, 19);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(125, 75);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "Barra Menu";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            this.catalogoDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.catalogoDeVehiculosToolStripMenuItem_Click);
            // 
            // serviciosAdicionalesToolStripMenuItem
            // 
            this.serviciosAdicionalesToolStripMenuItem.Name = "serviciosAdicionalesToolStripMenuItem";
            this.serviciosAdicionalesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.serviciosAdicionalesToolStripMenuItem.Text = "Servicios Adicionales";
            this.serviciosAdicionalesToolStripMenuItem.Click += new System.EventHandler(this.serviciosAdicionalesToolStripMenuItem_Click);
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
            // picAutosBanner
            // 
            this.picAutosBanner.Image = ((System.Drawing.Image)(resources.GetObject("picAutosBanner.Image")));
            this.picAutosBanner.Location = new System.Drawing.Point(12, 45);
            this.picAutosBanner.Name = "picAutosBanner";
            this.picAutosBanner.Size = new System.Drawing.Size(483, 413);
            this.picAutosBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAutosBanner.TabIndex = 4;
            this.picAutosBanner.TabStop = false;
            // 
            // grpOpcionesCliente
            // 
            this.grpOpcionesCliente.Controls.Add(this.btnCerrarSesion);
            this.grpOpcionesCliente.Controls.Add(this.btnMisCitas);
            this.grpOpcionesCliente.Controls.Add(this.btnServiciosAdicionales);
            this.grpOpcionesCliente.Controls.Add(this.btnCatalogo);
            this.grpOpcionesCliente.Controls.Add(this.picLogo);
            this.grpOpcionesCliente.Location = new System.Drawing.Point(531, 45);
            this.grpOpcionesCliente.Name = "grpOpcionesCliente";
            this.grpOpcionesCliente.Size = new System.Drawing.Size(277, 413);
            this.grpOpcionesCliente.TabIndex = 5;
            this.grpOpcionesCliente.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(76, 343);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(120, 53);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnMisCitas
            // 
            this.btnMisCitas.BackColor = System.Drawing.SystemColors.Control;
            this.btnMisCitas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMisCitas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisCitas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMisCitas.Location = new System.Drawing.Point(11, 269);
            this.btnMisCitas.Name = "btnMisCitas";
            this.btnMisCitas.Size = new System.Drawing.Size(257, 53);
            this.btnMisCitas.TabIndex = 2;
            this.btnMisCitas.Text = "Mis Citas";
            this.btnMisCitas.UseVisualStyleBackColor = false;
            this.btnMisCitas.Click += new System.EventHandler(this.btnMisCitas_Click);
            // 
            // btnServiciosAdicionales
            // 
            this.btnServiciosAdicionales.BackColor = System.Drawing.SystemColors.Control;
            this.btnServiciosAdicionales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServiciosAdicionales.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiciosAdicionales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnServiciosAdicionales.Location = new System.Drawing.Point(11, 192);
            this.btnServiciosAdicionales.Name = "btnServiciosAdicionales";
            this.btnServiciosAdicionales.Size = new System.Drawing.Size(257, 53);
            this.btnServiciosAdicionales.TabIndex = 1;
            this.btnServiciosAdicionales.Text = "Servicios Adicionales";
            this.btnServiciosAdicionales.UseVisualStyleBackColor = false;
            this.btnServiciosAdicionales.Click += new System.EventHandler(this.btnServiciosAdicionales_Click);
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.BackColor = System.Drawing.SystemColors.Control;
            this.btnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCatalogo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCatalogo.Location = new System.Drawing.Point(11, 113);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(257, 53);
            this.btnCatalogo.TabIndex = 0;
            this.btnCatalogo.Text = "Catálogo de Vehículos";
            this.btnCatalogo.UseVisualStyleBackColor = false;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click_1);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(858, 483);
            this.ControlBox = false;
            this.Controls.Add(this.grpOpcionesCliente);
            this.Controls.Add(this.picAutosBanner);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmClientes";
            this.Text = "Menu Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAutosBanner)).EndInit();
            this.grpOpcionesCliente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDelSistemaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDelSIstemaColaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosAdicionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMisCitasToolStripMenuItem;
        private System.Windows.Forms.PictureBox picAutosBanner;
        private System.Windows.Forms.GroupBox grpOpcionesCliente;
        private System.Windows.Forms.Button btnMisCitas;
        private System.Windows.Forms.Button btnServiciosAdicionales;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}

