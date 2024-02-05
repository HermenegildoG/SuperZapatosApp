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
    public partial class TiendasView : Form
    {
        private ArticuloController articuloController;
        private TiendaController tiendaController;
        private Articulos articulos;
        private Tiendas tiendas;
        public TiendasView()
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

        private async void GetFilterStores()
        {
            // Obtener el texto ingresado en el control txtFiltroArticulo
            string filtro = txtFiltroTienda.Text.ToLower();

            // Obtener todos los artículos desde el servidor
            tiendas = await tiendaController.GetAllTiendas();

            // Verificar si hay artículos y si se ingresó un filtro
            if (tiendas != null && !string.IsNullOrEmpty(filtro))
            {
                // Filtrar artículos por coincidencias
                var tiendasFiltradas = tiendas?.stores?.Where(tienda =>
                    tienda.name.ToLower().Contains(filtro) ||
                    tienda.adress.ToLower().Contains(filtro) ||
                    tienda.id.ToString().Contains(filtro)
                ).ToList();

                // Actualizar el DataGridView con los artículos filtrados
                ActualizarDataGridView(tiendasFiltradas);
            }
            else
            {
                // Si no hay filtro o no hay artículos, mostrar todos los artículos
                ActualizarDataGridView(tiendas?.stores);
            }
        }

        private void ActualizarDataGridView(List<Tienda> tiendaMostrar)
        {
            // Limpiar las filas existentes en el DataGridView
            dgvTodasTiendas.Rows.Clear();

            // Verificar si hay artículos para mostrar
            if (tiendaMostrar != null && tiendaMostrar.Any())
            {
                // Iterar sobre los artículos y agregar cada uno al DataGridView
                foreach (var tienda in tiendaMostrar)
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

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltroTienda_TextChanged(object sender, EventArgs e)
        {
            GetFilterStores();
        }
    }
}
