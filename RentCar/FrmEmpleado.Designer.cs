namespace RentCar
{
    partial class FrmEmpleado
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lbFechaCreacion = new System.Windows.Forms.Label();
            this.dpTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.lbCombustible = new System.Windows.Forms.Label();
            this.dpTanda = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TANDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_INGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chcEstado = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chcEstado);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dpFechaCreacion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dpFechaIngreso);
            this.panel1.Controls.Add(this.lbFechaCreacion);
            this.panel1.Controls.Add(this.dpTipoEmpleado);
            this.panel1.Controls.Add(this.lbCombustible);
            this.panel1.Controls.Add(this.dpTanda);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtComision);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(561, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 66;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(249, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Text = "Estado";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Guarda";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(698, 178);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 63;
            this.btnClose.Text = "Volver";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRES,
            this.APELLIDOS,
            this.ID_TANDA,
            this.ID_TIPO_EMPLEADO,
            this.FECHA_INGRESO,
            this.ESTADO});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(923, 220);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // dpFechaCreacion
            // 
            this.dpFechaCreacion.Enabled = false;
            this.dpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaCreacion.Location = new System.Drawing.Point(736, 59);
            this.dpFechaCreacion.Name = "dpFechaCreacion";
            this.dpFechaCreacion.Size = new System.Drawing.Size(155, 20);
            this.dpFechaCreacion.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(636, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Fecha Creacion";
            // 
            // dpFechaIngreso
            // 
            this.dpFechaIngreso.Enabled = false;
            this.dpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaIngreso.Location = new System.Drawing.Point(736, 12);
            this.dpFechaIngreso.Name = "dpFechaIngreso";
            this.dpFechaIngreso.Size = new System.Drawing.Size(155, 20);
            this.dpFechaIngreso.TabIndex = 59;
            // 
            // lbFechaCreacion
            // 
            this.lbFechaCreacion.AutoSize = true;
            this.lbFechaCreacion.Location = new System.Drawing.Point(636, 19);
            this.lbFechaCreacion.Name = "lbFechaCreacion";
            this.lbFechaCreacion.Size = new System.Drawing.Size(75, 13);
            this.lbFechaCreacion.TabIndex = 58;
            this.lbFechaCreacion.Text = "Fecha Ingreso";
            // 
            // dpTipoEmpleado
            // 
            this.dpTipoEmpleado.FormattingEnabled = true;
            this.dpTipoEmpleado.Location = new System.Drawing.Point(461, 99);
            this.dpTipoEmpleado.Name = "dpTipoEmpleado";
            this.dpTipoEmpleado.Size = new System.Drawing.Size(155, 21);
            this.dpTipoEmpleado.TabIndex = 57;
            this.dpTipoEmpleado.SelectedIndexChanged += new System.EventHandler(this.dpCombustible_SelectedIndexChanged);
            // 
            // lbCombustible
            // 
            this.lbCombustible.AutoSize = true;
            this.lbCombustible.Location = new System.Drawing.Point(361, 104);
            this.lbCombustible.Name = "lbCombustible";
            this.lbCombustible.Size = new System.Drawing.Size(78, 13);
            this.lbCombustible.TabIndex = 56;
            this.lbCombustible.Text = "Tipo Empleado";
            this.lbCombustible.Click += new System.EventHandler(this.lbCombustible_Click);
            // 
            // dpTanda
            // 
            this.dpTanda.FormattingEnabled = true;
            this.dpTanda.Location = new System.Drawing.Point(461, 58);
            this.dpTanda.Name = "dpTanda";
            this.dpTanda.Size = new System.Drawing.Size(155, 21);
            this.dpTanda.TabIndex = 55;
            this.dpTanda.SelectedIndexChanged += new System.EventHandler(this.dpTipoVehiculo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Tanda";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(461, 12);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(155, 20);
            this.txtClave.TabIndex = 53;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.TextChanged += new System.EventHandler(this.txtNumeroPlaca_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Clave";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(118, 100);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(155, 20);
            this.txtComision.TabIndex = 51;
            this.txtComision.TextChanged += new System.EventHandler(this.txtNumeroMotor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Comision";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(118, 54);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(155, 20);
            this.txtApellidos.TabIndex = 49;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtNumeroChasis_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Apellidos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 47;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nombre";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NOMBRES
            // 
            this.NOMBRES.DataPropertyName = "NOMBRES";
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.ReadOnly = true;
            // 
            // APELLIDOS
            // 
            this.APELLIDOS.DataPropertyName = "APELLIDOS";
            this.APELLIDOS.HeaderText = "APELLIDOS";
            this.APELLIDOS.Name = "APELLIDOS";
            this.APELLIDOS.ReadOnly = true;
            // 
            // ID_TANDA
            // 
            this.ID_TANDA.DataPropertyName = "TANDA";
            this.ID_TANDA.HeaderText = "TANDA";
            this.ID_TANDA.Name = "ID_TANDA";
            this.ID_TANDA.ReadOnly = true;
            // 
            // ID_TIPO_EMPLEADO
            // 
            this.ID_TIPO_EMPLEADO.DataPropertyName = "TIPO_EMPLEADO";
            this.ID_TIPO_EMPLEADO.HeaderText = "TIPO EMPLEADO";
            this.ID_TIPO_EMPLEADO.Name = "ID_TIPO_EMPLEADO";
            this.ID_TIPO_EMPLEADO.ReadOnly = true;
            // 
            // FECHA_INGRESO
            // 
            this.FECHA_INGRESO.DataPropertyName = "FECHA_INGRESO";
            this.FECHA_INGRESO.HeaderText = "Fecha Ingreso";
            this.FECHA_INGRESO.Name = "FECHA_INGRESO";
            this.FECHA_INGRESO.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // chcEstado
            // 
            this.chcEstado.AutoSize = true;
            this.chcEstado.Location = new System.Drawing.Point(736, 107);
            this.chcEstado.Name = "chcEstado";
            this.chcEstado.Size = new System.Drawing.Size(59, 17);
            this.chcEstado.TabIndex = 67;
            this.chcEstado.Text = "Estado";
            this.chcEstado.UseVisualStyleBackColor = true;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEmpleado";
            this.Text = "FrmEmpleado";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox dpTipoEmpleado;
        private System.Windows.Forms.Label lbCombustible;
        private System.Windows.Forms.ComboBox dpTanda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpFechaCreacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dpFechaIngreso;
        private System.Windows.Forms.Label lbFechaCreacion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TANDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO_EMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_INGRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.CheckBox chcEstado;
    }
}