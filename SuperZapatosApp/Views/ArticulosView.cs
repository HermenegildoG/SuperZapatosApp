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
    public partial class ArticulosView : Form
    {

        private ArticuloController articuloController;
        private TiendaController tiendaController;
        private Articulos articulos;
        private Tiendas tiendas;
        public ArticulosView()
        {
            InitializeComponent();
            articuloController = new ArticuloController();
            tiendaController = new TiendaController();
            articulos = new Articulos();
            tiendas = new Tiendas();
            GetStores();
            GetArticulos();
        }

        private async void GetArticulos()
        {
            articulos = await articuloController.GetAllArticulos();
            if(articulos != null )
            {
                foreach(var articulo in articulos?.articles!)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvArticulos);
                    row.Cells[0].Value = articulo.id;
                    row.Cells[1].Value = articulo.name;
                    row.Cells[2].Value = articulo.description;
                    row.Cells[3].Value = articulo.price;
                    row.Cells[4].Value = articulo.total_in_shelf;
                    row.Cells[5].Value = articulo.total_in_vault;
                    row.Cells[6].Value = articulo.store_name;
                    dgvArticulos.Rows.Add(row);

                }
            }
            else
            {
                MessageBox.Show("No se pudo obneter la peticion","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetStores()
        {
            tiendas = await tiendaController.GetAllTiendas();
            if(tiendas != null )
            {
                foreach(var tienda in tiendas.stores) 
                {
                    cmbTiendas.Items.Add(tienda.name);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTiendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el nombre de la tienda seleccionada en el ComboBox
            string tiendaSeleccionada = cmbTiendas.SelectedItem?.ToString();

            // Verificar si se ha seleccionado una tienda
            if (!string.IsNullOrEmpty(tiendaSeleccionada))
            {
                // Filtrar los artículos según la tienda seleccionada
                var articulosFiltrados = articulos?.articles?.Where(articulo => articulo.store_name == tiendaSeleccionada).ToList();

                // Actualizar el DataGridView con los artículos filtrados
                ActualizarDataGridView(articulosFiltrados);
            }
            else
            {
                // Si no hay tienda seleccionada, mostrar todos los artículos
                ActualizarDataGridView(articulos?.articles);
            }
        }

        private void ActualizarDataGridView(List<Articulo> articulosMostrar)
        {
            // Limpiar las filas existentes en el DataGridView
            dgvArticulos.Rows.Clear();

            // Verificar si hay artículos para mostrar
            if (articulosMostrar != null && articulosMostrar.Any())
            {
                // Iterar sobre los artículos y agregar cada uno al DataGridView
                foreach (var articulo in articulosMostrar)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvArticulos);
                    row.Cells[0].Value = articulo.id;
                    row.Cells[1].Value = articulo.name;
                    row.Cells[2].Value = articulo.description;
                    row.Cells[3].Value = articulo.price;
                    row.Cells[4].Value = articulo.total_in_shelf;
                    row.Cells[5].Value = articulo.total_in_vault;
                    row.Cells[6].Value = articulo.store_name;
                    dgvArticulos.Rows.Add(row);
                }
            }
            else
            {
                // Mostrar mensaje de error si no hay artículos
                MessageBox.Show("La tienda seleccionada no cuenta con artículos disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetArticulos();
            }
        }


    }
}
