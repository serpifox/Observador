namespace ObservadorApp
{
    partial class Observador_Admi
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
            this.components = new System.ComponentModel.Container();
            this.tBCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.datGridMuestra = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tBCurp = new System.Windows.Forms.TextBox();
            this.lblCurp = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tBDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblZona = new System.Windows.Forms.Label();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.cmbAsociacion = new System.Windows.Forms.ComboBox();
            this.lblAsociacion = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.errorGeneral = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tBContrasenia = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.tBUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datGridMuestra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // tBCodigo
            // 
            this.tBCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBCodigo.Location = new System.Drawing.Point(204, 199);
            this.tBCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBCodigo.Name = "tBCodigo";
            this.tBCodigo.Size = new System.Drawing.Size(329, 26);
            this.tBCodigo.TabIndex = 22;
            this.tBCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBCodigo_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 197);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(186, 27);
            this.lblCodigo.TabIndex = 21;
            this.lblCodigo.Text = "Código de observador:";
            // 
            // datGridMuestra
            // 
            this.datGridMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridMuestra.Location = new System.Drawing.Point(12, 13);
            this.datGridMuestra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datGridMuestra.Name = "datGridMuestra";
            this.datGridMuestra.Size = new System.Drawing.Size(776, 140);
            this.datGridMuestra.TabIndex = 20;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMostrar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(539, 160);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(249, 26);
            this.btnMostrar.TabIndex = 39;
            this.btnMostrar.Text = "Mostrar todos los observadores";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBuscar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(539, 200);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 26);
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tBCurp
            // 
            this.tBCurp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBCurp.Location = new System.Drawing.Point(118, 253);
            this.tBCurp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBCurp.Name = "tBCurp";
            this.tBCurp.Size = new System.Drawing.Size(274, 26);
            this.tBCurp.TabIndex = 42;
            this.tBCurp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBCurp_KeyPress);
            // 
            // lblCurp
            // 
            this.lblCurp.AutoSize = true;
            this.lblCurp.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurp.Location = new System.Drawing.Point(12, 252);
            this.lblCurp.Name = "lblCurp";
            this.lblCurp.Size = new System.Drawing.Size(61, 27);
            this.lblCurp.TabIndex = 41;
            this.lblCurp.Text = "CURP:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Silver;
            this.btnLimpiar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(684, 200);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 26);
            this.btnLimpiar.TabIndex = 43;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // tBNombre
            // 
            this.tBNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNombre.Location = new System.Drawing.Point(118, 286);
            this.tBNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(274, 26);
            this.tBNombre.TabIndex = 45;
            this.tBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 286);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 27);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "Nombre:";
            // 
            // tBDireccion
            // 
            this.tBDireccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBDireccion.Location = new System.Drawing.Point(118, 320);
            this.tBDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBDireccion.Name = "tBDireccion";
            this.tBDireccion.Size = new System.Drawing.Size(274, 26);
            this.tBDireccion.TabIndex = 47;
            this.tBDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBDireccion_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(12, 320);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(90, 27);
            this.lblDireccion.TabIndex = 46;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZona.Location = new System.Drawing.Point(408, 253);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(56, 27);
            this.lblZona.TabIndex = 48;
            this.lblZona.Text = "Zona:";
            // 
            // cmbZona
            // 
            this.cmbZona.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Location = new System.Drawing.Point(514, 253);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(274, 26);
            this.cmbZona.TabIndex = 49;
            this.cmbZona.Click += new System.EventHandler(this.cmbZona_Click);
            this.cmbZona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbZona_KeyPress);
            // 
            // cmbAsociacion
            // 
            this.cmbAsociacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAsociacion.FormattingEnabled = true;
            this.cmbAsociacion.Location = new System.Drawing.Point(514, 287);
            this.cmbAsociacion.Name = "cmbAsociacion";
            this.cmbAsociacion.Size = new System.Drawing.Size(274, 26);
            this.cmbAsociacion.TabIndex = 51;
            this.cmbAsociacion.Click += new System.EventHandler(this.cmbAsociacion_Click);
            this.cmbAsociacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAsociacion_KeyPress);
            // 
            // lblAsociacion
            // 
            this.lblAsociacion.AutoSize = true;
            this.lblAsociacion.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsociacion.Location = new System.Drawing.Point(408, 286);
            this.lblAsociacion.Name = "lblAsociacion";
            this.lblAsociacion.Size = new System.Drawing.Size(100, 27);
            this.lblAsociacion.TabIndex = 50;
            this.lblAsociacion.Text = "Asociación:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRegistrar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(17, 391);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(139, 26);
            this.btnRegistrar.TabIndex = 52;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnRegistrar_KeyPress);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnModificar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(172, 391);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(139, 26);
            this.btnModificar.TabIndex = 53;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnModificar_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEliminar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(327, 391);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(139, 26);
            this.btnEliminar.TabIndex = 54;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnEliminar_KeyPress);
            // 
            // errorGeneral
            // 
            this.errorGeneral.ContainerControl = this;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Silver;
            this.btnRegresar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(574, 391);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(104, 26);
            this.btnRegresar.TabIndex = 74;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            this.btnRegresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnRegresar_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Silver;
            this.btnSalir.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(684, 391);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 26);
            this.btnSalir.TabIndex = 73;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSalir_KeyPress);
            // 
            // tBContrasenia
            // 
            this.tBContrasenia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBContrasenia.Location = new System.Drawing.Point(514, 354);
            this.tBContrasenia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBContrasenia.Name = "tBContrasenia";
            this.tBContrasenia.PasswordChar = '■';
            this.tBContrasenia.Size = new System.Drawing.Size(274, 26);
            this.tBContrasenia.TabIndex = 78;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(408, 354);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(104, 27);
            this.lblContrasenia.TabIndex = 77;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // tBUsuario
            // 
            this.tBUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBUsuario.Location = new System.Drawing.Point(514, 320);
            this.tBUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBUsuario.Name = "tBUsuario";
            this.tBUsuario.Size = new System.Drawing.Size(274, 26);
            this.tBUsuario.TabIndex = 76;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(408, 320);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(73, 27);
            this.lblUsuario.TabIndex = 75;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(14, 367);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 79;
            this.lblId.Visible = false;
            // 
            // Observador_Admi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tBContrasenia);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.tBUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbAsociacion);
            this.Controls.Add(this.lblAsociacion);
            this.Controls.Add(this.cmbZona);
            this.Controls.Add(this.lblZona);
            this.Controls.Add(this.tBDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.tBNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.tBCurp);
            this.Controls.Add(this.lblCurp);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.tBCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.datGridMuestra);
            this.Name = "Observador_Admi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Observador";
            ((System.ComponentModel.ISupportInitialize)(this.datGridMuestra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView datGridMuestra;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tBCurp;
        private System.Windows.Forms.Label lblCurp;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tBDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.ComboBox cmbAsociacion;
        private System.Windows.Forms.Label lblAsociacion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ErrorProvider errorGeneral;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox tBContrasenia;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox tBUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblId;
    }
}