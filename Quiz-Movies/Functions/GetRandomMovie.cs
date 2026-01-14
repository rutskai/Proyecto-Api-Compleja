using Models;
using System.Net.Http.Json;
using Validations;

namespace Functions
{
    class GetMovies
    {
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