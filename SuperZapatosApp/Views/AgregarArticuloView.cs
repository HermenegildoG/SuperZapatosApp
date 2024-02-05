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
    public partial class AgregarArticuloView : Form
    {
        private ArticuloController articuloController;
        private TiendaController tiendaController;
        private Articulos articulos;
        private Tiendas tiendas;
        public AgregarArticuloView()
        {
            InitializeComponent();
            articuloController = new ArticuloController();
            tiendaController = new TiendaController();
            articulos = new Articulos();
            tiendas = new Tiendas();
            FillcmbSelectStore();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private async void FillcmbSelectStore()
        {
            tiendas = await tiendaController.GetAllTiendas();

            if (tiendas != null)
            {
                foreach (var tienda in tiendas.stores)
                {
                    cmbSelectStore.Items.Add(tienda.name); 
                }

                // Establecer la primera opción como seleccionada
                if (cmbSelectStore.Items.Count > 0)
                {
                    cmbSelectStore.SelectedIndex = 0;
                }
            }
        }

        // Modificación en el método btnCrear_Click
        private async void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el nombre de la tienda seleccionada del ComboBox
                string nombreTiendaSeleccionada = cmbSelectStore.SelectedItem as string;

                // Validar que se haya seleccionado una tienda
                if (string.IsNullOrEmpty(nombreTiendaSeleccionada))
                {
                    MessageBox.Show("Selecciona una tienda válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Buscar la tienda seleccionada en la colección de tiendas
                var tiendaSeleccionada = tiendas.stores.FirstOrDefault(tienda => tienda.name == nombreTiendaSeleccionada);

                // Validar que se haya encontrado la tienda
                if (tiendaSeleccionada == null)
                {
                    MessageBox.Show("No se encontró la tienda seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener los valores de los controles de entrada
                string name = txtName.Text;
                string description = txtDescription.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                int total_in_shelf = Convert.ToInt32(txtTotal_In_Shelf.Text);
                int total_in_vault = Convert.ToInt32(txtTotal_In_Vault.Text);

                // Crear un nuevo objeto Articulo con los datos recopilados
                Articulo nuevoArticulo = new Articulo
                {
                    name = name,
                    description = description,
                    price = price,
                    total_in_shelf = total_in_shelf,
                    total_in_vault = total_in_vault,
                    store_id = tiendaSeleccionada.id // Utiliza el ID de la tienda seleccionada
                };

                // Llamar al método CreateArticle del controlador para crear el artículo
                bool success = await articuloController.CreateArticle(nuevoArticulo);
                if (success)
                {
                    LimpiarControles();
                    MessageBox.Show("Artículo creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al crear el artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para 'Precio', 'Total en estante' y 'Total en bóveda'.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpiarControles()
        {
            // Limpiar los controles de entrada después de crear el artículo
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtTotal_In_Shelf.Clear();
            txtTotal_In_Vault.Clear();
            cmbSelectStore.SelectedIndex = -1; // Deseleccionar cualquier tienda seleccionada
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
