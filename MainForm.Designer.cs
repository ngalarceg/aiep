namespace BoockWorldApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.tableUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panelUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsuarioNombre = new System.Windows.Forms.Label();
            this.txtUsuarioNombre = new System.Windows.Forms.TextBox();
            this.lblUsuarioCorreo = new System.Windows.Forms.Label();
            this.txtUsuarioCorreo = new System.Windows.Forms.TextBox();
            this.lblUsuarioTelefono = new System.Windows.Forms.Label();
            this.txtUsuarioTelefono = new System.Windows.Forms.TextBox();
            this.panelUsuarioBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUsuarioAgregar = new System.Windows.Forms.Button();
            this.btnUsuarioActualizar = new System.Windows.Forms.Button();
            this.btnUsuarioEliminar = new System.Windows.Forms.Button();
            this.tabLibros = new System.Windows.Forms.TabPage();
            this.tableLibros = new System.Windows.Forms.TableLayoutPanel();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.panelLibros = new System.Windows.Forms.TableLayoutPanel();
            this.lblLibroTitulo = new System.Windows.Forms.Label();
            this.txtLibroTitulo = new System.Windows.Forms.TextBox();
            this.lblLibroAutor = new System.Windows.Forms.Label();
            this.txtLibroAutor = new System.Windows.Forms.TextBox();
            this.lblLibroAnio = new System.Windows.Forms.Label();
            this.txtLibroAnio = new System.Windows.Forms.TextBox();
            this.lblLibroGenero = new System.Windows.Forms.Label();
            this.txtLibroGenero = new System.Windows.Forms.TextBox();
            this.panelLibroBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLibroAgregar = new System.Windows.Forms.Button();
            this.btnLibroActualizar = new System.Windows.Forms.Button();
            this.btnLibroEliminar = new System.Windows.Forms.Button();
            this.tabPrestamos = new System.Windows.Forms.TabPage();
            this.tablePrestamos = new System.Windows.Forms.TableLayoutPanel();
            this.panelPrestamoForm = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrestamoUsuario = new System.Windows.Forms.Label();
            this.cmbPrestamoUsuario = new System.Windows.Forms.ComboBox();
            this.lblPrestamoLibro = new System.Windows.Forms.Label();
            this.cmbPrestamoLibro = new System.Windows.Forms.ComboBox();
            this.btnGenerarPrestamo = new System.Windows.Forms.Button();
            this.dgvPrestamosActivos = new System.Windows.Forms.DataGridView();
            this.btnDevolverPrestamo = new System.Windows.Forms.Button();
            this.tabReporte = new System.Windows.Forms.TabPage();
            this.dgvReportePrestamos = new System.Windows.Forms.DataGridView();
            this.tabPrincipal.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            this.tableUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panelUsuarios.SuspendLayout();
            this.panelUsuarioBotones.SuspendLayout();
            this.tabLibros.SuspendLayout();
            this.tableLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.panelLibros.SuspendLayout();
            this.panelLibroBotones.SuspendLayout();
            this.tabPrestamos.SuspendLayout();
            this.tablePrestamos.SuspendLayout();
            this.panelPrestamoForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosActivos)).BeginInit();
            this.tabReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabUsuarios);
            this.tabPrincipal.Controls.Add(this.tabLibros);
            this.tabPrincipal.Controls.Add(this.tabPrestamos);
            this.tabPrincipal.Controls.Add(this.tabReporte);
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(984, 561);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.tableUsuarios);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 29);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(976, 528);
            this.tabUsuarios.TabIndex = 0;
            this.tabUsuarios.Text = "Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // tableUsuarios
            // 
            this.tableUsuarios.ColumnCount = 1;
            this.tableUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableUsuarios.Controls.Add(this.dgvUsuarios, 0, 0);
            this.tableUsuarios.Controls.Add(this.panelUsuarios, 0, 1);
            this.tableUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableUsuarios.Location = new System.Drawing.Point(3, 3);
            this.tableUsuarios.Name = "tableUsuarios";
            this.tableUsuarios.RowCount = 2;
            this.tableUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableUsuarios.Size = new System.Drawing.Size(970, 522);
            this.tableUsuarios.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 29;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(964, 333);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.ColumnCount = 4;
            this.panelUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.panelUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.panelUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelUsuarios.Controls.Add(this.lblUsuarioNombre, 0, 0);
            this.panelUsuarios.Controls.Add(this.txtUsuarioNombre, 1, 0);
            this.panelUsuarios.Controls.Add(this.lblUsuarioCorreo, 0, 1);
            this.panelUsuarios.Controls.Add(this.txtUsuarioCorreo, 1, 1);
            this.panelUsuarios.Controls.Add(this.lblUsuarioTelefono, 0, 2);
            this.panelUsuarios.Controls.Add(this.txtUsuarioTelefono, 1, 2);
            this.panelUsuarios.Controls.Add(this.panelUsuarioBotones, 0, 3);
            this.panelUsuarios.SetColumnSpan(this.panelUsuarioBotones, 4);
            this.panelUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsuarios.Location = new System.Drawing.Point(3, 342);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.RowCount = 4;
            this.panelUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelUsuarios.Size = new System.Drawing.Size(964, 177);
            this.panelUsuarios.TabIndex = 1;
            // 
            // lblUsuarioNombre
            // 
            this.lblUsuarioNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsuarioNombre.AutoSize = true;
            this.lblUsuarioNombre.Location = new System.Drawing.Point(3, 9);
            this.lblUsuarioNombre.Name = "lblUsuarioNombre";
            this.lblUsuarioNombre.Size = new System.Drawing.Size(64, 20);
            this.lblUsuarioNombre.TabIndex = 0;
            this.lblUsuarioNombre.Text = "Nombre";
            // 
            // txtUsuarioNombre
            // 
            this.txtUsuarioNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuarioNombre.Location = new System.Drawing.Point(123, 6);
            this.txtUsuarioNombre.Name = "txtUsuarioNombre";
            this.txtUsuarioNombre.Size = new System.Drawing.Size(349, 27);
            this.txtUsuarioNombre.TabIndex = 1;
            // 
            // lblUsuarioCorreo
            // 
            this.lblUsuarioCorreo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsuarioCorreo.AutoSize = true;
            this.lblUsuarioCorreo.Location = new System.Drawing.Point(3, 49);
            this.lblUsuarioCorreo.Name = "lblUsuarioCorreo";
            this.lblUsuarioCorreo.Size = new System.Drawing.Size(55, 20);
            this.lblUsuarioCorreo.TabIndex = 2;
            this.lblUsuarioCorreo.Text = "Correo";
            // 
            // txtUsuarioCorreo
            // 
            this.txtUsuarioCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuarioCorreo.Location = new System.Drawing.Point(123, 46);
            this.txtUsuarioCorreo.Name = "txtUsuarioCorreo";
            this.txtUsuarioCorreo.Size = new System.Drawing.Size(349, 27);
            this.txtUsuarioCorreo.TabIndex = 3;
            // 
            // lblUsuarioTelefono
            // 
            this.lblUsuarioTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsuarioTelefono.AutoSize = true;
            this.lblUsuarioTelefono.Location = new System.Drawing.Point(3, 89);
            this.lblUsuarioTelefono.Name = "lblUsuarioTelefono";
            this.lblUsuarioTelefono.Size = new System.Drawing.Size(66, 20);
            this.lblUsuarioTelefono.TabIndex = 4;
            this.lblUsuarioTelefono.Text = "Teléfono";
            // 
            // txtUsuarioTelefono
            // 
            this.txtUsuarioTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuarioTelefono.Location = new System.Drawing.Point(123, 86);
            this.txtUsuarioTelefono.Name = "txtUsuarioTelefono";
            this.txtUsuarioTelefono.Size = new System.Drawing.Size(349, 27);
            this.txtUsuarioTelefono.TabIndex = 5;
            // 
            // panelUsuarioBotones
            // 
            this.panelUsuarioBotones.AutoSize = true;
            this.panelUsuarioBotones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelUsuarioBotones.Controls.Add(this.btnUsuarioAgregar);
            this.panelUsuarioBotones.Controls.Add(this.btnUsuarioActualizar);
            this.panelUsuarioBotones.Controls.Add(this.btnUsuarioEliminar);
            this.panelUsuarioBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsuarioBotones.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.panelUsuarioBotones.Location = new System.Drawing.Point(3, 123);
            this.panelUsuarioBotones.Name = "panelUsuarioBotones";
            this.panelUsuarioBotones.Size = new System.Drawing.Size(114, 51);
            this.panelUsuarioBotones.TabIndex = 6;
            // 
            // btnUsuarioAgregar
            // 
            this.btnUsuarioAgregar.AutoSize = true;
            this.btnUsuarioAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnUsuarioAgregar.Name = "btnUsuarioAgregar";
            this.btnUsuarioAgregar.Size = new System.Drawing.Size(78, 30);
            this.btnUsuarioAgregar.TabIndex = 0;
            this.btnUsuarioAgregar.Text = "Agregar";
            this.btnUsuarioAgregar.UseVisualStyleBackColor = true;
            this.btnUsuarioAgregar.Click += new System.EventHandler(this.btnUsuarioAgregar_Click);
            // 
            // btnUsuarioActualizar
            // 
            this.btnUsuarioActualizar.AutoSize = true;
            this.btnUsuarioActualizar.Location = new System.Drawing.Point(87, 3);
            this.btnUsuarioActualizar.Name = "btnUsuarioActualizar";
            this.btnUsuarioActualizar.Size = new System.Drawing.Size(94, 30);
            this.btnUsuarioActualizar.TabIndex = 1;
            this.btnUsuarioActualizar.Text = "Actualizar";
            this.btnUsuarioActualizar.UseVisualStyleBackColor = true;
            this.btnUsuarioActualizar.Click += new System.EventHandler(this.btnUsuarioActualizar_Click);
            // 
            // btnUsuarioEliminar
            // 
            this.btnUsuarioEliminar.AutoSize = true;
            this.btnUsuarioEliminar.Location = new System.Drawing.Point(187, 3);
            this.btnUsuarioEliminar.Name = "btnUsuarioEliminar";
            this.btnUsuarioEliminar.Size = new System.Drawing.Size(78, 30);
            this.btnUsuarioEliminar.TabIndex = 2;
            this.btnUsuarioEliminar.Text = "Eliminar";
            this.btnUsuarioEliminar.UseVisualStyleBackColor = true;
            this.btnUsuarioEliminar.Click += new System.EventHandler(this.btnUsuarioEliminar_Click);
            // 
            // tabLibros
            // 
            this.tabLibros.Controls.Add(this.tableLibros);
            this.tabLibros.Location = new System.Drawing.Point(4, 29);
            this.tabLibros.Name = "tabLibros";
            this.tabLibros.Padding = new System.Windows.Forms.Padding(3);
            this.tabLibros.Size = new System.Drawing.Size(976, 528);
            this.tabLibros.TabIndex = 1;
            this.tabLibros.Text = "Libros";
            this.tabLibros.UseVisualStyleBackColor = true;
            // 
            // tableLibros
            // 
            this.tableLibros.ColumnCount = 1;
            this.tableLibros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLibros.Controls.Add(this.dgvLibros, 0, 0);
            this.tableLibros.Controls.Add(this.panelLibros, 0, 1);
            this.tableLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLibros.Location = new System.Drawing.Point(3, 3);
            this.tableLibros.Name = "tableLibros";
            this.tableLibros.RowCount = 2;
            this.tableLibros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLibros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLibros.Size = new System.Drawing.Size(970, 522);
            this.tableLibros.TabIndex = 0;
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLibros.Location = new System.Drawing.Point(3, 3);
            this.dgvLibros.MultiSelect = false;
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 29;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(964, 333);
            this.dgvLibros.TabIndex = 0;
            this.dgvLibros.SelectionChanged += new System.EventHandler(this.dgvLibros_SelectionChanged);
            // 
            // panelLibros
            // 
            this.panelLibros.ColumnCount = 4;
            this.panelLibros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.panelLibros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLibros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.panelLibros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLibros.Controls.Add(this.lblLibroTitulo, 0, 0);
            this.panelLibros.Controls.Add(this.txtLibroTitulo, 1, 0);
            this.panelLibros.Controls.Add(this.lblLibroAutor, 0, 1);
            this.panelLibros.Controls.Add(this.txtLibroAutor, 1, 1);
            this.panelLibros.Controls.Add(this.lblLibroAnio, 2, 0);
            this.panelLibros.Controls.Add(this.txtLibroAnio, 3, 0);
            this.panelLibros.Controls.Add(this.lblLibroGenero, 2, 1);
            this.panelLibros.Controls.Add(this.txtLibroGenero, 3, 1);
            this.panelLibros.Controls.Add(this.panelLibroBotones, 0, 2);
            this.panelLibros.SetColumnSpan(this.panelLibroBotones, 4);
            this.panelLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLibros.Location = new System.Drawing.Point(3, 342);
            this.panelLibros.Name = "panelLibros";
            this.panelLibros.RowCount = 3;
            this.panelLibros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelLibros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelLibros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelLibros.Size = new System.Drawing.Size(964, 177);
            this.panelLibros.TabIndex = 1;
            // 
            // lblLibroTitulo
            // 
            this.lblLibroTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLibroTitulo.AutoSize = true;
            this.lblLibroTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblLibroTitulo.Name = "lblLibroTitulo";
            this.lblLibroTitulo.Size = new System.Drawing.Size(46, 20);
            this.lblLibroTitulo.TabIndex = 0;
            this.lblLibroTitulo.Text = "Título";
            // 
            // txtLibroTitulo
            // 
            this.txtLibroTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLibroTitulo.Location = new System.Drawing.Point(123, 6);
            this.txtLibroTitulo.Name = "txtLibroTitulo";
            this.txtLibroTitulo.Size = new System.Drawing.Size(349, 27);
            this.txtLibroTitulo.TabIndex = 1;
            // 
            // lblLibroAutor
            // 
            this.lblLibroAutor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLibroAutor.AutoSize = true;
            this.lblLibroAutor.Location = new System.Drawing.Point(3, 49);
            this.lblLibroAutor.Name = "lblLibroAutor";
            this.lblLibroAutor.Size = new System.Drawing.Size(47, 20);
            this.lblLibroAutor.TabIndex = 2;
            this.lblLibroAutor.Text = "Autor";
            // 
            // txtLibroAutor
            // 
            this.txtLibroAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLibroAutor.Location = new System.Drawing.Point(123, 46);
            this.txtLibroAutor.Name = "txtLibroAutor";
            this.txtLibroAutor.Size = new System.Drawing.Size(349, 27);
            this.txtLibroAutor.TabIndex = 3;
            // 
            // lblLibroAnio
            // 
            this.lblLibroAnio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLibroAnio.AutoSize = true;
            this.lblLibroAnio.Location = new System.Drawing.Point(478, 9);
            this.lblLibroAnio.Name = "lblLibroAnio";
            this.lblLibroAnio.Size = new System.Drawing.Size(38, 20);
            this.lblLibroAnio.TabIndex = 4;
            this.lblLibroAnio.Text = "Año";
            // 
            // txtLibroAnio
            // 
            this.txtLibroAnio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLibroAnio.Location = new System.Drawing.Point(598, 6);
            this.txtLibroAnio.Name = "txtLibroAnio";
            this.txtLibroAnio.Size = new System.Drawing.Size(363, 27);
            this.txtLibroAnio.TabIndex = 5;
            // 
            // lblLibroGenero
            // 
            this.lblLibroGenero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLibroGenero.AutoSize = true;
            this.lblLibroGenero.Location = new System.Drawing.Point(478, 49);
            this.lblLibroGenero.Name = "lblLibroGenero";
            this.lblLibroGenero.Size = new System.Drawing.Size(57, 20);
            this.lblLibroGenero.TabIndex = 6;
            this.lblLibroGenero.Text = "Género";
            // 
            // txtLibroGenero
            // 
            this.txtLibroGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLibroGenero.Location = new System.Drawing.Point(598, 46);
            this.txtLibroGenero.Name = "txtLibroGenero";
            this.txtLibroGenero.Size = new System.Drawing.Size(363, 27);
            this.txtLibroGenero.TabIndex = 7;
            // 
            // panelLibroBotones
            // 
            this.panelLibroBotones.AutoSize = true;
            this.panelLibroBotones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLibroBotones.Controls.Add(this.btnLibroAgregar);
            this.panelLibroBotones.Controls.Add(this.btnLibroActualizar);
            this.panelLibroBotones.Controls.Add(this.btnLibroEliminar);
            this.panelLibroBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLibroBotones.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.panelLibroBotones.Location = new System.Drawing.Point(3, 83);
            this.panelLibroBotones.Name = "panelLibroBotones";
            this.panelLibroBotones.Size = new System.Drawing.Size(114, 91);
            this.panelLibroBotones.TabIndex = 8;
            // 
            // btnLibroAgregar
            // 
            this.btnLibroAgregar.AutoSize = true;
            this.btnLibroAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnLibroAgregar.Name = "btnLibroAgregar";
            this.btnLibroAgregar.Size = new System.Drawing.Size(78, 30);
            this.btnLibroAgregar.TabIndex = 0;
            this.btnLibroAgregar.Text = "Agregar";
            this.btnLibroAgregar.UseVisualStyleBackColor = true;
            this.btnLibroAgregar.Click += new System.EventHandler(this.btnLibroAgregar_Click);
            // 
            // btnLibroActualizar
            // 
            this.btnLibroActualizar.AutoSize = true;
            this.btnLibroActualizar.Location = new System.Drawing.Point(87, 3);
            this.btnLibroActualizar.Name = "btnLibroActualizar";
            this.btnLibroActualizar.Size = new System.Drawing.Size(94, 30);
            this.btnLibroActualizar.TabIndex = 1;
            this.btnLibroActualizar.Text = "Actualizar";
            this.btnLibroActualizar.UseVisualStyleBackColor = true;
            this.btnLibroActualizar.Click += new System.EventHandler(this.btnLibroActualizar_Click);
            // 
            // btnLibroEliminar
            // 
            this.btnLibroEliminar.AutoSize = true;
            this.btnLibroEliminar.Location = new System.Drawing.Point(187, 3);
            this.btnLibroEliminar.Name = "btnLibroEliminar";
            this.btnLibroEliminar.Size = new System.Drawing.Size(78, 30);
            this.btnLibroEliminar.TabIndex = 2;
            this.btnLibroEliminar.Text = "Eliminar";
            this.btnLibroEliminar.UseVisualStyleBackColor = true;
            this.btnLibroEliminar.Click += new System.EventHandler(this.btnLibroEliminar_Click);
            // 
            // tabPrestamos
            // 
            this.tabPrestamos.Controls.Add(this.tablePrestamos);
            this.tabPrestamos.Location = new System.Drawing.Point(4, 29);
            this.tabPrestamos.Name = "tabPrestamos";
            this.tabPrestamos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrestamos.Size = new System.Drawing.Size(976, 528);
            this.tabPrestamos.TabIndex = 2;
            this.tabPrestamos.Text = "Préstamos";
            this.tabPrestamos.UseVisualStyleBackColor = true;
            // 
            // tablePrestamos
            // 
            this.tablePrestamos.ColumnCount = 1;
            this.tablePrestamos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePrestamos.Controls.Add(this.panelPrestamoForm, 0, 0);
            this.tablePrestamos.Controls.Add(this.dgvPrestamosActivos, 0, 1);
            this.tablePrestamos.Controls.Add(this.btnDevolverPrestamo, 0, 2);
            this.tablePrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePrestamos.Location = new System.Drawing.Point(3, 3);
            this.tablePrestamos.Name = "tablePrestamos";
            this.tablePrestamos.RowCount = 3;
            this.tablePrestamos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tablePrestamos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePrestamos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tablePrestamos.Size = new System.Drawing.Size(970, 522);
            this.tablePrestamos.TabIndex = 0;
            // 
            // panelPrestamoForm
            // 
            this.panelPrestamoForm.ColumnCount = 2;
            this.panelPrestamoForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.panelPrestamoForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelPrestamoForm.Controls.Add(this.lblPrestamoUsuario, 0, 0);
            this.panelPrestamoForm.Controls.Add(this.cmbPrestamoUsuario, 1, 0);
            this.panelPrestamoForm.Controls.Add(this.lblPrestamoLibro, 0, 1);
            this.panelPrestamoForm.Controls.Add(this.cmbPrestamoLibro, 1, 1);
            this.panelPrestamoForm.Controls.Add(this.btnGenerarPrestamo, 1, 2);
            this.panelPrestamoForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrestamoForm.Location = new System.Drawing.Point(3, 3);
            this.panelPrestamoForm.Name = "panelPrestamoForm";
            this.panelPrestamoForm.RowCount = 3;
            this.panelPrestamoForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelPrestamoForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelPrestamoForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelPrestamoForm.Size = new System.Drawing.Size(964, 114);
            this.panelPrestamoForm.TabIndex = 0;
            // 
            // lblPrestamoUsuario
            // 
            this.lblPrestamoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrestamoUsuario.AutoSize = true;
            this.lblPrestamoUsuario.Location = new System.Drawing.Point(3, 10);
            this.lblPrestamoUsuario.Name = "lblPrestamoUsuario";
            this.lblPrestamoUsuario.Size = new System.Drawing.Size(60, 20);
            this.lblPrestamoUsuario.TabIndex = 0;
            this.lblPrestamoUsuario.Text = "Usuario";
            // 
            // cmbPrestamoUsuario
            // 
            this.cmbPrestamoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPrestamoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrestamoUsuario.FormattingEnabled = true;
            this.cmbPrestamoUsuario.Location = new System.Drawing.Point(153, 6);
            this.cmbPrestamoUsuario.Name = "cmbPrestamoUsuario";
            this.cmbPrestamoUsuario.Size = new System.Drawing.Size(808, 28);
            this.cmbPrestamoUsuario.TabIndex = 1;
            // 
            // lblPrestamoLibro
            // 
            this.lblPrestamoLibro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrestamoLibro.AutoSize = true;
            this.lblPrestamoLibro.Location = new System.Drawing.Point(3, 50);
            this.lblPrestamoLibro.Name = "lblPrestamoLibro";
            this.lblPrestamoLibro.Size = new System.Drawing.Size(44, 20);
            this.lblPrestamoLibro.TabIndex = 2;
            this.lblPrestamoLibro.Text = "Libro";
            // 
            // cmbPrestamoLibro
            // 
            this.cmbPrestamoLibro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPrestamoLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrestamoLibro.FormattingEnabled = true;
            this.cmbPrestamoLibro.Location = new System.Drawing.Point(153, 46);
            this.cmbPrestamoLibro.Name = "cmbPrestamoLibro";
            this.cmbPrestamoLibro.Size = new System.Drawing.Size(808, 28);
            this.cmbPrestamoLibro.TabIndex = 3;
            // 
            // btnGenerarPrestamo
            // 
            this.btnGenerarPrestamo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGenerarPrestamo.AutoSize = true;
            this.btnGenerarPrestamo.Location = new System.Drawing.Point(153, 83);
            this.btnGenerarPrestamo.Name = "btnGenerarPrestamo";
            this.btnGenerarPrestamo.Size = new System.Drawing.Size(152, 30);
            this.btnGenerarPrestamo.TabIndex = 4;
            this.btnGenerarPrestamo.Text = "Generar préstamo";
            this.btnGenerarPrestamo.UseVisualStyleBackColor = true;
            this.btnGenerarPrestamo.Click += new System.EventHandler(this.btnGenerarPrestamo_Click);
            // 
            // dgvPrestamosActivos
            // 
            this.dgvPrestamosActivos.AllowUserToAddRows = false;
            this.dgvPrestamosActivos.AllowUserToDeleteRows = false;
            this.dgvPrestamosActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamosActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrestamosActivos.Location = new System.Drawing.Point(3, 123);
            this.dgvPrestamosActivos.MultiSelect = false;
            this.dgvPrestamosActivos.Name = "dgvPrestamosActivos";
            this.dgvPrestamosActivos.ReadOnly = true;
            this.dgvPrestamosActivos.RowHeadersWidth = 51;
            this.dgvPrestamosActivos.RowTemplate.Height = 29;
            this.dgvPrestamosActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamosActivos.Size = new System.Drawing.Size(964, 346);
            this.dgvPrestamosActivos.TabIndex = 1;
            // 
            // btnDevolverPrestamo
            // 
            this.btnDevolverPrestamo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDevolverPrestamo.AutoSize = true;
            this.btnDevolverPrestamo.Location = new System.Drawing.Point(3, 480);
            this.btnDevolverPrestamo.Name = "btnDevolverPrestamo";
            this.btnDevolverPrestamo.Size = new System.Drawing.Size(152, 30);
            this.btnDevolverPrestamo.TabIndex = 2;
            this.btnDevolverPrestamo.Text = "Registrar devolución";
            this.btnDevolverPrestamo.UseVisualStyleBackColor = true;
            this.btnDevolverPrestamo.Click += new System.EventHandler(this.btnDevolverPrestamo_Click);
            // 
            // tabReporte
            // 
            this.tabReporte.Controls.Add(this.dgvReportePrestamos);
            this.tabReporte.Location = new System.Drawing.Point(4, 29);
            this.tabReporte.Name = "tabReporte";
            this.tabReporte.Padding = new System.Windows.Forms.Padding(3);
            this.tabReporte.Size = new System.Drawing.Size(976, 528);
            this.tabReporte.TabIndex = 3;
            this.tabReporte.Text = "Reporte";
            this.tabReporte.UseVisualStyleBackColor = true;
            // 
            // dgvReportePrestamos
            // 
            this.dgvReportePrestamos.AllowUserToAddRows = false;
            this.dgvReportePrestamos.AllowUserToDeleteRows = false;
            this.dgvReportePrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportePrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportePrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportePrestamos.Location = new System.Drawing.Point(3, 3);
            this.dgvReportePrestamos.MultiSelect = false;
            this.dgvReportePrestamos.Name = "dgvReportePrestamos";
            this.dgvReportePrestamos.ReadOnly = true;
            this.dgvReportePrestamos.RowHeadersWidth = 51;
            this.dgvReportePrestamos.RowTemplate.Height = 29;
            this.dgvReportePrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportePrestamos.Size = new System.Drawing.Size(970, 522);
            this.dgvReportePrestamos.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabPrincipal);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookWorld";
            this.tabPrincipal.ResumeLayout(false);
            this.tabUsuarios.ResumeLayout(false);
            this.tableUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panelUsuarios.ResumeLayout(false);
            this.panelUsuarios.PerformLayout();
            this.panelUsuarioBotones.ResumeLayout(false);
            this.panelUsuarioBotones.PerformLayout();
            this.tabLibros.ResumeLayout(false);
            this.tableLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.panelLibros.ResumeLayout(false);
            this.panelLibros.PerformLayout();
            this.panelLibroBotones.ResumeLayout(false);
            this.panelLibroBotones.PerformLayout();
            this.tabPrestamos.ResumeLayout(false);
            this.tablePrestamos.ResumeLayout(false);
            this.tablePrestamos.PerformLayout();
            this.panelPrestamoForm.ResumeLayout(false);
            this.panelPrestamoForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosActivos)).EndInit();
            this.tabReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.TabPage tabLibros;
        private System.Windows.Forms.TabPage tabPrestamos;
        private System.Windows.Forms.TabPage tabReporte;
        private System.Windows.Forms.TableLayoutPanel tableUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TableLayoutPanel panelUsuarios;
        private System.Windows.Forms.Label lblUsuarioNombre;
        private System.Windows.Forms.TextBox txtUsuarioNombre;
        private System.Windows.Forms.Label lblUsuarioCorreo;
        private System.Windows.Forms.TextBox txtUsuarioCorreo;
        private System.Windows.Forms.Label lblUsuarioTelefono;
        private System.Windows.Forms.TextBox txtUsuarioTelefono;
        private System.Windows.Forms.FlowLayoutPanel panelUsuarioBotones;
        private System.Windows.Forms.Button btnUsuarioAgregar;
        private System.Windows.Forms.Button btnUsuarioActualizar;
        private System.Windows.Forms.Button btnUsuarioEliminar;
        private System.Windows.Forms.TableLayoutPanel tableLibros;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.TableLayoutPanel panelLibros;
        private System.Windows.Forms.Label lblLibroTitulo;
        private System.Windows.Forms.TextBox txtLibroTitulo;
        private System.Windows.Forms.Label lblLibroAutor;
        private System.Windows.Forms.TextBox txtLibroAutor;
        private System.Windows.Forms.Label lblLibroAnio;
        private System.Windows.Forms.TextBox txtLibroAnio;
        private System.Windows.Forms.Label lblLibroGenero;
        private System.Windows.Forms.TextBox txtLibroGenero;
        private System.Windows.Forms.FlowLayoutPanel panelLibroBotones;
        private System.Windows.Forms.Button btnLibroAgregar;
        private System.Windows.Forms.Button btnLibroActualizar;
        private System.Windows.Forms.Button btnLibroEliminar;
        private System.Windows.Forms.TableLayoutPanel tablePrestamos;
        private System.Windows.Forms.TableLayoutPanel panelPrestamoForm;
        private System.Windows.Forms.Label lblPrestamoUsuario;
        private System.Windows.Forms.ComboBox cmbPrestamoUsuario;
        private System.Windows.Forms.Label lblPrestamoLibro;
        private System.Windows.Forms.ComboBox cmbPrestamoLibro;
        private System.Windows.Forms.Button btnGenerarPrestamo;
        private System.Windows.Forms.DataGridView dgvPrestamosActivos;
        private System.Windows.Forms.Button btnDevolverPrestamo;
        private System.Windows.Forms.DataGridView dgvReportePrestamos;
    }
}
