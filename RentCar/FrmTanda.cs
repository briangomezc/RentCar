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
    public partial class FrmTanda : Form
    {
        TANDA model = new TANDA();
        
        public FrmTanda()
        {
            InitializeComponent();
        }

        private void FrmTanda_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ClearForm();
            PopulateDataGridView();

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
            gridTanda.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                var items = db.TANDA.Select(
                    x => new
                    {
                        x.ID,
                        x.DESCRIPCION,
                        ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                    }).ToList();
                gridTanda.DataSource = items;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                model.DESCRIPCION = txtNombre.Text.Trim().ToUpper();
                model.ESTADO = chcEstado.Checked;

                using (DBEntities db = new DBEntities())
                {
                    if (model.ID == 0)
                    {
                        db.TANDA.Add(model);
                    }
                    else
                    {
                        db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                ClearForm();
                PopulateDataGridView();
                MessageBox.Show("Tanda actualizado existosamente");
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
                string result = (model.ESTADO == true) ? "Tanda activado existosamente" : "Tanda desactivado existosamente";
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

        private bool ValidateData()
        {
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el tipo de tanda.");
                txtNombre.Focus();
                return false;
            }
            return true;
        }

        private void gridTanda_DoubleClick(object sender, EventArgs e)
        {
            if (gridTanda.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(gridTanda.CurrentRow.Cells["ID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    model = db.TANDA.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtNombre.Text = model.DESCRIPCION;
                    chcEstado.Checked = Convert.ToBoolean(model.ESTADO);
                    btnDelete.Text = model.ESTADO == true ? "Deshabilitar" : "Habilitar";
                    btnSave.Text = "Actualizar";
                    btnDelete.Enabled = true;
                }
            }
        }
    }
}
