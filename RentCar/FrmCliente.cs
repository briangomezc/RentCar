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
    public partial class FrmCliente : Form
    {
        CLIENTE model = new CLIENTE();

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtCedula.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            chcEstado.Checked = true;
            txtTarjetaCredito.Text = "";
            txtLimiteCredito.Text = "";
            lbFechaCreacion.Visible = false;
            dpFechaIngreso.Visible = false;
            model.ID = 0;
            btnSave.Text = "Guardar";
            btnDelete.Enabled = false;
        }

        private void PopulateDataGridView()
        {
            gridCliente.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                var items = db.CLIENTE.Select(
                    x => new
                    {
                        x.ID,
                        x.NOMBRES,
                        x.APELLIDOS,
                        x.CEDULA,
                        x.EMAIL,
                        x.TELEFONO,
                        x.LIMITE_CREDITO,
                        ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                    }).ToList();

                gridCliente.DataSource = items;
            }
        }

        public void PopulateCombos()
        {
            using (DBEntities db = new DBEntities())
            {
                dpTipoPersona.DataSource = db.TIPO_CLIENTE.ToList<TIPO_CLIENTE>();
                dpTipoPersona.DisplayMember = "DESCRIPCION";
                dpTipoPersona.ValueMember = "ID";
            }
        }

        private bool ValidateData()
        {
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del cliente.");
                txtNombre.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                MessageBox.Show("Debe ingresar el apellidos del cliente.");
                txtApellidos.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Debe ingresar la cedula del cliente.");
                txtCedula.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Debe ingresar la correo del cliente.");
                txtEmail.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtTarjetaCredito.Text))
            {
                MessageBox.Show("Debe ingresar la tarjeta de credito del cliente.");
                txtTarjetaCredito.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtLimiteCredito.Text))
            {
                MessageBox.Show("Debe ingresar el limite de credito del cliente.");
                txtLimiteCredito.Focus();
                return false;
            }

            if (dpTipoPersona.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el tipo de cliente.");
                dpTipoPersona.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                model.NOMBRES = txtNombre.Text.Trim();
                model.APELLIDOS = txtApellidos.Text.Trim();
                model.CEDULA = txtCedula.Text.Trim();
                model.EMAIL = txtEmail.Text.Trim();
                model.TELEFONO = txtTelefono.Text.Trim();
                model.TARJETA_CREDITO = txtTarjetaCredito.Text.Trim();
                model.LIMITE_CREDITO = Convert.ToDecimal(txtLimiteCredito.Text.Trim());
                model.ESTADO = chcEstado.Checked;
                model.ID_TIPO_CLIENTE = Convert.ToInt32(dpTipoPersona.SelectedValue);
                model.FECHA_CREACION = DateTime.Now;

                using (DBEntities db = new DBEntities())
                {
                    if (model.ID == 0)
                    {
                        db.CLIENTE.Add(model);
                    }
                    else
                    {
                        db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                ClearForm();
                PopulateDataGridView();
                PopulateCombos();
                MessageBox.Show("Cliente actualizado existosamente");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string question = (model.ESTADO == true) ? "Desea desactivar este elemento?" : "Desea activar este elemento";

            if (MessageBox.Show(question, "Cambiar Estado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                model.ESTADO = !model.ESTADO;

                using (DBEntities db = new DBEntities())
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                ClearForm();
                PopulateDataGridView();
                PopulateCombos();
                string result = (model.ESTADO == true) ? "Cliente activado existosamente" : "Cliente desactivado existosamente";
                MessageBox.Show(result);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ClearForm();
            PopulateCombos();
            PopulateDataGridView();
        }

        private void gridCliente_DoubleClick(object sender, EventArgs e)
        {
            if (gridCliente.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(gridCliente.CurrentRow.Cells["ID"].Value);

                using (DBEntities db = new DBEntities())
                {
                    model = db.CLIENTE.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtNombre.Text = model.NOMBRES;
                    txtApellidos.Text = model.APELLIDOS;
                    txtCedula.Text = model.CEDULA.ToString();
                    txtEmail.Text = model.EMAIL;
                    txtTelefono.Text = model.TELEFONO;
                    txtTarjetaCredito.Text = model.TARJETA_CREDITO.ToString();
                    txtLimiteCredito.Text = model.LIMITE_CREDITO.ToString();
                    chcEstado.Checked = Convert.ToBoolean(model.ESTADO);
                    dpTipoPersona.SelectedValue = Convert.ToInt32(model.ID_TIPO_CLIENTE);
                    dpFechaIngreso.Visible = true;
                    lbFechaCreacion.Visible = true;
                    dpFechaIngreso.Text = model.FECHA_CREACION.ToString();
                    btnDelete.Text = model.ESTADO == true ? "Deshabilitar" : "Habilitar";
                    btnSave.Text = "Actualizar";
                    btnDelete.Enabled = true;
                }
            }
        }
    }
}
