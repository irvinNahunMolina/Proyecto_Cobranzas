
namespace COBRANZAS
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tabMenuPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.tabSelectorClientes = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabOpcionClientes = new MaterialSkin.Controls.MaterialTabControl();
            this.tabRegistros = new System.Windows.Forms.TabPage();
            this.tabClientesConsultas = new System.Windows.Forms.TabPage();
            this.listaImagenes = new System.Windows.Forms.ImageList(this.components);
            this.tabServicios = new System.Windows.Forms.TabPage();
            this.tabSelectorServicios = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabOpcionServicios = new MaterialSkin.Controls.MaterialTabControl();
            this.tabServicioRegistro = new System.Windows.Forms.TabPage();
            this.tabServicioConsulta = new System.Windows.Forms.TabPage();
            this.tabServicioPrecios = new System.Windows.Forms.TabPage();
            this.tabMorosidad = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabOpcionMorosidad = new MaterialSkin.Controls.MaterialTabControl();
            this.tabMorosidadListaPagos = new System.Windows.Forms.TabPage();
            this.tabMorosidadPlanesPago = new System.Windows.Forms.TabPage();
            this.tabMorosidadNotificaciones = new System.Windows.Forms.TabPage();
            this.tabCobros = new System.Windows.Forms.TabPage();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabOpcionCobros = new MaterialSkin.Controls.MaterialTabControl();
            this.tabFacturar = new System.Windows.Forms.TabPage();
            this.tabConsultarMorosidad = new System.Windows.Forms.TabPage();
            this.tabConsultarCobros = new System.Windows.Forms.TabPage();
            this.tabConfiguraciones = new System.Windows.Forms.TabPage();
            this.materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabOpcionConfiguraciones = new MaterialSkin.Controls.MaterialTabControl();
            this.tabConfiguracionUsuarios = new System.Windows.Forms.TabPage();
            this.tabConfiguracionAccesos = new System.Windows.Forms.TabPage();
            this.tabConfiguracionModulos = new System.Windows.Forms.TabPage();
            this.tabConfiguracionParametros = new System.Windows.Forms.TabPage();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMorosidad = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeMoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCobros = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasMorosidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCobrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfiguraciones = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabReportes = new System.Windows.Forms.TabPage();
            this.tabSelectorReportes = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabOpcionReportes = new MaterialSkin.Controls.MaterialTabControl();
            this.tabReporteClientes = new System.Windows.Forms.TabPage();
            this.reporteClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMenuPrincipal.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabOpcionClientes.SuspendLayout();
            this.tabServicios.SuspendLayout();
            this.tabOpcionServicios.SuspendLayout();
            this.tabMorosidad.SuspendLayout();
            this.tabOpcionMorosidad.SuspendLayout();
            this.tabCobros.SuspendLayout();
            this.tabOpcionCobros.SuspendLayout();
            this.tabConfiguraciones.SuspendLayout();
            this.tabOpcionConfiguraciones.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.tabReportes.SuspendLayout();
            this.tabOpcionReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenuPrincipal
            // 
            this.tabMenuPrincipal.Controls.Add(this.tabClientes);
            this.tabMenuPrincipal.Controls.Add(this.tabServicios);
            this.tabMenuPrincipal.Controls.Add(this.tabMorosidad);
            this.tabMenuPrincipal.Controls.Add(this.tabCobros);
            this.tabMenuPrincipal.Controls.Add(this.tabConfiguraciones);
            this.tabMenuPrincipal.Controls.Add(this.tabReportes);
            this.tabMenuPrincipal.Depth = 0;
            this.tabMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenuPrincipal.ImageList = this.listaImagenes;
            this.tabMenuPrincipal.Location = new System.Drawing.Point(2, 76);
            this.tabMenuPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.tabMenuPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabMenuPrincipal.Multiline = true;
            this.tabMenuPrincipal.Name = "tabMenuPrincipal";
            this.tabMenuPrincipal.SelectedIndex = 0;
            this.tabMenuPrincipal.Size = new System.Drawing.Size(944, 496);
            this.tabMenuPrincipal.TabIndex = 0;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.tabSelectorClientes);
            this.tabClientes.Controls.Add(this.tabOpcionClientes);
            this.tabClientes.ImageKey = "admin_user.png";
            this.tabClientes.Location = new System.Drawing.Point(4, 23);
            this.tabClientes.Margin = new System.Windows.Forms.Padding(2);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(2);
            this.tabClientes.Size = new System.Drawing.Size(936, 469);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // tabSelectorClientes
            // 
            this.tabSelectorClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelectorClientes.BaseTabControl = this.tabOpcionClientes;
            this.tabSelectorClientes.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelectorClientes.Depth = 0;
            this.tabSelectorClientes.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorClientes.Location = new System.Drawing.Point(0, 0);
            this.tabSelectorClientes.Margin = new System.Windows.Forms.Padding(2);
            this.tabSelectorClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorClientes.Name = "tabSelectorClientes";
            this.tabSelectorClientes.Size = new System.Drawing.Size(938, 39);
            this.tabSelectorClientes.TabIndex = 1;
            this.tabSelectorClientes.Text = "materialTabSelector1";
            // 
            // tabOpcionClientes
            // 
            this.tabOpcionClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpcionClientes.Controls.Add(this.tabRegistros);
            this.tabOpcionClientes.Controls.Add(this.tabClientesConsultas);
            this.tabOpcionClientes.Depth = 0;
            this.tabOpcionClientes.ImageList = this.listaImagenes;
            this.tabOpcionClientes.Location = new System.Drawing.Point(0, 44);
            this.tabOpcionClientes.Margin = new System.Windows.Forms.Padding(2);
            this.tabOpcionClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionClientes.Multiline = true;
            this.tabOpcionClientes.Name = "tabOpcionClientes";
            this.tabOpcionClientes.SelectedIndex = 0;
            this.tabOpcionClientes.Size = new System.Drawing.Size(940, 432);
            this.tabOpcionClientes.TabIndex = 0;
            // 
            // tabRegistros
            // 
            this.tabRegistros.ImageKey = "registrar.png";
            this.tabRegistros.Location = new System.Drawing.Point(4, 23);
            this.tabRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.tabRegistros.Name = "tabRegistros";
            this.tabRegistros.Padding = new System.Windows.Forms.Padding(2);
            this.tabRegistros.Size = new System.Drawing.Size(932, 405);
            this.tabRegistros.TabIndex = 0;
            this.tabRegistros.Text = "Registro";
            this.tabRegistros.UseVisualStyleBackColor = true;
            // 
            // tabClientesConsultas
            // 
            this.tabClientesConsultas.ImageKey = "consultar.png";
            this.tabClientesConsultas.Location = new System.Drawing.Point(4, 23);
            this.tabClientesConsultas.Margin = new System.Windows.Forms.Padding(2);
            this.tabClientesConsultas.Name = "tabClientesConsultas";
            this.tabClientesConsultas.Padding = new System.Windows.Forms.Padding(2);
            this.tabClientesConsultas.Size = new System.Drawing.Size(932, 398);
            this.tabClientesConsultas.TabIndex = 1;
            this.tabClientesConsultas.Text = "Consultas";
            this.tabClientesConsultas.UseVisualStyleBackColor = true;
            // 
            // listaImagenes
            // 
            this.listaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaImagenes.ImageStream")));
            this.listaImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.listaImagenes.Images.SetKeyName(0, "admin_user.png");
            this.listaImagenes.Images.SetKeyName(1, "Cobros.png");
            this.listaImagenes.Images.SetKeyName(2, "Configuraciones.png");
            this.listaImagenes.Images.SetKeyName(3, "morosidad.png");
            this.listaImagenes.Images.SetKeyName(4, "Servicios.png");
            this.listaImagenes.Images.SetKeyName(5, "registrar.png");
            this.listaImagenes.Images.SetKeyName(6, "consultar.png");
            this.listaImagenes.Images.SetKeyName(7, "Reporte.png");
            this.listaImagenes.Images.SetKeyName(8, "Reporte_2.png");
            // 
            // tabServicios
            // 
            this.tabServicios.Controls.Add(this.tabSelectorServicios);
            this.tabServicios.Controls.Add(this.tabOpcionServicios);
            this.tabServicios.ImageKey = "Servicios.png";
            this.tabServicios.Location = new System.Drawing.Point(4, 23);
            this.tabServicios.Margin = new System.Windows.Forms.Padding(2);
            this.tabServicios.Name = "tabServicios";
            this.tabServicios.Padding = new System.Windows.Forms.Padding(2);
            this.tabServicios.Size = new System.Drawing.Size(936, 469);
            this.tabServicios.TabIndex = 1;
            this.tabServicios.Text = "Servicios";
            this.tabServicios.UseVisualStyleBackColor = true;
            // 
            // tabSelectorServicios
            // 
            this.tabSelectorServicios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelectorServicios.BaseTabControl = this.tabOpcionServicios;
            this.tabSelectorServicios.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelectorServicios.Depth = 0;
            this.tabSelectorServicios.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorServicios.Location = new System.Drawing.Point(-2, -2);
            this.tabSelectorServicios.Margin = new System.Windows.Forms.Padding(2);
            this.tabSelectorServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorServicios.Name = "tabSelectorServicios";
            this.tabSelectorServicios.Size = new System.Drawing.Size(938, 39);
            this.tabSelectorServicios.TabIndex = 3;
            this.tabSelectorServicios.Text = "materialTabSelector1";
            // 
            // tabOpcionServicios
            // 
            this.tabOpcionServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpcionServicios.Controls.Add(this.tabServicioRegistro);
            this.tabOpcionServicios.Controls.Add(this.tabServicioConsulta);
            this.tabOpcionServicios.Controls.Add(this.tabServicioPrecios);
            this.tabOpcionServicios.Depth = 0;
            this.tabOpcionServicios.Location = new System.Drawing.Point(-2, 42);
            this.tabOpcionServicios.Margin = new System.Windows.Forms.Padding(2);
            this.tabOpcionServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionServicios.Multiline = true;
            this.tabOpcionServicios.Name = "tabOpcionServicios";
            this.tabOpcionServicios.SelectedIndex = 0;
            this.tabOpcionServicios.Size = new System.Drawing.Size(940, 433);
            this.tabOpcionServicios.TabIndex = 2;
            // 
            // tabServicioRegistro
            // 
            this.tabServicioRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabServicioRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.tabServicioRegistro.Name = "tabServicioRegistro";
            this.tabServicioRegistro.Padding = new System.Windows.Forms.Padding(2);
            this.tabServicioRegistro.Size = new System.Drawing.Size(932, 407);
            this.tabServicioRegistro.TabIndex = 0;
            this.tabServicioRegistro.Text = "Registro";
            this.tabServicioRegistro.UseVisualStyleBackColor = true;
            // 
            // tabServicioConsulta
            // 
            this.tabServicioConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabServicioConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.tabServicioConsulta.Name = "tabServicioConsulta";
            this.tabServicioConsulta.Padding = new System.Windows.Forms.Padding(2);
            this.tabServicioConsulta.Size = new System.Drawing.Size(932, 407);
            this.tabServicioConsulta.TabIndex = 1;
            this.tabServicioConsulta.Text = "Consultas";
            this.tabServicioConsulta.UseVisualStyleBackColor = true;
            // 
            // tabServicioPrecios
            // 
            this.tabServicioPrecios.Location = new System.Drawing.Point(4, 22);
            this.tabServicioPrecios.Margin = new System.Windows.Forms.Padding(2);
            this.tabServicioPrecios.Name = "tabServicioPrecios";
            this.tabServicioPrecios.Size = new System.Drawing.Size(932, 407);
            this.tabServicioPrecios.TabIndex = 2;
            this.tabServicioPrecios.Text = "Precios";
            this.tabServicioPrecios.UseVisualStyleBackColor = true;
            // 
            // tabMorosidad
            // 
            this.tabMorosidad.Controls.Add(this.materialTabSelector1);
            this.tabMorosidad.Controls.Add(this.tabOpcionMorosidad);
            this.tabMorosidad.ImageKey = "morosidad.png";
            this.tabMorosidad.Location = new System.Drawing.Point(4, 23);
            this.tabMorosidad.Margin = new System.Windows.Forms.Padding(2);
            this.tabMorosidad.Name = "tabMorosidad";
            this.tabMorosidad.Size = new System.Drawing.Size(936, 469);
            this.tabMorosidad.TabIndex = 2;
            this.tabMorosidad.Text = "Morosidad";
            this.tabMorosidad.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.tabOpcionMorosidad;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(-2, -2);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(938, 39);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabOpcionMorosidad
            // 
            this.tabOpcionMorosidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpcionMorosidad.Controls.Add(this.tabMorosidadListaPagos);
            this.tabOpcionMorosidad.Controls.Add(this.tabMorosidadPlanesPago);
            this.tabOpcionMorosidad.Controls.Add(this.tabMorosidadNotificaciones);
            this.tabOpcionMorosidad.Depth = 0;
            this.tabOpcionMorosidad.Location = new System.Drawing.Point(-2, 42);
            this.tabOpcionMorosidad.Margin = new System.Windows.Forms.Padding(2);
            this.tabOpcionMorosidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionMorosidad.Multiline = true;
            this.tabOpcionMorosidad.Name = "tabOpcionMorosidad";
            this.tabOpcionMorosidad.SelectedIndex = 0;
            this.tabOpcionMorosidad.Size = new System.Drawing.Size(940, 433);
            this.tabOpcionMorosidad.TabIndex = 2;
            // 
            // tabMorosidadListaPagos
            // 
            this.tabMorosidadListaPagos.Location = new System.Drawing.Point(4, 22);
            this.tabMorosidadListaPagos.Margin = new System.Windows.Forms.Padding(2);
            this.tabMorosidadListaPagos.Name = "tabMorosidadListaPagos";
            this.tabMorosidadListaPagos.Padding = new System.Windows.Forms.Padding(2);
            this.tabMorosidadListaPagos.Size = new System.Drawing.Size(932, 407);
            this.tabMorosidadListaPagos.TabIndex = 0;
            this.tabMorosidadListaPagos.Text = "Lista de Mora";
            this.tabMorosidadListaPagos.UseVisualStyleBackColor = true;
            // 
            // tabMorosidadPlanesPago
            // 
            this.tabMorosidadPlanesPago.Location = new System.Drawing.Point(4, 22);
            this.tabMorosidadPlanesPago.Margin = new System.Windows.Forms.Padding(2);
            this.tabMorosidadPlanesPago.Name = "tabMorosidadPlanesPago";
            this.tabMorosidadPlanesPago.Padding = new System.Windows.Forms.Padding(2);
            this.tabMorosidadPlanesPago.Size = new System.Drawing.Size(932, 407);
            this.tabMorosidadPlanesPago.TabIndex = 1;
            this.tabMorosidadPlanesPago.Text = "Planes de pago";
            this.tabMorosidadPlanesPago.UseVisualStyleBackColor = true;
            // 
            // tabMorosidadNotificaciones
            // 
            this.tabMorosidadNotificaciones.Location = new System.Drawing.Point(4, 22);
            this.tabMorosidadNotificaciones.Margin = new System.Windows.Forms.Padding(2);
            this.tabMorosidadNotificaciones.Name = "tabMorosidadNotificaciones";
            this.tabMorosidadNotificaciones.Size = new System.Drawing.Size(932, 407);
            this.tabMorosidadNotificaciones.TabIndex = 2;
            this.tabMorosidadNotificaciones.Text = "Notificaciones";
            this.tabMorosidadNotificaciones.UseVisualStyleBackColor = true;
            // 
            // tabCobros
            // 
            this.tabCobros.Controls.Add(this.materialTabSelector2);
            this.tabCobros.Controls.Add(this.tabOpcionCobros);
            this.tabCobros.ImageKey = "Cobros.png";
            this.tabCobros.Location = new System.Drawing.Point(4, 23);
            this.tabCobros.Margin = new System.Windows.Forms.Padding(2);
            this.tabCobros.Name = "tabCobros";
            this.tabCobros.Size = new System.Drawing.Size(936, 469);
            this.tabCobros.TabIndex = 3;
            this.tabCobros.Text = "Cobros";
            this.tabCobros.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector2.BaseTabControl = this.tabOpcionCobros;
            this.materialTabSelector2.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector2.Location = new System.Drawing.Point(-2, -2);
            this.materialTabSelector2.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(938, 39);
            this.materialTabSelector2.TabIndex = 3;
            this.materialTabSelector2.Text = "materialTabSelector1";
            // 
            // tabOpcionCobros
            // 
            this.tabOpcionCobros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpcionCobros.Controls.Add(this.tabFacturar);
            this.tabOpcionCobros.Controls.Add(this.tabConsultarMorosidad);
            this.tabOpcionCobros.Controls.Add(this.tabConsultarCobros);
            this.tabOpcionCobros.Depth = 0;
            this.tabOpcionCobros.Location = new System.Drawing.Point(-2, 42);
            this.tabOpcionCobros.Margin = new System.Windows.Forms.Padding(2);
            this.tabOpcionCobros.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionCobros.Multiline = true;
            this.tabOpcionCobros.Name = "tabOpcionCobros";
            this.tabOpcionCobros.SelectedIndex = 0;
            this.tabOpcionCobros.Size = new System.Drawing.Size(940, 433);
            this.tabOpcionCobros.TabIndex = 2;
            // 
            // tabFacturar
            // 
            this.tabFacturar.Location = new System.Drawing.Point(4, 22);
            this.tabFacturar.Margin = new System.Windows.Forms.Padding(2);
            this.tabFacturar.Name = "tabFacturar";
            this.tabFacturar.Padding = new System.Windows.Forms.Padding(2);
            this.tabFacturar.Size = new System.Drawing.Size(932, 407);
            this.tabFacturar.TabIndex = 0;
            this.tabFacturar.Text = "Facturar";
            this.tabFacturar.UseVisualStyleBackColor = true;
            // 
            // tabConsultarMorosidad
            // 
            this.tabConsultarMorosidad.Location = new System.Drawing.Point(4, 22);
            this.tabConsultarMorosidad.Margin = new System.Windows.Forms.Padding(2);
            this.tabConsultarMorosidad.Name = "tabConsultarMorosidad";
            this.tabConsultarMorosidad.Padding = new System.Windows.Forms.Padding(2);
            this.tabConsultarMorosidad.Size = new System.Drawing.Size(932, 407);
            this.tabConsultarMorosidad.TabIndex = 1;
            this.tabConsultarMorosidad.Text = "Consultar Morosidad";
            this.tabConsultarMorosidad.UseVisualStyleBackColor = true;
            // 
            // tabConsultarCobros
            // 
            this.tabConsultarCobros.Location = new System.Drawing.Point(4, 22);
            this.tabConsultarCobros.Margin = new System.Windows.Forms.Padding(2);
            this.tabConsultarCobros.Name = "tabConsultarCobros";
            this.tabConsultarCobros.Size = new System.Drawing.Size(932, 407);
            this.tabConsultarCobros.TabIndex = 2;
            this.tabConsultarCobros.Text = "Consultar Cobros";
            this.tabConsultarCobros.UseVisualStyleBackColor = true;
            // 
            // tabConfiguraciones
            // 
            this.tabConfiguraciones.Controls.Add(this.materialTabSelector3);
            this.tabConfiguraciones.Controls.Add(this.tabOpcionConfiguraciones);
            this.tabConfiguraciones.ImageKey = "Configuraciones.png";
            this.tabConfiguraciones.Location = new System.Drawing.Point(4, 23);
            this.tabConfiguraciones.Margin = new System.Windows.Forms.Padding(2);
            this.tabConfiguraciones.Name = "tabConfiguraciones";
            this.tabConfiguraciones.Size = new System.Drawing.Size(936, 469);
            this.tabConfiguraciones.TabIndex = 4;
            this.tabConfiguraciones.Text = "Configuraciones";
            this.tabConfiguraciones.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector3
            // 
            this.materialTabSelector3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector3.BaseTabControl = this.tabOpcionConfiguraciones;
            this.materialTabSelector3.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector3.Depth = 0;
            this.materialTabSelector3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector3.Location = new System.Drawing.Point(-2, -2);
            this.materialTabSelector3.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabSelector3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector3.Name = "materialTabSelector3";
            this.materialTabSelector3.Size = new System.Drawing.Size(938, 39);
            this.materialTabSelector3.TabIndex = 3;
            this.materialTabSelector3.Text = "materialTabSelector1";
            // 
            // tabOpcionConfiguraciones
            // 
            this.tabOpcionConfiguraciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpcionConfiguraciones.Controls.Add(this.tabConfiguracionUsuarios);
            this.tabOpcionConfiguraciones.Controls.Add(this.tabConfiguracionAccesos);
            this.tabOpcionConfiguraciones.Controls.Add(this.tabConfiguracionModulos);
            this.tabOpcionConfiguraciones.Controls.Add(this.tabConfiguracionParametros);
            this.tabOpcionConfiguraciones.Depth = 0;
            this.tabOpcionConfiguraciones.Location = new System.Drawing.Point(-2, 42);
            this.tabOpcionConfiguraciones.Margin = new System.Windows.Forms.Padding(2);
            this.tabOpcionConfiguraciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionConfiguraciones.Multiline = true;
            this.tabOpcionConfiguraciones.Name = "tabOpcionConfiguraciones";
            this.tabOpcionConfiguraciones.SelectedIndex = 0;
            this.tabOpcionConfiguraciones.Size = new System.Drawing.Size(940, 433);
            this.tabOpcionConfiguraciones.TabIndex = 2;
            // 
            // tabConfiguracionUsuarios
            // 
            this.tabConfiguracionUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguracionUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.tabConfiguracionUsuarios.Name = "tabConfiguracionUsuarios";
            this.tabConfiguracionUsuarios.Padding = new System.Windows.Forms.Padding(2);
            this.tabConfiguracionUsuarios.Size = new System.Drawing.Size(932, 407);
            this.tabConfiguracionUsuarios.TabIndex = 0;
            this.tabConfiguracionUsuarios.Text = "Usuarios";
            this.tabConfiguracionUsuarios.UseVisualStyleBackColor = true;
            // 
            // tabConfiguracionAccesos
            // 
            this.tabConfiguracionAccesos.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguracionAccesos.Margin = new System.Windows.Forms.Padding(2);
            this.tabConfiguracionAccesos.Name = "tabConfiguracionAccesos";
            this.tabConfiguracionAccesos.Padding = new System.Windows.Forms.Padding(2);
            this.tabConfiguracionAccesos.Size = new System.Drawing.Size(932, 407);
            this.tabConfiguracionAccesos.TabIndex = 1;
            this.tabConfiguracionAccesos.Text = "Accesos";
            this.tabConfiguracionAccesos.UseVisualStyleBackColor = true;
            // 
            // tabConfiguracionModulos
            // 
            this.tabConfiguracionModulos.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguracionModulos.Margin = new System.Windows.Forms.Padding(2);
            this.tabConfiguracionModulos.Name = "tabConfiguracionModulos";
            this.tabConfiguracionModulos.Size = new System.Drawing.Size(932, 407);
            this.tabConfiguracionModulos.TabIndex = 2;
            this.tabConfiguracionModulos.Text = "Modulos";
            this.tabConfiguracionModulos.UseVisualStyleBackColor = true;
            // 
            // tabConfiguracionParametros
            // 
            this.tabConfiguracionParametros.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguracionParametros.Margin = new System.Windows.Forms.Padding(2);
            this.tabConfiguracionParametros.Name = "tabConfiguracionParametros";
            this.tabConfiguracionParametros.Size = new System.Drawing.Size(932, 407);
            this.tabConfiguracionParametros.TabIndex = 3;
            this.tabConfiguracionParametros.Text = "Parametros";
            this.tabConfiguracionParametros.UseVisualStyleBackColor = true;
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuServicios,
            this.menuMorosidad,
            this.menuCobros,
            this.menuConfiguraciones,
            this.reportesToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(2, 52);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuPrincipal.Size = new System.Drawing.Size(944, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuClientes
            // 
            this.menuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(61, 20);
            this.menuClientes.Text = "Clientes";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.registroToolStripMenuItem.Text = "Registro";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // menuServicios
            // 
            this.menuServicios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem1,
            this.preciosToolStripMenuItem});
            this.menuServicios.Name = "menuServicios";
            this.menuServicios.Size = new System.Drawing.Size(65, 20);
            this.menuServicios.Text = "Servicios";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // consultasToolStripMenuItem1
            // 
            this.consultasToolStripMenuItem1.Name = "consultasToolStripMenuItem1";
            this.consultasToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.consultasToolStripMenuItem1.Text = "Consultas";
            // 
            // preciosToolStripMenuItem
            // 
            this.preciosToolStripMenuItem.Name = "preciosToolStripMenuItem";
            this.preciosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.preciosToolStripMenuItem.Text = "Precios";
            // 
            // menuMorosidad
            // 
            this.menuMorosidad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeMoraToolStripMenuItem,
            this.planesDePagoToolStripMenuItem,
            this.notificacionesToolStripMenuItem});
            this.menuMorosidad.Name = "menuMorosidad";
            this.menuMorosidad.Size = new System.Drawing.Size(76, 20);
            this.menuMorosidad.Text = "Morosidad";
            // 
            // listaDeMoraToolStripMenuItem
            // 
            this.listaDeMoraToolStripMenuItem.Name = "listaDeMoraToolStripMenuItem";
            this.listaDeMoraToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.listaDeMoraToolStripMenuItem.Text = "Lista de Mora";
            // 
            // planesDePagoToolStripMenuItem
            // 
            this.planesDePagoToolStripMenuItem.Name = "planesDePagoToolStripMenuItem";
            this.planesDePagoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.planesDePagoToolStripMenuItem.Text = "Planes de Pago";
            // 
            // notificacionesToolStripMenuItem
            // 
            this.notificacionesToolStripMenuItem.Name = "notificacionesToolStripMenuItem";
            this.notificacionesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.notificacionesToolStripMenuItem.Text = "Notificaciones";
            // 
            // menuCobros
            // 
            this.menuCobros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturarToolStripMenuItem,
            this.consultasMorosidadToolStripMenuItem,
            this.consultarCobrosToolStripMenuItem});
            this.menuCobros.Name = "menuCobros";
            this.menuCobros.Size = new System.Drawing.Size(57, 20);
            this.menuCobros.Text = "Cobros";
            // 
            // facturarToolStripMenuItem
            // 
            this.facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
            this.facturarToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.facturarToolStripMenuItem.Text = "Facturar";
            // 
            // consultasMorosidadToolStripMenuItem
            // 
            this.consultasMorosidadToolStripMenuItem.Name = "consultasMorosidadToolStripMenuItem";
            this.consultasMorosidadToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.consultasMorosidadToolStripMenuItem.Text = "Consultar Morosidad";
            // 
            // consultarCobrosToolStripMenuItem
            // 
            this.consultarCobrosToolStripMenuItem.Name = "consultarCobrosToolStripMenuItem";
            this.consultarCobrosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.consultarCobrosToolStripMenuItem.Text = "Consultar Cobros";
            // 
            // menuConfiguraciones
            // 
            this.menuConfiguraciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.accesosToolStripMenuItem,
            this.modulosToolStripMenuItem,
            this.parametrosToolStripMenuItem});
            this.menuConfiguraciones.Name = "menuConfiguraciones";
            this.menuConfiguraciones.Size = new System.Drawing.Size(106, 20);
            this.menuConfiguraciones.Text = "Configuraciones";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // accesosToolStripMenuItem
            // 
            this.accesosToolStripMenuItem.Name = "accesosToolStripMenuItem";
            this.accesosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.accesosToolStripMenuItem.Text = "Accesos";
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.modulosToolStripMenuItem.Text = "Modulos";
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.parametrosToolStripMenuItem.Text = "Parametros";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteClientesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.tabOpcionReportes);
            this.tabReportes.Controls.Add(this.tabSelectorReportes);
            this.tabReportes.ImageKey = "Reporte.png";
            this.tabReportes.Location = new System.Drawing.Point(4, 23);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Size = new System.Drawing.Size(936, 469);
            this.tabReportes.TabIndex = 5;
            this.tabReportes.Text = "Reportes";
            this.tabReportes.UseVisualStyleBackColor = true;
            // 
            // tabSelectorReportes
            // 
            this.tabSelectorReportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelectorReportes.BaseTabControl = this.tabOpcionReportes;
            this.tabSelectorReportes.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelectorReportes.Depth = 0;
            this.tabSelectorReportes.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorReportes.Location = new System.Drawing.Point(-1, 3);
            this.tabSelectorReportes.Margin = new System.Windows.Forms.Padding(2);
            this.tabSelectorReportes.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorReportes.Name = "tabSelectorReportes";
            this.tabSelectorReportes.Size = new System.Drawing.Size(938, 39);
            this.tabSelectorReportes.TabIndex = 2;
            this.tabSelectorReportes.Text = "materialTabSelector1";
            // 
            // tabOpcionReportes
            // 
            this.tabOpcionReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpcionReportes.Controls.Add(this.tabReporteClientes);
            this.tabOpcionReportes.Depth = 0;
            this.tabOpcionReportes.ImageList = this.listaImagenes;
            this.tabOpcionReportes.Location = new System.Drawing.Point(-2, 40);
            this.tabOpcionReportes.Margin = new System.Windows.Forms.Padding(2);
            this.tabOpcionReportes.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionReportes.Multiline = true;
            this.tabOpcionReportes.Name = "tabOpcionReportes";
            this.tabOpcionReportes.SelectedIndex = 0;
            this.tabOpcionReportes.Size = new System.Drawing.Size(940, 432);
            this.tabOpcionReportes.TabIndex = 3;
            // 
            // tabReporteClientes
            // 
            this.tabReporteClientes.ImageKey = "Reporte_2.png";
            this.tabReporteClientes.Location = new System.Drawing.Point(4, 23);
            this.tabReporteClientes.Margin = new System.Windows.Forms.Padding(2);
            this.tabReporteClientes.Name = "tabReporteClientes";
            this.tabReporteClientes.Padding = new System.Windows.Forms.Padding(2);
            this.tabReporteClientes.Size = new System.Drawing.Size(932, 405);
            this.tabReporteClientes.TabIndex = 1;
            this.tabReporteClientes.Text = "ReporteClientes";
            this.tabReporteClientes.UseVisualStyleBackColor = true;
            // 
            // reporteClientesToolStripMenuItem
            // 
            this.reporteClientesToolStripMenuItem.Name = "reporteClientesToolStripMenuItem";
            this.reporteClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporteClientesToolStripMenuItem.Text = "Reporte Clientes";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 574);
            this.Controls.Add(this.tabMenuPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabMenuPrincipal;
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "Sistema de Cobranzas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabMenuPrincipal.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabOpcionClientes.ResumeLayout(false);
            this.tabServicios.ResumeLayout(false);
            this.tabOpcionServicios.ResumeLayout(false);
            this.tabMorosidad.ResumeLayout(false);
            this.tabOpcionMorosidad.ResumeLayout(false);
            this.tabCobros.ResumeLayout(false);
            this.tabOpcionCobros.ResumeLayout(false);
            this.tabConfiguraciones.ResumeLayout(false);
            this.tabOpcionConfiguraciones.ResumeLayout(false);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.tabReportes.ResumeLayout(false);
            this.tabOpcionReportes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabMenuPrincipal;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabServicios;
        private System.Windows.Forms.TabPage tabMorosidad;
        private System.Windows.Forms.TabPage tabCobros;
        private System.Windows.Forms.ImageList listaImagenes;
        private System.Windows.Forms.TabPage tabConfiguraciones;
        private MaterialSkin.Controls.MaterialTabControl tabOpcionClientes;
        private System.Windows.Forms.TabPage tabRegistros;
        private System.Windows.Forms.TabPage tabClientesConsultas;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorClientes;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorServicios;
        private MaterialSkin.Controls.MaterialTabControl tabOpcionServicios;
        private System.Windows.Forms.TabPage tabServicioRegistro;
        private System.Windows.Forms.TabPage tabServicioConsulta;
        private System.Windows.Forms.TabPage tabServicioPrecios;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tabOpcionMorosidad;
        private System.Windows.Forms.TabPage tabMorosidadListaPagos;
        private System.Windows.Forms.TabPage tabMorosidadPlanesPago;
        private System.Windows.Forms.TabPage tabMorosidadNotificaciones;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl tabOpcionCobros;
        private System.Windows.Forms.TabPage tabFacturar;
        private System.Windows.Forms.TabPage tabConsultarMorosidad;
        private System.Windows.Forms.TabPage tabConsultarCobros;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
        private MaterialSkin.Controls.MaterialTabControl tabOpcionConfiguraciones;
        private System.Windows.Forms.TabPage tabConfiguracionUsuarios;
        private System.Windows.Forms.TabPage tabConfiguracionAccesos;
        private System.Windows.Forms.TabPage tabConfiguracionModulos;
        private System.Windows.Forms.TabPage tabConfiguracionParametros;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuServicios;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMorosidad;
        private System.Windows.Forms.ToolStripMenuItem listaDeMoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCobros;
        private System.Windows.Forms.ToolStripMenuItem facturarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasMorosidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCobrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuConfiguraciones;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.TabPage tabReportes;
        private MaterialSkin.Controls.MaterialTabControl tabOpcionReportes;
        private System.Windows.Forms.TabPage tabReporteClientes;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorReportes;
        private System.Windows.Forms.ToolStripMenuItem reporteClientesToolStripMenuItem;
    }
}

