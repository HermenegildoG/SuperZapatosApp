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
    public partial class EditarArticuloView : Form
    {
        private ArticuloController articuloController;
        private TiendaController tiendaController;
        private Articulos articulos;
        private Tiendas tiendas;
        public EditarArticuloView()
        {
            InitializeComponent();
            articuloController = new ArticuloController();
            tiendaController = new TiendaController();
            articulos = new Articulos();
            tiendas = new Tiendas();

            GetArticulos();
        }

        private async void GetArticulos()
        {
            articulos = await articuloController.GetAllArticulos();
            if (articulos != null)
            {
                foreach (var articulo in articulos?.articles!)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvFiltroArticulo);
                    row.Cells[0].Value = articulo.id;
                    row.Cells[1].Value = articulo.name;
                    row.Cells[2].Value = articulo.description;
                    row.Cells[3].Value = articulo.price;
                    row.Cells[4].Value = articulo.total_in_shelf;
                    row.Cells[5].Value = articulo.total_in_vault;
                    row.Cells[6].Value = articulo.store_name;
                    dgvFiltroArticulo.Rows.Add(row);

                }
            }
            else
            {
                MessageBox.Show("No se pudo obneter la peticion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarArticulo_Click(object sender, EventArgs e)
        {
            if (dgvFiltroArticulo.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow selectedRow = dgvFiltroArticulo.SelectedRows[0];

                // Obtén los valores de las celdas correspondientes
                string id = selectedRow.Cells["id"].Value.ToString();
                string name = selectedRow.Cells["name"].Value.ToString();
                string description = selectedRow.Cells["description"].Value.ToString();
                string price = selectedRow.Cells["price"].Value.ToString();
                string total_in_shelf = selectedRow.Cells["total_in_shelf"].Value.ToString();
                string total_in_vault = selectedRow.Cells["total_in_vault"].Value.ToString();
                string store_name = selectedRow.Cells["store_name"].Value.ToString();

                // Llena los campos de edición con los valores obtenidos
                txtName.Text = name;
                txtDescription.Text = description;
                txtPrice.Text = price;
                txtTotal_In_Shelf.Text = total_in_shelf;
                txtTotal_In_Vault.Text = total_in_vault;
                txtSelectedStore.Text = store_name;
                GetStores();

            }
            else
            {
                MessageBox.Show("Selecciona una fila para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async void GetStores()
        {
            tiendas = await tiendaController.GetAllTiendas();

            if (tiendas != null)
            {
                foreach (var tienda in tiendas.stores)
                {
                    cmbSelectStore.Items.Add(tienda.name);
                }
            }
        }

        private void dgvFiltroArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            // Verificar si algún campo está vacío
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtTotal_In_Shelf.Text) ||
                string.IsNullOrWhiteSpace(txtTotal_In_Vault.Text) ||
                string.IsNullOrWhiteSpace(cmbSelectStore.Text))
            {
                MessageBox.Show("Completa todos los campos antes de actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nombreTiendaSeleccionada = cmbSelectStore.SelectedItem as string;
            var tiendaSeleccionada = tiendas.stores.FirstOrDefault(tienda => tienda.name == nombreTiendaSeleccionada);
            if (cmbSelectStore.SelectedItem == null)
            {
                MessageBox.Show("Selecciona la misma tienda o una diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Articulo updatedArticulo = new Articulo
                {
                    // Asigna las propiedades según los valores de los campos
                    name = txtName.Text,
                    description = txtDescription.Text,
                    price = double.Parse(txtPrice.Text),
                    total_in_shelf = int.Parse(txtTotal_In_Shelf.Text),
                    total_in_vault = int.Parse(txtTotal_In_Vault.Text),
                    store_id = tiendaSeleccionada.id
                };
                // Obtener el ID del artículo seleccionado
                if (dgvFiltroArticulo.SelectedRows.Count > 0)
                {
                    string id = dgvFiltroArticulo.SelectedRows[0].Cells["id"].Value.ToString();

                    bool success = await articuloController.UpdateArticle(int.Parse(id), updatedArticulo);

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



        }

        private void LimpiarControles()
        {
            // Limpia todos los campos y reinicia el DataGridView
            txtSelectedStore.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtTotal_In_Shelf.Clear();
            txtTotal_In_Vault.Clear();
            cmbSelectStore.SelectedIndex = -1; // Limpia la selección del ComboBox
            dgvFiltroArticulo.Rows.Clear();
            GetArticulos(); // Vuelve a cargar los artículos después de la actualización
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
