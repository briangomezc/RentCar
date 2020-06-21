using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RazorEngine;
using RazorEngine.Templating;

namespace RentCar
{
    public partial class FromRenta : Form
    {
        RENTA model = new RENTA();

        private EMPLEADO empleado = null;
        private RENTA renta = new RENTA();
        private INSPECCION inspeccion = new INSPECCION();

        public FromRenta(EMPLEADO Empleado = null)
        {
            InitializeComponent();
            empleado = Empleado;
        }

        private void ClearForm()
        {
            dpCliente.Enabled = false;
            dpVehiculo.Enabled = false;
            txtTotal.Text = "0";
            dpFechaRenta.Enabled = false;
            dpDevolucion.Enabled = false;
            txtDescripcion.Text = "";
            txtDescripcion.Enabled = false;
            txtCantidadDias.Text = "";
            txtCantidadDias.Enabled = false;
            txtMontoDia.Text = "";
            txtMontoDia.Enabled = false;
            chcEstado.Enabled = false;
            txtCodigo.Enabled = false;

            //Inspeccion
            chcLlantaDerechaD.Enabled = false;
            chcLlantaIzquierdaD.Enabled = false;
            chcLlantaDerechaT.Enabled = false;
            chcLlantaIzquierdaT.Enabled = false;
            chcTieneGoma.Enabled = false;
            chcRayadura.Enabled = false;
            chcTieneGato.Enabled = false;
            chcTieneRoturaCristal.Enabled = false;
            dpCantidaCombustible.Enabled = false;

            //Botones
            btnSave.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            renta.ID = 0;
            inspeccion.ID = 0;
        }

        private bool ValidateData()
        {
            if (dpVehiculo.SelectedIndex == -1)
            {
                dpVehiculo.Focus();
                MessageBox.Show("Debe seleccionar un vehiculo");
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
                using (DBEntities db = new DBEntities())
                {
                    if (renta.ID > 0)
                    {
                        renta.ID_CLIENTE = Convert.ToInt32(dpCliente.SelectedValue);
                        renta.ID_VEHICULO = Convert.ToInt32(dpVehiculo.SelectedValue);
                        renta.FECHA_RENTA = dpFechaRenta.Value;
                        renta.FECHA_DEVOLUCION = dpDevolucion.Value;
                        renta.CANTIDAD_DIAS = Convert.ToInt32(txtCantidadDias.Text);
                        renta.MONTO_DIA = Convert.ToDecimal(txtMontoDia.Text.Trim());
                        renta.DESCRIPCION = txtDescripcion.Text.Trim();
                        renta.ESTADO = chcEstado.Checked;

                        db.Entry(renta).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Renta Actualizada Existosamente");
                        ClearForm();
                        PopulateDataGridView();
                    }
                    else
                    {
                        inspeccion.ID_VEHICULO = Convert.ToInt32(dpVehiculo.SelectedValue);
                        inspeccion.CODIGO = GenerateCode();
                        inspeccion.TIENE_RAYADURAS = chcRayadura.Checked;
                        inspeccion.ID_CANTIDAD_COMBUSTIBLE = Convert.ToInt32(dpCantidaCombustible.SelectedValue);
                        inspeccion.TIENE_GATO = chcTieneGato.Checked;
                        inspeccion.TIENE_ROTURA_CRISTAL = chcTieneRoturaCristal.Checked;
                        inspeccion.FECHA_CREACION = DateTime.Now;
                        inspeccion.GOMA_DELANTERA_DERECHA = chcLlantaDerechaD.Checked;
                        inspeccion.GOMA_DELANTERA_IZQUIERDA = chcLlantaIzquierdaD.Checked;
                        inspeccion.GOMA_TRASERA_DERECHA = chcLlantaDerechaT.Checked;
                        inspeccion.GOMA_TRASERA_IZQUIERDA = chcLlantaIzquierdaT.Checked;
                        inspeccion.TIENE_GOMA = chcTieneGoma.Checked;

                        db.INSPECCION.Add(inspeccion);

                        //Renta
                        renta.ID_INSPECCION = inspeccion.ID;
                        renta.ID_EMPLEADO = empleado.ID;
                        renta.ID_CLIENTE = Convert.ToInt32(dpCliente.SelectedValue);
                        renta.ID_VEHICULO = Convert.ToInt32(dpVehiculo.SelectedValue);
                        renta.FECHA_RENTA = dpFechaRenta.Value;
                        renta.FECHA_DEVOLUCION = dpDevolucion.Value;
                        renta.FECHA_CREACION = DateTime.Now;
                        renta.CANTIDAD_DIAS = Convert.ToInt32(txtCantidadDias.Text);
                        renta.MONTO_DIA = Convert.ToDecimal(txtMontoDia.Text.Trim());
                        renta.DESCRIPCION = txtDescripcion.Text.Trim();
                        renta.CODIGO = GenerateCode();
                        renta.ESTADO = false;
                        db.RENTA.Add(renta);

                    }

                    db.SaveChanges();
                    MessageBox.Show("Renta Creada Existosamente");
                    ClearForm();
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
            using (DBEntities db = new DBEntities())
            {
                gridRenta.AutoGenerateColumns = false;
                var items = db.RENTA.Select(
                    x => new
                    {
                        x.ID,
                        VEHICULO = x.VEHICULO.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " " + x.VEHICULO.MODELO_VEHICULO.NOMBRE,
                        CLIENTE = x.CLIENTE.NOMBRES + " " + x.CLIENTE.APELLIDOS,
                        x.CODIGO,
                        ESTADO = x.ESTADO == true ? "Entregado" : "Sin Entregar"
                    })
                    .ToList();
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

                //Combustible
                var combustibles = db.CANTIDAD_COMBUSTIBLE
                    .Select(
                    x => new
                    {
                        x.ID,
                        x.DESCRIPCION
                    })
                    .ToList();
                dpCantidaCombustible.DataSource = combustibles;
                dpCantidaCombustible.DisplayMember = "DESCRIPCION";
                dpCantidaCombustible.ValueMember = "ID";
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dpDevolucion_ValueChanged(object sender, EventArgs e)
        {
            SetCantidadDias();
            SetTotalAPagar();
        }

        private void SetTotalAPagar()
        {
            decimal total = 0;

            if (txtMontoDia.Text.Length > 0)
            {
                int CantidadDias = Convert.ToInt32(txtCantidadDias.Text);
                decimal MontoXDia = Convert.ToInt32(txtMontoDia.Text);

                total = CantidadDias * MontoXDia;
            }

            txtTotal.Text = total.ToString();
        }


        private void txtMontoDia_TextChanged(object sender, EventArgs e)
        {
            SetTotalAPagar();
        }

        private void gridRenta_DoubleClick(object sender, EventArgs e)
        {
            if (gridRenta.CurrentRow.Index != -1)
            {
                renta.ID = Convert.ToInt32(gridRenta.CurrentRow.Cells["ID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    //Renta
                    renta = db.RENTA.Where(x => x.ID == renta.ID).FirstOrDefault();
                    dpCliente.Enabled = true;
                    dpCliente.SelectedValue = Convert.ToInt32(renta.ID_CLIENTE);
                    dpVehiculo.Enabled = true;
                    dpVehiculo.SelectedValue = Convert.ToInt32(renta.ID_VEHICULO);
                    dpFechaRenta.Enabled = true;
                    dpFechaRenta.Value = Convert.ToDateTime(renta.FECHA_RENTA);
                    dpDevolucion.Enabled = true;
                    dpDevolucion.Value = Convert.ToDateTime(renta.FECHA_DEVOLUCION);
                    txtDescripcion.Enabled = true;
                    txtDescripcion.Text = renta.DESCRIPCION;
                    txtCantidadDias.Text = renta.CANTIDAD_DIAS.ToString();
                    txtMontoDia.Enabled = true;
                    txtMontoDia.Text = renta.MONTO_DIA.ToString();
                    txtCodigo.Text = renta.CODIGO;
                    chcEstado.Enabled = true;
                    chcEstado.Checked = Convert.ToBoolean(renta.ESTADO);

                    //inspeccion
                    inspeccion = db.INSPECCION.Where(x => x.ID == renta.ID_INSPECCION).FirstOrDefault();
                    chcLlantaDerechaD.Checked = Convert.ToBoolean(inspeccion.GOMA_DELANTERA_DERECHA);
                    chcLlantaIzquierdaD.Checked = Convert.ToBoolean(inspeccion.GOMA_DELANTERA_IZQUIERDA);
                    chcLlantaDerechaT.Checked = Convert.ToBoolean(inspeccion.GOMA_TRASERA_DERECHA);
                    chcLlantaIzquierdaT.Checked = Convert.ToBoolean(inspeccion.GOMA_TRASERA_IZQUIERDA);
                    chcTieneGoma.Checked = Convert.ToBoolean(inspeccion.TIENE_GOMA);
                    chcRayadura.Checked = Convert.ToBoolean(inspeccion.TIENE_RAYADURAS);
                    chcTieneGato.Checked = Convert.ToBoolean(inspeccion.TIENE_GATO);
                    chcTieneRoturaCristal.Checked = Convert.ToBoolean(inspeccion.TIENE_ROTURA_CRISTAL);
                    dpCantidaCombustible.SelectedValue = Convert.ToInt32(inspeccion.ID_CANTIDAD_COMBUSTIBLE);
                }

                btnNuevo.Enabled = false;
                btnCancelar.Enabled = true;
                btnSave.Enabled = true;
            }
        }
        

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Renta
            dpCliente.Enabled = true;
            dpVehiculo.Enabled = true;
            txtTotal.Enabled = false;
            txtTotal.Text = "0";
            dpFechaRenta.MinDate = DateTime.Now;
            dpFechaRenta.Value = DateTime.Now;
            dpFechaRenta.Enabled = true;
            dpDevolucion.Value = DateTime.Now;
            dpDevolucion.Enabled = true;
            txtDescripcion.Text = "";
            txtDescripcion.Enabled = true;
            txtCantidadDias.Text = "";
            txtMontoDia.Text = "";
            txtMontoDia.Enabled = true;
            chcEstado.Checked = false;
            chcEstado.Enabled = false;
            btnSave.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            renta.ID = 0;

            //Inspeccion
            chcLlantaDerechaD.Checked = false;
            chcLlantaDerechaD.Enabled = true;
            chcLlantaIzquierdaD.Checked = false;
            chcLlantaIzquierdaD.Enabled = true;
            chcLlantaDerechaT.Checked = false;
            chcLlantaDerechaT.Enabled = true;
            chcLlantaIzquierdaT.Checked = false;
            chcLlantaIzquierdaT.Enabled = true;
            chcTieneGoma.Checked = false;
            chcTieneGoma.Enabled = true;
            chcRayadura.Checked = false;
            chcRayadura.Enabled = true;
            chcTieneGato.Checked = false;
            chcTieneGato.Enabled = true;
            chcTieneRoturaCristal.Checked = false;
            chcTieneRoturaCristal.Enabled = true;
            dpCantidaCombustible.Enabled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCantidadDias_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dpFechaRenta_ValueChanged(object sender, EventArgs e)
        {
            dpDevolucion.MinDate = dpFechaRenta.Value;
            SetCantidadDias();
            SetTotalAPagar();
        }

        private void SetCantidadDias()
        {
            DateTime StartDate = dpFechaRenta.Value;
            DateTime EndDate = dpDevolucion.Value;

            int dias = (EndDate - StartDate).Days + 1;
            txtCantidadDias.Text = dias.ToString();
        }

        private string GenerateCode(int length = 6)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltrar.Text.Length > 0)
            {
                using (DBEntities db = new DBEntities())
                {
                    var items = db.RENTA
                        .Where(x =>
                            x.CLIENTE.NOMBRES.Contains(txtFiltrar.Text.Trim()) ||
                            x.CLIENTE.APELLIDOS.Contains(txtFiltrar.Text.Trim()) ||
                            x.CODIGO.Contains(txtFiltrar.Text.Trim()) ||
                            x.VEHICULO.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE.Contains(txtFiltrar.Text.Trim()) ||
                            x.VEHICULO.MODELO_VEHICULO.NOMBRE.Contains(txtFiltrar.Text.Trim())
                        )
                        .Select(
                        x => new
                        {
                            x.ID,
                            VEHICULO = x.VEHICULO.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " " + x.VEHICULO.MODELO_VEHICULO.NOMBRE,
                            CLIENTE = x.CLIENTE.NOMBRES + " " + x.CLIENTE.APELLIDOS,
                            x.CODIGO,
                            ESTADO = x.ESTADO == true ? "Entregado" : "Sin Entregar"
                        })
                        .ToList();
                    gridRenta.DataSource = items;
                }
            }
            else
            {
                PopulateDataGridView();
            }
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                var items = db.RENTA.ToList();
                var file = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"Reporte\ReporteRenta.cshtml");
                var html = Engine.Razor.RunCompile(file, Guid.NewGuid().ToString(), null, items, null);
                var htmlToPDF = new NReco.PdfGenerator.HtmlToPdfConverter();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "Rentas";
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.ShowDialog();
                htmlToPDF.GeneratePdf(html, null, saveFileDialog.FileName + ".pdf");
            }
        }
    }
}
