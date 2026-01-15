using System.Text.Json;
using Models;
using static Validations.GeneralValidation;

namespace Functions
{
    /**
     * @class GetApiMovies
     * Clase encargada de obtener la lista completa de películas desde la API.
     */
    class GetApiMovies
    {
        /**
         * Realiza una petición HTTP GET al endpoint "/movies" para obtener todas las películas.
         * Deserializa el contenido JSON recibido en una lista de objetos Movie.
         * Valida que la lista no sea nula ni esté vacía.
         * Captura cualquier excepción durante la llamada a la API y devuelve una lista vacía en caso de error.
         *
         * @return Task<List<Movie>> Lista de películas obtenidas desde la API; si ocurre un error, retorna una lista vacía.
         */
        public static async Task<List<Movie>> GetApiMoviesAsync()
        {
            try
            {
                using HttpClient client = new HttpClient();

                string url = "http://localhost:3000/movies";

                var response = await client.GetAsync(url);
                var content = await response.Content.ReadAsStringAsync();

                  var movies = JsonSerializer.Deserialize<List<Movie>>(content) ?? new List<Movie>();
                
                if (!IsValid(movies))
                {
                    Console.WriteLine("Error al acceder a las películas.");
                    return new List<Movie>();
                }

                return movies;
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error accediendo a la API: " + e);
                return new List<Movie>();
            }
        }
    }
}