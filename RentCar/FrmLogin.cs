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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.BringToFront();
            childForm.Show();
        }

        private bool ValidateData()
        {
            if (String.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un usuario que exista.");
                txtUsuario.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Debe ingresar el password correctamente.");
                txtPassword.Focus();
                return false;
            }

           
            return true;
        }
        
        private void btn_Login_Click(object sender, EventArgs e)
        {
            DBEntities db = new DBEntities();

            if (txtUsuario.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                var userExist = db.EMPLEADO.FirstOrDefault(p => p.NOMBRES.Equals(txtUsuario.Text));

                if (userExist != null)
                {
                    if (userExist.CLAVE.Equals(txtPassword.Text))
                    {
                        MessageBox.Show("Bienvenido " + userExist.NOMBRES);
                        FrmHome frm = new FrmHome();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password incorrecto");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
            else
            {
                MessageBox.Show("Inserte datos en las filas");
            }
        }
    }
}
