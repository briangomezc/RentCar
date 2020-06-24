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
    public partial class FrmTipo_Vehiculo : Form
    {
        TIPO_VEHICULO model = new TIPO_VEHICULO();

        public FrmTipo_Vehiculo()
        {
            InitializeComponent();
        }

        private void PopulateDataGridView()
        {
            using (DBEntities db = new DBEntities())
            {
                var items = db.TIPO_VEHICULO.Select(
                    x => new
                    {
                        x.ID,
                        x.NOMBRE,
                        ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                    }).ToList();
                gridTipoVehiculo.DataSource = items;
            }
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.NOMBRE = txtNombre.Text.Trim();
            model.ESTADO = chcEstado.Checked;

            using (DBEntities db = new DBEntities())
            {
                if (model.ID == 0)
                {
                    db.TIPO_VEHICULO.Add(model);
                }
                else
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
            ClearForm();
            PopulateDataGridView();
            MessageBox.Show("Tipo de vehiculo se actualizo.");
        }
        


        private void gridTipoVehiculo_DoubleClick(object sender, EventArgs e)
        {
            if (gridTipoVehiculo.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(gridTipoVehiculo.CurrentRow.Cells["ID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    model = db.TIPO_VEHICULO.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtNombre.Text = model.NOMBRE;
                    chcEstado.Checked = Convert.ToBoolean(model.ESTADO);
                    btnDelete.Text = model.ESTADO == true ? "Deshabilitar" : "Habilitar";
                    btnSave.Text = "Actualizar";
                    btnDelete.Enabled = true;
                }
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
                string result = (model.ESTADO == true) ? "Tipo de vehiculo activado existosamente" : "Tipo de vehiculo desactivado existosamente";
                MessageBox.Show(result);
            }
        }

        private void FrmTipo_Vehiculo_Load(object sender, EventArgs e)
        {
            ClearForm();
            PopulateDataGridView();
            this.WindowState = FormWindowState.Maximized;
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltrar.Text.Length > 0)
            {
                using (DBEntities db = new DBEntities())
                {
                    var query = from tipos in db.TIPO_VEHICULO
                                where tipos.NOMBRE.Contains(txtFiltrar.Text.Trim().ToUpper())
                                select tipos;

                    var items = query.Select(
                        x => new
                        {
                            x.ID,
                            x.NOMBRE,
                            ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                        }).ToList();
                    gridTipoVehiculo.DataSource = items;
                }
            }
            else
            {
                PopulateDataGridView();
            }
        }
    }
}
