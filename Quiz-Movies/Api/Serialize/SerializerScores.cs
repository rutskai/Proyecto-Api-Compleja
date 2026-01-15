using System.Text.Json;
using Models;
using static Validations.GeneralValidation;

namespace Functions
{
    /**
     * @class GetApiScores
     * Clase encargada de obtener la puntuación actual del usuario desde la API.
     */
    class GetApiScores
    {
        /**
         * Realiza una petición HTTP GET al endpoint "/scores" para obtener la puntuación actual del usuario.
         * Deserializa el contenido JSON recibido en un objeto Score.
         * Valida que el objeto Score no sea nulo y tenga un valor válido.
         * Captura cualquier excepción durante la llamada a la API y devuelve un objeto Score vacío en caso de error.
         *
         * @return Task<Score> La puntuación del usuario obtenida desde la API; si ocurre un error, retorna un objeto Score vacío.
         */
        public static async Task<Score> GetApiScoreAsync()
        {
            try
            {
                using HttpClient client = new HttpClient();

                string url = "http://localhost:3000/scores";

                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();

             
                var score = JsonSerializer.Deserialize<Score>(content) ?? new Score();

                if (!IsValid(score))
                {
                    Console.WriteLine("Error al acceder al score.");
                    return new Score();
                }

                return score;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accediendo al API de scores: " + e.Message);
                return new Score();
            }
        }
    }
}
