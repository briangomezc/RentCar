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
    public partial class FrmEmpleado : Form
    {
        EMPLEADO model = new EMPLEADO();

        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void PopulateDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                var items = db.EMPLEADO.Select(
                    x => new
                    {
                        x.ID,
                        x.NOMBRES,
                        x.APELLIDOS,
                        Tanda = x.TANDA.DESCRIPCION,
                        TIPO_EMPLEADO = x.TIPO_EMPLEADO.DESCRIPCION,
                        x.FECHA_INGRESO,
                        ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                    }).ToList();
                dataGridView1.DataSource = items;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                using (DBEntities db = new DBEntities())
                {
                    model = db.EMPLEADO.Where(x => x.ID == model.ID).FirstOrDefault();

                    txtNombre.Text = model.NOMBRES;
                    txtApellidos.Text = model.APELLIDOS;
                    txtClave.Text = model.CLAVE;
                    dpTanda.SelectedValue = Convert.ToInt32(model.ID_TANDA);
                    txtComision.Text = model.PORCIENTO_COMISION.ToString();
                    dpFechaIngreso.Value = Convert.ToDateTime(model.FECHA_INGRESO);
                    dpTipoEmpleado.SelectedValue = Convert.ToInt32(model.ID_TIPO_EMPLEADO);
                    dpFechaCreacion.Text = model.FECHA_CREACION.ToString();
                    btnSave.Text = "Actualizar";
                    btnDelete.Enabled = true;
                }
            }
        }


        private void lbCombustible_Click(object sender, EventArgs e)
        {

        }

        private void dpTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroMotor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroChasis_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dpCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ClearForm();
            PopulateDataGridView();
            PopulateCombos();
        }

        private bool ValidateData()
        {
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del empleado.");
                txtNombre.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                MessageBox.Show("Debe ingresar el apellido del empleado.");
                txtApellidos.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Debe ingresar la clave del empleado.");
                txtClave.Focus();
                return false;
            }

            if (dpTanda.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la tanda del empleado.");
                dpTanda.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtComision.Text))
            {
                MessageBox.Show("Debe ingresar el porciento de comision del empleado.");
                txtComision.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(dpFechaIngreso.Text))
            {
                MessageBox.Show("Debe ingresar la fecha de ingreso del empleado.");
                dpFechaIngreso.Focus();
                return false;
            }

            if (dpTipoEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el tipo de empleado.");
                dpTipoEmpleado.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtClave.Text = "";
            chcEstado.Checked = true;
            txtComision.Text = "";
            dpFechaIngreso.Value = DateTime.Today;
            //labelFechaCreacion.Visible = false;
            //TxFechaCreacion.Visible = false;
            model.ID = 0;
            btnSave.Text = "Guardar";
            btnDelete.Enabled = false;
        }

        private void PopulateCombos()
        {
            using (DBEntities db = new DBEntities())
            {
                //Fill tandas
                dpTanda.DataSource = db.TANDA.Where(x => x.ESTADO == true).ToList();
                dpTanda.DisplayMember = "DESCRIPCION";
                dpTanda.ValueMember = "ID";

                //Fill Tipo de Empleado
                dpTipoEmpleado.DataSource = db.TIPO_EMPLEADO.ToList<TIPO_EMPLEADO>();
                dpTipoEmpleado.DisplayMember = "DESCRIPCION";
                dpTipoEmpleado.ValueMember = "ID";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                model.NOMBRES = txtNombre.Text.Trim();
                model.APELLIDOS = txtApellidos.Text.Trim();
                model.CLAVE = txtClave.Text.Trim();
                model.ID_TANDA = Convert.ToInt32(dpTanda.SelectedValue);
                model.ESTADO = chcEstado.Checked;
                model.PORCIENTO_COMISION = Convert.ToDecimal(txtComision.Text.Trim());
                model.FECHA_INGRESO = Convert.ToDateTime(dpFechaIngreso.Value);
                model.ID_TIPO_EMPLEADO = Convert.ToInt32(dpTipoEmpleado.SelectedValue);
                model.FECHA_CREACION = DateTime.Now;

                using (DBEntities db = new DBEntities())
                {
                    if (model.ID == 0)
                    {
                        db.EMPLEADO.Add(model);
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
                MessageBox.Show("Empleado actualizado existosamente");
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
                string result = (model.ESTADO == true) ? "Empleado activado existosamente" : "Empleado desactivado existosamente";
                MessageBox.Show(result);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
