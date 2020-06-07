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
    public partial class FrmModelo : Form
    {
        MODELO_VEHICULO model = new MODELO_VEHICULO();

        public FrmModelo()
        {
            InitializeComponent();
        }

        private void FrmModelo_Load(object sender, EventArgs e)
        {
            ClearForm();
            PopulateDataGridView();
            PopulateComboMarca();
            this.WindowState = FormWindowState.Maximized;
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
            gridModelo.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                var items = db.MODELO_VEHICULO.Select(
                    x => new
                    {
                        x.ID,
                        x.NOMBRE,
                        MARCA = x.MARCA_VEHICULO.NOMBRE,
                        ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                    }).ToList();
                gridModelo.DataSource = items;
            }
        }

        private void PopulateComboMarca()
        {
            using (DBEntities db = new DBEntities())
            {
                var items = db.MARCA_VEHICULO.Where(x => x.ESTADO == true).ToList();
                dpMarca.DataSource = items;
                dpMarca.DisplayMember = "NOMBRE";
                dpMarca.ValueMember = "ID";
            }
        }

        private bool ValidateData()
        {
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el modelo del vehiculo.");
                txtNombre.Focus();
                return false;
            }

            if (dpMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la marca del vehiculo.");
                dpMarca.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                model.NOMBRE = txtNombre.Text.Trim();
                model.ID_MARCA_VEHICULO = Convert.ToInt32(dpMarca.SelectedValue);
                model.ESTADO = chcEstado.Checked;

                using (DBEntities db = new DBEntities())
                {
                    if (model.ID == 0)
                    {
                        db.MODELO_VEHICULO.Add(model);
                    }
                    else
                    {
                        db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                ClearForm();
                PopulateDataGridView();
                PopulateComboMarca();
                MessageBox.Show("Modelo de vehiculo actualizado existosamente");
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
                PopulateComboMarca();
                string result = (model.ESTADO == true) ? "Modelo activado existosamente" : "Modelo desactivado existosamente";
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

        private void gridCombustibleVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridModelo_DoubleClick(object sender, EventArgs e)
        {
            if (gridModelo.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(gridModelo.CurrentRow.Cells["ID"].Value);

                using (DBEntities db = new DBEntities())
                {
                    model = db.MODELO_VEHICULO.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtNombre.Text = model.NOMBRE;
                    chcEstado.Checked = Convert.ToBoolean(model.ESTADO);
                    dpMarca.SelectedValue = Convert.ToInt32(model.ID_MARCA_VEHICULO);
                    btnDelete.Text = model.ESTADO == true ? "Deshabilitar" : "Habilitar";
                    btnSave.Text = "Actualizar";
                    btnDelete.Enabled = true;
                }
            }
        }
        
    }
}
