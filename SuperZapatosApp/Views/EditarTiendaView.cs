using SuperZapatosApp.Ccontrollers;
using SuperZapatosApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperZapatosApp.Views
{
    public partial class EditarTiendaView : Form
    {
        private ArticuloController articuloController;
        private TiendaController tiendaController;
        private Articulos articulos;
        private Tiendas tiendas;
        public EditarTiendaView()
        {
            InitializeComponent();
            articuloController = new ArticuloController();
            tiendaController = new TiendaController();
            articulos = new Articulos();
            tiendas = new Tiendas();
            GetTiendas();
        }
        private async void GetTiendas()
        {
            tiendas = await tiendaController.GetAllTiendas();
            if (articulos != null)
            {
                foreach (var tienda in tiendas?.stores!)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvTodasTiendas);
                    row.Cells[0].Value = tienda.id;
                    row.Cells[1].Value = tienda.name;
                    row.Cells[2].Value = tienda.adress;
                    dgvTodasTiendas.Rows.Add(row);

                }
            }
            else
            {
                MessageBox.Show("No se pudo obneter la peticion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarTienda_Click(object sender, EventArgs e)
        {
            if (dgvTodasTiendas.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow selectedRow = dgvTodasTiendas.SelectedRows[0];

                // Obtén los valores de las celdas correspondientes
                string id = selectedRow.Cells["id"].Value.ToString();
                string name = selectedRow.Cells["name"].Value.ToString();
                string adress = selectedRow.Cells["adress"].Value.ToString();
                // Obtén los valores de las otras columnas según sea necesario

                // Llena los campos de edición con los valores obtenidos
                txtName.Text = name;
                txtUbicacion.Text = adress;

            }
            else
            {
                MessageBox.Show("Selecciona una fila para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtUbicacion.Text))
            {
                MessageBox.Show("Completa todos los campos antes de actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tienda updatedTienda = new Tienda
            {
                // Asigna las propiedades según los valores de los campos
                name = txtName.Text,
                adress = txtUbicacion.Text
            };
            if (dgvTodasTiendas.SelectedRows.Count > 0)
            {
                string id = dgvTodasTiendas.SelectedRows[0].Cells["id"].Value.ToString();

                bool success = await tiendaController.UpdateStore(int.Parse(id), updatedTienda);

                if (success)
                {
                    MessageBox.Show("Artículo actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpia los campos después de la actualización
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LimpiarControles()
        {
            txtName.Clear();
            txtUbicacion.Clear();
        }
    }
}
