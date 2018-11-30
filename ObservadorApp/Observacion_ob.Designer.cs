namespace ObservadorApp
{
    partial class Observacion_ob
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
            this.tBHora = new System.Windows.Forms.TextBox();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.cmbObservador = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblObservador = new System.Windows.Forms.Label();
            this.datGridMuestra = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.errorGeneral = new System.Windows.Forms.ErrorProvider(this.components);
            this.tBFecha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datGridMuestra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // tBHora
            // 
            this.tBHora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBHora.Location = new System.Drawing.Point(453, 293);
            this.tBHora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBHora.MaxLength = 5;
            this.tBHora.Name = "tBHora";
            this.tBHora.Size = new System.Drawing.Size(335, 26);
            this.tBHora.TabIndex = 129;
            this.tBHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBHora_KeyPress);
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbCantidad.Location = new System.Drawing.Point(123, 293);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(269, 26);
            this.cmbCantidad.TabIndex = 128;
            this.cmbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCantidad_KeyPress);
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(123, 252);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(269, 26);
            this.cmbEspecie.TabIndex = 127;
            this.cmbEspecie.Click += new System.EventHandler(this.cmbEspecie_Click);
            this.cmbEspecie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEspecie_KeyPress);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(448, 262);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(175, 27);
            this.lblHora.TabIndex = 126;
            this.lblHora.Text = "Hora de observación:";
            // 
            // cmbObservador
            // 
            this.cmbObservador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbObservador.FormattingEnabled = true;
            this.cmbObservador.Location = new System.Drawing.Point(123, 211);
            this.cmbObservador.Name = "cmbObservador";
            this.cmbObservador.Size = new System.Drawing.Size(269, 26);
            this.cmbObservador.TabIndex = 124;
            this.cmbObservador.Click += new System.EventHandler(this.cmbObservador_Click);
            this.cmbObservador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbObservador_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Silver;
            this.btnSalir.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(684, 404);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 26);
            this.btnSalir.TabIndex = 122;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSalir_KeyPress);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRegistrar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(17, 404);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(139, 26);
            this.btnRegistrar.TabIndex = 119;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnRegistrar_KeyPress);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(448, 209);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(184, 27);
            this.lblFecha.TabIndex = 118;
            this.lblFecha.Text = "Fecha de observación:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(12, 292);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(87, 27);
            this.lblCantidad.TabIndex = 117;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(12, 251);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(74, 27);
            this.lblEspecie.TabIndex = 116;
            this.lblEspecie.Text = "Especie:";
            // 
            // lblObservador
            // 
            this.lblObservador.AutoSize = true;
            this.lblObservador.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservador.Location = new System.Drawing.Point(12, 209);
            this.lblObservador.Name = "lblObservador";
            this.lblObservador.Size = new System.Drawing.Size(105, 27);
            this.lblObservador.TabIndex = 114;
            this.lblObservador.Text = "Observador:";
            // 
            // datGridMuestra
            // 
            this.datGridMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridMuestra.Location = new System.Drawing.Point(12, 13);
            this.datGridMuestra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datGridMuestra.Name = "datGridMuestra";
            this.datGridMuestra.Size = new System.Drawing.Size(776, 140);
            this.datGridMuestra.TabIndex = 109;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMostrar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(539, 160);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(249, 26);
            this.btnMostrar.TabIndex = 112;
            this.btnMostrar.Text = "Mostrar todas mis observaciones";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            this.btnMostrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnMostrar_KeyPress);
            // 
            // errorGeneral
            // 
            this.errorGeneral.ContainerControl = this;
            // 
            // tBFecha
            // 
            this.tBFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBFecha.Location = new System.Drawing.Point(453, 232);
            this.tBFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBFecha.Name = "tBFecha";
            this.tBFecha.Size = new System.Drawing.Size(335, 26);
            this.tBFecha.TabIndex = 130;
            this.tBFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBFecha_KeyPress);
            // 
            // Observacion_ob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBFecha);
            this.Controls.Add(this.tBHora);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.cmbEspecie);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.cmbObservador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblObservador);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.datGridMuestra);
            this.Name = "Observacion_ob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Observación";
            ((System.ComponentModel.ISupportInitialize)(this.datGridMuestra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBHora;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cmbObservador;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblObservador;
        private System.Windows.Forms.DataGridView datGridMuestra;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ErrorProvider errorGeneral;
        private System.Windows.Forms.TextBox tBFecha;
    }
}