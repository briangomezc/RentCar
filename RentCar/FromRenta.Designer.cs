namespace RentCar
{
    partial class FromRenta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridRenta = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSPECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMontoDia = new System.Windows.Forms.TextBox();
            this.btnInspeccion = new System.Windows.Forms.Button();
            this.dpFechaRenta = new System.Windows.Forms.DateTimePicker();
            this.lbCombustible = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dpCliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dpEmpleado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dpVehiculo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidadDias = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lbFechaCreacion = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRenta)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridRenta);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 491);
            this.panel1.TabIndex = 0;
            // 
            // gridRenta
            // 
            this.gridRenta.AllowUserToAddRows = false;
            this.gridRenta.AllowUserToDeleteRows = false;
            this.gridRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.INSPECCION});
            this.gridRenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridRenta.Location = new System.Drawing.Point(0, 271);
            this.gridRenta.Name = "gridRenta";
            this.gridRenta.ReadOnly = true;
            this.gridRenta.Size = new System.Drawing.Size(1068, 220);
            this.gridRenta.TabIndex = 96;
            this.gridRenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRenta_CellContentClick);
            this.gridRenta.DoubleClick += new System.EventHandler(this.gridRenta_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // INSPECCION
            // 
            this.INSPECCION.HeaderText = "Inspeccion";
            this.INSPECCION.Name = "INSPECCION";
            this.INSPECCION.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtMontoDia);
            this.panel2.Controls.Add(this.btnInspeccion);
            this.panel2.Controls.Add(this.dpFechaRenta);
            this.panel2.Controls.Add(this.lbCombustible);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dpCliente);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dpEmpleado);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dpVehiculo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.txtCantidadDias);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.dpDevolucion);
            this.panel2.Controls.Add(this.lbFechaCreacion);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 495);
            this.panel2.TabIndex = 85;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 103;
            this.label9.Text = "Monto por Dias";
            // 
            // txtMontoDia
            // 
            this.txtMontoDia.Location = new System.Drawing.Point(461, 114);
            this.txtMontoDia.Name = "txtMontoDia";
            this.txtMontoDia.Size = new System.Drawing.Size(155, 20);
            this.txtMontoDia.TabIndex = 102;
            this.txtMontoDia.TextChanged += new System.EventHandler(this.txtMontoDia_TextChanged);
            this.txtMontoDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoDia_KeyPress);
            // 
            // btnInspeccion
            // 
            this.btnInspeccion.Location = new System.Drawing.Point(812, 152);
            this.btnInspeccion.Name = "btnInspeccion";
            this.btnInspeccion.Size = new System.Drawing.Size(141, 23);
            this.btnInspeccion.TabIndex = 101;
            this.btnInspeccion.Text = "Crear Inspeccion";
            this.btnInspeccion.UseVisualStyleBackColor = true;
            // 
            // dpFechaRenta
            // 
            this.dpFechaRenta.Enabled = false;
            this.dpFechaRenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaRenta.Location = new System.Drawing.Point(461, 17);
            this.dpFechaRenta.Name = "dpFechaRenta";
            this.dpFechaRenta.Size = new System.Drawing.Size(155, 20);
            this.dpFechaRenta.TabIndex = 100;
            // 
            // lbCombustible
            // 
            this.lbCombustible.AutoSize = true;
            this.lbCombustible.Location = new System.Drawing.Point(664, 64);
            this.lbCombustible.Name = "lbCombustible";
            this.lbCombustible.Size = new System.Drawing.Size(63, 13);
            this.lbCombustible.TabIndex = 95;
            this.lbCombustible.Text = "Descripcion";
            this.lbCombustible.Click += new System.EventHandler(this.lbCombustible_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Cantidad de Dias";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 99;
            this.label8.Text = "Fecha Renta";
            // 
            // dpCliente
            // 
            this.dpCliente.FormattingEnabled = true;
            this.dpCliente.Location = new System.Drawing.Point(155, 116);
            this.dpCliente.Name = "dpCliente";
            this.dpCliente.Size = new System.Drawing.Size(155, 21);
            this.dpCliente.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "Tipo Cliente";
            // 
            // dpEmpleado
            // 
            this.dpEmpleado.FormattingEnabled = true;
            this.dpEmpleado.Location = new System.Drawing.Point(155, 63);
            this.dpEmpleado.Name = "dpEmpleado";
            this.dpEmpleado.Size = new System.Drawing.Size(155, 21);
            this.dpEmpleado.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "Tipo Empleado";
            // 
            // dpVehiculo
            // 
            this.dpVehiculo.FormattingEnabled = true;
            this.dpVehiculo.Location = new System.Drawing.Point(155, 17);
            this.dpVehiculo.Name = "dpVehiculo";
            this.dpVehiculo.Size = new System.Drawing.Size(155, 21);
            this.dpVehiculo.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Tipo Vehiculo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(771, 57);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(219, 75);
            this.txtDescripcion.TabIndex = 91;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtLimiteCredito_TextChanged);
            // 
            // txtCantidadDias
            // 
            this.txtCantidadDias.Location = new System.Drawing.Point(461, 65);
            this.txtCantidadDias.Name = "txtCantidadDias";
            this.txtCantidadDias.Size = new System.Drawing.Size(155, 20);
            this.txtCantidadDias.TabIndex = 85;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(559, 197);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 88;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(247, 199);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 87;
            this.btnDelete.Text = "Estado";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(126, 199);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 86;
            this.btnSave.Text = "Guarda";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(696, 196);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 85;
            this.btnClose.Text = "Volver";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dpDevolucion
            // 
            this.dpDevolucion.Enabled = false;
            this.dpDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDevolucion.Location = new System.Drawing.Point(771, 17);
            this.dpDevolucion.Name = "dpDevolucion";
            this.dpDevolucion.Size = new System.Drawing.Size(155, 20);
            this.dpDevolucion.TabIndex = 81;
            this.dpDevolucion.ValueChanged += new System.EventHandler(this.dpDevolucion_ValueChanged);
            // 
            // lbFechaCreacion
            // 
            this.lbFechaCreacion.AutoSize = true;
            this.lbFechaCreacion.Location = new System.Drawing.Point(664, 20);
            this.lbFechaCreacion.Name = "lbFechaCreacion";
            this.lbFechaCreacion.Size = new System.Drawing.Size(94, 13);
            this.lbFechaCreacion.TabIndex = 80;
            this.lbFechaCreacion.Text = "Fecha Devolucion";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(118, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 20);
            this.txtEmail.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Email";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(118, 44);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(155, 20);
            this.txtApellidos.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Apellidos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 105;
            this.label10.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(461, 155);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(155, 20);
            this.txtTotal.TabIndex = 104;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(878, 199);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 106;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FromRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 491);
            this.Controls.Add(this.panel1);
            this.Name = "FromRenta";
            this.Text = "FromRenta";
            this.Load += new System.EventHandler(this.FromRenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRenta)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridRenta;
        private System.Windows.Forms.Label lbCombustible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCantidadDias;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dpDevolucion;
        private System.Windows.Forms.Label lbFechaCreacion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpFechaRenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox dpCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dpEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dpVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEHICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSPECCION;
        private System.Windows.Forms.Button btnInspeccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMontoDia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnNuevo;
    }
}