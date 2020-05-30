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
            if (MessageBox.Show("Desea borrar este elemento?", "Eliminar Elemento", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBEntities db = new DBEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.MARCA_VEHICULO.Attach(model);
                    }
                    db.MARCA_VEHICULO.Remove(model);
                    db.SaveChanges();

                    PopulateDataGridView();
                    ClearForm();
                    MessageBox.Show("Marca de vehiculo eliminado existosamente");
                }
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
                gridMarcaVehiculo.DataSource = db.MARCA_VEHICULO.ToList<MARCA_VEHICULO>();
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
                }
                btnSave.Text = "Actualizar";
                btnDelete.Enabled = true;
            }
        }

    }
}
