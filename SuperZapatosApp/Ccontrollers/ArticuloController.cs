using Newtonsoft.Json;
using SuperZapatosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SuperZapatosApp.Ccontrollers
{
    public class ArticuloController
    {
        private HttpClient _httpClient;

        public ArticuloController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Articulos> GetAllArticulos()
        {
            try
            {
                Articulos articulos = new Articulos();
                HttpResponseMessage response = await _httpClient.GetAsync("https://localhost:7270/services/articles");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();

                articulos = JsonConvert.DeserializeObject<Articulos>(responseJson);


                return articulos;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<bool> DeleteArticle(int articleId)
        {
            try
            {
                // Concatena el ID del artículo a la URL de la solicitud DELETE
                string url = $"https://localhost:7270/services/articles/deletearticle/{articleId}";

                // Realiza la solicitud DELETE
                HttpResponseMessage response = await _httpClient.DeleteAsync(url);

                // Verifica si la solicitud fue exitosa (código 200 OK)
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la solicitud
                Console.WriteLine($"Error al eliminar el artículo: {ex.Message}");
                return false;
            }
        }
        public async Task<bool> CreateArticle(Articulo nuevoArticulo)
        {
            try
            {
                // Serializa el objeto Articulo a formato JSON
                string jsonArticulo = JsonConvert.SerializeObject(nuevoArticulo);

                // Crea el contenido de la solicitud POST con el JSON del nuevo artículo
                var content = new StringContent(jsonArticulo, Encoding.UTF8, "application/json");

                // Realiza la solicitud POST
                HttpResponseMessage response = await _httpClient.PostAsync("https://localhost:7270/services/articles/createarticle", content);

                // Verifica si la solicitud fue exitosa (código 201 Created)
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la solicitud
                Console.WriteLine($"Error al crear el artículo: {ex.Message}");
                return false;
            }
        }
        public async Task<bool> UpdateArticle(int articleId, Articulo updatedArticulo)
        {
            try
            {
                // Serializa el objeto Articulo actualizado a formato JSON
                string jsonUpdatedArticulo = JsonConvert.SerializeObject(updatedArticulo);

                // Crea el contenido de la solicitud PUT con el JSON del artículo actualizado
                var content = new StringContent(jsonUpdatedArticulo, Encoding.UTF8, "application/json");

                // Realiza la solicitud PUT a la URL específica para actualizar el artículo
                HttpResponseMessage response = await _httpClient.PutAsync($"https://localhost:7270/services/articles/updatearticle/{articleId}", content);

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