using System.Text.Json;
using Models;
using static Validations.GeneralValidation;

namespace Functions
{
    class GetApiMovies
    {
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