using Models;
using System.Net.Http.Json;
using Validations;

namespace Functions
{
     /**
     * @class GetMovies
     * Clase encargada de obtener películas desde la API y de proporcionar películas aleatorias.
     */

    class GetMovies
    {

        /**
         * Obtiene todas las películas desde la API mediante GetApiMovies.GetApiMoviesAsync().
         * Valida que la lista no sea nula ni esté vacía.
         * 
         * @return Task<List<Movie>> Una lista de películas; si ocurre un error o la lista no es válida, retorna una lista vacía.
         */

        public static async Task<List<Movie>> GetAllMoviesAsync()
        {

            try
            {
                
            List<Movie> movies = await GetApiMovies.GetApiMoviesAsync();

             if (!GeneralValidation.IsValid(movies))
                {
                    Console.WriteLine("Error, no se puede acceder a las películas.");
                    return new List<Movie>() ;
                }

            return movies;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error accediendo a la API: " +  ex);
                return new List<Movie>() ;
            }

        }

       private static readonly HttpClient client = new HttpClient();

       
        /**
         * Obtiene una película aleatoria desde la API usando HttpClient y el endpoint "/movies/random".
         * 
         * @return Task<Movie> La película obtenida; si ocurre un error, retorna un objeto Movie vacío.
         */

        public static async Task<Movie> GetRandomMovieAsync()
        {
            try
            {
                Movie movie = await client.GetFromJsonAsync<Movie>("http://localhost:3000/movies/random") ?? new Movie();
                return movie;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error accediendo a la API: " +  ex);
                return new Movie();
            }
        }

    }
}