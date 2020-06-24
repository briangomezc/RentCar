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
    public partial class FrmCombustible : Form
    {
        COMBUSTIBLE_VEHICULO model = new COMBUSTIBLE_VEHICULO();
        public FrmCombustible()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                model.NOMBRE = txtNombre.Text.Trim();
                model.ESTADO = chcEstado.Checked;

                using (DBEntities db = new DBEntities())
                {
                    if (model.ID == 0)
                    {
                        db.COMBUSTIBLE_VEHICULO.Add(model);
                    }
                    else
                    {
                        db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                ClearForm();
                PopulateDataGridView();
                MessageBox.Show("Combustible de vehiculo actualizado existosamente");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtNombre.Text = "";
            chcEstado.Checked = true;
            btnSave.Text = "Guardar";
            btnDelete.Enabled = false;
            model.ID = 0;
        }

        private void PopulateDataGridView()
        {
            gridCombustibleVehiculo.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                var items = db.COMBUSTIBLE_VEHICULO.Select(
                    x => new
                    {
                        x.ID,
                        x.NOMBRE,
                        ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                    }).ToList();
                gridCombustibleVehiculo.DataSource = items;
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
                string result = (model.ESTADO == true) ? "Combustible activado existosamente" : "Combustible desactivado existosamente";
                MessageBox.Show(result);
            }
        }

        private void gridTipoVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chcEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCombustible_Load(object sender, EventArgs e)
        {
            ClearForm();
            this.Hide();
            PopulateDataGridView();
        }

        private bool ValidateData()
        {
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el tipo de combustible.");
                txtNombre.Focus();
                return false;
            }
            return true;
        }

        private void FrmCombustible_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void gridCombustibleVehiculo_DoubleClick(object sender, EventArgs e)
        {
            if (gridCombustibleVehiculo.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(gridCombustibleVehiculo.CurrentRow.Cells["ID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    model = db.COMBUSTIBLE_VEHICULO.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtNombre.Text = model.NOMBRE;
                    chcEstado.Checked = Convert.ToBoolean(model.ESTADO);
                    btnDelete.Text = model.ESTADO == true ? "Deshabilitar" : "Habilitar";
                    btnSave.Text = "Actualizar";
                    btnDelete.Enabled = true;
                }
            }
        }
    }
}
