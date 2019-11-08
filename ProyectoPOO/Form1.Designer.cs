namespace ProyectoPOO
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
            this.components = new System.ComponentModel.Container();
            this.butRegistrarUsuario = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.labTitulo = new System.Windows.Forms.Label();
            this.labNombreArticulo = new System.Windows.Forms.Label();
            this.labDireccion = new System.Windows.Forms.Label();
            this.labIdentificacion = new System.Windows.Forms.Label();
            this.labNombreEmpleado = new System.Windows.Forms.Label();
            this.butSalir = new System.Windows.Forms.Button();
            this.butRegistrar = new System.Windows.Forms.Button();
            this.labArticulo = new System.Windows.Forms.Label();
            this.cboArticulo = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // butRegistrarUsuario
            // 
            this.butRegistrarUsuario.Location = new System.Drawing.Point(395, 293);
            this.butRegistrarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butRegistrarUsuario.Name = "butRegistrarUsuario";
            this.butRegistrarUsuario.Size = new System.Drawing.Size(277, 28);
            this.butRegistrarUsuario.TabIndex = 31;
            this.butRegistrarUsuario.Text = "Registrar usuario";
            this.butRegistrarUsuario.UseVisualStyleBackColor = true;
            this.butRegistrarUsuario.Click += new System.EventHandler(this.ButRegistrarUsuario_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(552, 223);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(121, 22);
            this.txtTitulo.TabIndex = 30;
            this.txtTitulo.Validated += new System.EventHandler(this.TxtTitulo_Validated);
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new System.Drawing.Point(552, 181);
            this.txtNombreArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(121, 22);
            this.txtNombreArticulo.TabIndex = 29;
            this.txtNombreArticulo.Validated += new System.EventHandler(this.TxtNombreArticulo_Validated);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(552, 139);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 22);
            this.txtDireccion.TabIndex = 28;
            this.txtDireccion.Validated += new System.EventHandler(this.TxtDireccion_Validated);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(552, 106);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(121, 22);
            this.txtIdentificacion.TabIndex = 27;
            this.txtIdentificacion.Validated += new System.EventHandler(this.TxtIdentificacion_Validated);
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(552, 68);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(121, 22);
            this.txtNombreEmpleado.TabIndex = 26;
            this.txtNombreEmpleado.Validated += new System.EventHandler(this.TxtNombreEmpleado_Validated);
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Location = new System.Drawing.Point(392, 223);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(43, 17);
            this.labTitulo.TabIndex = 25;
            this.labTitulo.Text = "Titulo";
            // 
            // labNombreArticulo
            // 
            this.labNombreArticulo.AutoSize = true;
            this.labNombreArticulo.Location = new System.Drawing.Point(392, 181);
            this.labNombreArticulo.Name = "labNombreArticulo";
            this.labNombreArticulo.Size = new System.Drawing.Size(109, 17);
            this.labNombreArticulo.TabIndex = 24;
            this.labNombreArticulo.Text = "Nombre Articulo";
            // 
            // labDireccion
            // 
            this.labDireccion.AutoSize = true;
            this.labDireccion.Location = new System.Drawing.Point(392, 139);
            this.labDireccion.Name = "labDireccion";
            this.labDireccion.Size = new System.Drawing.Size(67, 17);
            this.labDireccion.TabIndex = 23;
            this.labDireccion.Text = "Direccion";
            // 
            // labIdentificacion
            // 
            this.labIdentificacion.AutoSize = true;
            this.labIdentificacion.Location = new System.Drawing.Point(392, 106);
            this.labIdentificacion.Name = "labIdentificacion";
            this.labIdentificacion.Size = new System.Drawing.Size(90, 17);
            this.labIdentificacion.TabIndex = 22;
            this.labIdentificacion.Text = "Identificacion";
            // 
            // labNombreEmpleado
            // 
            this.labNombreEmpleado.AutoSize = true;
            this.labNombreEmpleado.Location = new System.Drawing.Point(392, 70);
            this.labNombreEmpleado.Name = "labNombreEmpleado";
            this.labNombreEmpleado.Size = new System.Drawing.Size(125, 17);
            this.labNombreEmpleado.TabIndex = 21;
            this.labNombreEmpleado.Text = "Nombre Empleado";
            // 
            // butSalir
            // 
            this.butSalir.Location = new System.Drawing.Point(489, 447);
            this.butSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butSalir.Name = "butSalir";
            this.butSalir.Size = new System.Drawing.Size(75, 39);
            this.butSalir.TabIndex = 20;
            this.butSalir.Text = "Salir";
            this.butSalir.UseVisualStyleBackColor = true;
            this.butSalir.Click += new System.EventHandler(this.ButSalir_Click);
            // 
            // butRegistrar
            // 
            this.butRegistrar.Location = new System.Drawing.Point(456, 401);
            this.butRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butRegistrar.Name = "butRegistrar";
            this.butRegistrar.Size = new System.Drawing.Size(144, 39);
            this.butRegistrar.TabIndex = 19;
            this.butRegistrar.Text = "Calcular comision";
            this.butRegistrar.UseVisualStyleBackColor = true;
            this.butRegistrar.Click += new System.EventHandler(this.ButRegistrar_Click);
            // 
            // labArticulo
            // 
            this.labArticulo.AutoSize = true;
            this.labArticulo.Location = new System.Drawing.Point(392, 362);
            this.labArticulo.Name = "labArticulo";
            this.labArticulo.Size = new System.Drawing.Size(107, 17);
            this.labArticulo.TabIndex = 18;
            this.labArticulo.Text = "Tipo de Articulo";
            // 
            // cboArticulo
            // 
            this.cboArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Items.AddRange(new object[] {
            "CLibro",
            "ARevista",
            "ACapitulo"});
            this.cboArticulo.Location = new System.Drawing.Point(552, 354);
            this.cboArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(121, 24);
            this.cboArticulo.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.butRegistrarUsuario);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNombreArticulo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.labNombreArticulo);
            this.Controls.Add(this.labDireccion);
            this.Controls.Add(this.labIdentificacion);
            this.Controls.Add(this.labNombreEmpleado);
            this.Controls.Add(this.butSalir);
            this.Controls.Add(this.butRegistrar);
            this.Controls.Add(this.labArticulo);
            this.Controls.Add(this.cboArticulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butRegistrarUsuario;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Label labNombreArticulo;
        private System.Windows.Forms.Label labDireccion;
        private System.Windows.Forms.Label labIdentificacion;
        private System.Windows.Forms.Label labNombreEmpleado;
        private System.Windows.Forms.Button butSalir;
        private System.Windows.Forms.Button butRegistrar;
        private System.Windows.Forms.Label labArticulo;
        private System.Windows.Forms.ComboBox cboArticulo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

