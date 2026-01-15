using System.Net.Http.Json;
using Models;


namespace Functions
{
     /**
     * @class UpdateScore
     * Clase encargada de actualizar la puntuación del usuario en la API.
     */
    class UpdateScore
    {
        
        private static readonly HttpClient client = new HttpClient();

         /**
         * Envía una petición PUT al endpoint "/scores/update" para  actualizar la puntuación del usuario.
         * Asegura que la respuesta HTTP sea exitosa y lee el contenido de la respuesta como un objeto Score.
         * Captura cualquier excepción de tipo HttpRequestException y muestra un mensaje en consola.
         *
         * @return Task Representa la operación asincrónica de actualización de la puntuación.
         */
        public static async Task UpdateScoreAsync()
        {
        try
            {
                var response = await client.PutAsync("http://localhost:3000/scores/update", null);
                response.EnsureSuccessStatusCode();

                await response.Content.ReadFromJsonAsync<Score>();
               
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error accediendo al API: {ex.Message}");
            }

        }
    }
}