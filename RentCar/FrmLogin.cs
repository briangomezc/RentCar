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
            if (ValidateData())
            {
                btn_Login.Enabled = false;
                btn_Login.Text = "Por favor, espere";
                using (DBEntities db = new DBEntities())
                {
                    var empleado = db.EMPLEADO.FirstOrDefault(x => x.EMAIL.Equals(txtUsuario.Text.Trim().ToLower()));

                    if (empleado != null)
                    {
                        if (empleado.CLAVE.Equals(txtPassword.Text.Trim()))
                        {
                            FrmHome frm = new FrmHome();
                            frm.EMPLEADO = empleado;
                            this.Hide();
                            frm.Show();
                        }
                        else
                        {
                            MessageBox.Show("La clave no es correcta");
                            btn_Login.Text = "Login";
                            btn_Login.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                        btn_Login.Text = "Login";
                        btn_Login.Enabled = true;
                    }
                }
            }
        }
    }
}
