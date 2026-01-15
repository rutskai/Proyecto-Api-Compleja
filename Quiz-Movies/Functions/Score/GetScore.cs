using Models;

namespace Functions
{
    /**
     * @class GetScore
     * Clase encargada de obtener la puntuación actual del usuario desde la API.
     */
    class GetScore
    {
        /**
         * Obtiene la puntuación actual del usuario llamando a GetApiScores.GetApiScoreAsync().
         * Captura cualquier excepción que ocurra durante la llamada a la API y devuelve un objeto Score vacío en caso de error.
         *
         * @return Task<Score> La puntuación del usuario; si ocurre un error, retorna un objeto Score vacío.
         */
        public static async Task<Score> GetScoreAsync()
        {
            try
            {
                
            Score score= await GetApiScores.GetApiScoreAsync();
            return score;

            }
            catch (Exception ex)
            {
                 Console.WriteLine($"Error accediendo al API: {ex.Message}");
                   return new Score();
            }
        }
    }
}