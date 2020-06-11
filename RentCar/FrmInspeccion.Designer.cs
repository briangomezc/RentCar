namespace RentCar
{
    partial class FrmInspeccion
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.chcTieneRoturaCristal = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chcTieneGato = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chcTieneGoma = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chcRayadura = new System.Windows.Forms.CheckBox();
            this.dpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dpEstadoInspeccion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dpCantidaCombustible = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dpEmpleado = new System.Windows.Forms.ComboBox();
            this.dpCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpVehiculo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chcLlantaDerechaD = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chcLlantaIzquierdaD = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chcLlantaDerechaT = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chcLlantaIzquierdaT = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.chcLlantaIzquierdaT);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.chcLlantaDerechaT);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.chcLlantaIzquierdaD);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.chcLlantaDerechaD);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.chcTieneRoturaCristal);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.chcTieneGato);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.chcTieneGoma);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.chcRayadura);
            this.panel1.Controls.Add(this.dpFechaCreacion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dpEstadoInspeccion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dpCantidaCombustible);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dpEmpleado);
            this.panel1.Controls.Add(this.dpCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dpVehiculo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 632);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(179, 581);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 112;
            this.btnCerrar.Text = "Volver";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(74, 581);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 111;
            this.btnGuardar.Text = "Crear";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 110;
            this.label10.Text = "Tiene Rotura Cristal";
            // 
            // chcTieneRoturaCristal
            // 
            this.chcTieneRoturaCristal.AutoSize = true;
            this.chcTieneRoturaCristal.Location = new System.Drawing.Point(134, 343);
            this.chcTieneRoturaCristal.Name = "chcTieneRoturaCristal";
            this.chcTieneRoturaCristal.Size = new System.Drawing.Size(15, 14);
            this.chcTieneRoturaCristal.TabIndex = 109;
            this.chcTieneRoturaCristal.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 108;
            this.label9.Text = "Tiene Gato";
            // 
            // chcTieneGato
            // 
            this.chcTieneGato.AutoSize = true;
            this.chcTieneGato.Location = new System.Drawing.Point(134, 309);
            this.chcTieneGato.Name = "chcTieneGato";
            this.chcTieneGato.Size = new System.Drawing.Size(15, 14);
            this.chcTieneGato.TabIndex = 107;
            this.chcTieneGato.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 106;
            this.label7.Text = "Tiene Goma";
            // 
            // chcTieneGoma
            // 
            this.chcTieneGoma.AutoSize = true;
            this.chcTieneGoma.Location = new System.Drawing.Point(134, 272);
            this.chcTieneGoma.Name = "chcTieneGoma";
            this.chcTieneGoma.Size = new System.Drawing.Size(15, 14);
            this.chcTieneGoma.TabIndex = 105;
            this.chcTieneGoma.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 104;
            this.label6.Text = "Rayadura";
            // 
            // chcRayadura
            // 
            this.chcRayadura.AutoSize = true;
            this.chcRayadura.Location = new System.Drawing.Point(134, 232);
            this.chcRayadura.Name = "chcRayadura";
            this.chcRayadura.Size = new System.Drawing.Size(15, 14);
            this.chcRayadura.TabIndex = 103;
            this.chcRayadura.UseVisualStyleBackColor = true;
            // 
            // dpFechaCreacion
            // 
            this.dpFechaCreacion.Enabled = false;
            this.dpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaCreacion.Location = new System.Drawing.Point(134, 485);
            this.dpFechaCreacion.Name = "dpFechaCreacion";
            this.dpFechaCreacion.Size = new System.Drawing.Size(169, 20);
            this.dpFechaCreacion.TabIndex = 102;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 101;
            this.label8.Text = "Fecha Creacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estado Inpeccion";
            // 
            // dpEstadoInspeccion
            // 
            this.dpEstadoInspeccion.FormattingEnabled = true;
            this.dpEstadoInspeccion.Location = new System.Drawing.Point(134, 522);
            this.dpEstadoInspeccion.Name = "dpEstadoInspeccion";
            this.dpEstadoInspeccion.Size = new System.Drawing.Size(169, 21);
            this.dpEstadoInspeccion.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad Combustible";
            // 
            // dpCantidaCombustible
            // 
            this.dpCantidaCombustible.FormattingEnabled = true;
            this.dpCantidaCombustible.Location = new System.Drawing.Point(134, 180);
            this.dpCantidaCombustible.Name = "dpCantidaCombustible";
            this.dpCantidaCombustible.Size = new System.Drawing.Size(169, 21);
            this.dpCantidaCombustible.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Empleado";
            // 
            // dpEmpleado
            // 
            this.dpEmpleado.FormattingEnabled = true;
            this.dpEmpleado.Location = new System.Drawing.Point(134, 128);
            this.dpEmpleado.Name = "dpEmpleado";
            this.dpEmpleado.Size = new System.Drawing.Size(169, 21);
            this.dpEmpleado.TabIndex = 4;
            // 
            // dpCliente
            // 
            this.dpCliente.FormattingEnabled = true;
            this.dpCliente.Location = new System.Drawing.Point(134, 24);
            this.dpCliente.Name = "dpCliente";
            this.dpCliente.Size = new System.Drawing.Size(169, 21);
            this.dpCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehiculo";
            // 
            // dpVehiculo
            // 
            this.dpVehiculo.FormattingEnabled = true;
            this.dpVehiculo.Location = new System.Drawing.Point(134, 75);
            this.dpVehiculo.Name = "dpVehiculo";
            this.dpVehiculo.Size = new System.Drawing.Size(169, 21);
            this.dpVehiculo.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(173, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 114;
            this.label11.Text = "Llanta Derecha D.";
            // 
            // chcLlantaDerechaD
            // 
            this.chcLlantaDerechaD.AutoSize = true;
            this.chcLlantaDerechaD.Location = new System.Drawing.Point(288, 233);
            this.chcLlantaDerechaD.Name = "chcLlantaDerechaD";
            this.chcLlantaDerechaD.Size = new System.Drawing.Size(15, 14);
            this.chcLlantaDerechaD.TabIndex = 113;
            this.chcLlantaDerechaD.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(173, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 116;
            this.label12.Text = "Llanta Izquierda D.";
            // 
            // chcLlantaIzquierdaD
            // 
            this.chcLlantaIzquierdaD.AutoSize = true;
            this.chcLlantaIzquierdaD.Location = new System.Drawing.Point(288, 272);
            this.chcLlantaIzquierdaD.Name = "chcLlantaIzquierdaD";
            this.chcLlantaIzquierdaD.Size = new System.Drawing.Size(15, 14);
            this.chcLlantaIzquierdaD.TabIndex = 115;
            this.chcLlantaIzquierdaD.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(173, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 118;
            this.label13.Text = "Llanta Derecha T.";
            // 
            // chcLlantaDerechaT
            // 
            this.chcLlantaDerechaT.AutoSize = true;
            this.chcLlantaDerechaT.Location = new System.Drawing.Point(288, 309);
            this.chcLlantaDerechaT.Name = "chcLlantaDerechaT";
            this.chcLlantaDerechaT.Size = new System.Drawing.Size(15, 14);
            this.chcLlantaDerechaT.TabIndex = 117;
            this.chcLlantaDerechaT.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(173, 344);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 120;
            this.label14.Text = "Llanta Izquierda T.";
            // 
            // chcLlantaIzquierdaT
            // 
            this.chcLlantaIzquierdaT.AutoSize = true;
            this.chcLlantaIzquierdaT.Location = new System.Drawing.Point(288, 343);
            this.chcLlantaIzquierdaT.Name = "chcLlantaIzquierdaT";
            this.chcLlantaIzquierdaT.Size = new System.Drawing.Size(15, 14);
            this.chcLlantaIzquierdaT.TabIndex = 119;
            this.chcLlantaIzquierdaT.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 387);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 121;
            this.label15.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(134, 387);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(169, 76);
            this.txtDescripcion.TabIndex = 122;
            // 
            // FrmInspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 633);
            this.Controls.Add(this.panel1);
            this.Name = "FrmInspeccion";
            this.Text = "FrmInspeccion";
            this.Load += new System.EventHandler(this.FrmInspeccion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dpEstadoInspeccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dpCantidaCombustible;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dpEmpleado;
        private System.Windows.Forms.ComboBox dpCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dpVehiculo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chcTieneRoturaCristal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chcTieneGato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chcTieneGoma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chcRayadura;
        private System.Windows.Forms.DateTimePicker dpFechaCreacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chcLlantaIzquierdaT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chcLlantaDerechaT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chcLlantaIzquierdaD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chcLlantaDerechaD;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label15;
    }
}