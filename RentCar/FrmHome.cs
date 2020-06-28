using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar
{
    public partial class FrmHome : Form
    {
        private Form activeForm = null;
        public EMPLEADO EMPLEADO = null;

        public FrmHome()
        {
            InitializeComponent();
        }


        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        

        private void logOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCliente());
        }

        private void gToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEmpleado());
        }

        private void tipoVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTipo_Vehiculo());
        }

        private void marcaVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmMarcaVehiculo());
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmModelo());
        }

        private void combustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCombustible());
        }

        private void rentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FromRenta(EMPLEADO));
        }

        private void tandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTanda());
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmVehiculo());
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongDateString();
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

    }
}
