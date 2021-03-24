namespace sistema_para_Biblioteca
{
    partial class sistema
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sistema));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnlogin = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lenguaYLiteraturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matematicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lgebraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filosofiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.francesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secretariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliotecariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliotecariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosYObrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enciclopediasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escolaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lapizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadernoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosPorDiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesPorDiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosDisponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encriptarInformacionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otrosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnsalir = new System.Windows.Forms.ToolStripMenuItem();
            this.button6 = new System.Windows.Forms.Button();
            this.btnprestamo = new System.Windows.Forms.Button();
            this.btnseguridad = new System.Windows.Forms.Button();
            this.btninforme = new System.Windows.Forms.Button();
            this.btnlibros = new System.Windows.Forms.Button();
            this.btnusuario = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.librosToolStripMenuItem,
            this.autorizacionToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.btnsalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnlogin,
            this.helpToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.registroUsuarioToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.menuToolStripMenuItem.Text = "Usuario";
            // 
            // btnlogin
            // 
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(180, 22);
            this.btnlogin.Text = "Login";
            this.btnlogin.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // registroUsuarioToolStripMenuItem
            // 
            this.registroUsuarioToolStripMenuItem.Name = "registroUsuarioToolStripMenuItem";
            this.registroUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroUsuarioToolStripMenuItem.Text = "Registro usuario";
            this.registroUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registroUsuarioToolStripMenuItem_Click);
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordDeLibrosToolStripMenuItem,
            this.historiasToolStripMenuItem,
            this.lenguaYLiteraturaToolStripMenuItem,
            this.matematicasToolStripMenuItem,
            this.lgebraToolStripMenuItem,
            this.filosofiaToolStripMenuItem,
            this.inglesToolStripMenuItem,
            this.francesToolStripMenuItem,
            this.fisicaToolStripMenuItem});
            this.librosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.librosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // recordDeLibrosToolStripMenuItem
            // 
            this.recordDeLibrosToolStripMenuItem.Name = "recordDeLibrosToolStripMenuItem";
            this.recordDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.recordDeLibrosToolStripMenuItem.Text = "Record de libros";
            this.recordDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.recordDeLibrosToolStripMenuItem_Click);
            // 
            // historiasToolStripMenuItem
            // 
            this.historiasToolStripMenuItem.Name = "historiasToolStripMenuItem";
            this.historiasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.historiasToolStripMenuItem.Text = "Historias";
            this.historiasToolStripMenuItem.Click += new System.EventHandler(this.historiasToolStripMenuItem_Click);
            // 
            // lenguaYLiteraturaToolStripMenuItem
            // 
            this.lenguaYLiteraturaToolStripMenuItem.Name = "lenguaYLiteraturaToolStripMenuItem";
            this.lenguaYLiteraturaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.lenguaYLiteraturaToolStripMenuItem.Text = "Lengua y Literatura";
            this.lenguaYLiteraturaToolStripMenuItem.Click += new System.EventHandler(this.lenguaYLiteraturaToolStripMenuItem_Click);
            // 
            // matematicasToolStripMenuItem
            // 
            this.matematicasToolStripMenuItem.Name = "matematicasToolStripMenuItem";
            this.matematicasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.matematicasToolStripMenuItem.Text = "Matematicas";
            this.matematicasToolStripMenuItem.Click += new System.EventHandler(this.matematicasToolStripMenuItem_Click);
            // 
            // lgebraToolStripMenuItem
            // 
            this.lgebraToolStripMenuItem.Name = "lgebraToolStripMenuItem";
            this.lgebraToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.lgebraToolStripMenuItem.Text = "Algebra";
            this.lgebraToolStripMenuItem.Click += new System.EventHandler(this.lgebraToolStripMenuItem_Click);
            // 
            // filosofiaToolStripMenuItem
            // 
            this.filosofiaToolStripMenuItem.Name = "filosofiaToolStripMenuItem";
            this.filosofiaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.filosofiaToolStripMenuItem.Text = "Filosofia";
            this.filosofiaToolStripMenuItem.Click += new System.EventHandler(this.filosofiaToolStripMenuItem_Click);
            // 
            // inglesToolStripMenuItem
            // 
            this.inglesToolStripMenuItem.Name = "inglesToolStripMenuItem";
            this.inglesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.inglesToolStripMenuItem.Text = "Ingles ";
            this.inglesToolStripMenuItem.Click += new System.EventHandler(this.inglesToolStripMenuItem_Click);
            // 
            // francesToolStripMenuItem
            // 
            this.francesToolStripMenuItem.Name = "francesToolStripMenuItem";
            this.francesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.francesToolStripMenuItem.Text = "Frances";
            this.francesToolStripMenuItem.Click += new System.EventHandler(this.francesToolStripMenuItem_Click);
            // 
            // fisicaToolStripMenuItem
            // 
            this.fisicaToolStripMenuItem.Name = "fisicaToolStripMenuItem";
            this.fisicaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.fisicaToolStripMenuItem.Text = "Fisica";
            this.fisicaToolStripMenuItem.Click += new System.EventHandler(this.fisicaToolStripMenuItem_Click);
            // 
            // autorizacionToolStripMenuItem
            // 
            this.autorizacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.direccionToolStripMenuItem,
            this.secretariaToolStripMenuItem,
            this.bibliotecariaToolStripMenuItem,
            this.profesorToolStripMenuItem});
            this.autorizacionToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorizacionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.autorizacionToolStripMenuItem.Name = "autorizacionToolStripMenuItem";
            this.autorizacionToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.autorizacionToolStripMenuItem.Text = "Autorizacion";
            // 
            // direccionToolStripMenuItem
            // 
            this.direccionToolStripMenuItem.Name = "direccionToolStripMenuItem";
            this.direccionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.direccionToolStripMenuItem.Text = "Direccion";
            // 
            // secretariaToolStripMenuItem
            // 
            this.secretariaToolStripMenuItem.Name = "secretariaToolStripMenuItem";
            this.secretariaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.secretariaToolStripMenuItem.Text = "Secretaria";
            // 
            // bibliotecariaToolStripMenuItem
            // 
            this.bibliotecariaToolStripMenuItem.Name = "bibliotecariaToolStripMenuItem";
            this.bibliotecariaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.bibliotecariaToolStripMenuItem.Text = "Bibliotecaria";
            // 
            // profesorToolStripMenuItem
            // 
            this.profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            this.profesorToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.profesorToolStripMenuItem.Text = "profesor";
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bibliotecariosToolStripMenuItem,
            this.escolaresToolStripMenuItem});
            this.prestamosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prestamosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            // 
            // bibliotecariosToolStripMenuItem
            // 
            this.bibliotecariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosYObrasToolStripMenuItem,
            this.enciclopediasToolStripMenuItem,
            this.otrosToolStripMenuItem});
            this.bibliotecariosToolStripMenuItem.Name = "bibliotecariosToolStripMenuItem";
            this.bibliotecariosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.bibliotecariosToolStripMenuItem.Text = "bibliotecarios";
            // 
            // librosYObrasToolStripMenuItem
            // 
            this.librosYObrasToolStripMenuItem.Name = "librosYObrasToolStripMenuItem";
            this.librosYObrasToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.librosYObrasToolStripMenuItem.Text = "Libros y obras";
            this.librosYObrasToolStripMenuItem.Click += new System.EventHandler(this.librosYObrasToolStripMenuItem_Click);
            // 
            // enciclopediasToolStripMenuItem
            // 
            this.enciclopediasToolStripMenuItem.Name = "enciclopediasToolStripMenuItem";
            this.enciclopediasToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.enciclopediasToolStripMenuItem.Text = "enciclopedias";
            this.enciclopediasToolStripMenuItem.Click += new System.EventHandler(this.enciclopediasToolStripMenuItem_Click);
            // 
            // otrosToolStripMenuItem
            // 
            this.otrosToolStripMenuItem.Name = "otrosToolStripMenuItem";
            this.otrosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.otrosToolStripMenuItem.Text = "computadora";
            this.otrosToolStripMenuItem.Click += new System.EventHandler(this.otrosToolStripMenuItem_Click);
            // 
            // escolaresToolStripMenuItem
            // 
            this.escolaresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lapizToolStripMenuItem,
            this.cuadernoToolStripMenuItem,
            this.borradoresToolStripMenuItem,
            this.otrosToolStripMenuItem1});
            this.escolaresToolStripMenuItem.Name = "escolaresToolStripMenuItem";
            this.escolaresToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.escolaresToolStripMenuItem.Text = "escolares";
            // 
            // lapizToolStripMenuItem
            // 
            this.lapizToolStripMenuItem.Name = "lapizToolStripMenuItem";
            this.lapizToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.lapizToolStripMenuItem.Text = "lapiz";
            this.lapizToolStripMenuItem.Click += new System.EventHandler(this.lapizToolStripMenuItem_Click);
            // 
            // cuadernoToolStripMenuItem
            // 
            this.cuadernoToolStripMenuItem.Name = "cuadernoToolStripMenuItem";
            this.cuadernoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cuadernoToolStripMenuItem.Text = "cuaderno";
            this.cuadernoToolStripMenuItem.Click += new System.EventHandler(this.cuadernoToolStripMenuItem_Click);
            // 
            // borradoresToolStripMenuItem
            // 
            this.borradoresToolStripMenuItem.Name = "borradoresToolStripMenuItem";
            this.borradoresToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.borradoresToolStripMenuItem.Text = "borradores";
            this.borradoresToolStripMenuItem.Click += new System.EventHandler(this.borradoresToolStripMenuItem_Click);
            // 
            // otrosToolStripMenuItem1
            // 
            this.otrosToolStripMenuItem1.Name = "otrosToolStripMenuItem1";
            this.otrosToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.otrosToolStripMenuItem1.Text = "otros";
            this.otrosToolStripMenuItem1.Click += new System.EventHandler(this.otrosToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamosPorDiasToolStripMenuItem,
            this.clientesPorDiasToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.librosDisponiblesToolStripMenuItem});
            this.informesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // prestamosPorDiasToolStripMenuItem
            // 
            this.prestamosPorDiasToolStripMenuItem.Name = "prestamosPorDiasToolStripMenuItem";
            this.prestamosPorDiasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.prestamosPorDiasToolStripMenuItem.Text = "prestamos por dias";
            // 
            // clientesPorDiasToolStripMenuItem
            // 
            this.clientesPorDiasToolStripMenuItem.Name = "clientesPorDiasToolStripMenuItem";
            this.clientesPorDiasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.clientesPorDiasToolStripMenuItem.Text = "clientes por dias";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.usuariosToolStripMenuItem.Text = "usuarios ";
            // 
            // librosDisponiblesToolStripMenuItem
            // 
            this.librosDisponiblesToolStripMenuItem.Name = "librosDisponiblesToolStripMenuItem";
            this.librosDisponiblesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.librosDisponiblesToolStripMenuItem.Text = "libros disponibles";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.encriptarInformacionDeUsuariosToolStripMenuItem,
            this.otrosToolStripMenuItem2});
            this.seguridadToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seguridadToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.guardarToolStripMenuItem.Text = "guardar";
            // 
            // encriptarInformacionDeUsuariosToolStripMenuItem
            // 
            this.encriptarInformacionDeUsuariosToolStripMenuItem.Name = "encriptarInformacionDeUsuariosToolStripMenuItem";
            this.encriptarInformacionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.encriptarInformacionDeUsuariosToolStripMenuItem.Text = "encriptar informacion de usuarios";
            // 
            // otrosToolStripMenuItem2
            // 
            this.otrosToolStripMenuItem2.Name = "otrosToolStripMenuItem2";
            this.otrosToolStripMenuItem2.Size = new System.Drawing.Size(290, 22);
            this.otrosToolStripMenuItem2.Text = "otros";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.Red;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(49, 20);
            this.btnsalir.Text = "Salir";
            this.btnsalir.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MidnightBlue;
            this.button6.BackgroundImage = global::sistema_para_Biblioteca.Properties.Resources.salir;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.SpringGreen;
            this.button6.Location = new System.Drawing.Point(12, 487);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 81);
            this.button6.TabIndex = 6;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnprestamo
            // 
            this.btnprestamo.BackgroundImage = global::sistema_para_Biblioteca.Properties.Resources.prestamo_libros;
            this.btnprestamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnprestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprestamo.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnprestamo.Location = new System.Drawing.Point(12, 139);
            this.btnprestamo.Name = "btnprestamo";
            this.btnprestamo.Size = new System.Drawing.Size(109, 81);
            this.btnprestamo.TabIndex = 5;
            this.btnprestamo.Text = "Pretamos";
            this.btnprestamo.UseVisualStyleBackColor = true;
            this.btnprestamo.Click += new System.EventHandler(this.btnprestamo_Click);
            // 
            // btnseguridad
            // 
            this.btnseguridad.BackgroundImage = global::sistema_para_Biblioteca.Properties.Resources.seguridad;
            this.btnseguridad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnseguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseguridad.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnseguridad.Location = new System.Drawing.Point(12, 400);
            this.btnseguridad.Name = "btnseguridad";
            this.btnseguridad.Size = new System.Drawing.Size(109, 81);
            this.btnseguridad.TabIndex = 4;
            this.btnseguridad.Text = "Seguridad";
            this.btnseguridad.UseVisualStyleBackColor = true;
            this.btnseguridad.Click += new System.EventHandler(this.btnseguridad_Click);
            // 
            // btninforme
            // 
            this.btninforme.BackgroundImage = global::sistema_para_Biblioteca.Properties.Resources.informes;
            this.btninforme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btninforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninforme.ForeColor = System.Drawing.Color.SpringGreen;
            this.btninforme.Location = new System.Drawing.Point(12, 313);
            this.btninforme.Name = "btninforme";
            this.btninforme.Size = new System.Drawing.Size(109, 81);
            this.btninforme.TabIndex = 3;
            this.btninforme.Text = "Informes";
            this.btninforme.UseVisualStyleBackColor = true;
            this.btninforme.Click += new System.EventHandler(this.btninforme_Click);
            // 
            // btnlibros
            // 
            this.btnlibros.BackgroundImage = global::sistema_para_Biblioteca.Properties.Resources.Libros;
            this.btnlibros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlibros.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnlibros.Location = new System.Drawing.Point(12, 226);
            this.btnlibros.Name = "btnlibros";
            this.btnlibros.Size = new System.Drawing.Size(109, 81);
            this.btnlibros.TabIndex = 2;
            this.btnlibros.Text = "Libros";
            this.btnlibros.UseVisualStyleBackColor = true;
            this.btnlibros.Click += new System.EventHandler(this.btnlibros_Click);
            // 
            // btnusuario
            // 
            this.btnusuario.BackgroundImage = global::sistema_para_Biblioteca.Properties.Resources.usuario_biblioteca;
            this.btnusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuario.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnusuario.Location = new System.Drawing.Point(12, 52);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(109, 81);
            this.btnusuario.TabIndex = 1;
            this.btnusuario.Text = "Usuario";
            this.btnusuario.UseVisualStyleBackColor = true;
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.BackgroundImage = global::sistema_para_Biblioteca.Properties.Resources.Libros1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1006, 605);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnprestamo);
            this.Controls.Add(this.btnseguridad);
            this.Controls.Add(this.btninforme);
            this.Controls.Add(this.btnlibros);
            this.Controls.Add(this.btnusuario);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BIBLIOTECA EUGENIO MARIA DE HOSTOS";
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.Load += new System.EventHandler(this.sistema_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnlogin;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lenguaYLiteraturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matematicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lgebraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filosofiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inglesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem francesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secretariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliotecariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliotecariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosYObrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enciclopediasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escolaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lapizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadernoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otrosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosPorDiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesPorDiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosDisponiblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encriptarInformacionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otrosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnsalir;
        private System.Windows.Forms.Button btnlibros;
        private System.Windows.Forms.Button btninforme;
        private System.Windows.Forms.Button btnseguridad;
        private System.Windows.Forms.Button btnprestamo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnusuario;
        private System.Windows.Forms.ToolStripMenuItem registroUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordDeLibrosToolStripMenuItem;

    }
}

