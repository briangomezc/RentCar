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
            gridTipoVehiculo.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                gridTipoVehiculo.DataSource = db.TIPO_VEHICULO.ToList<TIPO_VEHICULO>();
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
                }
                btnSave.Text = "Actualizar";
                btnDelete.Enabled = true;
            }
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
                        db.TIPO_VEHICULO.Attach(model);
                    }
                    db.TIPO_VEHICULO.Remove(model);
                    db.SaveChanges();

                    PopulateDataGridView();
                    ClearForm();
                    MessageBox.Show("Se elimino el Tipo de Vehiculo.");
                }
            }
        }

        private void FrmTipo_Vehiculo_Load(object sender, EventArgs e)
        {
            ClearForm();
            PopulateDataGridView();
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
