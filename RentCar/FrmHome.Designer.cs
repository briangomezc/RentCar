namespace RentCar
{
    partial class FrmHome
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combustibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.menuStrip1);
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1088, 659);
            this.panelContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.logOut);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 629);
            this.panel1.TabIndex = 11;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTimer.Location = new System.Drawing.Point(368, 404);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(100, 37);
            this.lblTimer.TabIndex = 12;
            this.lblTimer.Text = "label1";
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(491, 495);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(156, 52);
            this.logOut.TabIndex = 10;
            this.logOut.Text = "Salir";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentCar.Properties.Resources.editada;
            this.pictureBox1.Location = new System.Drawing.Point(277, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 458);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem,
            this.dToolStripMenuItem1,
            this.sToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1088, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gToolStripMenuItem,
            this.gToolStripMenuItem1,
            this.tandaToolStripMenuItem});
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.dToolStripMenuItem.Text = "Usuario";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.gToolStripMenuItem.Text = "Cliente";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // gToolStripMenuItem1
            // 
            this.gToolStripMenuItem1.Name = "gToolStripMenuItem1";
            this.gToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.gToolStripMenuItem1.Text = "Empleado";
            this.gToolStripMenuItem1.Click += new System.EventHandler(this.gToolStripMenuItem1_Click);
            // 
            // tandaToolStripMenuItem
            // 
            this.tandaToolStripMenuItem.Name = "tandaToolStripMenuItem";
            this.tandaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.tandaToolStripMenuItem.Text = "Tanda";
            this.tandaToolStripMenuItem.Click += new System.EventHandler(this.tandaToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem1
            // 
            this.dToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoVehiculoToolStripMenuItem,
            this.marcaVehiculoToolStripMenuItem,
            this.modeloToolStripMenuItem,
            this.combustibleToolStripMenuItem,
            this.vehiculosToolStripMenuItem});
            this.dToolStripMenuItem1.Name = "dToolStripMenuItem1";
            this.dToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.dToolStripMenuItem1.Text = "Vehiculo";
            // 
            // tipoVehiculoToolStripMenuItem
            // 
            this.tipoVehiculoToolStripMenuItem.Name = "tipoVehiculoToolStripMenuItem";
            this.tipoVehiculoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.tipoVehiculoToolStripMenuItem.Text = "Tipo";
            this.tipoVehiculoToolStripMenuItem.Click += new System.EventHandler(this.tipoVehiculoToolStripMenuItem_Click);
            // 
            // marcaVehiculoToolStripMenuItem
            // 
            this.marcaVehiculoToolStripMenuItem.Name = "marcaVehiculoToolStripMenuItem";
            this.marcaVehiculoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.marcaVehiculoToolStripMenuItem.Text = "Marca";
            this.marcaVehiculoToolStripMenuItem.Click += new System.EventHandler(this.marcaVehiculoToolStripMenuItem_Click);
            // 
            // modeloToolStripMenuItem
            // 
            this.modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
            this.modeloToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.modeloToolStripMenuItem.Text = "Modelo";
            this.modeloToolStripMenuItem.Click += new System.EventHandler(this.modeloToolStripMenuItem_Click);
            // 
            // combustibleToolStripMenuItem
            // 
            this.combustibleToolStripMenuItem.Name = "combustibleToolStripMenuItem";
            this.combustibleToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.combustibleToolStripMenuItem.Text = "Combustible";
            this.combustibleToolStripMenuItem.Click += new System.EventHandler(this.combustibleToolStripMenuItem_Click);
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentasToolStripMenuItem});
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sToolStripMenuItem.Text = "Renta";
            // 
            // rentasToolStripMenuItem
            // 
            this.rentasToolStripMenuItem.Name = "rentasToolStripMenuItem";
            this.rentasToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.rentasToolStripMenuItem.Text = "Rentas";
            this.rentasToolStripMenuItem.Click += new System.EventHandler(this.rentasToolStripMenuItem_Click);
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTime.Location = new System.Drawing.Point(503, 441);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(100, 37);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "label1";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 659);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem1;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.ToolStripMenuItem tipoVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combustibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTime;
    }
}

