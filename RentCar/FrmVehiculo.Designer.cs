namespace RentCar
{
    partial class FrmVehiculo
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
            this.gridVehiculo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO_CHASIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO_PLACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_CREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNumeroChasis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroMotor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroPlaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dpTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.dpModeloVehiculo = new System.Windows.Forms.ComboBox();
            this.lbFechaCreacion = new System.Windows.Forms.Label();
            this.dpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.dpCombustible = new System.Windows.Forms.ComboBox();
            this.lbCombustible = new System.Windows.Forms.Label();
            this.chcEstado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // gridVehiculo
            // 
            this.gridVehiculo.AllowUserToAddRows = false;
            this.gridVehiculo.AllowUserToDeleteRows = false;
            this.gridVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.NUMERO_CHASIS,
            this.NUMERO_PLACA,
            this.MARCA,
            this.MODELO,
            this.FECHA_CREACION,
            this.ESTADO});
            this.gridVehiculo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridVehiculo.Location = new System.Drawing.Point(0, 227);
            this.gridVehiculo.Name = "gridVehiculo";
            this.gridVehiculo.ReadOnly = true;
            this.gridVehiculo.Size = new System.Drawing.Size(905, 223);
            this.gridVehiculo.TabIndex = 23;
            this.gridVehiculo.DoubleClick += new System.EventHandler(this.gridTipoCliente_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "DESCRIPCION";
            this.Nombre.HeaderText = "Descripcion";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // NUMERO_CHASIS
            // 
            this.NUMERO_CHASIS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NUMERO_CHASIS.DataPropertyName = "NUMERO_CHASIS";
            this.NUMERO_CHASIS.HeaderText = "Numero Chasis";
            this.NUMERO_CHASIS.Name = "NUMERO_CHASIS";
            this.NUMERO_CHASIS.ReadOnly = true;
            // 
            // NUMERO_PLACA
            // 
            this.NUMERO_PLACA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NUMERO_PLACA.DataPropertyName = "NUMERO_PLACA";
            this.NUMERO_PLACA.HeaderText = "Numero Placa";
            this.NUMERO_PLACA.Name = "NUMERO_PLACA";
            this.NUMERO_PLACA.ReadOnly = true;
            // 
            // MARCA
            // 
            this.MARCA.DataPropertyName = "MARCA";
            this.MARCA.HeaderText = "Tipo Vehiculo";
            this.MARCA.Name = "MARCA";
            this.MARCA.ReadOnly = true;
            // 
            // MODELO
            // 
            this.MODELO.DataPropertyName = "MODELO";
            this.MODELO.HeaderText = "Modelo Vehiculo";
            this.MODELO.Name = "MODELO";
            this.MODELO.ReadOnly = true;
            // 
            // FECHA_CREACION
            // 
            this.FECHA_CREACION.DataPropertyName = "FECHA_CREACION";
            this.FECHA_CREACION.HeaderText = "Fecha de Creacion";
            this.FECHA_CREACION.Name = "FECHA_CREACION";
            this.FECHA_CREACION.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "Estado";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(471, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 22;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(159, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(38, 173);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Guarda";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Descripcion";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(608, 171);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Volver";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNumeroChasis
            // 
            this.txtNumeroChasis.Location = new System.Drawing.Point(109, 47);
            this.txtNumeroChasis.Name = "txtNumeroChasis";
            this.txtNumeroChasis.Size = new System.Drawing.Size(155, 20);
            this.txtNumeroChasis.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Número Chasis";
            // 
            // txtNumeroMotor
            // 
            this.txtNumeroMotor.Location = new System.Drawing.Point(109, 93);
            this.txtNumeroMotor.Name = "txtNumeroMotor";
            this.txtNumeroMotor.Size = new System.Drawing.Size(155, 20);
            this.txtNumeroMotor.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Número Motor";
            // 
            // txtNumeroPlaca
            // 
            this.txtNumeroPlaca.Location = new System.Drawing.Point(452, 5);
            this.txtNumeroPlaca.Name = "txtNumeroPlaca";
            this.txtNumeroPlaca.Size = new System.Drawing.Size(155, 20);
            this.txtNumeroPlaca.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Número Placa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tipo Vehículo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(626, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Modelo Vehículo";
            // 
            // dpTipoVehiculo
            // 
            this.dpTipoVehiculo.FormattingEnabled = true;
            this.dpTipoVehiculo.Location = new System.Drawing.Point(452, 51);
            this.dpTipoVehiculo.Name = "dpTipoVehiculo";
            this.dpTipoVehiculo.Size = new System.Drawing.Size(155, 21);
            this.dpTipoVehiculo.TabIndex = 38;
            // 
            // dpModeloVehiculo
            // 
            this.dpModeloVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dpModeloVehiculo.FormattingEnabled = true;
            this.dpModeloVehiculo.Location = new System.Drawing.Point(726, 4);
            this.dpModeloVehiculo.Name = "dpModeloVehiculo";
            this.dpModeloVehiculo.Size = new System.Drawing.Size(155, 21);
            this.dpModeloVehiculo.TabIndex = 39;
            this.dpModeloVehiculo.SelectedIndexChanged += new System.EventHandler(this.dpModeloVehiculo_SelectedIndexChanged);
            // 
            // lbFechaCreacion
            // 
            this.lbFechaCreacion.AutoSize = true;
            this.lbFechaCreacion.Location = new System.Drawing.Point(626, 55);
            this.lbFechaCreacion.Name = "lbFechaCreacion";
            this.lbFechaCreacion.Size = new System.Drawing.Size(37, 13);
            this.lbFechaCreacion.TabIndex = 42;
            this.lbFechaCreacion.Text = "Fecha";
            // 
            // dpFechaCreacion
            // 
            this.dpFechaCreacion.Enabled = false;
            this.dpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaCreacion.Location = new System.Drawing.Point(726, 48);
            this.dpFechaCreacion.Name = "dpFechaCreacion";
            this.dpFechaCreacion.Size = new System.Drawing.Size(155, 20);
            this.dpFechaCreacion.TabIndex = 43;
            // 
            // dpCombustible
            // 
            this.dpCombustible.FormattingEnabled = true;
            this.dpCombustible.Location = new System.Drawing.Point(452, 92);
            this.dpCombustible.Name = "dpCombustible";
            this.dpCombustible.Size = new System.Drawing.Size(155, 21);
            this.dpCombustible.TabIndex = 45;
            // 
            // lbCombustible
            // 
            this.lbCombustible.AutoSize = true;
            this.lbCombustible.Location = new System.Drawing.Point(352, 97);
            this.lbCombustible.Name = "lbCombustible";
            this.lbCombustible.Size = new System.Drawing.Size(64, 13);
            this.lbCombustible.TabIndex = 44;
            this.lbCombustible.Text = "Combustible";
            // 
            // chcEstado
            // 
            this.chcEstado.AutoSize = true;
            this.chcEstado.Location = new System.Drawing.Point(726, 99);
            this.chcEstado.Name = "chcEstado";
            this.chcEstado.Size = new System.Drawing.Size(59, 17);
            this.chcEstado.TabIndex = 46;
            this.chcEstado.Text = "Estado";
            this.chcEstado.UseVisualStyleBackColor = true;
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.chcEstado);
            this.Controls.Add(this.dpCombustible);
            this.Controls.Add(this.lbCombustible);
            this.Controls.Add(this.dpFechaCreacion);
            this.Controls.Add(this.lbFechaCreacion);
            this.Controls.Add(this.dpModeloVehiculo);
            this.Controls.Add(this.dpTipoVehiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumeroPlaca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumeroMotor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroChasis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridVehiculo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmVehiculo";
            this.Text = "FrmTipo_Cliente";
            this.Load += new System.EventHandler(this.FrmVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridVehiculo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNumeroChasis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroMotor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroPlaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dpTipoVehiculo;
        private System.Windows.Forms.ComboBox dpModeloVehiculo;
        private System.Windows.Forms.Label lbFechaCreacion;
        private System.Windows.Forms.DateTimePicker dpFechaCreacion;
        private System.Windows.Forms.ComboBox dpCombustible;
        private System.Windows.Forms.Label lbCombustible;
        private System.Windows.Forms.CheckBox chcEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_CHASIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_PLACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CREACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}