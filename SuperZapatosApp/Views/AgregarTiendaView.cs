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
    public partial class AgregarTiendaView : Form
    {
        private ArticuloController articuloController;
        private TiendaController tiendaController;
        private Articulos articulos;
        private Tiendas tiendas;
        public AgregarTiendaView()
        {
            InitializeComponent();
            articuloController = new ArticuloController();
            tiendaController = new TiendaController();
            articulos = new Articulos();
            tiendas = new Tiendas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                

                // Obtener los valores de los controles de entrada
                string name = txtName.Text;
                string adress = txtDireccion.Text;

                // Crear un nuevo objeto Articulo con los datos recopilados
                Tienda nuevaTienda = new Tienda
                {
                    name = name,
                    adress = adress
                };

                // Llamar al método CreateArticle del controlador para crear el artículo
                bool success = await tiendaController.CreateStore(nuevaTienda);
                if (success)
                {
                    LimpiarControles();
                    MessageBox.Show("Tienda creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al crear la tienda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpiarControles()
        {
            // Limpiar los controles de entrada después de crear el artículo
            txtName.Clear();
            txtDireccion.Clear();
        }
    }
}
