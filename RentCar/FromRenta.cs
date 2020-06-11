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
    public partial class FromRenta : Form
    {
        RENTA model = new RENTA();

        public static int VEHICULO = 0;
        public static int CLIENTE = 0;
        public static int EMPLEADO = 0;

        public FromRenta()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            btnInspeccion.Text = "Crear Inspeccion";
            //TxFechaRenta.Text = "";
            //TxFechaRenta.Text = DateTime.Now.ToString();
            //DPFechaDevolucion.MinDate = DateTime.Now;
            //TxCantidadDias.Text = "";
            //TxMontoDia.Text = "";
            //TxDescripcion.Text = "";
            btnSave.Text = "Guardar";
            btnSave.Enabled = false;
            btnInspeccion.Enabled = false;
            btnInspeccion.Text = "Crear Inspeccion";
            model.ID = 0;
            model.ID_INSPECCION = 0;
        }

        private bool ValidateData()
        {
            if (dpVehiculo.SelectedIndex == -1)
            {
                dpVehiculo.Focus();
                MessageBox.Show("Debe seleccionar un vehiculo");
                return false;
            }

            if (dpEmpleado.SelectedIndex == -1)
            {
                dpEmpleado.Focus();
                MessageBox.Show("Debe seleccionar un empleado");
                return false;
            }

            if (dpCliente.SelectedIndex == -1)
            {
                dpCliente.Focus();
                MessageBox.Show("Debe seleccionar un cliente");
                return false;
            }

            if (model.ID_INSPECCION == 0)
            {
                MessageBox.Show("Debe crear una inspeccion");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtMontoDia.Text))
            {
                txtMontoDia.Focus();
                MessageBox.Show("Debe ingresar el monto de la renta por dia");
                return false;
            }

            return true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbCombustible_Click(object sender, EventArgs e)
        {

        }

        private void txtLimiteCredito_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                model.ID_VEHICULO = Convert.ToInt32(dpVehiculo.SelectedValue);
                model.ID_EMPLEADO = Convert.ToInt32(dpEmpleado.SelectedValue);
                model.ID_CLIENTE = Convert.ToInt32(dpCliente.SelectedValue);
                model.FECHA_RENTA = Convert.ToDateTime(dpFechaRenta.Text);
                model.FECHA_DEVOLUCION = Convert.ToDateTime(dpDevolucion.Value);
                model.CANTIDAD_DIAS = Convert.ToInt32(txtCantidadDias.Text);
                model.MONTO_DIA = Convert.ToInt32(txtMontoDia.Text.Trim());
                model.DESCRIPCION = txtDescripcion.Text.Trim();

                using (DBEntities db = new DBEntities())
                {
                    db.RENTA.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Renta creada exitosamente");
                    ClearForm();
                    PopulateCombos();
                    PopulateDataGridView();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridRenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PopulateDataGridView()
        {
            gridRenta.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                var items = db.RENTA.Select(
                    x => new
                    {
                        x.ID,
                        VEHICULO = x.VEHICULO.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " " + x.VEHICULO.MODELO_VEHICULO.NOMBRE,
                        CLIENTE = x.CLIENTE.NOMBRES + " " + x.CLIENTE.APELLIDOS,
                        EMPLEADO = x.EMPLEADO.NOMBRES + " " + x.EMPLEADO.APELLIDOS,
                        INSPECCION = x.INSPECCION.CODIGO
                    }).ToList();
                gridRenta.DataSource = items;
            }
        }

        private void PopulateCombos()
        {
            using (DBEntities db = new DBEntities())
            {
                //vehiculos
                var vehiculos = db.VEHICULO
                    .Where(x => x.ESTADO == true)
                    .Select(
                    x => new
                    {
                        x.ID,
                        VEHICULO = x.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " " + x.MODELO_VEHICULO.NOMBRE
                    })
                    .ToList();
                dpVehiculo.DataSource = vehiculos;
                dpVehiculo.DisplayMember = "VEHICULO";
                dpVehiculo.ValueMember = "ID";

                //Empleados
                var empleados = db.EMPLEADO
                    .Where(x => x.ESTADO == true)
                    .Select(
                    x => new
                    {
                        x.ID,
                        EMPLEADO = x.NOMBRES + " " + x.APELLIDOS
                    })
                    .ToList();
                dpEmpleado.DataSource = empleados;
                dpEmpleado.DisplayMember = "EMPLEADO";
                dpEmpleado.ValueMember = "ID";

                //Clientes
                var clientes = db.CLIENTE
                    .Where(x => x.ESTADO == true)
                    .Select(
                    x => new
                    {
                        x.ID,
                        CLIENTE = x.NOMBRES + " " + x.APELLIDOS
                    })
                    .ToList();
                dpCliente.DataSource = clientes;
                dpCliente.DisplayMember = "CLIENTE";
                dpCliente.ValueMember = "ID";
            }
        }
        public void GetIdInspeccion(int ID_INSPECCION)
        {
            model.ID_INSPECCION = ID_INSPECCION;
        }

        private void FromRenta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ClearForm();
            PopulateDataGridView();
            PopulateCombos();
        }
        
        private void txtMontoDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica que la tecla presionada es solo numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dpDevolucion_ValueChanged(object sender, EventArgs e)
        {
            DateTime StartDate = DateTime.Now;
            DateTime EndDate = dpDevolucion.Value;

            txtCantidadDias.Text = Math.Round((EndDate - StartDate).TotalDays).ToString();

            SetTotalAPagar();
        }

        private void SetTotalAPagar()
        {
            if (txtCantidadDias.Text.Length > 0 && txtMontoDia.Text.Length > 0)
            {
                decimal total = Convert.ToInt32(txtCantidadDias.Text) * Convert.ToDecimal(txtMontoDia.Text);
                txtTotal.Text = total.ToString();
            }
            else
            {
                txtTotal.Text = "";
            }
        }

        private void txtMontoDia_TextChanged(object sender, EventArgs e)
        {
            SetTotalAPagar();
        }

        private void gridRenta_DoubleClick(object sender, EventArgs e)
        {
            if (gridRenta.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(gridRenta.CurrentRow.Cells["ID"].Value);

                using (DBEntities db = new DBEntities())
                {
                    model = db.RENTA.Where(x => x.ID == model.ID).FirstOrDefault();

                    dpVehiculo.SelectedValue = Convert.ToInt32(model.ID_VEHICULO);
                    dpEmpleado.SelectedValue = Convert.ToInt32(model.ID_EMPLEADO);
                    dpCliente.SelectedValue = Convert.ToInt32(model.ID_CLIENTE);
                    btnInspeccion.Enabled = false;
                    btnInspeccion.Text = model.INSPECCION.CODIGO;
                    dpFechaRenta.Text = model.FECHA_RENTA.ToString();
                    dpDevolucion.Value = Convert.ToDateTime(model.FECHA_DEVOLUCION);
                    dpDevolucion.Enabled = false;
                    txtCantidadDias.Text = model.CANTIDAD_DIAS.ToString();
                    txtMontoDia.Text = model.MONTO_DIA.ToString();
                    txtMontoDia.Enabled = false;
                    decimal TotalAPagaar = Convert.ToInt32(model.CANTIDAD_DIAS) * Convert.ToDecimal(model.MONTO_DIA);
                    txtTotal.Text = TotalAPagaar.ToString();
                    txtTotal.Enabled = false;
                    txtDescripcion.Text = model.DESCRIPCION;
                    txtDescripcion.Enabled = false;
                    btnSave.Enabled = false;
                    dpCliente.Enabled = false;
                    dpEmpleado.Enabled = false;
                    dpVehiculo.Enabled = false;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dpVehiculo.Enabled = true;
            dpEmpleado.Enabled = true;
            dpCliente.Enabled = true;
            btnInspeccion.Enabled = true;
            btnInspeccion.Text = "Crear Inspeccion";
            dpFechaRenta.Enabled = true;
            //dpFechaRenta.ReadOnly = true;
            dpFechaRenta.Text = DateTime.Now.ToString();
            dpDevolucion.Enabled = true;
            dpDevolucion.MinDate = DateTime.Now;
            dpDevolucion.Value = DateTime.Now;
            txtMontoDia.Enabled = true;
            txtMontoDia.ReadOnly = false;
            txtMontoDia.Text = "";
            txtDescripcion.Enabled = true;
            txtDescripcion.ReadOnly = false;
            txtDescripcion.Text = "";
            btnNuevo.Enabled = false;
            btnSave.Enabled = true;
            model.ID = 0;
        }
    }
}
