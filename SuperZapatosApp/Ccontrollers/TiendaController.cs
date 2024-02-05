using Newtonsoft.Json;
using SuperZapatosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperZapatosApp.Ccontrollers
{
    internal class TiendaController
    {
        private HttpClient _httpClient;
        
        public TiendaController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Tiendas> GetAllTiendas()
        {
            try
            {
                Tiendas tiendas = new Tiendas();
                HttpResponseMessage response = await _httpClient.GetAsync("https://localhost:7270/services/stores");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();

                tiendas = JsonConvert.DeserializeObject<Tiendas>(responseJson);


                return tiendas;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> CreateStore(Tienda nuevaTienda)
        {
            try
            {
                // Serializa el objeto Articulo a formato JSON
                string jsonTienda = JsonConvert.SerializeObject(nuevaTienda);

                // Crea el contenido de la solicitud POST con el JSON del nuevo artículo
                var content = new StringContent(jsonTienda, Encoding.UTF8, "application/json");

                // Realiza la solicitud POST
                HttpResponseMessage response = await _httpClient.PostAsync("https://localhost:7270/services/stores/createstore", content);

                // Verifica si la solicitud fue exitosa (código 201 Created)
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la solicitud
                Console.WriteLine($"Error al crear la tienda: {ex.Message}");
                return false;
            }
        }
        public async Task<bool> UpdateStore(int storeId, Tienda updatedStore)
        {
            try
            {
                // Serializa el objeto Articulo actualizado a formato JSON
                string jsonUpdatedStore = JsonConvert.SerializeObject(updatedStore);

                // Crea el contenido de la solicitud PUT con el JSON del artículo actualizado
                var content = new StringContent(jsonUpdatedStore, Encoding.UTF8, "application/json");

                // Realiza la solicitud PUT a la URL específica para actualizar el artículo
                HttpResponseMessage response = await _httpClient.PutAsync($"https://localhost:7270/services/stores/updatestore/{storeId}", content);

                // Verifica si la solicitud fue exitosa (código 200 OK)
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la solicitud
                Console.WriteLine($"Error al actualizar el artículo: {ex.Message}");
                return false;
            }
        }
    }
}
