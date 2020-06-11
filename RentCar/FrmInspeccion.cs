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
    public partial class FrmInspeccion : Form
    {
        INSPECCION inspeccion = new INSPECCION();
        INSPECCION_GOMAS inspeccion_gomas = new INSPECCION_GOMAS();

        public FrmInspeccion()
        {
            InitializeComponent();
        }

        FromRenta _FrmRenta = new FromRenta();

        public FrmInspeccion(FromRenta frmRenta)
        {
            InitializeComponent();
            _FrmRenta = frmRenta;
        }

        private void FrmInspeccion_Load(object sender, EventArgs e)
        {
            PopulateCombos();
            ClearForm();
        }

        private void ClearForm()
        {
            chcRayadura.Checked = false;
            chcTieneGoma.Checked = false;
            chcTieneGato.Checked = false;
            chcTieneRoturaCristal.Checked = false;
            chcLlantaDerechaD.Checked = false;
            chcLlantaIzquierdaD.Checked = false;
            chcLlantaIzquierdaT.Checked = false;
            chcLlantaDerechaT.Checked = false;
            txtDescripcion.Text = "";
            inspeccion.ID = 0;
            inspeccion_gomas.ID = 0;
        }


        private void PopulateCombos()
        {
            using (DBEntities db = new DBEntities())
            {
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

                //Estado inspeccion
                var estados = db.ESTADO_INSPECCION
                    .Select(
                    x => new
                    {
                        x.ID,
                        x.DESCRIPCION
                    })
                    .ToList();

                dpEstadoInspeccion.DataSource = estados;
                dpEstadoInspeccion.DisplayMember = "DESCRIPCION";
                dpEstadoInspeccion.ValueMember = "ID";

                //vehiculo
                var vehiculo = db.VEHICULO
                    .Where(x => x.ID == FromRenta.VEHICULO)
                    .FirstOrDefault();
                txtVehiculo.Text = vehiculo.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " " + vehiculo.MODELO_VEHICULO.NOMBRE;

                //Cliente
                var cliente = db.CLIENTE
                    .Where(x => x.ID == FromRenta.CLIENTE)
                    .FirstOrDefault();
                txtCliente.Text = cliente.NOMBRES + " " + cliente.APELLIDOS;

                //Empleado
                var empleado = db.EMPLEADO
                    .Where(x => x.ID == FromRenta.EMPLEADO)
                    .FirstOrDefault();
                txtEmpleado.Text = empleado.NOMBRES + " " + empleado.APELLIDOS;
            }
        }

        private bool ValidateData()
        {
            if (dpCantidaCombustible.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la cantidad de combustible");
                dpCantidaCombustible.Focus();
                return false;
            }

            if (dpEstadoInspeccion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la cantidad de combustible");
                dpEstadoInspeccion.Focus();
                return false;
            }

            return true;
        }

        private string GenerateCode(int length = 20)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                inspeccion.CODIGO = GenerateCode(6);
                inspeccion.ID_VEHICULO = FromRenta.VEHICULO;
                inspeccion.ID_CLIENTE = FromRenta.CLIENTE;
                inspeccion.ID_EMPLEADO = FromRenta.EMPLEADO;
                inspeccion.TIENE_RAYADURAS = chcRayadura.Checked;
                inspeccion.ID_CANTIDAD_COMBUSTIBLE = Convert.ToInt32(dpCantidaCombustible.SelectedValue);
                inspeccion.TIENE_GOMA = chcTieneGoma.Checked;
                inspeccion.TIENE_GATO = chcTieneGato.Checked;
                inspeccion.TIENE_ROTURA_CRISTAL = chcTieneRoturaCristal.Checked;
                inspeccion.FECHA_CREACION = DateTime.Now;
                inspeccion.ID_ESTADO_INSPECCION = Convert.ToInt32(dpEstadoInspeccion.SelectedValue);

                using (DBEntities db = new DBEntities())
                {
                    db.INSPECCION.Add(inspeccion);
                    db.SaveChanges();

                    int ID_INSPECCION = inspeccion.ID;

                    inspeccion_gomas.ID_INSPECCION = ID_INSPECCION;
                    inspeccion_gomas.GOMA_TRASERA_DERECHA = chcLlantaDerechaT.Checked;
                    inspeccion_gomas.GOMA_TRASERA_IZQUIERDA = chcLlantaIzquierdaT.Checked;
                    inspeccion_gomas.GOMA_DELANTERA_DERECHA = chcLlantaDerechaD.Checked;
                    inspeccion_gomas.GOME_DELANTERA_IZQUIERDA = chcLlantaIzquierdaD.Checked;
                    inspeccion_gomas.DESCRIPCION = txtDescripcion.Text.Trim();

                    db.INSPECCION_GOMAS.Add(inspeccion_gomas);
                    db.SaveChanges();

                    if (MessageBox.Show("Inspeccion creada exitosamente") == DialogResult.OK)
                    {
                        _FrmRenta.GetIdInspeccion(ID_INSPECCION);
                        _FrmRenta.btnSave.Enabled = true;
                        _FrmRenta.btnInspeccion.Enabled = false;
                        _FrmRenta.btnInspeccion.Text = inspeccion.CODIGO;
                        this.Close();
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
