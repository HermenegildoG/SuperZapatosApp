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
    public partial class FiltrarArticulosView : Form
    {
        private ArticuloController articuloController;
        private Articulos articulos;
        public FiltrarArticulosView()
        {
            InitializeComponent();
            articuloController = new ArticuloController();
            articulos = new Articulos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void GetFilterArticles()
        {
            // Obtener el texto ingresado en el control txtFiltroArticulo
            string filtro = txtFiltroArticulo.Text.ToLower();

            // Obtener todos los artículos desde el servidor
            articulos = await articuloController.GetAllArticulos();

            // Verificar si hay artículos y si se ingresó un filtro
            if (articulos != null && !string.IsNullOrEmpty(filtro))
            {
                // Filtrar artículos por coincidencias
                var articulosFiltrados = articulos?.articles?.Where(articulo =>
                    articulo.name.ToLower().Contains(filtro) ||
                    articulo.description.ToLower().Contains(filtro) ||
                    articulo.id.ToString().Contains(filtro) ||
                    articulo.store_name.ToLower().Contains(filtro)
                ).ToList();

                // Actualizar el DataGridView con los artículos filtrados
                ActualizarDataGridView(articulosFiltrados);
            }
            else
            {
                // Si no hay filtro o no hay artículos, mostrar todos los artículos
                ActualizarDataGridView(articulos?.articles);
            }
        }
        private void ActualizarDataGridView(List<Articulo> articulosMostrar)
        {
            // Limpiar las filas existentes en el DataGridView
            dgvFiltroArticulo.Rows.Clear();

            // Verificar si hay artículos para mostrar
            if (articulosMostrar != null && articulosMostrar.Any())
            {
                // Iterar sobre los artículos y agregar cada uno al DataGridView
                foreach (var articulo in articulosMostrar)
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

            }
        }

        private void txtFiltroArticulo_TextChanged(object sender, EventArgs e)
        {
            GetFilterArticles();
        }

        private async void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvFiltroArticulo.SelectedRows.Count > 0)
            {
                // Obtener el ID del artículo seleccionado
                int articleId = Convert.ToInt32(dgvFiltroArticulo.SelectedRows[0].Cells["ID"].Value);

                // Mostrar un mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este artículo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes)
                {
                    // Intentar eliminar el artículo
                    bool success = await articuloController.DeleteArticle(articleId);

                    // Verificar si la eliminación fue exitosa
                    if (success)
                    {
                        MessageBox.Show("Artículo eliminado exitosamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar la vista después de la eliminación
                        GetFilterArticles();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el artículo. Inténtalo de nuevo.", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un artículo para eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
