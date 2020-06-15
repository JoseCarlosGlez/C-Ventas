namespace WindowsFormsApp2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pMenuLateral = new System.Windows.Forms.Panel();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.pSubMenuCatalogo = new System.Windows.Forms.Panel();
            this.btnVerCatalogo = new FontAwesome.Sharp.IconButton();
            this.btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.btnCatalogo = new FontAwesome.Sharp.IconButton();
            this.pSubMenuClientes = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnAgregarClientes = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.pSubMenuCitas = new System.Windows.Forms.Panel();
            this.btnVerCitas = new FontAwesome.Sharp.IconButton();
            this.btnAgendarCita = new FontAwesome.Sharp.IconButton();
            this.btnCitas = new FontAwesome.Sharp.IconButton();
            this.pLogo = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.pBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTituloHijo = new System.Windows.Forms.Label();
            this.btnHijoInicio = new FontAwesome.Sharp.IconPictureBox();
            this.pSombra = new System.Windows.Forms.Panel();
            this.pChildForm = new System.Windows.Forms.Panel();
            this.pSubMenuVta = new System.Windows.Forms.Panel();
            this.btnAgregarVta = new FontAwesome.Sharp.IconButton();
            this.btnVerVta = new FontAwesome.Sharp.IconButton();
            this.pMenuLateral.SuspendLayout();
            this.pSubMenuCatalogo.SuspendLayout();
            this.pSubMenuClientes.SuspendLayout();
            this.pSubMenuCitas.SuspendLayout();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.pBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHijoInicio)).BeginInit();
            this.pSubMenuVta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenuLateral
            // 
            this.pMenuLateral.AutoScroll = true;
            this.pMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pMenuLateral.Controls.Add(this.pSubMenuVta);
            this.pMenuLateral.Controls.Add(this.btnVentas);
            this.pMenuLateral.Controls.Add(this.pSubMenuCatalogo);
            this.pMenuLateral.Controls.Add(this.btnCatalogo);
            this.pMenuLateral.Controls.Add(this.pSubMenuClientes);
            this.pMenuLateral.Controls.Add(this.btnClientes);
            this.pMenuLateral.Controls.Add(this.pSubMenuCitas);
            this.pMenuLateral.Controls.Add(this.btnCitas);
            this.pMenuLateral.Controls.Add(this.pLogo);
            this.pMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pMenuLateral.Name = "pMenuLateral";
            this.pMenuLateral.Size = new System.Drawing.Size(200, 588);
            this.pMenuLateral.TabIndex = 0;
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVentas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.Salesforce;
            this.btnVentas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.IconSize = 32;
            this.btnVentas.Location = new System.Drawing.Point(0, 439);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Rotation = 0D;
            this.btnVentas.Size = new System.Drawing.Size(200, 40);
            this.btnVentas.TabIndex = 9;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // pSubMenuCatalogo
            // 
            this.pSubMenuCatalogo.Controls.Add(this.btnVerCatalogo);
            this.pSubMenuCatalogo.Controls.Add(this.btnAgregarProducto);
            this.pSubMenuCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubMenuCatalogo.Location = new System.Drawing.Point(0, 363);
            this.pSubMenuCatalogo.Name = "pSubMenuCatalogo";
            this.pSubMenuCatalogo.Size = new System.Drawing.Size(200, 76);
            this.pSubMenuCatalogo.TabIndex = 7;
            // 
            // btnVerCatalogo
            // 
            this.btnVerCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerCatalogo.FlatAppearance.BorderSize = 0;
            this.btnVerCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCatalogo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVerCatalogo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCatalogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVerCatalogo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVerCatalogo.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVerCatalogo.IconSize = 32;
            this.btnVerCatalogo.Location = new System.Drawing.Point(0, 40);
            this.btnVerCatalogo.Name = "btnVerCatalogo";
            this.btnVerCatalogo.Rotation = 0D;
            this.btnVerCatalogo.Size = new System.Drawing.Size(200, 30);
            this.btnVerCatalogo.TabIndex = 8;
            this.btnVerCatalogo.Text = "Ver Catálogo";
            this.btnVerCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerCatalogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerCatalogo.UseVisualStyleBackColor = true;
            this.btnVerCatalogo.Click += new System.EventHandler(this.btnVerCatalogo_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarProducto.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarProducto.IconSize = 32;
            this.btnAgregarProducto.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Rotation = 0D;
            this.btnAgregarProducto.Size = new System.Drawing.Size(200, 40);
            this.btnAgregarProducto.TabIndex = 7;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalogo.FlatAppearance.BorderSize = 0;
            this.btnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCatalogo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCatalogo.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnCatalogo.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCatalogo.IconSize = 32;
            this.btnCatalogo.Location = new System.Drawing.Point(0, 323);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Rotation = 0D;
            this.btnCatalogo.Size = new System.Drawing.Size(200, 40);
            this.btnCatalogo.TabIndex = 6;
            this.btnCatalogo.Text = "Catalogo";
            this.btnCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCatalogo.UseVisualStyleBackColor = true;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // pSubMenuClientes
            // 
            this.pSubMenuClientes.Controls.Add(this.iconButton2);
            this.pSubMenuClientes.Controls.Add(this.btnAgregarClientes);
            this.pSubMenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubMenuClientes.Location = new System.Drawing.Point(0, 244);
            this.pSubMenuClientes.Name = "pSubMenuClientes";
            this.pSubMenuClientes.Size = new System.Drawing.Size(200, 79);
            this.pSubMenuClientes.TabIndex = 4;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconSize = 32;
            this.iconButton2.Location = new System.Drawing.Point(0, 40);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(200, 36);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Ver Clientes";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnAgregarClientes
            // 
            this.btnAgregarClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarClientes.FlatAppearance.BorderSize = 0;
            this.btnAgregarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregarClientes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarClientes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarClientes.IconSize = 32;
            this.btnAgregarClientes.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarClientes.Name = "btnAgregarClientes";
            this.btnAgregarClientes.Rotation = 0D;
            this.btnAgregarClientes.Size = new System.Drawing.Size(200, 40);
            this.btnAgregarClientes.TabIndex = 2;
            this.btnAgregarClientes.Text = "Agregar Cliente";
            this.btnAgregarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarClientes.UseVisualStyleBackColor = true;
            this.btnAgregarClientes.Click += new System.EventHandler(this.btnAgregarClientes_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClientes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnClientes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.IconSize = 32;
            this.btnClientes.Location = new System.Drawing.Point(0, 204);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Rotation = 0D;
            this.btnClientes.Size = new System.Drawing.Size(200, 40);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pSubMenuCitas
            // 
            this.pSubMenuCitas.Controls.Add(this.btnVerCitas);
            this.pSubMenuCitas.Controls.Add(this.btnAgendarCita);
            this.pSubMenuCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubMenuCitas.Location = new System.Drawing.Point(0, 122);
            this.pSubMenuCitas.Name = "pSubMenuCitas";
            this.pSubMenuCitas.Size = new System.Drawing.Size(200, 82);
            this.pSubMenuCitas.TabIndex = 2;
            // 
            // btnVerCitas
            // 
            this.btnVerCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerCitas.FlatAppearance.BorderSize = 0;
            this.btnVerCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCitas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVerCitas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCitas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVerCitas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVerCitas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVerCitas.IconSize = 32;
            this.btnVerCitas.Location = new System.Drawing.Point(0, 40);
            this.btnVerCitas.Name = "btnVerCitas";
            this.btnVerCitas.Rotation = 0D;
            this.btnVerCitas.Size = new System.Drawing.Size(200, 40);
            this.btnVerCitas.TabIndex = 4;
            this.btnVerCitas.Text = "Ver Citas";
            this.btnVerCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerCitas.UseVisualStyleBackColor = true;
            this.btnVerCitas.Click += new System.EventHandler(this.btnEliminarCita_Click);
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgendarCita.FlatAppearance.BorderSize = 0;
            this.btnAgendarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendarCita.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgendarCita.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarCita.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgendarCita.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgendarCita.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAgendarCita.IconSize = 32;
            this.btnAgendarCita.Location = new System.Drawing.Point(0, 0);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Rotation = 0D;
            this.btnAgendarCita.Size = new System.Drawing.Size(200, 40);
            this.btnAgendarCita.TabIndex = 2;
            this.btnAgendarCita.Text = "Agendar Cita";
            this.btnAgendarCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendarCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgendarCita.UseVisualStyleBackColor = true;
            this.btnAgendarCita.Click += new System.EventHandler(this.btnAgendarCita_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCitas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCitas.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnCitas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCitas.IconSize = 32;
            this.btnCitas.Location = new System.Drawing.Point(0, 82);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Rotation = 0D;
            this.btnCitas.Size = new System.Drawing.Size(200, 40);
            this.btnCitas.TabIndex = 1;
            this.btnCitas.Text = "Citas";
            this.btnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCitas.UseVisualStyleBackColor = true;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click_1);
            // 
            // pLogo
            // 
            this.pLogo.Controls.Add(this.btnInicio);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(200, 82);
            this.pLogo.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(-3, 20);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(197, 59);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pBarraTitulo
            // 
            this.pBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pBarraTitulo.Controls.Add(this.lblTituloHijo);
            this.pBarraTitulo.Controls.Add(this.btnHijoInicio);
            this.pBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBarraTitulo.Location = new System.Drawing.Point(200, 0);
            this.pBarraTitulo.Name = "pBarraTitulo";
            this.pBarraTitulo.Size = new System.Drawing.Size(655, 44);
            this.pBarraTitulo.TabIndex = 1;
            this.pBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBarraTitulo_MouseDown_1);
            // 
            // lblTituloHijo
            // 
            this.lblTituloHijo.AutoSize = true;
            this.lblTituloHijo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHijo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTituloHijo.Location = new System.Drawing.Point(43, 14);
            this.lblTituloHijo.Name = "lblTituloHijo";
            this.lblTituloHijo.Size = new System.Drawing.Size(40, 20);
            this.lblTituloHijo.TabIndex = 1;
            this.lblTituloHijo.Text = "Inicio";
            // 
            // btnHijoInicio
            // 
            this.btnHijoInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnHijoInicio.ForeColor = System.Drawing.Color.Red;
            this.btnHijoInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHijoInicio.IconColor = System.Drawing.Color.Red;
            this.btnHijoInicio.Location = new System.Drawing.Point(6, 9);
            this.btnHijoInicio.Name = "btnHijoInicio";
            this.btnHijoInicio.Size = new System.Drawing.Size(32, 32);
            this.btnHijoInicio.TabIndex = 0;
            this.btnHijoInicio.TabStop = false;
            // 
            // pSombra
            // 
            this.pSombra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pSombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSombra.Location = new System.Drawing.Point(200, 44);
            this.pSombra.Name = "pSombra";
            this.pSombra.Size = new System.Drawing.Size(655, 10);
            this.pSombra.TabIndex = 2;
            // 
            // pChildForm
            // 
            this.pChildForm.BackColor = System.Drawing.Color.LightSlateGray;
            this.pChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pChildForm.Location = new System.Drawing.Point(200, 54);
            this.pChildForm.Name = "pChildForm";
            this.pChildForm.Size = new System.Drawing.Size(655, 534);
            this.pChildForm.TabIndex = 3;
            // 
            // pSubMenuVta
            // 
            this.pSubMenuVta.Controls.Add(this.btnVerVta);
            this.pSubMenuVta.Controls.Add(this.btnAgregarVta);
            this.pSubMenuVta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubMenuVta.Location = new System.Drawing.Point(0, 479);
            this.pSubMenuVta.Name = "pSubMenuVta";
            this.pSubMenuVta.Size = new System.Drawing.Size(200, 87);
            this.pSubMenuVta.TabIndex = 9;
            // 
            // btnAgregarVta
            // 
            this.btnAgregarVta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarVta.FlatAppearance.BorderSize = 0;
            this.btnAgregarVta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregarVta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarVta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarVta.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarVta.IconSize = 32;
            this.btnAgregarVta.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarVta.Name = "btnAgregarVta";
            this.btnAgregarVta.Rotation = 0D;
            this.btnAgregarVta.Size = new System.Drawing.Size(200, 40);
            this.btnAgregarVta.TabIndex = 10;
            this.btnAgregarVta.Text = "Agregar Venta";
            this.btnAgregarVta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarVta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarVta.UseVisualStyleBackColor = true;
            this.btnAgregarVta.Click += new System.EventHandler(this.btnAgregarVta_Click);
            // 
            // btnVerVta
            // 
            this.btnVerVta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerVta.FlatAppearance.BorderSize = 0;
            this.btnVerVta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerVta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVerVta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVerVta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVerVta.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVerVta.IconSize = 32;
            this.btnVerVta.Location = new System.Drawing.Point(0, 40);
            this.btnVerVta.Name = "btnVerVta";
            this.btnVerVta.Rotation = 0D;
            this.btnVerVta.Size = new System.Drawing.Size(200, 40);
            this.btnVerVta.TabIndex = 11;
            this.btnVerVta.Text = "Ver Ventas";
            this.btnVerVta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerVta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerVta.UseVisualStyleBackColor = true;
            this.btnVerVta.Click += new System.EventHandler(this.btnVerVta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 588);
            this.Controls.Add(this.pChildForm);
            this.Controls.Add(this.pSombra);
            this.Controls.Add(this.pBarraTitulo);
            this.Controls.Add(this.pMenuLateral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pMenuLateral.ResumeLayout(false);
            this.pSubMenuCatalogo.ResumeLayout(false);
            this.pSubMenuClientes.ResumeLayout(false);
            this.pSubMenuCitas.ResumeLayout(false);
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.pBarraTitulo.ResumeLayout(false);
            this.pBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHijoInicio)).EndInit();
            this.pSubMenuVta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenuLateral;
        private System.Windows.Forms.Panel pSubMenuCitas;
        private FontAwesome.Sharp.IconButton btnVerCitas;
        private FontAwesome.Sharp.IconButton btnAgendarCita;
        private FontAwesome.Sharp.IconButton btnCitas;
        private System.Windows.Forms.Panel pLogo;
        private FontAwesome.Sharp.IconButton btnCatalogo;
        private System.Windows.Forms.Panel pSubMenuClientes;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnAgregarClientes;
        private FontAwesome.Sharp.IconButton btnClientes;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Panel pBarraTitulo;
        private FontAwesome.Sharp.IconPictureBox btnHijoInicio;
        private System.Windows.Forms.Label lblTituloHijo;
        private System.Windows.Forms.Panel pSombra;
        private System.Windows.Forms.Panel pChildForm;
        private FontAwesome.Sharp.IconButton btnVentas;
        private System.Windows.Forms.Panel pSubMenuCatalogo;
        private FontAwesome.Sharp.IconButton btnVerCatalogo;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private System.Windows.Forms.Panel pSubMenuVta;
        private FontAwesome.Sharp.IconButton btnVerVta;
        private FontAwesome.Sharp.IconButton btnAgregarVta;
    }
}

