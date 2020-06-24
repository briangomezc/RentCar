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
    public partial class FrmMarcaVehiculo : Form
    {
        MARCA_VEHICULO model = new MARCA_VEHICULO();

        public FrmMarcaVehiculo()
        {
            InitializeComponent();
        }

    
        private void btnSave_Click(object sender, EventArgs e)
        {
            model.NOMBRE = txtNombre.Text.Trim();
            model.ESTADO = chcEstado.Checked;

            using (DBEntities db = new DBEntities())
            {
                if (model.ID == 0)
                {
                    db.MARCA_VEHICULO.Add(model);
                }
                else
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
            ClearForm();
            PopulateDataGridView();
            MessageBox.Show("Marca de vehiculo actualizado existosamente");
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
                string result = (model.ESTADO == true) ? "Marca activada existosamente" : "Marca desactivada existosamente";
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

        private void ClearForm()
        {
            txtNombre.Text = "";
            chcEstado.Checked = true;
            btnSave.Text = "Guardar";
            btnDelete.Enabled = false;
            model.ID = 0;
        }

        private void FrmMarcaVehiculo_Load(object sender, EventArgs e)
        {
            ClearForm();
            PopulateDataGridView();
            this.WindowState = FormWindowState.Maximized;
        }

        private void PopulateDataGridView()
        {
            gridMarcaVehiculo.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                var items = db.MARCA_VEHICULO.Select(
                    x => new
                    {
                        x.ID,
                        x.NOMBRE,
                        ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                    }).ToList();
                gridMarcaVehiculo.DataSource = items;
            }
        }


        private void gridMarcaVehiculo_DoubleClick(object sender, EventArgs e)
        {
            if (gridMarcaVehiculo.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(gridMarcaVehiculo.CurrentRow.Cells["ID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    model = db.MARCA_VEHICULO.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtNombre.Text = model.NOMBRE;
                    chcEstado.Checked = Convert.ToBoolean(model.ESTADO);
                    btnDelete.Text = model.ESTADO == true ? "Deshabilitar" : "Habilitar";
                    btnSave.Text = "Actualizar";
                    btnDelete.Enabled = true;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                using (DBEntities db = new DBEntities())
                {
                    var query = from marcas in db.MARCA_VEHICULO
                                where marcas.NOMBRE.Contains(textBox1.Text.Trim().ToUpper())
                                select marcas;

                    var items = query.Select(
                        x => new
                        {
                            x.ID,
                            x.NOMBRE,
                            ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                        })
                        .ToList();
                    gridMarcaVehiculo.DataSource = items;
                }
            }
            else
            {
                PopulateDataGridView();
            }
        }
    }
}
