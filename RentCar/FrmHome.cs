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

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FrmTipo_Vehiculo());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmMarcaVehiculo());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
                openChildForm(new FrmVehiculo());
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEmpleado());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCombustible());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTanda());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmModelo());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCliente());
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new FromRenta(EMPLEADO));
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

    }
}
