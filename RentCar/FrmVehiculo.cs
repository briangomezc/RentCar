﻿using System;
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
    public partial class FrmVehiculo : Form
    {
        VEHICULO model = new VEHICULO();

        public FrmVehiculo()
        {
            InitializeComponent();
        }

        public void ClearForm()
        {
            txtNumeroChasis.Text = "";
            txtNumeroMotor.Text = "";
            txtNumeroPlaca.Text = "";
            txtNombre.Text = "";
            //labelFechaCreacion.Visible = false;
            chcEstado.Checked = true;
            btnSave.Text = "Guardar";
            btnDelete.Enabled = false;
            model.ID = 0;
        }

        public void PopulateDataGridView()
        {
            gridVehiculo.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                var items = db.VEHICULO.Select(
                    x => new
                    {
                        x.ID,
                        x.DESCRIPCION,
                        x.NUMERO_CHASIS,
                        x.NUMERO_PLACA,
                        MARCA = x.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE,
                        MODELO = x.MODELO_VEHICULO.NOMBRE,
                        x.FECHA_CREACION,
                        ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                    }).ToList();
                gridVehiculo.DataSource = items;
            }
        }

        public void PopulateCombos()
        {
            using (DBEntities db = new DBEntities())
            {
                //Fill comboModelo
                var models = db.MODELO_VEHICULO
                    .Where(x => x.ESTADO == true)
                    .Select(
                    x => new
                    {
                        x.ID,
                        NOMBRE = x.MARCA_VEHICULO.NOMBRE + " - " + x.NOMBRE
                    })
                    .ToList();
                dpModeloVehiculo.DataSource = models;
                dpModeloVehiculo.DisplayMember = "NOMBRE";
                dpModeloVehiculo.ValueMember = "ID";

                //Fill comboTipoVehiculo
                dpTipoVehiculo.DataSource = db.TIPO_VEHICULO.Where(x => x.ESTADO == true).ToList();
                dpTipoVehiculo.DisplayMember = "NOMBRE";
                dpTipoVehiculo.ValueMember = "ID";

                //Fill comboTipoCombustible
                dpCombustible.DataSource = db.COMBUSTIBLE_VEHICULO.Where(x => x.ESTADO == true).ToList();
                dpCombustible.DisplayMember = "NOMBRE";
                dpCombustible.ValueMember = "ID";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.ID_MODELO_VEHICULO = Convert.ToInt32(dpModeloVehiculo.SelectedValue);
            model.NUMERO_CHASIS = txtNumeroChasis.Text.Trim();
            model.NUMERO_MOTOR = txtNumeroMotor.Text.Trim();
            model.NUMERO_PLACA = txtNumeroPlaca.Text.Trim();
            model.ID_TIPO_VEHICULO = Convert.ToInt32(dpTipoVehiculo.SelectedValue);
            model.ID_TIPO_COMBUSTIBLE = Convert.ToInt32(dpCombustible.SelectedValue);
            model.DESCRIPCION = txtNombre.Text.Trim();
            model.FECHA_CREACION = DateTime.Now;
            model.ESTADO = Convert.ToBoolean(chcEstado.Checked);

            using (DBEntities db = new DBEntities())
            {
                if (model.ID == 0)
                {
                    db.VEHICULO.Add(model);
                }
                else
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
            ClearForm();
            PopulateDataGridView();
            PopulateCombos();
            MessageBox.Show("Vehiculo actualizado existosamente");
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
                PopulateCombos();
                string result = (model.ESTADO == true) ? "Vehiculo activado existosamente" : "Vehiculo desactivado existosamente";
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

        private void gridTipoCliente_DoubleClick(object sender, EventArgs e)
        {
            if (gridVehiculo.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(gridVehiculo.CurrentRow.Cells["ID"].Value);

                using (DBEntities db = new DBEntities())
                {
                    model = db.VEHICULO.Where(x => x.ID == model.ID).FirstOrDefault();
                    dpModeloVehiculo.SelectedValue = Convert.ToInt32(model.ID_MODELO_VEHICULO);
                    txtNumeroChasis.Text = model.NUMERO_CHASIS;
                    txtNumeroMotor.Text = model.NUMERO_MOTOR;
                    txtNumeroPlaca.Text = model.NUMERO_PLACA;
                    dpTipoVehiculo.SelectedValue = Convert.ToInt32(model.ID_TIPO_VEHICULO);
                    dpCombustible.SelectedValue = Convert.ToInt32(model.ID_TIPO_COMBUSTIBLE);
                    txtNombre.Text = model.DESCRIPCION;
                    dpFechaCreacion.Text = model.FECHA_CREACION.ToString();
                }
                btnDelete.Text = model.ESTADO == true ? "Deshabilitar" : "Habilitar";
                btnSave.Text = "Actualizar";
                btnDelete.Enabled = true;
            }
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            ClearForm();
            PopulateDataGridView();
            PopulateCombos();
        }

        private void dpModeloVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltrar.Text.Length > 0)
            {
                using (DBEntities db = new DBEntities())
                {
                    var items = db.VEHICULO
                        .Where(x =>
                            x.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE.Contains(txtFiltrar.Text.Trim().ToUpper()) ||
                            x.MODELO_VEHICULO.NOMBRE.Contains(txtFiltrar.Text.Trim().ToUpper()) ||
                            x.NUMERO_CHASIS.Contains(txtFiltrar.Text.Trim()) ||
                            x.NUMERO_MOTOR.Contains(txtFiltrar.Text.Trim()) ||
                            x.NUMERO_PLACA.Contains(txtFiltrar.Text.Trim()) ||
                            x.TIPO_VEHICULO.NOMBRE.Contains(txtFiltrar.Text.Trim().ToUpper()) ||
                            x.COMBUSTIBLE_VEHICULO.NOMBRE.Contains(txtFiltrar.Text.Trim().ToUpper())
                        )
                        .Select(
                        x => new
                        {
                            x.ID,
                            x.NUMERO_CHASIS,
                            x.NUMERO_PLACA,
                            x.TIPO_VEHICULO,
                            MARCA = x.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE,
                            MODELO = x.MODELO_VEHICULO.NOMBRE,
                            ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                        })
                        .ToList();
                    gridVehiculo.DataSource = items;
                }
            }
            else
            {
                PopulateDataGridView();
            }
        }
    }
}
